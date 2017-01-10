<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreateService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCreateService))
        Me.LblCaption = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnBrowse = New ServicesPlus.Controls.MetroButton()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtServiceName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelAccount = New System.Windows.Forms.Panel()
        Me.TxtConfirmPassword = New ServicesPlus.Controls.CueTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtAccount = New ServicesPlus.Controls.CueTextBox()
        Me.TxtPassword = New ServicesPlus.Controls.CueTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChkInteract = New System.Windows.Forms.CheckBox()
        Me.DdlAccount = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DdlErrorControl = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DdlStartupType = New System.Windows.Forms.ComboBox()
        Me.LblStartupType = New System.Windows.Forms.Label()
        Me.TxtDisplayName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblError = New System.Windows.Forms.Label()
        Me.BtnSave = New ServicesPlus.Controls.MetroButton()
        Me.HLoader1 = New ServicesPlus.Controls.HLoader()
        Me.BtnClose = New ServicesPlus.Controls.MetroButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelAccount.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCaption
        '
        Me.LblCaption.AutoSize = True
        Me.LblCaption.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaption.Location = New System.Drawing.Point(12, 9)
        Me.LblCaption.Name = "LblCaption"
        Me.LblCaption.Size = New System.Drawing.Size(208, 32)
        Me.LblCaption.TabIndex = 0
        Me.LblCaption.Tag = ""
        Me.LblCaption.Text = "Create new service"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnBrowse)
        Me.Panel1.Controls.Add(Me.TxtPath)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtServiceName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DdlErrorControl)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DdlStartupType)
        Me.Panel1.Controls.Add(Me.LblStartupType)
        Me.Panel1.Controls.Add(Me.TxtDisplayName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(485, 370)
        Me.Panel1.TabIndex = 1
        '
        'BtnBrowse
        '
        Me.BtnBrowse.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnBrowse.FixedHeight = 25
        Me.BtnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowse.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBrowse.Location = New System.Drawing.Point(444, 136)
        Me.BtnBrowse.MouseDonwBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(25, 25)
        Me.BtnBrowse.TabIndex = 5
        Me.BtnBrowse.Text = "..."
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'TxtPath
        '
        Me.TxtPath.Location = New System.Drawing.Point(97, 136)
        Me.TxtPath.MaxLength = 240
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(341, 25)
        Me.TxtPath.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Binary path:"
        '
        'TxtServiceName
        '
        Me.TxtServiceName.Location = New System.Drawing.Point(97, 8)
        Me.TxtServiceName.MaxLength = 240
        Me.TxtServiceName.Name = "TxtServiceName"
        Me.TxtServiceName.Size = New System.Drawing.Size(374, 25)
        Me.TxtServiceName.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Service name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PanelAccount)
        Me.GroupBox1.Controls.Add(Me.ChkInteract)
        Me.GroupBox1.Controls.Add(Me.DdlAccount)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 186)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Log on"
        '
        'PanelAccount
        '
        Me.PanelAccount.Controls.Add(Me.TxtConfirmPassword)
        Me.PanelAccount.Controls.Add(Me.Label4)
        Me.PanelAccount.Controls.Add(Me.Label6)
        Me.PanelAccount.Controls.Add(Me.TxtAccount)
        Me.PanelAccount.Controls.Add(Me.TxtPassword)
        Me.PanelAccount.Controls.Add(Me.Label5)
        Me.PanelAccount.Location = New System.Drawing.Point(17, 72)
        Me.PanelAccount.Name = "PanelAccount"
        Me.PanelAccount.Size = New System.Drawing.Size(438, 103)
        Me.PanelAccount.TabIndex = 8
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.Cue = "Keep it empty for unchanged password ..."
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(138, 71)
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(290, 25)
        Me.TxtConfirmPassword.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Account:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Confirm password:"
        '
        'TxtAccount
        '
        Me.TxtAccount.Cue = "Domain\Username or .\Username"
        Me.TxtAccount.Location = New System.Drawing.Point(138, 9)
        Me.TxtAccount.Name = "TxtAccount"
        Me.TxtAccount.Size = New System.Drawing.Size(290, 25)
        Me.TxtAccount.TabIndex = 0
        '
        'TxtPassword
        '
        Me.TxtPassword.Cue = "Keep it empty for unchanged password ..."
        Me.TxtPassword.Location = New System.Drawing.Point(138, 40)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(290, 25)
        Me.TxtPassword.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Password:"
        '
        'ChkInteract
        '
        Me.ChkInteract.AutoSize = True
        Me.ChkInteract.Location = New System.Drawing.Point(303, 33)
        Me.ChkInteract.Name = "ChkInteract"
        Me.ChkInteract.Size = New System.Drawing.Size(143, 21)
        Me.ChkInteract.TabIndex = 1
        Me.ChkInteract.Text = "Interact with desktop"
        Me.ChkInteract.UseVisualStyleBackColor = True
        '
        'DdlAccount
        '
        Me.DdlAccount.DisplayMember = "Display"
        Me.DdlAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DdlAccount.FormattingEnabled = True
        Me.DdlAccount.Location = New System.Drawing.Point(91, 30)
        Me.DdlAccount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DdlAccount.Name = "DdlAccount"
        Me.DdlAccount.Size = New System.Drawing.Size(206, 25)
        Me.DdlAccount.TabIndex = 0
        Me.DdlAccount.ValueMember = "Value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Account:"
        '
        'DdlErrorControl
        '
        Me.DdlErrorControl.DisplayMember = "Display"
        Me.DdlErrorControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DdlErrorControl.FormattingEnabled = True
        Me.DdlErrorControl.Location = New System.Drawing.Point(97, 104)
        Me.DdlErrorControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DdlErrorControl.Name = "DdlErrorControl"
        Me.DdlErrorControl.Size = New System.Drawing.Size(374, 25)
        Me.DdlErrorControl.TabIndex = 3
        Me.DdlErrorControl.ValueMember = "Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Error control:"
        '
        'DdlStartupType
        '
        Me.DdlStartupType.DisplayMember = "Display"
        Me.DdlStartupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DdlStartupType.FormattingEnabled = True
        Me.DdlStartupType.Location = New System.Drawing.Point(97, 71)
        Me.DdlStartupType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DdlStartupType.Name = "DdlStartupType"
        Me.DdlStartupType.Size = New System.Drawing.Size(374, 25)
        Me.DdlStartupType.TabIndex = 2
        Me.DdlStartupType.ValueMember = "Value"
        '
        'LblStartupType
        '
        Me.LblStartupType.AutoSize = True
        Me.LblStartupType.Location = New System.Drawing.Point(3, 74)
        Me.LblStartupType.Name = "LblStartupType"
        Me.LblStartupType.Size = New System.Drawing.Size(79, 17)
        Me.LblStartupType.TabIndex = 2
        Me.LblStartupType.Text = "Startup type:"
        '
        'TxtDisplayName
        '
        Me.TxtDisplayName.Location = New System.Drawing.Point(97, 39)
        Me.TxtDisplayName.MaxLength = 240
        Me.TxtDisplayName.Name = "TxtDisplayName"
        Me.TxtDisplayName.Size = New System.Drawing.Size(374, 25)
        Me.TxtDisplayName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Display name:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 100
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LblError
        '
        Me.LblError.AutoEllipsis = True
        Me.LblError.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.ForeColor = System.Drawing.Color.Red
        Me.LblError.Location = New System.Drawing.Point(12, 435)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(320, 28)
        Me.LblError.TabIndex = 9
        '
        'BtnSave
        '
        Me.BtnSave.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.FixedHeight = 30
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Location = New System.Drawing.Point(341, 435)
        Me.BtnSave.MouseDonwBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 30)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'HLoader1
        '
        Me.HLoader1.Location = New System.Drawing.Point(-3, 49)
        Me.HLoader1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HLoader1.Name = "HLoader1"
        Me.HLoader1.Size = New System.Drawing.Size(800, 3)
        Me.HLoader1.Step = 2
        Me.HLoader1.TabIndex = 6
        '
        'BtnClose
        '
        Me.BtnClose.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnClose.FixedHeight = 30
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(422, 435)
        Me.BtnClose.MouseDonwBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 30)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.CheckFileExists = False
        Me.OpenFileDialog1.CheckPathExists = False
        Me.OpenFileDialog1.DefaultExt = "exe"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Executable|*.exe"
        Me.OpenFileDialog1.InitialDirectory = "C:\Windows\System32"
        Me.OpenFileDialog1.Title = "Services+"
        '
        'FrmCreateService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(509, 476)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.HLoader1)
        Me.Controls.Add(Me.LblCaption)
        Me.Controls.Add(Me.BtnClose)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmCreateService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Service"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelAccount.ResumeLayout(False)
        Me.PanelAccount.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As ServicesPlus.Controls.MetroButton
    Friend WithEvents LblCaption As System.Windows.Forms.Label
    Friend WithEvents HLoader1 As ServicesPlus.Controls.HLoader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtDisplayName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DdlStartupType As System.Windows.Forms.ComboBox
    Friend WithEvents LblStartupType As System.Windows.Forms.Label
    Friend WithEvents DdlErrorControl As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DdlAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkInteract As System.Windows.Forms.CheckBox
    Friend WithEvents TxtConfirmPassword As Controls.CueTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As Controls.CueTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtAccount As Controls.CueTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PanelAccount As System.Windows.Forms.Panel
    Friend WithEvents BtnSave As ServicesPlus.Controls.MetroButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblError As System.Windows.Forms.Label
    Friend WithEvents TxtServiceName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnBrowse As ServicesPlus.Controls.MetroButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
