Imports ServicesPlus.Controls

Namespace Forms.MetroModal

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmModal
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
            Me.lblLine1 = New System.Windows.Forms.Label()
            Me.lblLine2 = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.MainTable = New System.Windows.Forms.TableLayoutPanel()
            Me.PicLoading = New System.Windows.Forms.PictureBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.BtnClose = New ServicesPlus.Controls.MetroButton()
            Me.MainTable.SuspendLayout()
            CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblLine1
            '
            Me.lblLine1.AutoSize = True
            Me.lblLine1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLine1.Location = New System.Drawing.Point(3, 4)
            Me.lblLine1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
            Me.lblLine1.Name = "lblLine1"
            Me.lblLine1.Size = New System.Drawing.Size(0, 25)
            Me.lblLine1.TabIndex = 0
            Me.lblLine1.Tag = ""
            '
            'lblLine2
            '
            Me.lblLine2.AutoSize = True
            Me.lblLine2.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLine2.Location = New System.Drawing.Point(3, 40)
            Me.lblLine2.Name = "lblLine2"
            Me.lblLine2.Size = New System.Drawing.Size(0, 25)
            Me.lblLine2.TabIndex = 1
            '
            'Timer1
            '
            Me.Timer1.Interval = 2000
            '
            'MainTable
            '
            Me.MainTable.ColumnCount = 1
            Me.MainTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.MainTable.Controls.Add(Me.PicLoading, 0, 2)
            Me.MainTable.Controls.Add(Me.Panel1, 0, 3)
            Me.MainTable.Controls.Add(Me.lblLine2, 0, 1)
            Me.MainTable.Controls.Add(Me.lblLine1, 0, 0)
            Me.MainTable.Location = New System.Drawing.Point(12, 13)
            Me.MainTable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.MainTable.Name = "MainTable"
            Me.MainTable.RowCount = 4
            Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
            Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.MainTable.Size = New System.Drawing.Size(763, 279)
            Me.MainTable.TabIndex = 5
            '
            'PicLoading
            '
            Me.PicLoading.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PicLoading.Image = Global.ServicesPlus.My.Resources.Resources.Loading
            Me.PicLoading.Location = New System.Drawing.Point(0, 75)
            Me.PicLoading.Margin = New System.Windows.Forms.Padding(0)
            Me.PicLoading.Name = "PicLoading"
            Me.PicLoading.Size = New System.Drawing.Size(763, 154)
            Me.PicLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.PicLoading.TabIndex = 5
            Me.PicLoading.TabStop = False
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.BtnClose)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(3, 232)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(757, 44)
            Me.Panel1.TabIndex = 6
            '
            'BtnClose
            '
            Me.BtnClose.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.BtnClose.Enabled = False
            Me.BtnClose.FixedHeight = 30
            Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnClose.Location = New System.Drawing.Point(674, 7)
            Me.BtnClose.MouseDonwBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.BtnClose.Name = "BtnClose"
            Me.BtnClose.Size = New System.Drawing.Size(75, 30)
            Me.BtnClose.TabIndex = 1
            Me.BtnClose.Text = Global.ServicesPlus.My.Resources.Resources.TextClose
            Me.BtnClose.UseVisualStyleBackColor = True
            '
            'FrmModal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(787, 302)
            Me.Controls.Add(Me.MainTable)
            Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmModal"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.TopMost = True
            Me.MainTable.ResumeLayout(False)
            Me.MainTable.PerformLayout()
            CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblLine1 As System.Windows.Forms.Label
        Friend WithEvents lblLine2 As System.Windows.Forms.Label
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents MainTable As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents PicLoading As System.Windows.Forms.PictureBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents BtnClose As MetroButton
    End Class
End NameSpace