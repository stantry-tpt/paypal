Imports AutomateUI.Controls.Navigation
Imports BluePrism.ActiveDirectory.AutoFac
Imports BluePrism.ActiveDirectory.Domains
Imports BluePrism.AutomateAppCore
Imports BluePrism.AutomateAppCore.Auth
Imports BluePrism.BPCoreLib
Imports BluePrism.BPCoreLib.DependencyInjection
Imports BluePrism.Common.Security
Imports BluePrism.ExternalLoginBrowser

Public Class AuthenticationMethodsControl
    Private WithEvents mParent As LoginControl
    Private ReadOnly mUsers As New SortedDictionary(Of String, User)
    Private mLogonOptions As LogonOptions

    Public Event NativeLoginRequested(sender As Object, args As NativeLoginRequestedEventArgs)
    Public Event LoginWithMethodRequested(sender As Object, args As LoginWithMethodRequestedEventArgs)
    Public Event ConnectingToExternalProviderStarted(sender As Object, args As EventArgs)
    Public Event ConnectingToExternalProviderFinished(sender As Object, args As EventArgs)

    Public Property ParentAppForm As LoginControl
        Get
            Return mParent
        End Get
        Set
            mParent = Value
        End Set
    End Property

    Friend Property Credentials As (username As String, securePassword As SafeString)
        Get
            Return (txtUsername.Text, txtPassword.SecurePassword)
        End Get
        Set
            txtUsername.Text = Value.username
            txtPassword.SecurePassword = Value.securePassword
        End Set
    End Property

    Public Sub New()
        InitializeComponent()

        txtPassword.PasswordChar = BPUtil.PasswordChar
    End Sub

    Private Sub SetAuthenticationControlState()

        Dim allUsers As ICollection(Of User) = Nothing
        mLogonOptions = gSv.GetLogonOptions(allUsers)

        gbNativeLogin.Visible = Not mLogonOptions.AuthenticationServerAuthenticationEnabled AndAlso mLogonOptions.NativeAuthenticationEnabled
        If Not mLogonOptions.AuthenticationServerAuthenticationEnabled AndAlso mLogonOptions.NativeAuthenticationEnabled Then
            FocusUsernameOrPassword()

            txtPassword.AllowPasting = gSv.GetAllowPasswordPasting()

            mUsers.Clear()
            For Each user In allUsers
                If Not user.IsHidden AndAlso Not user.Deleted Then
                    mUsers(user.Name) = user
                End If
            Next

            Select Case mLogonOptions.AutoPopulate
                Case AutoPopulateMode.None : txtUsername.Text = String.Empty
                Case AutoPopulateMode.SystemUser : txtUsername.Text = Environment.UserName
                Case AutoPopulateMode.LastUser : txtUsername.Text = Options.Instance.LastNativeUser
            End Select
        End If

        gbActiveDirectoryLogin.Text = If(Not mLogonOptions.NativeAuthenticationEnabled AndAlso Not mLogonOptions.AuthenticationServerAuthenticationEnabled,
            btnSignInUsingActiveDirectory.Text, My.Resources._Or)

        gbActiveDirectoryLogin.Visible = Not mLogonOptions.AuthenticationServerAuthenticationEnabled AndAlso mLogonOptions.ActiveDirectoryAuthenticationEnabled AndAlso ClientIsConnectedToDomain()

        pnlAuthenticationServerLogin.Visible = mLogonOptions.AuthenticationServerAuthenticationEnabled
        fpAuthenticationControls.Invalidate()

    End Sub

    Private Shared Function ClientIsConnectedToDomain() As Boolean
        Try
            Return DependencyResolver.FromScope(
                Function(domainTools As IDomainTools)
                    Return domainTools.IsHostConnectedToDomain()
                End Function)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub HandleParentConnectionChanged() Handles mParent.ParentConnectionChanged
        SetAuthenticationControlState()
        Me.Visible = True
    End Sub

    Friend Sub FocusUsernameOrPassword()
        Try
            Dim focusControl As Control

            If String.IsNullOrEmpty(txtUsername.Text) Then
                focusControl = txtUsername
            Else
                focusControl = txtPassword
            End If

            clsUserInterfaceUtils.SetFocusDelayed(focusControl)
        Catch
        End Try
    End Sub

    Private Sub Login()
        mBalloonTip.Hide(txtPassword)
        RaiseEvent NativeLoginRequested(txtPassword, New NativeLoginRequestedEventArgs(txtUsername, txtPassword))
    End Sub

    Private Sub HandlePasswordKeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab Then
            Login()
        End If
    End Sub

    Private Sub HandleUsernameKeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub HandlePasswordEnter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        Dim user As User = Nothing

        If mUsers.Count = 0 OrElse String.IsNullOrEmpty(txtUsername.Text) OrElse Not mUsers.TryGetValue(txtUsername.Text, user) Then
            Return
        End If

        Dim warningMessage As String = GetExpiryMessage(user)
        If Not String.IsNullOrEmpty(warningMessage) Then
            mBalloonTip.ToolTipTitle = GetExpiryPrompt(user)
            mBalloonTip.Active = False
            mBalloonTip.SetToolTip(txtPassword, warningMessage)
            mBalloonTip.Active = True
            mBalloonTip.Show(warningMessage, txtPassword, CType(txtPassword.Size, Point))
        End If
    End Sub

    Private Shared Function GetExpiryMessage(u As IUser) As String
        Dim warningMessageStringFormat As String = String.Empty

        If u.AccountExpiresSoon Then
            If u.Expiry <= Today Then
                warningMessageStringFormat =
                    My.Resources.AuthenticationMethodsControl_WarningYourAccountExpiredOn0D22PleaseAskTheSystemManagerToReactivateThisAccount
            Else
                warningMessageStringFormat =
                    My.Resources.AuthenticationMethodsControl_ReminderYourAccountWillExpireOn0D22PleaseContactYourBluePrismAdministratorToExt
            End If
        End If

        If u.PasswordExpiresSoon Then
            If warningMessageStringFormat <> String.Empty Then
                warningMessageStringFormat &= "{2}{2}"
            End If

            If u.PasswordExpiry < Today Then
                warningMessageStringFormat &=
                    My.Resources.AuthenticationMethodsControl_WarningYourPasswordExpiredOn1D2AndWillNeedToBeChangedWhenYouNextLogIn
            ElseIf u.PasswordExpiry > Today Then
                warningMessageStringFormat &=
                    My.Resources.AuthenticationMethodsControl_WarningYourPasswordWillExpireOn1D2AndWillNeedToBeChangedWhenYouNextLogInAfterTh
            Else
                warningMessageStringFormat &=
                    My.Resources.AuthenticationMethodsControl_ReminderYourPasswordExpiresToday2AndWillNeedToBeChangedWhenYouNextLogIn
            End If
        End If

        If warningMessageStringFormat = String.Empty Then
            Return String.Empty
        End If

        Return String.Format(warningMessageStringFormat, u.Expiry, u.PasswordExpiry, vbCrLf)
    End Function

    Private Shared Function GetExpiryPrompt(u As IUser) As String
        Dim passwordExpiresSoon As Boolean = u.PasswordExpiresSoon
        Dim accountExpiresSoon As Boolean = u.AccountExpiresSoon

        If passwordExpiresSoon AndAlso accountExpiresSoon Then
            Return My.Resources.AuthenticationMethodsControl_AccountAndPasswordExpiryReminder
        End If

        If accountExpiresSoon Then
            Return My.Resources.AuthenticationMethodsControl_AccountExpiryReminder
        End If

        If passwordExpiresSoon Then
            Return My.Resources.AuthenticationMethodsControl_PasswordExpiryReminder
        End If

        Return String.Empty
    End Function

    Private Sub HandleHideWarning(sender As Object, e As EventArgs) _
        Handles MyBase.Resize, mParent.Move, txtPassword.Leave, mParent.Deactivate

        mBalloonTip.Hide(txtPassword)
    End Sub

    Private Sub HandleDirectLoginClick(sender As Object, e As EventArgs) Handles btnNativeLogin.Click
        If String.IsNullOrEmpty(txtUsername.Text) Then
            UserMessage.Show(My.Resources.AuthenticationMethodsControl_YouMustEnterAUsername)
            txtUsername.Focus()
            Exit Sub
        End If

        Login()
    End Sub

    Private Sub HandleSignInUsingActiveDirectoryClick(sender As Object, e As EventArgs) Handles btnSignInUsingActiveDirectory.Click

        Dim loginMethod As Func(Of String, String, LoginResult) =
                Function(resource, locale) User.LoginWithActiveDirectory(resource, locale)

        RaiseEvent LoginWithMethodRequested(sender, New LoginWithMethodRequestedEventArgs(loginMethod))
    End Sub

    Private Sub HandleAuthenticationServerSigninClick(sender As Object, e As EventArgs) Handles btnAuthenticationServerSignin.Click
        If mLogonOptions.AuthenticationServerAuthenticationEnabled Then
            SignInUsingExternalLoginBrowser(mLogonOptions.AuthenticationServerUrl)
        End If
    End Sub

    Private Sub DisplayConnectingToExternalProvider(state As Boolean)
        If state Then
            RaiseEvent ConnectingToExternalProviderStarted(btnAuthenticationServerSignin, EventArgs.Empty)
        Else
            RaiseEvent ConnectingToExternalProviderFinished(btnAuthenticationServerSignin, EventArgs.Empty)
        End If

        txtUsername.Enabled = Not state
        txtPassword.Enabled = Not state
        btnNativeLogin.Enabled = Not state
        btnSignInUsingActiveDirectory.Enabled = Not state
        btnAuthenticationServerSignin.Enabled = Not state
    End Sub

    Private Async Sub SignInUsingExternalLoginBrowser(authenticationServerUrl As String)
        Try
            DisplayConnectingToExternalProvider(True)

            Dim browser = New BrowserStartup(authenticationServerUrl)
            Dim externalAuthenticationResult = Await browser.LoginWithDisplayVisible()

            If Not externalAuthenticationResult.IsError Then
                Dim loginMethod As Func(Of String, String, LoginResult) =
                        Function(resource, locale)
                            Return User.LoginWithAccessToken(resource,
                                                             externalAuthenticationResult.AccessToken,
                                                             locale)
                        End Function

                RaiseEvent LoginWithMethodRequested(btnAuthenticationServerSignin, New LoginWithMethodRequestedEventArgs(loginMethod))
            Else
                Select Case externalAuthenticationResult.[Error]
                    Case IdentityModel.OidcClient.Browser.BrowserResultType.UnknownError.ToString()
                        UserMessage.Err(My.Resources.AuthenticationMethodsControl_UnexpectedBrowserError)
                    Case IdentityModel.OidcClient.Browser.BrowserResultType.HttpError.ToString()
                        UserMessage.Err(My.Resources.AuthenticationMethodsControl_LoginFailed)
                    Case IdentityModel.OidcClient.Browser.BrowserResultType.Timeout.ToString()
                        UserMessage.Err(My.Resources.AuthenticationMethodsControl_ExternalProviderTimeout)
                End Select
            End If
        Catch ex As Exception
            UserMessage.Err(My.Resources.AuthenticationMethodsControl_UnexpectedBrowserError)
        Finally
            DisplayConnectingToExternalProvider(False)
        End Try
    End Sub
End Class
