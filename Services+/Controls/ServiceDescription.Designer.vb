Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ServiceDescription
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
            Me.LinkDisplayName = New System.Windows.Forms.LinkLabel()
            Me.lblDescription = New System.Windows.Forms.Label()
            Me.LinkPath = New System.Windows.Forms.LinkLabel()
            Me.CMLink = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.OpenPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.CopyPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.LinkRestart = New System.Windows.Forms.LinkLabel()
            Me.LinkPause = New System.Windows.Forms.LinkLabel()
            Me.linkStartStop = New System.Windows.Forms.LinkLabel()
            Me.lblDesc = New System.Windows.Forms.Label()
            Me.CMLink.SuspendLayout()
            Me.SuspendLayout()
            '
            'LinkDisplayName
            '
            Me.LinkDisplayName.Dock = System.Windows.Forms.DockStyle.Top
            Me.LinkDisplayName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LinkDisplayName.Location = New System.Drawing.Point(0, 3)
            Me.LinkDisplayName.Name = "LinkDisplayName"
            Me.LinkDisplayName.Size = New System.Drawing.Size(233, 46)
            Me.LinkDisplayName.TabIndex = 0
            '
            'lblDescription
            '
            Me.lblDescription.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescription.Location = New System.Drawing.Point(0, 188)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.Size = New System.Drawing.Size(233, 286)
            Me.lblDescription.TabIndex = 2
            '
            'LinkPath
            '
            Me.LinkPath.Location = New System.Drawing.Point(0, 139)
            Me.LinkPath.Name = "LinkPath"
            Me.LinkPath.Size = New System.Drawing.Size(230, 22)
            Me.LinkPath.TabIndex = 7
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
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(0, 124)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(108, 15)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Path to executable:"
            '
            'LinkRestart
            '
            Me.LinkRestart.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.LinkRestart.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.LinkRestart.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LinkRestart.LinkArea = New System.Windows.Forms.LinkArea(0, 7)
            Me.LinkRestart.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
            Me.LinkRestart.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.LinkRestart.Location = New System.Drawing.Point(3, 92)
            Me.LinkRestart.Name = "LinkRestart"
            Me.LinkRestart.Size = New System.Drawing.Size(130, 19)
            Me.LinkRestart.TabIndex = 6
            Me.LinkRestart.TabStop = True
            Me.LinkRestart.Text = "Restart the service"
            Me.LinkRestart.UseCompatibleTextRendering = True
            Me.LinkRestart.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'LinkPause
            '
            Me.LinkPause.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.LinkPause.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.LinkPause.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LinkPause.LinkArea = New System.Windows.Forms.LinkArea(0, 5)
            Me.LinkPause.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
            Me.LinkPause.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.LinkPause.Location = New System.Drawing.Point(3, 71)
            Me.LinkPause.Name = "LinkPause"
            Me.LinkPause.Size = New System.Drawing.Size(130, 19)
            Me.LinkPause.TabIndex = 5
            Me.LinkPause.TabStop = True
            Me.LinkPause.Text = "Pause the service"
            Me.LinkPause.UseCompatibleTextRendering = True
            Me.LinkPause.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'linkStartStop
            '
            Me.linkStartStop.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.linkStartStop.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.linkStartStop.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.linkStartStop.LinkArea = New System.Windows.Forms.LinkArea(0, 4)
            Me.linkStartStop.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
            Me.linkStartStop.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.linkStartStop.Location = New System.Drawing.Point(3, 50)
            Me.linkStartStop.Margin = New System.Windows.Forms.Padding(0)
            Me.linkStartStop.Name = "linkStartStop"
            Me.linkStartStop.Size = New System.Drawing.Size(130, 19)
            Me.linkStartStop.TabIndex = 4
            Me.linkStartStop.TabStop = True
            Me.linkStartStop.Text = "Stop the service"
            Me.linkStartStop.UseCompatibleTextRendering = True
            Me.linkStartStop.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'lblDesc
            '
            Me.lblDesc.AutoSize = True
            Me.lblDesc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDesc.Location = New System.Drawing.Point(0, 173)
            Me.lblDesc.Margin = New System.Windows.Forms.Padding(0)
            Me.lblDesc.Name = "lblDesc"
            Me.lblDesc.Size = New System.Drawing.Size(71, 15)
            Me.lblDesc.TabIndex = 1
            Me.lblDesc.Text = "Description:"
            Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ServiceDescription
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.LinkPath)
            Me.Controls.Add(Me.LinkRestart)
            Me.Controls.Add(Me.LinkPause)
            Me.Controls.Add(Me.linkStartStop)
            Me.Controls.Add(Me.lblDescription)
            Me.Controls.Add(Me.lblDesc)
            Me.Controls.Add(Me.LinkDisplayName)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "ServiceDescription"
            Me.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
            Me.Size = New System.Drawing.Size(233, 474)
            Me.CMLink.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents LinkDisplayName As System.Windows.Forms.LinkLabel
        Friend WithEvents lblDesc As System.Windows.Forms.Label
        Friend WithEvents lblDescription As System.Windows.Forms.Label
        Friend WithEvents linkStartStop As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkPause As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkRestart As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkPath As System.Windows.Forms.LinkLabel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents CMLink As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents OpenPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CopyPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

    End Class
End Namespace