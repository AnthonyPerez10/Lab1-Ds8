Public Class frmMenuPrincipal

    Private Sub btnAnalisisRectangulos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAnalisisRectangulos.Click
        Dim objFormAnalisis As New frmAnalisisRectangulos()
        Me.Hide()
        objFormAnalisis.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnTablasMultiplicar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTablasMultiplicar.Click
        Dim objFormTablas As New frmTablasMultiplicar()
        Me.Hide()
        objFormTablas.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnCalificacionFinal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalificacionFinal.Click
        Dim objFormCalificacion As New frmCalificacionFinal()
        Me.Hide()
        objFormCalificacion.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnNumeroPositivo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNumeroPositivo.Click
        Dim objFormNumeroPositivo As New frmNumeroPositivo()
        Me.Hide()
        objFormNumeroPositivo.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

End Class

