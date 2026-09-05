<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTablasMultiplicar
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
        Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTituloHeader = New System.Windows.Forms.Label()
        Me.grpEntradaDatos = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGenerarTabla = New System.Windows.Forms.Button()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.lblLimitePrompt = New System.Windows.Forms.Label()
        Me.txtNumeroTabla = New System.Windows.Forms.TextBox()
        Me.lblNumeroPrompt = New System.Windows.Forms.Label()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.colMultiplicador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExpresion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colResultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpResumenTabla = New System.Windows.Forms.GroupBox()
        Me.lblResumenMetrics = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.grpEntradaDatos.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResumenTabla.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTituloHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(780, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTituloHeader
        '
        Me.lblTituloHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTituloHeader.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTituloHeader.ForeColor = System.Drawing.Color.White
        Me.lblTituloHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblTituloHeader.Name = "lblTituloHeader"
        Me.lblTituloHeader.Size = New System.Drawing.Size(780, 60)
        Me.lblTituloHeader.TabIndex = 0
        Me.lblTituloHeader.Text = "ESTRUCTURA DE ITERACIÓN: TABLA DE MULTIPLICAR"
        Me.lblTituloHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpEntradaDatos
        '
        Me.grpEntradaDatos.Controls.Add(Me.btnLimpiar)
        Me.grpEntradaDatos.Controls.Add(Me.btnGenerarTabla)
        Me.grpEntradaDatos.Controls.Add(Me.txtLimite)
        Me.grpEntradaDatos.Controls.Add(Me.lblLimitePrompt)
        Me.grpEntradaDatos.Controls.Add(Me.txtNumeroTabla)
        Me.grpEntradaDatos.Controls.Add(Me.lblNumeroPrompt)
        Me.grpEntradaDatos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpEntradaDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.grpEntradaDatos.Location = New System.Drawing.Point(25, 75)
        Me.grpEntradaDatos.Name = "grpEntradaDatos"
        Me.grpEntradaDatos.Size = New System.Drawing.Size(330, 250)
        Me.grpEntradaDatos.TabIndex = 1
        Me.grpEntradaDatos.TabStop = False
        Me.grpEntradaDatos.Text = "1. Configuración de Parámetros"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(20, 195)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(290, 38)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "↺ LIMPIAR CAMPOS"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnGenerarTabla
        '
        Me.btnGenerarTabla.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnGenerarTabla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarTabla.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGenerarTabla.ForeColor = System.Drawing.Color.White
        Me.btnGenerarTabla.Location = New System.Drawing.Point(20, 145)
        Me.btnGenerarTabla.Name = "btnGenerarTabla"
        Me.btnGenerarTabla.Size = New System.Drawing.Size(290, 42)
        Me.btnGenerarTabla.TabIndex = 4
        Me.btnGenerarTabla.Text = "⚙ GENERAR TABLA"
        Me.btnGenerarTabla.UseVisualStyleBackColor = False
        '
        'txtLimite
        '
        Me.txtLimite.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLimite.Location = New System.Drawing.Point(200, 85)
        Me.txtLimite.MaxLength = 2
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(110, 25)
        Me.txtLimite.TabIndex = 3
        '
        'lblLimitePrompt
        '
        Me.lblLimitePrompt.AutoSize = True
        Me.lblLimitePrompt.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLimitePrompt.Location = New System.Drawing.Point(15, 88)
        Me.lblLimitePrompt.Name = "lblLimitePrompt"
        Me.lblLimitePrompt.Size = New System.Drawing.Size(171, 17)
        Me.lblLimitePrompt.TabIndex = 2
        Me.lblLimitePrompt.Text = "Límite (Máx. 2 dígitos > 0) >"
        '
        'txtNumeroTabla
        '
        Me.txtNumeroTabla.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNumeroTabla.Location = New System.Drawing.Point(200, 40)
        Me.txtNumeroTabla.MaxLength = 2
        Me.txtNumeroTabla.Name = "txtNumeroTabla"
        Me.txtNumeroTabla.Size = New System.Drawing.Size(110, 25)
        Me.txtNumeroTabla.TabIndex = 1
        '
        'lblNumeroPrompt
        '
        Me.lblNumeroPrompt.AutoSize = True
        Me.lblNumeroPrompt.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNumeroPrompt.Location = New System.Drawing.Point(15, 43)
        Me.lblNumeroPrompt.Name = "lblNumeroPrompt"
        Me.lblNumeroPrompt.Size = New System.Drawing.Size(175, 17)
        Me.lblNumeroPrompt.TabIndex = 0
        Me.lblNumeroPrompt.Text = "Tabla N° (Máx. 2 dígitos > 0) >"
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.AllowUserToResizeRows = False
        Me.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultados.BackgroundColor = System.Drawing.Color.White
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        dataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMultiplicador, Me.colExpresion, Me.colResultado})
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        dataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResultados.DefaultCellStyle = dataGridViewCellStyle2
        Me.dgvResultados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvResultados.Location = New System.Drawing.Point(375, 75)
        Me.dgvResultados.MultiSelect = False
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.RowHeadersVisible = False
        Me.dgvResultados.RowTemplate.Height = 25
        Me.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultados.Size = New System.Drawing.Size(380, 250)
        Me.dgvResultados.TabIndex = 2
        '
        'colMultiplicador
        '
        Me.colMultiplicador.FillWeight = 50.0!
        Me.colMultiplicador.HeaderText = "Paso (#)"
        Me.colMultiplicador.Name = "colMultiplicador"
        Me.colMultiplicador.ReadOnly = True
        '
        'colExpresion
        '
        Me.colExpresion.FillWeight = 120.0!
        Me.colExpresion.HeaderText = "Operación / Expresión"
        Me.colExpresion.Name = "colExpresion"
        Me.colExpresion.ReadOnly = True
        '
        'colResultado
        '
        Me.colResultado.FillWeight = 80.0!
        Me.colResultado.HeaderText = "Resultado"
        Me.colResultado.Name = "colResultado"
        Me.colResultado.ReadOnly = True
        '
        'grpResumenTabla
        '
        Me.grpResumenTabla.Controls.Add(Me.lblResumenMetrics)
        Me.grpResumenTabla.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpResumenTabla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.grpResumenTabla.Location = New System.Drawing.Point(25, 335)
        Me.grpResumenTabla.Name = "grpResumenTabla"
        Me.grpResumenTabla.Size = New System.Drawing.Size(730, 95)
        Me.grpResumenTabla.TabIndex = 3
        Me.grpResumenTabla.TabStop = False
        Me.grpResumenTabla.Text = "2. Resumen Estadístico de la Serie"
        '
        'lblResumenMetrics
        '
        Me.lblResumenMetrics.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblResumenMetrics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblResumenMetrics.Location = New System.Drawing.Point(20, 30)
        Me.lblResumenMetrics.Name = "lblResumenMetrics"
        Me.lblResumenMetrics.Size = New System.Drawing.Size(690, 50)
        Me.lblResumenMetrics.TabIndex = 0
        Me.lblResumenMetrics.Text = "Ingrese los parámetros y haga clic en 'GENERAR TABLA' para ejecutar el algoritmo."
        Me.lblResumenMetrics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(605, 440)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(150, 40)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "← VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmTablasMultiplicar
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 495)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.grpResumenTabla)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.grpEntradaDatos)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmTablasMultiplicar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Algoritmo de Iteración - Tablas de Multiplicación"
        Me.pnlHeader.ResumeLayout(False)
        Me.grpEntradaDatos.ResumeLayout(False)
        Me.grpEntradaDatos.PerformLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResumenTabla.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTituloHeader As System.Windows.Forms.Label
    Friend WithEvents grpEntradaDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumeroPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumeroTabla As System.Windows.Forms.TextBox
    Friend WithEvents lblLimitePrompt As System.Windows.Forms.Label
    Friend WithEvents txtLimite As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerarTabla As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dgvResultados As System.Windows.Forms.DataGridView
    Friend WithEvents colMultiplicador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colExpresion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colResultado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpResumenTabla As System.Windows.Forms.GroupBox
    Friend WithEvents lblResumenMetrics As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button

End Class
