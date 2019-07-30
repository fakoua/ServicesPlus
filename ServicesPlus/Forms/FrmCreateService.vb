Imports ServicesPlus.BLL.OM
Imports System.ComponentModel

Friend Class FrmCreateService

    <Category("Services+")>
    Public Event OnServiceRefresh As EventHandler(Of BLL.EventArgs.ServiceEventArgs)

    Private _service As BLL.OM.Service
    Private _identity As BLL.OM.Identity
    Private _needRefresh As Boolean = False

    Function Open(service As BLL.OM.Service, identity As BLL.OM.Identity) As Boolean
        _service = service
        _identity = identity
        If Debugger.IsAttached Then
            Me.TopMost = False
        End If
        Me.ShowDialog()
        Return _needRefresh
    End Function

    Private Sub FrmCreateService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HLoader1.Start()
        HLoader1.Left = 0
        HLoader1.Width = Me.Width
        LblCaption.ForeColor = Modules.ColorLightblue

        DdlAccount.DataSource = BLL.EditServiceModel.AccountList
        DdlErrorControl.DataSource = BLL.EditServiceModel.ErrorControlList
        DdlStartupType.DataSource = BLL.EditServiceModel.StartupTypeList

        HLoader1.Done()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        _needRefresh = False
        Me.Close()
    End Sub

    Private Sub DdlAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DdlAccount.SelectedIndexChanged
        ChkInteract.Enabled = False
        PanelAccount.Enabled = False
        Select Case DdlAccount.SelectedValue.ToString.ToUpperInvariant
            Case "LocalSystem".ToUpperInvariant
                ChkInteract.Enabled = True
            Case "custom".ToUpperInvariant
                PanelAccount.Enabled = True
                TxtAccount.Focus()
        End Select
    End Sub

    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If IsValid() Then
            Try
                HLoader1.Start()
                Panel1.Enabled = False
                BtnSave.Enabled = False
                BtnClose.Enabled = False
                'TODO: Remove hardcoded computer name
                Dim createEntity As New BLL.OM.CreateServiceEntity("NOVO8")
                createEntity.ServiceName = TxtServiceName.Text
                createEntity.DisplayName = TxtDisplayName.Text
                createEntity.ErrorControl = DdlErrorControl.SelectedValue.ToString
                createEntity.DesktopInteract = ChkInteract.Checked
                createEntity.StartMode = DdlStartupType.SelectedValue.ToString
                createEntity.PathName = TxtPath.Text

                If DdlAccount.SelectedValue.ToString = "custom" Then
                    createEntity.StartName = TxtAccount.Text
                Else
                    createEntity.StartName = DdlAccount.SelectedValue.ToString
                End If
                createEntity.StartPassword = TxtPassword.Text

                Dim manager As New BLL.ServiceManager
                manager.Identity = _identity
                Dim result = Await manager.CreateAsync(createEntity)
                LblError.Text = ""
                If result.WmiValue = WmiReturn.Success Then
                    Me.Close()
                Else
                    Dim msg As String
                    If result.WmiValue = WmiReturn.HandledError Then
                        msg = result.LastError
                    Else
                        msg = result.WmiValue.ToString
                    End If
                    LblError.Text = msg
                End If
            Catch ex As Exception
                Modules.PushLog(ex)
                LblError.Text = ex.Message
            Finally
                Panel1.Enabled = True
                BtnSave.Enabled = True
                BtnClose.Enabled = True
                HLoader1.Done()
            End Try
            _needRefresh = True
        End If
    End Sub

    Private Function IsValid() As Boolean

        If String.IsNullOrEmpty(TxtServiceName.Text) Then
            ErrorProvider1.SetIconAlignment(TxtServiceName, ErrorIconAlignment.MiddleLeft)
            ErrorProvider1.SetError(TxtServiceName, "Service name can't be empty")
            Return False
        Else
            ErrorProvider1.Clear()
        End If

        If String.IsNullOrEmpty(TxtDisplayName.Text) Then
            ErrorProvider1.SetIconAlignment(TxtDisplayName, ErrorIconAlignment.MiddleLeft)
            ErrorProvider1.SetError(TxtDisplayName, "Display name can't be empty")
            Return False
        Else
            ErrorProvider1.Clear()
        End If

        If String.IsNullOrEmpty(TxtPath.Text) Then
            ErrorProvider1.SetIconAlignment(TxtPath, ErrorIconAlignment.MiddleLeft)
            ErrorProvider1.SetError(TxtPath, "Path can't be empty")
            Return False
        Else
            ErrorProvider1.Clear()
        End If

        If DdlAccount.SelectedValue.ToString = "custom" AndAlso String.IsNullOrEmpty(TxtAccount.Text) Then
            ErrorProvider1.SetIconAlignment(TxtAccount, ErrorIconAlignment.MiddleLeft)
            ErrorProvider1.SetError(TxtAccount, "Username can't be empty")
            Return False
        Else
            ErrorProvider1.Clear()
        End If

        If TxtPassword.Enabled AndAlso (TxtPassword.Text <> TxtConfirmPassword.Text) Then
            ErrorProvider1.SetIconAlignment(TxtConfirmPassword, ErrorIconAlignment.MiddleLeft)
            ErrorProvider1.SetError(TxtConfirmPassword, "Password does not match")
            Return False
        Else
            ErrorProvider1.Clear()
        End If
        Return True
    End Function

    Private Sub TxtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtConfirmPassword.TextChanged, TxtPassword.TextChanged, TxtAccount.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub TxtAccount_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtAccount.Validating
        If Not String.IsNullOrEmpty(TxtAccount.Text) AndAlso TxtAccount.Text.IndexOf("\") < 0 Then
            TxtAccount.Text = String.Format(".\{0}", TxtAccount.Text)
        End If
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TxtPath.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class
