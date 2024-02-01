<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagos
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DgvTrimestres = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnVerPredios = New System.Windows.Forms.Button
        Me.DgvDj = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblcodigocliente = New System.Windows.Forms.Label
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.lblruc = New System.Windows.Forms.Label
        Me.lbldni = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.lblmonto = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblcodpago = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtfecha = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbltrimestre = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LvwPagos = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.btngrabar = New System.Windows.Forms.Button
        Me.Btnimprimir = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.CmbCuenta = New System.Windows.Forms.ComboBox
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvTrimestres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvDj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DgvTrimestres)
        Me.GroupBox3.Location = New System.Drawing.Point(259, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(435, 160)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Trimestres de Pagos"
        '
        'DgvTrimestres
        '
        Me.DgvTrimestres.AllowUserToAddRows = False
        Me.DgvTrimestres.AllowUserToDeleteRows = False
        Me.DgvTrimestres.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvTrimestres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTrimestres.Location = New System.Drawing.Point(8, 16)
        Me.DgvTrimestres.Name = "DgvTrimestres"
        Me.DgvTrimestres.ReadOnly = True
        Me.DgvTrimestres.Size = New System.Drawing.Size(421, 138)
        Me.DgvTrimestres.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnVerPredios)
        Me.GroupBox2.Controls.Add(Me.DgvDj)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(241, 161)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Declaraciones Juradas"
        '
        'BtnVerPredios
        '
        Me.BtnVerPredios.Image = Global.GUIRentas.My.Resources.Resources._05
        Me.BtnVerPredios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerPredios.Location = New System.Drawing.Point(126, 132)
        Me.BtnVerPredios.Name = "BtnVerPredios"
        Me.BtnVerPredios.Size = New System.Drawing.Size(105, 23)
        Me.BtnVerPredios.TabIndex = 15
        Me.BtnVerPredios.Text = "&Ver Predios"
        Me.BtnVerPredios.UseVisualStyleBackColor = True
        '
        'DgvDj
        '
        Me.DgvDj.AllowUserToAddRows = False
        Me.DgvDj.AllowUserToDeleteRows = False
        Me.DgvDj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDj.Location = New System.Drawing.Point(6, 19)
        Me.DgvDj.Name = "DgvDj"
        Me.DgvDj.ReadOnly = True
        Me.DgvDj.Size = New System.Drawing.Size(225, 107)
        Me.DgvDj.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblcodigocliente)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.lblruc)
        Me.GroupBox1.Controls.Add(Me.lbldni)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 77)
        Me.GroupBox1.TabIndex = 11
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
        Me.BtnBuscar.Location = New System.Drawing.Point(416, 23)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 48)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'lblruc
        '
        Me.lblruc.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblruc.Location = New System.Drawing.Point(312, 48)
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
        Me.lblDescripcion.Location = New System.Drawing.Point(85, 23)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(325, 20)
        Me.lblDescripcion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(267, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "R.U.C."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 55)
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnAgregar)
        Me.GroupBox4.Controls.Add(Me.lblmonto)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.lblcodpago)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.dtfecha)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.lbltrimestre)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 272)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(244, 132)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Pago"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Image = Global.GUIRentas.My.Resources.Resources._72b
        Me.BtnAgregar.Location = New System.Drawing.Point(172, 48)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(66, 46)
        Me.BtnAgregar.TabIndex = 15
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'lblmonto
        '
        Me.lblmonto.BackColor = System.Drawing.Color.PaleGreen
        Me.lblmonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmonto.Location = New System.Drawing.Point(78, 97)
        Me.lblmonto.Name = "lblmonto"
        Me.lblmonto.Size = New System.Drawing.Size(86, 20)
        Me.lblmonto.TabIndex = 14
        Me.lblmonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Monto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblcodpago
        '
        Me.lblcodpago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodpago.Location = New System.Drawing.Point(78, 20)
        Me.lblcodpago.Name = "lblcodpago"
        Me.lblcodpago.Size = New System.Drawing.Size(86, 20)
        Me.lblcodpago.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Codigo pago"
        '
        'dtfecha
        '
        Me.dtfecha.Enabled = False
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(78, 74)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(86, 20)
        Me.dtfecha.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha"
        '
        'lbltrimestre
        '
        Me.lbltrimestre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltrimestre.Location = New System.Drawing.Point(78, 48)
        Me.lbltrimestre.Name = "lbltrimestre"
        Me.lbltrimestre.Size = New System.Drawing.Size(86, 20)
        Me.lbltrimestre.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Trimestre"
        '
        'LvwPagos
        '
        Me.LvwPagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LvwPagos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LvwPagos.FullRowSelect = True
        Me.LvwPagos.Location = New System.Drawing.Point(259, 274)
        Me.LvwPagos.Name = "LvwPagos"
        Me.LvwPagos.Size = New System.Drawing.Size(354, 130)
        Me.LvwPagos.TabIndex = 15
        Me.LvwPagos.UseCompatibleStateImageBehavior = False
        Me.LvwPagos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cod.Pago"
        Me.ColumnHeader1.Width = 119
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Trimestre"
        Me.ColumnHeader2.Width = 127
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Monto"
        Me.ColumnHeader3.Width = 103
        '
        'btngrabar
        '
        Me.btngrabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btngrabar.Enabled = False
        Me.btngrabar.Image = Global.GUIRentas.My.Resources.Resources._21
        Me.btngrabar.Location = New System.Drawing.Point(619, 273)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(75, 61)
        Me.btngrabar.TabIndex = 16
        Me.btngrabar.Text = "Grabar"
        Me.btngrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'Btnimprimir
        '
        Me.Btnimprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnimprimir.Enabled = False
        Me.Btnimprimir.Image = Global.GUIRentas.My.Resources.Resources._20
        Me.Btnimprimir.Location = New System.Drawing.Point(619, 339)
        Me.Btnimprimir.Name = "Btnimprimir"
        Me.Btnimprimir.Size = New System.Drawing.Size(75, 61)
        Me.Btnimprimir.TabIndex = 17
        Me.Btnimprimir.Text = "Imprimir"
        Me.Btnimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnimprimir.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.Image = Global.GUIRentas.My.Resources.Resources._41
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsalir.Location = New System.Drawing.Point(619, 406)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 18
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(474, 413)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Total S/."
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.BackColor = System.Drawing.Color.DarkGreen
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.ForeColor = System.Drawing.Color.White
        Me.lbltotal.Location = New System.Drawing.Point(527, 405)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(86, 20)
        Me.lbltotal.TabIndex = 16
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(515, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Cuenta"
        '
        'CmbCuenta
        '
        Me.CmbCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCuenta.FormattingEnabled = True
        Me.CmbCuenta.Location = New System.Drawing.Point(518, 59)
        Me.CmbCuenta.Name = "CmbCuenta"
        Me.CmbCuenta.Size = New System.Drawing.Size(176, 21)
        Me.CmbCuenta.TabIndex = 21
        '
        'BtnRemove
        '
        Me.BtnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRemove.Image = Global.GUIRentas.My.Resources.Resources._19s
        Me.BtnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRemove.Location = New System.Drawing.Point(258, 404)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(104, 23)
        Me.BtnRemove.TabIndex = 22
        Me.BtnRemove.Text = "Quitar Pago"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'FrmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(705, 438)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.CmbCuenta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Btnimprimir)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.LvwPagos)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FrmPagos"
        Me.Text = "Cancelar Trimestres"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvTrimestres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvDj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcodigocliente As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblruc As System.Windows.Forms.Label
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgvDj As System.Windows.Forms.DataGridView
    Friend WithEvents DgvTrimestres As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcodpago As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbltrimestre As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblmonto As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnVerPredios As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents LvwPagos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents Btnimprimir As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
End Class
