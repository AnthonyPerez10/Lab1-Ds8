Imports System.Collections.Generic

Public Class clsTablasMultiplicarLogica

    ''' <summary>
    ''' Genera la tabla de multiplicar de un número hasta un límite mediante un bucle For.
    ''' </summary>
    Public Function funGenerarTabla(ByVal intNumero As Integer, ByVal intLimite As Integer) As List(Of String)
        Dim lstResultados As New List(Of String)()
        For i As Integer = 1 To intLimite
            Dim intResultado As Integer = intNumero * i
            lstResultados.Add($"{intNumero} x {i} = {intResultado}")
        Next
        Return lstResultados
    End Function

End Class

