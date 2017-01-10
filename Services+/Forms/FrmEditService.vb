Imports ServicesPlus.BLL.OM
Imports System.ComponentModel

Friend Class FrmEditService

    <Category("Services+")>
    Public Event OnServiceRefresh As EventHandler(Of BLL.EventArgs.ServiceEventArgs)

    Private _service As BLL.OM.Service
    Private _identity As BLL.OM.Identity
    Sub Open(service As BLL.OM.Service, identity As BLL.OM.Identity)
        _service = service
        _identity = identity
        Me.ShowDialog()
    End Sub

    Private Sub FrmEditService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HLoader1.Start()
        HLoader1.Left = 0
        HLoader1.Width = Me.Width
        LblCaption.ForeColor = Modules.ColorLightblue

        DdlAccount.DataSource = BLL.EditServiceModel.AccountList
        ddlErrorControl.DataSource = BLL.EditServiceModel.ErrorControlList
        ddlStartupType.DataSource = BLL.EditServiceModel.StartupTypeList

        txtDisplayName.Text = _service.DisplayName
        ddlStartupType.SelectedValue = _service.StartModeView
        ddlErrorControl.SelectedValue = _service.ErrorControl

        Select Case _service.StartName.ToUpperInvariant
            Case "LocalSystem".ToUpperInvariant
                ChkInteract.Checked = _service.DesktopInteract
                DdlAccount.SelectedValue = "LocalSystem"
            Case "NT AUTHORITY\LocalService".ToUpperInvariant
                DdlAccount.SelectedValue = "NT AUTHORITY\LocalService"
            Case "NT AUTHORITY\NetworkService".ToUpperInvariant
                DdlAccount.SelectedValue = "NT AUTHORITY\NetworkService"
            Case Else
                DdlAccount.SelectedValue = "custom"
                TxtAccount.Text = _service.StartName
                TxtPassword.Text = ""
        End Select
        LblCaption.Text = String.Format(LblCaption.Tag.ToString, _service.DisplayName)
        HLoader1.Done()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
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
                Dim editEntity As New BLL.OM.EditServiceEntry(_service.SystemName, _service.ServiceName)
                editEntity.DisplayName = txtDisplayName.Text
                editEntity.ErrorControl = ddlErrorControl.SelectedValue.ToString
                editEntity.DesktopInteract = ChkInteract.Checked
                editEntity.StartMode = ddlStartupType.SelectedValue.ToString
                If DdlAccount.SelectedValue.ToString = "custom" Then
                    editEntity.StartName = TxtAccount.Text
                Else
                    editEntity.StartName = DdlAccount.SelectedValue.ToString
                End If
                editEntity.StartPassword = TxtPassword.Text
                Dim manager As New BLL.ServiceManager
                manager.Identity = _identity
                Dim result = Await manager.ChangeAsync(editEntity)
                LblError.Text = ""
                If result.WmiValue = WmiReturn.Success Then
                    RaiseEvent OnServiceRefresh(Me, New BLL.EventArgs.ServiceEventArgs With {.Service = result.ServiceRefresh})
                    LblCaption.Text = String.Format(LblCaption.Tag.ToString, result.ServiceRefresh.DisplayName)
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
        End If
    End Sub

    Private Function IsValid() As Boolean
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
End Class