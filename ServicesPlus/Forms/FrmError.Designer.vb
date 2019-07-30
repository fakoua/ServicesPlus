Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmError
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmError))
            txtError = New System.Windows.Forms.TextBox()
            SuspendLayout()
            '
            'txtError
            '
            txtError.Dock = System.Windows.Forms.DockStyle.Fill
            txtError.Location = New System.Drawing.Point(0, 0)
            txtError.Multiline = True
            txtError.Name = "txtError"
            txtError.Size = New System.Drawing.Size(682, 377)
            txtError.TabIndex = 0
            '
            'frmError
            '
            AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New System.Drawing.Size(682, 377)
            Controls.Add(Me.txtError)
            Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Name = "frmError"
            ShowIcon = False
            Text = "Error Details"
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Friend WithEvents txtError As System.Windows.Forms.TextBox
    End Class
End Namespace