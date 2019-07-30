Namespace Controls.TabEx

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class TabHeader
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TabHeader))
            MainFlow = New System.Windows.Forms.FlowLayoutPanel()
            BtnNew = New ExButton()
            MainFlow.SuspendLayout()
            SuspendLayout()
            '
            'MainFlow
            '
            MainFlow.BackColor = System.Drawing.Color.Transparent
            MainFlow.Controls.Add(Me.BtnNew)
            MainFlow.Dock = System.Windows.Forms.DockStyle.Fill
            MainFlow.Location = New System.Drawing.Point(0, 0)
            MainFlow.Name = "MainFlow"
            MainFlow.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
            MainFlow.Size = New System.Drawing.Size(1151, 107)
            MainFlow.TabIndex = 0
            MainFlow.WrapContents = False
            '
            'btnNew
            '
            BtnNew.BackgroundImage = CType(resources.GetObject("btnNew.BackgroundImage"), System.Drawing.Image)
            BtnNew.ImageDown = CType(resources.GetObject("btnNew.ImageDown"), System.Drawing.Image)
            BtnNew.ImageNormal = CType(resources.GetObject("btnNew.ImageNormal"), System.Drawing.Image)
            BtnNew.ImageOver = CType(resources.GetObject("btnNew.ImageOver"), System.Drawing.Image)
            BtnNew.Location = New System.Drawing.Point(0, 3)
            BtnNew.Margin = New System.Windows.Forms.Padding(0)
            BtnNew.Name = "btnNew"
            BtnNew.Size = New System.Drawing.Size(25, 28)
            BtnNew.TabIndex = 0
            '
            'TabHeader
            '
            AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            BackColor = Modules.ColorBackgroud
            Controls.Add(Me.MainFlow)
            Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Name = "TabHeader"
            Size = New System.Drawing.Size(1151, 107)
            MainFlow.ResumeLayout(False)
            ResumeLayout(False)

        End Sub
        Friend WithEvents MainFlow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnNew As ExButton

    End Class
End Namespace