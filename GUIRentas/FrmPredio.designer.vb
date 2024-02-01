<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPredio
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtareatotal = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.nudPisos = New System.Windows.Forms.NumericUpDown
        Me.chkEstado = New System.Windows.Forms.CheckBox
        Me.cmbCondicion = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmbZona = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbConservacion = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbMaterial = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblcodpredio = New System.Windows.Forms.Label
        Me.cmbTipoConstruccion = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbSituacion = New System.Windows.Forms.ComboBox
        Me.txtarea = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.DtfechaAdq = New System.Windows.Forms.DateTimePicker
        Me.dtFechaConst = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtlote = New System.Windows.Forms.TextBox
        Me.txtmanzana = New System.Windows.Forms.TextBox
        Me.txtnumero = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.cmbDireccion = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.lblcodigocliente = New System.Windows.Forms.Label
        Me.lblruc = New System.Windows.Forms.Label
        Me.lbldni = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DgvPredios = New System.Windows.Forms.DataGridView
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btneliminar = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudPisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvPredios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(7, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(625, 391)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(617, 365)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos del Predio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtareatotal)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.nudPisos)
        Me.GroupBox2.Controls.Add(Me.chkEstado)
        Me.GroupBox2.Controls.Add(Me.cmbCondicion)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cmbZona)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cmbConservacion)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cmbMaterial)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblcodpredio)
        Me.GroupBox2.Controls.Add(Me.cmbTipoConstruccion)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cmbSituacion)
        Me.GroupBox2.Controls.Add(Me.txtarea)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.DtfechaAdq)
        Me.GroupBox2.Controls.Add(Me.dtFechaConst)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtlote)
        Me.GroupBox2.Controls.Add(Me.txtmanzana)
        Me.GroupBox2.Controls.Add(Me.txtnumero)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtdireccion)
        Me.GroupBox2.Controls.Add(Me.cmbDireccion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(602, 263)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Predio"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(333, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Área Total (m2)"
        '
        'txtareatotal
        '
        Me.txtareatotal.Location = New System.Drawing.Point(336, 108)
        Me.txtareatotal.Name = "txtareatotal"
        Me.txtareatotal.Size = New System.Drawing.Size(107, 20)
        Me.txtareatotal.TabIndex = 32
        Me.txtareatotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(137, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Direccion del Contribuyente"
        '
        'nudPisos
        '
        Me.nudPisos.Location = New System.Drawing.Point(59, 231)
        Me.nudPisos.Name = "nudPisos"
        Me.nudPisos.Size = New System.Drawing.Size(76, 20)
        Me.nudPisos.TabIndex = 30
        Me.nudPisos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudPisos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkEstado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEstado.Location = New System.Drawing.Point(344, 238)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(235, 17)
        Me.chkEstado.TabIndex = 29
        Me.chkEstado.Text = "El Predio actual se considera como Principal"
        Me.chkEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEstado.UseVisualStyleBackColor = False
        '
        'cmbCondicion
        '
        Me.cmbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondicion.FormattingEnabled = True
        Me.cmbCondicion.Location = New System.Drawing.Point(429, 153)
        Me.cmbCondicion.Name = "cmbCondicion"
        Me.cmbCondicion.Size = New System.Drawing.Size(150, 21)
        Me.cmbCondicion.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(429, 137)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Cond. Propiedad"
        '
        'cmbZona
        '
        Me.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbZona.FormattingEnabled = True
        Me.cmbZona.Location = New System.Drawing.Point(9, 153)
        Me.cmbZona.Name = "cmbZona"
        Me.cmbZona.Size = New System.Drawing.Size(126, 21)
        Me.cmbZona.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 137)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Zona"
        '
        'cmbConservacion
        '
        Me.cmbConservacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConservacion.FormattingEnabled = True
        Me.cmbConservacion.Location = New System.Drawing.Point(429, 199)
        Me.cmbConservacion.Name = "cmbConservacion"
        Me.cmbConservacion.Size = New System.Drawing.Size(150, 21)
        Me.cmbConservacion.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(426, 182)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Est. Conservacion"
        '
        'cmbMaterial
        '
        Me.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaterial.FormattingEnabled = True
        Me.cmbMaterial.Location = New System.Drawing.Point(9, 199)
        Me.cmbMaterial.Name = "cmbMaterial"
        Me.cmbMaterial.Size = New System.Drawing.Size(126, 21)
        Me.cmbMaterial.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Tipo Material"
        '
        'lblcodpredio
        '
        Me.lblcodpredio.BackColor = System.Drawing.Color.LightGray
        Me.lblcodpredio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodpredio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodpredio.Location = New System.Drawing.Point(450, 14)
        Me.lblcodpredio.Name = "lblcodpredio"
        Me.lblcodpredio.Size = New System.Drawing.Size(129, 20)
        Me.lblcodpredio.TabIndex = 8
        Me.lblcodpredio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTipoConstruccion
        '
        Me.cmbTipoConstruccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoConstruccion.FormattingEnabled = True
        Me.cmbTipoConstruccion.Location = New System.Drawing.Point(159, 199)
        Me.cmbTipoConstruccion.Name = "cmbTipoConstruccion"
        Me.cmbTipoConstruccion.Size = New System.Drawing.Size(253, 21)
        Me.cmbTipoConstruccion.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(156, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Tipo Construcción"
        '
        'cmbSituacion
        '
        Me.cmbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSituacion.FormattingEnabled = True
        Me.cmbSituacion.Items.AddRange(New Object() {"EN CONSTRUCCION", "TREMINADA", "EN RUINAS", "TERRENO SIN CONSTRUIR"})
        Me.cmbSituacion.Location = New System.Drawing.Point(159, 153)
        Me.cmbSituacion.Name = "cmbSituacion"
        Me.cmbSituacion.Size = New System.Drawing.Size(253, 21)
        Me.cmbSituacion.TabIndex = 18
        '
        'txtarea
        '
        Me.txtarea.Location = New System.Drawing.Point(449, 106)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(130, 20)
        Me.txtarea.TabIndex = 17
        Me.txtarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(159, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Situación"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(446, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Área Construida (m2)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Nª Pisos"
        '
        'DtfechaAdq
        '
        Me.DtfechaAdq.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtfechaAdq.Location = New System.Drawing.Point(9, 108)
        Me.DtfechaAdq.Name = "DtfechaAdq"
        Me.DtfechaAdq.Size = New System.Drawing.Size(126, 20)
        Me.DtfechaAdq.TabIndex = 12
        '
        'dtFechaConst
        '
        Me.dtFechaConst.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaConst.Location = New System.Drawing.Point(159, 108)
        Me.dtFechaConst.Name = "dtFechaConst"
        Me.dtFechaConst.Size = New System.Drawing.Size(150, 20)
        Me.dtFechaConst.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Fecha de Adquisición"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(156, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Fecha Construcción"
        '
        'txtlote
        '
        Me.txtlote.Location = New System.Drawing.Point(540, 56)
        Me.txtlote.MaxLength = 4
        Me.txtlote.Name = "txtlote"
        Me.txtlote.Size = New System.Drawing.Size(39, 20)
        Me.txtlote.TabIndex = 8
        Me.txtlote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmanzana
        '
        Me.txtmanzana.Location = New System.Drawing.Point(499, 56)
        Me.txtmanzana.MaxLength = 4
        Me.txtmanzana.Name = "txtmanzana"
        Me.txtmanzana.Size = New System.Drawing.Size(35, 20)
        Me.txtmanzana.TabIndex = 7
        Me.txtmanzana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(449, 56)
        Me.txtnumero.MaxLength = 5
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(42, 20)
        Me.txtnumero.TabIndex = 6
        Me.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(537, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Lote"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(85, 56)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(358, 20)
        Me.txtdireccion.TabIndex = 4
        '
        'cmbDireccion
        '
        Me.cmbDireccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDireccion.FormattingEnabled = True
        Me.cmbDireccion.Items.AddRange(New Object() {"AV.", "CALLE.", "JR.", "PSJE.", "TRANSV."})
        Me.cmbDireccion.Location = New System.Drawing.Point(12, 55)
        Me.cmbDireccion.Name = "cmbDireccion"
        Me.cmbDireccion.Size = New System.Drawing.Size(67, 21)
        Me.cmbDireccion.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(501, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Mza."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(447, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Número"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.lblcodigocliente)
        Me.GroupBox1.Controls.Add(Me.lblruc)
        Me.GroupBox1.Controls.Add(Me.lbldni)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 85)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Contribuyente"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Codigo"
        '
        'btnBuscar
        '
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Image = Global.GUIRentas.My.Resources.Resources._30
        Me.btnBuscar.Location = New System.Drawing.Point(501, 24)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 46)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblcodigocliente
        '
        Me.lblcodigocliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigocliente.Location = New System.Drawing.Point(85, 52)
        Me.lblcodigocliente.Name = "lblcodigocliente"
        Me.lblcodigocliente.Size = New System.Drawing.Size(93, 18)
        Me.lblcodigocliente.TabIndex = 7
        '
        'lblruc
        '
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblruc.Location = New System.Drawing.Point(393, 50)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(98, 20)
        Me.lblruc.TabIndex = 5
        '
        'lbldni
        '
        Me.lbldni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldni.Location = New System.Drawing.Point(247, 50)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(86, 20)
        Me.lbldni.TabIndex = 4
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescripcion.Location = New System.Drawing.Point(85, 23)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(406, 20)
        Me.lblDescripcion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "R.U.C."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "D.N.I."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DgvPredios)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(617, 365)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Predios Declarados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DgvPredios
        '
        Me.DgvPredios.AllowUserToAddRows = False
        Me.DgvPredios.AllowUserToDeleteRows = False
        Me.DgvPredios.AllowUserToOrderColumns = True
        Me.DgvPredios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPredios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPredios.Location = New System.Drawing.Point(3, 3)
        Me.DgvPredios.Name = "DgvPredios"
        Me.DgvPredios.ReadOnly = True
        Me.DgvPredios.Size = New System.Drawing.Size(611, 359)
        Me.DgvPredios.TabIndex = 0
        '
        'btnGrabar
        '
        Me.btnGrabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGrabar.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.ForeColor = System.Drawing.Color.Black
        Me.btnGrabar.Image = Global.GUIRentas.My.Resources.Resources._15
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabar.Location = New System.Drawing.Point(331, 406)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(96, 26)
        Me.btnGrabar.TabIndex = 59
        Me.btnGrabar.Text = "&Actualizar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = Global.GUIRentas.My.Resources.Resources._28
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(433, 406)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 26)
        Me.btnCancelar.TabIndex = 58
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
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
        Me.btnNuevo.Location = New System.Drawing.Point(133, 406)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 26)
        Me.btnNuevo.TabIndex = 56
        Me.btnNuevo.Text = "&Agregar"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = Global.GUIRentas.My.Resources.Resources._41
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(532, 406)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 26)
        Me.btnSalir.TabIndex = 60
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btneliminar.BackColor = System.Drawing.Color.SaddleBrown
        Me.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen
        Me.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btneliminar.ForeColor = System.Drawing.Color.Black
        Me.btneliminar.Image = Global.GUIRentas.My.Resources.Resources._19s
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.Location = New System.Drawing.Point(232, 406)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(96, 26)
        Me.btneliminar.TabIndex = 61
        Me.btneliminar.Text = "&Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.Location = New System.Drawing.Point(7, 402)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 37)
        Me.ListView1.TabIndex = 62
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CODIGO"
        Me.ColumnHeader1.Width = 104
        '
        'FrmPredio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(639, 438)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmPredio"
        Me.Text = "Declaracion de Predios"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudPisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DgvPredios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTipoConstruccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbSituacion As System.Windows.Forms.ComboBox
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DtfechaAdq As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaConst As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtlote As System.Windows.Forms.TextBox
    Friend WithEvents txtmanzana As System.Windows.Forms.TextBox
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents cmbDireccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcodigocliente As System.Windows.Forms.Label
    Friend WithEvents lblruc As System.Windows.Forms.Label
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DgvPredios As System.Windows.Forms.DataGridView
    Friend WithEvents lblcodpredio As System.Windows.Forms.Label
    Friend WithEvents cmbMaterial As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbConservacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbZona As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbCondicion As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents nudPisos As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtareatotal As System.Windows.Forms.TextBox
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
