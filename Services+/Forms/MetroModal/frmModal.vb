Namespace Forms.MetroModal
    Friend Class FrmModal

        Public WriteOnly Property Line1() As String
            Set(ByVal value As String)
                lblLine1.Text = value
            End Set
        End Property

        Public WriteOnly Property Line2() As String
            Set(ByVal value As String)
                lblLine2.Text = value
            End Set
        End Property

        Private Sub FrmServiceControl_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
            'MainTable.Left = CInt((Width - MainTable.Width) / 2)
            'MainTable.Top = CInt((Height - MainTable.Height) / 2)
        End Sub

        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Close()
        End Sub

        Public Sub CloseAfter()
            BtnClose.Enabled = True
            Timer1.Enabled = True
            Timer1.Start()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            Close()
        End Sub

        Public Sub HideLoader()
            PicLoading.Visible = False
            BtnClose.Enabled = True
        End Sub

    End Class
End Namespace