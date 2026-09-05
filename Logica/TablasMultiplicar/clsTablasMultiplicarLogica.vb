Imports System.Collections.Generic

Public Class clsTablasMultiplicarLogica

    ''' <summary>
    ''' Valida que las entradas del número de la tabla y el límite sean enteros positivos válidos de máximo 2 dígitos (1 al 99).
    ''' </summary>
    Public Function funValidarEntradas(ByVal strNumeroTabla As String, ByVal strLimite As String, ByRef intNumeroValido As Integer, ByRef intLimiteValido As Integer, ByRef strMensajeError As String) As Boolean
        strMensajeError = String.Empty

        If String.IsNullOrWhiteSpace(strNumeroTabla) Then
            strMensajeError = "Debe ingresar el número de la tabla a generar."
            Return False
        End If

        If Not Integer.TryParse(strNumeroTabla.Trim(), intNumeroValido) Then
            strMensajeError = "El número de la tabla debe ser un entero válido sin letras ni caracteres especiales."
            Return False
        End If

        If intNumeroValido <= 0 Then
            strMensajeError = "El número de la tabla debe ser estrictamente mayor a 0."
            Return False
        End If

        If intNumeroValido > 99 Then
            strMensajeError = "El número de la tabla no puede superar los 2 dígitos (máximo 99)."
            Return False
        End If

        If String.IsNullOrWhiteSpace(strLimite) Then
            strMensajeError = "Debe ingresar el límite de multiplicación."
            Return False
        End If

        If Not Integer.TryParse(strLimite.Trim(), intLimiteValido) Then
            strMensajeError = "El límite de multiplicación debe ser un entero válido sin letras ni caracteres especiales."
            Return False
        End If

        If intLimiteValido <= 0 Then
            strMensajeError = "El límite debe ser estrictamente mayor a 0."
            Return False
        End If

        If intLimiteValido > 99 Then
            strMensajeError = "El límite no puede superar los 2 dígitos (máximo 99)."
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Genera iterativamente la tabla de multiplicar mediante un bucle Do While.
    ''' Multiplica el número por el contador, acumula el resultado y aumenta el contador en 1.
    ''' </summary>
    Public Function funGenerarTablaMultiplicar(ByVal intNumeroTabla As Integer, ByVal intLimite As Integer) As clsTablaMultiplicarModelo
        Dim objTablaModelo As New clsTablaMultiplicarModelo(intNumeroTabla, intLimite)

        Dim intContador As Integer = 1
        ' Estructura de Iteración: Do While
        Do While intContador <= intLimite
            Dim intProducto As Integer = intNumeroTabla * intContador
            Dim objItem As New clsItemMultiplicarModelo(intNumeroTabla, intContador, intProducto)
            objTablaModelo.lstItems.Add(objItem)

            intContador += 1
        Loop

        Return objTablaModelo
    End Function

End Class
