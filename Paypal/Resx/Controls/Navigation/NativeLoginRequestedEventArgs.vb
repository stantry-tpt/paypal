Imports AutomateControls.Textboxes

Namespace Controls.Navigation

    Public Class NativeLoginRequestedEventArgs
        Inherits EventArgs

        Public ReadOnly Property UsernameControl As StyledTextBox

        Public ReadOnly Property SecurePasswordControl As ctlAutomateInputSecurePassword

        Public Sub New(usernameControl As StyledTextBox, securePasswordControl As ctlAutomateInputSecurePassword)
            Me.UsernameControl = usernameControl
            Me.SecurePasswordControl = securePasswordControl
        End Sub
    End Class
End NameSpace
