<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuthenticationMethodsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim llPassword As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AuthenticationMethodsControl))
        Dim llUsername As System.Windows.Forms.Label
        Me.fpAuthenticationControls = New System.Windows.Forms.FlowLayoutPanel()
        Me.gbNativeLogin = New System.Windows.Forms.GroupBox()
        Me.txtUsername = New AutomateControls.Textboxes.StyledTextBox()
        Me.btnNativeLogin = New AutomateControls.Buttons.StandardStyledButton(Me.components)
        Me.gbActiveDirectoryLogin = New System.Windows.Forms.GroupBox()
        Me.btnSignInUsingActiveDirectory = New AutomateControls.Buttons.StandardStyledButton(Me.components)
        Me.pnlAuthenticationServerLogin = New System.Windows.Forms.Panel()
        Me.btnAuthenticationServerSignin = New AutomateControls.Buttons.StandardStyledButton(Me.components)
        Me.mBalloonTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtPassword = New AutomateUI.ctlAutomateInputSecurePassword()
        llPassword = New System.Windows.Forms.Label()
        llUsername = New System.Windows.Forms.Label()
        Me.fpAuthenticationControls.SuspendLayout
        Me.gbNativeLogin.SuspendLayout
        Me.gbActiveDirectoryLogin.SuspendLayout
        Me.pnlAuthenticationServerLogin.SuspendLayout
        Me.SuspendLayout
        '
        'llPassword
        '
        resources.ApplyResources(llPassword, "llPassword")
        llPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(79,Byte),Integer))
        llPassword.Name = "llPassword"
        '
        'llUsername
        '
        resources.ApplyResources(llUsername, "llUsername")
        llUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(79,Byte),Integer))
        llUsername.Name = "llUsername"
        '
        'fpAuthenticationControls
        '
        resources.ApplyResources(Me.fpAuthenticationControls, "fpAuthenticationControls")
        Me.fpAuthenticationControls.Controls.Add(Me.gbNativeLogin)
        Me.fpAuthenticationControls.Controls.Add(Me.gbActiveDirectoryLogin)
        Me.fpAuthenticationControls.Controls.Add(Me.pnlAuthenticationServerLogin)
        Me.fpAuthenticationControls.Name = "fpAuthenticationControls"
        '
        'gbNativeLogin
        '
        Me.gbNativeLogin.Controls.Add(Me.txtUsername)
        Me.gbNativeLogin.Controls.Add(llPassword)
        Me.gbNativeLogin.Controls.Add(llUsername)
        Me.gbNativeLogin.Controls.Add(Me.txtPassword)
        Me.gbNativeLogin.Controls.Add(Me.btnNativeLogin)
        resources.ApplyResources(Me.gbNativeLogin, "gbNativeLogin")
        Me.gbNativeLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(79,Byte),Integer))
        Me.gbNativeLogin.Name = "gbNativeLogin"
        Me.gbNativeLogin.TabStop = false
        '
        'txtUsername
        '
        resources.ApplyResources(Me.txtUsername, "txtUsername")
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11,Byte),Integer), CType(CType(117,Byte),Integer), CType(CType(183,Byte),Integer))
        Me.txtUsername.Name = "txtUsername"
        '
        'btnNativeLogin
        '
        resources.ApplyResources(Me.btnNativeLogin, "btnNativeLogin")
        Me.btnNativeLogin.BackColor = System.Drawing.SystemColors.Window
        Me.btnNativeLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11,Byte),Integer), CType(CType(117,Byte),Integer), CType(CType(183,Byte),Integer))
        Me.btnNativeLogin.Name = "btnNativeLogin"
        Me.btnNativeLogin.UseVisualStyleBackColor = false
        '
        'gbActiveDirectoryLogin
        '
        Me.gbActiveDirectoryLogin.Controls.Add(Me.btnSignInUsingActiveDirectory)
        resources.ApplyResources(Me.gbActiveDirectoryLogin, "gbActiveDirectoryLogin")
        Me.gbActiveDirectoryLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(79,Byte),Integer))
        Me.gbActiveDirectoryLogin.Name = "gbActiveDirectoryLogin"
        Me.gbActiveDirectoryLogin.TabStop = false
        '
        'btnSignInUsingActiveDirectory
        '
        resources.ApplyResources(Me.btnSignInUsingActiveDirectory, "btnSignInUsingActiveDirectory")
        Me.btnSignInUsingActiveDirectory.BackColor = System.Drawing.SystemColors.Window
        Me.btnSignInUsingActiveDirectory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11,Byte),Integer), CType(CType(117,Byte),Integer), CType(CType(183,Byte),Integer))
        Me.btnSignInUsingActiveDirectory.Name = "btnSignInUsingActiveDirectory"
        Me.btnSignInUsingActiveDirectory.UseVisualStyleBackColor = false
        '
        'pnlAuthenticationServerLogin
        '
        Me.pnlAuthenticationServerLogin.Controls.Add(Me.btnAuthenticationServerSignin)
        resources.ApplyResources(Me.pnlAuthenticationServerLogin, "pnlAuthenticationServerLogin")
        Me.pnlAuthenticationServerLogin.Name = "pnlAuthenticationServerLogin"
        '
        'btnAuthenticationServerSignin
        '
        resources.ApplyResources(Me.btnAuthenticationServerSignin, "btnAuthenticationServerSignin")
        Me.btnAuthenticationServerSignin.BackColor = System.Drawing.SystemColors.Window
        Me.btnAuthenticationServerSignin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11,Byte),Integer), CType(CType(117,Byte),Integer), CType(CType(183,Byte),Integer))
        Me.btnAuthenticationServerSignin.Name = "btnAuthenticationServerSignin"
        Me.btnAuthenticationServerSignin.UseVisualStyleBackColor = false
        '
        'mBalloonTip
        '
        Me.mBalloonTip.AutoPopDelay = 0
        Me.mBalloonTip.InitialDelay = 30000
        Me.mBalloonTip.IsBalloon = true
        Me.mBalloonTip.ReshowDelay = 0
        Me.mBalloonTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'txtPassword
        '
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11,Byte),Integer), CType(CType(117,Byte),Integer), CType(CType(183,Byte),Integer))
        Me.txtPassword.HandleSetText = true
        Me.txtPassword.Name = "txtPassword"
        '
        'AuthenticationMethodsControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.fpAuthenticationControls)
        Me.Name = "AuthenticationMethodsControl"
        Me.fpAuthenticationControls.ResumeLayout(false)
        Me.gbNativeLogin.ResumeLayout(false)
        Me.gbNativeLogin.PerformLayout
        Me.gbActiveDirectoryLogin.ResumeLayout(false)
        Me.gbActiveDirectoryLogin.PerformLayout
        Me.pnlAuthenticationServerLogin.ResumeLayout(false)
        Me.pnlAuthenticationServerLogin.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents fpAuthenticationControls As FlowLayoutPanel
    Friend WithEvents gbNativeLogin As GroupBox
    Private WithEvents txtUsername As AutomateControls.Textboxes.StyledTextBox
    Friend WithEvents txtPassword As ctlAutomateInputSecurePassword
    Friend WithEvents btnNativeLogin As AutomateControls.Buttons.StandardStyledButton
    Friend WithEvents gbActiveDirectoryLogin As GroupBox
    Friend WithEvents btnSignInUsingActiveDirectory As AutomateControls.Buttons.StandardStyledButton
    Private WithEvents mBalloonTip As ToolTip
    Friend WithEvents pnlAuthenticationServerLogin As Panel
    Friend WithEvents btnAuthenticationServerSignin As AutomateControls.Buttons.StandardStyledButton
End Class
