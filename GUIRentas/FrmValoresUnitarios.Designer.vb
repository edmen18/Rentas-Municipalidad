<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValoresUnitarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValoresUnitarios))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.dgvDenominacion = New System.Windows.Forms.DataGridView
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnEditar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnAgrega = New System.Windows.Forms.Button
        Me.dgvCategorias = New System.Windows.Forms.DataGridView
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dgvDenominacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.LightBlue
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainer1.Size = New System.Drawing.Size(773, 429)
        Me.SplitContainer1.SplitterDistance = 243
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.dgvDenominacion)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(243, 429)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Contenidos"
        '
        'dgvDenominacion
        '
        Me.dgvDenominacion.AllowUserToAddRows = False
        Me.dgvDenominacion.AllowUserToDeleteRows = False
        Me.dgvDenominacion.AllowUserToOrderColumns = True
        Me.dgvDenominacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDenominacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDenominacion.Location = New System.Drawing.Point(3, 23)
        Me.dgvDenominacion.Name = "dgvDenominacion"
        Me.dgvDenominacion.ReadOnly = True
        Me.dgvDenominacion.Size = New System.Drawing.Size(238, 364)
        Me.dgvDenominacion.TabIndex = 1
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btnEliminar)
        Me.GroupControl2.Controls.Add(Me.btnEditar)
        Me.GroupControl2.Controls.Add(Me.btnSalir)
        Me.GroupControl2.Controls.Add(Me.btnAgrega)
        Me.GroupControl2.Controls.Add(Me.dgvCategorias)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(526, 429)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Categorias"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.CadetBlue
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Image = Global.GUIRentas.My.Resources.Resources._19s
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(324, 393)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 26)
        Me.btnEliminar.TabIndex = 74
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.CadetBlue
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.Color.Black
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(222, 393)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(96, 26)
        Me.btnEditar.TabIndex = 73
        Me.btnEditar.Text = "&Modificar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.CadetBlue
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = Global.GUIRentas.My.Resources.Resources._41
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(426, 393)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 26)
        Me.btnSalir.TabIndex = 72
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
        Me.btnAgrega.ForeColor = System.Drawing.Color.Black
        Me.btnAgrega.Image = Global.GUIRentas.My.Resources.Resources._17
        Me.btnAgrega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgrega.Location = New System.Drawing.Point(120, 393)
        Me.btnAgrega.Name = "btnAgrega"
        Me.btnAgrega.Size = New System.Drawing.Size(96, 26)
        Me.btnAgrega.TabIndex = 71
        Me.btnAgrega.Text = "&Agregar"
        Me.btnAgrega.UseVisualStyleBackColor = False
        '
        'dgvCategorias
        '
        Me.dgvCategorias.AllowUserToAddRows = False
        Me.dgvCategorias.AllowUserToDeleteRows = False
        Me.dgvCategorias.AllowUserToOrderColumns = True
        Me.dgvCategorias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategorias.Location = New System.Drawing.Point(3, 23)
        Me.dgvCategorias.Name = "dgvCategorias"
        Me.dgvCategorias.ReadOnly = True
        Me.dgvCategorias.Size = New System.Drawing.Size(520, 364)
        Me.dgvCategorias.TabIndex = 1
        '
        'FrmValoresUnitarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 429)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmValoresUnitarios"
        Me.Text = "Valores Unitarios oficiales de Edificacion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.dgvDenominacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvDenominacion As System.Windows.Forms.DataGridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvCategorias As System.Windows.Forms.DataGridView
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAgrega As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
