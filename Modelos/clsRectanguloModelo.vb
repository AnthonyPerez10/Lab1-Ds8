Public Class clsRectanguloModelo

    Public Property dblBase As Double
    Public Property dblAltura As Double

    Public Sub New()
        Me.dblBase = 0.0
        Me.dblAltura = 0.0
    End Sub

    Public Sub New(ByVal dblBase As Double, ByVal dblAltura As Double)
        Me.dblBase = dblBase
        Me.dblAltura = dblAltura
    End Sub

End Class

