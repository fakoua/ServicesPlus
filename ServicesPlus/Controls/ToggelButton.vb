Imports System.ComponentModel

Namespace Controls

    Friend Class ToggelButton
        <Category("Services+")>
        Property Checked As Boolean = False
        <Category("Services+")>
        Property UncheckedColor As Color = Modules.ColorBackgroud
        <Category("Services+")>
        Property CheckedColor As Color = Modules.ColorLightblue

        Private Sub ToggelButton_Click(sender As Object, e As EventArgs) Handles Me.Click
            Checked = Not Checked
            Me.BackColor = If(Checked, CheckedColor, UncheckedColor)
        End Sub

    End Class

End Namespace
