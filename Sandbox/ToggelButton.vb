
Public Class ToggelButton
    Property Checked As Boolean = False
    Property UncheckedColor As Color = Color.Red
    Property CheckedColor As Color = Color.Blue

    Private Sub ToggelButton_Click(sender As Object, e As EventArgs) Handles Me.Click
        Checked = Not Checked
        Me.BackColor = If(Checked, CheckedColor, UncheckedColor)
    End Sub

End Class
