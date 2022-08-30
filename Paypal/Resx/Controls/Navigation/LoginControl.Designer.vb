<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginControl
    Inherits System.Windows.Forms.UserControl

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim lblConnection As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginControl))
        Dim lblConnectingMessage As System.Windows.Forms.Label
        Me.tlLogin = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlLogin = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.llLocale = New System.Windows.Forms.LinkLabel()
        Me.llRefresh = New System.Windows.Forms.LinkLabel()
        Me.llConfigure = New System.Windows.Forms.LinkLabel()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.cmbConnection = New System.Windows.Forms.ComboBox()
        Me.ctlAuthenticationMethods = New AutomateUI.AuthenticationMethodsControl()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.plConnecting = New System.Windows.Forms.Panel()
        Me.imgConnecting = New System.Windows.Forms.PictureBox()
        lblConnection = New System.Windows.Forms.Label()
        lblConnectingMessage = New System.Windows.Forms.Label()
        Me.tlLogin.SuspendLayout()
        Me.pnlLogin.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plConnecting.SuspendLayout()
        CType(Me.imgConnecting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConnection
        '
        resources.ApplyResources(lblConnection, "lblConnection")
        lblConnection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(79, Byte), Integer))
        lblConnection.Name = "lblConnection"
        '
        'lblConnectingMessage
        '
        resources.ApplyResources(lblConnectingMessage, "lblConnectingMessage")
        lblConnectingMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(79, Byte), Integer))
        lblConnectingMessage.Name = "lblConnectingMessage"
        '
        'tlLogin
        '
        resources.ApplyResources(Me.tlLogin, "tlLogin")
        Me.tlLogin.Controls.Add(Me.pnlLogin, 1, 1)
        Me.tlLogin.Name = "tlLogin"
        '
        'pnlLogin
        '
        resources.ApplyResources(Me.pnlLogin, "pnlLogin")
        Me.pnlLogin.BackColor = System.Drawing.Color.White
        Me.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLogin.Controls.Add(Me.pnlHeader)
        Me.pnlLogin.Controls.Add(Me.ctlAuthenticationMethods)
        Me.pnlLogin.Name = "pnlLogin"
        '
        'pnlHeader
        '
        resources.ApplyResources(Me.pnlHeader, "pnlHeader")
        Me.pnlHeader.BackColor = System.Drawing.Color.Transparent
        Me.pnlHeader.Controls.Add(Me.llLocale)
        Me.pnlHeader.Controls.Add(Me.llRefresh)
        Me.pnlHeader.Controls.Add(Me.llConfigure)
        Me.pnlHeader.Controls.Add(Me.lblSignIn)
        Me.pnlHeader.Controls.Add(Me.cmbConnection)
        Me.pnlHeader.Controls.Add(lblConnection)
        Me.pnlHeader.Name = "pnlHeader"
        '
        'llLocale
        '
        resources.ApplyResources(Me.llLocale, "llLocale")
        Me.llLocale.BackColor = System.Drawing.Color.White
        Me.llLocale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.llLocale.LinkColor = System.Drawing.Color.SteelBlue
        Me.llLocale.Name = "llLocale"
        Me.llLocale.TabStop = True
        Me.llLocale.UseCompatibleTextRendering = True
        '
        'llRefresh
        '
        resources.ApplyResources(Me.llRefresh, "llRefresh")
        Me.llRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.llRefresh.LinkColor = System.Drawing.Color.SteelBlue
        Me.llRefresh.Name = "llRefresh"
        Me.llRefresh.TabStop = True
        '
        'llConfigure
        '
        resources.ApplyResources(Me.llConfigure, "llConfigure")
        Me.llConfigure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.llConfigure.LinkColor = System.Drawing.Color.SteelBlue
        Me.llConfigure.Name = "llConfigure"
        Me.llConfigure.TabStop = True
        '
        'lblSignIn
        '
        resources.ApplyResources(Me.lblSignIn, "lblSignIn")
        Me.lblSignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblSignIn.Name = "lblSignIn"
        '
        'cmbConnection
        '
        resources.ApplyResources(Me.cmbConnection, "cmbConnection")
        Me.cmbConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConnection.FormattingEnabled = True
        Me.cmbConnection.Name = "cmbConnection"
        '
        'ctlAuthenticationMethods
        '
        resources.ApplyResources(Me.ctlAuthenticationMethods, "ctlAuthenticationMethods")
        Me.ctlAuthenticationMethods.Name = "ctlAuthenticationMethods"
        Me.ctlAuthenticationMethods.ParentAppForm = Nothing
        '
        'pbLogo
        '
        resources.ApplyResources(Me.pbLogo, "pbLogo")
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.TabStop = False
        '
        'plConnecting
        '
        Me.plConnecting.BackColor = System.Drawing.Color.Transparent
        Me.plConnecting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plConnecting.Controls.Add(lblConnectingMessage)
        Me.plConnecting.Controls.Add(Me.imgConnecting)
        resources.ApplyResources(Me.plConnecting, "plConnecting")
        Me.plConnecting.Name = "plConnecting"
        '
        'imgConnecting
        '
        resources.ApplyResources(Me.imgConnecting, "imgConnecting")
        Me.imgConnecting.Image = Global.AutomateUI.My.Resources.Resources.preloader
        Me.imgConnecting.Name = "imgConnecting"
        Me.imgConnecting.TabStop = False
        '
        'LoginControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.tlLogin)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.plConnecting)
        Me.Name = "LoginControl"
        resources.ApplyResources(Me, "$this")
        Me.tlLogin.ResumeLayout(false)
        Me.tlLogin.PerformLayout
        Me.pnlLogin.ResumeLayout(false)
        Me.pnlLogin.PerformLayout
        Me.pnlHeader.ResumeLayout(false)
        Me.pnlHeader.PerformLayout
        CType(Me.pbLogo,System.ComponentModel.ISupportInitialize).EndInit
        Me.plConnecting.ResumeLayout(false)
        Me.plConnecting.PerformLayout
        CType(Me.imgConnecting,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents tlLogin As TableLayoutPanel
    Friend WithEvents pnlLogin As FlowLayoutPanel
    Friend WithEvents pnlHeader As Panel
    Private WithEvents llLocale As LinkLabel
    Private WithEvents llRefresh As LinkLabel
    Private WithEvents llConfigure As LinkLabel
    Friend WithEvents lblSignIn As Label
    Friend WithEvents cmbConnection As ComboBox
    Friend WithEvents ctlAuthenticationMethods As AuthenticationMethodsControl
    Private WithEvents pbLogo As PictureBox
    Friend WithEvents plConnecting As Panel
    Friend WithEvents imgConnecting As PictureBox
End Class
