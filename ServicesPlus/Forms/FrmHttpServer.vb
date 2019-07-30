Public Class FrmHttpServer
    Property PortNumber As Integer

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Me.PortNumber = TxtPortNumber.Value
        Me.Close()
    End Sub
End Class