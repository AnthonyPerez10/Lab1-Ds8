Public Class clsItemMultiplicarModelo

    Public Property intMultiplicando As Integer
    Public Property intMultiplicador As Integer
    Public Property intProducto As Integer

    Public Sub New()
        Me.intMultiplicando = 0
        Me.intMultiplicador = 0
        Me.intProducto = 0
    End Sub

    Public Sub New(ByVal intMultiplicando As Integer, ByVal intMultiplicador As Integer, ByVal intProducto As Integer)
        Me.intMultiplicando = intMultiplicando
        Me.intMultiplicador = intMultiplicador
        Me.intProducto = intProducto
    End Sub

    ''' <summary>
    ''' Retorna la expresión formateada de la multiplicación (ej: "7 × 1 = 7").
    ''' </summary>
    Public ReadOnly Property strExpresion As String
        Get
            Return $"{Me.intMultiplicando} × {Me.intMultiplicador} = {Me.intProducto}"
        End Get
    End Property

End Class

