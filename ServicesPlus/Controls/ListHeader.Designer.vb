Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ListHeader
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
            Me.components = New System.ComponentModel.Container()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.PicIcon = New System.Windows.Forms.PictureBox()
            Me.PanelMenu = New System.Windows.Forms.Panel()
            Me.MenuGroupView = New System.Windows.Forms.MenuStrip()
            Me.GroupByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.FlowControl = New System.Windows.Forms.FlowLayoutPanel()
            Me.PanelCaption = New System.Windows.Forms.Panel()
            Me.lblCaption = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.SearchBox1 = New ServicesPlus.Controls.SearchBox()
            Me.BtnStart = New ServicesPlus.Controls.RoundButton()
            Me.btnStop = New ServicesPlus.Controls.RoundButton()
            Me.btnPause = New ServicesPlus.Controls.RoundButton()
            Me.btnResume = New ServicesPlus.Controls.RoundButton()
            Me.btnRestart = New ServicesPlus.Controls.RoundButton()
            Me.ToggelButton1 = New ServicesPlus.Controls.ToggelButton()
            Me.BtnInstall = New ServicesPlus.Controls.RoundButton()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.PicIcon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelMenu.SuspendLayout()
            Me.MenuGroupView.SuspendLayout()
            Me.FlowControl.SuspendLayout()
            Me.PanelCaption.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 6
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.PicIcon, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.SearchBox1, 2, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.PanelMenu, 5, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.FlowControl, 4, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.ToggelButton1, 3, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.PanelCaption, 1, 0)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(1042, 42)
            Me.TableLayoutPanel1.TabIndex = 2
            '
            'PicIcon
            '
            Me.PicIcon.Image = Global.ServicesPlus.My.Resources.Resources.Server
            Me.PicIcon.Location = New System.Drawing.Point(3, 7)
            Me.PicIcon.Margin = New System.Windows.Forms.Padding(3, 7, 3, 4)
            Me.PicIcon.Name = "PicIcon"
            Me.PicIcon.Size = New System.Drawing.Size(32, 31)
            Me.PicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
            Me.PicIcon.TabIndex = 1
            Me.PicIcon.TabStop = False
            '
            'PanelMenu
            '
            Me.PanelMenu.Controls.Add(Me.MenuGroupView)
            Me.PanelMenu.Location = New System.Drawing.Point(845, 4)
            Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.PanelMenu.Name = "PanelMenu"
            Me.PanelMenu.Size = New System.Drawing.Size(194, 34)
            Me.PanelMenu.TabIndex = 4
            '
            'MenuGroupView
            '
            Me.MenuGroupView.AutoSize = False
            Me.MenuGroupView.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.MenuGroupView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MenuGroupView.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuGroupView.GripMargin = New System.Windows.Forms.Padding(0)
            Me.MenuGroupView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GroupByToolStripMenuItem, Me.ViewToolStripMenuItem})
            Me.MenuGroupView.Location = New System.Drawing.Point(0, 0)
            Me.MenuGroupView.Name = "MenuGroupView"
            Me.MenuGroupView.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
            Me.MenuGroupView.Size = New System.Drawing.Size(194, 34)
            Me.MenuGroupView.TabIndex = 0
            '
            'GroupByToolStripMenuItem
            '
            Me.GroupByToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
            Me.GroupByToolStripMenuItem.Image = Global.ServicesPlus.My.Resources.Resources.dropdown
            Me.GroupByToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.GroupByToolStripMenuItem.Name = "GroupByToolStripMenuItem"
            Me.GroupByToolStripMenuItem.Size = New System.Drawing.Size(71, 34)
            Me.GroupByToolStripMenuItem.Text = Global.ServicesPlus.My.Resources.Resources.TextGroupBy
            Me.GroupByToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            '
            'ViewToolStripMenuItem
            '
            Me.ViewToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
            Me.ViewToolStripMenuItem.Image = Global.ServicesPlus.My.Resources.Resources.dropdown
            Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
            Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(47, 34)
            Me.ViewToolStripMenuItem.Text = Global.ServicesPlus.My.Resources.Resources.TextView
            Me.ViewToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            '
            'FlowControl
            '
            Me.FlowControl.BackColor = System.Drawing.Color.Transparent
            Me.FlowControl.Controls.Add(Me.BtnStart)
            Me.FlowControl.Controls.Add(Me.btnStop)
            Me.FlowControl.Controls.Add(Me.btnPause)
            Me.FlowControl.Controls.Add(Me.btnResume)
            Me.FlowControl.Controls.Add(Me.btnRestart)
            Me.FlowControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FlowControl.Location = New System.Drawing.Point(501, 1)
            Me.FlowControl.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
            Me.FlowControl.Name = "FlowControl"
            Me.FlowControl.Size = New System.Drawing.Size(341, 41)
            Me.FlowControl.TabIndex = 5
            '
            'PanelCaption
            '
            Me.PanelCaption.Controls.Add(Me.BtnInstall)
            Me.PanelCaption.Controls.Add(Me.lblCaption)
            Me.PanelCaption.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelCaption.Location = New System.Drawing.Point(40, 0)
            Me.PanelCaption.Margin = New System.Windows.Forms.Padding(0)
            Me.PanelCaption.Name = "PanelCaption"
            Me.PanelCaption.Size = New System.Drawing.Size(205, 42)
            Me.PanelCaption.TabIndex = 7
            '
            'lblCaption
            '
            Me.lblCaption.AutoSize = True
            Me.lblCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.lblCaption.Location = New System.Drawing.Point(3, 10)
            Me.lblCaption.Margin = New System.Windows.Forms.Padding(3, 13, 3, 0)
            Me.lblCaption.Name = "lblCaption"
            Me.lblCaption.Size = New System.Drawing.Size(0, 21)
            Me.lblCaption.TabIndex = 1
            '
            'SearchBox1
            '
            Me.SearchBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.SearchBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SearchBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SearchBox1.Location = New System.Drawing.Point(248, 8)
            Me.SearchBox1.Margin = New System.Windows.Forms.Padding(3, 8, 3, 5)
            Me.SearchBox1.Name = "SearchBox1"
            Me.SearchBox1.Size = New System.Drawing.Size(220, 29)
            Me.SearchBox1.TabIndex = 2
            '
            'BtnStart
            '
            Me.BtnStart.BackgroundImage = Global.ServicesPlus.My.Resources.Resources.Start
            Me.BtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.BtnStart.FlatAppearance.BorderSize = 0
            Me.BtnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.BtnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnStart.Location = New System.Drawing.Point(3, 4)
            Me.BtnStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.BtnStart.Name = "BtnStart"
            Me.BtnStart.Size = New System.Drawing.Size(32, 32)
            Me.BtnStart.TabIndex = 1
            Me.ToolTip1.SetToolTip(Me.BtnStart, "Start Service")
            Me.BtnStart.UseVisualStyleBackColor = True
            '
            'btnStop
            '
            Me.btnStop.BackgroundImage = Global.ServicesPlus.My.Resources.Resources._Stop
            Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnStop.FlatAppearance.BorderSize = 0
            Me.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnStop.Location = New System.Drawing.Point(41, 4)
            Me.btnStop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnStop.Name = "btnStop"
            Me.btnStop.Size = New System.Drawing.Size(32, 32)
            Me.btnStop.TabIndex = 2
            Me.ToolTip1.SetToolTip(Me.btnStop, "Stop Service")
            Me.btnStop.UseVisualStyleBackColor = True
            '
            'btnPause
            '
            Me.btnPause.BackgroundImage = Global.ServicesPlus.My.Resources.Resources.Pause
            Me.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnPause.FlatAppearance.BorderSize = 0
            Me.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPause.Location = New System.Drawing.Point(79, 4)
            Me.btnPause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnPause.Name = "btnPause"
            Me.btnPause.Size = New System.Drawing.Size(32, 32)
            Me.btnPause.TabIndex = 3
            Me.ToolTip1.SetToolTip(Me.btnPause, "Pause Service")
            Me.btnPause.UseVisualStyleBackColor = True
            '
            'btnResume
            '
            Me.btnResume.BackgroundImage = Global.ServicesPlus.My.Resources.Resources._Resume
            Me.btnResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnResume.FlatAppearance.BorderSize = 0
            Me.btnResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnResume.Location = New System.Drawing.Point(117, 4)
            Me.btnResume.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnResume.Name = "btnResume"
            Me.btnResume.Size = New System.Drawing.Size(32, 32)
            Me.btnResume.TabIndex = 4
            Me.ToolTip1.SetToolTip(Me.btnResume, "Resume Service")
            Me.btnResume.UseVisualStyleBackColor = True
            '
            'btnRestart
            '
            Me.btnRestart.BackgroundImage = Global.ServicesPlus.My.Resources.Resources.Restart
            Me.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnRestart.FlatAppearance.BorderSize = 0
            Me.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRestart.Location = New System.Drawing.Point(155, 4)
            Me.btnRestart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnRestart.Name = "btnRestart"
            Me.btnRestart.Size = New System.Drawing.Size(32, 32)
            Me.btnRestart.TabIndex = 5
            Me.ToolTip1.SetToolTip(Me.btnRestart, "Restart Service")
            Me.btnRestart.UseVisualStyleBackColor = True
            '
            'ToggelButton1
            '
            Me.ToggelButton1.BackgroundImage = Global.ServicesPlus.My.Resources.Resources.ShowSystem
            Me.ToggelButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.ToggelButton1.Checked = False
            Me.ToggelButton1.CheckedColor = System.Drawing.Color.White
            Me.ToggelButton1.Location = New System.Drawing.Point(471, 8)
            Me.ToggelButton1.Margin = New System.Windows.Forms.Padding(0, 8, 0, 5)
            Me.ToggelButton1.Name = "ToggelButton1"
            Me.ToggelButton1.Size = New System.Drawing.Size(30, 28)
            Me.ToggelButton1.TabIndex = 6
            Me.ToolTip1.SetToolTip(Me.ToggelButton1, "Show System Components")
            Me.ToggelButton1.UncheckedColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
            '
            'BtnInstall
            '
            Me.BtnInstall.BackgroundImage = Global.ServicesPlus.My.Resources.Resources.InstallService
            Me.BtnInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.BtnInstall.FlatAppearance.BorderSize = 0
            Me.BtnInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.BtnInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.BtnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnInstall.Location = New System.Drawing.Point(167, 5)
            Me.BtnInstall.Name = "BtnInstall"
            Me.BtnInstall.Size = New System.Drawing.Size(32, 32)
            Me.BtnInstall.TabIndex = 2
            Me.ToolTip1.SetToolTip(Me.BtnInstall, "Install new service")
            Me.BtnInstall.UseVisualStyleBackColor = True
            '
            'ListHeader
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "ListHeader"
            Me.Size = New System.Drawing.Size(1042, 95)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            CType(Me.PicIcon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelMenu.ResumeLayout(False)
            Me.MenuGroupView.ResumeLayout(False)
            Me.MenuGroupView.PerformLayout()
            Me.FlowControl.ResumeLayout(False)
            Me.PanelCaption.ResumeLayout(False)
            Me.PanelCaption.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents PicIcon As System.Windows.Forms.PictureBox
        Friend WithEvents SearchBox1 As SearchBox
        Friend WithEvents PanelMenu As System.Windows.Forms.Panel
        Friend WithEvents MenuGroupView As System.Windows.Forms.MenuStrip
        Friend WithEvents GroupByToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents FlowControl As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnStart As RoundButton
        Friend WithEvents btnStop As RoundButton
        Friend WithEvents btnPause As RoundButton
        Friend WithEvents btnResume As RoundButton
        Friend WithEvents btnRestart As RoundButton
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents ToggelButton1 As Controls.ToggelButton
        Friend WithEvents PanelCaption As System.Windows.Forms.Panel
        Friend WithEvents lblCaption As System.Windows.Forms.Label
        Friend WithEvents BtnInstall As ServicesPlus.Controls.RoundButton

    End Class
End NameSpace