Public Class clsCalificacionModelo

    Public Property dblParcial1 As Double
    Public Property dblParcial2 As Double
    Public Property dblParcial3 As Double
    Public Property dblExamenFinal As Double
    Public Property dblPromedioParciales As Double
    Public Property dblNotaFinal As Double
    Public Property strLetraCalificacion As String

    Public Sub New()
        Me.dblParcial1 = 0.0
        Me.dblParcial2 = 0.0
        Me.dblParcial3 = 0.0
        Me.dblExamenFinal = 0.0
        Me.dblPromedioParciales = 0.0
        Me.dblNotaFinal = 0.0
        Me.strLetraCalificacion = String.Empty
    End Sub

    Public Sub New(ByVal dblParcial1 As Double, ByVal dblParcial2 As Double, ByVal dblParcial3 As Double, ByVal dblExamenFinal As Double, ByVal dblPromedioParciales As Double, ByVal dblNotaFinal As Double, ByVal strLetraCalificacion As String)
        Me.dblParcial1 = dblParcial1
        Me.dblParcial2 = dblParcial2
        Me.dblParcial3 = dblParcial3
        Me.dblExamenFinal = dblExamenFinal
        Me.dblPromedioParciales = dblPromedioParciales
        Me.dblNotaFinal = dblNotaFinal
        Me.strLetraCalificacion = strLetraCalificacion
    End Sub

End Class

