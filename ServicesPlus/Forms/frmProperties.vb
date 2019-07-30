Imports System.Globalization
Imports ServicesPlus.BLL
Imports ServicesPlus.BLL.OM
Imports ServicesPlus.BLL.EventArgs
Imports System
Imports ServicesPlus.Modules
Imports ServicesPlus.Utils.Util
Imports System.ComponentModel

Namespace Forms

    Friend Class FrmProperties

        <Category("Services+")>
        Public Event OnAction As EventHandler(Of ActionEventArgs)
        <Category("Services+")>
        Public Event OnServiceRefresh As EventHandler(Of BLL.EventArgs.ServiceEventArgs)

        Private _service As Service
        WriteOnly Property Service As Service
            Set(value As Service)
                _service = value
                Init()
                'TODO: how about canseeperformance
            End Set
        End Property

        Dim _services As List(Of Service)
        Dim _identity As BLL.OM.Identity

        Dim _canSeePerformance As Boolean
        ReadOnly _manager As New ServiceManager

        Public Sub Open(ByVal serviceObject As Service, canSeePerformace As Boolean, services As List(Of Service), identity As BLL.OM.Identity)
            _service = serviceObject
            _services = services
            _identity = identity
            _canSeePerformance = canSeePerformace
            Init()
            ShowDialog()
        End Sub

        Private Sub Init()
            Trace()
            If _canSeePerformance Then
                lblWarning.Visible = False
                PanelPerformance.Top = 0
                PanelPerformance.Visible = True
            Else
                lblWarning.Visible = True
                PanelPerformance.Visible = False
            End If
            lblWarning.Text = String.Format(CultureInfo.InvariantCulture, lblWarning.Text, _service.SystemName)

            If Not _service.Started Then
                lblWarning.Text = "Service is not running"
                lblWarning.Visible = True
                PanelPerformance.Visible = False
            End If

            txtDescription.Text = _service.Description
            txtDisplayName.Text = _service.DisplayName
            txtLogOn.Text = _service.StartName
            linkPath.Text = _service.PathName
            txtServiceName.Text = _service.ServiceName
            txtStatus.Text = _service.State
            LblStartupType.Text = _service.StartModeView
            Text = String.Format(CultureInfo.InvariantCulture, Text, _service.DisplayName, _service.SystemName)

            Dim capabilities = _service.Capablites
            btnStart.Enabled = capabilities.CanStart
            btnStop.Enabled = capabilities.CanStop
            btnPause.Enabled = capabilities.CanPause
            btnResume.Enabled = capabilities.CanResume
            btnRestart.Enabled = capabilities.CanRestart

            If _service.IsSystem Then
                TabControl1.TabPages.Remove(TabPerformance)
                BtnEdit.Enabled = False
            End If
        End Sub

        Private Sub BtnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClose.Click
            Close()
        End Sub

        Private Sub TxtPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkPath.LinkClicked
            Const X As Integer = 0
            Dim y = linkPath.Height - 6
            CMLink.Show(linkPath, X, y)
        End Sub

        Private Async Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
            Trace()
            Try
                If TabControl1.SelectedIndex = 2 AndAlso _canSeePerformance AndAlso _service.Started Then
                    Loading1.Top = 0
                    Loading1.Left = 0
                    Loading1.Width = TabPerformance.Width
                    Loading1.Height = TabPerformance.Height
                    Loading1.Start()
                    Dim perf = Await _manager.GetPerformanceAsync(_service)
                    lblMemory.Text = SizeToReadable(perf.Memory)
                    lblPeak.Text = SizeToReadable(perf.PeakMemory)

                    PanelPerformance.Visible = True
                    Loading1.Done()
                End If
            Catch ex As Exception
                PushLog(ex)
            End Try

            If TabControl1.SelectedIndex = 1 Then
                Await FillDependencies()
            End If
        End Sub

        Private Async Function FillDependencies() As Threading.Tasks.Task
            HLoader1.Start()
            Dim dependsOn = Await _service.DependsOnAsync(_services, Me._identity)
            TvDependsOn.Nodes.Clear()
            If dependsOn Is Nothing OrElse dependsOn.Count = 0 Then
                TvDependsOn.Nodes.Add("No Dependencies")
                TvDependsOn.Enabled = False
            Else
                TvDependsOn.Enabled = True
                For Each s In dependsOn
                    AddNode(TvDependsOn.Nodes, s)
                Next
            End If

            NativeMethods.SetWindowTheme(TvDependsOn.Handle, "explorer", Nothing)

            Dim dependOnThisService = Await _service.DependOnThisServiceAsync(_services, Me._identity)
            TvDependsOnThisService.Nodes.Clear()
            If dependOnThisService Is Nothing OrElse dependOnThisService.Count = 0 Then
                TvDependsOnThisService.Nodes.Add("No Dependencies")
                TvDependsOnThisService.Enabled = False
            Else
                TvDependsOnThisService.Enabled = True
                For Each s In dependOnThisService
                    AddNode(TvDependsOnThisService.Nodes, s)
                Next
            End If


            NativeMethods.SetWindowTheme(TvDependsOnThisService.Handle, "explorer", Nothing)
            HLoader1.Done()
        End Function

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            lblStartType.Text = My.Resources.LBLStartType
            lblPath.Text = My.Resources.LBLPath
            lblDescription.Text = My.Resources.LBLDescription
            LblServiceStatusTitle.Text = My.Resources.LBLServiceStatus
            lblDispalyName.Text = My.Resources.LBLDisplayName
            lblServiceName.Text = My.Resources.LBLServiceName
            LblLogonAsTitle.Text = My.Resources.LBLLogonAs
            lblWarning.Text = My.Resources.TempPerformanceWarning
            lblMemoryLbl.Text = My.Resources.LBLMemory
            lblPeakLbl.Text = My.Resources.LBLPeakMemory
            Text = My.Resources.TempPropertiesCaption

        End Sub

        Private Sub OpenPathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPathToolStripMenuItem.Click
            OpenFileLocation(_service.PathName, _service.SystemName)
        End Sub

        Private Sub CopyPathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyPathToolStripMenuItem.Click
            Trace()
            Dim pathParser As New PathParser(_service.PathName)
            My.Computer.Clipboard.SetText(pathParser.FolderName)
        End Sub

        Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
            RaiseEvent OnAction(Me, New ActionEventArgs With {.Action = ServiceAction.Start})
        End Sub

        Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
            RaiseEvent OnAction(Me, New ActionEventArgs With {.Action = ServiceAction.Stop})
        End Sub

        Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
            RaiseEvent OnAction(Me, New ActionEventArgs With {.Action = ServiceAction.Pause})
        End Sub

        Private Sub BtnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
            RaiseEvent OnAction(Me, New ActionEventArgs With {.Action = ServiceAction.Resume})
        End Sub

        Private Sub BtnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
            RaiseEvent OnAction(Me, New ActionEventArgs With {.Action = ServiceAction.Restart})
        End Sub

        Private Sub BtnCancel_Click(sender As Object, e As EventArgs)
            Close()
        End Sub

        Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
            Using objEditService As New FrmEditService
                AddHandler objEditService.OnServiceRefresh, AddressOf Edit_ServiceRefresh
                objEditService.Open(_service, _identity)
                RemoveHandler objEditService.OnServiceRefresh, AddressOf Edit_ServiceRefresh
                'Have no idea why I need to active this form after closing the modal and topmost forms
                Me.Activate()
            End Using
        End Sub

        Private Async Sub TvDependsOn_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles TvDependsOn.AfterExpand
            e.Node.Nodes.Clear()
            HLoader1.Start()
            Dim serviceObject As Service = TryCast(e.Node.Tag, Service)
            If serviceObject IsNot Nothing Then
                Dim services = Await serviceObject.DependsOnAsync(_services, Me._identity)

                For Each s In services
                    AddNode(e.Node.Nodes, s)
                Next
            End If
            'e.Node.Expand()
            HLoader1.Done()
        End Sub

        Private Async Sub TvDependsOnThisService_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles TvDependsOnThisService.AfterExpand
            e.Node.Nodes.Clear()
            HLoader1.Start()
            Dim serviceObject = TryCast(e.Node.Tag, Service)
            If serviceObject IsNot Nothing Then
                Dim services = Await serviceObject.DependOnThisServiceAsync(_services, Me._identity)

                For Each s In services
                    AddNode(e.Node.Nodes, s)
                Next
            End If
            'e.Node.Expand()
            HLoader1.Done()
        End Sub

        Private Shared Sub AddNode(nodes As TreeNodeCollection, serviceObject As Service)
            Dim nd = nodes.Add(serviceObject.DisplayNameDepend)
            nd.ForeColor = ColorByState(serviceObject)
            nd.Tag = serviceObject
            nd.Nodes.Add("Loading ...")
        End Sub

        Private Sub FrmProperties_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        End Sub

        Private Sub Edit_ServiceRefresh(sender As Object, e As ServiceEventArgs)
            'Need to pass Me as sender in order to alow the caller to force property form to refresh
            RaiseEvent OnServiceRefresh(Me, e)
        End Sub

    End Class
End Namespace