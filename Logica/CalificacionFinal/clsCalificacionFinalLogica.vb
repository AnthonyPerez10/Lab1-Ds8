Imports System.Collections.Generic

Public Class clsCalificacionFinalLogica

    ''' <summary>
    ''' Calcula el promedio final de una lista de notas.
    ''' </summary>
    Public Function funCalcularPromedio(ByVal lstNotas As List(Of Double)) As Double
        If lstNotas Is Nothing OrElse lstNotas.Count = 0 Then Return 0.0

        Dim dblSuma As Double = 0.0
        For Each dblNota As Double In lstNotas
            dblSuma += dblNota
        Next
        Return dblSuma / lstNotas.Count
    End Function

    ''' <summary>
    ''' Determina el estado de aprobación según el promedio.
    ''' </summary>
    Public Function funObtenerEstado(ByVal dblPromedio As Double) As String
        If dblPromedio >= 71.0 Then
            Return "Aprobado"
        Else
            Return "Reprobado"
        End If
    End Function

End Class

