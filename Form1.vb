Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtNombre.Text = "Estudiante"
    End Sub

    Private Sub btnSaludar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaludar.Click
        Dim nombre As String = txtNombre.Text.Trim()
        If String.IsNullOrWhiteSpace(nombre) Then
            nombre = "Mundo"
        End If

        lblMensaje.Text = $"¡Hola, {nombre}! Bienvenido a tu primera aplicación gráfica en Visual Basic .NET."
        MessageBox.Show($"¡Hola {nombre}! Tu entorno Visual Basic .NET con interfaz gráfica está configurado y funcionando correctamente.", "¡Hola Mundo en Visual Basic!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnEjecutarBucle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEjecutarBucle.Click
        lstResultados.Items.Clear()
        lstResultados.Items.Add("=== Demostración de Estructuras de Iteración ===")

        ' 1. Ejemplo de bucle For ... Next
        lstResultados.Items.Add("[1] Bucle For ... Next (1 al 5):")
        For i As Integer = 1 To 5
            lstResultados.Items.Add($"    - Iteración número: {i}")
        Next

        ' 2. Ejemplo de bucle Do While
        lstResultados.Items.Add("[2] Bucle Do While (contador < 3):")
        Dim contador As Integer = 1
        Do While contador <= 3
            lstResultados.Items.Add($"    - Do While ciclo #{contador}")
            contador += 1
        Loop

        lstResultados.Items.Add("=== Fin del proceso ===")
    End Sub

End Class
