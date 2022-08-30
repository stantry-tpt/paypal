Imports BluePrism.AutomateAppCore.Auth

Namespace Controls.Navigation

    Public Class LoginWithMethodRequestedEventArgs
        Inherits EventArgs

        Public ReadOnly Property LoginMethod As Func(Of String, String, LoginResult)

        Public Sub New(loginMethod As Func(Of String, String, LoginResult))
            Me.LoginMethod = loginMethod
        End Sub
    End Class
End NameSpace
