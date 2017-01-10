Imports System.Xml.Serialization
Imports System.IO

Public Class AppSettings

    Property RecentServers As List(Of BLL.OM.RecentServerEntity)
    Property OpenServers As List(Of BLL.OM.ServerEntity)

    Sub Save()
        Try
            Using objStreamWriter As New StreamWriter(Glob.GetSettingPath)
                Dim x As New XmlSerializer(Me.GetType)
                x.Serialize(objStreamWriter, Me)
            End Using
        Catch ex As Exception
            Modules.PushLog(ex)
        End Try
    End Sub

    Friend Sub AddRecentServer(server As BLL.OM.ServerEntity)
        If RecentServers Is Nothing Then
            RecentServers = New List(Of BLL.OM.RecentServerEntity)
        End If
        Dim recentServerCount = RecentServers.Where(Function(p) p.Server.ComputerName.ToUpperInvariant = server.ComputerName.ToUpperInvariant).FirstOrDefault
        If recentServerCount Is Nothing Then
            Dim recentServer = New BLL.OM.RecentServerEntity
            recentServer.OpenCount = 1
            recentServer.Server = server
            RecentServers.Add(recentServer)
        Else
            Dim recentServer = RecentServers.Where(Function(p) p.Server.ComputerName.ToUpperInvariant = server.ComputerName.ToUpperInvariant).First
            recentServer.OpenCount += 1
            recentServer.Server = server
        End If
    End Sub
End Class
