<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaVenta
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
        Me.rbfecha = New System.Windows.Forms.RadioButton
        Me.rbservicio = New System.Windows.Forms.RadioButton
        Me.rbcliente = New System.Windows.Forms.RadioButton
        Me.gbcliente = New System.Windows.Forms.GroupBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbldni = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.lblcodcliente = New System.Windows.Forms.Label
        Me.gbfecha = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtal = New System.Windows.Forms.DateTimePicker
        Me.dtdel = New System.Windows.Forms.DateTimePicker
        Me.Gbservicio = New System.Windows.Forms.GroupBox
        Me.btnbuscarserv = New System.Windows.Forms.Button
        Me.lblcodigoservicio = New System.Windows.Forms.Label
        Me.lbldescripcion = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.LBLRUCENTIDAD = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnVerdetalle = New System.Windows.Forms.Button
        Me.dgvVentas = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.gbcliente.SuspendLayout()
        Me.gbfecha.SuspendLayout()
        Me.Gbservicio.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbfecha)
        Me.GroupBox1.Controls.Add(Me.rbservicio)
        Me.GroupBox1.Controls.Add(Me.rbcliente)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 68)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una Opción"
        '
        'rbfecha
        '
        Me.rbfecha.AutoSize = True
        Me.rbfecha.Location = New System.Drawing.Point(193, 28)
        Me.rbfecha.Name = "rbfecha"
        Me.rbfecha.Size = New System.Drawing.Size(74, 17)
        Me.rbfecha.TabIndex = 2
        Me.rbfecha.TabStop = True
        Me.rbfecha.Text = "Por Fecha"
        Me.rbfecha.UseVisualStyleBackColor = True
        '
        'rbservicio
        '
        Me.rbservicio.AutoSize = True
        Me.rbservicio.Checked = True
        Me.rbservicio.Location = New System.Drawing.Point(102, 28)
        Me.rbservicio.Name = "rbservicio"
        Me.rbservicio.Size = New System.Drawing.Size(85, 17)
        Me.rbservicio.TabIndex = 1
        Me.rbservicio.TabStop = True
        Me.rbservicio.Text = "Por  Servicio"
        Me.rbservicio.UseVisualStyleBackColor = True
        '
        'rbcliente
        '
        Me.rbcliente.AutoSize = True
        Me.rbcliente.Location = New System.Drawing.Point(20, 28)
        Me.rbcliente.Name = "rbcliente"
        Me.rbcliente.Size = New System.Drawing.Size(76, 17)
        Me.rbcliente.TabIndex = 0
        Me.rbcliente.TabStop = True
        Me.rbcliente.Text = "Por Cliente"
        Me.rbcliente.UseVisualStyleBackColor = True
        '
        'gbcliente
        '
        Me.gbcliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbcliente.Controls.Add(Me.btnbuscar)
        Me.gbcliente.Controls.Add(Me.Label1)
        Me.gbcliente.Controls.Add(Me.Label3)
        Me.gbcliente.Controls.Add(Me.Label2)
        Me.gbcliente.Controls.Add(Me.lbldni)
        Me.gbcliente.Controls.Add(Me.lblnombre)
        Me.gbcliente.Controls.Add(Me.lblcodcliente)
        Me.gbcliente.Location = New System.Drawing.Point(292, 12)
        Me.gbcliente.Name = "gbcliente"
        Me.gbcliente.Size = New System.Drawing.Size(435, 68)
        Me.gbcliente.TabIndex = 2
        Me.gbcliente.TabStop = False
        Me.gbcliente.Text = "Cliente"
        '
        'btnbuscar
        '
        Me.btnbuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbuscar.Image = Global.GUIRentas.My.Resources.Resources._30
        Me.btnbuscar.Location = New System.Drawing.Point(356, 17)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 46)
        Me.btnbuscar.TabIndex = 6
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "R.U.C."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dni"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente"
        '
        'lbldni
        '
        Me.lbldni.BackColor = System.Drawing.Color.Tan
        Me.lbldni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldni.Location = New System.Drawing.Point(66, 39)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(104, 20)
        Me.lbldni.TabIndex = 1
        '
        'lblnombre
        '
        Me.lblnombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnombre.BackColor = System.Drawing.Color.Tan
        Me.lblnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(66, 16)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(283, 20)
        Me.lblnombre.TabIndex = 0
        '
        'lblcodcliente
        '
        Me.lblcodcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodcliente.Location = New System.Drawing.Point(332, 39)
        Me.lblcodcliente.Name = "lblcodcliente"
        Me.lblcodcliente.Size = New System.Drawing.Size(20, 20)
        Me.lblcodcliente.TabIndex = 7
        Me.lblcodcliente.Visible = False
        '
        'gbfecha
        '
        Me.gbfecha.Controls.Add(Me.Label5)
        Me.gbfecha.Controls.Add(Me.Label4)
        Me.gbfecha.Controls.Add(Me.dtal)
        Me.gbfecha.Controls.Add(Me.dtdel)
        Me.gbfecha.Location = New System.Drawing.Point(292, 12)
        Me.gbfecha.Name = "gbfecha"
        Me.gbfecha.Size = New System.Drawing.Size(455, 68)
        Me.gbfecha.TabIndex = 4
        Me.gbfecha.TabStop = False
        Me.gbfecha.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "&Al"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "&Del"
        '
        'dtal
        '
        Me.dtal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtal.Location = New System.Drawing.Point(260, 28)
        Me.dtal.Name = "dtal"
        Me.dtal.Size = New System.Drawing.Size(146, 20)
        Me.dtal.TabIndex = 1
        '
        'dtdel
        '
        Me.dtdel.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdel.Location = New System.Drawing.Point(62, 27)
        Me.dtdel.Name = "dtdel"
        Me.dtdel.Size = New System.Drawing.Size(154, 20)
        Me.dtdel.TabIndex = 0
        '
        'Gbservicio
        '
        Me.Gbservicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbservicio.Controls.Add(Me.btnbuscarserv)
        Me.Gbservicio.Controls.Add(Me.lblcodigoservicio)
        Me.Gbservicio.Controls.Add(Me.lbldescripcion)
        Me.Gbservicio.Controls.Add(Me.Label7)
        Me.Gbservicio.Controls.Add(Me.Label6)
        Me.Gbservicio.Location = New System.Drawing.Point(292, 12)
        Me.Gbservicio.Name = "Gbservicio"
        Me.Gbservicio.Size = New System.Drawing.Size(449, 68)
        Me.Gbservicio.TabIndex = 5
        Me.Gbservicio.TabStop = False
        Me.Gbservicio.Text = "Servicio"
        '
        'btnbuscarserv
        '
        Me.btnbuscarserv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbuscarserv.Image = Global.GUIRentas.My.Resources.Resources._30
        Me.btnbuscarserv.Location = New System.Drawing.Point(365, 15)
        Me.btnbuscarserv.Name = "btnbuscarserv"
        Me.btnbuscarserv.Size = New System.Drawing.Size(78, 46)
        Me.btnbuscarserv.TabIndex = 4
        Me.btnbuscarserv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbuscarserv.UseVisualStyleBackColor = True
        '
        'lblcodigoservicio
        '
        Me.lblcodigoservicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcodigoservicio.BackColor = System.Drawing.Color.Tan
        Me.lblcodigoservicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigoservicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigoservicio.Location = New System.Drawing.Point(98, 41)
        Me.lblcodigoservicio.Name = "lblcodigoservicio"
        Me.lblcodigoservicio.Size = New System.Drawing.Size(261, 20)
        Me.lblcodigoservicio.TabIndex = 3
        Me.lblcodigoservicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldescripcion
        '
        Me.lbldescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldescripcion.BackColor = System.Drawing.Color.Tan
        Me.lbldescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion.Location = New System.Drawing.Point(98, 15)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(261, 23)
        Me.lbldescripcion.TabIndex = 2
        Me.lbldescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(24, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Código"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Descripción"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Image = Global.GUIRentas.My.Resources.Resources._41
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(632, 369)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(93, 30)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'LBLRUCENTIDAD
        '
        Me.LBLRUCENTIDAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLRUCENTIDAD.Location = New System.Drawing.Point(594, 40)
        Me.LBLRUCENTIDAD.Name = "LBLRUCENTIDAD"
        Me.LBLRUCENTIDAD.Size = New System.Drawing.Size(37, 23)
        Me.LBLRUCENTIDAD.TabIndex = 5
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.GUIRentas.My.Resources.Resources._25
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(533, 369)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(93, 30)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnVerdetalle
        '
        Me.btnVerdetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVerdetalle.Image = Global.GUIRentas.My.Resources.Resources._05
        Me.btnVerdetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerdetalle.Location = New System.Drawing.Point(433, 369)
        Me.btnVerdetalle.Name = "btnVerdetalle"
        Me.btnVerdetalle.Size = New System.Drawing.Size(93, 30)
        Me.btnVerdetalle.TabIndex = 6
        Me.btnVerdetalle.Text = "&Ver Detalle"
        Me.btnVerdetalle.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(9, 86)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(718, 277)
        Me.dgvVentas.TabIndex = 9
        '
        'FrmConsultaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(737, 412)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnVerdetalle)
        Me.Controls.Add(Me.Gbservicio)
        Me.Controls.Add(Me.gbfecha)
        Me.Controls.Add(Me.gbcliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBLRUCENTIDAD)
        Me.Name = "FrmConsultaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbcliente.ResumeLayout(False)
        Me.gbcliente.PerformLayout()
        Me.gbfecha.ResumeLayout(False)
        Me.gbfecha.PerformLayout()
        Me.Gbservicio.ResumeLayout(False)
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbfecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbservicio As System.Windows.Forms.RadioButton
    Friend WithEvents rbcliente As System.Windows.Forms.RadioButton
    Friend WithEvents gbcliente As System.Windows.Forms.GroupBox
    Friend WithEvents lblcodcliente As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents gbfecha As System.Windows.Forms.GroupBox
    Friend WithEvents dtal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtdel As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Gbservicio As System.Windows.Forms.GroupBox
    Friend WithEvents lblcodigoservicio As System.Windows.Forms.Label
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnbuscarserv As System.Windows.Forms.Button
    Friend WithEvents btnVerdetalle As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents LBLRUCENTIDAD As System.Windows.Forms.Label
    Friend WithEvents dgvVentas As System.Windows.Forms.DataGridView
End Class
