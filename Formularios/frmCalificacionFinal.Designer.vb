<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalificacionFinal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTituloHeader = New System.Windows.Forms.Label()
        Me.grpNotasParciales = New System.Windows.Forms.GroupBox()
        Me.txtExamenFinal = New System.Windows.Forms.TextBox()
        Me.lblExamenFinalPrompt = New System.Windows.Forms.Label()
        Me.txtParcial3 = New System.Windows.Forms.TextBox()
        Me.lblParcial3Prompt = New System.Windows.Forms.Label()
        Me.txtParcial2 = New System.Windows.Forms.TextBox()
        Me.lblParcial2Prompt = New System.Windows.Forms.Label()
        Me.txtParcial1 = New System.Windows.Forms.TextBox()
        Me.lblParcial1Prompt = New System.Windows.Forms.Label()
        Me.grpResultados = New System.Windows.Forms.GroupBox()
        Me.txtCalificacion = New System.Windows.Forms.TextBox()
        Me.lblCalificacionPrompt = New System.Windows.Forms.Label()
        Me.txtNotaFinal = New System.Windows.Forms.TextBox()
        Me.lblNotaFinalPrompt = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.grpNotasParciales.SuspendLayout()
        Me.grpResultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTituloHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(640, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTituloHeader
        '
        Me.lblTituloHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTituloHeader.Font = New System.Drawing.Font("Segoe UI", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTituloHeader.ForeColor = System.Drawing.Color.White
        Me.lblTituloHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblTituloHeader.Name = "lblTituloHeader"
        Me.lblTituloHeader.Size = New System.Drawing.Size(640, 60)
        Me.lblTituloHeader.TabIndex = 0
        Me.lblTituloHeader.Text = "CALIFICACION FINAL"
        Me.lblTituloHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpNotasParciales
        '
        Me.grpNotasParciales.Controls.Add(Me.txtExamenFinal)
        Me.grpNotasParciales.Controls.Add(Me.lblExamenFinalPrompt)
        Me.grpNotasParciales.Controls.Add(Me.txtParcial3)
        Me.grpNotasParciales.Controls.Add(Me.lblParcial3Prompt)
        Me.grpNotasParciales.Controls.Add(Me.txtParcial2)
        Me.grpNotasParciales.Controls.Add(Me.lblParcial2Prompt)
        Me.grpNotasParciales.Controls.Add(Me.txtParcial1)
        Me.grpNotasParciales.Controls.Add(Me.lblParcial1Prompt)
        Me.grpNotasParciales.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpNotasParciales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.grpNotasParciales.Location = New System.Drawing.Point(25, 75)
        Me.grpNotasParciales.Name = "grpNotasParciales"
        Me.grpNotasParciales.Size = New System.Drawing.Size(590, 130)
        Me.grpNotasParciales.TabIndex = 1
        Me.grpNotasParciales.TabStop = False
        Me.grpNotasParciales.Text = "1. Registro de Evaluaciones (0 - 100)"
        '
        'txtExamenFinal
        '
        Me.txtExamenFinal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtExamenFinal.Location = New System.Drawing.Point(440, 75)
        Me.txtExamenFinal.MaxLength = 6
        Me.txtExamenFinal.Name = "txtExamenFinal"
        Me.txtExamenFinal.Size = New System.Drawing.Size(130, 25)
        Me.txtExamenFinal.TabIndex = 7
        '
        'lblExamenFinalPrompt
        '
        Me.lblExamenFinalPrompt.AutoSize = True
        Me.lblExamenFinalPrompt.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblExamenFinalPrompt.Location = New System.Drawing.Point(315, 78)
        Me.lblExamenFinalPrompt.Name = "lblExamenFinalPrompt"
        Me.lblExamenFinalPrompt.Size = New System.Drawing.Size(115, 17)
        Me.lblExamenFinalPrompt.TabIndex = 6
        Me.lblExamenFinalPrompt.Text = "EXAMEN FINAL :"
        '
        'txtParcial3
        '
        Me.txtParcial3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtParcial3.Location = New System.Drawing.Point(440, 35)
        Me.txtParcial3.MaxLength = 6
        Me.txtParcial3.Name = "txtParcial3"
        Me.txtParcial3.Size = New System.Drawing.Size(130, 25)
        Me.txtParcial3.TabIndex = 5
        '
        'lblParcial3Prompt
        '
        Me.lblParcial3Prompt.AutoSize = True
        Me.lblParcial3Prompt.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblParcial3Prompt.Location = New System.Drawing.Point(315, 38)
        Me.lblParcial3Prompt.Name = "lblParcial3Prompt"
        Me.lblParcial3Prompt.Size = New System.Drawing.Size(111, 17)
        Me.lblParcial3Prompt.TabIndex = 4
        Me.lblParcial3Prompt.Text = "PARCIAL No 3 :"
        '
        'txtParcial2
        '
        Me.txtParcial2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtParcial2.Location = New System.Drawing.Point(145, 75)
        Me.txtParcial2.MaxLength = 6
        Me.txtParcial2.Name = "txtParcial2"
        Me.txtParcial2.Size = New System.Drawing.Size(130, 25)
        Me.txtParcial2.TabIndex = 3
        '
        'lblParcial2Prompt
        '
        Me.lblParcial2Prompt.AutoSize = True
        Me.lblParcial2Prompt.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblParcial2Prompt.Location = New System.Drawing.Point(20, 78)
        Me.lblParcial2Prompt.Name = "lblParcial2Prompt"
        Me.lblParcial2Prompt.Size = New System.Drawing.Size(111, 17)
        Me.lblParcial2Prompt.TabIndex = 2
        Me.lblParcial2Prompt.Text = "PARCIAL No 2 :"
        '
        'txtParcial1
        '
        Me.txtParcial1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtParcial1.Location = New System.Drawing.Point(145, 35)
        Me.txtParcial1.MaxLength = 6
        Me.txtParcial1.Name = "txtParcial1"
        Me.txtParcial1.Size = New System.Drawing.Size(130, 25)
        Me.txtParcial1.TabIndex = 1
        '
        'lblParcial1Prompt
        '
        Me.lblParcial1Prompt.AutoSize = True
        Me.lblParcial1Prompt.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblParcial1Prompt.Location = New System.Drawing.Point(20, 38)
        Me.lblParcial1Prompt.Name = "lblParcial1Prompt"
        Me.lblParcial1Prompt.Size = New System.Drawing.Size(111, 17)
        Me.lblParcial1Prompt.TabIndex = 0
        Me.lblParcial1Prompt.Text = "PARCIAL No 1 :"
        '
        'grpResultados
        '
        Me.grpResultados.Controls.Add(Me.txtCalificacion)
        Me.grpResultados.Controls.Add(Me.lblCalificacionPrompt)
        Me.grpResultados.Controls.Add(Me.txtNotaFinal)
        Me.grpResultados.Controls.Add(Me.lblNotaFinalPrompt)
        Me.grpResultados.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpResultados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.grpResultados.Location = New System.Drawing.Point(25, 215)
        Me.grpResultados.Name = "grpResultados"
        Me.grpResultados.Size = New System.Drawing.Size(320, 130)
        Me.grpResultados.TabIndex = 2
        Me.grpResultados.TabStop = False
        Me.grpResultados.Text = "2. Calificación Calculada"
        '
        'txtCalificacion
        '
        Me.txtCalificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCalificacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtCalificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtCalificacion.Location = New System.Drawing.Point(145, 75)
        Me.txtCalificacion.Name = "txtCalificacion"
        Me.txtCalificacion.ReadOnly = True
        Me.txtCalificacion.Size = New System.Drawing.Size(155, 29)
        Me.txtCalificacion.TabIndex = 3
        Me.txtCalificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCalificacionPrompt
        '
        Me.lblCalificacionPrompt.AutoSize = True
        Me.lblCalificacionPrompt.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCalificacionPrompt.Location = New System.Drawing.Point(20, 81)
        Me.lblCalificacionPrompt.Name = "lblCalificacionPrompt"
        Me.lblCalificacionPrompt.Size = New System.Drawing.Size(107, 17)
        Me.lblCalificacionPrompt.TabIndex = 2
        Me.lblCalificacionPrompt.Text = "CALIFICACION :"
        '
        'txtNotaFinal
        '
        Me.txtNotaFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtNotaFinal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtNotaFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtNotaFinal.Location = New System.Drawing.Point(145, 35)
        Me.txtNotaFinal.Name = "txtNotaFinal"
        Me.txtNotaFinal.ReadOnly = True
        Me.txtNotaFinal.Size = New System.Drawing.Size(155, 27)
        Me.txtNotaFinal.TabIndex = 1
        Me.txtNotaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNotaFinalPrompt
        '
        Me.lblNotaFinalPrompt.AutoSize = True
        Me.lblNotaFinalPrompt.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNotaFinalPrompt.Location = New System.Drawing.Point(20, 40)
        Me.lblNotaFinalPrompt.Name = "lblNotaFinalPrompt"
        Me.lblNotaFinalPrompt.Size = New System.Drawing.Size(95, 17)
        Me.lblNotaFinalPrompt.TabIndex = 0
        Me.lblNotaFinalPrompt.Text = "NOTA FINAL :"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalcular.ForeColor = System.Drawing.Color.White
        Me.btnCalcular.Location = New System.Drawing.Point(365, 225)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(250, 60)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(365, 295)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(250, 45)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "↺ LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(465, 360)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(150, 40)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "← VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmCalificacionFinal
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 415)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.grpResultados)
        Me.Controls.Add(Me.grpNotasParciales)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCalificacionFinal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Algoritmo de Evaluación - Calificación Final"
        Me.pnlHeader.ResumeLayout(False)
        Me.grpNotasParciales.ResumeLayout(False)
        Me.grpNotasParciales.PerformLayout()
        Me.grpResultados.ResumeLayout(False)
        Me.grpResultados.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTituloHeader As System.Windows.Forms.Label
    Friend WithEvents grpNotasParciales As System.Windows.Forms.GroupBox
    Friend WithEvents lblParcial1Prompt As System.Windows.Forms.Label
    Friend WithEvents txtParcial1 As System.Windows.Forms.TextBox
    Friend WithEvents lblParcial2Prompt As System.Windows.Forms.Label
    Friend WithEvents txtParcial2 As System.Windows.Forms.TextBox
    Friend WithEvents lblParcial3Prompt As System.Windows.Forms.Label
    Friend WithEvents txtParcial3 As System.Windows.Forms.TextBox
    Friend WithEvents lblExamenFinalPrompt As System.Windows.Forms.Label
    Friend WithEvents txtExamenFinal As System.Windows.Forms.TextBox
    Friend WithEvents grpResultados As System.Windows.Forms.GroupBox
    Friend WithEvents lblNotaFinalPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNotaFinal As System.Windows.Forms.TextBox
    Friend WithEvents lblCalificacionPrompt As System.Windows.Forms.Label
    Friend WithEvents txtCalificacion As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button

End Class
