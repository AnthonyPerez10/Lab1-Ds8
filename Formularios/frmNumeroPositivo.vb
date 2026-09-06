Imports System.Windows.Forms

Public Class frmNumeroPositivo

    Private ReadOnly objLogica As New clsNumeroPositivoLogica()

    Private Sub frmNumeroPositivo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        subLimpiarFormulario()
    End Sub

    ''' <summary>
    ''' Restringe la entrada a únicamente dígitos enteros positivos (0-9) y teclas de control.
    ''' Bloquea letras, números negativos, puntos/comas decimales y caracteres especiales.
    ''' </summary>
    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Valida e invoca el algoritmo iterativo con bucle While para generar la serie numérica.
    ''' </summary>
    Private Sub btnGenerar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerar.Click
        Dim strError As String = String.Empty
        Dim intNumeroValido As Integer = 0

        If Not objLogica.funValidarNumeroPositivo(txtNumero.Text, intNumeroValido, strError) Then
            MessageBox.Show(strError, "Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtResultadoSerie.Text = $"Por favor, ingrese un número positivo validado."
            lblSumatoriaTotal.Text = "Sumatoria Acumulada: 0 | Total: 0"
            txtNumero.Focus()
            Return
        End If

        ' Invocar la lógica de negocio (bucle While del 1 al N)
        Dim objResultado As clsNumeroPositivoModelo = objLogica.funGenerarSerieIterativa(intNumeroValido)

        ' Mostrar resultados
        txtResultadoSerie.Text = $"Números: {objResultado.strSecuenciaGenerada}"
        lblSumatoriaTotal.Text = $"Sumatoria Acumulada: {objResultado.intSumatoriaTotal:N0} | Total Números Generados: {objResultado.intTotalElementos}"
    End Sub

    ''' <summary>
    ''' Restablece los campos del formulario.
    ''' </summary>
    Private Sub btnLimpiar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLimpiar.Click
        subLimpiarFormulario()
    End Sub

    Private Sub subLimpiarFormulario()
        txtNumero.Clear()
        txtResultadoSerie.Text = "Números: "
        lblSumatoriaTotal.Text = "Sumatoria Acumulada: 0 | Total: 0"
        txtNumero.Focus()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

End Class
