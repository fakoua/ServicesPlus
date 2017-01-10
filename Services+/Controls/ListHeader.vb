Imports ServicesPlus.BLL.OM
Imports ServicesPlus.BLL.EventArgs
Imports System.ComponentModel

Namespace Controls
    Friend Class ListHeader
        <Category("Services+")>
        Event OnAction As EventHandler(Of ActionEventArgs)
        <Category("Services+")>
        Event OnSearch As EventHandler(Of FilterEventArgs)
        <Category("Services+")>
        Event OnShowSystemServices As EventHandler(Of Boolean)

        Property Identity As BLL.OM.Identity

        WriteOnly Property Service As Service
            Set(value As Service)
                RefreshUi(value)
            End Set
        End Property

        Private Sub RefreshUi(s As Service)
            Dim cap = s.Capablites
            BtnStart.Enabled = cap.CanStart
            btnStop.Enabled = cap.CanStop
            btnPause.Enabled = cap.CanPause
            btnResume.Enabled = cap.CanResume
            btnRestart.Enabled = cap.CanRestart
        End Sub

        Public Property DropDownView() As ToolStripDropDownMenu
            Get
                Return ViewToolStripMenuItem.DropDown
            End Get
            Set(ByVal value As ToolStripDropDownMenu)
                ViewToolStripMenuItem.DropDown = value
            End Set
        End Property

        Public Property DropDownGroupBy() As ToolStripDropDownMenu
            Get
                Return GroupByToolStripMenuItem.DropDown
            End Get
            Set(ByVal value As ToolStripDropDownMenu)
                GroupByToolStripMenuItem.DropDown = value
            End Set
        End Property

        Public Property ServerName() As String
            Get
                Return lblCaption.Text
            End Get
            Set(ByVal value As String)
                lblCaption.Text = value
                BtnInstall.Visible = CBool(Environment.MachineName.ToUpperInvariant = value.ToUpperInvariant)
            End Set
        End Property

        Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
            RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Start})
        End Sub

        Private Sub SearchBox1_OnSearch(sender As Object, e As FilterEventArgs) Handles SearchBox1.OnSearch
            RaiseEvent OnSearch(sender, e)
        End Sub

        Public Sub ClearText()
            SearchBox1.ClearText()
        End Sub

        Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
            RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Stop})
        End Sub

        Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
            RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Pause})
        End Sub

        Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
            RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Resume})
        End Sub

        Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
            RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Restart})
        End Sub

        Dim _previousSize As ResponsiveSize = ResponsiveSize.Large

        Public Sub Responsive(responsiveSize As ResponsiveSize)
            If responsiveSize = _previousSize Then Exit Sub
            _previousSize = responsiveSize
            Select Case responsiveSize
                Case responsiveSize.Large
                    TableLayoutPanel1.ColumnStyles(0).Width = 40
                    TableLayoutPanel1.ColumnStyles(1).Width = 205
                    TableLayoutPanel1.ColumnStyles(2).Width = 226
                    PicIcon.Visible = True
                    lblCaption.Visible = True
                Case responsiveSize.Medium
                    TableLayoutPanel1.ColumnStyles(0).Width = 40
                    TableLayoutPanel1.ColumnStyles(1).Width = 205
                    TableLayoutPanel1.ColumnStyles(2).Width = 90
                    PicIcon.Visible = True
                    lblCaption.Visible = True
                Case responsiveSize.Small
                    TableLayoutPanel1.ColumnStyles(0).Width = 0
                    TableLayoutPanel1.ColumnStyles(1).Width = 0
                    TableLayoutPanel1.ColumnStyles(2).Width = 140
                    PicIcon.Visible = False
                    lblCaption.Visible = False
            End Select
        End Sub

        Private Sub ToggelButton1_Click(sender As Object, e As EventArgs) Handles ToggelButton1.Click
            RaiseEvent OnShowSystemServices(sender, ToggelButton1.Checked)
        End Sub

        Private Sub BtnInstall_Click(sender As Object, e As EventArgs) Handles BtnInstall.Click
            'TODO: make it as event
            Dim objSave As New FrmCreateService
            If objSave.Open(New BLL.OM.Service With {.ServiceName = ""}, Me.Identity) Then
                RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Refresh})
            End If
            Me.ParentForm.Activate()
        End Sub
    End Class

    Friend Enum ResponsiveSize
        Large
        Medium
        Small
    End Enum
End Namespace