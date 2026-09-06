<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNumeroPositivo
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
        Me.grpEntradaDatos = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumeroPrompt = New System.Windows.Forms.Label()
        Me.grpResultados = New System.Windows.Forms.GroupBox()
        Me.lblSumatoriaTotal = New System.Windows.Forms.Label()
        Me.txtResultadoSerie = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.grpEntradaDatos.SuspendLayout()
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
        Me.pnlHeader.Size = New System.Drawing.Size(600, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTituloHeader
        '
        Me.lblTituloHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTituloHeader.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTituloHeader.ForeColor = System.Drawing.Color.White
        Me.lblTituloHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblTituloHeader.Name = "lblTituloHeader"
        Me.lblTituloHeader.Size = New System.Drawing.Size(600, 60)
        Me.lblTituloHeader.TabIndex = 0
        Me.lblTituloHeader.Text = "INGRESE UN NÚMERO POSITIVO"
        Me.lblTituloHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpEntradaDatos
        '
        Me.grpEntradaDatos.Controls.Add(Me.btnLimpiar)
        Me.grpEntradaDatos.Controls.Add(Me.btnGenerar)
        Me.grpEntradaDatos.Controls.Add(Me.txtNumero)
        Me.grpEntradaDatos.Controls.Add(Me.lblNumeroPrompt)
        Me.grpEntradaDatos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpEntradaDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.grpEntradaDatos.Location = New System.Drawing.Point(25, 75)
        Me.grpEntradaDatos.Name = "grpEntradaDatos"
        Me.grpEntradaDatos.Size = New System.Drawing.Size(550, 140)
        Me.grpEntradaDatos.TabIndex = 1
        Me.grpEntradaDatos.TabStop = False
        Me.grpEntradaDatos.Text = "1. Configuración de Número N"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(365, 80)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(165, 42)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "↺ LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGenerar.ForeColor = System.Drawing.Color.White
        Me.btnGenerar.Location = New System.Drawing.Point(20, 80)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(330, 42)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "GENERAR SERIE (WHILE)"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNumero.Location = New System.Drawing.Point(235, 35)
        Me.txtNumero.MaxLength = 3
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(295, 27)
        Me.txtNumero.TabIndex = 1
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumeroPrompt
        '
        Me.lblNumeroPrompt.AutoSize = True
        Me.lblNumeroPrompt.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNumeroPrompt.Location = New System.Drawing.Point(20, 40)
        Me.lblNumeroPrompt.Name = "lblNumeroPrompt"
        Me.lblNumeroPrompt.Size = New System.Drawing.Size(209, 17)
        Me.lblNumeroPrompt.TabIndex = 0
        Me.lblNumeroPrompt.Text = "Número Positivo (Máx. 3 Díg) >"
        '
        'grpResultados
        '
        Me.grpResultados.Controls.Add(Me.lblSumatoriaTotal)
        Me.grpResultados.Controls.Add(Me.txtResultadoSerie)
        Me.grpResultados.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpResultados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.grpResultados.Location = New System.Drawing.Point(25, 225)
        Me.grpResultados.Name = "grpResultados"
        Me.grpResultados.Size = New System.Drawing.Size(550, 160)
        Me.grpResultados.TabIndex = 2
        Me.grpResultados.TabStop = False
        Me.grpResultados.Text = "2. Secuencia Generada (Del 1 al N)"
        '
        'lblSumatoriaTotal
        '
        Me.lblSumatoriaTotal.AutoSize = True
        Me.lblSumatoriaTotal.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSumatoriaTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.lblSumatoriaTotal.Location = New System.Drawing.Point(20, 128)
        Me.lblSumatoriaTotal.Name = "lblSumatoriaTotal"
        Me.lblSumatoriaTotal.Size = New System.Drawing.Size(242, 17)
        Me.lblSumatoriaTotal.TabIndex = 1
        Me.lblSumatoriaTotal.Text = "Sumatoria Acumulada: 0 | Total: 0"
        '
        'txtResultadoSerie
        '
        Me.txtResultadoSerie.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtResultadoSerie.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtResultadoSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtResultadoSerie.Location = New System.Drawing.Point(20, 30)
        Me.txtResultadoSerie.Multiline = True
        Me.txtResultadoSerie.Name = "txtResultadoSerie"
        Me.txtResultadoSerie.ReadOnly = True
        Me.txtResultadoSerie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResultadoSerie.Size = New System.Drawing.Size(510, 85)
        Me.txtResultadoSerie.TabIndex = 0
        Me.txtResultadoSerie.Text = "Números: "
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(425, 400)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(150, 40)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "← VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmNumeroPositivo
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 455)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.grpResultados)
        Me.Controls.Add(Me.grpEntradaDatos)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNumeroPositivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Algoritmo de Iteración - Inserte un Número Positivo"
        Me.pnlHeader.ResumeLayout(False)
        Me.grpEntradaDatos.ResumeLayout(False)
        Me.grpEntradaDatos.PerformLayout()
        Me.grpResultados.ResumeLayout(False)
        Me.grpResultados.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTituloHeader As System.Windows.Forms.Label
    Friend WithEvents grpEntradaDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumeroPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents grpResultados As System.Windows.Forms.GroupBox
    Friend WithEvents txtResultadoSerie As System.Windows.Forms.TextBox
    Friend WithEvents lblSumatoriaTotal As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button

End Class
