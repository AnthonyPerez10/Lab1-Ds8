Imports System.Collections.Generic

Public Class clsTablaMultiplicarModelo

    Public Property intNumeroTabla As Integer
    Public Property intLimite As Integer
    Public Property lstItems As List(Of clsItemMultiplicarModelo)

    Public Sub New()
        Me.intNumeroTabla = 0
        Me.intLimite = 0
        Me.lstItems = New List(Of clsItemMultiplicarModelo)()
    End Sub

    Public Sub New(ByVal intNumeroTabla As Integer, ByVal intLimite As Integer)
        Me.intNumeroTabla = intNumeroTabla
        Me.intLimite = intLimite
        Me.lstItems = New List(Of clsItemMultiplicarModelo)()
    End Sub

    ''' <summary>
    ''' Sumatoria total de todos los productos generados.
    ''' </summary>
    Public ReadOnly Property intSumaProductos As Integer
        Get
            Dim intSuma As Integer = 0
            For Each objItem As clsItemMultiplicarModelo In Me.lstItems
                intSuma += objItem.intProducto
            Next
            Return intSuma
        End Get
    End Property

    ''' <summary>
    ''' Producto máximo alcanzado en la serie.
    ''' </summary>
    Public ReadOnly Property intProductoMaximo As Integer
        Get
            If Me.lstItems.Count = 0 Then Return 0
            Return Me.lstItems(Me.lstItems.Count - 1).intProducto
        End Get
    End Property

End Class

