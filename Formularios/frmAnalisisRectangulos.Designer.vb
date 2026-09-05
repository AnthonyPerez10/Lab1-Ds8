<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnalisisRectangulos
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
        Me.grpDefinicionCantidad = New System.Windows.Forms.GroupBox()
        Me.lblProgreso = New System.Windows.Forms.Label()
        Me.btnEstablecerCantidad = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidadPrompt = New System.Windows.Forms.Label()
        Me.grpRegistro = New System.Windows.Forms.GroupBox()
        Me.lblLiveSuperficie = New System.Windows.Forms.Label()
        Me.btnAgregarRectangulo = New System.Windows.Forms.Button()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.lblAlturaPrompt = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.lblBasePrompt = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombrePrompt = New System.Windows.Forms.Label()
        Me.dgvRectangulos = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAltura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPerimetro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpResultados = New System.Windows.Forms.GroupBox()
        Me.lblConteoClasificacion = New System.Windows.Forms.Label()
        Me.lblPromediosTotales = New System.Windows.Forms.Label()
        Me.lblMenorPerimetro = New System.Windows.Forms.Label()
        Me.lblMayorPerimetro = New System.Windows.Forms.Label()
        Me.lblMenorArea = New System.Windows.Forms.Label()
        Me.lblMayorArea = New System.Windows.Forms.Label()
        Me.btnNuevoConjunto = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.grpDefinicionCantidad.SuspendLayout()
        Me.grpRegistro.SuspendLayout()
        CType(Me.dgvRectangulos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlHeader.Size = New System.Drawing.Size(960, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTituloHeader
        '
        Me.lblTituloHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTituloHeader.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTituloHeader.ForeColor = System.Drawing.Color.White
        Me.lblTituloHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblTituloHeader.Name = "lblTituloHeader"
        Me.lblTituloHeader.Size = New System.Drawing.Size(960, 60)
        Me.lblTituloHeader.TabIndex = 0
        Me.lblTituloHeader.Text = "ALGORITMO GEOMÉTRICO: ANÁLISIS DE UN CONJUNTO DE RECTÁNGULOS"
        Me.lblTituloHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpDefinicionCantidad
        '
        Me.grpDefinicionCantidad.Controls.Add(Me.lblProgreso)
        Me.grpDefinicionCantidad.Controls.Add(Me.btnEstablecerCantidad)
        Me.grpDefinicionCantidad.Controls.Add(Me.txtCantidad)
        Me.grpDefinicionCantidad.Controls.Add(Me.lblCantidadPrompt)
        Me.grpDefinicionCantidad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpDefinicionCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.grpDefinicionCantidad.Location = New System.Drawing.Point(20, 75)
        Me.grpDefinicionCantidad.Name = "grpDefinicionCantidad"
        Me.grpDefinicionCantidad.Size = New System.Drawing.Size(420, 95)
        Me.grpDefinicionCantidad.TabIndex = 1
        Me.grpDefinicionCantidad.TabStop = False
        Me.grpDefinicionCantidad.Text = "1. Definir Cantidad de Rectángulos a Analizar"
        '
        'lblProgreso
        '
        Me.lblProgreso.AutoSize = True
        Me.lblProgreso.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProgreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.lblProgreso.Location = New System.Drawing.Point(15, 65)
        Me.lblProgreso.Name = "lblProgreso"
        Me.lblProgreso.Size = New System.Drawing.Size(262, 17)
        Me.lblProgreso.TabIndex = 3
        Me.lblProgreso.Text = "Estado: Defina la cantidad para empezar."
        '
        'btnEstablecerCantidad
        '
        Me.btnEstablecerCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnEstablecerCantidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEstablecerCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstablecerCantidad.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEstablecerCantidad.ForeColor = System.Drawing.Color.White
        Me.btnEstablecerCantidad.Location = New System.Drawing.Point(295, 27)
        Me.btnEstablecerCantidad.Name = "btnEstablecerCantidad"
        Me.btnEstablecerCantidad.Size = New System.Drawing.Size(110, 30)
        Me.btnEstablecerCantidad.TabIndex = 2
        Me.btnEstablecerCantidad.Text = "Establecer"
        Me.btnEstablecerCantidad.UseVisualStyleBackColor = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCantidad.Location = New System.Drawing.Point(205, 30)
        Me.txtCantidad.MaxLength = 2
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(80, 25)
        Me.txtCantidad.TabIndex = 1
        '
        'lblCantidadPrompt
        '
        Me.lblCantidadPrompt.AutoSize = True
        Me.lblCantidadPrompt.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCantidadPrompt.Location = New System.Drawing.Point(15, 33)
        Me.lblCantidadPrompt.Name = "lblCantidadPrompt"
        Me.lblCantidadPrompt.Size = New System.Drawing.Size(184, 17)
        Me.lblCantidadPrompt.TabIndex = 0
        Me.lblCantidadPrompt.Text = "Cantidad (Máx. 2 dígitos > 0):"
        '
        'grpRegistro
        '
        Me.grpRegistro.Controls.Add(Me.lblLiveSuperficie)
        Me.grpRegistro.Controls.Add(Me.btnAgregarRectangulo)
        Me.grpRegistro.Controls.Add(Me.txtAltura)
        Me.grpRegistro.Controls.Add(Me.lblAlturaPrompt)
        Me.grpRegistro.Controls.Add(Me.txtBase)
        Me.grpRegistro.Controls.Add(Me.lblBasePrompt)
        Me.grpRegistro.Controls.Add(Me.txtNombre)
        Me.grpRegistro.Controls.Add(Me.lblNombrePrompt)
        Me.grpRegistro.Enabled = False
        Me.grpRegistro.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.grpRegistro.Location = New System.Drawing.Point(20, 180)
        Me.grpRegistro.Name = "grpRegistro"
        Me.grpRegistro.Size = New System.Drawing.Size(420, 230)
        Me.grpRegistro.TabIndex = 2
        Me.grpRegistro.TabStop = False
        Me.grpRegistro.Text = "2. Entrada de Dimensiones y Registro"
        '
        'lblLiveSuperficie
        '
        Me.lblLiveSuperficie.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblLiveSuperficie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLiveSuperficie.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLiveSuperficie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblLiveSuperficie.Location = New System.Drawing.Point(15, 135)
        Me.lblLiveSuperficie.Name = "lblLiveSuperficie"
        Me.lblLiveSuperficie.Size = New System.Drawing.Size(390, 35)
        Me.lblLiveSuperficie.TabIndex = 6
        Me.lblLiveSuperficie.Text = "Superficie calculada: 0.00 cm² (A = b × h)"
        Me.lblLiveSuperficie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregarRectangulo
        '
        Me.btnAgregarRectangulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnAgregarRectangulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarRectangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarRectangulo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAgregarRectangulo.ForeColor = System.Drawing.Color.White
        Me.btnAgregarRectangulo.Location = New System.Drawing.Point(15, 180)
        Me.btnAgregarRectangulo.Name = "btnAgregarRectangulo"
        Me.btnAgregarRectangulo.Size = New System.Drawing.Size(390, 38)
        Me.btnAgregarRectangulo.TabIndex = 7
        Me.btnAgregarRectangulo.Text = "⊕ REGISTRAR / AGREGAR RECTÁNGULO"
        Me.btnAgregarRectangulo.UseVisualStyleBackColor = False
        '
        'txtAltura
        '
        Me.txtAltura.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAltura.Location = New System.Drawing.Point(145, 95)
        Me.txtAltura.MaxLength = 8
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(260, 25)
        Me.txtAltura.TabIndex = 5
        '
        'lblAlturaPrompt
        '
        Me.lblAlturaPrompt.AutoSize = True
        Me.lblAlturaPrompt.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAlturaPrompt.Location = New System.Drawing.Point(15, 98)
        Me.lblAlturaPrompt.Name = "lblAlturaPrompt"
        Me.lblAlturaPrompt.Size = New System.Drawing.Size(124, 17)
        Me.lblAlturaPrompt.TabIndex = 4
        Me.lblAlturaPrompt.Text = "Altura (h) en [cm] >"
        '
        'txtBase
        '
        Me.txtBase.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBase.Location = New System.Drawing.Point(145, 62)
        Me.txtBase.MaxLength = 8
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(260, 25)
        Me.txtBase.TabIndex = 3
        '
        'lblBasePrompt
        '
        Me.lblBasePrompt.AutoSize = True
        Me.lblBasePrompt.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBasePrompt.Location = New System.Drawing.Point(15, 65)
        Me.lblBasePrompt.Name = "lblBasePrompt"
        Me.lblBasePrompt.Size = New System.Drawing.Size(124, 17)
        Me.lblBasePrompt.TabIndex = 2
        Me.lblBasePrompt.Text = "Base (b) en [cm] >"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtNombre.Location = New System.Drawing.Point(145, 29)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(260, 25)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombrePrompt
        '
        Me.lblNombrePrompt.AutoSize = True
        Me.lblNombrePrompt.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombrePrompt.Location = New System.Drawing.Point(15, 32)
        Me.lblNombrePrompt.Name = "lblNombrePrompt"
        Me.lblNombrePrompt.Size = New System.Drawing.Size(123, 17)
        Me.lblNombrePrompt.TabIndex = 0
        Me.lblNombrePrompt.Text = "Identificador (Auto) >"
        '
        'dgvRectangulos
        '
        Me.dgvRectangulos.AllowUserToAddRows = False
        Me.dgvRectangulos.AllowUserToDeleteRows = False
        Me.dgvRectangulos.AllowUserToResizeRows = False
        Me.dgvRectangulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRectangulos.BackgroundColor = System.Drawing.Color.White
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        dataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRectangulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
        Me.dgvRectangulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRectangulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colNombre, Me.colBase, Me.colAltura, Me.colArea, Me.colPerimetro, Me.colTipo})
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        dataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRectangulos.DefaultCellStyle = dataGridViewCellStyle2
        Me.dgvRectangulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRectangulos.Location = New System.Drawing.Point(460, 75)
        Me.dgvRectangulos.MultiSelect = False
        Me.dgvRectangulos.Name = "dgvRectangulos"
        Me.dgvRectangulos.ReadOnly = True
        Me.dgvRectangulos.RowHeadersVisible = False
        Me.dgvRectangulos.RowTemplate.Height = 25
        Me.dgvRectangulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRectangulos.Size = New System.Drawing.Size(480, 335)
        Me.dgvRectangulos.TabIndex = 3
        '
        'colId
        '
        Me.colId.FillWeight = 40.0!
        Me.colId.HeaderText = "ID"
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        '
        'colNombre
        '
        Me.colNombre.FillWeight = 110.0!
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        '
        'colBase
        '
        Me.colBase.FillWeight = 70.0!
        Me.colBase.HeaderText = "Base (cm)"
        Me.colBase.Name = "colBase"
        Me.colBase.ReadOnly = True
        '
        'colAltura
        '
        Me.colAltura.FillWeight = 70.0!
        Me.colAltura.HeaderText = "Altura (cm)"
        Me.colAltura.Name = "colAltura"
        Me.colAltura.ReadOnly = True
        '
        'colArea
        '
        Me.colArea.FillWeight = 85.0!
        Me.colArea.HeaderText = "Área (cm²)"
        Me.colArea.Name = "colArea"
        Me.colArea.ReadOnly = True
        '
        'colPerimetro
        '
        Me.colPerimetro.FillWeight = 90.0!
        Me.colPerimetro.HeaderText = "Perímetro (cm)"
        Me.colPerimetro.Name = "colPerimetro"
        Me.colPerimetro.ReadOnly = True
        '
        'colTipo
        '
        Me.colTipo.FillWeight = 90.0!
        Me.colTipo.HeaderText = "Clasificación"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.ReadOnly = True
        '
        'grpResultados
        '
        Me.grpResultados.Controls.Add(Me.lblConteoClasificacion)
        Me.grpResultados.Controls.Add(Me.lblPromediosTotales)
        Me.grpResultados.Controls.Add(Me.lblMenorPerimetro)
        Me.grpResultados.Controls.Add(Me.lblMayorPerimetro)
        Me.grpResultados.Controls.Add(Me.lblMenorArea)
        Me.grpResultados.Controls.Add(Me.lblMayorArea)
        Me.grpResultados.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpResultados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.grpResultados.Location = New System.Drawing.Point(20, 420)
        Me.grpResultados.Name = "grpResultados"
        Me.grpResultados.Size = New System.Drawing.Size(920, 155)
        Me.grpResultados.TabIndex = 4
        Me.grpResultados.TabStop = False
        Me.grpResultados.Text = "3. Análisis Estadístico del Conjunto Completo"
        '
        'lblConteoClasificacion
        '
        Me.lblConteoClasificacion.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblConteoClasificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.lblConteoClasificacion.Location = New System.Drawing.Point(610, 30)
        Me.lblConteoClasificacion.Name = "lblConteoClasificacion"
        Me.lblConteoClasificacion.Size = New System.Drawing.Size(295, 110)
        Me.lblConteoClasificacion.TabIndex = 5
        Me.lblConteoClasificacion.Text = "Conteo por Tipo:" & vbCrLf & "• Cuadrados: 0" & vbCrLf & "• Horizontales: 0" & vbCrLf & "• Verticales: 0"
        '
        'lblPromediosTotales
        '
        Me.lblPromediosTotales.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPromediosTotales.Location = New System.Drawing.Point(310, 30)
        Me.lblPromediosTotales.Name = "lblPromediosTotales"
        Me.lblPromediosTotales.Size = New System.Drawing.Size(280, 110)
        Me.lblPromediosTotales.TabIndex = 4
        Me.lblPromediosTotales.Text = "Métricas Totales:" & vbCrLf & "• Área Total: 0.00 cm²" & vbCrLf & "• Perímetro Total: 0.00 cm" & vbCrLf & "• Promedio Áreas: 0.00 cm²"
        '
        'lblMenorPerimetro
        '
        Me.lblMenorPerimetro.AutoSize = True
        Me.lblMenorPerimetro.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMenorPerimetro.Location = New System.Drawing.Point(15, 115)
        Me.lblMenorPerimetro.Name = "lblMenorPerimetro"
        Me.lblMenorPerimetro.Size = New System.Drawing.Size(185, 17)
        Me.lblMenorPerimetro.TabIndex = 3
        Me.lblMenorPerimetro.Text = "• Menor Perímetro: N/A (0.00 cm)"
        '
        'lblMayorPerimetro
        '
        Me.lblMayorPerimetro.AutoSize = True
        Me.lblMayorPerimetro.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMayorPerimetro.Location = New System.Drawing.Point(15, 85)
        Me.lblMayorPerimetro.Name = "lblMayorPerimetro"
        Me.lblMayorPerimetro.Size = New System.Drawing.Size(184, 17)
        Me.lblMayorPerimetro.TabIndex = 2
        Me.lblMayorPerimetro.Text = "• Mayor Perímetro: N/A (0.00 cm)"
        '
        'lblMenorArea
        '
        Me.lblMenorArea.AutoSize = True
        Me.lblMenorArea.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMenorArea.Location = New System.Drawing.Point(15, 55)
        Me.lblMenorArea.Name = "lblMenorArea"
        Me.lblMenorArea.Size = New System.Drawing.Size(159, 17)
        Me.lblMenorArea.TabIndex = 1
        Me.lblMenorArea.Text = "• Menor Área: N/A (0.00 cm²)"
        '
        'lblMayorArea
        '
        Me.lblMayorArea.AutoSize = True
        Me.lblMayorArea.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMayorArea.Location = New System.Drawing.Point(15, 28)
        Me.lblMayorArea.Name = "lblMayorArea"
        Me.lblMayorArea.Size = New System.Drawing.Size(158, 17)
        Me.lblMayorArea.TabIndex = 0
        Me.lblMayorArea.Text = "• Mayor Área: N/A (0.00 cm²)"
        '
        'btnNuevoConjunto
        '
        Me.btnNuevoConjunto.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnNuevoConjunto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevoConjunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoConjunto.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNuevoConjunto.ForeColor = System.Drawing.Color.White
        Me.btnNuevoConjunto.Location = New System.Drawing.Point(615, 585)
        Me.btnNuevoConjunto.Name = "btnNuevoConjunto"
        Me.btnNuevoConjunto.Size = New System.Drawing.Size(160, 40)
        Me.btnNuevoConjunto.TabIndex = 5
        Me.btnNuevoConjunto.Text = "↺ NUEVO CONJUNTO"
        Me.btnNuevoConjunto.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(790, 585)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(150, 40)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "← VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmAnalisisRectangulos
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 640)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnNuevoConjunto)
        Me.Controls.Add(Me.grpResultados)
        Me.Controls.Add(Me.dgvRectangulos)
        Me.Controls.Add(Me.grpRegistro)
        Me.Controls.Add(Me.grpDefinicionCantidad)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAnalisisRectangulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Algoritmo Geométrico - Análisis de un Conjunto de Rectángulos"
        Me.pnlHeader.ResumeLayout(False)
        Me.grpDefinicionCantidad.ResumeLayout(False)
        Me.grpDefinicionCantidad.PerformLayout()
        Me.grpRegistro.ResumeLayout(False)
        Me.grpRegistro.PerformLayout()
        CType(Me.dgvRectangulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResultados.ResumeLayout(False)
        Me.grpResultados.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTituloHeader As System.Windows.Forms.Label
    Friend WithEvents grpDefinicionCantidad As System.Windows.Forms.GroupBox
    Friend WithEvents lblCantidadPrompt As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents btnEstablecerCantidad As System.Windows.Forms.Button
    Friend WithEvents lblProgreso As System.Windows.Forms.Label
    Friend WithEvents grpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombrePrompt As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblBasePrompt As System.Windows.Forms.Label
    Friend WithEvents txtBase As System.Windows.Forms.TextBox
    Friend WithEvents lblAlturaPrompt As System.Windows.Forms.Label
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents lblLiveSuperficie As System.Windows.Forms.Label
    Friend WithEvents btnAgregarRectangulo As System.Windows.Forms.Button
    Friend WithEvents dgvRectangulos As System.Windows.Forms.DataGridView
    Friend WithEvents colId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAltura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPerimetro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpResultados As System.Windows.Forms.GroupBox
    Friend WithEvents lblMayorArea As System.Windows.Forms.Label
    Friend WithEvents lblMenorArea As System.Windows.Forms.Label
    Friend WithEvents lblMayorPerimetro As System.Windows.Forms.Label
    Friend WithEvents lblMenorPerimetro As System.Windows.Forms.Label
    Friend WithEvents lblPromediosTotales As System.Windows.Forms.Label
    Friend WithEvents lblConteoClasificacion As System.Windows.Forms.Label
    Friend WithEvents btnNuevoConjunto As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button

End Class
