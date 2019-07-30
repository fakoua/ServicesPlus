Imports ServicesPlus.Controls

Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmAddServer
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
            Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"3", "test"}, -1, System.Drawing.Color.Black, System.Drawing.Color.Empty, Nothing)
            Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1", "best"}, -1)
            Me.RdLocal = New System.Windows.Forms.RadioButton()
            Me.rdAnother = New System.Windows.Forms.RadioButton()
            Me.TxtAnother = New ServicesPlus.Controls.CueTextBox()
            Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.BtnOK = New ServicesPlus.Controls.MetroButton()
            Me.BtnCancel = New ServicesPlus.Controls.MetroButton()
            Me.lblIntro = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblError = New System.Windows.Forms.Label()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.txtUsername = New ServicesPlus.Controls.CueTextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ChkConnectAs = New System.Windows.Forms.CheckBox()
            Me.LvRecentServers = New System.Windows.Forms.ListView()
            Me.ColFrequency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColComputer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColUsername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.Label3 = New System.Windows.Forms.Label()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'RdLocal
            '
            Me.RdLocal.AutoSize = True
            Me.RdLocal.Checked = True
            Me.RdLocal.Location = New System.Drawing.Point(12, 33)
            Me.RdLocal.Name = "RdLocal"
            Me.RdLocal.Size = New System.Drawing.Size(141, 21)
            Me.RdLocal.TabIndex = 1
            Me.RdLocal.TabStop = True
            Me.RdLocal.Text = Global.ServicesPlus.My.Resources.Resources.TempLocalComputer
            Me.RdLocal.UseVisualStyleBackColor = True
            '
            'rdAnother
            '
            Me.rdAnother.AutoSize = True
            Me.rdAnother.Location = New System.Drawing.Point(12, 74)
            Me.rdAnother.Name = "rdAnother"
            Me.rdAnother.Size = New System.Drawing.Size(133, 21)
            Me.rdAnother.TabIndex = 2
            Me.rdAnother.Text = Global.ServicesPlus.My.Resources.Resources.TextAnotherComputer
            Me.rdAnother.UseVisualStyleBackColor = True
            '
            'TxtAnother
            '
            Me.TxtAnother.Cue = "Computer Name or IP Address ..."
            Me.TxtAnother.Enabled = False
            Me.TxtAnother.Location = New System.Drawing.Point(171, 74)
            Me.TxtAnother.Name = "TxtAnother"
            Me.TxtAnother.Size = New System.Drawing.Size(333, 25)
            Me.TxtAnother.TabIndex = 3
            '
            'ErrorProvider1
            '
            Me.ErrorProvider1.ContainerControl = Me
            '
            'BtnOK
            '
            Me.BtnOK.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.BtnOK.FixedHeight = 30
            Me.BtnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.BtnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnOK.Location = New System.Drawing.Point(242, 367)
            Me.BtnOK.MouseDonwBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.BtnOK.Name = "BtnOK"
            Me.BtnOK.Size = New System.Drawing.Size(128, 30)
            Me.BtnOK.TabIndex = 8
            Me.BtnOK.Text = Global.ServicesPlus.My.Resources.Resources.TextOk
            Me.BtnOK.UseVisualStyleBackColor = True
            '
            'BtnCancel
            '
            Me.BtnCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.BtnCancel.FixedHeight = 30
            Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnCancel.Location = New System.Drawing.Point(376, 367)
            Me.BtnCancel.MouseDonwBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(128, 30)
            Me.BtnCancel.TabIndex = 9
            Me.BtnCancel.Text = Global.ServicesPlus.My.Resources.Resources.TextCancel
            Me.BtnCancel.UseVisualStyleBackColor = True
            '
            'lblIntro
            '
            Me.lblIntro.AutoSize = True
            Me.lblIntro.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIntro.Location = New System.Drawing.Point(2, 2)
            Me.lblIntro.Name = "lblIntro"
            Me.lblIntro.Size = New System.Drawing.Size(76, 17)
            Me.lblIntro.TabIndex = 0
            Me.lblIntro.Text = "Add Server"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblError)
            Me.GroupBox1.Controls.Add(Me.txtPassword)
            Me.GroupBox1.Controls.Add(Me.txtUsername)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.ChkConnectAs)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 105)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(492, 100)
            Me.GroupBox1.TabIndex = 10
            Me.GroupBox1.TabStop = False
            '
            'lblError
            '
            Me.lblError.AutoEllipsis = True
            Me.lblError.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblError.ForeColor = System.Drawing.Color.Red
            Me.lblError.Location = New System.Drawing.Point(376, 14)
            Me.lblError.Name = "lblError"
            Me.lblError.Size = New System.Drawing.Size(112, 83)
            Me.lblError.TabIndex = 16
            '
            'txtPassword
            '
            Me.txtPassword.Enabled = False
            Me.txtPassword.Location = New System.Drawing.Point(159, 57)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(209, 25)
            Me.txtPassword.TabIndex = 15
            '
            'txtUsername
            '
            Me.txtUsername.Cue = "Domain\Username or Username ..."
            Me.txtUsername.Enabled = False
            Me.txtUsername.Location = New System.Drawing.Point(159, 24)
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(209, 25)
            Me.txtUsername.TabIndex = 14
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(27, 57)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(62, 17)
            Me.Label2.TabIndex = 13
            Me.Label2.Text = "Password:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(27, 27)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(68, 17)
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "Username:"
            '
            'ChkConnectAs
            '
            Me.ChkConnectAs.AutoSize = True
            Me.ChkConnectAs.Location = New System.Drawing.Point(6, 0)
            Me.ChkConnectAs.Name = "ChkConnectAs"
            Me.ChkConnectAs.Size = New System.Drawing.Size(92, 21)
            Me.ChkConnectAs.TabIndex = 11
            Me.ChkConnectAs.Text = "Connect as:"
            Me.ChkConnectAs.UseVisualStyleBackColor = True
            '
            'LvRecentServers
            '
            Me.LvRecentServers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColFrequency, Me.ColComputer, Me.ColUsername})
            Me.LvRecentServers.FullRowSelect = True
            Me.LvRecentServers.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
            Me.LvRecentServers.Location = New System.Drawing.Point(12, 234)
            Me.LvRecentServers.Name = "LvRecentServers"
            Me.LvRecentServers.Size = New System.Drawing.Size(492, 127)
            Me.LvRecentServers.TabIndex = 11
            Me.LvRecentServers.UseCompatibleStateImageBehavior = False
            Me.LvRecentServers.View = System.Windows.Forms.View.Details
            '
            'ColFrequency
            '
            Me.ColFrequency.Text = "#"
            Me.ColFrequency.Width = 37
            '
            'ColComputer
            '
            Me.ColComputer.Text = "Computer"
            Me.ColComputer.Width = 243
            '
            'ColUsername
            '
            Me.ColUsername.Text = "Username"
            Me.ColUsername.Width = 175
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(9, 214)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(224, 17)
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "Recent Computers (currently not open)"
            '
            'FrmAddServer
            '
            Me.AcceptButton = Me.BtnOK
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(511, 400)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.LvRecentServers)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.BtnCancel)
            Me.Controls.Add(Me.BtnOK)
            Me.Controls.Add(Me.TxtAnother)
            Me.Controls.Add(Me.rdAnother)
            Me.Controls.Add(Me.RdLocal)
            Me.Controls.Add(Me.lblIntro)
            Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmAddServer"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.Text = "Add Server"
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblIntro As System.Windows.Forms.Label
        Friend WithEvents RdLocal As System.Windows.Forms.RadioButton
        Friend WithEvents rdAnother As System.Windows.Forms.RadioButton
        Friend WithEvents TxtAnother As CueTextBox
        Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
        Friend WithEvents BtnCancel As MetroButton
        Friend WithEvents BtnOK As MetroButton
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents ChkConnectAs As System.Windows.Forms.CheckBox
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents txtUsername As ServicesPlus.Controls.CueTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblError As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents LvRecentServers As System.Windows.Forms.ListView
        Friend WithEvents ColFrequency As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColComputer As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColUsername As System.Windows.Forms.ColumnHeader
    End Class
End Namespace