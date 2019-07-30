Namespace Forms.MetroModal
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmOverlay
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
            SuspendLayout()
            '
            'frmOverlay
            '
            AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            BackColor = System.Drawing.Color.Black
            ClientSize = New System.Drawing.Size(284, 261)
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Name = "frmOverlay"
            Opacity = 0.5R
            ShowIcon = False
            ShowInTaskbar = False
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            TopMost = True
            WindowState = System.Windows.Forms.FormWindowState.Maximized
            ResumeLayout(False)

        End Sub
    End Class
End Namespace