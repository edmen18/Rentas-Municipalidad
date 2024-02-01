<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategorias
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lblFlag = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDenominacion = New System.Windows.Forms.TextBox
        Me.txtColumna = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnAgrega = New System.Windows.Forms.Button
        Me.txtValor = New System.Windows.Forms.TextBox
        Me.txtContenido = New System.Windows.Forms.TextBox
        Me.txtLetra = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lblFlag)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.txtDenominacion)
        Me.GroupControl1.Controls.Add(Me.txtColumna)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Controls.Add(Me.btnAgrega)
        Me.GroupControl1.Controls.Add(Me.txtValor)
        Me.GroupControl1.Controls.Add(Me.txtContenido)
        Me.GroupControl1.Controls.Add(Me.txtLetra)
        Me.GroupControl1.Controls.Add(Me.txtCodigo)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(472, 223)
        Me.GroupControl1.TabIndex = 0
        '
        'lblFlag
        '
        Me.lblFlag.AutoSize = True
        Me.lblFlag.Location = New System.Drawing.Point(5, 175)
        Me.lblFlag.Name = "lblFlag"
        Me.lblFlag.Size = New System.Drawing.Size(0, 13)
        Me.lblFlag.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(357, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Valor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Denominacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Col."
        '
        'txtDenominacion
        '
        Me.txtDenominacion.Enabled = False
        Me.txtDenominacion.Location = New System.Drawing.Point(61, 109)
        Me.txtDenominacion.Multiline = True
        Me.txtDenominacion.Name = "txtDenominacion"
        Me.txtDenominacion.Size = New System.Drawing.Size(406, 33)
        Me.txtDenominacion.TabIndex = 79
        '
        'txtColumna
        '
        Me.txtColumna.Enabled = False
        Me.txtColumna.Location = New System.Drawing.Point(14, 109)
        Me.txtColumna.MaxLength = 2
        Me.txtColumna.Name = "txtColumna"
        Me.txtColumna.Size = New System.Drawing.Size(43, 20)
        Me.txtColumna.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Contenido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Letra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(325, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Codigo"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.CadetBlue
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.GUIRentas.My.Resources.Resources._41
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(371, 185)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 26)
        Me.btnSalir.TabIndex = 74
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAgrega
        '
        Me.btnAgrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgrega.BackColor = System.Drawing.Color.CadetBlue
        Me.btnAgrega.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btnAgrega.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen
        Me.btnAgrega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAgrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgrega.ForeColor = System.Drawing.Color.White
        Me.btnAgrega.Image = Global.GUIRentas.My.Resources.Resources._09
        Me.btnAgrega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgrega.Location = New System.Drawing.Point(269, 185)
        Me.btnAgrega.Name = "btnAgrega"
        Me.btnAgrega.Size = New System.Drawing.Size(96, 26)
        Me.btnAgrega.TabIndex = 73
        Me.btnAgrega.Text = "&Actualizar"
        Me.btnAgrega.UseVisualStyleBackColor = False
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(394, 148)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(73, 20)
        Me.txtValor.TabIndex = 5
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtContenido
        '
        Me.txtContenido.Location = New System.Drawing.Point(61, 52)
        Me.txtContenido.Multiline = True
        Me.txtContenido.Name = "txtContenido"
        Me.txtContenido.Size = New System.Drawing.Size(406, 38)
        Me.txtContenido.TabIndex = 2
        '
        'txtLetra
        '
        Me.txtLetra.Location = New System.Drawing.Point(14, 52)
        Me.txtLetra.MaxLength = 1
        Me.txtLetra.Name = "txtLetra"
        Me.txtLetra.Size = New System.Drawing.Size(43, 20)
        Me.txtLetra.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(367, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 223)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmCategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorias"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtContenido As System.Windows.Forms.TextBox
    Friend WithEvents txtLetra As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAgrega As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDenominacion As System.Windows.Forms.TextBox
    Friend WithEvents txtColumna As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblFlag As System.Windows.Forms.Label
End Class
