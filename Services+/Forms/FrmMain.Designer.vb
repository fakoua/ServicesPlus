Imports ServicesPlus.Controls.TabEx

Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ErrorLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ServicesmscToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.HttpServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TestIdentityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabHeader1 = New ServicesPlus.Controls.TabEx.TabHeader()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MainToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.TestToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(776, 25)
            Me.MenuStrip1.TabIndex = 4
            '
            'FileToolStripMenuItem
            '
            Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ErrorLogsToolStripMenuItem, Me.ServicesmscToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
            Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
            Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
            Me.FileToolStripMenuItem.Text = "File"
            '
            'ErrorLogsToolStripMenuItem
            '
            Me.ErrorLogsToolStripMenuItem.Image = Global.ServicesPlus.My.Resources.Resources.OpenFileLocation
            Me.ErrorLogsToolStripMenuItem.Name = "ErrorLogsToolStripMenuItem"
            Me.ErrorLogsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
            Me.ErrorLogsToolStripMenuItem.Text = "Error logs"
            '
            'ServicesmscToolStripMenuItem
            '
            Me.ServicesmscToolStripMenuItem.Image = Global.ServicesPlus.My.Resources.Resources.settings
            Me.ServicesmscToolStripMenuItem.Name = "ServicesmscToolStripMenuItem"
            Me.ServicesmscToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
            Me.ServicesmscToolStripMenuItem.Text = "Services.msc"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(144, 6)
            '
            'ExitToolStripMenuItem
            '
            Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
            Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
            Me.ExitToolStripMenuItem.Text = "Exit"
            '
            'MainToolStripMenuItem
            '
            Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
            Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
            Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 21)
            Me.MainToolStripMenuItem.Text = "Help"
            '
            'AboutToolStripMenuItem
            '
            Me.AboutToolStripMenuItem.Image = Global.ServicesPlus.My.Resources.Resources.settings
            Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
            Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
            Me.AboutToolStripMenuItem.Text = "About"
            '
            'ToolsToolStripMenuItem
            '
            Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HttpServerToolStripMenuItem})
            Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
            Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 21)
            Me.ToolsToolStripMenuItem.Text = "Tools"
            '
            'HttpServerToolStripMenuItem
            '
            Me.HttpServerToolStripMenuItem.Name = "HttpServerToolStripMenuItem"
            Me.HttpServerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.HttpServerToolStripMenuItem.Text = "Http Server"
            '
            'TestToolStripMenuItem
            '
            Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestIdentityToolStripMenuItem})
            Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
            Me.TestToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
            Me.TestToolStripMenuItem.Text = "Test"
            '
            'TestIdentityToolStripMenuItem
            '
            Me.TestIdentityToolStripMenuItem.Name = "TestIdentityToolStripMenuItem"
            Me.TestIdentityToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
            Me.TestIdentityToolStripMenuItem.Text = "Test Identity"
            '
            'TabControl1
            '
            Me.TabControl1.Location = New System.Drawing.Point(0, 52)
            Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(469, 264)
            Me.TabControl1.TabIndex = 6
            '
            'TabHeader1
            '
            Me.TabHeader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.TabHeader1.CanAdd = True
            Me.TabHeader1.Dock = System.Windows.Forms.DockStyle.Top
            Me.TabHeader1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabHeader1.Location = New System.Drawing.Point(0, 25)
            Me.TabHeader1.Name = "TabHeader1"
            Me.TabHeader1.Size = New System.Drawing.Size(776, 33)
            Me.TabHeader1.TabControl = Me.TabControl1
            Me.TabHeader1.TabIndex = 5
            '
            'FrmMain
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(776, 461)
            Me.Controls.Add(Me.TabHeader1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.TabControl1)
            Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.KeyPreview = True
            Me.MainMenuStrip = Me.MenuStrip1
            Me.MinimumSize = New System.Drawing.Size(636, 500)
            Me.Name = "FrmMain"
            Me.Text = "Services+"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents TabHeader1 As TabHeader
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ErrorLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TestIdentityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ServicesmscToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents HttpServerToolStripMenuItem As ToolStripMenuItem
    End Class
End Namespace