<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.grpSaludo = New System.Windows.Forms.GroupBox()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnSaludar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombrePrompt = New System.Windows.Forms.Label()
        Me.grpIteracion = New System.Windows.Forms.GroupBox()
        Me.lblIteracionInfo = New System.Windows.Forms.Label()
        Me.btnEjecutarBucle = New System.Windows.Forms.Button()
        Me.lstResultados = New System.Windows.Forms.ListBox()
        Me.grpSaludo.SuspendLayout()
        Me.grpIteracion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTitulo.Location = New System.Drawing.Point(20, 20)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(370, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "¡Hola Mundo en Visual Basic .NET!"
        '
        'grpSaludo
        '
        Me.grpSaludo.Controls.Add(Me.lblMensaje)
        Me.grpSaludo.Controls.Add(Me.btnSaludar)
        Me.grpSaludo.Controls.Add(Me.txtNombre)
        Me.grpSaludo.Controls.Add(Me.lblNombrePrompt)
        Me.grpSaludo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpSaludo.Location = New System.Drawing.Point(20, 65)
        Me.grpSaludo.Name = "grpSaludo"
        Me.grpSaludo.Size = New System.Drawing.Size(440, 140)
        Me.grpSaludo.TabIndex = 1
        Me.grpSaludo.TabStop = False
        Me.grpSaludo.Text = "1. Interacción de Saludo"
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMensaje.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblMensaje.Location = New System.Drawing.Point(15, 70)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(410, 50)
        Me.lblMensaje.TabIndex = 3
        Me.lblMensaje.Text = "Haz clic en '¡Saludar!' para ver la magia."
        '
        'btnSaludar
        '
        Me.btnSaludar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSaludar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSaludar.Location = New System.Drawing.Point(325, 25)
        Me.btnSaludar.Name = "btnSaludar"
        Me.btnSaludar.Size = New System.Drawing.Size(100, 28)
        Me.btnSaludar.TabIndex = 2
        Me.btnSaludar.Text = "¡Saludar!"
        Me.btnSaludar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(145, 27)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(170, 25)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombrePrompt
        '
        Me.lblNombrePrompt.AutoSize = True
        Me.lblNombrePrompt.Location = New System.Drawing.Point(15, 30)
        Me.lblNombrePrompt.Name = "lblNombrePrompt"
        Me.lblNombrePrompt.Size = New System.Drawing.Size(123, 19)
        Me.lblNombrePrompt.TabIndex = 0
        Me.lblNombrePrompt.Text = "Ingresa tu nombre:"
        '
        'grpIteracion
        '
        Me.grpIteracion.Controls.Add(Me.lblIteracionInfo)
        Me.grpIteracion.Controls.Add(Me.btnEjecutarBucle)
        Me.grpIteracion.Controls.Add(Me.lstResultados)
        Me.grpIteracion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpIteracion.Location = New System.Drawing.Point(20, 215)
        Me.grpIteracion.Name = "grpIteracion"
        Me.grpIteracion.Size = New System.Drawing.Size(440, 220)
        Me.grpIteracion.TabIndex = 2
        Me.grpIteracion.TabStop = False
        Me.grpIteracion.Text = "2. Estructuras de Iteración (Loops)"
        '
        'lblIteracionInfo
        '
        Me.lblIteracionInfo.AutoSize = True
        Me.lblIteracionInfo.Location = New System.Drawing.Point(15, 30)
        Me.lblIteracionInfo.Name = "lblIteracionInfo"
        Me.lblIteracionInfo.Size = New System.Drawing.Size(230, 19)
        Me.lblIteracionInfo.TabIndex = 0
        Me.lblIteracionInfo.Text = "Ejemplo de iteración (For ... Next):"
        '
        'btnEjecutarBucle
        '
        Me.btnEjecutarBucle.Location = New System.Drawing.Point(280, 25)
        Me.btnEjecutarBucle.Name = "btnEjecutarBucle"
        Me.btnEjecutarBucle.Size = New System.Drawing.Size(145, 28)
        Me.btnEjecutarBucle.TabIndex = 1
        Me.btnEjecutarBucle.Text = "Ejecutar Bucle For"
        Me.btnEjecutarBucle.UseVisualStyleBackColor = True
        '
        'lstResultados
        '
        Me.lstResultados.FormattingEnabled = True
        Me.lstResultados.ItemHeight = 17
        Me.lstResultados.Location = New System.Drawing.Point(15, 60)
        Me.lstResultados.Name = "lstResultados"
        Me.lstResultados.Size = New System.Drawing.Size(410, 140)
        Me.lstResultados.TabIndex = 2
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(480, 455)
        Me.Controls.Add(Me.grpIteracion)
        Me.Controls.Add(Me.grpSaludo)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Basic - Hola Mundo & Estructuras de Iteración"
        Me.grpSaludo.ResumeLayout(False)
        Me.grpSaludo.PerformLayout()
        Me.grpIteracion.ResumeLayout(False)
        Me.grpIteracion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents grpSaludo As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombrePrompt As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnSaludar As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents grpIteracion As System.Windows.Forms.GroupBox
    Friend WithEvents lblIteracionInfo As System.Windows.Forms.Label
    Friend WithEvents btnEjecutarBucle As System.Windows.Forms.Button
    Friend WithEvents lstResultados As System.Windows.Forms.ListBox

End Class
