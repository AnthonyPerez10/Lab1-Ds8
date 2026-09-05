Public Class clsRectanguloModelo

    Public Property intId As Integer
    Public Property strNombre As String
    Public Property dblBase As Double
    Public Property dblAltura As Double

    Public Sub New()
        Me.intId = 0
        Me.strNombre = String.Empty
        Me.dblBase = 0.0
        Me.dblAltura = 0.0
    End Sub

    Public Sub New(ByVal intId As Integer, ByVal strNombre As String, ByVal dblBase As Double, ByVal dblAltura As Double)
        Me.intId = intId
        Me.strNombre = strNombre
        Me.dblBase = dblBase
        Me.dblAltura = dblAltura
    End Sub

    ''' <summary>
    ''' Calcula el área del rectángulo: Base * Altura
    ''' </summary>
    Public ReadOnly Property dblArea As Double
        Get
            Return Me.dblBase * Me.dblAltura
        End Get
    End Property

    ''' <summary>
    ''' Calcula el perímetro del rectángulo: 2 * (Base + Altura)
    ''' </summary>
    Public ReadOnly Property dblPerimetro As Double
        Get
            Return 2 * (Me.dblBase + Me.dblAltura)
        End Get
    End Property

    ''' <summary>
    ''' Determina el tipo de figura geométrica: Cuadrado, Horizontal o Vertical.
    ''' </summary>
    Public ReadOnly Property strTipo As String
        Get
            If Me.dblBase = Me.dblAltura Then
                Return "Cuadrado"
            ElseIf Me.dblBase > Me.dblAltura Then
                Return "Horizontal"
            Else
                Return "Vertical"
            End If
        End Get
    End Property

End Class

