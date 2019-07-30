Imports ServicesPlus.Modules

Namespace Controls.TabEx

    Friend Class TabHeader

        Const TabHeaderDefaultWidth = 150
        Const TabAddWidth = 35

        Public Property CanAdd() As Boolean
            Get
                Return BtnNew.Enabled
            End Get
            Set(ByVal value As Boolean)
                BtnNew.Enabled = value
            End Set
        End Property

        ReadOnly Property Tabs As Dictionary(Of String, Integer)
            Get
                Dim rtnVal As New Dictionary(Of String, Integer)
                For i As Int32 = 0 To MainFlow.Controls.Count - 2
                    Dim tb = DirectCast(MainFlow.Controls(i), TabButton)
                    rtnVal.Add(tb.Text, i)
                Next
                Return rtnVal
            End Get
        End Property

        Public Event OnAdding As EventHandler(Of EventArgs)
        Public Event OnRemoving As EventHandler(Of CancelingEventArgs)

#Region "TabControl"

        Private _tabControl As TabControl
        Public Property TabControl() As TabControl
            Get
                Return _tabControl
            End Get
            Set(ByVal value As TabControl)
                _tabControl = value
                If _tabControl IsNot Nothing Then
                    AddHandler _tabControl.ControlAdded, AddressOf TabControl_ControlAdded
                    AddHandler _tabControl.ControlRemoved, AddressOf TabControl_ControlRemoved
                    AddHandler _tabControl.Deselected, AddressOf TabControl_Deselected
                    AddHandler _tabControl.Selected, AddressOf TabControl_Selected
                End If
            End Set
        End Property

        Private Sub TabControl_ControlRemoved(sender As Object, e As ControlEventArgs)
            Dim index = -1
            For i As Integer = 0 To TabControl.TabPages.Count - 1
                If e.Control Is TabControl.TabPages(i) Then
                    index = i
                End If
            Next

            Dim tabButton = DirectCast(MainFlow.Controls(index), TabButton)
            RemoveHandler tabButton.TabClick, AddressOf TabButton_TabClick
            RemoveHandler tabButton.TabClosing, AddressOf TabButton_TabClosing
            RemoveHandler tabButton.TabAddServer, AddressOf TabButton_TabAddServer

            MainFlow.Controls.RemoveAt(index)
            tabButton.Dispose()
            PerformResize()
            ArrageIndex()
        End Sub

        Private Sub TabControl_ControlAdded(sender As Object, e As ControlEventArgs)
            Trace()
            Dim tabPage = DirectCast(e.Control, TabPage)
            Dim tabButton As New TabButton With {.Text = tabPage.Text}
            AddHandler tabButton.TabClick, AddressOf TabButton_TabClick
            AddHandler tabButton.TabClosing, AddressOf TabButton_TabClosing
            AddHandler tabButton.TabAddServer, AddressOf TabButton_TabAddServer
            tabButton.IsActive = True
            MainFlow.Controls.Add(tabButton)
            MainFlow.Controls.SetChildIndex(BtnNew, 1000)
            PerformResize()
            ArrageIndex()
        End Sub

        Private Sub ArrageIndex()
            For i As Integer = 0 To MainFlow.Controls.Count - 2 'Exclude +
                DirectCast(MainFlow.Controls(i), TabButton).PageIndex = i
            Next
        End Sub

        Private Sub TabButton_TabClosing(sender As Object, e As EventArgs)
            Dim canceling = New CancelingEventArgs With {.Cancel = False}
            RaiseEvent OnRemoving(sender, canceling)
            If Not canceling.Cancel Then
                Dim tabButton = DirectCast(sender, TabButton)
                TabControl.TabPages.RemoveAt(tabButton.PageIndex)
            End If
        End Sub

        Private Sub TabButton_TabClick(sender As Object, e As EventArgs)
            TabControl.SelectedIndex = DirectCast(sender, TabButton).PageIndex
        End Sub

        Private Sub TabButton_TabAddServer(sender As Object, e As EventArgs)
            RaiseEvent OnAdding(Me, EventArgs.Empty)
        End Sub

        Private Sub TabControl_Deselected(sender As Object, e As TabControlEventArgs)
            If e.TabPageIndex > -1 Then
                DirectCast(MainFlow.Controls(e.TabPageIndex), TabButton).IsActive = False
            End If
        End Sub

        Private Sub TabControl_Selected(sender As Object, e As TabControlEventArgs)
            If e.TabPageIndex > -1 Then
                DirectCast(MainFlow.Controls(e.TabPageIndex), TabButton).IsActive = True
            End If
        End Sub
#End Region

        Private Sub MainFlow_Resize(sender As Object, e As EventArgs) Handles MainFlow.Resize
            PerformResize()
        End Sub

        Private Sub PerformResize()
            Trace()
            MainFlow.SuspendLayout()
            Dim tabsCount = MainFlow.Controls.Count - 1
            Dim totalTabsWidth = (tabsCount * TabHeaderDefaultWidth) + TabAddWidth
            Dim eachWidth = TabHeaderDefaultWidth

            If MainFlow.Width <= totalTabsWidth Then
                eachWidth = CInt((MainFlow.Width - TabAddWidth - 12) / tabsCount)
            End If

            For i As Integer = 0 To tabsCount - 1
                MainFlow.Controls(i).Width = eachWidth
            Next
            MainFlow.ResumeLayout(True)
        End Sub

        Private Sub BtnNew_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnNew.MouseDown
            RaiseEvent OnAdding(Me, EventArgs.Empty)
        End Sub

        Private Sub TabHeader_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
            Using linePen As New Pen(ColorBlue, 2)
                e.Graphics.DrawLine(linePen, New Point(0, Height - 3), New Point(Width, Height - 3))
            End Using
        End Sub
    End Class

    Friend Class CancelingEventArgs
        Inherits EventArgs

        Property Cancel As Boolean
    End Class
End Namespace