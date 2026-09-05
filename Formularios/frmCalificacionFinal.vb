Imports System.Globalization
Imports System.Windows.Forms

Public Class frmCalificacionFinal

    Private ReadOnly objLogica As New clsCalificacionFinalLogica()

    Private Sub frmCalificacionFinal_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        subLimpiarFormulario()
    End Sub

    ''' <summary>
    ''' Restringe los campos de notas a únicamente números enteros o decimales positivos (0 - 100),
    ''' impidiendo el ingreso de letras, espacios, signos negativos o símbolos especiales.
    ''' </summary>
    Private Sub txtNotas_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtParcial1.KeyPress, txtParcial2.KeyPress, txtParcial3.KeyPress, txtExamenFinal.KeyPress
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
    ''' Valida los datos e invoca el cálculo ponderado de la nota final y su equivalencia alfabética.
    ''' </summary>
    Private Sub btnCalcular_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalcular.Click
        Dim strError As String = String.Empty
        Dim dblP1 As Double = 0.0
        Dim dblP2 As Double = 0.0
        Dim dblP3 As Double = 0.0
        Dim dblFinal As Double = 0.0

        If Not objLogica.funValidarNotas(txtParcial1.Text, txtParcial2.Text, txtParcial3.Text, txtExamenFinal.Text, dblP1, dblP2, dblP3, dblFinal, strError) Then
            MessageBox.Show(strError, "Validación de Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Invocar la lógica de negocio para el cálculo
        Dim objCalificacion As clsCalificacionModelo = objLogica.funCalcularCalificacionFinal(dblP1, dblP2, dblP3, dblFinal)

        ' Mostrar resultados en los campos bloqueados
        txtNotaFinal.Text = objCalificacion.dblNotaFinal.ToString("N2")
        txtCalificacion.Text = objCalificacion.strLetraCalificacion
    End Sub

    ''' <summary>
    ''' Restablece todos los campos del formulario.
    ''' </summary>
    Private Sub btnLimpiar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLimpiar.Click
        subLimpiarFormulario()
    End Sub

    Private Sub subLimpiarFormulario()
        txtParcial1.Clear()
        txtParcial2.Clear()
        txtParcial3.Clear()
        txtExamenFinal.Clear()
        txtNotaFinal.Clear()
        txtCalificacion.Clear()
        txtParcial1.Focus()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

End Class
