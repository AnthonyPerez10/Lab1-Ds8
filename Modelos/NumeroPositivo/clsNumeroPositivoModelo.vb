Public Class clsNumeroPositivoModelo

    Public Property intNumeroIngresado As Integer
    Public Property strSecuenciaGenerada As String
    Public Property intTotalElementos As Integer
    Public Property intSumatoriaTotal As Integer

    Public Sub New()
        Me.intNumeroIngresado = 0
        Me.strSecuenciaGenerada = String.Empty
        Me.intTotalElementos = 0
        Me.intSumatoriaTotal = 0
    End Sub

    Public Sub New(ByVal intNumeroIngresado As Integer, ByVal strSecuenciaGenerada As String, ByVal intTotalElementos As Integer, ByVal intSumatoriaTotal As Integer)
        Me.intNumeroIngresado = intNumeroIngresado
        Me.strSecuenciaGenerada = strSecuenciaGenerada
        Me.intTotalElementos = intTotalElementos
        Me.intSumatoriaTotal = intSumatoriaTotal
    End Sub

End Class

