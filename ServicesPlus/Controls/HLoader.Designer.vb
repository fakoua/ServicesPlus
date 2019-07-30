Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class HLoader
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
            Timer1 = New System.Windows.Forms.Timer(Me.components)
            SuspendLayout()
            '
            'Timer1
            '
            Timer1.Interval = 4
            '
            'HLoader
            '
            AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            DoubleBuffered = True
            Name = "HLoader"
            Size = New System.Drawing.Size(508, 42)
            ResumeLayout(False)

        End Sub
        Friend WithEvents Timer1 As System.Windows.Forms.Timer

    End Class
End NameSpace