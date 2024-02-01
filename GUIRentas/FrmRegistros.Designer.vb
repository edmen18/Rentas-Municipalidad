<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistros))
        Me.gbxClase = New System.Windows.Forms.GroupBox
        Me.dgvClase = New System.Windows.Forms.DataGridView
        Me.btnGrabarClase = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnNuevaClase = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgvDivision = New System.Windows.Forms.DataGridView
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.gbxClase.SuspendLayout()
        CType(Me.dgvClase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxClase
        '
        Me.gbxClase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxClase.Controls.Add(Me.dgvClase)
        Me.gbxClase.Controls.Add(Me.btnGrabarClase)
        Me.gbxClase.Controls.Add(Me.btnSalir)
        Me.gbxClase.Controls.Add(Me.btnNuevaClase)
        Me.gbxClase.Location = New System.Drawing.Point(420, 0)
        Me.gbxClase.Name = "gbxClase"
        Me.gbxClase.Size = New System.Drawing.Size(350, 496)
        Me.gbxClase.TabIndex = 66
        Me.gbxClase.TabStop = False
        Me.gbxClase.Text = "Datos de la Tasa"
        '
        'dgvClase
        '
        Me.dgvClase.AllowUserToAddRows = False
        Me.dgvClase.AllowUserToDeleteRows = False
        Me.dgvClase.AllowUserToOrderColumns = True
        Me.dgvClase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClase.Location = New System.Drawing.Point(13, 19)
        Me.dgvClase.Name = "dgvClase"
        Me.dgvClase.ReadOnly = True
        Me.dgvClase.Size = New System.Drawing.Size(331, 441)
        Me.dgvClase.TabIndex = 71
        '
        'btnGrabarClase
        '
        Me.btnGrabarClase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGrabarClase.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnGrabarClase.ForeColor = System.Drawing.Color.Black
        Me.btnGrabarClase.Image = CType(resources.GetObject("btnGrabarClase.Image"), System.Drawing.Image)
        Me.btnGrabarClase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabarClase.Location = New System.Drawing.Point(150, 466)
        Me.btnGrabarClase.Name = "btnGrabarClase"
        Me.btnGrabarClase.Size = New System.Drawing.Size(96, 26)
        Me.btnGrabarClase.TabIndex = 70
        Me.btnGrabarClase.Text = "&Modificar"
        Me.btnGrabarClase.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = Global.GUIRentas.My.Resources.Resources._41
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(248, 466)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 26)
        Me.btnSalir.TabIndex = 69
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevaClase
        '
        Me.btnNuevaClase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevaClase.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnNuevaClase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen
        Me.btnNuevaClase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnNuevaClase.ForeColor = System.Drawing.Color.Black
        Me.btnNuevaClase.Image = Global.GUIRentas.My.Resources.Resources._17
        Me.btnNuevaClase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevaClase.Location = New System.Drawing.Point(52, 466)
        Me.btnNuevaClase.Name = "btnNuevaClase"
        Me.btnNuevaClase.Size = New System.Drawing.Size(96, 26)
        Me.btnNuevaClase.TabIndex = 68
        Me.btnNuevaClase.Text = "&Agregar"
        Me.btnNuevaClase.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgvDivision)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 496)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Division"
        '
        'dgvDivision
        '
        Me.dgvDivision.AllowUserToAddRows = False
        Me.dgvDivision.AllowUserToDeleteRows = False
        Me.dgvDivision.AllowUserToOrderColumns = True
        Me.dgvDivision.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDivision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDivision.Location = New System.Drawing.Point(13, 19)
        Me.dgvDivision.Name = "dgvDivision"
        Me.dgvDivision.ReadOnly = True
        Me.dgvDivision.Size = New System.Drawing.Size(378, 438)
        Me.dgvDivision.TabIndex = 68
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(295, 463)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(96, 26)
        Me.btnGuardar.TabIndex = 67
        Me.btnGuardar.Text = "&Modificar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = Global.GUIRentas.My.Resources.Resources._17
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(197, 463)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 26)
        Me.btnNuevo.TabIndex = 65
        Me.btnNuevo.Text = "&Agregar"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'FrmRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(771, 496)
        Me.Controls.Add(Me.gbxClase)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmRegistros"
        Me.Text = "Texto Unico Ordenado de Tasas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbxClase.ResumeLayout(False)
        CType(Me.dgvClase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDivision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxClase As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnGrabarClase As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnNuevaClase As System.Windows.Forms.Button
    Friend WithEvents dgvDivision As System.Windows.Forms.DataGridView
    Friend WithEvents dgvClase As System.Windows.Forms.DataGridView
End Class
