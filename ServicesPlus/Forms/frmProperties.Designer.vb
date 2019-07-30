Imports ServicesPlus.Controls

Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmProperties
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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
            Me.components = New System.ComponentModel.Container()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabGeneral = New System.Windows.Forms.TabPage()
            Me.txtLogOn = New System.Windows.Forms.TextBox()
            Me.LblLogonAsTitle = New System.Windows.Forms.Label()
            Me.LblStartupType = New System.Windows.Forms.Label()
            Me.btnRestart = New ServicesPlus.Controls.MetroButton()
            Me.Hr1 = New ServicesPlus.Controls.Hr()
            Me.linkPath = New System.Windows.Forms.LinkLabel()
            Me.txtStatus = New System.Windows.Forms.TextBox()
            Me.txtServiceName = New System.Windows.Forms.TextBox()
            Me.btnResume = New ServicesPlus.Controls.MetroButton()
            Me.lblStartType = New System.Windows.Forms.Label()
            Me.btnPause = New ServicesPlus.Controls.MetroButton()
            Me.lblPath = New System.Windows.Forms.Label()
            Me.btnStop = New ServicesPlus.Controls.MetroButton()
            Me.btnStart = New ServicesPlus.Controls.MetroButton()
            Me.lblDescription = New System.Windows.Forms.Label()
            Me.LblServiceStatusTitle = New System.Windows.Forms.Label()
            Me.lblDispalyName = New System.Windows.Forms.Label()
            Me.lblServiceName = New System.Windows.Forms.Label()
            Me.txtDescription = New System.Windows.Forms.TextBox()
            Me.txtDisplayName = New System.Windows.Forms.TextBox()
            Me.TabDependencies = New System.Windows.Forms.TabPage()
            Me.HLoader1 = New ServicesPlus.Controls.HLoader()
            Me.LblIndecatesSystemComponent = New System.Windows.Forms.Label()
            Me.LblTheFollowingServicesDepend = New System.Windows.Forms.Label()
            Me.LblThisServiceDependsOn = New System.Windows.Forms.Label()
            Me.TvDependsOnThisService = New System.Windows.Forms.TreeView()
            Me.TvDependsOn = New System.Windows.Forms.TreeView()
            Me.TabPerformance = New System.Windows.Forms.TabPage()
            Me.lblWarning = New System.Windows.Forms.Label()
            Me.Loading1 = New ServicesPlus.Controls.Loading()
            Me.PanelPerformance = New System.Windows.Forms.Panel()
            Me.lblMemoryLbl = New System.Windows.Forms.Label()
            Me.lblPeakLbl = New System.Windows.Forms.Label()
            Me.lblPeak = New System.Windows.Forms.Label()
            Me.lblMemory = New System.Windows.Forms.Label()
            Me.BtnClose = New ServicesPlus.Controls.MetroButton()
            Me.BtnEdit = New ServicesPlus.Controls.MetroButton()
            Me.CMLink = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.OpenPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.CopyPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TabControl1.SuspendLayout()
            Me.TabGeneral.SuspendLayout()
            Me.TabDependencies.SuspendLayout()
            Me.TabPerformance.SuspendLayout()
            Me.PanelPerformance.SuspendLayout()
            Me.CMLink.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabGeneral)
            Me.TabControl1.Controls.Add(Me.TabDependencies)
            Me.TabControl1.Controls.Add(Me.TabPerformance)
            Me.TabControl1.Location = New System.Drawing.Point(12, 12)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(385, 404)
            Me.TabControl1.TabIndex = 3
            '
            'TabGeneral
            '
            Me.TabGeneral.Controls.Add(Me.txtLogOn)
            Me.TabGeneral.Controls.Add(Me.LblLogonAsTitle)
            Me.TabGeneral.Controls.Add(Me.LblStartupType)
            Me.TabGeneral.Controls.Add(Me.btnRestart)
            Me.TabGeneral.Controls.Add(Me.Hr1)
            Me.TabGeneral.Controls.Add(Me.linkPath)
            Me.TabGeneral.Controls.Add(Me.txtStatus)
            Me.TabGeneral.Controls.Add(Me.txtServiceName)
            Me.TabGeneral.Controls.Add(Me.btnResume)
            Me.TabGeneral.Controls.Add(Me.lblStartType)
            Me.TabGeneral.Controls.Add(Me.btnPause)
            Me.TabGeneral.Controls.Add(Me.lblPath)
            Me.TabGeneral.Controls.Add(Me.btnStop)
            Me.TabGeneral.Controls.Add(Me.btnStart)
            Me.TabGeneral.Controls.Add(Me.lblDescription)
            Me.TabGeneral.Controls.Add(Me.LblServiceStatusTitle)
            Me.TabGeneral.Controls.Add(Me.lblDispalyName)
            Me.TabGeneral.Controls.Add(Me.lblServiceName)
            Me.TabGeneral.Controls.Add(Me.txtDescription)
            Me.TabGeneral.Controls.Add(Me.txtDisplayName)
            Me.TabGeneral.Location = New System.Drawing.Point(4, 26)
            Me.TabGeneral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.TabGeneral.Name = "TabGeneral"
            Me.TabGeneral.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.TabGeneral.Size = New System.Drawing.Size(377, 374)
            Me.TabGeneral.TabIndex = 0
            Me.TabGeneral.Text = Global.ServicesPlus.My.Resources.Resources.TextGeneral
            Me.TabGeneral.UseVisualStyleBackColor = True
            '
            'txtLogOn
            '
            Me.txtLogOn.BackColor = System.Drawing.Color.White
            Me.txtLogOn.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtLogOn.Location = New System.Drawing.Point(100, 306)
            Me.txtLogOn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txtLogOn.Name = "txtLogOn"
            Me.txtLogOn.ReadOnly = True
            Me.txtLogOn.Size = New System.Drawing.Size(270, 18)
            Me.txtLogOn.TabIndex = 21
            Me.txtLogOn.Text = "Logon"
            '
            'LblLogonAsTitle
            '
            Me.LblLogonAsTitle.AutoSize = True
            Me.LblLogonAsTitle.Location = New System.Drawing.Point(2, 306)
            Me.LblLogonAsTitle.Name = "LblLogonAsTitle"
            Me.LblLogonAsTitle.Size = New System.Drawing.Size(62, 17)
            Me.LblLogonAsTitle.TabIndex = 20
            Me.LblLogonAsTitle.Text = "Logon As:"
            '
            'LblStartupType
            '
            Me.LblStartupType.Location = New System.Drawing.Point(99, 232)
            Me.LblStartupType.Name = "LblStartupType"
            Me.LblStartupType.Size = New System.Drawing.Size(272, 25)
            Me.LblStartupType.TabIndex = 19
            '
            'btnRestart
            '
            Me.btnRestart.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.btnRestart.FixedHeight = 30
            Me.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRestart.Location = New System.Drawing.Point(298, 336)
            Me.btnRestart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnRestart.MouseDonwBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.btnRestart.Name = "btnRestart"
            Me.btnRestart.Size = New System.Drawing.Size(70, 30)
            Me.btnRestart.TabIndex = 18
            Me.btnRestart.Text = Global.ServicesPlus.My.Resources.Resources.TextRestart
            Me.btnRestart.UseVisualStyleBackColor = True
            '
            'Hr1
            '
            Me.Hr1.BackColor = System.Drawing.Color.Silver
            Me.Hr1.Location = New System.Drawing.Point(5, 268)
            Me.Hr1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Hr1.Name = "Hr1"
            Me.Hr1.Size = New System.Drawing.Size(363, 2)
            Me.Hr1.TabIndex = 17
            Me.Hr1.Thickness = 2
            '
            'linkPath
            '
            Me.linkPath.AutoEllipsis = True
            Me.linkPath.Location = New System.Drawing.Point(2, 196)
            Me.linkPath.Name = "linkPath"
            Me.linkPath.Size = New System.Drawing.Size(366, 24)
            Me.linkPath.TabIndex = 1
            '
            'txtStatus
            '
            Me.txtStatus.BackColor = System.Drawing.Color.White
            Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtStatus.Location = New System.Drawing.Point(100, 281)
            Me.txtStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txtStatus.Name = "txtStatus"
            Me.txtStatus.ReadOnly = True
            Me.txtStatus.Size = New System.Drawing.Size(266, 18)
            Me.txtStatus.TabIndex = 16
            '
            'txtServiceName
            '
            Me.txtServiceName.BackColor = System.Drawing.Color.White
            Me.txtServiceName.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtServiceName.Location = New System.Drawing.Point(99, 6)
            Me.txtServiceName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txtServiceName.Name = "txtServiceName"
            Me.txtServiceName.ReadOnly = True
            Me.txtServiceName.Size = New System.Drawing.Size(269, 18)
            Me.txtServiceName.TabIndex = 11
            '
            'btnResume
            '
            Me.btnResume.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.btnResume.FixedHeight = 30
            Me.btnResume.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.btnResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnResume.Location = New System.Drawing.Point(224, 336)
            Me.btnResume.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnResume.MouseDonwBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.btnResume.Name = "btnResume"
            Me.btnResume.Size = New System.Drawing.Size(70, 30)
            Me.btnResume.TabIndex = 6
            Me.btnResume.Text = Global.ServicesPlus.My.Resources.Resources.TextResume
            Me.btnResume.UseVisualStyleBackColor = True
            '
            'lblStartType
            '
            Me.lblStartType.AutoSize = True
            Me.lblStartType.Location = New System.Drawing.Point(2, 232)
            Me.lblStartType.Name = "lblStartType"
            Me.lblStartType.Size = New System.Drawing.Size(0, 17)
            Me.lblStartType.TabIndex = 4
            '
            'btnPause
            '
            Me.btnPause.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.btnPause.FixedHeight = 30
            Me.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPause.Location = New System.Drawing.Point(150, 336)
            Me.btnPause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnPause.MouseDonwBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.btnPause.Name = "btnPause"
            Me.btnPause.Size = New System.Drawing.Size(70, 30)
            Me.btnPause.TabIndex = 5
            Me.btnPause.Text = Global.ServicesPlus.My.Resources.Resources.TextPause
            Me.btnPause.UseVisualStyleBackColor = True
            '
            'lblPath
            '
            Me.lblPath.AutoSize = True
            Me.lblPath.Location = New System.Drawing.Point(2, 179)
            Me.lblPath.Name = "lblPath"
            Me.lblPath.Size = New System.Drawing.Size(0, 17)
            Me.lblPath.TabIndex = 3
            '
            'btnStop
            '
            Me.btnStop.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.btnStop.FixedHeight = 30
            Me.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnStop.Location = New System.Drawing.Point(77, 336)
            Me.btnStop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnStop.MouseDonwBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.btnStop.Name = "btnStop"
            Me.btnStop.Size = New System.Drawing.Size(70, 30)
            Me.btnStop.TabIndex = 4
            Me.btnStop.Text = Global.ServicesPlus.My.Resources.Resources.TextStop
            Me.btnStop.UseVisualStyleBackColor = True
            '
            'btnStart
            '
            Me.btnStart.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.btnStart.FixedHeight = 30
            Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnStart.Location = New System.Drawing.Point(4, 336)
            Me.btnStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnStart.MouseDonwBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.btnStart.Name = "btnStart"
            Me.btnStart.Size = New System.Drawing.Size(70, 30)
            Me.btnStart.TabIndex = 3
            Me.btnStart.Text = Global.ServicesPlus.My.Resources.Resources.TextStart
            Me.btnStart.UseVisualStyleBackColor = True
            '
            'lblDescription
            '
            Me.lblDescription.AutoSize = True
            Me.lblDescription.Location = New System.Drawing.Point(2, 65)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.Size = New System.Drawing.Size(0, 17)
            Me.lblDescription.TabIndex = 2
            '
            'LblServiceStatusTitle
            '
            Me.LblServiceStatusTitle.AutoSize = True
            Me.LblServiceStatusTitle.BackColor = System.Drawing.Color.Transparent
            Me.LblServiceStatusTitle.Location = New System.Drawing.Point(1, 281)
            Me.LblServiceStatusTitle.Name = "LblServiceStatusTitle"
            Me.LblServiceStatusTitle.Size = New System.Drawing.Size(90, 17)
            Me.LblServiceStatusTitle.TabIndex = 6
            Me.LblServiceStatusTitle.Text = "Service Status:"
            '
            'lblDispalyName
            '
            Me.lblDispalyName.AutoSize = True
            Me.lblDispalyName.Location = New System.Drawing.Point(2, 35)
            Me.lblDispalyName.Name = "lblDispalyName"
            Me.lblDispalyName.Size = New System.Drawing.Size(0, 17)
            Me.lblDispalyName.TabIndex = 1
            '
            'lblServiceName
            '
            Me.lblServiceName.AutoSize = True
            Me.lblServiceName.Location = New System.Drawing.Point(2, 6)
            Me.lblServiceName.Name = "lblServiceName"
            Me.lblServiceName.Size = New System.Drawing.Size(0, 17)
            Me.lblServiceName.TabIndex = 0
            '
            'txtDescription
            '
            Me.txtDescription.BackColor = System.Drawing.Color.White
            Me.txtDescription.Location = New System.Drawing.Point(99, 65)
            Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txtDescription.Multiline = True
            Me.txtDescription.Name = "txtDescription"
            Me.txtDescription.ReadOnly = True
            Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDescription.Size = New System.Drawing.Size(269, 100)
            Me.txtDescription.TabIndex = 0
            '
            'txtDisplayName
            '
            Me.txtDisplayName.BackColor = System.Drawing.Color.White
            Me.txtDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtDisplayName.Location = New System.Drawing.Point(99, 35)
            Me.txtDisplayName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txtDisplayName.Name = "txtDisplayName"
            Me.txtDisplayName.ReadOnly = True
            Me.txtDisplayName.Size = New System.Drawing.Size(270, 18)
            Me.txtDisplayName.TabIndex = 12
            Me.txtDisplayName.WordWrap = False
            '
            'TabDependencies
            '
            Me.TabDependencies.Controls.Add(Me.HLoader1)
            Me.TabDependencies.Controls.Add(Me.LblIndecatesSystemComponent)
            Me.TabDependencies.Controls.Add(Me.LblTheFollowingServicesDepend)
            Me.TabDependencies.Controls.Add(Me.LblThisServiceDependsOn)
            Me.TabDependencies.Controls.Add(Me.TvDependsOnThisService)
            Me.TabDependencies.Controls.Add(Me.TvDependsOn)
            Me.TabDependencies.Location = New System.Drawing.Point(4, 26)
            Me.TabDependencies.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.TabDependencies.Name = "TabDependencies"
            Me.TabDependencies.Size = New System.Drawing.Size(377, 374)
            Me.TabDependencies.TabIndex = 2
            Me.TabDependencies.Text = Global.ServicesPlus.My.Resources.Resources.TextDependencies
            Me.TabDependencies.UseVisualStyleBackColor = True
            '
            'HLoader1
            '
            Me.HLoader1.Location = New System.Drawing.Point(3, 184)
            Me.HLoader1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.HLoader1.Name = "HLoader1"
            Me.HLoader1.Size = New System.Drawing.Size(371, 2)
            Me.HLoader1.Step = 2
            Me.HLoader1.TabIndex = 5
            '
            'LblIndecatesSystemComponent
            '
            Me.LblIndecatesSystemComponent.AutoSize = True
            Me.LblIndecatesSystemComponent.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblIndecatesSystemComponent.ForeColor = System.Drawing.Color.Blue
            Me.LblIndecatesSystemComponent.Location = New System.Drawing.Point(223, 168)
            Me.LblIndecatesSystemComponent.Name = "LblIndecatesSystemComponent"
            Me.LblIndecatesSystemComponent.Size = New System.Drawing.Size(145, 13)
            Me.LblIndecatesSystemComponent.TabIndex = 4
            Me.LblIndecatesSystemComponent.Text = "* indicates system component"
            '
            'LblTheFollowingServicesDepend
            '
            Me.LblTheFollowingServicesDepend.AutoSize = True
            Me.LblTheFollowingServicesDepend.Location = New System.Drawing.Point(3, 191)
            Me.LblTheFollowingServicesDepend.Name = "LblTheFollowingServicesDepend"
            Me.LblTheFollowingServicesDepend.Size = New System.Drawing.Size(264, 17)
            Me.LblTheFollowingServicesDepend.TabIndex = 3
            Me.LblTheFollowingServicesDepend.Text = "The following services depend on this service:"
            '
            'LblThisServiceDependsOn
            '
            Me.LblThisServiceDependsOn.AutoSize = True
            Me.LblThisServiceDependsOn.Location = New System.Drawing.Point(3, 5)
            Me.LblThisServiceDependsOn.Name = "LblThisServiceDependsOn"
            Me.LblThisServiceDependsOn.Size = New System.Drawing.Size(269, 17)
            Me.LblThisServiceDependsOn.TabIndex = 2
            Me.LblThisServiceDependsOn.Text = "This service depends on the following services:"
            '
            'TvDependsOnThisService
            '
            Me.TvDependsOnThisService.FullRowSelect = True
            Me.TvDependsOnThisService.Location = New System.Drawing.Point(3, 211)
            Me.TvDependsOnThisService.Name = "TvDependsOnThisService"
            Me.TvDependsOnThisService.Size = New System.Drawing.Size(371, 140)
            Me.TvDependsOnThisService.TabIndex = 1
            '
            'TvDependsOn
            '
            Me.TvDependsOn.FullRowSelect = True
            Me.TvDependsOn.Location = New System.Drawing.Point(3, 25)
            Me.TvDependsOn.Name = "TvDependsOn"
            Me.TvDependsOn.Size = New System.Drawing.Size(371, 140)
            Me.TvDependsOn.TabIndex = 0
            '
            'TabPerformance
            '
            Me.TabPerformance.Controls.Add(Me.lblWarning)
            Me.TabPerformance.Controls.Add(Me.Loading1)
            Me.TabPerformance.Controls.Add(Me.PanelPerformance)
            Me.TabPerformance.Location = New System.Drawing.Point(4, 26)
            Me.TabPerformance.Name = "TabPerformance"
            Me.TabPerformance.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPerformance.Size = New System.Drawing.Size(377, 374)
            Me.TabPerformance.TabIndex = 3
            Me.TabPerformance.Text = Global.ServicesPlus.My.Resources.Resources.TextPerformance
            Me.TabPerformance.UseVisualStyleBackColor = True
            '
            'lblWarning
            '
            Me.lblWarning.AutoSize = True
            Me.lblWarning.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblWarning.ForeColor = System.Drawing.Color.Red
            Me.lblWarning.Location = New System.Drawing.Point(6, 3)
            Me.lblWarning.Name = "lblWarning"
            Me.lblWarning.Size = New System.Drawing.Size(0, 17)
            Me.lblWarning.TabIndex = 6
            '
            'Loading1
            '
            Me.Loading1.BackColor = System.Drawing.Color.White
            Me.Loading1.Location = New System.Drawing.Point(22, 247)
            Me.Loading1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Loading1.Name = "Loading1"
            Me.Loading1.Size = New System.Drawing.Size(242, 165)
            Me.Loading1.TabIndex = 4
            Me.Loading1.Visible = False
            '
            'PanelPerformance
            '
            Me.PanelPerformance.Controls.Add(Me.lblMemoryLbl)
            Me.PanelPerformance.Controls.Add(Me.lblPeakLbl)
            Me.PanelPerformance.Controls.Add(Me.lblPeak)
            Me.PanelPerformance.Controls.Add(Me.lblMemory)
            Me.PanelPerformance.Location = New System.Drawing.Point(0, 60)
            Me.PanelPerformance.Name = "PanelPerformance"
            Me.PanelPerformance.Size = New System.Drawing.Size(374, 152)
            Me.PanelPerformance.TabIndex = 5
            Me.PanelPerformance.Visible = False
            '
            'lblMemoryLbl
            '
            Me.lblMemoryLbl.AutoSize = True
            Me.lblMemoryLbl.Location = New System.Drawing.Point(3, 10)
            Me.lblMemoryLbl.Name = "lblMemoryLbl"
            Me.lblMemoryLbl.Size = New System.Drawing.Size(0, 17)
            Me.lblMemoryLbl.TabIndex = 0
            '
            'lblPeakLbl
            '
            Me.lblPeakLbl.AutoSize = True
            Me.lblPeakLbl.Location = New System.Drawing.Point(3, 40)
            Me.lblPeakLbl.Name = "lblPeakLbl"
            Me.lblPeakLbl.Size = New System.Drawing.Size(0, 17)
            Me.lblPeakLbl.TabIndex = 1
            '
            'lblPeak
            '
            Me.lblPeak.AutoSize = True
            Me.lblPeak.Location = New System.Drawing.Point(133, 40)
            Me.lblPeak.Name = "lblPeak"
            Me.lblPeak.Size = New System.Drawing.Size(0, 17)
            Me.lblPeak.TabIndex = 3
            '
            'lblMemory
            '
            Me.lblMemory.AutoSize = True
            Me.lblMemory.Location = New System.Drawing.Point(133, 10)
            Me.lblMemory.Name = "lblMemory"
            Me.lblMemory.Size = New System.Drawing.Size(0, 17)
            Me.lblMemory.TabIndex = 2
            '
            'BtnClose
            '
            Me.BtnClose.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.BtnClose.FixedHeight = 30
            Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnClose.Location = New System.Drawing.Point(315, 423)
            Me.BtnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.BtnClose.MouseDonwBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.BtnClose.Name = "BtnClose"
            Me.BtnClose.Size = New System.Drawing.Size(78, 30)
            Me.BtnClose.TabIndex = 0
            Me.BtnClose.Text = "Close"
            Me.BtnClose.UseVisualStyleBackColor = True
            '
            'BtnEdit
            '
            Me.BtnEdit.BorderColor = System.Drawing.Color.Red
            Me.BtnEdit.FixedHeight = 30
            Me.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Red
            Me.BtnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
            Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnEdit.ForeColor = System.Drawing.Color.Red
            Me.BtnEdit.Location = New System.Drawing.Point(228, 423)
            Me.BtnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.BtnEdit.MouseDonwBackColor = System.Drawing.Color.Black
            Me.BtnEdit.Name = "BtnEdit"
            Me.BtnEdit.Size = New System.Drawing.Size(78, 30)
            Me.BtnEdit.TabIndex = 2
            Me.BtnEdit.Text = "Edit"
            Me.BtnEdit.UseVisualStyleBackColor = True
            '
            'CMLink
            '
            Me.CMLink.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMLink.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenPathToolStripMenuItem, Me.CopyPathToolStripMenuItem})
            Me.CMLink.Name = "CMLink"
            Me.CMLink.Size = New System.Drawing.Size(183, 48)
            '
            'OpenPathToolStripMenuItem
            '
            Me.OpenPathToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OpenPathToolStripMenuItem.Image = Global.ServicesPlus.My.Resources.Resources.OpenFileLocation
            Me.OpenPathToolStripMenuItem.Name = "OpenPathToolStripMenuItem"
            Me.OpenPathToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
            Me.OpenPathToolStripMenuItem.Text = Global.ServicesPlus.My.Resources.Resources.TextOpenFileLocation
            '
            'CopyPathToolStripMenuItem
            '
            Me.CopyPathToolStripMenuItem.Image = Global.ServicesPlus.My.Resources.Resources.CopyFileLocation
            Me.CopyPathToolStripMenuItem.Name = "CopyPathToolStripMenuItem"
            Me.CopyPathToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
            Me.CopyPathToolStripMenuItem.Text = Global.ServicesPlus.My.Resources.Resources.TextCopyFileLocation
            '
            'FrmProperties
            '
            Me.AcceptButton = Me.BtnClose
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(406, 466)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.BtnEdit)
            Me.Controls.Add(Me.BtnClose)
            Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.KeyPreview = True
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmProperties"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.TabControl1.ResumeLayout(False)
            Me.TabGeneral.ResumeLayout(False)
            Me.TabGeneral.PerformLayout()
            Me.TabDependencies.ResumeLayout(False)
            Me.TabDependencies.PerformLayout()
            Me.TabPerformance.ResumeLayout(False)
            Me.TabPerformance.PerformLayout()
            Me.PanelPerformance.ResumeLayout(False)
            Me.PanelPerformance.PerformLayout()
            Me.CMLink.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblServiceName As System.Windows.Forms.Label
        Friend WithEvents lblDispalyName As System.Windows.Forms.Label
        Friend WithEvents lblDescription As System.Windows.Forms.Label
        Friend WithEvents lblPath As System.Windows.Forms.Label
        Friend WithEvents lblStartType As System.Windows.Forms.Label
        Friend WithEvents LblServiceStatusTitle As System.Windows.Forms.Label
        Friend WithEvents btnStart As MetroButton
        Friend WithEvents btnStop As MetroButton
        Friend WithEvents btnResume As MetroButton
        Friend WithEvents btnPause As MetroButton
        Friend WithEvents txtServiceName As System.Windows.Forms.TextBox
        Friend WithEvents txtDescription As System.Windows.Forms.TextBox
        Friend WithEvents txtDisplayName As System.Windows.Forms.TextBox
        Friend WithEvents txtStatus As System.Windows.Forms.TextBox
        Friend WithEvents BtnEdit As MetroButton
        Friend WithEvents BtnClose As MetroButton
        Friend WithEvents linkPath As System.Windows.Forms.LinkLabel
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabGeneral As System.Windows.Forms.TabPage
        Friend WithEvents TabDependencies As System.Windows.Forms.TabPage
        Friend WithEvents TabPerformance As System.Windows.Forms.TabPage
        Friend WithEvents lblPeak As System.Windows.Forms.Label
        Friend WithEvents lblMemory As System.Windows.Forms.Label
        Friend WithEvents lblPeakLbl As System.Windows.Forms.Label
        Friend WithEvents lblMemoryLbl As System.Windows.Forms.Label
        Friend WithEvents Loading1 As Loading
        Friend WithEvents PanelPerformance As System.Windows.Forms.Panel
        Friend WithEvents Hr1 As Hr
        Friend WithEvents lblWarning As System.Windows.Forms.Label
        Friend WithEvents btnRestart As MetroButton
        Friend WithEvents CMLink As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents OpenPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CopyPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TvDependsOn As System.Windows.Forms.TreeView
        Friend WithEvents TvDependsOnThisService As System.Windows.Forms.TreeView
        Friend WithEvents LblTheFollowingServicesDepend As System.Windows.Forms.Label
        Friend WithEvents LblThisServiceDependsOn As System.Windows.Forms.Label
        Friend WithEvents LblIndecatesSystemComponent As System.Windows.Forms.Label
        Friend WithEvents HLoader1 As ServicesPlus.Controls.HLoader
        Friend WithEvents LblStartupType As System.Windows.Forms.Label
        Friend WithEvents txtLogOn As System.Windows.Forms.TextBox
        Friend WithEvents LblLogonAsTitle As System.Windows.Forms.Label
    End Class
End Namespace