Imports BluePrism.Common.Security

Public interface ILoginControl
    Property LoginEnabled As Boolean
    Sub SetUsernameAndPassword(previousUsername As String, previousPassword As SafeString)
    Sub FocusUsernameOrPassword()
end interface
