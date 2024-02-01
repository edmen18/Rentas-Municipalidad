<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.lblSerieHD = New System.Windows.Forms.Label
        Me.txtClaveProducto = New System.Windows.Forms.TextBox
        Me.btnActivarAhora = New System.Windows.Forms.Button
        Me.btnActivarDespues = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id de Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Clave Producto"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(201, 16)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(365, 20)
        Me.txtUsuario.TabIndex = 3
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSerieHD
        '
        Me.lblSerieHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSerieHD.Location = New System.Drawing.Point(201, 41)
        Me.lblSerieHD.Name = "lblSerieHD"
        Me.lblSerieHD.Size = New System.Drawing.Size(365, 21)
        Me.lblSerieHD.TabIndex = 4
        Me.lblSerieHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtClaveProducto
        '
        Me.txtClaveProducto.Location = New System.Drawing.Point(201, 75)
        Me.txtClaveProducto.Name = "txtClaveProducto"
        Me.txtClaveProducto.Size = New System.Drawing.Size(365, 20)
        Me.txtClaveProducto.TabIndex = 5
        Me.txtClaveProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnActivarAhora
        '
        Me.btnActivarAhora.Image = Global.GUIRentas.My.Resources.Resources._84
        Me.btnActivarAhora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActivarAhora.Location = New System.Drawing.Point(419, 101)
        Me.btnActivarAhora.Name = "btnActivarAhora"
        Me.btnActivarAhora.Size = New System.Drawing.Size(147, 36)
        Me.btnActivarAhora.TabIndex = 6
        Me.btnActivarAhora.Text = "Activar ahora"
        Me.btnActivarAhora.UseVisualStyleBackColor = True
        '
        'btnActivarDespues
        '
        Me.btnActivarDespues.Image = Global.GUIRentas.My.Resources.Resources._75
        Me.btnActivarDespues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActivarDespues.Location = New System.Drawing.Point(254, 101)
        Me.btnActivarDespues.Name = "btnActivarDespues"
        Me.btnActivarDespues.Size = New System.Drawing.Size(159, 36)
        Me.btnActivarDespues.TabIndex = 7
        Me.btnActivarDespues.Text = "Registrar despues"
        Me.btnActivarDespues.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUIRentas.My.Resources.Resources.lockD
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 117)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'RegistroProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 138)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnActivarDespues)
        Me.Controls.Add(Me.btnActivarAhora)
        Me.Controls.Add(Me.txtClaveProducto)
        Me.Controls.Add(Me.lblSerieHD)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "RegistroProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Producto"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblSerieHD As System.Windows.Forms.Label
    Friend WithEvents txtClaveProducto As System.Windows.Forms.TextBox
    Friend WithEvents btnActivarAhora As System.Windows.Forms.Button
    Friend WithEvents btnActivarDespues As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
