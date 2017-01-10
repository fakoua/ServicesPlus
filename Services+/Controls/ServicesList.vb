Imports System.Globalization
Imports System.Diagnostics.CodeAnalysis
Imports System.IO
Imports ServicesPlus.Forms
Imports ServicesPlus.BLL
Imports ServicesPlus.BLL.EventArgs
Imports ServicesPlus.BLL.OM
Imports System.Threading.Tasks
Imports System.Text
Imports System
Imports ServicesPlus.Modules

Namespace Controls

    Friend Class ServicesList

        Property MachineName As String

        Private _identity As Identity
        Public Property Identity() As Identity
            Get
                Return _identity
            End Get
            Set(ByVal value As Identity)
                _identity = value
                LVServices.Identity = _identity
            End Set
        End Property

        Property Services As List(Of BLL.OM.Service) 'TODO: for web server

        Private _manager As ServiceManager = Nothing
        Private _isLoading As Boolean = False

        Public Async Function Fetch() As Task
            _isLoading = True
            Trace()
            Loading1.Start()
            Dim result = Await FillServices()
            Loading1.Done()
            If result Then
                Await ServerInfo1.RefreshUi(MachineName)
            End If
            _isLoading = False
        End Function

        Private Async Function FillServices(Optional refresh As Boolean = True) As Task(Of Boolean)
            Trace()
            If _manager Is Nothing Then
                Header.ServerName = MachineName.ToUpperInvariant
                _manager = New ServiceManager(MachineName, Identity)
                ServerInfo1.Identity = Identity
                Header.Identity = Identity
            End If

            If refresh Then
                Await _manager.GetServicesByMachineAsync()
                If _manager.Services IsNot Nothing AndAlso _manager.Services.Count > 0 Then
                    LVServices.Services = _manager.Services
                    Me.Services = _manager.Services 'TODO: For web server
                    Header.ServerName = _manager.Services.FirstOrDefault.SystemName.ToUpperInvariant
                    Return True
                Else
                    Header.Enabled = False
                    Dim errorMessage = String.Format("Unable to reach the server:{0}{1}", vbNewLine, _manager.LastError)
                    MsgBox(errorMessage)
                    Return False
                End If
            End If

            Return True 'TODO: bad logic
        End Function

        Private Sub SearchBox_OnSearch(sender As Object, e As FilterEventArgs) Handles Header.OnSearch
            Trace()
            LVServices.SearchBy = New SearchBy With {.SearchBy = ServiceColumn.Name, .Keyword = e.Text}
        End Sub

        Private Sub ServicesList_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            Loading1.ParentResize()
            If Width < 728 Then
                PanelLeft.Visible = False
                Header.Responsive(ResponsiveSize.Small)
            ElseIf Width < 880 Then
                PanelLeft.Visible = True
                Header.Responsive(ResponsiveSize.Medium)
            Else
                PanelLeft.Visible = True
                Header.Responsive(ResponsiveSize.Large)
            End If
        End Sub

        Private Sub UncheckGroupBy()
            Trace()
            For Each item As ToolStripMenuItem In CMGroupBy.Items
                item.Checked = False
            Next
        End Sub

        Private Sub NoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miNoneGroupBy.Click
            Trace()
            LVServices.GroupBy = ServiceColumn.None
        End Sub

        Private Sub StatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miStatusGroupBy.Click
            Trace()
            LVServices.GroupBy = ServiceColumn.Status
        End Sub

        Private Sub StartupTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miStartupTypeGroupBy.Click
            Trace()
            LVServices.GroupBy = ServiceColumn.StartType
        End Sub

        Private Sub LogonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miLogonGroupBy.Click
            Trace()
            LVServices.GroupBy = ServiceColumn.LogOn
        End Sub

        Private Sub UncheckAllViews()
            miListView.Checked = False
            miDetailsView.Checked = False
            miTileView.Checked = False
            miLargeIconView.Checked = False
        End Sub

        Private Sub LargeIconToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miLargeIconView.Click
            UncheckAllViews()
            miLargeIconView.Checked = True
            LVServices.View = View.LargeIcon
        End Sub

        Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miListView.Click
            UncheckAllViews()
            miListView.Checked = True
            LVServices.View = View.List
        End Sub

        Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miDetailsView.Click
            UncheckAllViews()
            miDetailsView.Checked = True
            LVServices.View = View.Details
        End Sub

        Private Sub TileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miTileView.Click
            UncheckAllViews()
            miTileView.Checked = True
            LVServices.View = View.Tile
        End Sub

        Private Sub LVServices_OnServiceChanged(sender As Object, e As ServiceEventArgs) Handles LVServices.OnServiceChanged
            ServiceDescription1.Service = e.Service
            Header.Service = e.Service
        End Sub

        Private Sub LVServices_OnAfterFill(sender As Object, e As String) Handles LVServices.OnAfterFill
            lblServices.Text = e
            If LVServices.SearchBy.SearchBy <> ServiceColumn.Name Then
                Header.ClearText()
            End If
            UncheckGroupBy()
            Select Case LVServices.GroupBy
                Case ServiceColumn.LogOn
                    miLogonGroupBy.Checked = True
                Case ServiceColumn.Name
                Case ServiceColumn.None
                    miNoneGroupBy.Checked = True
                Case ServiceColumn.StartType
                    miStartupTypeGroupBy.Checked = True
                Case ServiceColumn.Status
                    miStatusGroupBy.Checked = True
                Case ServiceColumn.ServiceType
                    MiServiceTypeGroupBy.Checked = True
            End Select
        End Sub

        Private Async Sub Service_OnAction(sender As Object, e As ActionEventArgs) Handles Header.OnAction, LVServices.OnAction, ServiceDescription1.OnAction
            Dim refreshService As Service = Nothing

            Select Case e.Action
                Case ServiceAction.Pause
                    refreshService = Await ControlService(WmiMethod.PauseService)
                Case ServiceAction.Restart
                    'TODO: consider split stop/start logic
                    Await ControlService(WmiMethod.StopService)
                    refreshService = Await ControlService(WmiMethod.StartService)
                Case ServiceAction.Resume
                    refreshService = Await ControlService(WmiMethod.ResumeService)
                Case ServiceAction.Start
                    refreshService = Await ControlService(WmiMethod.StartService)
                Case ServiceAction.Stop
                    refreshService = Await ControlService(WmiMethod.StopService)
                Case ServiceAction.Refresh
                    Await Fetch()
            End Select
            Dim frmProperty = TryCast(sender, FrmProperties)
            If frmProperty IsNot Nothing AndAlso refreshService IsNot Nothing Then
                frmProperty.Service = refreshService
            End If
        End Sub

        Private Async Function ControlService(action As WmiMethod) As Task(Of Service)
            Dim service = LVServices.GetSelectedService()
            Dim rtnVal = service
            Dim actionName = action.ToString.Replace("Service", "")
            MetroModal1.Show(String.Format("Attempting to {0} the service {1} on {2} ", actionName, service.DisplayName, service.SystemName), "")
            Dim result = Await _manager.ControlServiceAsync(service, action)
            If result.WmiValue = WmiReturn.Success Then
                MetroModal1.Done()
                LVServices.UpdateService(result.ServiceRefresh)
                rtnVal = result.ServiceRefresh
            Else
                Dim msg As String
                If result.WmiValue = WmiReturn.HandledError Then
                    msg = result.LastError
                Else
                    msg = result.WmiValue.ToString
                End If
                MetroModal1.Update(msg, True)
            End If
            Return rtnVal
        End Function

        Private Sub LVServices_OnServiceProperty(sender As Object, e As ServiceEventArgs) Handles LVServices.OnServiceProperty, ServiceDescription1.OnServiceProperty
            Using objProperty As New FrmProperties
                AddHandler objProperty.OnAction, AddressOf Service_OnAction
                AddHandler objProperty.OnServiceRefresh, AddressOf Property_ServiceRefresh
                Dim isRemoteRegistryRunning = _manager.Services.Where(Function(p) p.ServiceName.ToUpperInvariant = "RemoteRegistry".ToUpperInvariant).Select(Function(p) p.Started).FirstOrDefault
                isRemoteRegistryRunning = isRemoteRegistryRunning Or (_manager.Services.First.SystemName.ToUpperInvariant = Environment.MachineName.ToUpperInvariant)
                objProperty.Open(e.Service, isRemoteRegistryRunning, _manager.Services, Me.Identity)
                'TODO: consider this remove
                RemoveHandler objProperty.OnAction, AddressOf Service_OnAction
                RemoveHandler objProperty.OnServiceRefresh, AddressOf Property_ServiceRefresh
            End Using
        End Sub

        Private Sub ExportCsv()
            Const CsvHeader As String = "Computer,Name,Display Name,Description,Path,Status,State,Startup Type,Log on,Accept Pause,Accept Stop,Desktop Interact,Process,Service Type"
            Dim csvList = _manager.Services.Select(Function(p) p.ToCsv).ToList
            Dim csv = csvList.Aggregate(Function(a, b) String.Format(CultureInfo.InvariantCulture, "{0}{1}", a, b))
            csv = String.Format(CultureInfo.InvariantCulture, "{0}{1}{2}", CsvHeader, vbNewLine, csv)
            Dim fileName = String.Format(CultureInfo.InvariantCulture, "{0}-Services.csv", _manager.Services.First.SystemName)
            fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName)
            My.Computer.FileSystem.WriteAllText(fileName, csv, False, ASCIIEncoding.Default)
            Process.Start("explorer.exe", "/select," & fileName)
        End Sub

        <SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId:="th")> Private Sub ExportHtml()
            Const HtmlHeader As String = "<table border=1 cellpadding=0 cellspacing=0><tr><th>Computer</th><th>Name</th><th>Display Name</th><th>Description</th><th>Path</th><th>Status</th><th>State</th><th>Startup Type</th><th>Log on</th><th>Accept Pause</th><th>Accept Stop</th><th>Desktop Interact</th><th>Process</th><th>Service Type</th></tr>"
            Const HtmlFooter As String = "</table>"
            Dim htmlList = _manager.Services.Select(Function(p) p.ToHtml).ToList
            Dim html = htmlList.Aggregate(Function(a, b) String.Format(CultureInfo.InvariantCulture, "{0}{1}", a, b))
            html = String.Format(CultureInfo.InvariantCulture, "{0}{1}{2}", HtmlHeader, html, HtmlFooter)
            Dim fileName = String.Format(CultureInfo.InvariantCulture, "{0}-Services.htm", _manager.Services.First.SystemName)
            fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName)
            My.Computer.FileSystem.WriteAllText(fileName, html, False, ASCIIEncoding.Default)
            Process.Start("explorer.exe", "/select," & fileName)
        End Sub

        Private Sub MiCsvFormatExport_Click(sender As Object, e As EventArgs) Handles MiCsvFormatExport.Click
            ExportCsv()
        End Sub

        Private Sub MiHtmlFormatExport_Click(sender As Object, e As EventArgs) Handles MiHtmlFormatExport.Click
            ExportHtml()
        End Sub

        Private Sub Header_OnShowSystemServices(sender As Object, e As Boolean) Handles Header.OnShowSystemServices
            LVServices.ShowSystemServices = e
        End Sub

        Private Sub ServiceTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiServiceTypeGroupBy.Click
            LVServices.GroupBy = ServiceColumn.ServiceType
        End Sub

        Private Sub Property_ServiceRefresh(sender As Object, e As ServiceEventArgs)
            LVServices.UpdateService(e.Service)
            Dim frmProperty = TryCast(sender, FrmProperties)
            If frmProperty IsNot Nothing AndAlso e.Service IsNot Nothing Then
                frmProperty.Service = e.Service
            End If
        End Sub

        Friend Async Function RefreshList() As Task
            If Not _isLoading Then Await Fetch()
        End Function

    End Class
End Namespace