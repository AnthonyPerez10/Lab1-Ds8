<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuPrincipal
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
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.grpOpcionesMenu = New System.Windows.Forms.GroupBox()
        Me.btnAnalisisRectangulos = New System.Windows.Forms.Button()
        Me.btnTablasMultiplicar = New System.Windows.Forms.Button()
        Me.btnCalificacionFinal = New System.Windows.Forms.Button()
        Me.btnNumeroPositivo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.grpOpcionesMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTituloHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(540, 70)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTituloHeader
        '
        Me.lblTituloHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTituloHeader.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTituloHeader.ForeColor = System.Drawing.Color.White
        Me.lblTituloHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblTituloHeader.Name = "lblTituloHeader"
        Me.lblTituloHeader.Size = New System.Drawing.Size(540, 70)
        Me.lblTituloHeader.TabIndex = 0
        Me.lblTituloHeader.Text = "ESTRUCTURAS DE ITERACIÓN VISUAL BASIC"
        Me.lblTituloHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.AutoSize = True
        Me.lblSubtitulo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblSubtitulo.Location = New System.Drawing.Point(30, 85)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(432, 19)
        Me.lblSubtitulo.TabIndex = 1
        Me.lblSubtitulo.Text = "Seleccione una opción para navegar a la ventana correspondiente:"
        '
        'grpOpcionesMenu
        '
        Me.grpOpcionesMenu.Controls.Add(Me.btnAnalisisRectangulos)
        Me.grpOpcionesMenu.Controls.Add(Me.btnTablasMultiplicar)
        Me.grpOpcionesMenu.Controls.Add(Me.btnCalificacionFinal)
        Me.grpOpcionesMenu.Controls.Add(Me.btnNumeroPositivo)
        Me.grpOpcionesMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpOpcionesMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.grpOpcionesMenu.Location = New System.Drawing.Point(30, 115)
        Me.grpOpcionesMenu.Name = "grpOpcionesMenu"
        Me.grpOpcionesMenu.Size = New System.Drawing.Size(480, 270)
        Me.grpOpcionesMenu.TabIndex = 2
        Me.grpOpcionesMenu.TabStop = False
        Me.grpOpcionesMenu.Text = "Menú Principal de Opciones"
        '
        'btnAnalisisRectangulos
        '
        Me.btnAnalisisRectangulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnAnalisisRectangulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnalisisRectangulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnalisisRectangulos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAnalisisRectangulos.ForeColor = System.Drawing.Color.White
        Me.btnAnalisisRectangulos.Location = New System.Drawing.Point(30, 35)
        Me.btnAnalisisRectangulos.Name = "btnAnalisisRectangulos"
        Me.btnAnalisisRectangulos.Size = New System.Drawing.Size(420, 45)
        Me.btnAnalisisRectangulos.TabIndex = 0
        Me.btnAnalisisRectangulos.Text = "1. Análisis de conjuntos de rectángulos"
        Me.btnAnalisisRectangulos.UseVisualStyleBackColor = False
        '
        'btnTablasMultiplicar
        '
        Me.btnTablasMultiplicar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnTablasMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTablasMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTablasMultiplicar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTablasMultiplicar.ForeColor = System.Drawing.Color.White
        Me.btnTablasMultiplicar.Location = New System.Drawing.Point(30, 90)
        Me.btnTablasMultiplicar.Name = "btnTablasMultiplicar"
        Me.btnTablasMultiplicar.Size = New System.Drawing.Size(420, 45)
        Me.btnTablasMultiplicar.TabIndex = 1
        Me.btnTablasMultiplicar.Text = "2. Tablas de multiplicación"
        Me.btnTablasMultiplicar.UseVisualStyleBackColor = False
        '
        'btnCalificacionFinal
        '
        Me.btnCalificacionFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnCalificacionFinal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalificacionFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalificacionFinal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalificacionFinal.ForeColor = System.Drawing.Color.White
        Me.btnCalificacionFinal.Location = New System.Drawing.Point(30, 145)
        Me.btnCalificacionFinal.Name = "btnCalificacionFinal"
        Me.btnCalificacionFinal.Size = New System.Drawing.Size(420, 45)
        Me.btnCalificacionFinal.TabIndex = 2
        Me.btnCalificacionFinal.Text = "3. Calificación final"
        Me.btnCalificacionFinal.UseVisualStyleBackColor = False
        '
        'btnNumeroPositivo
        '
        Me.btnNumeroPositivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNumeroPositivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNumeroPositivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNumeroPositivo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNumeroPositivo.ForeColor = System.Drawing.Color.White
        Me.btnNumeroPositivo.Location = New System.Drawing.Point(30, 200)
        Me.btnNumeroPositivo.Name = "btnNumeroPositivo"
        Me.btnNumeroPositivo.Size = New System.Drawing.Size(420, 45)
        Me.btnNumeroPositivo.TabIndex = 3
        Me.btnNumeroPositivo.Text = "4. Inserte un número positivo"
        Me.btnNumeroPositivo.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(380, 395)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(130, 38)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmMenuPrincipal
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(540, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.grpOpcionesMenu)
        Me.Controls.Add(Me.lblSubtitulo)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESTRUCTURAS DE ITERACION VISUAL BASIC"
        Me.pnlHeader.ResumeLayout(False)
        Me.grpOpcionesMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTituloHeader As System.Windows.Forms.Label
    Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
    Friend WithEvents grpOpcionesMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnalisisRectangulos As System.Windows.Forms.Button
    Friend WithEvents btnTablasMultiplicar As System.Windows.Forms.Button
    Friend WithEvents btnCalificacionFinal As System.Windows.Forms.Button
    Friend WithEvents btnNumeroPositivo As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class

