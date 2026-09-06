Public Class clsNumeroPositivoLogica

    ''' <summary>
    ''' Valida que el valor ingresado sea un número entero estrictamente positivo (> 0).
    ''' </summary>
    Public Function funValidarNumeroPositivo(ByVal strNumero As String, ByRef intNumeroValido As Integer, ByRef strMensajeError As String) As Boolean
        strMensajeError = String.Empty

        If String.IsNullOrWhiteSpace(strNumero) Then
            strMensajeError = "Debe ingresar un número entero positivo."
            Return False
        End If

        If Not Integer.TryParse(strNumero.Trim(), intNumeroValido) Then
            strMensajeError = "El valor ingresado debe ser un número entero válido sin letras ni caracteres especiales."
            Return False
        End If

        If intNumeroValido <= 0 Then
            strMensajeError = "Por favor, ingrese un número positivo mayor que cero."
            Return False
        End If

        If intNumeroValido > 999 Then
            strMensajeError = "El número máximo permitido es de 3 dígitos (máximo 999)."
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Genera iterativamente la secuencia numérica del 1 hasta N utilizando la estructura de iteración While.
    ''' Acumula la cadena de resultados y calcula la sumatoria total.
    ''' </summary>
    Public Function funGenerarSerieIterativa(ByVal intNumero As Integer) As clsNumeroPositivoModelo
        Dim strSecuencia As String = String.Empty
        Dim intSumatoria As Integer = 0
        Dim i As Integer = 1

        ' Estructura de Iteración: While
        While i <= intNumero
            strSecuencia &= i.ToString() & " "
            intSumatoria += i
            i += 1
        End While

        Return New clsNumeroPositivoModelo(intNumero, strSecuencia.Trim(), intNumero, intSumatoria)
    End Function

End Class
