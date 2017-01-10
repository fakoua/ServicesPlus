Namespace Controls

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SearchBox
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
            Me.BtnClear = New System.Windows.Forms.Button()
            Me.TxtFilter = New ServicesPlus.Controls.CueTextBox()
            Me.SuspendLayout()
            '
            'BtnClear
            '
            Me.BtnClear.BackColor = System.Drawing.Color.White
            Me.BtnClear.BackgroundImage = Global.ServicesPlus.My.Resources.Resources.filter_clear
            Me.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.BtnClear.FlatAppearance.BorderSize = 0
            Me.BtnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
            Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
            Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnClear.Location = New System.Drawing.Point(404, 1)
            Me.BtnClear.Name = "BtnClear"
            Me.BtnClear.Size = New System.Drawing.Size(27, 27)
            Me.BtnClear.TabIndex = 4
            Me.BtnClear.UseVisualStyleBackColor = False
            '
            'TxtFilter
            '
            Me.TxtFilter.AcceptsReturn = True
            Me.TxtFilter.Cue = Global.ServicesPlus.My.Resources.Resources.TextFilterSearch
            Me.TxtFilter.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TxtFilter.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtFilter.ForeColor = System.Drawing.Color.Black
            Me.TxtFilter.Location = New System.Drawing.Point(0, 0)
            Me.TxtFilter.Margin = New System.Windows.Forms.Padding(0)
            Me.TxtFilter.Name = "TxtFilter"
            Me.TxtFilter.Size = New System.Drawing.Size(436, 29)
            Me.TxtFilter.TabIndex = 3
            Me.TxtFilter.Tag = ""
            '
            'SearchBox
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.TxtFilter)
            Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "SearchBox"
            Me.Size = New System.Drawing.Size(436, 68)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtFilter As CueTextBox
        Friend WithEvents BtnClear As System.Windows.Forms.Button

    End Class
End Namespace