<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroExtorno
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbloperacion = New System.Windows.Forms.Label
        Me.lblmonto = New System.Windows.Forms.Label
        Me.Dtfecha = New System.Windows.Forms.DateTimePicker
        Me.btngrabar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbMotivo = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operación Nº"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Monto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Operación"
        '
        'lbloperacion
        '
        Me.lbloperacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbloperacion.Location = New System.Drawing.Point(113, 8)
        Me.lbloperacion.Name = "lbloperacion"
        Me.lbloperacion.Size = New System.Drawing.Size(188, 20)
        Me.lbloperacion.TabIndex = 5
        '
        'lblmonto
        '
        Me.lblmonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmonto.Location = New System.Drawing.Point(113, 35)
        Me.lblmonto.Name = "lblmonto"
        Me.lblmonto.Size = New System.Drawing.Size(188, 20)
        Me.lblmonto.TabIndex = 6
        Me.lblmonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dtfecha
        '
        Me.Dtfecha.Enabled = False
        Me.Dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtfecha.Location = New System.Drawing.Point(113, 61)
        Me.Dtfecha.Name = "Dtfecha"
        Me.Dtfecha.Size = New System.Drawing.Size(188, 20)
        Me.Dtfecha.TabIndex = 7
        '
        'btngrabar
        '
        Me.btngrabar.Image = Global.GUIRentas.My.Resources.Resources._15
        Me.btngrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngrabar.Location = New System.Drawing.Point(70, 136)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(88, 23)
        Me.btngrabar.TabIndex = 8
        Me.btngrabar.Text = "&Grabar"
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Image = Global.GUIRentas.My.Resources.Resources._41
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.Location = New System.Drawing.Point(164, 136)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(88, 23)
        Me.btnsalir.TabIndex = 9
        Me.btnsalir.Text = "&Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Motivo de Extorno"
        '
        'cmbMotivo
        '
        Me.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMotivo.FormattingEnabled = True
        Me.cmbMotivo.Location = New System.Drawing.Point(113, 87)
        Me.cmbMotivo.Name = "cmbMotivo"
        Me.cmbMotivo.Size = New System.Drawing.Size(188, 21)
        Me.cmbMotivo.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(7, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(296, 22)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "_________________________________________________________________________________" & _
            "______________________________"
        '
        'FrmRegistroExtorno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 164)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbMotivo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.Dtfecha)
        Me.Controls.Add(Me.lblmonto)
        Me.Controls.Add(Me.lbloperacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmRegistroExtorno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Extorno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbloperacion As System.Windows.Forms.Label
    Friend WithEvents lblmonto As System.Windows.Forms.Label
    Friend WithEvents Dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
