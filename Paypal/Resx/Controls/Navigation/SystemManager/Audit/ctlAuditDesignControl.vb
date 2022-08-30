Imports BluePrism.AutomateAppCore.Auth

Public Class ctlAuditDesignControl
    Implements IChild
    Implements IPermission

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mDesignControlPanel.Populate()
    End Sub

    Friend Property ParentAppForm As frmApplication Implements IChild.ParentAppForm

    Public ReadOnly Property RequiredPermissions As ICollection(Of Permission) Implements IPermission.RequiredPermissions
        Get
            Return Permission.ByName("Audit - View Design Controls", "Audit - Configure Design Controls")
        End Get
    End Property
End Class
