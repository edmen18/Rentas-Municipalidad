<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRealizaVenta
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbAgregaItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbRemoveItem = New System.Windows.Forms.ToolStripButton
        Me.tsbEditaItem = New System.Windows.Forms.ToolStripButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.LBLCODCTA = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.lbluitmonto = New System.Windows.Forms.Label
        Me.txtuitmonto = New System.Windows.Forms.TextBox
        Me.Lvwdetalle_venta = New System.Windows.Forms.ListView
        Me.Codi = New System.Windows.Forms.ColumnHeader
        Me.Des = New System.Windows.Forms.ColumnHeader
        Me.PrecAc = New System.Windows.Forms.ColumnHeader
        Me.Cant = New System.Windows.Forms.ColumnHeader
        Me.Subt = New System.Windows.Forms.ColumnHeader
        Me.tipo = New System.Windows.Forms.ColumnHeader
        Me.uitx = New System.Windows.Forms.ColumnHeader
        Me.cuent = New System.Windows.Forms.ColumnHeader
        Me.prcio = New System.Windows.Forms.ColumnHeader
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.lblpreciounitario = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblcodservicio = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbldescripcion = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbltiposervicio = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.lblcodigo_cli = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblruc = New System.Windows.Forms.Label
        Me.lblnombre_cliente = New System.Windows.Forms.Label
        Me.lbldni = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtclase = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lvwclase = New System.Windows.Forms.ListView
        Me.cod = New System.Windows.Forms.ColumnHeader
        Me.desc = New System.Windows.Forms.ColumnHeader
        Me.valor = New System.Windows.Forms.ColumnHeader
        Me.codx = New System.Windows.Forms.ColumnHeader
        Me.cuenta = New System.Windows.Forms.ColumnHeader
        Me.porc = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbogrupo = New System.Windows.Forms.ComboBox
        Me.GrpVenta = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblcod_venta = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboformapago = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpVenta.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.btnCancelar)
        Me.GroupBox4.Controls.Add(Me.btnGrabar)
        Me.GroupBox4.Controls.Add(Me.btnNuevo)
        Me.GroupBox4.Location = New System.Drawing.Point(852, 338)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(105, 203)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ejecucion"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.GUIRentas.My.Resources.Resources._75
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(17, 136)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(74, 58)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "&Salir"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Image = Global.GUIRentas.My.Resources.Resources._21
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(17, 77)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(74, 58)
        Me.btnGrabar.TabIndex = 1
        Me.btnGrabar.Text = "&Guardar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.GUIRentas.My.Resources.Resources._49
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(17, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(74, 58)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.ToolStrip1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.LBLCODCTA)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lbltotal)
        Me.GroupBox3.Controls.Add(Me.lbluitmonto)
        Me.GroupBox3.Controls.Add(Me.txtuitmonto)
        Me.GroupBox3.Controls.Add(Me.Lvwdetalle_venta)
        Me.GroupBox3.Controls.Add(Me.txtcantidad)
        Me.GroupBox3.Controls.Add(Me.lblpreciounitario)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lblcodservicio)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lbldescripcion)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lbltiposervicio)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 338)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(835, 203)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Servicio"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregaItem, Me.ToolStripSeparator1, Me.tsbRemoveItem, Me.tsbEditaItem})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(803, 49)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(24, 86)
        Me.ToolStrip1.TabIndex = 49
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbAgregaItem
        '
        Me.tsbAgregaItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAgregaItem.Image = Global.GUIRentas.My.Resources.Resources._49s
        Me.tsbAgregaItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregaItem.Name = "tsbAgregaItem"
        Me.tsbAgregaItem.Size = New System.Drawing.Size(22, 20)
        Me.tsbAgregaItem.Text = "Agregar Item a la Lista"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(22, 6)
        '
        'tsbRemoveItem
        '
        Me.tsbRemoveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRemoveItem.Image = Global.GUIRentas.My.Resources.Resources._50
        Me.tsbRemoveItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRemoveItem.Name = "tsbRemoveItem"
        Me.tsbRemoveItem.Size = New System.Drawing.Size(22, 20)
        Me.tsbRemoveItem.Text = "Quitar Item de la Lista"
        '
        'tsbEditaItem
        '
        Me.tsbEditaItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditaItem.Image = Global.GUIRentas.My.Resources.Resources._09
        Me.tsbEditaItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditaItem.Name = "tsbEditaItem"
        Me.tsbEditaItem.Size = New System.Drawing.Size(22, 20)
        Me.tsbEditaItem.Text = "Modifcar el Item"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(600, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "N° Cuenta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LBLCODCTA
        '
        Me.LBLCODCTA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLCODCTA.BackColor = System.Drawing.Color.LightGray
        Me.LBLCODCTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLCODCTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCODCTA.Location = New System.Drawing.Point(584, 42)
        Me.LBLCODCTA.Name = "LBLCODCTA"
        Me.LBLCODCTA.Size = New System.Drawing.Size(88, 23)
        Me.LBLCODCTA.TabIndex = 47
        Me.LBLCODCTA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(651, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Total (S/.)"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.BackColor = System.Drawing.Color.LightGray
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Location = New System.Drawing.Point(713, 171)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(84, 23)
        Me.lbltotal.TabIndex = 43
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbluitmonto
        '
        Me.lbluitmonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbluitmonto.Location = New System.Drawing.Point(734, 8)
        Me.lbluitmonto.Name = "lbluitmonto"
        Me.lbluitmonto.Size = New System.Drawing.Size(66, 34)
        Me.lbluitmonto.TabIndex = 41
        Me.lbluitmonto.Text = "Valor"
        Me.lbluitmonto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtuitmonto
        '
        Me.txtuitmonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtuitmonto.BackColor = System.Drawing.Color.Orange
        Me.txtuitmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuitmonto.Location = New System.Drawing.Point(731, 45)
        Me.txtuitmonto.Name = "txtuitmonto"
        Me.txtuitmonto.Size = New System.Drawing.Size(66, 20)
        Me.txtuitmonto.TabIndex = 42
        Me.txtuitmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lvwdetalle_venta
        '
        Me.Lvwdetalle_venta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lvwdetalle_venta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codi, Me.Des, Me.PrecAc, Me.Cant, Me.Subt, Me.tipo, Me.uitx, Me.cuent, Me.prcio})
        Me.Lvwdetalle_venta.FullRowSelect = True
        Me.Lvwdetalle_venta.GridLines = True
        Me.Lvwdetalle_venta.HideSelection = False
        Me.Lvwdetalle_venta.Location = New System.Drawing.Point(8, 67)
        Me.Lvwdetalle_venta.Name = "Lvwdetalle_venta"
        Me.Lvwdetalle_venta.Size = New System.Drawing.Size(789, 103)
        Me.Lvwdetalle_venta.TabIndex = 38
        Me.Lvwdetalle_venta.UseCompatibleStateImageBehavior = False
        Me.Lvwdetalle_venta.View = System.Windows.Forms.View.Details
        '
        'Codi
        '
        Me.Codi.Text = "Código"
        '
        'Des
        '
        Me.Des.Text = "Descripción"
        Me.Des.Width = 219
        '
        'PrecAc
        '
        Me.PrecAc.Text = "Precio"
        Me.PrecAc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrecAc.Width = 58
        '
        'Cant
        '
        Me.Cant.Text = "Cant."
        Me.Cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Cant.Width = 67
        '
        'Subt
        '
        Me.Subt.Text = "Subtotal"
        Me.Subt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Subt.Width = 90
        '
        'tipo
        '
        Me.tipo.Text = "tipo"
        Me.tipo.Width = 0
        '
        'uitx
        '
        Me.uitx.Text = "uit"
        Me.uitx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.uitx.Width = 0
        '
        'cuent
        '
        Me.cuent.Text = "Cuenta"
        Me.cuent.Width = 0
        '
        'prcio
        '
        Me.prcio.Text = "precio"
        Me.prcio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.prcio.Width = 0
        '
        'txtcantidad
        '
        Me.txtcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcantidad.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtcantidad.Enabled = False
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(678, 45)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(47, 20)
        Me.txtcantidad.TabIndex = 37
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblpreciounitario
        '
        Me.lblpreciounitario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblpreciounitario.BackColor = System.Drawing.Color.LightGray
        Me.lblpreciounitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpreciounitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreciounitario.Location = New System.Drawing.Point(515, 42)
        Me.lblpreciounitario.Name = "lblpreciounitario"
        Me.lblpreciounitario.Size = New System.Drawing.Size(63, 23)
        Me.lblpreciounitario.TabIndex = 35
        Me.lblpreciounitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Código"
        '
        'lblcodservicio
        '
        Me.lblcodservicio.BackColor = System.Drawing.Color.LightGray
        Me.lblcodservicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodservicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodservicio.Location = New System.Drawing.Point(8, 42)
        Me.lblcodservicio.Name = "lblcodservicio"
        Me.lblcodservicio.Size = New System.Drawing.Size(81, 23)
        Me.lblcodservicio.TabIndex = 29
        Me.lblcodservicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Descripción"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldescripcion.BackColor = System.Drawing.Color.LightGray
        Me.lbldescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion.Location = New System.Drawing.Point(95, 42)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(414, 23)
        Me.lbldescripcion.TabIndex = 30
        Me.lbldescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(518, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Precio_unit."
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(679, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Cantidad"
        '
        'lbltiposervicio
        '
        Me.lbltiposervicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltiposervicio.Location = New System.Drawing.Point(229, 19)
        Me.lbltiposervicio.Name = "lbltiposervicio"
        Me.lbltiposervicio.Size = New System.Drawing.Size(38, 16)
        Me.lbltiposervicio.TabIndex = 36
        Me.lbltiposervicio.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.lblcodigo_cli)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblruc)
        Me.GroupBox2.Controls.Add(Me.lblnombre_cliente)
        Me.GroupBox2.Controls.Add(Me.lbldni)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox2.Location = New System.Drawing.Point(337, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 121)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Cliente"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Image = Global.GUIRentas.My.Resources.Resources._30
        Me.btnBuscar.Location = New System.Drawing.Point(218, 38)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 64)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblcodigo_cli
        '
        Me.lblcodigo_cli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcodigo_cli.Location = New System.Drawing.Point(221, 102)
        Me.lblcodigo_cli.Name = "lblcodigo_cli"
        Me.lblcodigo_cli.Size = New System.Drawing.Size(29, 11)
        Me.lblcodigo_cli.TabIndex = 7
        Me.lblcodigo_cli.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(7, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cliente"
        '
        'lblruc
        '
        Me.lblruc.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblruc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblruc.Location = New System.Drawing.Point(150, 79)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(146, 23)
        Me.lblruc.TabIndex = 5
        Me.lblruc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblnombre_cliente
        '
        Me.lblnombre_cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnombre_cliente.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblnombre_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnombre_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre_cliente.Location = New System.Drawing.Point(10, 38)
        Me.lblnombre_cliente.Name = "lblnombre_cliente"
        Me.lblnombre_cliente.Size = New System.Drawing.Size(196, 23)
        Me.lblnombre_cliente.TabIndex = 1
        Me.lblnombre_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldni
        '
        Me.lbldni.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lbldni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldni.Location = New System.Drawing.Point(9, 79)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(121, 23)
        Me.lbldni.TabIndex = 4
        Me.lbldni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(6, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "D.N.I."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(147, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "RUC"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtclase)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lvwclase)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbogrupo)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(946, 204)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Servicios a prestar"
        '
        'txtclase
        '
        Me.txtclase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtclase.BackColor = System.Drawing.Color.White
        Me.txtclase.Enabled = False
        Me.txtclase.Location = New System.Drawing.Point(340, 35)
        Me.txtclase.Name = "txtclase"
        Me.txtclase.Size = New System.Drawing.Size(600, 20)
        Me.txtclase.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Servicio"
        '
        'lvwclase
        '
        Me.lvwclase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwclase.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cod, Me.desc, Me.valor, Me.codx, Me.cuenta, Me.porc})
        Me.lvwclase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwclase.FullRowSelect = True
        Me.lvwclase.Location = New System.Drawing.Point(8, 61)
        Me.lvwclase.MultiSelect = False
        Me.lvwclase.Name = "lvwclase"
        Me.lvwclase.Size = New System.Drawing.Size(932, 137)
        Me.lvwclase.TabIndex = 75
        Me.lvwclase.UseCompatibleStateImageBehavior = False
        Me.lvwclase.View = System.Windows.Forms.View.Details
        '
        'cod
        '
        Me.cod.Text = "Codigo"
        Me.cod.Width = 101
        '
        'desc
        '
        Me.desc.Text = "Descripcion"
        Me.desc.Width = 688
        '
        'valor
        '
        Me.valor.Text = "Valor"
        Me.valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.valor.Width = 77
        '
        'codx
        '
        Me.codx.Text = "Codx"
        Me.codx.Width = 0
        '
        'cuenta
        '
        Me.cuenta.Text = "Cuenta"
        Me.cuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cuenta.Width = 0
        '
        'porc
        '
        Me.porc.Text = "Porc"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Seleccionar Division"
        '
        'cbogrupo
        '
        Me.cbogrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbogrupo.Enabled = False
        Me.cbogrupo.FormattingEnabled = True
        Me.cbogrupo.Location = New System.Drawing.Point(8, 34)
        Me.cbogrupo.Name = "cbogrupo"
        Me.cbogrupo.Size = New System.Drawing.Size(326, 21)
        Me.cbogrupo.TabIndex = 76
        '
        'GrpVenta
        '
        Me.GrpVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpVenta.BackColor = System.Drawing.Color.White
        Me.GrpVenta.Controls.Add(Me.Label12)
        Me.GrpVenta.Controls.Add(Me.lblcod_venta)
        Me.GrpVenta.Controls.Add(Me.Label14)
        Me.GrpVenta.Controls.Add(Me.cboformapago)
        Me.GrpVenta.Location = New System.Drawing.Point(650, 5)
        Me.GrpVenta.Name = "GrpVenta"
        Me.GrpVenta.Size = New System.Drawing.Size(307, 121)
        Me.GrpVenta.TabIndex = 16
        Me.GrpVenta.TabStop = False
        Me.GrpVenta.Text = "Datos de la venta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(231, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Recibo N°"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcod_venta
        '
        Me.lblcod_venta.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblcod_venta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcod_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcod_venta.Location = New System.Drawing.Point(177, 38)
        Me.lblcod_venta.Name = "lblcod_venta"
        Me.lblcod_venta.Size = New System.Drawing.Size(110, 23)
        Me.lblcod_venta.TabIndex = 38
        Me.lblcod_venta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(35, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Forma de Pago" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cboformapago
        '
        Me.cboformapago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboformapago.Enabled = False
        Me.cboformapago.FormattingEnabled = True
        Me.cboformapago.Location = New System.Drawing.Point(38, 84)
        Me.cboformapago.Name = "cboformapago"
        Me.cboformapago.Size = New System.Drawing.Size(249, 21)
        Me.cboformapago.TabIndex = 40
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUIRentas.My.Resources.Resources.SRM
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'FrmRealizaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 544)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GrpVenta)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmRealizaVenta"
        Me.Text = "Servicios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpVenta.ResumeLayout(False)
        Me.GrpVenta.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregaItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRemoveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEditaItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LBLCODCTA As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lbluitmonto As System.Windows.Forms.Label
    Friend WithEvents txtuitmonto As System.Windows.Forms.TextBox
    Friend WithEvents Lvwdetalle_venta As System.Windows.Forms.ListView
    Friend WithEvents Codi As System.Windows.Forms.ColumnHeader
    Friend WithEvents Des As System.Windows.Forms.ColumnHeader
    Friend WithEvents PrecAc As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cant As System.Windows.Forms.ColumnHeader
    Friend WithEvents Subt As System.Windows.Forms.ColumnHeader
    Friend WithEvents tipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents uitx As System.Windows.Forms.ColumnHeader
    Friend WithEvents cuent As System.Windows.Forms.ColumnHeader
    Friend WithEvents prcio As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblpreciounitario As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblcodservicio As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbltiposervicio As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcodigo_cli As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblruc As System.Windows.Forms.Label
    Friend WithEvents lblnombre_cliente As System.Windows.Forms.Label
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtclase As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lvwclase As System.Windows.Forms.ListView
    Friend WithEvents cod As System.Windows.Forms.ColumnHeader
    Friend WithEvents desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents valor As System.Windows.Forms.ColumnHeader
    Friend WithEvents codx As System.Windows.Forms.ColumnHeader
    Friend WithEvents cuenta As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbogrupo As System.Windows.Forms.ComboBox
    Friend WithEvents GrpVenta As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblcod_venta As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboformapago As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents porc As System.Windows.Forms.ColumnHeader
End Class
