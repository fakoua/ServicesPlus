Friend Class frmDelete

    Dim _service As BLL.OM.Service
    Dim success As Boolean = False
    Public Function Open(service As BLL.OM.Service) As Boolean
        Me._service = service

        LblTitle.Text = String.Format(LblTitle.Text, service.DisplayName)

        HLoader1.Start()
        HLoader1.Done()
        Dim rA = GetRandom(4, 15)
        Dim rB = GetRandom(10, 50)
        Dim result = rA + rB

        txtA.Text = rA
        txtB.Text = rB

        txtResult.Cue = String.Format("{0} + {1} = ?", rA, rB)
        txtResult.Tag = result
        Me.ShowDialog()
        Return success
    End Function


    Private Function GetRandom(min As Integer, max As Integer) As Integer
        Randomize()
        Dim r As New Random(Now.Millisecond + Now.Second + Now.Minute + Now.Hour)
        Return r.Next(min, max)
    End Function
   
    Private Sub frmDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Debugger.IsAttached Or (Not String.IsNullOrEmpty(txtResult.Text) AndAlso txtResult.Text.Trim = txtResult.Tag.ToString) Then
            LblWrongAnswer.Visible = False
            BtnDelete.Enabled = False
            HLoader1.Start()

            Dim objManager As New BLL.ServiceManager
            Dim res = Await objManager.DeleteAsync(Me._service)
            If res.WmiValue = BLL.OM.WmiReturn.Success Then
                Me.success = True
                Me.Close()
            Else
                Me.success = False
                LblError.Text = res.LastError
            End If
        Else
            LblWrongAnswer.Visible = True
        End If
    End Sub
End Class