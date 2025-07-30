Namespace BLL.OM
    Public Class Identity

        Property UserName As String
        Property Password As String
        Property Domain As String

        ''' <summary>
        ''' ctor with Username and password
        ''' </summary>
        ''' <param name="username">domain username, user or domain\user</param>
        ''' <param name="password">user password</param>
        ''' <remarks>If domain was not provided, the login will take current domain or workgroup</remarks>
        Public Sub New(userName As String, password As String)
            If Not String.IsNullOrEmpty(userName) AndAlso userName.Contains("\") Then
                Dim pos = userName.IndexOf("\")
                Me.Domain = userName.Substring(0, pos)
                Me.UserName = userName.Substring(pos + 1)
            Else
                Me.UserName = userName
            End If
            Me.Password = password
        End Sub

        ''' <summary>
        ''' ctor with username, password and domain
        ''' </summary>
        ''' <param name="username">domain username (domain\user is not accepted)</param>
        ''' <param name="password">user password</param>
        ''' <param name="domain">Domain name</param>
        ''' <remarks></remarks>
        Public Sub New(userName As String, password As String, domain As String)
            Me.UserName = userName
            Me.Password = password
            Me.Domain = domain
        End Sub

        ''' <summary>
        ''' For Xml Serialization
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()

        End Sub
    End Class
End Namespace