Imports System.ComponentModel
Imports System.Globalization
Imports ServicesPlus.My.Resources
Imports ServicesPlus.Classes
Imports ServicesPlus.BLL.OM
Imports ServicesPlus.BLL.EventArgs
Imports ServicesPlus.Modules
Imports ServicesPlus.Utils.Util
Namespace Controls
    Friend Class ListViewNf
        Inherits ListView

#Region "Components"

        Friend WithEvents ColDisplayName As ColumnHeader
        Friend WithEvents ColStatus As ColumnHeader
        Friend WithEvents ColStartType As ColumnHeader
        Friend WithEvents ColLogin As ColumnHeader
        Friend WithEvents ColDesc As ColumnHeader
        Friend WithEvents ColName As ColumnHeader
        Friend WithEvents ColType As ColumnHeader

        Friend WithEvents MiPropertiesService As ToolStripMenuItem
        Friend WithEvents ImageListLarge As ImageList
        Friend WithEvents ImageListSmall As ImageList
        Friend WithEvents CmName As ContextMenuStrip
        Friend WithEvents MiSortName As ToolStripMenuItem
        Friend WithEvents CmLogon As ContextMenuStrip
        Friend WithEvents MiSortLogon As ToolStripMenuItem
        Friend WithEvents MiGroupByLogon As ToolStripMenuItem
        Friend WithEvents MiFilterLogon As ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
        Friend WithEvents CmStartMode As ContextMenuStrip
        Friend WithEvents MiSortStartMode As ToolStripMenuItem
        Friend WithEvents MiGroupByStartMode As ToolStripMenuItem
        Friend WithEvents MiFilterStartMode As ToolStripMenuItem
        Friend WithEvents SubFilterStartModeShowAll As ToolStripMenuItem
        Friend WithEvents SubFilterStartModeManual As ToolStripMenuItem
        Friend WithEvents SubFilterStartModeAutomatic As ToolStripMenuItem
        Friend WithEvents SubFilterStartModeDisabled As ToolStripMenuItem
        Friend WithEvents CmStatus As ContextMenuStrip
        Friend WithEvents MiSortStats As ToolStripMenuItem
        Friend WithEvents MiGroupByStatus As ToolStripMenuItem
        Friend WithEvents MiFilterStatus As ToolStripMenuItem
        Friend WithEvents SubFilterStatusShowAll As ToolStripMenuItem
        Friend WithEvents SubFilterStatusRunning As ToolStripMenuItem
        Friend WithEvents SubFilterStatusStopped As ToolStripMenuItem
        Friend WithEvents SubFilterStatusPaused As ToolStripMenuItem
        Friend WithEvents MiS04 As ToolStripSeparator
        Friend WithEvents MiExportService As ToolStripMenuItem
        Friend WithEvents MiS03 As ToolStripSeparator
        Friend WithEvents MiViewService As ToolStripMenuItem
        Friend WithEvents MiGroupByService As ToolStripMenuItem
        Friend WithEvents MiS02 As ToolStripSeparator
        Friend WithEvents MiRefreshService As ToolStripMenuItem
        Friend WithEvents MiS01 As ToolStripSeparator
        Friend WithEvents MiRestartService As ToolStripMenuItem
        Friend WithEvents MiResumeService As ToolStripMenuItem
        Friend WithEvents MiPauseService As ToolStripMenuItem
        Friend WithEvents MiStopService As ToolStripMenuItem
        Friend WithEvents MiStartService As ToolStripMenuItem
        Private components As IContainer
        Friend WithEvents CmService As ContextMenuStrip

#End Region

        <Category("Services+")>
        Public Event ColumnContextMenu As EventHandler(Of ColumnConextMenuEventArgs)

        <Category("Services+")>
        Public Event OnServiceChanged As EventHandler(Of ServiceEventArgs)

        <Category("Services+")>
        Public Event OnAfterFill As EventHandler(Of String)

        <Category("Services+")>
        Public Event OnServiceProperty As EventHandler(Of ServiceEventArgs)

        <Category("Services+")>
        Public Event OnAction As EventHandler(Of ActionEventArgs)

        Const WmContextmenu As Integer = &H7B
        Dim _colClickEventArgs As ColumnClickEventArgs

        Private _groupBy As ServiceColumn

        <Category("Services+")>
        Public Property GroupBy() As ServiceColumn
            Get
                Return _groupBy
            End Get
            Set(ByVal value As ServiceColumn)
                _groupBy = value
                If Services IsNot Nothing Then FillList()
            End Set
        End Property

        Private _searchBy As SearchBy

        <Category("Services+"), Browsable(True)>
        Public Property SearchBy() As SearchBy
            Get
                Return _searchBy
            End Get
            Set(ByVal value As SearchBy)
                _searchBy = value
                If Services IsNot Nothing Then FillList()
            End Set
        End Property

        <Category("Services+")>
        Public Property DropDownView() As ToolStripDropDownMenu
            Get
                Return MiViewService.DropDown
            End Get
            Set(ByVal value As ToolStripDropDownMenu)
                MiViewService.DropDown = value
            End Set
        End Property

        <Category("Services+")>
        Private _showSystemServices As Boolean = False
        Friend WithEvents CmServiceType As ContextMenuStrip
        Friend WithEvents MiSortServiceType As ToolStripMenuItem
        Friend WithEvents MiGroupByServiceType As ToolStripMenuItem
        Friend WithEvents MiFilterByServiceType As ToolStripMenuItem
        Friend WithEvents KEY As System.Windows.Forms.ColumnHeader
        Friend WithEvents MiS05 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents MiDeleteService As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MiEditService As ToolStripMenuItem

        Public Property ShowSystemServices() As Boolean
            Get
                Return _showSystemServices
            End Get
            Set(ByVal value As Boolean)
                _showSystemServices = value
                If Services IsNot Nothing Then FillList()
            End Set
        End Property

        <Category("Services+")>
        Public Property DropDownGroupBy() As ToolStripDropDownMenu
            Get
                Return MiGroupByService.DropDown
            End Get
            Set(ByVal value As ToolStripDropDownMenu)
                MiGroupByService.DropDown = value
            End Set
        End Property

        <Category("Services+")>
        Public Property DropDownExport() As ToolStripDropDownMenu
            Get
                Return MiExportService.DropDown
            End Get
            Set(ByVal value As ToolStripDropDownMenu)
                MiExportService.DropDown = value
            End Set
        End Property

        Private _services As List(Of Service)
        Public Property Services() As List(Of Service)
            Get
                Return _services
            End Get
            Set(ByVal value As List(Of Service))
                _services = value
                If value IsNot Nothing Then FillList()
            End Set
        End Property

        Property Identity As Identity

        Sub UpdateService(service As Service)
            Trace()
            Dim selectedService = GetSelectedService()
            Dim itemIndex =
                    Services.FindIndex(
                        Function(p) p.ServiceName.ToUpperInvariant = selectedService.ServiceName.ToUpperInvariant)
            Services.Item(itemIndex) = service
            If selectedService.ServiceName = service.ServiceName Then
                SelectedItems(0).Text = service.DisplayName
                SelectedItems(0).ImageIndex = ImageByState(service)
                SelectedItems(0).ForeColor = ColorByState(service)
                SelectedItems(0).SubItems(1).Text = service.StateView
                SelectedItems(0).SubItems(2).Text = service.StartModeView
                SelectedItems(0).SubItems(3).Text = service.StartNameView
                SelectedItems(0).SubItems(4).Text = service.DescriptionView
            End If
            OnSelectedIndexChanged(EventArgs.Empty)
        End Sub

        Private Sub FillLogonFilterCm()
            Trace()
            Dim tempList = Services
            If Not ShowSystemServices Then
                tempList = tempList.Where(Function(p) p.IsSystem = False).ToList
            End If
            'TODO: consider uknown and empty logins
            Dim logons = tempList.Select(Function(p) p.StartNameView.ToCap).Distinct(New LogonComparer).ToList

            For Each item As ToolStripItem In MiFilterLogon.DropDownItems
                RemoveHandler item.Click, AddressOf LogonFilter_Click
            Next
            MiFilterLogon.DropDownItems.Clear()
            Dim ddiClearAll As New ToolStripMenuItem
            ddiClearAll.Font = New Font("Segoe UI Semibold", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            ddiClearAll.Text = TextShowAll

            MiFilterLogon.DropDownItems.Add(ddiClearAll)

            AddHandler ddiClearAll.Click, AddressOf LogonFilter_Click

            For Each l In logons
                Dim ddi As New ToolStripMenuItem
                ddi.Text = l
                ddi.Font = New Font(CmLogon.Font, FontStyle.Regular)
                AddHandler ddi.Click, AddressOf LogonFilter_Click
                MiFilterLogon.DropDownItems.Add(ddi)
            Next
        End Sub

        Private Sub FillServiceTypeFilterCm()
            Trace()
            Dim tempList = Services
            If Not ShowSystemServices Then
                tempList = tempList.Where(Function(p) p.IsSystem = False).ToList
            End If
            Dim serviceTypes = tempList.Select(Function(p) p.ServiceType).Distinct.ToList

            For Each item As ToolStripItem In MiFilterByServiceType.DropDownItems
                RemoveHandler item.Click, AddressOf ServiceTypeFilter_Click
            Next
            MiFilterByServiceType.DropDownItems.Clear()
            Dim ddiClearAll As New ToolStripMenuItem
            ddiClearAll.Font = New Font("Segoe UI Semibold", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            ddiClearAll.Text = TextShowAll

            MiFilterByServiceType.DropDownItems.Add(ddiClearAll)

            AddHandler ddiClearAll.Click, AddressOf ServiceTypeFilter_Click

            For Each l In serviceTypes
                Dim ddi As New ToolStripMenuItem
                ddi.Text = l
                ddi.Font = New Font(CmLogon.Font, FontStyle.Regular)
                AddHandler ddi.Click, AddressOf ServiceTypeFilter_Click
                MiFilterByServiceType.DropDownItems.Add(ddi)
            Next
        End Sub

        ReadOnly _arrayItems As New List(Of ListViewItem)

        Private Sub FillList()
            Trace()
            If Services Is Nothing Then
                Exit Sub
            End If

            ResetCols()
            BeginUpdate()
            Items.Clear()
            Groups.Clear()

            FillLogonFilterCm()
            FillServiceTypeFilterCm()
            Dim tempServices = Services
            If Not ShowSystemServices Then
                tempServices = tempServices.Where(Function(p) p.IsSystem = False).ToList
            End If
            Dim totalServices = If(ShowSystemServices, Services.Count, Services.Where(Function(p) p.IsSystem = False).Count)

            Dim servicesText = String.Format(CultureInfo.InvariantCulture, "{0} Services", totalServices)
            If SearchBy.SearchBy <> ServiceColumn.None Then

                Select Case SearchBy.SearchBy
                    Case ServiceColumn.ServiceType
                        tempServices =
                            tempServices.Where(
                                Function(p) p.ServiceType.ToUpperInvariant.Contains(SearchBy.Keyword.ToUpperInvariant)) _
                                .ToList
                    Case ServiceColumn.LogOn
                        tempServices =
                            tempServices.Where(
                                Function(p) p.StartNameView.ToUpperInvariant.Contains(SearchBy.Keyword.ToUpperInvariant)) _
                                .ToList
                    Case ServiceColumn.Name
                        tempServices =
                            tempServices.Where(
                                Function(p) p.DisplayName.ToUpperInvariant.Contains(SearchBy.Keyword.ToUpperInvariant) Or p.ServiceName.ToUpperInvariant.Contains(SearchBy.Keyword.ToUpperInvariant)).
                                ToList
                    Case ServiceColumn.StartType
                        tempServices =
                            tempServices.Where(
                                Function(p) p.StartModeView.ToUpperInvariant.Contains(SearchBy.Keyword.ToUpperInvariant)) _
                                .ToList
                    Case ServiceColumn.Status
                        tempServices =
                            tempServices.Where(
                                Function(p) p.State.ToUpperInvariant.Contains(SearchBy.Keyword.ToUpperInvariant)).ToList
                End Select

                If tempServices.Count <> totalServices Then
                    servicesText = String.Format(CultureInfo.InvariantCulture, "{0} of {1} Services", tempServices.Count,
                                                 totalServices)
                End If
            End If

            _arrayItems.Clear()
            For Each s In tempServices
                AddService(s)
            Next
            Items.AddRange(_arrayItems.ToArray)

            For Each g As ListViewGroup In Groups
                g.Header = String.Format(CultureInfo.InvariantCulture, "{0} ({1})", g.Header, g.Items.Count)
            Next
            ColLogin.Width = -1
            ColDisplayName.Width = 350
            ColDesc.Width = -1

            If Items.Count > 0 Then
                Items(0).Selected = True
            Else
                'ListView1_SelectedIndexChanged(Nothing, Nothing)
            End If
            SetTheme()
            EndUpdate()
            RaiseEvent OnAfterFill(Me, servicesText)
        End Sub

        Private Sub AddService(ByVal service As Service)
            'Trace()
            Dim objListItem As New ListViewItem
            Dim objGroup = GetGroup(service)
            If objGroup IsNot Nothing Then
                objListItem.Group = objGroup
            End If
            objListItem.ImageIndex = ImageByState(service)
            objListItem.ForeColor = ColorByState(service)
            If service.IsSystem Then
                objListItem.Font = New Font("Segoe UI Semilight", 8.0!, FontStyle.Italic, GraphicsUnit.Point, CType(0, Byte))
            End If
            objListItem.Text = service.DisplayName
            objListItem.SubItems.Add(service.StateView)
            Dim objSub = objListItem.SubItems.Add(service.StartModeView)
            objListItem.SubItems.Add(service.ServiceType)
            objListItem.SubItems.Add(service.StartNameView)
            objListItem.SubItems.Add(service.DescriptionView)
            objListItem.SubItems.Add(service.ServiceName).Name = TextKey
            objSub.ForeColor = ColorByState(service)
            _arrayItems.Add(objListItem)
        End Sub

        Private Function GetGroup(service As Service) As ListViewGroup
            'Trace()
            If GroupBy = ServiceColumn.None Then
                Return Nothing
            End If
            Dim groupName = ""

            Select Case GroupBy
                Case ServiceColumn.LogOn
                    groupName = service.StartNameView
                Case ServiceColumn.StartType
                    groupName = service.StartModeView
                Case ServiceColumn.Status
                    groupName = service.State
                Case ServiceColumn.ServiceType
                    groupName = service.ServiceType
            End Select

            Dim objGroup As ListViewGroup
            objGroup = (From g As ListViewGroup In Groups
                        Where g.Header.StartsWith(groupName, StringComparison.OrdinalIgnoreCase)
                        Select g).FirstOrDefault

            If objGroup Is Nothing Then
                objGroup = New ListViewGroup(groupName.ToCap)
                Groups.Add(objGroup)
            End If
            Return objGroup
        End Function

        Public Sub New()
            InitializeComponent()
            SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
            SetStyle(ControlStyles.EnableNotifyMessage, True)
        End Sub

        Protected Overrides Sub OnNotifyMessage(m As Message)
            If m.Msg <> &H14 Then
                MyBase.OnNotifyMessage(m)
            End If
        End Sub

        Public Sub SetTheme()
            If NativeMethods.SetWindowTheme(Handle, "explorer", Nothing) <> 0 Then
                'PushLog("ListViewNF.vb.SetTheme", "Unable to set the theme to explorer theme [SetWindowTheme]")
            End If
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)
            Try
                If m.Msg = WmContextmenu Then
                    ' ReSharper disable once RedundantMyBaseQualifier
                    Dim p = MyBase.PointToClient(MousePosition)
                    Dim totalWidth = 0
                    If p.Y <= 22 Then
                        ' ReSharper disable once RedundantMyBaseQualifier
                        For Each c As ColumnHeader In MyBase.Columns
                            totalWidth += c.Width
                            If (p.X < totalWidth) Then
                                RaiseEvent ColumnContextMenu(Me, New ColumnConextMenuEventArgs With {.Column = c})
                                Exit Sub
                            End If
                        Next
                    End If
                End If
            Catch ex As Exception
                PushLog(ex)
            End Try
            MyBase.WndProc(m)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListViewNf))
            Me.ImageListLarge = New System.Windows.Forms.ImageList(Me.components)
            Me.ImageListSmall = New System.Windows.Forms.ImageList(Me.components)
            Me.ColDisplayName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColStartType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColLogin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.KEY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.CmService = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.MiStartService = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiStopService = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiPauseService = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiResumeService = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiRestartService = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiS05 = New System.Windows.Forms.ToolStripSeparator()
            Me.MiDeleteService = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiS01 = New System.Windows.Forms.ToolStripSeparator()
            Me.MiRefreshService = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiS02 = New System.Windows.Forms.ToolStripSeparator()
            Me.MiGroupByService = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiViewService = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiS03 = New System.Windows.Forms.ToolStripSeparator()
            Me.MiExportService = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiS04 = New System.Windows.Forms.ToolStripSeparator()
            Me.MiPropertiesService = New System.Windows.Forms.ToolStripMenuItem()
            Me.CmName = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.MiSortName = New System.Windows.Forms.ToolStripMenuItem()
            Me.CmLogon = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.MiSortLogon = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiGroupByLogon = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiFilterLogon = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
            Me.CmStartMode = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.MiSortStartMode = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiGroupByStartMode = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiFilterStartMode = New System.Windows.Forms.ToolStripMenuItem()
            Me.SubFilterStartModeShowAll = New System.Windows.Forms.ToolStripMenuItem()
            Me.SubFilterStartModeManual = New System.Windows.Forms.ToolStripMenuItem()
            Me.SubFilterStartModeAutomatic = New System.Windows.Forms.ToolStripMenuItem()
            Me.SubFilterStartModeDisabled = New System.Windows.Forms.ToolStripMenuItem()
            Me.CmStatus = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.MiSortStats = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiGroupByStatus = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiFilterStatus = New System.Windows.Forms.ToolStripMenuItem()
            Me.SubFilterStatusShowAll = New System.Windows.Forms.ToolStripMenuItem()
            Me.SubFilterStatusRunning = New System.Windows.Forms.ToolStripMenuItem()
            Me.SubFilterStatusStopped = New System.Windows.Forms.ToolStripMenuItem()
            Me.SubFilterStatusPaused = New System.Windows.Forms.ToolStripMenuItem()
            Me.CmServiceType = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.MiSortServiceType = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiGroupByServiceType = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiFilterByServiceType = New System.Windows.Forms.ToolStripMenuItem()
            Me.MiEditService = New System.Windows.Forms.ToolStripMenuItem()
            Me.CmService.SuspendLayout()
            Me.CmName.SuspendLayout()
            Me.CmLogon.SuspendLayout()
            Me.CmStartMode.SuspendLayout()
            Me.CmStatus.SuspendLayout()
            Me.CmServiceType.SuspendLayout()
            Me.SuspendLayout()
            '
            'ImageListLarge
            '
            Me.ImageListLarge.ImageStream = CType(resources.GetObject("ImageListLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageListLarge.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageListLarge.Images.SetKeyName(0, "l_running.png")
            Me.ImageListLarge.Images.SetKeyName(1, "l_paused.png")
            Me.ImageListLarge.Images.SetKeyName(2, "l_stopped.png")
            Me.ImageListLarge.Images.SetKeyName(3, "l_disabled.png")
            Me.ImageListLarge.Images.SetKeyName(4, "l_s_running.png")
            Me.ImageListLarge.Images.SetKeyName(5, "l_s_paused.png")
            Me.ImageListLarge.Images.SetKeyName(6, "l_s_stopped.png")
            Me.ImageListLarge.Images.SetKeyName(7, "l_s_disabled.png")
            '
            'ImageListSmall
            '
            Me.ImageListSmall.ImageStream = CType(resources.GetObject("ImageListSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageListSmall.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageListSmall.Images.SetKeyName(0, "Running.png")
            Me.ImageListSmall.Images.SetKeyName(1, "paused.png")
            Me.ImageListSmall.Images.SetKeyName(2, "stopped.png")
            Me.ImageListSmall.Images.SetKeyName(3, "disabled.png")
            Me.ImageListSmall.Images.SetKeyName(4, "s_running.png")
            Me.ImageListSmall.Images.SetKeyName(5, "s_paused.png")
            Me.ImageListSmall.Images.SetKeyName(6, "s_stopped.png")
            Me.ImageListSmall.Images.SetKeyName(7, "s_disabled.png")
            Me.ImageListSmall.Images.SetKeyName(8, "az.png")
            Me.ImageListSmall.Images.SetKeyName(9, "za.png")
            '
            'ColDisplayName
            '
            Me.ColDisplayName.DisplayIndex = 1
            Me.ColDisplayName.Text = Global.ServicesPlus.My.Resources.Resources.TextDisplayName
            Me.ColDisplayName.Width = 200
            '
            'ColStatus
            '
            Me.ColStatus.DisplayIndex = 2
            Me.ColStatus.Text = Global.ServicesPlus.My.Resources.Resources.TextStatus
            Me.ColStatus.Width = 99
            '
            'ColStartType
            '
            Me.ColStartType.DisplayIndex = 3
            Me.ColStartType.Text = Global.ServicesPlus.My.Resources.Resources.TextStartType
            Me.ColStartType.Width = 90
            '
            'ColType
            '
            Me.ColType.DisplayIndex = 4
            Me.ColType.Text = Global.ServicesPlus.My.Resources.Resources.TextServiceType
            Me.ColType.Width = 90
            '
            'ColLogin
            '
            Me.ColLogin.DisplayIndex = 5
            Me.ColLogin.Text = Global.ServicesPlus.My.Resources.Resources.TextLogon
            Me.ColLogin.Width = 130
            '
            'ColDesc
            '
            Me.ColDesc.DisplayIndex = 6
            Me.ColDesc.Text = Global.ServicesPlus.My.Resources.Resources.TextDescription
            Me.ColDesc.Width = 112
            '
            'KEY
            '
            Me.KEY.DisplayIndex = 0
            Me.KEY.Name = Global.ServicesPlus.My.Resources.Resources.TextKey
            Me.KEY.Text = Global.ServicesPlus.My.Resources.Resources.TextServiceName
            Me.KEY.Width = 0
            '
            'CmService
            '
            Me.CmService.Enabled = False
            Me.CmService.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmService.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiStartService, Me.MiStopService, Me.MiPauseService, Me.MiResumeService, Me.MiRestartService, Me.MiS05, Me.MiEditService, Me.MiDeleteService, Me.MiS01, Me.MiRefreshService, Me.MiS02, Me.MiGroupByService, Me.MiViewService, Me.MiS03, Me.MiExportService, Me.MiS04, Me.MiPropertiesService})
            Me.CmService.Name = "CmService"
            Me.CmService.Size = New System.Drawing.Size(157, 298)
            '
            'MiStartService
            '
            Me.MiStartService.Enabled = False
            Me.MiStartService.Image = Global.ServicesPlus.My.Resources.Resources.Start
            Me.MiStartService.Name = "MiStartService"
            Me.MiStartService.Size = New System.Drawing.Size(156, 22)
            Me.MiStartService.Text = Global.ServicesPlus.My.Resources.Resources.TextStart
            '
            'MiStopService
            '
            Me.MiStopService.Enabled = False
            Me.MiStopService.Image = Global.ServicesPlus.My.Resources.Resources._Stop
            Me.MiStopService.Name = "MiStopService"
            Me.MiStopService.Size = New System.Drawing.Size(156, 22)
            Me.MiStopService.Text = Global.ServicesPlus.My.Resources.Resources.TextStop
            '
            'MiPauseService
            '
            Me.MiPauseService.Enabled = False
            Me.MiPauseService.Image = Global.ServicesPlus.My.Resources.Resources.Pause
            Me.MiPauseService.Name = "MiPauseService"
            Me.MiPauseService.Size = New System.Drawing.Size(156, 22)
            Me.MiPauseService.Text = Global.ServicesPlus.My.Resources.Resources.TextPause
            '
            'MiResumeService
            '
            Me.MiResumeService.Enabled = False
            Me.MiResumeService.Image = Global.ServicesPlus.My.Resources.Resources._Resume
            Me.MiResumeService.Name = "MiResumeService"
            Me.MiResumeService.Size = New System.Drawing.Size(156, 22)
            Me.MiResumeService.Text = Global.ServicesPlus.My.Resources.Resources.TextResume
            '
            'MiRestartService
            '
            Me.MiRestartService.Enabled = False
            Me.MiRestartService.Image = Global.ServicesPlus.My.Resources.Resources.Restart
            Me.MiRestartService.Name = "MiRestartService"
            Me.MiRestartService.Size = New System.Drawing.Size(156, 22)
            Me.MiRestartService.Text = Global.ServicesPlus.My.Resources.Resources.TextRestart
            '
            'MiS05
            '
            Me.MiS05.Name = "MiS05"
            Me.MiS05.Size = New System.Drawing.Size(153, 6)
            '
            'MiDeleteService
            '
            Me.MiDeleteService.Enabled = False
            Me.MiDeleteService.ForeColor = System.Drawing.Color.Red
            Me.MiDeleteService.Image = Global.ServicesPlus.My.Resources.Resources.delete
            Me.MiDeleteService.Name = "MiDeleteService"
            Me.MiDeleteService.Size = New System.Drawing.Size(156, 22)
            Me.MiDeleteService.Text = "Delete service"
            '
            'MiS01
            '
            Me.MiS01.Name = "MiS01"
            Me.MiS01.Size = New System.Drawing.Size(153, 6)
            '
            'MiRefreshService
            '
            Me.MiRefreshService.Enabled = False
            Me.MiRefreshService.Image = Global.ServicesPlus.My.Resources.Resources.Refresh
            Me.MiRefreshService.Name = "MiRefreshService"
            Me.MiRefreshService.Size = New System.Drawing.Size(156, 22)
            Me.MiRefreshService.Text = Global.ServicesPlus.My.Resources.Resources.TextRefresh
            '
            'MiS02
            '
            Me.MiS02.Name = "MiS02"
            Me.MiS02.Size = New System.Drawing.Size(153, 6)
            '
            'MiGroupByService
            '
            Me.MiGroupByService.Enabled = False
            Me.MiGroupByService.Image = Global.ServicesPlus.My.Resources.Resources.Grouping
            Me.MiGroupByService.Name = "MiGroupByService"
            Me.MiGroupByService.Size = New System.Drawing.Size(156, 22)
            Me.MiGroupByService.Text = Global.ServicesPlus.My.Resources.Resources.TextGroupBy
            '
            'MiViewService
            '
            Me.MiViewService.Enabled = False
            Me.MiViewService.Image = Global.ServicesPlus.My.Resources.Resources.View
            Me.MiViewService.Name = "MiViewService"
            Me.MiViewService.Size = New System.Drawing.Size(156, 22)
            Me.MiViewService.Text = Global.ServicesPlus.My.Resources.Resources.TextView
            '
            'MiS03
            '
            Me.MiS03.Name = "MiS03"
            Me.MiS03.Size = New System.Drawing.Size(153, 6)
            '
            'MiExportService
            '
            Me.MiExportService.Enabled = False
            Me.MiExportService.Image = Global.ServicesPlus.My.Resources.Resources.exportBlue
            Me.MiExportService.Name = "MiExportService"
            Me.MiExportService.Size = New System.Drawing.Size(156, 22)
            Me.MiExportService.Text = Global.ServicesPlus.My.Resources.Resources.TextExport
            '
            'MiS04
            '
            Me.MiS04.Name = "MiS04"
            Me.MiS04.Size = New System.Drawing.Size(153, 6)
            '
            'MiPropertiesService
            '
            Me.MiPropertiesService.Enabled = False
            Me.MiPropertiesService.Image = Global.ServicesPlus.My.Resources.Resources._Property
            Me.MiPropertiesService.Name = "MiPropertiesService"
            Me.MiPropertiesService.Size = New System.Drawing.Size(156, 22)
            Me.MiPropertiesService.Text = Global.ServicesPlus.My.Resources.Resources.TextProperties
            '
            'CmName
            '
            Me.CmName.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmName.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiSortName})
            Me.CmName.Name = "CmName"
            Me.CmName.Size = New System.Drawing.Size(160, 26)
            '
            'MiSortName
            '
            Me.MiSortName.Image = Global.ServicesPlus.My.Resources.Resources.Sorting
            Me.MiSortName.Name = "MiSortName"
            Me.MiSortName.Size = New System.Drawing.Size(159, 22)
            Me.MiSortName.Text = Global.ServicesPlus.My.Resources.Resources.TextSortAscending
            '
            'CmLogon
            '
            Me.CmLogon.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmLogon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiSortLogon, Me.MiGroupByLogon, Me.MiFilterLogon})
            Me.CmLogon.Name = "CmName"
            Me.CmLogon.Size = New System.Drawing.Size(167, 70)
            '
            'MiSortLogon
            '
            Me.MiSortLogon.Image = Global.ServicesPlus.My.Resources.Resources.Sorting
            Me.MiSortLogon.Name = "MiSortLogon"
            Me.MiSortLogon.Size = New System.Drawing.Size(166, 22)
            Me.MiSortLogon.Text = Global.ServicesPlus.My.Resources.Resources.TextSortAscending
            '
            'MiGroupByLogon
            '
            Me.MiGroupByLogon.Image = Global.ServicesPlus.My.Resources.Resources.Grouping
            Me.MiGroupByLogon.Name = "MiGroupByLogon"
            Me.MiGroupByLogon.Size = New System.Drawing.Size(166, 22)
            Me.MiGroupByLogon.Text = Global.ServicesPlus.My.Resources.Resources.TextGroupByLogOn
            '
            'MiFilterLogon
            '
            Me.MiFilterLogon.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem12})
            Me.MiFilterLogon.Image = Global.ServicesPlus.My.Resources.Resources.filtering
            Me.MiFilterLogon.Name = "MiFilterLogon"
            Me.MiFilterLogon.Size = New System.Drawing.Size(166, 22)
            Me.MiFilterLogon.Text = Global.ServicesPlus.My.Resources.Resources.TextFilter
            '
            'ToolStripMenuItem12
            '
            Me.ToolStripMenuItem12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
            Me.ToolStripMenuItem12.Size = New System.Drawing.Size(152, 22)
            Me.ToolStripMenuItem12.Text = Global.ServicesPlus.My.Resources.Resources.TextShowAll
            '
            'CmStartMode
            '
            Me.CmStartMode.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmStartMode.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiSortStartMode, Me.MiGroupByStartMode, Me.MiFilterStartMode})
            Me.CmStartMode.Name = "CmName"
            Me.CmStartMode.Size = New System.Drawing.Size(170, 70)
            '
            'MiSortStartMode
            '
            Me.MiSortStartMode.Image = Global.ServicesPlus.My.Resources.Resources.Sorting
            Me.MiSortStartMode.Name = "MiSortStartMode"
            Me.MiSortStartMode.Size = New System.Drawing.Size(169, 22)
            Me.MiSortStartMode.Text = Global.ServicesPlus.My.Resources.Resources.TextSortAscending
            '
            'MiGroupByStartMode
            '
            Me.MiGroupByStartMode.Image = Global.ServicesPlus.My.Resources.Resources.Grouping
            Me.MiGroupByStartMode.Name = "MiGroupByStartMode"
            Me.MiGroupByStartMode.Size = New System.Drawing.Size(169, 22)
            Me.MiGroupByStartMode.Text = Global.ServicesPlus.My.Resources.Resources.TextGroupByStartupType
            '
            'MiFilterStartMode
            '
            Me.MiFilterStartMode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubFilterStartModeShowAll, Me.SubFilterStartModeManual, Me.SubFilterStartModeAutomatic, Me.SubFilterStartModeDisabled})
            Me.MiFilterStartMode.Image = Global.ServicesPlus.My.Resources.Resources.filtering
            Me.MiFilterStartMode.Name = "MiFilterStartMode"
            Me.MiFilterStartMode.Size = New System.Drawing.Size(169, 22)
            Me.MiFilterStartMode.Text = Global.ServicesPlus.My.Resources.Resources.TextFilter
            '
            'SubFilterStartModeShowAll
            '
            Me.SubFilterStartModeShowAll.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SubFilterStartModeShowAll.Name = "SubFilterStartModeShowAll"
            Me.SubFilterStartModeShowAll.Size = New System.Drawing.Size(133, 22)
            Me.SubFilterStartModeShowAll.Text = Global.ServicesPlus.My.Resources.Resources.TextShowAll
            '
            'SubFilterStartModeManual
            '
            Me.SubFilterStartModeManual.Name = "SubFilterStartModeManual"
            Me.SubFilterStartModeManual.Size = New System.Drawing.Size(133, 22)
            Me.SubFilterStartModeManual.Text = Global.ServicesPlus.My.Resources.Resources.TextManual
            '
            'SubFilterStartModeAutomatic
            '
            Me.SubFilterStartModeAutomatic.Name = "SubFilterStartModeAutomatic"
            Me.SubFilterStartModeAutomatic.Size = New System.Drawing.Size(133, 22)
            Me.SubFilterStartModeAutomatic.Text = Global.ServicesPlus.My.Resources.Resources.TextAutomatic
            '
            'SubFilterStartModeDisabled
            '
            Me.SubFilterStartModeDisabled.Name = "SubFilterStartModeDisabled"
            Me.SubFilterStartModeDisabled.Size = New System.Drawing.Size(133, 22)
            Me.SubFilterStartModeDisabled.Text = Global.ServicesPlus.My.Resources.Resources.TextDisabled
            '
            'CmStatus
            '
            Me.CmStatus.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiSortStats, Me.MiGroupByStatus, Me.MiFilterStatus})
            Me.CmStatus.Name = "CmName"
            Me.CmStatus.Size = New System.Drawing.Size(164, 70)
            '
            'MiSortStats
            '
            Me.MiSortStats.Image = Global.ServicesPlus.My.Resources.Resources.Sorting
            Me.MiSortStats.Name = "MiSortStats"
            Me.MiSortStats.Size = New System.Drawing.Size(163, 22)
            Me.MiSortStats.Text = Global.ServicesPlus.My.Resources.Resources.TextSortAscending
            '
            'MiGroupByStatus
            '
            Me.MiGroupByStatus.Image = Global.ServicesPlus.My.Resources.Resources.Grouping
            Me.MiGroupByStatus.Name = "MiGroupByStatus"
            Me.MiGroupByStatus.Size = New System.Drawing.Size(163, 22)
            Me.MiGroupByStatus.Text = Global.ServicesPlus.My.Resources.Resources.TextGroupByStatus
            '
            'MiFilterStatus
            '
            Me.MiFilterStatus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubFilterStatusShowAll, Me.SubFilterStatusRunning, Me.SubFilterStatusStopped, Me.SubFilterStatusPaused})
            Me.MiFilterStatus.Image = Global.ServicesPlus.My.Resources.Resources.filtering
            Me.MiFilterStatus.Name = "MiFilterStatus"
            Me.MiFilterStatus.Size = New System.Drawing.Size(163, 22)
            Me.MiFilterStatus.Text = Global.ServicesPlus.My.Resources.Resources.TextFilter
            '
            'SubFilterStatusShowAll
            '
            Me.SubFilterStatusShowAll.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SubFilterStatusShowAll.Name = "SubFilterStatusShowAll"
            Me.SubFilterStatusShowAll.Size = New System.Drawing.Size(126, 22)
            Me.SubFilterStatusShowAll.Text = Global.ServicesPlus.My.Resources.Resources.TextShowAll
            '
            'SubFilterStatusRunning
            '
            Me.SubFilterStatusRunning.Name = "SubFilterStatusRunning"
            Me.SubFilterStatusRunning.Size = New System.Drawing.Size(126, 22)
            Me.SubFilterStatusRunning.Text = Global.ServicesPlus.My.Resources.Resources.TextRunning
            '
            'SubFilterStatusStopped
            '
            Me.SubFilterStatusStopped.Name = "SubFilterStatusStopped"
            Me.SubFilterStatusStopped.Size = New System.Drawing.Size(126, 22)
            Me.SubFilterStatusStopped.Text = Global.ServicesPlus.My.Resources.Resources.TextStopped
            '
            'SubFilterStatusPaused
            '
            Me.SubFilterStatusPaused.Name = "SubFilterStatusPaused"
            Me.SubFilterStatusPaused.Size = New System.Drawing.Size(126, 22)
            Me.SubFilterStatusPaused.Text = Global.ServicesPlus.My.Resources.Resources.TextPaused
            '
            'CmServiceType
            '
            Me.CmServiceType.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmServiceType.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiSortServiceType, Me.MiGroupByServiceType, Me.MiFilterByServiceType})
            Me.CmServiceType.Name = "CmServiceType"
            Me.CmServiceType.Size = New System.Drawing.Size(168, 70)
            '
            'MiSortServiceType
            '
            Me.MiSortServiceType.Image = Global.ServicesPlus.My.Resources.Resources.Sorting
            Me.MiSortServiceType.Name = "MiSortServiceType"
            Me.MiSortServiceType.Size = New System.Drawing.Size(167, 22)
            Me.MiSortServiceType.Text = Global.ServicesPlus.My.Resources.Resources.TextSortDescending
            '
            'MiGroupByServiceType
            '
            Me.MiGroupByServiceType.Image = Global.ServicesPlus.My.Resources.Resources.Grouping
            Me.MiGroupByServiceType.Name = "MiGroupByServiceType"
            Me.MiGroupByServiceType.Size = New System.Drawing.Size(167, 22)
            Me.MiGroupByServiceType.Text = Global.ServicesPlus.My.Resources.Resources.TextGroupByType
            '
            'MiFilterByServiceType
            '
            Me.MiFilterByServiceType.Image = Global.ServicesPlus.My.Resources.Resources.filtering
            Me.MiFilterByServiceType.Name = "MiFilterByServiceType"
            Me.MiFilterByServiceType.Size = New System.Drawing.Size(167, 22)
            Me.MiFilterByServiceType.Text = Global.ServicesPlus.My.Resources.Resources.TextFilter
            '
            'MiEdit
            '
            Me.MiEditService.Enabled = False
            Me.MiEditService.ForeColor = System.Drawing.Color.Red
            Me.MiEditService.Name = "MiEdit"
            Me.MiEditService.Size = New System.Drawing.Size(156, 22)
            Me.MiEditService.Text = Global.ServicesPlus.My.Resources.Resources.TextEdit
            '
            'ListViewNf
            '
            Me.AllowColumnReorder = True
            Me.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColDisplayName, Me.ColStatus, Me.ColStartType, Me.ColType, Me.ColLogin, Me.ColDesc, Me.KEY})
            Me.ContextMenuStrip = Me.CmService
            Me.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FullRowSelect = True
            Me.HideSelection = False
            Me.LargeImageList = Me.ImageListLarge
            Me.Location = New System.Drawing.Point(247, 42)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.MultiSelect = False
            Me.SmallImageList = Me.ImageListSmall
            Me.Sorting = System.Windows.Forms.SortOrder.Ascending
            Me.UseCompatibleStateImageBehavior = False
            Me.CmService.ResumeLayout(False)
            Me.CmName.ResumeLayout(False)
            Me.CmLogon.ResumeLayout(False)
            Me.CmStartMode.ResumeLayout(False)
            Me.CmStatus.ResumeLayout(False)
            Me.CmServiceType.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Protected Overrides Sub OnSelectedIndexChanged(e As EventArgs)
            Trace()
            If SelectedItems.Count > 0 Then
                Dim currentService = GetSelectedService()
                RaiseEvent OnServiceChanged(Me, New ServiceEventArgs With {.Service = currentService})
            Else
                RaiseEvent OnServiceChanged(Me, New ServiceEventArgs With {.Service = Nothing})
            End If
            UpdateServiceUi()
            MyBase.OnSelectedIndexChanged(e)
        End Sub

        Private Sub UpdateServiceUi()
            Dim currentService = GetSelectedService()
            Dim capabilities = currentService.Capablites
            MiStartService.Enabled = capabilities.CanStart
            MiStopService.Enabled = capabilities.CanStop
            MiPauseService.Enabled = capabilities.CanPause
            MiResumeService.Enabled = capabilities.CanResume
            MiRestartService.Enabled = capabilities.CanRestart
            MiDeleteService.Enabled = capabilities.CanDelete
            MiEditService.Enabled = True

            MiPropertiesService.Enabled = CBool(currentService IsNot Nothing)
            CmService.Enabled = True
            MiRefreshService.Enabled = True
            MiGroupByService.Enabled = True
            MiViewService.Enabled = True
            MiExportService.Enabled = True
            MiPropertiesService.Enabled = True


        End Sub

        Public Function GetSelectedService() As Service
            Trace()
            If SelectedItems.Count > 0 Then
                Dim serviceName = SelectedItems(0).SubItems(TextKey).Text
                Dim service =
                        Services.Where(Function(p) p.ServiceName.ToUpperInvariant = serviceName.ToUpperInvariant).
                        FirstOrDefault
                Return service
            Else
                Return Nothing
            End If
        End Function

        Private Sub ListViewNF_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles Me.ColumnClick
            _colClickEventArgs = e
            ListSorting()
        End Sub

        Private Sub ResetCols()
            Trace()
            For Each c As ColumnHeader In Columns
                c.ImageIndex = -1
                c.TextAlign = HorizontalAlignment.Left
            Next
        End Sub

        Private Sub ListSorting()
            Trace()
            Sorting = If(Sorting = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending)
            Sort()
            ListViewItemSorter = New ListViewItemComparer(_colClickEventArgs.Column, Sorting)
            ResetCols()
            Columns(_colClickEventArgs.Column).ImageIndex = If(Sorting = SortOrder.Ascending, 8, 9)
            SetTheme()
        End Sub

        Private Sub Me_ColumnContextMenu(sender As Object, e As ColumnConextMenuEventArgs) Handles Me.ColumnContextMenu
            Trace()
            Dim sort = TextSortDescending
            If Sorting = SortOrder.Descending Or Sorting = SortOrder.None Then
                sort = TextSortAscending
            End If

            If e.Column Is ColStatus Then
                MiSortStats.Text = sort
                CmStatus.Show(MousePosition)
            End If

            If e.Column Is ColStartType Then
                MiSortStartMode.Text = sort
                CmStartMode.Show(MousePosition)
            End If

            If e.Column Is ColLogin Then
                MiSortLogon.Text = sort
                CmLogon.Show(MousePosition)
            End If

            If e.Column Is ColType Then
                MiSortServiceType.Text = sort
                CmServiceType.Show(MousePosition)
            End If
        End Sub

        Private Sub MiSortStats_Click(sender As Object, e As EventArgs) Handles MiSortStats.Click
            _colClickEventArgs = New ColumnClickEventArgs(ColStatus.Index)
            ListSorting()
        End Sub

        Private Sub MiSortLogon_Click(sender As Object, e As EventArgs) Handles MiSortLogon.Click
            _colClickEventArgs = New ColumnClickEventArgs(ColLogin.Index)
            ListSorting()
        End Sub

        Private Sub MiSortName_Click(sender As Object, e As EventArgs) Handles MiSortName.Click
            _colClickEventArgs = New ColumnClickEventArgs(ColName.Index)
            ListSorting()
        End Sub

        Private Sub MiSortStartMode_Click(sender As Object, e As EventArgs) Handles MiSortStartMode.Click
            _colClickEventArgs = New ColumnClickEventArgs(ColStartType.Index)
            ListSorting()
        End Sub

        Private Sub MiGroupByLogon_Click(sender As Object, e As EventArgs) Handles MiGroupByLogon.Click
            GroupBy = ServiceColumn.LogOn
        End Sub

        Private Sub MiGroupByStartMode_Click(sender As Object, e As EventArgs) Handles MiGroupByStartMode.Click
            GroupBy = ServiceColumn.StartType
        End Sub

        Private Sub MiGroupByStatus_Click(sender As Object, e As EventArgs) Handles MiGroupByStatus.Click
            GroupBy = ServiceColumn.Status
        End Sub

        Private Sub SubFilterStartModeAutomatic_Click(sender As Object, e As EventArgs) _
            Handles SubFilterStartModeAutomatic.Click
            SearchBy = New SearchBy With {.Keyword = "Automatic", .SearchBy = ServiceColumn.StartType}
        End Sub

        Private Sub SubFilterStartModeDisabled_Click(sender As Object, e As EventArgs) _
            Handles SubFilterStartModeDisabled.Click
            SearchBy = New SearchBy With {.Keyword = "Disabled", .SearchBy = ServiceColumn.StartType}
        End Sub

        Private Sub SubFilterStartModeManual_Click(sender As Object, e As EventArgs) _
            Handles SubFilterStartModeManual.Click
            SearchBy = New SearchBy With {.Keyword = "Manual", .SearchBy = ServiceColumn.StartType}
        End Sub

        Private Sub SubFilterStartModeShowAll_Click(sender As Object, e As EventArgs) _
            Handles SubFilterStartModeShowAll.Click
            SearchBy = New SearchBy With {.Keyword = "", .SearchBy = ServiceColumn.None}
        End Sub

        Private Sub SubFilterStatusPaused_Click(sender As Object, e As EventArgs) Handles SubFilterStatusPaused.Click
            SearchBy = New SearchBy With {.Keyword = "Paused", .SearchBy = ServiceColumn.Status}
        End Sub

        Private Sub SubFilterStatusRunning_Click(sender As Object, e As EventArgs) Handles SubFilterStatusRunning.Click
            SearchBy = New SearchBy With {.Keyword = "Running", .SearchBy = ServiceColumn.Status}
        End Sub

        Private Sub SubFilterStatusShowAll_Click(sender As Object, e As EventArgs) Handles SubFilterStatusShowAll.Click
            SearchBy = New SearchBy With {.Keyword = "", .SearchBy = ServiceColumn.None}
        End Sub

        Private Sub SubFilterStatusStopped_Click(sender As Object, e As EventArgs) Handles SubFilterStatusStopped.Click
            SearchBy = New SearchBy With {.Keyword = "Stopped", .SearchBy = ServiceColumn.Status}
        End Sub

        Private Sub ListViewNF_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
            ShowProperties()
        End Sub

        Private Sub ShowProperties()
            Trace()
            Dim service = GetSelectedService()
            If service IsNot Nothing Then
                SelectedItems(0).Font = New Font(SelectedItems(0).Font, FontStyle.Bold)
                RaiseEvent OnServiceProperty(Me, New ServiceEventArgs With {.Service = service})
                SelectedItems(0).Font = New Font(SelectedItems(0).Font, If(service.IsSystem, FontStyle.Italic, FontStyle.Regular))
            End If
        End Sub

        Private Sub LogonFilter_Click(sender As Object, e As EventArgs)
            Dim filter = DirectCast(sender, ToolStripItem).Text
            If filter = TextShowAll Then
                SearchBy = New SearchBy With {.Keyword = "", .SearchBy = ServiceColumn.None}
            Else
                SearchBy = New SearchBy With {.Keyword = filter, .SearchBy = ServiceColumn.LogOn}
            End If
        End Sub

        Private Sub ServiceTypeFilter_Click(sender As Object, e As EventArgs)
            Dim filter = DirectCast(sender, ToolStripItem).Text
            If filter = TextShowAll Then
                SearchBy = New SearchBy With {.Keyword = "", .SearchBy = ServiceColumn.None}
            Else
                SearchBy = New SearchBy With {.Keyword = filter, .SearchBy = ServiceColumn.ServiceType}
            End If
        End Sub

        Protected Overrides Sub OnColumnWidthChanging(e As ColumnWidthChangingEventArgs)
            If e IsNot Nothing AndAlso e.ColumnIndex = Key.Index Then
                e.Cancel = True
                e.NewWidth = 0
            End If
            MyBase.OnColumnWidthChanging(e)
        End Sub

        Private Sub MiStartService_Click(sender As Object, e As EventArgs) Handles MiStartService.Click
            RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Start})
        End Sub

        Private Sub MiStopService_Click(sender As Object, e As EventArgs) Handles MiStopService.Click
            RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Stop})
        End Sub

        Private Sub MiResumeService_Click(sender As Object, e As EventArgs) Handles MiResumeService.Click
            RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Resume})
        End Sub

        Private Sub MiRestartService_Click(sender As Object, e As EventArgs) Handles MiRestartService.Click
            RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Restart})
        End Sub

        Private Sub MiPauseService_Click(sender As Object, e As EventArgs) Handles MiPauseService.Click
            RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Pause})
        End Sub

        Private Sub MiRefreshService_Click(sender As Object, e As EventArgs) Handles MiRefreshService.Click
            RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Refresh})
        End Sub

        Private Sub MiPropertiesService_Click(sender As Object, e As EventArgs) Handles MiPropertiesService.Click
            ShowProperties()
        End Sub

        Private Sub MiGroupByServiceType_Click(sender As Object, e As EventArgs) Handles MiGroupByServiceType.Click
            GroupBy = ServiceColumn.ServiceType
        End Sub

        Private Sub MiDeleteService_Click(sender As Object, e As EventArgs) Handles MiDeleteService.Click
            Dim objDelete As New frmDelete
            If objDelete.Open(GetSelectedService) Then
                RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Refresh})
            End If
        End Sub

        Private Sub MiEditService_Click(sender As Object, e As EventArgs) Handles MiEditService.Click
            Dim objEdit As New FrmEditService
            objEdit.Open(GetSelectedService, Me.Identity)
            RaiseEvent OnAction(sender, New ActionEventArgs With {.Action = ServiceAction.Refresh})
        End Sub
    End Class

    Friend Class ColumnConextMenuEventArgs
        Inherits EventArgs

        Property Column As ColumnHeader
    End Class
End Namespace