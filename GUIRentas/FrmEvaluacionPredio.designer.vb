<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEvaluacionPredio
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
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.lblcodigocliente = New System.Windows.Forms.Label
        Me.lblruc = New System.Windows.Forms.Label
        Me.lbldni = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cmbdenominacion = New System.Windows.Forms.ComboBox
        Me.lvwCategoria = New System.Windows.Forms.ListView
        Me.cod = New System.Windows.Forms.ColumnHeader
        Me.Cate = New System.Windows.Forms.ColumnHeader
        Me.Des = New System.Windows.Forms.ColumnHeader
        Me.Val = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwasisgnacion = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.lbldepre = New System.Windows.Forms.Label
        Me.cmbMaterial = New System.Windows.Forms.ComboBox
        Me.cmbConservacion = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblantiguedad = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblte = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtarea = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblarea = New System.Windows.Forms.Label
        Me.lbldireccion = New System.Windows.Forms.Label
        Me.lblcodpredio = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblannio = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lvwpredios = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.lblSumaCat = New System.Windows.Forms.Label
        Me.btnSeleccionar = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtinstalacion = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtvalorsoles = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.lvwInstalaciones = New System.Windows.Forms.ListView
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.btnai = New System.Windows.Forms.Button
        Me.btnqi = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.lblcodigocliente)
        Me.GroupBox1.Controls.Add(Me.lblruc)
        Me.GroupBox1.Controls.Add(Me.lbldni)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 77)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Contribuyente"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.GUIRentas.My.Resources.Resources._30
        Me.btnBuscar.Location = New System.Drawing.Point(365, 18)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 48)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblcodigocliente
        '
        Me.lblcodigocliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigocliente.Location = New System.Drawing.Point(19, 78)
        Me.lblcodigocliente.Name = "lblcodigocliente"
        Me.lblcodigocliente.Size = New System.Drawing.Size(93, 18)
        Me.lblcodigocliente.TabIndex = 7
        '
        'lblruc
        '
        Me.lblruc.BackColor = System.Drawing.Color.LightBlue
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblruc.Location = New System.Drawing.Point(233, 49)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(98, 20)
        Me.lblruc.TabIndex = 5
        '
        'lbldni
        '
        Me.lbldni.BackColor = System.Drawing.Color.LightBlue
        Me.lbldni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldni.Location = New System.Drawing.Point(85, 49)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(86, 20)
        Me.lbldni.TabIndex = 4
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.Color.LightBlue
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescripcion.Location = New System.Drawing.Point(85, 23)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(274, 20)
        Me.lblDescripcion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "R.U.C."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 49)
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
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion"
        '
        'Cmbdenominacion
        '
        Me.Cmbdenominacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbdenominacion.FormattingEnabled = True
        Me.Cmbdenominacion.Location = New System.Drawing.Point(7, 19)
        Me.Cmbdenominacion.Name = "Cmbdenominacion"
        Me.Cmbdenominacion.Size = New System.Drawing.Size(444, 21)
        Me.Cmbdenominacion.TabIndex = 5
        '
        'lvwCategoria
        '
        Me.lvwCategoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCategoria.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cod, Me.Cate, Me.Des, Me.Val})
        Me.lvwCategoria.FullRowSelect = True
        Me.lvwCategoria.GridLines = True
        Me.lvwCategoria.Location = New System.Drawing.Point(7, 46)
        Me.lvwCategoria.MultiSelect = False
        Me.lvwCategoria.Name = "lvwCategoria"
        Me.lvwCategoria.Size = New System.Drawing.Size(444, 240)
        Me.lvwCategoria.TabIndex = 6
        Me.lvwCategoria.UseCompatibleStateImageBehavior = False
        Me.lvwCategoria.View = System.Windows.Forms.View.Details
        '
        'cod
        '
        Me.cod.Text = "Codigo"
        Me.cod.Width = 47
        '
        'Cate
        '
        Me.Cate.Text = "Categoria"
        '
        'Des
        '
        Me.Des.Text = "Descripción"
        Me.Des.Width = 336
        '
        'Val
        '
        Me.Val.Text = "Valor"
        Me.Val.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Val.Width = 90
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Cmbdenominacion)
        Me.GroupBox2.Controls.Add(Me.lvwCategoria)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 293)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Categorias"
        '
        'lvwasisgnacion
        '
        Me.lvwasisgnacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwasisgnacion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvwasisgnacion.FullRowSelect = True
        Me.lvwasisgnacion.Location = New System.Drawing.Point(11, 129)
        Me.lvwasisgnacion.MultiSelect = False
        Me.lvwasisgnacion.Name = "lvwasisgnacion"
        Me.lvwasisgnacion.Size = New System.Drawing.Size(465, 161)
        Me.lvwasisgnacion.TabIndex = 7
        Me.lvwasisgnacion.UseCompatibleStateImageBehavior = False
        Me.lvwasisgnacion.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Predio"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "["
        Me.ColumnHeader10.Width = 34
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "]"
        Me.ColumnHeader11.Width = 34
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Valor"
        Me.ColumnHeader12.Width = 58
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Deprec."
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Valor Deprec."
        Me.ColumnHeader6.Width = 78
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Area m2"
        Me.ColumnHeader7.Width = 52
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Valor Constr."
        Me.ColumnHeader8.Width = 74
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.lblSumaCat)
        Me.GroupBox3.Controls.Add(Me.lbldepre)
        Me.GroupBox3.Controls.Add(Me.cmbMaterial)
        Me.GroupBox3.Controls.Add(Me.cmbConservacion)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblantiguedad)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lblte)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtarea)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lblarea)
        Me.GroupBox3.Controls.Add(Me.lbldireccion)
        Me.GroupBox3.Controls.Add(Me.lblcodpredio)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lvwasisgnacion)
        Me.GroupBox3.Controls.Add(Me.lblannio)
        Me.GroupBox3.Location = New System.Drawing.Point(537, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(479, 319)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(448, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Años"
        '
        'lbldepre
        '
        Me.lbldepre.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lbldepre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldepre.Location = New System.Drawing.Point(291, 100)
        Me.lbldepre.Name = "lbldepre"
        Me.lbldepre.Size = New System.Drawing.Size(50, 20)
        Me.lbldepre.TabIndex = 34
        '
        'cmbMaterial
        '
        Me.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaterial.FormattingEnabled = True
        Me.cmbMaterial.Location = New System.Drawing.Point(306, 71)
        Me.cmbMaterial.Name = "cmbMaterial"
        Me.cmbMaterial.Size = New System.Drawing.Size(151, 21)
        Me.cmbMaterial.TabIndex = 33
        '
        'cmbConservacion
        '
        Me.cmbConservacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConservacion.FormattingEnabled = True
        Me.cmbConservacion.Location = New System.Drawing.Point(78, 71)
        Me.cmbConservacion.Name = "cmbConservacion"
        Me.cmbConservacion.Size = New System.Drawing.Size(150, 21)
        Me.cmbConservacion.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(253, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Material"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(244, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "% Depr."
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 12)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Estado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(348, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Antiguedad"
        '
        'lblantiguedad
        '
        Me.lblantiguedad.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblantiguedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblantiguedad.Location = New System.Drawing.Point(415, 46)
        Me.lblantiguedad.Name = "lblantiguedad"
        Me.lblantiguedad.Size = New System.Drawing.Size(27, 20)
        Me.lblantiguedad.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(348, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Tipo Edif."
        '
        'lblte
        '
        Me.lblte.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblte.Location = New System.Drawing.Point(406, 16)
        Me.lblte.Name = "lblte"
        Me.lblte.Size = New System.Drawing.Size(65, 20)
        Me.lblte.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(209, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "(m2)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 26)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Ingrese área " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a evaluar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtarea
        '
        Me.txtarea.Location = New System.Drawing.Point(80, 100)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(123, 20)
        Me.txtarea.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(312, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "(m2)"
        '
        'lblarea
        '
        Me.lblarea.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblarea.Location = New System.Drawing.Point(209, 14)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(87, 20)
        Me.lblarea.TabIndex = 12
        Me.lblarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldireccion
        '
        Me.lbldireccion.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lbldireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldireccion.Location = New System.Drawing.Point(78, 42)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(267, 20)
        Me.lbldireccion.TabIndex = 11
        '
        'lblcodpredio
        '
        Me.lblcodpredio.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblcodpredio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodpredio.Location = New System.Drawing.Point(79, 12)
        Me.lblcodpredio.Name = "lblcodpredio"
        Me.lblcodpredio.Size = New System.Drawing.Size(85, 20)
        Me.lblcodpredio.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(174, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Área"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Predio"
        '
        'lblannio
        '
        Me.lblannio.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblannio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblannio.Location = New System.Drawing.Point(328, 42)
        Me.lblannio.Name = "lblannio"
        Me.lblannio.Size = New System.Drawing.Size(11, 20)
        Me.lblannio.TabIndex = 21
        Me.lblannio.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lvwpredios)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(475, 115)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Predios del Contribuyente"
        '
        'lvwpredios
        '
        Me.lvwpredios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader13})
        Me.lvwpredios.FullRowSelect = True
        Me.lvwpredios.GridLines = True
        Me.lvwpredios.Location = New System.Drawing.Point(8, 16)
        Me.lvwpredios.MultiSelect = False
        Me.lvwpredios.Name = "lvwpredios"
        Me.lvwpredios.Size = New System.Drawing.Size(457, 94)
        Me.lvwpredios.TabIndex = 5
        Me.lvwpredios.UseCompatibleStateImageBehavior = False
        Me.lvwpredios.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cod Predio"
        Me.ColumnHeader1.Width = 78
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Dirección"
        Me.ColumnHeader2.Width = 294
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Área"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 92
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Antig."
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 68
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "TipoEdif"
        '
        'lblSumaCat
        '
        Me.lblSumaCat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSumaCat.BackColor = System.Drawing.Color.SteelBlue
        Me.lblSumaCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumaCat.ForeColor = System.Drawing.Color.White
        Me.lblSumaCat.Location = New System.Drawing.Point(373, 293)
        Me.lblSumaCat.Name = "lblSumaCat"
        Me.lblSumaCat.Size = New System.Drawing.Size(100, 23)
        Me.lblSumaCat.TabIndex = 18
        Me.lblSumaCat.Text = "0.00"
        Me.lblSumaCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Image = Global.GUIRentas.My.Resources.Resources._72b
        Me.btnSeleccionar.Location = New System.Drawing.Point(491, 143)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(38, 35)
        Me.btnSeleccionar.TabIndex = 20
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Image = Global.GUIRentas.My.Resources.Resources.b_109
        Me.btnRemove.Location = New System.Drawing.Point(492, 294)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(38, 35)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Image = Global.GUIRentas.My.Resources.Resources._41
        Me.btnAdd.Location = New System.Drawing.Point(492, 253)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(38, 35)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.Image = Global.GUIRentas.My.Resources.Resources._87
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.Location = New System.Drawing.Point(857, 472)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(91, 37)
        Me.btnsalir.TabIndex = 15
        Me.btnsalir.Text = "&Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.Image = Global.GUIRentas.My.Resources.Resources._36b
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(736, 472)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(115, 37)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btngrabar
        '
        Me.btngrabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btngrabar.Image = Global.GUIRentas.My.Resources.Resources._21
        Me.btngrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngrabar.Location = New System.Drawing.Point(621, 472)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(109, 37)
        Me.btngrabar.TabIndex = 13
        Me.btngrabar.Text = "&Grabar"
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnqi)
        Me.GroupBox5.Controls.Add(Me.btnai)
        Me.GroupBox5.Controls.Add(Me.lvwInstalaciones)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txtvalorsoles)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txtinstalacion)
        Me.GroupBox5.Location = New System.Drawing.Point(537, 339)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(479, 127)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Otras Instalaciones"
        '
        'txtinstalacion
        '
        Me.txtinstalacion.Location = New System.Drawing.Point(81, 19)
        Me.txtinstalacion.Name = "txtinstalacion"
        Me.txtinstalacion.Size = New System.Drawing.Size(233, 20)
        Me.txtinstalacion.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Instalación"
        '
        'txtvalorsoles
        '
        Me.txtvalorsoles.Location = New System.Drawing.Point(385, 19)
        Me.txtvalorsoles.Name = "txtvalorsoles"
        Me.txtvalorsoles.Size = New System.Drawing.Size(94, 20)
        Me.txtvalorsoles.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(317, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 26)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Valor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Estimado S/." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lvwInstalaciones
        '
        Me.lvwInstalaciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.lvwInstalaciones.FullRowSelect = True
        Me.lvwInstalaciones.GridLines = True
        Me.lvwInstalaciones.HideSelection = False
        Me.lvwInstalaciones.Location = New System.Drawing.Point(22, 47)
        Me.lvwInstalaciones.Name = "lvwInstalaciones"
        Me.lvwInstalaciones.Size = New System.Drawing.Size(343, 74)
        Me.lvwInstalaciones.TabIndex = 4
        Me.lvwInstalaciones.UseCompatibleStateImageBehavior = False
        Me.lvwInstalaciones.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Predio"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Instalación"
        Me.ColumnHeader15.Width = 151
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Valor"
        Me.ColumnHeader16.Width = 124
        '
        'btnai
        '
        Me.btnai.Location = New System.Drawing.Point(382, 64)
        Me.btnai.Name = "btnai"
        Me.btnai.Size = New System.Drawing.Size(75, 23)
        Me.btnai.TabIndex = 5
        Me.btnai.Text = "Agregar"
        Me.btnai.UseVisualStyleBackColor = True
        '
        'btnqi
        '
        Me.btnqi.Location = New System.Drawing.Point(382, 98)
        Me.btnqi.Name = "btnqi"
        Me.btnqi.Size = New System.Drawing.Size(75, 23)
        Me.btnqi.TabIndex = 6
        Me.btnqi.Text = "Quitar"
        Me.btnqi.UseVisualStyleBackColor = True
        '
        'FrmEvaluacionPredio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 517)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmEvaluacionPredio"
        Me.Text = "Evaluacion de Predio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcodigocliente As System.Windows.Forms.Label
    Friend WithEvents lblruc As System.Windows.Forms.Label
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cmbdenominacion As System.Windows.Forms.ComboBox
    Friend WithEvents lvwCategoria As System.Windows.Forms.ListView
    Friend WithEvents cod As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Des As System.Windows.Forms.ColumnHeader
    Friend WithEvents Val As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwasisgnacion As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblarea As System.Windows.Forms.Label
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents lblcodpredio As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwpredios As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lblSumaCat As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents lblannio As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblte As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblantiguedad As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbConservacion As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMaterial As System.Windows.Forms.ComboBox
    Friend WithEvents lbldepre As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwInstalaciones As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtvalorsoles As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtinstalacion As System.Windows.Forms.TextBox
    Friend WithEvents btnqi As System.Windows.Forms.Button
    Friend WithEvents btnai As System.Windows.Forms.Button
End Class
