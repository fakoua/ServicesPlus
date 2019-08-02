Public Class IdentityModel
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
            Me._Domain = userName.Substring(0, pos)
            Me._UserName = userName.Substring(pos + 1)
        Else
            Me._UserName = userName
        End If
        Me._Password = password
    End Sub

    ''' <summary>
    ''' ctor with username, password and domain
    ''' </summary>
    ''' <param name="username">domain username (domain\user is not accepted)</param>
    ''' <param name="password">user password</param>
    ''' <param name="domain">Domain name</param>
    ''' <remarks></remarks>
    Public Sub New(userName As String, password As String, domain As String)
        Me._UserName = userName
        Me._Password = password
        Me._Domain = domain
    End Sub

    ''' <summary>
    ''' For Xml Serialization
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub
End Class
