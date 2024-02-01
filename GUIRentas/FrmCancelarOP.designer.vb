<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCancelarOP
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
        Me.BtnImprimir = New System.Windows.Forms.Button
        Me.lvwordenes = New System.Windows.Forms.ListView
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblcodigocliente = New System.Windows.Forms.Label
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.lblruc = New System.Windows.Forms.Label
        Me.lbldni = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnGrabar = New System.Windows.Forms.Button
        Me.lblrecibo = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LvwPagos = New System.Windows.Forms.ListView
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.CmbCuenta = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImprimir.Image = Global.GUIRentas.My.Resources.Resources._20
        Me.BtnImprimir.Location = New System.Drawing.Point(1045, 222)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(75, 64)
        Me.BtnImprimir.TabIndex = 36
        Me.BtnImprimir.Text = "&Imprime"
        Me.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'lvwordenes
        '
        Me.lvwordenes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lvwordenes.FullRowSelect = True
        Me.lvwordenes.Location = New System.Drawing.Point(12, 126)
        Me.lvwordenes.Name = "lvwordenes"
        Me.lvwordenes.Size = New System.Drawing.Size(265, 97)
        Me.lvwordenes.TabIndex = 35
        Me.lvwordenes.UseCompatibleStateImageBehavior = False
        Me.lvwordenes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Orden de Pago"
        Me.ColumnHeader12.Width = 121
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Fecha"
        Me.ColumnHeader13.Width = 106
        '
        'lvwDetalle
        '
        Me.lvwDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwDetalle.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvwDetalle.FullRowSelect = True
        Me.lvwDetalle.GridLines = True
        Me.lvwDetalle.Location = New System.Drawing.Point(12, 229)
        Me.lvwDetalle.Name = "lvwDetalle"
        Me.lvwDetalle.Size = New System.Drawing.Size(1027, 158)
        Me.lvwDetalle.TabIndex = 34
        Me.lvwDetalle.UseCompatibleStateImageBehavior = False
        Me.lvwDetalle.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Año"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Base Imponible"
        Me.ColumnHeader2.Width = 88
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tramo de Autovaluo"
        Me.ColumnHeader3.Width = 154
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ali Cuota"
        Me.ColumnHeader4.Width = 169
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Insolutos"
        Me.ColumnHeader5.Width = 127
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Imp Anual"
        Me.ColumnHeader6.Width = 83
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Trimestres"
        Me.ColumnHeader7.Width = 87
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Insoluto"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Reajuste"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Interes"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Total"
        Me.ColumnHeader11.Width = 84
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
        Me.GroupBox1.Location = New System.Drawing.Point(385, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 88)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Contribuyente"
        '
        'lblcodigocliente
        '
        Me.lblcodigocliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigocliente.Location = New System.Drawing.Point(19, 89)
        Me.lblcodigocliente.Name = "lblcodigocliente"
        Me.lblcodigocliente.Size = New System.Drawing.Size(93, 18)
        Me.lblcodigocliente.TabIndex = 7
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.GUIRentas.My.Resources.Resources._30
        Me.BtnBuscar.Location = New System.Drawing.Point(435, 20)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 49)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'lblruc
        '
        Me.lblruc.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblruc.Location = New System.Drawing.Point(233, 49)
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
        Me.lblDescripcion.Size = New System.Drawing.Size(347, 20)
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
        'BtnGrabar
        '
        Me.BtnGrabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGrabar.Enabled = False
        Me.BtnGrabar.Image = Global.GUIRentas.My.Resources.Resources._21
        Me.BtnGrabar.Location = New System.Drawing.Point(1045, 159)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(75, 64)
        Me.BtnGrabar.TabIndex = 38
        Me.BtnGrabar.Text = "&Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'lblrecibo
        '
        Me.lblrecibo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblrecibo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblrecibo.Location = New System.Drawing.Point(957, 29)
        Me.lblrecibo.Name = "lblrecibo"
        Me.lblrecibo.Size = New System.Drawing.Size(137, 20)
        Me.lblrecibo.TabIndex = 8
        Me.lblrecibo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(956, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Recibo de Pago Nº"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Location = New System.Drawing.Point(941, 390)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(98, 20)
        Me.lbltotal.TabIndex = 40
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(871, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Total deuda"
        '
        'LvwPagos
        '
        Me.LvwPagos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.LvwPagos.FullRowSelect = True
        Me.LvwPagos.Location = New System.Drawing.Point(283, 126)
        Me.LvwPagos.Name = "LvwPagos"
        Me.LvwPagos.Size = New System.Drawing.Size(441, 97)
        Me.LvwPagos.TabIndex = 42
        Me.LvwPagos.UseCompatibleStateImageBehavior = False
        Me.LvwPagos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Cod Pago"
        Me.ColumnHeader14.Width = 132
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Trimestre"
        Me.ColumnHeader15.Width = 111
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Fecha Venc"
        Me.ColumnHeader16.Width = 132
        '
        'CmbCuenta
        '
        Me.CmbCuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCuenta.FormattingEnabled = True
        Me.CmbCuenta.Location = New System.Drawing.Point(957, 68)
        Me.CmbCuenta.Name = "CmbCuenta"
        Me.CmbCuenta.Size = New System.Drawing.Size(137, 21)
        Me.CmbCuenta.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(956, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Cuenta"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.Image = Global.GUIRentas.My.Resources.Resources._36b
        Me.BtnCancelar.Location = New System.Drawing.Point(1045, 285)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 64)
        Me.BtnCancelar.TabIndex = 45
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUIRentas.My.Resources.Resources.SRM
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Image = Global.GUIRentas.My.Resources.Resources.Exit_one
        Me.btnSalir.Location = New System.Drawing.Point(1045, 348)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 64)
        Me.btnSalir.TabIndex = 47
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FrmCancelarOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1132, 419)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.CmbCuenta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LvwPagos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblrecibo)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.lvwordenes)
        Me.Controls.Add(Me.lvwDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCancelarOP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelar Orden de Pago"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents lvwordenes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcodigocliente As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblruc As System.Windows.Forms.Label
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents lblrecibo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LvwPagos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CmbCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
