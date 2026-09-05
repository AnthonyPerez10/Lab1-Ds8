Imports System.Collections.Generic

Public Class clsAnalisisRectangulosLogica

    ''' <summary>
    ''' Valida que la cantidad total de rectángulos a analizar sea un número entero positivo (máximo 2 dígitos: 1 al 99).
    ''' </summary>
    Public Function funValidarCantidad(ByVal strCantidad As String, ByRef intCantidadValida As Integer, ByRef strMensajeError As String) As Boolean
        strMensajeError = String.Empty

        If String.IsNullOrWhiteSpace(strCantidad) Then
            strMensajeError = "Debe ingresar la cantidad de rectángulos a analizar."
            Return False
        End If

        If Not Integer.TryParse(strCantidad.Trim(), intCantidadValida) Then
            strMensajeError = "La cantidad debe ser un número entero positivo sin letras ni caracteres especiales."
            Return False
        End If

        If intCantidadValida <= 0 Then
            strMensajeError = "La cantidad debe ser un número positivo mayor que cero."
            Return False
        End If

        If intCantidadValida > 99 Then
            strMensajeError = "La cantidad máxima permitida es de 2 dígitos (máximo 99)."
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Valida que la base y la altura sean valores numéricos positivos mayores a cero.
    ''' </summary>
    Public Function funValidarDimensiones(ByVal strBase As String, ByVal strAltura As String, ByRef dblBaseValida As Double, ByRef dblAlturaValida As Double, ByRef strMensajeError As String) As Boolean
        strMensajeError = String.Empty

        If String.IsNullOrWhiteSpace(strBase) Then
            strMensajeError = "Debe ingresar el valor de la base."
            Return False
        End If

        If Not Double.TryParse(strBase.Trim(), dblBaseValida) Then
            strMensajeError = "El valor de la base debe ser un número válido sin letras ni caracteres especiales."
            Return False
        End If

        If dblBaseValida <= 0 Then
            strMensajeError = "El valor de la base debe ser estrictamente positivo (mayor que 0)."
            Return False
        End If

        If String.IsNullOrWhiteSpace(strAltura) Then
            strMensajeError = "Debe ingresar el valor de la altura."
            Return False
        End If

        If Not Double.TryParse(strAltura.Trim(), dblAlturaValida) Then
            strMensajeError = "El valor de la altura debe ser un número válido sin letras ni caracteres especiales."
            Return False
        End If

        If dblAlturaValida <= 0 Then
            strMensajeError = "El valor de la altura debe ser estrictamente positivo (mayor que 0)."
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Crea e inicializa una instancia de la entidad clsRectanguloModelo.
    ''' </summary>
    Public Function funCrearRectangulo(ByVal intId As Integer, ByVal strNombre As String, ByVal dblBase As Double, ByVal dblAltura As Double) As clsRectanguloModelo
        Dim strNombreFinal As String = strNombre.Trim()
        If String.IsNullOrWhiteSpace(strNombreFinal) Then
            strNombreFinal = $"Rectángulo #{intId}"
        End If

        Return New clsRectanguloModelo(intId, strNombreFinal, dblBase, dblAltura)
    End Function

    ''' <summary>
    ''' Realiza el análisis estadístico completo sobre la lista de rectángulos ingresados.
    ''' </summary>
    Public Function funAnalizarConjunto(ByVal lstRectangulos As List(Of clsRectanguloModelo)) As clsResumenConjuntosModelo
        Dim objResumen As New clsResumenConjuntosModelo()

        If lstRectangulos Is Nothing OrElse lstRectangulos.Count = 0 Then
            Return objResumen
        End If

        objResumen.intTotalRectangulos = lstRectangulos.Count
        objResumen.objMayorArea = lstRectangulos(0)
        objResumen.objMenorArea = lstRectangulos(0)
        objResumen.objMayorPerimetro = lstRectangulos(0)
        objResumen.objMenorPerimetro = lstRectangulos(0)

        Dim dblSumaAreas As Double = 0.0
        Dim dblSumaPerimetros As Double = 0.0

        For Each objRectangulo As clsRectanguloModelo In lstRectangulos
            ' Acumular Totales
            dblSumaAreas += objRectangulo.dblArea
            dblSumaPerimetros += objRectangulo.dblPerimetro

            ' Comparar Mayor y Menor Área
            If objRectangulo.dblArea > objResumen.objMayorArea.dblArea Then
                objResumen.objMayorArea = objRectangulo
            End If
            If objRectangulo.dblArea < objResumen.objMenorArea.dblArea Then
                objResumen.objMenorArea = objRectangulo
            End If

            ' Comparar Mayor y Menor Perímetro
            If objRectangulo.dblPerimetro > objResumen.objMayorPerimetro.dblPerimetro Then
                objResumen.objMayorPerimetro = objRectangulo
            End If
            If objRectangulo.dblPerimetro < objResumen.objMenorPerimetro.dblPerimetro Then
                objResumen.objMenorPerimetro = objRectangulo
            End If

            ' Conteos según clasificación
            Select Case objRectangulo.strTipo
                Case "Cuadrado"
                    objResumen.intCantidadCuadrados += 1
                Case "Horizontal"
                    objResumen.intCantidadHorizontales += 1
                Case "Vertical"
                    objResumen.intCantidadVerticales += 1
            End Select
        Next

        objResumen.dblAreaTotal = dblSumaAreas
        objResumen.dblPerimetroTotal = dblSumaPerimetros
        objResumen.dblPromedioAreas = dblSumaAreas / lstRectangulos.Count

        Return objResumen
    End Function

End Class

