Public Class clsAnalisisRectangulosLogica

    ''' <summary>
    ''' Calcula el área de un rectángulo.
    ''' </summary>
    Public Function funCalcularArea(ByVal dblBase As Double, ByVal dblAltura As Double) As Double
        Return dblBase * dblAltura
    End Function

    ''' <summary>
    ''' Calcula el perímetro de un rectángulo.
    ''' </summary>
    Public Function funCalcularPerimetro(ByVal dblBase As Double, ByVal dblAltura As Double) As Double
        Return 2 * (dblBase + dblAltura)
    End Function

End Class

