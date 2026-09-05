Public Class clsCalificacionFinalLogica

    ''' <summary>
    ''' Valida que las cuatro notas ingresadas sean valores numéricos válidos en el rango de 0.00 a 100.00.
    ''' </summary>
    Public Function funValidarNotas(ByVal strP1 As String, ByVal strP2 As String, ByVal strP3 As String, ByVal strFinal As String, ByRef dblP1 As Double, ByRef dblP2 As Double, ByRef dblP3 As Double, ByRef dblFinal As Double, ByRef strMensajeError As String) As Boolean
        strMensajeError = String.Empty

        ' Validar Parcial 1
        If String.IsNullOrWhiteSpace(strP1) OrElse Not Double.TryParse(strP1.Trim(), dblP1) Then
            strMensajeError = "Ingrese una nota válida para el Parcial N° 1."
            Return False
        End If
        If dblP1 < 0.0 OrElse dblP1 > 100.0 Then
            strMensajeError = "La nota del Parcial N° 1 debe estar entre 0.00 y 100.00."
            Return False
        End If

        ' Validar Parcial 2
        If String.IsNullOrWhiteSpace(strP2) OrElse Not Double.TryParse(strP2.Trim(), dblP2) Then
            strMensajeError = "Ingrese una nota válida para el Parcial N° 2."
            Return False
        End If
        If dblP2 < 0.0 OrElse dblP2 > 100.0 Then
            strMensajeError = "La nota del Parcial N° 2 debe estar entre 0.00 y 100.00."
            Return False
        End If

        ' Validar Parcial 3
        If String.IsNullOrWhiteSpace(strP3) OrElse Not Double.TryParse(strP3.Trim(), dblP3) Then
            strMensajeError = "Ingrese una nota válida para el Parcial N° 3."
            Return False
        End If
        If dblP3 < 0.0 OrElse dblP3 > 100.0 Then
            strMensajeError = "La nota del Parcial N° 3 debe estar entre 0.00 y 100.00."
            Return False
        End If

        ' Validar Examen Final
        If String.IsNullOrWhiteSpace(strFinal) OrElse Not Double.TryParse(strFinal.Trim(), dblFinal) Then
            strMensajeError = "Ingrese una nota válida para el Examen Final."
            Return False
        End If
        If dblFinal < 0.0 OrElse dblFinal > 100.0 Then
            strMensajeError = "La nota del Examen Final debe estar entre 0.00 y 100.00."
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Procesa el cálculo ponderado (60% promedio de parciales + 40% examen final) y asigna la calificación alfabética.
    ''' </summary>
    Public Function funCalcularCalificacionFinal(ByVal dblP1 As Double, ByVal dblP2 As Double, ByVal dblP3 As Double, ByVal dblFinal As Double) As clsCalificacionModelo
        Dim dblPromedioParciales As Double = (dblP1 + dblP2 + dblP3) / 3.0
        Dim dblNotaFinal As Double = (dblPromedioParciales * 0.6) + (dblFinal * 0.4)
        Dim strLetra As String = funDeterminarLetra(dblNotaFinal)

        Return New clsCalificacionModelo(dblP1, dblP2, dblP3, dblFinal, dblPromedioParciales, dblNotaFinal, strLetra)
    End Function

    ''' <summary>
    ''' Asigna la letra de calificación equivalente según la nota final obtenida.
    ''' </summary>
    Public Function funDeterminarLetra(ByVal dblNotaFinal As Double) As String
        If dblNotaFinal >= 91.0 Then
            Return "A"
        ElseIf dblNotaFinal >= 81.0 Then
            Return "B"
        ElseIf dblNotaFinal >= 71.0 Then
            Return "C"
        ElseIf dblNotaFinal >= 61.0 Then
            Return "D"
        Else
            Return "F"
        End If
    End Function

End Class
