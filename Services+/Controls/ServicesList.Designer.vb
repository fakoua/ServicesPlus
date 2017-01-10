Imports ServicesPlus.Forms.MetroModal
Imports ServicesPlus.BLL.OM

Namespace Controls

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ServicesList
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            CMGroupBy = New System.Windows.Forms.ContextMenuStrip(Me.components)
            miNoneGroupBy = New System.Windows.Forms.ToolStripMenuItem()
            miStatusGroupBy = New System.Windows.Forms.ToolStripMenuItem()
            miStartupTypeGroupBy = New System.Windows.Forms.ToolStripMenuItem()
            MiServiceTypeGroupBy = New System.Windows.Forms.ToolStripMenuItem()
            miLogonGroupBy = New System.Windows.Forms.ToolStripMenuItem()
            CMView = New System.Windows.Forms.ContextMenuStrip(Me.components)
            miLargeIconView = New System.Windows.Forms.ToolStripMenuItem()
            miListView = New System.Windows.Forms.ToolStripMenuItem()
            miDetailsView = New System.Windows.Forms.ToolStripMenuItem()
            miTileView = New System.Windows.Forms.ToolStripMenuItem()
            viewStatusbar = New System.Windows.Forms.ToolStripDropDownButton()
            PanelLeft = New System.Windows.Forms.Panel()
            ServerInfo1 = New ServicesPlus.Controls.ServerInfo()
            ServiceDescription1 = New ServicesPlus.Controls.ServiceDescription()
            CMExport = New System.Windows.Forms.ContextMenuStrip(Me.components)
            MiCsvFormatExport = New System.Windows.Forms.ToolStripMenuItem()
            MiHtmlFormatExport = New System.Windows.Forms.ToolStripMenuItem()
            btnExport = New System.Windows.Forms.ToolStripDropDownButton()
            StatusMain = New System.Windows.Forms.StatusStrip()
            lblServices = New System.Windows.Forms.ToolStripStatusLabel()
            Loading1 = New ServicesPlus.Controls.Loading()
            LVServices = New ServicesPlus.Controls.ListViewNf()
            Header = New ServicesPlus.Controls.ListHeader()
            MetroModal1 = New ServicesPlus.Forms.MetroModal.MetroModal(Me.components)
            CMGroupBy.SuspendLayout()
            CMView.SuspendLayout()
            PanelLeft.SuspendLayout()
            CMExport.SuspendLayout()
            StatusMain.SuspendLayout()
            SuspendLayout()
            '
            'CMGroupBy
            '
            CMGroupBy.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CMGroupBy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miNoneGroupBy, miStatusGroupBy, miStartupTypeGroupBy, MiServiceTypeGroupBy, miLogonGroupBy})
            CMGroupBy.Name = "CMGroupBy"
            CMGroupBy.Size = New System.Drawing.Size(153, 136)
            '
            'miNoneGroupBy
            '
            miNoneGroupBy.Checked = True
            miNoneGroupBy.CheckState = System.Windows.Forms.CheckState.Checked
            miNoneGroupBy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            miNoneGroupBy.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            miNoneGroupBy.Name = "miNoneGroupBy"
            miNoneGroupBy.Size = New System.Drawing.Size(152, 22)
            miNoneGroupBy.Text = Global.ServicesPlus.My.Resources.Resources.TextNone
            '
            'miStatusGroupBy
            '
            miStatusGroupBy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            miStatusGroupBy.Name = "miStatusGroupBy"
            miStatusGroupBy.Size = New System.Drawing.Size(152, 22)
            miStatusGroupBy.Text = Global.ServicesPlus.My.Resources.Resources.TextStatus
            '
            'miStartupTypeGroupBy
            '
            miStartupTypeGroupBy.Name = "miStartupTypeGroupBy"
            miStartupTypeGroupBy.Size = New System.Drawing.Size(152, 22)
            miStartupTypeGroupBy.Text = Global.ServicesPlus.My.Resources.Resources.TextStartType
            '
            'miServiceTypeGroupBy
            '
            MiServiceTypeGroupBy.Name = "miServiceTypeGroupBy"
            MiServiceTypeGroupBy.Size = New System.Drawing.Size(152, 22)
            MiServiceTypeGroupBy.Text = "Service Type"
            '
            'miLogonGroupBy
            '
            miLogonGroupBy.Name = "miLogonGroupBy"
            miLogonGroupBy.Size = New System.Drawing.Size(152, 22)
            miLogonGroupBy.Text = Global.ServicesPlus.My.Resources.Resources.TextLogon
            '
            'CMView
            '
            CMView.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CMView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miLargeIconView, miListView, miDetailsView, miTileView})
            CMView.Name = "CMView"
            CMView.OwnerItem = viewStatusbar
            CMView.Size = New System.Drawing.Size(135, 92)
            '
            'miLargeIconView
            '
            miLargeIconView.Image = Global.ServicesPlus.My.Resources.Resources.ViewIcon
            miLargeIconView.Name = "miLargeIconView"
            miLargeIconView.Size = New System.Drawing.Size(134, 22)
            miLargeIconView.Text = Global.ServicesPlus.My.Resources.Resources.TextLargeIcon
            '
            'miListView
            '
            miListView.Image = Global.ServicesPlus.My.Resources.Resources.ViewList
            miListView.Name = "miListView"
            miListView.Size = New System.Drawing.Size(134, 22)
            miListView.Text = Global.ServicesPlus.My.Resources.Resources.TextList
            '
            'miDetailsView
            '
            miDetailsView.Checked = True
            miDetailsView.CheckState = System.Windows.Forms.CheckState.Checked
            miDetailsView.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            miDetailsView.Image = Global.ServicesPlus.My.Resources.Resources.ViewDetails
            miDetailsView.Name = "miDetailsView"
            miDetailsView.Size = New System.Drawing.Size(134, 22)
            miDetailsView.Text = Global.ServicesPlus.My.Resources.Resources.TextDetails
            '
            'miTileView
            '
            miTileView.Image = Global.ServicesPlus.My.Resources.Resources.ViewTile
            miTileView.Name = "miTileView"
            miTileView.Size = New System.Drawing.Size(134, 22)
            miTileView.Text = Global.ServicesPlus.My.Resources.Resources.TextTile
            '
            'viewStatusbar
            '
            viewStatusbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            viewStatusbar.DropDown = CMView
            viewStatusbar.Image = Global.ServicesPlus.My.Resources.Resources.ViewWhite
            viewStatusbar.ImageTransparentColor = System.Drawing.Color.Magenta
            viewStatusbar.Name = "viewStatusbar"
            viewStatusbar.Size = New System.Drawing.Size(29, 20)
            '
            'PanelLeft
            '
            PanelLeft.Controls.Add(Me.ServerInfo1)
            PanelLeft.Controls.Add(Me.ServiceDescription1)
            PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
            PanelLeft.Location = New System.Drawing.Point(0, 42)
            PanelLeft.Name = "PanelLeft"
            PanelLeft.Size = New System.Drawing.Size(247, 587)
            PanelLeft.TabIndex = 8
            '
            'ServerInfo1
            '
            ServerInfo1.BackColor = System.Drawing.Color.White
            ServerInfo1.Dock = System.Windows.Forms.DockStyle.Bottom
            ServerInfo1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ServerInfo1.Location = New System.Drawing.Point(0, 426)
            ServerInfo1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            ServerInfo1.Name = "ServerInfo1"
            ServerInfo1.Size = New System.Drawing.Size(247, 161)
            ServerInfo1.TabIndex = 1
            '
            'ServiceDescription1
            '
            ServiceDescription1.BackColor = System.Drawing.Color.White
            ServiceDescription1.Dock = System.Windows.Forms.DockStyle.Top
            ServiceDescription1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ServiceDescription1.Location = New System.Drawing.Point(0, 0)
            ServiceDescription1.Name = "ServiceDescription1"
            ServiceDescription1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
            ServiceDescription1.Service = Nothing
            ServiceDescription1.Size = New System.Drawing.Size(247, 478)
            ServiceDescription1.TabIndex = 0
            '
            'CMExport
            '
            CMExport.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CMExport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiCsvFormatExport, MiHtmlFormatExport})
            CMExport.Name = "CMExport"
            CMExport.OwnerItem = btnExport
            CMExport.Size = New System.Drawing.Size(147, 48)
            '
            'miCSVFormatExport
            '
            MiCsvFormatExport.Image = Global.ServicesPlus.My.Resources.Resources.csv
            MiCsvFormatExport.Name = "miCSVFormatExport"
            MiCsvFormatExport.Size = New System.Drawing.Size(146, 22)
            MiCsvFormatExport.Text = Global.ServicesPlus.My.Resources.Resources.TextCSVFormat
            '
            'miHtmlFormatExport
            '
            MiHtmlFormatExport.Image = Global.ServicesPlus.My.Resources.Resources.html
            MiHtmlFormatExport.Name = "miHtmlFormatExport"
            MiHtmlFormatExport.Size = New System.Drawing.Size(146, 22)
            MiHtmlFormatExport.Text = Global.ServicesPlus.My.Resources.Resources.TextHtmlFormat
            '
            'btnExport
            '
            btnExport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
            btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            btnExport.DropDown = CMExport
            btnExport.ForeColor = System.Drawing.Color.White
            btnExport.Image = Global.ServicesPlus.My.Resources.Resources.exportWhite
            btnExport.ImageTransparentColor = System.Drawing.Color.Magenta
            btnExport.Name = "btnExport"
            btnExport.Size = New System.Drawing.Size(29, 20)
            btnExport.Text = Global.ServicesPlus.My.Resources.Resources.TextExport
            '
            'StatusMain
            '
            StatusMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            StatusMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.viewStatusbar, lblServices, btnExport})
            StatusMain.Location = New System.Drawing.Point(247, 607)
            StatusMain.Name = "StatusMain"
            StatusMain.Size = New System.Drawing.Size(703, 22)
            StatusMain.SizingGrip = False
            StatusMain.TabIndex = 9
            '
            'lblServices
            '
            lblServices.ForeColor = System.Drawing.Color.White
            lblServices.Name = "lblServices"
            lblServices.Size = New System.Drawing.Size(630, 17)
            lblServices.Spring = True
            lblServices.Text = Global.ServicesPlus.My.Resources.Resources.TempServices
            '
            'Loading1
            '
            Loading1.BackColor = System.Drawing.Color.White
            Loading1.Location = New System.Drawing.Point(157, 10)
            Loading1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
            Loading1.Name = "Loading1"
            Loading1.Size = New System.Drawing.Size(90, 64)
            Loading1.TabIndex = 6
            Loading1.Visible = False
            '
            'LVServices
            '
            LVServices.AllowColumnReorder = True
            LVServices.BorderStyle = System.Windows.Forms.BorderStyle.None
            LVServices.Dock = System.Windows.Forms.DockStyle.Fill
            LVServices.DropDownExport = CMExport
            LVServices.DropDownGroupBy = CMGroupBy
            LVServices.DropDownView = CMView
            LVServices.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            LVServices.FullRowSelect = True
            LVServices.GroupBy = ServicesPlus.BLL.OM.ServiceColumn.None
            LVServices.HideSelection = False
            LVServices.Location = New System.Drawing.Point(247, 42)
            LVServices.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            LVServices.MultiSelect = False
            LVServices.Name = "LVServices"
            LVServices.Services = Nothing
            LVServices.ShowSystemServices = False
            LVServices.Size = New System.Drawing.Size(703, 565)
            LVServices.Sorting = System.Windows.Forms.SortOrder.Ascending
            LVServices.TabIndex = 3
            LVServices.UseCompatibleStateImageBehavior = False
            LVServices.View = System.Windows.Forms.View.Details
            '
            'Header
            '
            Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
            Header.Dock = System.Windows.Forms.DockStyle.Top
            Header.DropDownGroupBy = CMGroupBy
            Header.DropDownView = CMView
            Header.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Header.Location = New System.Drawing.Point(0, 0)
            Header.Margin = New System.Windows.Forms.Padding(0)
            Header.Name = "Header"
            Header.ServerName = ""
            Header.Size = New System.Drawing.Size(950, 42)
            Header.TabIndex = 7
            '
            'ServicesList
            '
            AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            BackColor = System.Drawing.Color.White
            Controls.Add(Me.Loading1)
            Controls.Add(Me.LVServices)
            Controls.Add(Me.StatusMain)
            Controls.Add(Me.PanelLeft)
            Controls.Add(Me.Header)
            Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Margin = New System.Windows.Forms.Padding(0, 4, 3, 4)
            Name = "ServicesList"
            Size = New System.Drawing.Size(950, 629)
            CMGroupBy.ResumeLayout(False)
            CMView.ResumeLayout(False)
            PanelLeft.ResumeLayout(False)
            CMExport.ResumeLayout(False)
            StatusMain.ResumeLayout(False)
            StatusMain.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Friend WithEvents LVServices As ListViewNF
        Friend WithEvents Loading1 As Loading
        Friend WithEvents Header As ListHeader
        Friend WithEvents PanelLeft As System.Windows.Forms.Panel
        Friend WithEvents ServiceDescription1 As ServiceDescription
        Friend WithEvents ServerInfo1 As ServerInfo
        Friend WithEvents miNoneGroupBy As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents miStatusGroupBy As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents miStartupTypeGroupBy As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents miLogonGroupBy As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MetroModal1 As MetroModal
        Friend WithEvents miLargeIconView As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents miListView As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents miDetailsView As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents miTileView As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CMGroupBy As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents CMView As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents StatusMain As System.Windows.Forms.StatusStrip
        Friend WithEvents lblServices As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents btnExport As System.Windows.Forms.ToolStripDropDownButton
        Friend WithEvents CMExport As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents MiCsvFormatExport As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MiHtmlFormatExport As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents viewStatusbar As System.Windows.Forms.ToolStripDropDownButton
        Friend WithEvents MiServiceTypeGroupBy As System.Windows.Forms.ToolStripMenuItem

    End Class
End Namespace