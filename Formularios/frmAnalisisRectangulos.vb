Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows.Forms

Public Class frmAnalisisRectangulos

    Private ReadOnly objLogica As New clsAnalisisRectangulosLogica()
    Private ReadOnly lstRectangulos As New List(Of clsRectanguloModelo)()
    Private intCantidadTotalDefinida As Integer = 0

    Private Sub frmAnalisisRectangulos_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        subReiniciarFormulario()
    End Sub

    ''' <summary>
    ''' Restringe la entrada en txtCantidad a únicamente números enteros positivos (0-9) y teclas de control (Backspace).
    ''' Evita letras, negativos, decimales y caracteres especiales.
    ''' </summary>
    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Restringe la entrada en txtBase y txtAltura a únicamente dígitos (0-9), control y un único separador decimal.
    ''' Evita números negativos, letras y caracteres especiales.
    ''' </summary>
    Private Sub txtDimensiones_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtBase.KeyPress, txtAltura.KeyPress
        Dim txtSender As TextBox = CType(sender, TextBox)
        Dim strSeparadorDecimal As String = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim charSeparador As Char = strSeparadorDecimal(0)

        ' Permitir dígitos (0-9) y teclas de control como Backspace
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            Return
        ElseIf e.KeyChar = "."c OrElse e.KeyChar = ","c Then
            ' Normalizar coma/punto al separador del sistema y evitar repetidos
            e.KeyChar = charSeparador
            If txtSender.Text.Contains(charSeparador) Then
                e.Handled = True
            End If
        Else
            ' Bloquear cualquier otro carácter (letras, signos negativos '-', símbolos)
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Establece la cantidad total de rectángulos a analizar y habilita el formulario de entrada.
    ''' </summary>
    Private Sub btnEstablecerCantidad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEstablecerCantidad.Click
        Dim strError As String = String.Empty
        Dim intCantidad As Integer = 0

        If Not objLogica.funValidarCantidad(txtCantidad.Text, intCantidad, strError) Then
            MessageBox.Show(strError, "Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidad.Focus()
            Return
        End If

        intCantidadTotalDefinida = intCantidad
        txtCantidad.Enabled = False
        btnEstablecerCantidad.Enabled = False
        grpRegistro.Enabled = True

        subActualizarEstadoProgreso()
        txtNombre.Text = $"Rectángulo #{lstRectangulos.Count + 1}"
        txtBase.Focus()
    End Sub

    ''' <summary>
    ''' Muestra el cálculo de superficie en tiempo real al cambiar los valores de base o altura.
    ''' </summary>
    Private Sub txtBase_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBase.TextChanged, txtAltura.TextChanged
        Dim dblBase As Double = 0.0
        Dim dblAltura As Double = 0.0

        If Double.TryParse(txtBase.Text.Trim(), dblBase) AndAlso Double.TryParse(txtAltura.Text.Trim(), dblAltura) AndAlso dblBase > 0 AndAlso dblAltura > 0 Then
            Dim dblAreaCalculada As Double = dblBase * dblAltura
            lblLiveSuperficie.Text = $"Superficie calculada: {dblAreaCalculada:N2} cm² (A = b × h)"
        Else
            lblLiveSuperficie.Text = "Superficie calculada: 0.00 cm² (A = b × h)"
        End If
    End Sub

    ''' <summary>
    ''' Valida e ingresa un nuevo rectángulo a la colección y actualiza la tabla y el resumen.
    ''' </summary>
    Private Sub btnAgregarRectangulo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAgregarRectangulo.Click
        If lstRectangulos.Count >= intCantidadTotalDefinida Then
            MessageBox.Show($"Ya se ha alcanzado la cantidad total establecida ({intCantidadTotalDefinida} rectángulos).", "Límite Alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim strError As String = String.Empty
        Dim dblBase As Double = 0.0
        Dim dblAltura As Double = 0.0

        If Not objLogica.funValidarDimensiones(txtBase.Text, txtAltura.Text, dblBase, dblAltura, strError) Then
            MessageBox.Show(strError, "Validación de Dimensiones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim intSiguienteId As Integer = lstRectangulos.Count + 1
        Dim strNombreAutomatico As String = $"Rectángulo #{intSiguienteId}"

        ' Crear objeto modelo
        Dim objRectangulo As clsRectanguloModelo = objLogica.funCrearRectangulo(intSiguienteId, strNombreAutomatico, dblBase, dblAltura)

        ' Guardar en estructura de datos (Lista lógica)
        lstRectangulos.Add(objRectangulo)

        ' Agregar fila a DataGridView
        dgvRectangulos.Rows.Add(objRectangulo.intId, objRectangulo.strNombre, objRectangulo.dblBase.ToString("N2"), objRectangulo.dblAltura.ToString("N2"), objRectangulo.dblArea.ToString("N2"), objRectangulo.dblPerimetro.ToString("N2"), objRectangulo.strTipo)

        ' Actualizar resumen del conjunto completo
        subActualizarResumenAnalisis()
        subActualizarEstadoProgreso()

        ' Limpiar campos para la siguiente entrada
        txtBase.Clear()
        txtAltura.Clear()
        lblLiveSuperficie.Text = "Superficie calculada: 0.00 cm² (A = b × h)"

        If lstRectangulos.Count < intCantidadTotalDefinida Then
            txtNombre.Text = $"Rectángulo #{lstRectangulos.Count + 1}"
            txtBase.Focus()
        Else
            grpRegistro.Enabled = False
            MessageBox.Show("¡Se ha completado el registro de todos los rectángulos solicitados!", "Registro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ''' <summary>
    ''' Actualiza las métricas y estadísticas del conjunto completo en el panel inferior.
    ''' </summary>
    Private Sub subActualizarResumenAnalisis()
        Dim objResumen As clsResumenConjuntosModelo = objLogica.funAnalizarConjunto(lstRectangulos)

        If objResumen.intTotalRectangulos = 0 Then
            lblMayorArea.Text = "• Mayor Área: N/A (0.00 cm²)"
            lblMenorArea.Text = "• Menor Área: N/A (0.00 cm²)"
            lblMayorPerimetro.Text = "• Mayor Perímetro: N/A (0.00 cm)"
            lblMenorPerimetro.Text = "• Menor Perímetro: N/A (0.00 cm)"
            lblPromediosTotales.Text = "Métricas Totales:" & vbCrLf & "• Área Total: 0.00 cm²" & vbCrLf & "• Perímetro Total: 0.00 cm" & vbCrLf & "• Promedio Áreas: 0.00 cm²"
            lblConteoClasificacion.Text = "Conteo por Tipo:" & vbCrLf & "• Cuadrados: 0" & vbCrLf & "• Horizontales: 0" & vbCrLf & "• Verticales: 0"
            Return
        End If

        lblMayorArea.Text = $"• Mayor Área: {objResumen.objMayorArea.strNombre} ({objResumen.objMayorArea.dblArea:N2} cm²)"
        lblMenorArea.Text = $"• Menor Área: {objResumen.objMenorArea.strNombre} ({objResumen.objMenorArea.dblArea:N2} cm²)"
        lblMayorPerimetro.Text = $"• Mayor Perímetro: {objResumen.objMayorPerimetro.strNombre} ({objResumen.objMayorPerimetro.dblPerimetro:N2} cm)"
        lblMenorPerimetro.Text = $"• Menor Perímetro: {objResumen.objMenorPerimetro.strNombre} ({objResumen.objMenorPerimetro.dblPerimetro:N2} cm)"

        lblPromediosTotales.Text = "Métricas Totales:" & vbCrLf &
                                  $"• Área Total: {objResumen.dblAreaTotal:N2} cm²" & vbCrLf &
                                  $"• Perímetro Total: {objResumen.dblPerimetroTotal:N2} cm" & vbCrLf &
                                  $"• Promedio Áreas: {objResumen.dblPromedioAreas:N2} cm²"

        lblConteoClasificacion.Text = "Conteo por Tipo:" & vbCrLf &
                                     $"• Cuadrados: {objResumen.intCantidadCuadrados}" & vbCrLf &
                                     $"• Horizontales: {objResumen.intCantidadHorizontales}" & vbCrLf &
                                     $"• Verticales: {objResumen.intCantidadVerticales}"
    End Sub

    ''' <summary>
    ''' Actualiza la etiqueta del progreso de registros.
    ''' </summary>
    Private Sub subActualizarEstadoProgreso()
        If intCantidadTotalDefinida = 0 Then
            lblProgreso.Text = "Estado: Defina la cantidad para empezar."
            lblProgreso.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Else
            lblProgreso.Text = $"Progreso de Registro: {lstRectangulos.Count} de {intCantidadTotalDefinida} rectángulos registrados."
            If lstRectangulos.Count = intCantidadTotalDefinida Then
                lblProgreso.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129)
            Else
                lblProgreso.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Reinicia el formulario para iniciar un nuevo conjunto de análisis.
    ''' </summary>
    Private Sub btnNuevoConjunto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevoConjunto.Click
        subReiniciarFormulario()
    End Sub

    Private Sub subReiniciarFormulario()
        lstRectangulos.Clear()
        intCantidadTotalDefinida = 0
        dgvRectangulos.Rows.Clear()

        txtCantidad.Enabled = True
        txtCantidad.Clear()
        btnEstablecerCantidad.Enabled = True

        grpRegistro.Enabled = False
        txtNombre.Text = "Rectángulo #1"
        txtBase.Clear()
        txtAltura.Clear()

        lblLiveSuperficie.Text = "Superficie calculada: 0.00 cm² (A = b × h)"

        subActualizarEstadoProgreso()
        subActualizarResumenAnalisis()

        txtCantidad.Focus()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

End Class
