Namespace Controls

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ServerInfo
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
            TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            lblCaption = New System.Windows.Forms.Label()
            Panel1 = New System.Windows.Forms.Panel()
            lblName = New System.Windows.Forms.Label()
            lblInstallDate = New System.Windows.Forms.Label()
            lblMemory = New System.Windows.Forms.Label()
            lblCPU = New System.Windows.Forms.Label()
            lblOS = New System.Windows.Forms.Label()
            HLoader1 = New HLoader()
            TableLayoutPanel1.SuspendLayout()
            Panel1.SuspendLayout()
            SuspendLayout()
            '
            'TableLayoutPanel1
            '
            TableLayoutPanel1.ColumnCount = 1
            TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            TableLayoutPanel1.Controls.Add(Me.lblCaption, 0, 0)
            TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
            TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            TableLayoutPanel1.Name = "TableLayoutPanel1"
            TableLayoutPanel1.RowCount = 3
            TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
            TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            TableLayoutPanel1.Size = New System.Drawing.Size(593, 328)
            TableLayoutPanel1.TabIndex = 4
            '
            'lblCaption
            '
            lblCaption.AutoSize = True
            lblCaption.Text = My.Resources.TextSystem
            lblCaption.ForeColor = Modules.ColorBlue
            lblCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblCaption.ForeColor = Modules.ColorBlue
            lblCaption.Location = New System.Drawing.Point(4, 4)
            lblCaption.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
            lblCaption.Name = "lblCaption"
            lblCaption.Size = New System.Drawing.Size(63, 21)
            lblCaption.TabIndex = 1
            lblCaption.Text = Global.ServicesPlus.My.Resources.TextSystem
            '
            'Panel1
            '
            Panel1.Controls.Add(Me.HLoader1)
            Panel1.Controls.Add(Me.lblName)
            Panel1.Controls.Add(Me.lblInstallDate)
            Panel1.Controls.Add(Me.lblMemory)
            Panel1.Controls.Add(Me.lblCPU)
            Panel1.Controls.Add(Me.lblOS)
            Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Panel1.Location = New System.Drawing.Point(0, 33)
            Panel1.Margin = New System.Windows.Forms.Padding(0)
            Panel1.Name = "Panel1"
            Panel1.Size = New System.Drawing.Size(593, 295)
            Panel1.TabIndex = 3
            '
            'lblName
            '
            lblName.AutoSize = True
            lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblName.Location = New System.Drawing.Point(6, 10)
            lblName.Name = "lblName"
            lblName.Size = New System.Drawing.Size(2, 19)
            lblName.TabIndex = 4
            lblName.Visible = False
            '
            'lblInstallDate
            '
            lblInstallDate.AutoSize = True
            lblInstallDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            lblInstallDate.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblInstallDate.Location = New System.Drawing.Point(6, 70)
            lblInstallDate.Name = "lblInstallDate"
            lblInstallDate.Size = New System.Drawing.Size(2, 15)
            lblInstallDate.TabIndex = 3
            lblInstallDate.Visible = False
            '
            'lblMemory
            '
            lblMemory.AutoSize = True
            lblMemory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            lblMemory.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblMemory.Location = New System.Drawing.Point(6, 108)
            lblMemory.Name = "lblMemory"
            lblMemory.Size = New System.Drawing.Size(2, 15)
            lblMemory.TabIndex = 2
            lblMemory.Visible = False
            '
            'lblCPU
            '
            lblCPU.AutoSize = True
            lblCPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            lblCPU.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblCPU.Location = New System.Drawing.Point(6, 89)
            lblCPU.Name = "lblCPU"
            lblCPU.Size = New System.Drawing.Size(2, 15)
            lblCPU.TabIndex = 1
            lblCPU.Visible = False
            '
            'lblOS
            '
            lblOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            lblOS.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblOS.Location = New System.Drawing.Point(6, 31)
            lblOS.Name = "lblOS"
            lblOS.Size = New System.Drawing.Size(219, 36)
            lblOS.TabIndex = 0
            lblOS.Visible = False
            '
            'HLoader1
            '
            HLoader1.Dock = System.Windows.Forms.DockStyle.Top
            HLoader1.Location = New System.Drawing.Point(0, 0)
            HLoader1.Margin = New System.Windows.Forms.Padding(0)
            HLoader1.Name = "HLoader1"
            HLoader1.Size = New System.Drawing.Size(593, 2)
            HLoader1.Step = 2
            HLoader1.TabIndex = 5
            '
            'ServerInfo
            '
            AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            BackColor = System.Drawing.Color.White
            Controls.Add(Me.TableLayoutPanel1)
            Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Name = "ServerInfo"
            Size = New System.Drawing.Size(593, 328)
            TableLayoutPanel1.ResumeLayout(False)
            TableLayoutPanel1.PerformLayout()
            Panel1.ResumeLayout(False)
            Panel1.PerformLayout()
            ResumeLayout(False)

        End Sub
        Friend WithEvents lblCaption As System.Windows.Forms.Label
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblOS As System.Windows.Forms.Label
        Friend WithEvents lblInstallDate As System.Windows.Forms.Label
        Friend WithEvents lblMemory As System.Windows.Forms.Label
        Friend WithEvents lblCPU As System.Windows.Forms.Label
        Friend WithEvents lblName As System.Windows.Forms.Label
        Friend WithEvents HLoader1 As HLoader

    End Class
End Namespace