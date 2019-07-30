Imports System.Globalization
Imports ServicesPlus.Controls
Imports ServicesPlus.Modules
Imports ServicesPlus.Utils

Namespace Forms

    Friend Class FrmMain

        Private Async Sub TabHeader1_OnAdding(sender As Object, e As EventArgs) Handles TabHeader1.OnAdding
            Trace()
            Try
                Dim objAddServer As New FrmAddServer
                Dim result = objAddServer.Open

                If result.IsResult Then
                    Dim server = result.ServerName
                    If server = "" Or server = "." Or server = "local" Or server = "localhost" Then
                        server = Environment.MachineName
                    End If

                    If TabHeader1.Tabs.Where(Function(p) p.Key.ToLower = server.ToLower).Count = 0 Then
                        Dim serverObject As New BLL.OM.ServerEntity With {.ComputerName = server, .Identity = result.Identity}
                        UpdateServersList(serverObject)
                        Await FetchServer(serverObject)
                    Else
                        'TabHeader1.SelectedIndex = TabHeader1.Tabs.Where(Function(p) p.Key.ToLower = server.ToLower).First.Value
                    End If
                End If
            Catch ex As Exception
                PushLog(ex)
            End Try
        End Sub

        Private Shared Sub UpdateServersList(server As BLL.OM.ServerEntity)
            If Glob.AppSettings.OpenServers Is Nothing Then
                Glob.AppSettings.OpenServers = New List(Of BLL.OM.ServerEntity)
            End If
            Dim currentServer = Glob.AppSettings.OpenServers.Where(Function(p) p.ComputerName.ToUpperInvariant = server.ComputerName.ToUpperInvariant).FirstOrDefault
            If currentServer Is Nothing Then
                Glob.AppSettings.OpenServers.Add(server)
            Else
                currentServer.Identity = server.Identity
            End If
        End Sub

        Private Async Function FetchServer(server As BLL.OM.ServerEntity) As Threading.Tasks.Task
            Try
                TabHeader1.CanAdd = False
                Glob.AppSettings.AddRecentServer(server)
                Dim newTab As New TabPage(server.ComputerName)
                newTab.Margin = New Padding(0)
                newTab.UseVisualStyleBackColor = True
                TabControl1.TabPages.Add(newTab)
                Dim newServer As New ServicesList
                newServer.MachineName = server.ComputerName
                newServer.Identity = server.Identity

                newTab.Controls.Add(newServer)
                newServer.Dock = DockStyle.Fill
                TabControl1.SelectedTab = newTab
                Await newServer.Fetch()
            Catch ex As Exception
                PushLog(ex)
            Finally
                TabHeader1.CanAdd = True
            End Try
        End Function

        Private Sub FrmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
            TabControl1.Top = 34
            TabControl1.Left = -4
            TabControl1.Width = Width - 8
            TabControl1.Height = Height - 72
            If Debugger.IsAttached Then
                Text = String.Format(CultureInfo.InvariantCulture, "{0} x {1}", Width, Height)
            End If
        End Sub

        Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
            Using objAbout As New MainSplash
                objAbout.ShowDialog()
            End Using
        End Sub

        Private Async Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If Not Debugger.IsAttached Then
                TestToolStripMenuItem.Visible = False
            End If

            Await FetchServer(New BLL.OM.ServerEntity With {.ComputerName = Environment.MachineName, .Identity = Nothing})

            If Glob.AppSettings.OpenServers IsNot Nothing Then
                For Each s In Glob.AppSettings.OpenServers.Where(Function(p) p.ComputerName.ToUpperInvariant <> Environment.MachineName.ToUpperInvariant).ToList
                    Await FetchServer(s)
                Next
            End If
            Await Updater.CheckForUpdate
        End Sub

        Private Sub ErrorLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErrorLogsToolStripMenuItem.Click
            Dim logFile = GetLogPath()
            Process.Start(logFile)
        End Sub

        Private Sub TabControl1_ControlRemoved(sender As Object, e As ControlEventArgs) Handles TabControl1.ControlRemoved
            Dim serverName = e.Control.Text
            Dim toRemove = Glob.AppSettings.OpenServers.Where(Function(p) p.ComputerName.ToUpperInvariant = serverName.ToUpperInvariant).FirstOrDefault()
            If toRemove IsNot Nothing Then
                Glob.AppSettings.OpenServers.Remove(toRemove)
            End If
        End Sub

        Private Sub ServicesmscToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicesmscToolStripMenuItem.Click
            Process.Start("services.msc")
        End Sub

        Private Async Sub FrmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
            Select Case e.KeyCode
                Case Keys.F5
                    Dim servicesCtl = DirectCast(TabControl1.SelectedTab.Controls(0), ServicesList)
                    Await servicesCtl.RefreshList
                Case Keys.F3

            End Select
        End Sub
    End Class
End Namespace