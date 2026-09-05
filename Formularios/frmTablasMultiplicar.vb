Imports System.Windows.Forms

Public Class frmTablasMultiplicar

    Private ReadOnly objLogica As New clsTablasMultiplicarLogica()

    Private Sub frmTablasMultiplicar_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        subLimpiarFormulario()
    End Sub

    ''' <summary>
    ''' Restringe las entradas de los campos de texto a únicamente dígitos enteros positivos (0-9) y teclas de control.
    ''' Evita letras, espacios, caracteres especiales, números negativos y decimales.
    ''' </summary>
    Private Sub txtEntradas_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNumeroTabla.KeyPress, txtLimite.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Valida los datos e invoca el algoritmo iterativo de generación de tabla.
    ''' </summary>
    Private Sub btnGenerarTabla_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerarTabla.Click
        Dim strError As String = String.Empty
        Dim intNumeroTabla As Integer = 0
        Dim intLimite As Integer = 0

        If Not objLogica.funValidarEntradas(txtNumeroTabla.Text, txtLimite.Text, intNumeroTabla, intLimite, strError) Then
            MessageBox.Show(strError, "Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Invocar la lógica de negocio
        Dim objTablaModelo As clsTablaMultiplicarModelo = objLogica.funGenerarTablaMultiplicar(intNumeroTabla, intLimite)

        ' Cargar filas en el DataGridView
        dgvResultados.Rows.Clear()
        For Each objItem As clsItemMultiplicarModelo In objTablaModelo.lstItems
            dgvResultados.Rows.Add(objItem.intMultiplicador, objItem.strExpresion, objItem.intProducto)
        Next

        ' Actualizar resumen estadístico
        lblResumenMetrics.Text = $"Resumen de la Serie Generada:" & vbCrLf &
                                $"• Tabla de Multiplicar del N°: {objTablaModelo.intNumeroTabla} | Total de Iteraciones: {objTablaModelo.lstItems.Count}" & vbCrLf &
                                $"• Suma Total de los Productos: {objTablaModelo.intSumaProductos:N0} | Producto Máximo: {objTablaModelo.intProductoMaximo:N0}"
    End Sub

    ''' <summary>
    ''' Restablece todos los campos del formulario.
    ''' </summary>
    Private Sub btnLimpiar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLimpiar.Click
        subLimpiarFormulario()
    End Sub

    Private Sub subLimpiarFormulario()
        txtNumeroTabla.Clear()
        txtLimite.Clear()
        dgvResultados.Rows.Clear()
        lblResumenMetrics.Text = "Ingrese los parámetros y haga clic en 'GENERAR TABLA' para ejecutar el algoritmo."
        txtNumeroTabla.Focus()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

End Class
