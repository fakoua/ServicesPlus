Public Class TestService01

    Dim th As System.Threading.Timer
    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        th = New System.Threading.Timer(New System.Threading.TimerCallback(AddressOf OnTimer), Nothing, 1000, 600000)
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        th.Dispose()
    End Sub

    Private Sub OnTimer(st As Object)

    End Sub
End Class
