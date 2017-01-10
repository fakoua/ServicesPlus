Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Loading
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
            PicLoading = New System.Windows.Forms.PictureBox()
            CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            '
            'PicLoading
            '
            PicLoading.Image = Global.ServicesPlus.My.Resources.Resources.Loading
            PicLoading.Location = New System.Drawing.Point(223, 135)
            PicLoading.Name = "PicLoading"
            PicLoading.Size = New System.Drawing.Size(128, 128)
            PicLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
            PicLoading.TabIndex = 0
            PicLoading.TabStop = False
            '
            'Loading
            '
            AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            BackColor = System.Drawing.Color.White
            Controls.Add(Me.PicLoading)
            Name = "Loading"
            Size = New System.Drawing.Size(621, 440)
            CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Friend WithEvents PicLoading As System.Windows.Forms.PictureBox

    End Class
End Namespace