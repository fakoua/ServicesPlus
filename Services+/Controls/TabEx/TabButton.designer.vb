Namespace Controls.TabEx

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class TabButton
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TabButton))
            lblCaption = New System.Windows.Forms.Label()
            CMMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
            AddServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            TableMain = New System.Windows.Forms.TableLayoutPanel()
            btnClose = New ExButton()
            CMMain.SuspendLayout()
            TableMain.SuspendLayout()
            SuspendLayout()
            '
            'lblCaption
            '
            lblCaption.ContextMenuStrip = CMMain
            lblCaption.Dock = System.Windows.Forms.DockStyle.Fill
            lblCaption.Location = New System.Drawing.Point(0, 6)
            lblCaption.Margin = New System.Windows.Forms.Padding(0, 6, 0, 0)
            lblCaption.Name = "lblCaption"
            lblCaption.Size = New System.Drawing.Size(131, 28)
            lblCaption.TabIndex = 1
            '
            'CMMain
            '
            CMMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddServerToolStripMenuItem, ToolStripMenuItem1, CloseToolStripMenuItem})
            CMMain.Name = "CMMain"
            CMMain.Size = New System.Drawing.Size(138, 54)
            '
            'AddServerToolStripMenuItem
            '
            AddServerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            AddServerToolStripMenuItem.Name = "AddServerToolStripMenuItem"
            AddServerToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
            AddServerToolStripMenuItem.Text = Global.ServicesPlus.My.Resources.TextAddServerCaption
            '
            'ToolStripMenuItem1
            '
            ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            ToolStripMenuItem1.Size = New System.Drawing.Size(134, 6)
            '
            'CloseToolStripMenuItem
            '
            CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
            CloseToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
            CloseToolStripMenuItem.Text = Global.ServicesPlus.My.Resources.TextClose
            '
            'TableMain
            '
            TableMain.ColumnCount = 2
            TableMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            TableMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            TableMain.ContextMenuStrip = CMMain
            TableMain.Controls.Add(Me.lblCaption, 0, 0)
            TableMain.Controls.Add(Me.btnClose, 1, 0)
            TableMain.Dock = System.Windows.Forms.DockStyle.Fill
            TableMain.Location = New System.Drawing.Point(0, 0)
            TableMain.Margin = New System.Windows.Forms.Padding(0)
            TableMain.Name = "TableMain"
            TableMain.RowCount = 1
            TableMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            TableMain.Size = New System.Drawing.Size(151, 34)
            TableMain.TabIndex = 2
            '
            'btnClose
            '
            btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
            btnClose.ImageDown = CType(resources.GetObject("btnClose.ImageDown"), System.Drawing.Image)
            btnClose.ImageNormal = CType(resources.GetObject("btnClose.ImageNormal"), System.Drawing.Image)
            btnClose.ImageOver = CType(resources.GetObject("btnClose.ImageOver"), System.Drawing.Image)
            btnClose.Location = New System.Drawing.Point(131, 5)
            btnClose.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
            btnClose.Name = "btnClose"
            btnClose.Size = New System.Drawing.Size(16, 16)
            btnClose.TabIndex = 2
            '
            'TabButton
            '
            AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            BackColor = Modules.ColorBackgroud
            Controls.Add(Me.TableMain)
            Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Margin = New System.Windows.Forms.Padding(0)
            Name = "TabButton"
            Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Size = New System.Drawing.Size(151, 36)
            CMMain.ResumeLayout(False)
            TableMain.ResumeLayout(False)
            ResumeLayout(False)

        End Sub
        Friend WithEvents lblCaption As System.Windows.Forms.Label
        Friend WithEvents TableMain As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents btnClose As ExButton
        Friend WithEvents CMMain As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents AddServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    End Class
End Namespace