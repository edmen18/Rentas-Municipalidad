<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrdenPago
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblcodigocliente = New System.Windows.Forms.Label
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.lblruc = New System.Windows.Forms.Label
        Me.lbldni = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txttasa = New System.Windows.Forms.NumericUpDown
        Me.txtDias = New System.Windows.Forms.NumericUpDown
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnagregar = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpfechaactualizacion = New System.Windows.Forms.DateTimePicker
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DgvTrimestres = New System.Windows.Forms.DataGridView
        Me.btnsalir = New System.Windows.Forms.Button
        Me.lvwDetalle = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lbl60uit = New System.Windows.Forms.Label
        Me.lblmas15uit = New System.Windows.Forms.Label
        Me.lbl15uit = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Lvwdetalles = New System.Windows.Forms.ListView
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblfechadj = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblcoddj = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblorden = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txttasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvTrimestres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblcodigocliente)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.lblruc)
        Me.GroupBox1.Controls.Add(Me.lbldni)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(146, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 77)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Contribuyente"
        '
        'lblcodigocliente
        '
        Me.lblcodigocliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigocliente.Location = New System.Drawing.Point(19, 78)
        Me.lblcodigocliente.Name = "lblcodigocliente"
        Me.lblcodigocliente.Size = New System.Drawing.Size(93, 18)
        Me.lblcodigocliente.TabIndex = 7
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.GUIRentas.My.Resources.Resources._30
        Me.BtnBuscar.Location = New System.Drawing.Point(402, 17)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 53)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'lblruc
        '
        Me.lblruc.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblruc.Location = New System.Drawing.Point(298, 49)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(98, 20)
        Me.lblruc.TabIndex = 5
        '
        'lbldni
        '
        Me.lbldni.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lbldni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldni.Location = New System.Drawing.Point(85, 49)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(86, 20)
        Me.lbldni.TabIndex = 4
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescripcion.Location = New System.Drawing.Point(85, 21)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(311, 20)
        Me.lblDescripcion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(253, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "R.U.C."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "D.N.I."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txttasa)
        Me.GroupBox3.Controls.Add(Me.txtDias)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.btnagregar)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.dtpfechaactualizacion)
        Me.GroupBox3.Location = New System.Drawing.Point(638, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(377, 78)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pagos pendientes"
        '
        'txttasa
        '
        Me.txttasa.DecimalPlaces = 2
        Me.txttasa.Location = New System.Drawing.Point(126, 52)
        Me.txttasa.Name = "txttasa"
        Me.txttasa.Size = New System.Drawing.Size(58, 20)
        Me.txttasa.TabIndex = 33
        Me.txttasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttasa.Value = New Decimal(New Integer() {3, 0, 0, 131072})
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(126, 27)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(58, 20)
        Me.txtDias.TabIndex = 32
        Me.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDias.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(169, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "%"
        '
        'btnagregar
        '
        Me.btnagregar.Image = Global.GUIRentas.My.Resources.Resources._101
        Me.btnagregar.Location = New System.Drawing.Point(296, 19)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 53)
        Me.btnagregar.TabIndex = 30
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Tasa de Interes Diaria"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Plazo (dias)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(207, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Actualización"
        '
        'dtpfechaactualizacion
        '
        Me.dtpfechaactualizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaactualizacion.Location = New System.Drawing.Point(208, 53)
        Me.dtpfechaactualizacion.Name = "dtpfechaactualizacion"
        Me.dtpfechaactualizacion.Size = New System.Drawing.Size(82, 20)
        Me.dtpfechaactualizacion.TabIndex = 18
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.BackColor = System.Drawing.Color.LightBlue
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Location = New System.Drawing.Point(917, 374)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(98, 20)
        Me.lbltotal.TabIndex = 8
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(880, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Total"
        '
        'DgvTrimestres
        '
        Me.DgvTrimestres.AllowUserToAddRows = False
        Me.DgvTrimestres.AllowUserToDeleteRows = False
        Me.DgvTrimestres.AllowUserToOrderColumns = True
        Me.DgvTrimestres.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTrimestres.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvTrimestres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvTrimestres.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvTrimestres.Location = New System.Drawing.Point(10, 112)
        Me.DgvTrimestres.Name = "DgvTrimestres"
        Me.DgvTrimestres.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTrimestres.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvTrimestres.Size = New System.Drawing.Size(1005, 130)
        Me.DgvTrimestres.TabIndex = 14
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.Image = Global.GUIRentas.My.Resources.Resources.Exit_one
        Me.btnsalir.Location = New System.Drawing.Point(921, 400)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(94, 62)
        Me.btnsalir.TabIndex = 21
        Me.btnsalir.Text = "&Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'lvwDetalle
        '
        Me.lvwDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwDetalle.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvwDetalle.FullRowSelect = True
        Me.lvwDetalle.GridLines = True
        Me.lvwDetalle.Location = New System.Drawing.Point(10, 248)
        Me.lvwDetalle.Name = "lvwDetalle"
        Me.lvwDetalle.Size = New System.Drawing.Size(1005, 124)
        Me.lvwDetalle.TabIndex = 29
        Me.lvwDetalle.UseCompatibleStateImageBehavior = False
        Me.lvwDetalle.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Año"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "BaseImponible"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 97
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tramo de Autovaluo"
        Me.ColumnHeader3.Width = 210
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ali Cuota"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 201
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Insolutos"
        Me.ColumnHeader5.Width = 140
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Imp Anual"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 89
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Trimestres"
        Me.ColumnHeader7.Width = 82
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Insoluto"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 87
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Reajuste"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 93
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Interes"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 95
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Total"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 93
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.lbl60uit)
        Me.GroupBox4.Controls.Add(Me.lblmas15uit)
        Me.GroupBox4.Controls.Add(Me.lbl15uit)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Location = New System.Drawing.Point(363, 374)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(226, 88)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Pago"
        '
        'lbl60uit
        '
        Me.lbl60uit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl60uit.Location = New System.Drawing.Point(112, 58)
        Me.lbl60uit.Name = "lbl60uit"
        Me.lbl60uit.Size = New System.Drawing.Size(97, 20)
        Me.lbl60uit.TabIndex = 22
        Me.lbl60uit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblmas15uit
        '
        Me.lblmas15uit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmas15uit.Location = New System.Drawing.Point(112, 37)
        Me.lblmas15uit.Name = "lblmas15uit"
        Me.lblmas15uit.Size = New System.Drawing.Size(97, 20)
        Me.lblmas15uit.TabIndex = 21
        Me.lblmas15uit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl15uit
        '
        Me.lbl15uit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl15uit.Location = New System.Drawing.Point(112, 16)
        Me.lbl15uit.Name = "lbl15uit"
        Me.lbl15uit.Size = New System.Drawing.Size(97, 20)
        Me.lbl15uit.TabIndex = 20
        Me.lbl15uit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 63)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Mas de 60 UIT."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "De 16 a 60 UIT."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "De 1 a 15 UIT."
        '
        'Lvwdetalles
        '
        Me.Lvwdetalles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.Lvwdetalles.Location = New System.Drawing.Point(595, 381)
        Me.Lvwdetalles.Name = "Lvwdetalles"
        Me.Lvwdetalles.Size = New System.Drawing.Size(73, 25)
        Me.Lvwdetalles.TabIndex = 31
        Me.Lvwdetalles.UseCompatibleStateImageBehavior = False
        Me.Lvwdetalles.View = System.Windows.Forms.View.Details
        Me.Lvwdetalles.Visible = False
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Año"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Uit"
        Me.ColumnHeader13.Width = 90
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Reajuste"
        Me.ColumnHeader14.Width = 214
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "T.I.M."
        Me.ColumnHeader15.Width = 162
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lblfechadj)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblcoddj)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblorden)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 374)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 88)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Orden"
        '
        'lblfechadj
        '
        Me.lblfechadj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblfechadj.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblfechadj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblfechadj.Location = New System.Drawing.Point(235, 63)
        Me.lblfechadj.Name = "lblfechadj"
        Me.lblfechadj.Size = New System.Drawing.Size(98, 20)
        Me.lblfechadj.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(178, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "De fecha"
        '
        'lblcoddj
        '
        Me.lblcoddj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcoddj.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblcoddj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcoddj.Location = New System.Drawing.Point(235, 40)
        Me.lblcoddj.Name = "lblcoddj"
        Me.lblcoddj.Size = New System.Drawing.Size(98, 20)
        Me.lblcoddj.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(206, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Actualizacion de la Declaración Jurada Nº"
        '
        'lblorden
        '
        Me.lblorden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblorden.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblorden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblorden.Location = New System.Drawing.Point(235, 16)
        Me.lblorden.Name = "lblorden"
        Me.lblorden.Size = New System.Drawing.Size(98, 20)
        Me.lblorden.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Orden de Pago Nº"
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.Image = Global.GUIRentas.My.Resources.Resources._36b
        Me.btncancelar.Location = New System.Drawing.Point(824, 400)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(94, 62)
        Me.btncancelar.TabIndex = 22
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btngrabar
        '
        Me.btngrabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btngrabar.Image = Global.GUIRentas.My.Resources.Resources._21
        Me.btngrabar.Location = New System.Drawing.Point(727, 400)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(94, 62)
        Me.btngrabar.TabIndex = 20
        Me.btngrabar.Text = "&Grabar"
        Me.btngrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUIRentas.My.Resources.Resources.SRM
        Me.PictureBox1.Location = New System.Drawing.Point(10, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'FrmOrdenPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 471)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Lvwdetalles)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lvwDetalle)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.DgvTrimestres)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmOrdenPago"
        Me.Text = "Orden Pago"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txttasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvTrimestres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcodigocliente As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblruc As System.Windows.Forms.Label
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DgvTrimestres As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaactualizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lvwDetalle As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl60uit As System.Windows.Forms.Label
    Friend WithEvents lblmas15uit As System.Windows.Forms.Label
    Friend WithEvents lbl15uit As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Lvwdetalles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txttasa As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDias As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblfechadj As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblcoddj As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblorden As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
