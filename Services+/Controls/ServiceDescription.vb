Imports System.Globalization
Imports ServicesPlus.BLL
Imports ServicesPlus.BLL.EventArgs
Imports ServicesPlus.BLL.OM
Imports ServicesPlus.Modules
Imports ServicesPlus.Utils.Util
Imports System.ComponentModel


Namespace Controls

    Friend Class ServiceDescription

        <Category("Services+")>
        Event OnServiceProperty As EventHandler(Of ServiceEventArgs)
        <Category("Services+")>
        Event OnAction As EventHandler(Of ActionEventArgs)

        Private _service As Service
        Public Property Service() As Service
            Get
                Return _service
            End Get
            Set(ByVal value As Service)
                _service = value
                If value Is Nothing Then
                    Visible = DesignMode
                Else
                    DoRefresh()
                    Visible = True
                End If
            End Set
        End Property

        Private Shared Function PathView(pathName As String) As String
            If pathName.Length <= 31 Then Return pathName
            Dim first15 = pathName.Substring(0, 15)
            Dim last12 = pathName.Substring(pathName.Length - 12)
            Return String.Format(CultureInfo.InvariantCulture, "{0} ... {1}", first15, last12)
        End Function

        Private Sub DoRefresh()
            lblDescription.Text = Service.Description
            LinkDisplayName.Text = Service.DisplayName
            LinkPath.Text = PathView(Service.PathName)
            ToolTip1.SetToolTip(LinkPath, Service.PathName)

            If Service.StartMode.ToUpperInvariant = "disabled".ToUpperInvariant Then
                linkStartStop.Enabled = False
                LinkPause.Enabled = False
                LinkRestart.Enabled = False
            Else
                Dim cap = Service.Capablites
                LinkPause.Enabled = False
                LinkRestart.Enabled = False
                linkStartStop.Enabled = False

                If cap.CanPause Then
                    LinkPause.Text = My.Resources.TextPauseTheService
                    LinkPause.LinkArea = New LinkArea(0, 5)
                    LinkPause.Enabled = True
                End If
                If cap.CanRestart Then
                    LinkRestart.Text = My.Resources.TextRestartTheService
                    LinkRestart.LinkArea = New LinkArea(0, 7)
                    LinkRestart.Enabled = True
                End If
                If cap.CanResume Then
                    LinkPause.Text = My.Resources.TextResumeTheService
                    LinkPause.LinkArea = New LinkArea(0, 6)
                    LinkPause.Enabled = True
                End If
                If cap.CanStart Then
                    linkStartStop.Text = My.Resources.TextStartTheService
                    linkStartStop.LinkArea = New LinkArea(0, 5)
                    linkStartStop.Enabled = True
                End If
                If cap.CanStop Then
                    linkStartStop.Text = My.Resources.TextStopTheService
                    linkStartStop.LinkArea = New LinkArea(0, 4)
                    linkStartStop.Enabled = True
                End If
            End If
        End Sub

        Private Sub LinkPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkPath.LinkClicked
            Const X As Integer = 0
            Dim y = LinkPath.Height - 6
            CMLink.Show(LinkPath, X, y)
        End Sub

        Private Sub CopyPathToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles CopyPathToolStripMenuItem.Click
            Trace()
            Dim pathParser As New PathParser(Service.PathName)
            My.Computer.Clipboard.SetText(pathParser.FolderName)
        End Sub

        Private Sub OpenPathToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles OpenPathToolStripMenuItem.Click
            OpenFileLocation(Service.PathName, Service.SystemName)
        End Sub

        Private Sub LinkDisplayName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkDisplayName.LinkClicked
            RaiseEvent OnServiceProperty(sender, New ServiceEventArgs With {.Service = Service})
        End Sub

        Private Sub linkStartStop_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkStartStop.LinkClicked
            If linkStartStop.Text.StartsWith("Start") Then
                RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Start})
            Else
                RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Stop})
            End If
        End Sub

        Private Sub LinkPause_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkPause.LinkClicked
            If LinkPath.Text.StartsWith("Pause") Then
                RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Pause})
            Else
                RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Resume})
            End If
        End Sub

        Private Sub LinkRestart_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRestart.LinkClicked
            RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Restart})
        End Sub
    End Class
End Namespace