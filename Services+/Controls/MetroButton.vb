Imports ServicesPlus.Modules
Imports System.ComponentModel

Namespace Controls
    Friend Class MetroButton
        Inherits Button

        Private _borderColor As Color = Modules.ColorBlue
        <Category("Services+")>
        Public Property BorderColor() As Color
            Get
                Return _borderColor
            End Get
            Set(ByVal value As Color)
                _borderColor = value
                FlatAppearance.BorderColor = value
            End Set
        End Property

        Private _mouseDownBackColor As Color = ColorLightblue
        <Category("Services+")>
        Public Property MouseDonwBackColor() As Color
            Get
                Return _mouseDownBackColor
            End Get
            Set(ByVal value As Color)
                _mouseDownBackColor = value
                FlatAppearance.MouseDownBackColor = value
            End Set
        End Property

        Private _fixedHeight As Integer = 30
        <Category("Services+")>
        Public Property FixedHeight() As Integer
            Get
                Return _fixedHeight
            End Get
            Set(ByVal value As Integer)
                _fixedHeight = value
                Me.Height = value
            End Set
        End Property

        Public Sub New()
            FlatAppearance.BorderColor = BorderColor
            FlatAppearance.MouseDownBackColor = MouseDonwBackColor
            FlatAppearance.MouseOverBackColor = Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
            FlatStyle = FlatStyle.Flat
            UseVisualStyleBackColor = True
            Height = Me.FixedHeight
        End Sub

        Private Sub MetroButton_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            Height = Me.FixedHeight
        End Sub

        Protected Overrides Sub OnEnabledChanged(e As EventArgs)
            MyBase.OnEnabledChanged(e)
            If Enabled Then
                Font = New Font(Font, FontStyle.Regular)
                FlatAppearance.BorderColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Else
                Font = New Font(Font, FontStyle.Strikeout)
                FlatAppearance.BorderColor = Color.Silver
            End If
        End Sub
    End Class
End Namespace