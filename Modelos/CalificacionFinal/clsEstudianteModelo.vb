Imports System.Collections.Generic

Public Class clsEstudianteModelo

    Public Property strNombre As String
    Public Property lstNotas As List(Of Double)

    Public Sub New()
        Me.strNombre = String.Empty
        Me.lstNotas = New List(Of Double)()
    End Sub

    Public Sub New(ByVal strNombre As String)
        Me.strNombre = strNombre
        Me.lstNotas = New List(Of Double)()
    End Sub

End Class

