<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelete
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblWrongAnswer = New System.Windows.Forms.Label()
        Me.HLoader1 = New ServicesPlus.Controls.HLoader()
        Me.BtnDelete = New ServicesPlus.Controls.MetroButton()
        Me.txtResult = New ServicesPlus.Controls.CueTextBox()
        Me.LblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.Red
        Me.LblTitle.Location = New System.Drawing.Point(0, 0)
        Me.LblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(519, 65)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Are you sure you want to delete '{0}'?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Awake proof !"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(171, 84)
        Me.txtA.Name = "txtA"
        Me.txtA.ReadOnly = True
        Me.txtA.Size = New System.Drawing.Size(52, 29)
        Me.txtA.TabIndex = 2
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(256, 84)
        Me.txtB.Name = "txtB"
        Me.txtB.ReadOnly = True
        Me.txtB.Size = New System.Drawing.Size(52, 29)
        Me.txtB.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "+"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "="
        '
        'LblWrongAnswer
        '
        Me.LblWrongAnswer.AutoSize = True
        Me.LblWrongAnswer.ForeColor = System.Drawing.Color.Red
        Me.LblWrongAnswer.Location = New System.Drawing.Point(374, 116)
        Me.LblWrongAnswer.Name = "LblWrongAnswer"
        Me.LblWrongAnswer.Size = New System.Drawing.Size(130, 21)
        Me.LblWrongAnswer.TabIndex = 9
        Me.LblWrongAnswer.Text = "... wrong answer !"
        Me.LblWrongAnswer.Visible = False
        '
        'HLoader1
        '
        Me.HLoader1.Location = New System.Drawing.Point(4, 151)
        Me.HLoader1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HLoader1.Name = "HLoader1"
        Me.HLoader1.Size = New System.Drawing.Size(510, 2)
        Me.HLoader1.Step = 2
        Me.HLoader1.TabIndex = 10
        '
        'BtnDelete
        '
        Me.BtnDelete.BorderColor = System.Drawing.Color.Red
        Me.BtnDelete.FixedHeight = 30
        Me.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Location = New System.Drawing.Point(403, 163)
        Me.BtnDelete.MouseDonwBackColor = System.Drawing.Color.Red
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(103, 30)
        Me.BtnDelete.TabIndex = 1
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Cue = Nothing
        Me.txtResult.Location = New System.Drawing.Point(378, 84)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(128, 29)
        Me.txtResult.TabIndex = 0
        '
        'LblError
        '
        Me.LblError.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.ForeColor = System.Drawing.Color.Red
        Me.LblError.Location = New System.Drawing.Point(12, 158)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(385, 36)
        Me.LblError.TabIndex = 11
        Me.LblError.Text = "Label1"
        Me.LblError.Visible = False
        '
        'frmDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(519, 203)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.HLoader1)
        Me.Controls.Add(Me.LblWrongAnswer)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblTitle)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDelete"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Service"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As ServicesPlus.Controls.CueTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As ServicesPlus.Controls.MetroButton
    Friend WithEvents LblWrongAnswer As System.Windows.Forms.Label
    Friend WithEvents HLoader1 As ServicesPlus.Controls.HLoader
    Friend WithEvents LblError As System.Windows.Forms.Label
End Class
