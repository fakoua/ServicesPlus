Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControl1_Deselected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Deselected
        ' Panel1.Controls(e.TabPageIndex).Font = New Font(Me.Font, FontStyle.Regular)
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        Panel1.Controls(e.TabPageIndex).Font = New Font(Me.Font, FontStyle.Bold)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o As New FormParent
        o.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim o As New FormChild
        o.Show()
    End Sub
End Class

Class sam
    Property p As String
End Class
