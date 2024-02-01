<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFactorReajuste
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtbase = New System.Windows.Forms.TextBox
        Me.txtmensual = New System.Windows.Forms.TextBox
        Me.txtacumulado = New System.Windows.Forms.TextBox
        Me.DtFecha = New System.Windows.Forms.DateTimePicker
        Me.DgvFactores = New System.Windows.Forms.DataGridView
        Me.btngrabar = New System.Windows.Forms.Button
        Me.Btncancelar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btneliminar = New System.Windows.Forms.Button
        CType(Me.DgvFactores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mensual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Acumulado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha"
        '
        'txtbase
        '
        Me.txtbase.Location = New System.Drawing.Point(92, 17)
        Me.txtbase.Name = "txtbase"
        Me.txtbase.Size = New System.Drawing.Size(193, 20)
        Me.txtbase.TabIndex = 4
        '
        'txtmensual
        '
        Me.txtmensual.Location = New System.Drawing.Point(92, 44)
        Me.txtmensual.Name = "txtmensual"
        Me.txtmensual.Size = New System.Drawing.Size(193, 20)
        Me.txtmensual.TabIndex = 5
        '
        'txtacumulado
        '
        Me.txtacumulado.Location = New System.Drawing.Point(92, 68)
        Me.txtacumulado.Name = "txtacumulado"
        Me.txtacumulado.Size = New System.Drawing.Size(193, 20)
        Me.txtacumulado.TabIndex = 6
        '
        'DtFecha
        '
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(92, 93)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(193, 20)
        Me.DtFecha.TabIndex = 7
        '
        'DgvFactores
        '
        Me.DgvFactores.AllowUserToAddRows = False
        Me.DgvFactores.AllowUserToDeleteRows = False
        Me.DgvFactores.AllowUserToOrderColumns = True
        Me.DgvFactores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvFactores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFactores.Location = New System.Drawing.Point(6, 121)
        Me.DgvFactores.Name = "DgvFactores"
        Me.DgvFactores.ReadOnly = True
        Me.DgvFactores.Size = New System.Drawing.Size(579, 235)
        Me.DgvFactores.TabIndex = 8
        '
        'btngrabar
        '
        Me.btngrabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btngrabar.Image = Global.GUIRentas.My.Resources.Resources._15
        Me.btngrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngrabar.Location = New System.Drawing.Point(488, 20)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(97, 23)
        Me.btngrabar.TabIndex = 9
        Me.btngrabar.Text = "&Grabar"
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'Btncancelar
        '
        Me.Btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btncancelar.Image = Global.GUIRentas.My.Resources.Resources._28
        Me.Btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btncancelar.Location = New System.Drawing.Point(488, 43)
        Me.Btncancelar.Name = "Btncancelar"
        Me.Btncancelar.Size = New System.Drawing.Size(97, 23)
        Me.Btncancelar.TabIndex = 10
        Me.Btncancelar.Text = "&Cancelar"
        Me.Btncancelar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.Image = Global.GUIRentas.My.Resources.Resources._41
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.Location = New System.Drawing.Point(488, 91)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(97, 23)
        Me.btnsalir.TabIndex = 11
        Me.btnsalir.Text = "&Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btneliminar.Image = Global.GUIRentas.My.Resources.Resources._19s
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.Location = New System.Drawing.Point(488, 67)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(97, 23)
        Me.btneliminar.TabIndex = 13
        Me.btneliminar.Text = "&Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'FrmFactorReajuste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 358)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Btncancelar)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.DgvFactores)
        Me.Controls.Add(Me.DtFecha)
        Me.Controls.Add(Me.txtacumulado)
        Me.Controls.Add(Me.txtmensual)
        Me.Controls.Add(Me.txtbase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmFactorReajuste"
        Me.Text = "Factores de Reajuste"
        CType(Me.DgvFactores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtbase As System.Windows.Forms.TextBox
    Friend WithEvents txtmensual As System.Windows.Forms.TextBox
    Friend WithEvents txtacumulado As System.Windows.Forms.TextBox
    Friend WithEvents DtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DgvFactores As System.Windows.Forms.DataGridView
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents Btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
End Class
