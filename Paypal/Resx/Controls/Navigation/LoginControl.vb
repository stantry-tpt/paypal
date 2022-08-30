Imports System.Globalization
Imports AutomateUI.Controls.Navigation
Imports BluePrism.AutomateAppCore
Imports BluePrism.Common.Security
Imports BluePrism.Config
Imports BluePrism.Core.Help

Public Class LoginControl
    Implements IHelp, IChild
    Implements ILoginControl

    Private WithEvents mParent As frmApplication
    Private mLoaded As Boolean

    Public Event ParentConnectionChanged(sender As Object, args As EventArgs)
    Public Event Deactivate(sender As Object, e As EventArgs)

    Public Property ParentAppForm As frmApplication Implements IChild.ParentAppForm
        Get
            Return mParent
        End Get
        Set
            mParent = value
            PopulateConnections()
            If mParent IsNot Nothing Then
                AddHandler mParent.ConnectionChanged, New frmApplication.ConnectionChangedEventHandler(AddressOf ParentHandleConnectionChanged)
            End If
        End Set
    End Property

    Friend Property LoginEnabled As Boolean Implements ILoginControl.LoginEnabled
        Get
            Return ctlAuthenticationMethods.Enabled AndAlso
                   Not llRefresh.Visible
        End Get
        Set
            ctlAuthenticationMethods.Enabled = Value
            llRefresh.Visible = Not Value
        End Set
    End Property

    Friend Shared Property PseudoLocalization As Boolean

    Public Sub New()
        InitializeComponent()

        If Application.RenderWithVisualStyles Then
            pnlLogin.BackColor = Color.White
            BackColor = Color.FromKnownColor(KnownColor.Control)
        Else
            BackColor = Color.White
            pnlLogin.BackColor = Color.FromKnownColor(KnownColor.Control)
        End If

        AddHandler Options.Instance.Load, AddressOf HandleOptionsLoaded
    End Sub

    Public Function GetHelpFile() As String Implements IHelp.GetHelpFile
        Return "frmLogin.htm"
    End Function

    Public Sub SetUsernameAndPassword(previousUsername As String, previousPassword As SafeString) _
        Implements ILoginControl.SetUsernameAndPassword
        ctlAuthenticationMethods.Credentials = (previousUsername, previousPassword)
    End Sub

    Public Sub FocusUsernameOrPassword() _
        Implements ILoginControl.FocusUsernameOrPassword
        ctlAuthenticationMethods.FocusUsernameOrPassword()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        pbLogo.Image = Branding.GetLargeLogo()
        If pbLogo.Image IsNot Nothing Then
            pbLogo.Size = pbLogo.Image.Size
            pbLogo.Location = New Point(Width - pbLogo.Image.Width - Branding.LargeLogoMarginRight,
                                        Height - pbLogo.Image.Height - Branding.LargeLogoMarginBottom)
        End If
        If Options.Instance.Unbranded Then
            lblSignIn.Text = My.Resources.LoginControl_SignIn
        End If
        ctlAuthenticationMethods.Visible = False
        mLoaded = True
    End Sub

    Protected Overrides Sub Dispose(explicit As Boolean)
        Try
            If explicit Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If

                RemoveHandler Options.Instance.Load, AddressOf HandleOptionsLoaded

                If mParent IsNot Nothing Then
                    RemoveHandler mParent.ConnectionChanged, AddressOf ParentHandleConnectionChanged
                End If
            End If
        Finally
            MyBase.Dispose(explicit)
        End Try
    End Sub

    Private Sub ParentHandleConnectionChanged(sender As Object, e As DatabaseChangeEventArgs)
        Try
            ctlAuthenticationMethods.ParentAppForm = Me
            ctlAuthenticationMethods.Visible = Not ParentAppForm.IsInitialisingConnection
            LoginEnabled = e.Success

            With mParent.GetTaskPanel()
                .BeginUpdate()
                .Clear()
                .EndUpdate()
            End With

            If Not e.Success Then
                Dim msg As String = My.Resources.LoginControl_Error & e.ShortMessage & vbCrLf & vbCrLf & e.LongMessage

                If Not mLoaded Then
                    BeginInvoke(New Action(Of String, Exception)(AddressOf UserMessage.Show), msg, e.Exception)
                Else
                    UserMessage.Show(msg, e.Exception)
                End If

                Return
            End If

            RaiseEvent ParentConnectionChanged(mParent, EventArgs.Empty)
        Catch
        End Try
    End Sub

    Private Sub PopulateConnections()
        If mParent Is Nothing Then
            Return
        End If

        With cmbConnection
            .BeginUpdate()
            .Items.Clear()
            Dim configOptions = Options.Instance
            Dim currentConnection As IDatabaseConnectionSetting = configOptions.DbConnectionSetting
            For Each setting As clsDBConnectionSetting In configOptions.Connections
                .Items.Add(setting.ConnectionName)
            Next
            .Text = currentConnection.ConnectionName
            .EndUpdate()
        End With
    End Sub

    Private Sub HandleConnectionChanged(sender As Object, e As EventArgs) Handles cmbConnection.SelectedValueChanged
        If Not IsHandleCreated Then
            Return
        End If

        Dim currentConnectionName As String = Options.Instance.CurrentConnectionName

        If currentConnectionName = cmbConnection.Text Then
            Return
        End If

        HandleConnectionClicked(sender, e)
    End Sub

    Private Sub HandleConnectionClicked(sender As Object, e As EventArgs) Handles llRefresh.LinkClicked
        ctlAuthenticationMethods.Visible = False
        mParent.WaitForInitConnection(cmbConnection.Text)
    End Sub

    Private Sub HandleOptionsLoaded()
        If InvokeRequired Then
            BeginInvoke(New MethodInvoker(AddressOf PopulateConnections))
        Else
            PopulateConnections()
        End If
    End Sub

    Private Sub HandleConfigureConnections(sender As Object, e As LinkLabelLinkClickedEventArgs) _
        Handles llConfigure.LinkClicked
        If mParent IsNot Nothing Then
            mParent.ShowDBConfig()
        End If
    End Sub

    Private Sub HandleLocaleLinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llLocale.LinkClicked
        Using localeConfigForm As New SelectLanguageForm(PseudoLocalization)
            localeConfigForm.ShowInTaskbar = False
            localeConfigForm.StartPosition = FormStartPosition.CenterParent
            If localeConfigForm.ShowDialog() = DialogResult.OK AndAlso localeConfigForm.NewLocale IsNot Nothing AndAlso
                localeConfigForm.NewLocale <> Options.Instance.CurrentLocale Then
                ChangeLocale(localeConfigForm.NewLocale)
            End If
        End Using
    End Sub

    Private Sub ChangeLocale(locale As String)
        If ParentAppForm IsNot Nothing AndAlso locale IsNot Nothing Then
            ParentAppForm.PreviousUsername = ctlAuthenticationMethods.Credentials.username
            ParentAppForm.PreviousPassword = ctlAuthenticationMethods.Credentials.securePassword
            ParentAppForm.SelectedLocale = locale
        End If
    End Sub

    Private Sub HandleLoginRequested(sender As Object, e As NativeLoginRequestedEventArgs) _
        Handles ctlAuthenticationMethods.NativeLoginRequested
        mParent.AttemptBluePrismLogin(e.UsernameControl, e.SecurePasswordControl, CultureInfo.CurrentUICulture.Name)
    End Sub

    Private Sub HandleLoginWithMethodRequested(sender As Object, e As LoginWithMethodRequestedEventArgs) _
        Handles ctlAuthenticationMethods.LoginWithMethodRequested
        mParent.AttemptLogin(CultureInfo.CurrentUICulture.Name, e.LoginMethod)
    End Sub

    Private Sub HandleParentDeactivate(sender As Object, e As EventArgs) Handles mParent.Deactivate
        RaiseEvent Deactivate(sender, e)
    End Sub

    Private Sub HandleConnectingToExternalProviderStarted(sender As Object, e As EventArgs) _
        Handles ctlAuthenticationMethods.ConnectingToExternalProviderStarted
        HandleConnectingToExternalProviderStateChange(True)
    End Sub

    Private Sub HandleConnectingToExternalProviderFinished(sender As Object, e As EventArgs) _
        Handles ctlAuthenticationMethods.ConnectingToExternalProviderFinished
        HandleConnectingToExternalProviderStateChange(False)
    End Sub

    Private Sub HandleConnectingToExternalProviderStateChange(state As Boolean)
        plConnecting.Enabled = state
        plConnecting.Visible = state

        If state Then
            plConnecting.BringToFront()

            Dim controlIndex = plConnecting.Controls.IndexOfKey("lblConnectingMessage")
            If controlIndex >= 0 Then
                Dim connectLabel = CType(plConnecting.Controls(controlIndex), Label)
                connectLabel.Text = My.Resources.LoginControl_ConnectingToTheAuthenticationServer
            End If
        Else
            plConnecting.SendToBack()
        End If

        cmbConnection.Enabled = Not state
        llRefresh.Enabled = Not state
        llConfigure.Enabled = Not state
        llLocale.Enabled = Not state
    End Sub

    Private Sub LoginControl_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim parentLocation = pnlHeader.Parent.Location
        plConnecting.Location = New Point(parentLocation.X + 114, parentLocation.Y + 100)
    End Sub

End Class
