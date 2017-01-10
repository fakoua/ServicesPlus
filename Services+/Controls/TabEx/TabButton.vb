Imports ServicesPlus.Modules

Namespace Controls.TabEx
    Friend Class TabButton

        Public Event TabClick As EventHandler(Of EventArgs)
        Public Event TabClosing As EventHandler(Of EventArgs)
        Public Event TabAddServer As EventHandler(Of EventArgs)

        Property PageIndex As Integer

        Private _isActive As Boolean
        Public Property IsActive() As Boolean
            Get
                Return _isActive
            End Get
            Set(ByVal value As Boolean)
                _isActive = value
                If _isActive Then
                    BackColor = ColorBlue
                    lblCaption.ForeColor = Color.White
                Else
                    BackColor = ColorBackgroud
                    lblCaption.ForeColor = Color.Black
                End If
            End Set
        End Property

        Private Sub TabButton_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, lblCaption.MouseDown, TableMain.MouseDown
            RaiseEvent TabClick(Me, EventArgs.Empty)
            IsActive = True
        End Sub

        Private Sub BtnClose_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClose.MouseDown
            RaiseEvent TabClosing(Me, EventArgs.Empty)
        End Sub

        Private Sub TabButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter, lblCaption.MouseEnter, TableMain.MouseEnter, btnClose.MouseEnter
            If Not IsActive Then BackColor = ColorLightblue
            lblCaption.ForeColor = Color.White
        End Sub

        Private Sub TabButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave, lblCaption.MouseLeave, TableMain.MouseLeave, btnClose.MouseLeave
            If Not IsActive Then
                lblCaption.ForeColor = Color.Black
                BackColor = ColorBackgroud
            End If
        End Sub

        Private Sub TabButton_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
            Height = 28
        End Sub

        Private Sub TabButton_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
            Using linePen As New Pen(ColorBlue, 2)
                e.Graphics.DrawLine(linePen, New Point(0, Height - 1), New Point(Width, Height - 1))
            End Using
        End Sub

        Public Overrides Property Text() As String
            Get
                Return lblCaption.Text
            End Get
            Set(ByVal value As String)
                If String.IsNullOrEmpty(value) Then
                    lblCaption.Text = ""
                Else
                    lblCaption.Text = value.ToUpperInvariant
                End If
            End Set
        End Property

        Private Sub AddServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddServerToolStripMenuItem.Click
            RaiseEvent TabAddServer(Me, e)
        End Sub

        Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
            RaiseEvent TabClosing(Me, EventArgs.Empty)
        End Sub
    End Class
End Namespace