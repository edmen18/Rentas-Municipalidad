<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCliente))
        Me.gruCliente = New System.Windows.Forms.GroupBox
        Me.txtmz = New System.Windows.Forms.TextBox
        Me.txtlote = New System.Windows.Forms.TextBox
        Me.txtnumero = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCodCli = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.txtRepLeg = New System.Windows.Forms.TextBox
        Me.cmbTipoPer = New System.Windows.Forms.ComboBox
        Me.txtRuc = New System.Windows.Forms.TextBox
        Me.txtDni = New System.Windows.Forms.TextBox
        Me.txtDirCli = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNomCli = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImgStado = New System.Windows.Forms.ImageList(Me.components)
        Me.txtBusqueda = New System.Windows.Forms.TextBox
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.dgvClientes = New System.Windows.Forms.DataGridView
        Me.lvwpredios = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.lvwventas = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.gruCliente.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gruCliente
        '
        Me.gruCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gruCliente.Controls.Add(Me.txtmz)
        Me.gruCliente.Controls.Add(Me.txtlote)
        Me.gruCliente.Controls.Add(Me.txtnumero)
        Me.gruCliente.Controls.Add(Me.Label12)
        Me.gruCliente.Controls.Add(Me.Label11)
        Me.gruCliente.Controls.Add(Me.Label10)
        Me.gruCliente.Controls.Add(Me.Label9)
        Me.gruCliente.Controls.Add(Me.txtCodCli)
        Me.gruCliente.Controls.Add(Me.txtEmail)
        Me.gruCliente.Controls.Add(Me.txtTel)
        Me.gruCliente.Controls.Add(Me.txtRepLeg)
        Me.gruCliente.Controls.Add(Me.cmbTipoPer)
        Me.gruCliente.Controls.Add(Me.txtRuc)
        Me.gruCliente.Controls.Add(Me.txtDni)
        Me.gruCliente.Controls.Add(Me.txtDirCli)
        Me.gruCliente.Controls.Add(Me.Label8)
        Me.gruCliente.Controls.Add(Me.txtNomCli)
        Me.gruCliente.Controls.Add(Me.Label7)
        Me.gruCliente.Controls.Add(Me.Label6)
        Me.gruCliente.Controls.Add(Me.Label5)
        Me.gruCliente.Controls.Add(Me.Label4)
        Me.gruCliente.Controls.Add(Me.Label3)
        Me.gruCliente.Controls.Add(Me.Label2)
        Me.gruCliente.Controls.Add(Me.Label1)
        Me.gruCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gruCliente.Location = New System.Drawing.Point(8, 12)
        Me.gruCliente.Name = "gruCliente"
        Me.gruCliente.Size = New System.Drawing.Size(654, 178)
        Me.gruCliente.TabIndex = 51
        Me.gruCliente.TabStop = False
        Me.gruCliente.Text = "Datos del Contribuyente"
        '
        'txtmz
        '
        Me.txtmz.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmz.Location = New System.Drawing.Point(591, 81)
        Me.txtmz.Name = "txtmz"
        Me.txtmz.Size = New System.Drawing.Size(46, 20)
        Me.txtmz.TabIndex = 39
        '
        'txtlote
        '
        Me.txtlote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtlote.Location = New System.Drawing.Point(511, 80)
        Me.txtlote.Name = "txtlote"
        Me.txtlote.Size = New System.Drawing.Size(46, 20)
        Me.txtlote.TabIndex = 38
        '
        'txtnumero
        '
        Me.txtnumero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnumero.Location = New System.Drawing.Point(437, 80)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(46, 20)
        Me.txtnumero.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(563, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Mz."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(486, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Lote"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(397, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Numero"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Codigo"
        '
        'txtCodCli
        '
        Me.txtCodCli.Enabled = False
        Me.txtCodCli.Location = New System.Drawing.Point(82, 32)
        Me.txtCodCli.MaxLength = 10
        Me.txtCodCli.Name = "txtCodCli"
        Me.txtCodCli.Size = New System.Drawing.Size(140, 20)
        Me.txtCodCli.TabIndex = 32
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(288, 150)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(349, 20)
        Me.txtEmail.TabIndex = 31
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(82, 150)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(140, 20)
        Me.txtTel.TabIndex = 30
        '
        'txtRepLeg
        '
        Me.txtRepLeg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRepLeg.Location = New System.Drawing.Point(82, 125)
        Me.txtRepLeg.Name = "txtRepLeg"
        Me.txtRepLeg.Size = New System.Drawing.Size(555, 20)
        Me.txtRepLeg.TabIndex = 29
        '
        'cmbTipoPer
        '
        Me.cmbTipoPer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTipoPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoPer.FormattingEnabled = True
        Me.cmbTipoPer.Location = New System.Drawing.Point(522, 32)
        Me.cmbTipoPer.Name = "cmbTipoPer"
        Me.cmbTipoPer.Size = New System.Drawing.Size(115, 21)
        Me.cmbTipoPer.TabIndex = 28
        '
        'txtRuc
        '
        Me.txtRuc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRuc.Location = New System.Drawing.Point(288, 102)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(349, 20)
        Me.txtRuc.TabIndex = 27
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(82, 102)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(140, 20)
        Me.txtDni.TabIndex = 26
        '
        'txtDirCli
        '
        Me.txtDirCli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirCli.Location = New System.Drawing.Point(82, 79)
        Me.txtDirCli.Name = "txtDirCli"
        Me.txtDirCli.Size = New System.Drawing.Size(266, 20)
        Me.txtDirCli.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(431, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Tipo de Persona"
        '
        'txtNomCli
        '
        Me.txtNomCli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomCli.Location = New System.Drawing.Point(82, 55)
        Me.txtNomCli.Name = "txtNomCli"
        Me.txtNomCli.Size = New System.Drawing.Size(555, 20)
        Me.txtNomCli.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(247, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "E-mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Rep. Legal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "RUC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "DNI "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Direccion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre"
        '
        'ImgStado
        '
        Me.ImgStado.ImageStream = CType(resources.GetObject("ImgStado.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgStado.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgStado.Images.SetKeyName(0, "FileAddDigitalSignature.png")
        Me.ImgStado.Images.SetKeyName(1, "NewDistributionList.png")
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.BackColor = System.Drawing.Color.Khaki
        Me.txtBusqueda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.Gray
        Me.txtBusqueda.Location = New System.Drawing.Point(8, 234)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(654, 21)
        Me.txtBusqueda.TabIndex = 57
        Me.txtBusqueda.Text = "ingrese contribuyente a consultar..."
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnActualizar.Enabled = False
        Me.btnActualizar.ForeColor = System.Drawing.Color.Black
        Me.btnActualizar.Image = Global.GUIRentas.My.Resources.Resources._15
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(362, 196)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(96, 28)
        Me.btnActualizar.TabIndex = 55
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = Global.GUIRentas.My.Resources.Resources._28
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(566, 196)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 28)
        Me.btnCancelar.TabIndex = 54
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Image = Global.GUIRentas.My.Resources.Resources._19s
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(464, 196)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 28)
        Me.btnEliminar.TabIndex = 53
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = Global.GUIRentas.My.Resources.Resources._17
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(260, 196)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 28)
        Me.btnNuevo.TabIndex = 52
        Me.btnNuevo.Text = "&Agregar"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.GUIRentas.My.Resources.Resources._28
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.GUIRentas.My.Resources.Resources._32
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.GUIRentas.My.Resources.Resources._21
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.GUIRentas.My.Resources.Resources._28
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(8, 261)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.Size = New System.Drawing.Size(654, 235)
        Me.dgvClientes.TabIndex = 58
        '
        'lvwpredios
        '
        Me.lvwpredios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvwpredios.GridLines = True
        Me.lvwpredios.Location = New System.Drawing.Point(28, 327)
        Me.lvwpredios.Name = "lvwpredios"
        Me.lvwpredios.Size = New System.Drawing.Size(125, 154)
        Me.lvwpredios.TabIndex = 59
        Me.lvwpredios.UseCompatibleStateImageBehavior = False
        Me.lvwpredios.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "predio"
        Me.ColumnHeader1.Width = 121
        '
        'lvwventas
        '
        Me.lvwventas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.lvwventas.GridLines = True
        Me.lvwventas.Location = New System.Drawing.Point(165, 327)
        Me.lvwventas.Name = "lvwventas"
        Me.lvwventas.Size = New System.Drawing.Size(125, 154)
        Me.lvwventas.TabIndex = 60
        Me.lvwventas.UseCompatibleStateImageBehavior = False
        Me.lvwventas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ventas"
        Me.ColumnHeader2.Width = 121
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(674, 508)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.gruCliente)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lvwventas)
        Me.Controls.Add(Me.lvwpredios)
        Me.Name = "FrmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Contribuyente"
        Me.gruCliente.ResumeLayout(False)
        Me.gruCliente.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gruCliente As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtRepLeg As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoPer As System.Windows.Forms.ComboBox
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents txtDirCli As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNomCli As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ImgStado As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents txtmz As System.Windows.Forms.TextBox
    Friend WithEvents txtlote As System.Windows.Forms.TextBox
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lvwpredios As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwventas As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
