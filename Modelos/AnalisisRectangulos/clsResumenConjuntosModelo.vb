Public Class clsResumenConjuntosModelo

    Public Property intTotalRectangulos As Integer
    Public Property objMayorArea As clsRectanguloModelo
    Public Property objMenorArea As clsRectanguloModelo
    Public Property objMayorPerimetro As clsRectanguloModelo
    Public Property objMenorPerimetro As clsRectanguloModelo
    Public Property dblAreaTotal As Double
    Public Property dblPerimetroTotal As Double
    Public Property dblPromedioAreas As Double
    Public Property intCantidadCuadrados As Integer
    Public Property intCantidadHorizontales As Integer
    Public Property intCantidadVerticales As Integer

    Public Sub New()
        Me.intTotalRectangulos = 0
        Me.objMayorArea = Nothing
        Me.objMenorArea = Nothing
        Me.objMayorPerimetro = Nothing
        Me.objMenorPerimetro = Nothing
        Me.dblAreaTotal = 0.0
        Me.dblPerimetroTotal = 0.0
        Me.dblPromedioAreas = 0.0
        Me.intCantidadCuadrados = 0
        Me.intCantidadHorizontales = 0
        Me.intCantidadVerticales = 0
    End Sub

End Class

