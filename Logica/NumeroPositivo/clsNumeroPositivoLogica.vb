Public Class clsNumeroPositivoLogica

    ''' <summary>
    ''' Valida si el valor ingresado es un número estrictamente positivo (> 0).
    ''' </summary>
    Public Function funEsNumeroPositivo(ByVal dblNumero As Double) As Boolean
        Return dblNumero > 0
    End Function

End Class

