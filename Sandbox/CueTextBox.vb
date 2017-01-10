Imports System.Runtime.InteropServices

Public Class CueTextBox
    Inherits TextBox

    <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
    Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wp As IntPtr, lp As String) As IntPtr
    End Function

    Private _Cue As String
    Public Property Cue() As String
        Get
            Return _Cue
        End Get
        Set(ByVal value As String)
            _Cue = value
            UpdateCue()
        End Set
    End Property

    Private Sub UpdateCue()
        If Me.IsHandleCreated AndAlso Not String.IsNullOrEmpty(Me.Cue) Then
            SendMessage(Me.Handle, &H1501, 1, Cue)
        End If
    End Sub

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        UpdateCue()
    End Sub

End Class
