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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTituloHeader = New System.Windows.Forms.Label()
        Me.grpContenedor = New System.Windows.Forms.GroupBox()
        Me.lblMenuAccedido = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.grpContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTituloHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(500, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTituloHeader
        '
        Me.lblTituloHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTituloHeader.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTituloHeader.ForeColor = System.Drawing.Color.White
        Me.lblTituloHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblTituloHeader.Name = "lblTituloHeader"
        Me.lblTituloHeader.Size = New System.Drawing.Size(500, 60)
        Me.lblTituloHeader.TabIndex = 0
        Me.lblTituloHeader.Text = "Análisis de conjuntos de rectángulos"
        Me.lblTituloHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpContenedor
        '
        Me.grpContenedor.Controls.Add(Me.lblMenuAccedido)
        Me.grpContenedor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpContenedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.grpContenedor.Location = New System.Drawing.Point(25, 80)
        Me.grpContenedor.Name = "grpContenedor"
        Me.grpContenedor.Size = New System.Drawing.Size(450, 150)
        Me.grpContenedor.TabIndex = 1
        Me.grpContenedor.TabStop = False
        Me.grpContenedor.Text = "Información del Menú"
        '
        'lblMenuAccedido
        '
        Me.lblMenuAccedido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMenuAccedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblMenuAccedido.Location = New System.Drawing.Point(20, 45)
        Me.lblMenuAccedido.Name = "lblMenuAccedido"
        Me.lblMenuAccedido.Size = New System.Drawing.Size(410, 70)
        Me.lblMenuAccedido.TabIndex = 0
        Me.lblMenuAccedido.Text = "Accedió al menú: Análisis de conjuntos de rectángulos"
        Me.lblMenuAccedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(175, 250)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(150, 40)
        Me.btnVolver.TabIndex = 2
        Me.btnVolver.Text = "← Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmAnalisisRectangulos
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 315)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.grpContenedor)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAnalisisRectangulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis de conjuntos de rectángulos"
        Me.pnlHeader.ResumeLayout(False)
        Me.grpContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTituloHeader As System.Windows.Forms.Label
    Friend WithEvents grpContenedor As System.Windows.Forms.GroupBox
    Friend WithEvents lblMenuAccedido As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button

End Class

