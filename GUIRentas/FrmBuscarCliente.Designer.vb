<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarCliente
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbruc = New System.Windows.Forms.RadioButton
        Me.rbdni = New System.Windows.Forms.RadioButton
        Me.rbnombreapellidos = New System.Windows.Forms.RadioButton
        Me.TXTDATO = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblflag = New System.Windows.Forms.Label
        Me.dgvClientes = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbruc)
        Me.GroupBox1.Controls.Add(Me.rbdni)
        Me.GroupBox1.Controls.Add(Me.rbnombreapellidos)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opción"
        '
        'rbruc
        '
        Me.rbruc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbruc.AutoSize = True
        Me.rbruc.Location = New System.Drawing.Point(438, 26)
        Me.rbruc.Name = "rbruc"
        Me.rbruc.Size = New System.Drawing.Size(67, 17)
        Me.rbruc.TabIndex = 2
        Me.rbruc.TabStop = True
        Me.rbruc.Text = "Por RUC"
        Me.rbruc.UseVisualStyleBackColor = True
        '
        'rbdni
        '
        Me.rbdni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbdni.AutoSize = True
        Me.rbdni.Location = New System.Drawing.Point(309, 26)
        Me.rbdni.Name = "rbdni"
        Me.rbdni.Size = New System.Drawing.Size(72, 17)
        Me.rbdni.TabIndex = 1
        Me.rbdni.TabStop = True
        Me.rbdni.Text = "Por D.N.I."
        Me.rbdni.UseVisualStyleBackColor = True
        '
        'rbnombreapellidos
        '
        Me.rbnombreapellidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbnombreapellidos.AutoSize = True
        Me.rbnombreapellidos.Location = New System.Drawing.Point(102, 26)
        Me.rbnombreapellidos.Name = "rbnombreapellidos"
        Me.rbnombreapellidos.Size = New System.Drawing.Size(140, 17)
        Me.rbnombreapellidos.TabIndex = 0
        Me.rbnombreapellidos.TabStop = True
        Me.rbnombreapellidos.Text = "Por Nombre y/o Apellido"
        Me.rbnombreapellidos.UseVisualStyleBackColor = True
        '
        'TXTDATO
        '
        Me.TXTDATO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTDATO.Location = New System.Drawing.Point(97, 78)
        Me.TXTDATO.Name = "TXTDATO"
        Me.TXTDATO.Size = New System.Drawing.Size(548, 20)
        Me.TXTDATO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese el Dato"
        '
        'lblflag
        '
        Me.lblflag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblflag.Location = New System.Drawing.Point(531, 257)
        Me.lblflag.Name = "lblflag"
        Me.lblflag.Size = New System.Drawing.Size(100, 23)
        Me.lblflag.TabIndex = 4
        Me.lblflag.Visible = False
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(12, 104)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.Size = New System.Drawing.Size(633, 187)
        Me.dgvClientes.TabIndex = 5
        '
        'FrmBuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(663, 303)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTDATO)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblflag)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmBuscarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbruc As System.Windows.Forms.RadioButton
    Friend WithEvents rbdni As System.Windows.Forms.RadioButton
    Friend WithEvents rbnombreapellidos As System.Windows.Forms.RadioButton
    Friend WithEvents TXTDATO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblflag As System.Windows.Forms.Label
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
End Class
