Imports System.Globalization
Imports ServicesPlus.Modules

Namespace Forms

    Friend Class FrmAddServer

        ReadOnly _addServerResult As New AddServerResult

        Public Function Open() As AddServerResult
            ShowDialog()
            Return _addServerResult
        End Function

        Private Sub RdLocal_CheckedChanged(sender As Object, e As EventArgs) Handles RdLocal.CheckedChanged
            TxtAnother.Enabled = Not RdLocal.Checked
            If TxtAnother.Enabled Then
                TxtAnother.Focus()
            End If
        End Sub

        Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
            Trace()
            If rdAnother.Checked AndAlso String.IsNullOrEmpty(TxtAnother.Text) Then
                ErrorProvider1.SetIconAlignment(TxtAnother, ErrorIconAlignment.MiddleLeft)
                ErrorProvider1.SetError(TxtAnother, "Please enter a valid computer name")
                Exit Sub
            End If

            _addServerResult.IsResult = True
            If RdLocal.Checked Then
                _addServerResult.ServerName = Environment.MachineName
            End If
            _addServerResult.ServerName = TxtAnother.Text

            If ChkConnectAs.Checked Then
                Dim username = txtUsername.Text
                Dim password = txtPassword.Text
                Dim objIdentity As New BLL.OM.Identity(username, password)
                Try
                    Using context = BLL.Impersonator.LogOn(objIdentity.UserName, objIdentity.Password, objIdentity.Domain)
                        BLL.Impersonator.LogOff(context)
                    End Using
                    lblError.Text = ""
                    _addServerResult.Identity = objIdentity
                    Me.Close()
                Catch ex As Exception
                    lblError.Text = ex.Message
                    _addServerResult.Identity = Nothing
                    _addServerResult.IsResult = False
                End Try
            Else
                Close()
            End If
        End Sub

        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            _addServerResult.IsResult = False
            Close()
        End Sub

        Private Sub FrmAddServer_Load(sender As Object, e As EventArgs) Handles Me.Load
            Dim localList = Glob.AppSettings.RecentServers.OrderByDescending(Function(p) p.OpenCount).ToList
            LvRecentServers.Items.Clear()
            For Each server In localList
                Dim item = LvRecentServers.Items.Add(server.OpenCount)
                item.Tag = server
                item.SubItems.Add(server.Server.ComputerName)
                item.SubItems.Add(If(server.Server.Identity Is Nothing, "", server.Server.Identity.UserName))
            Next
            RdLocal.Text = String.Format(CultureInfo.InvariantCulture, RdLocal.Text, Environment.MachineName)
        End Sub

        Private Sub TxtAnother_TextChanged(sender As Object, e As EventArgs) Handles TxtAnother.TextChanged
            ErrorProvider1.Clear()
        End Sub

        Private Sub ChkConnectAs_CheckedChanged(sender As Object, e As EventArgs) Handles ChkConnectAs.CheckedChanged
            If ChkConnectAs.Checked Then
                txtUsername.Enabled = True
                txtPassword.Enabled = True
                txtUsername.Focus()
                BtnOK.Text = My.Resources.TextTestAndConnect
            Else
                BtnOK.Text = My.Resources.TextOk
                txtUsername.Enabled = False
                txtPassword.Enabled = False
            End If
        End Sub

        Private Sub LvRecentServers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvRecentServers.SelectedIndexChanged
            If LvRecentServers.SelectedItems.Count > 0 Then
                Dim recentServer = TryCast(LvRecentServers.SelectedItems(0).Tag, BLL.OM.RecentServerEntity)
                Dim server = recentServer.Server
                If server.ComputerName.ToUpperInvariant <> Environment.MachineName.ToUpperInvariant Then
                    rdAnother.Checked = True
                    TxtAnother.Text = server.ComputerName
                Else
                    RdLocal.Checked = True
                End If
                If server.Identity IsNot Nothing Then
                    ChkConnectAs.Checked = True
                    txtPassword.Text = server.Identity.Password
                    Dim usernameView = If(String.IsNullOrEmpty(server.Identity.Domain), server.Identity.UserName, String.Format("{0}\{1}", server.Identity.Domain, server.Identity.UserName))
                    txtUsername.Text = usernameView
                Else
                    ChkConnectAs.Checked = False
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                End If
            End If
        End Sub

        Private Sub LvRecentServers_DoubleClick(sender As Object, e As EventArgs) Handles LvRecentServers.DoubleClick
            If LvRecentServers.SelectedItems.Count > 0 Then
                BtnOk_Click(sender, e)
            End If
        End Sub
    End Class

    Friend Class AddServerResult
        Property ServerName As String = ""
        Property IsResult As Boolean = False
        Property Identity As BLL.OM.Identity
    End Class
End Namespace