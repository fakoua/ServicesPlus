Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmUpdate
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
            lblTitle = New System.Windows.Forms.Label()
            Label1 = New System.Windows.Forms.Label()
            Label2 = New System.Windows.Forms.Label()
            Label3 = New System.Windows.Forms.Label()
            txtChangeLog = New System.Windows.Forms.TextBox()
            BtnDownload = New ServicesPlus.Controls.MetroButton()
            LblInstalledVersion = New System.Windows.Forms.Label()
            lblNewVersion = New System.Windows.Forms.Label()
            SuspendLayout()
            '
            'lblTitle
            '
            lblTitle.AutoSize = True
            lblTitle.ForeColor = System.Drawing.Color.Blue
            lblTitle.Location = New System.Drawing.Point(12, 9)
            lblTitle.Name = "lblTitle"
            lblTitle.Size = New System.Drawing.Size(142, 17)
            lblTitle.TabIndex = 1
            lblTitle.Text = "New update is available"
            '
            'Label1
            '
            Label1.AutoSize = True
            Label1.Location = New System.Drawing.Point(12, 40)
            Label1.Name = "Label1"
            Label1.Size = New System.Drawing.Size(101, 17)
            Label1.TabIndex = 2
            Label1.Text = "Installed Version:"
            '
            'Label2
            '
            Label2.AutoSize = True
            Label2.Location = New System.Drawing.Point(12, 69)
            Label2.Name = "Label2"
            Label2.Size = New System.Drawing.Size(80, 17)
            Label2.TabIndex = 4
            Label2.Text = "New Version:"
            '
            'Label3
            '
            Label3.AutoSize = True
            Label3.Location = New System.Drawing.Point(12, 96)
            Label3.Name = "Label3"
            Label3.Size = New System.Drawing.Size(78, 17)
            Label3.TabIndex = 6
            Label3.Text = "What's New:"
            '
            'txtChangeLog
            '
            txtChangeLog.Location = New System.Drawing.Point(15, 116)
            txtChangeLog.Multiline = True
            txtChangeLog.Name = "txtChangeLog"
            txtChangeLog.ReadOnly = True
            txtChangeLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            txtChangeLog.Size = New System.Drawing.Size(469, 157)
            txtChangeLog.TabIndex = 7
            '
            'BtnDownload
            '
            BtnDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            BtnDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            BtnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
            BtnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnDownload.Location = New System.Drawing.Point(388, 288)
            BtnDownload.Name = "BtnDownload"
            BtnDownload.Size = New System.Drawing.Size(96, 30)
            BtnDownload.TabIndex = 0
            BtnDownload.Text = "Download"
            BtnDownload.UseVisualStyleBackColor = True
            '
            'LblInstalledVersion
            '
            LblInstalledVersion.AutoSize = True
            LblInstalledVersion.Location = New System.Drawing.Point(119, 40)
            LblInstalledVersion.Name = "LblInstalledVersion"
            LblInstalledVersion.Size = New System.Drawing.Size(101, 17)
            LblInstalledVersion.TabIndex = 3
            LblInstalledVersion.Text = "Installed Version:"
            '
            'lblNewVersion
            '
            lblNewVersion.AutoSize = True
            lblNewVersion.Location = New System.Drawing.Point(119, 69)
            lblNewVersion.Name = "lblNewVersion"
            lblNewVersion.Size = New System.Drawing.Size(101, 17)
            lblNewVersion.TabIndex = 5
            lblNewVersion.Text = "Installed Version:"
            '
            'FrmUpdate
            '
            AcceptButton = BtnDownload
            AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            BackColor = System.Drawing.Color.White
            ClientSize = New System.Drawing.Size(495, 328)
            Controls.Add(Me.lblNewVersion)
            Controls.Add(Me.LblInstalledVersion)
            Controls.Add(Me.BtnDownload)
            Controls.Add(Me.txtChangeLog)
            Controls.Add(Me.Label3)
            Controls.Add(Me.Label2)
            Controls.Add(Me.Label1)
            Controls.Add(Me.lblTitle)
            Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Name = "FrmUpdate"
            ShowInTaskbar = False
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "Update"
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtChangeLog As System.Windows.Forms.TextBox
        Friend WithEvents BtnDownload As ServicesPlus.Controls.MetroButton
        Friend WithEvents LblInstalledVersion As System.Windows.Forms.Label
        Friend WithEvents lblNewVersion As System.Windows.Forms.Label
    End Class
End Namespace