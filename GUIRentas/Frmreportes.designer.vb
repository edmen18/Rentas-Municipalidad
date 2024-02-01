<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmreportes
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
        Me.rbrecibosemitidos = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.rbdiarioingreso = New System.Windows.Forms.RadioButton
        Me.BTNVER = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.rbreportediariocaja = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbrecibosemitidos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.rbdiarioingreso)
        Me.GroupBox1.Controls.Add(Me.BTNVER)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.rbreportediariocaja)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reportes de Ingresos"
        '
        'rbrecibosemitidos
        '
        Me.rbrecibosemitidos.AutoSize = True
        Me.rbrecibosemitidos.Location = New System.Drawing.Point(238, 26)
        Me.rbrecibosemitidos.Name = "rbrecibosemitidos"
        Me.rbrecibosemitidos.Size = New System.Drawing.Size(106, 17)
        Me.rbrecibosemitidos.TabIndex = 15
        Me.rbrecibosemitidos.TabStop = True
        Me.rbrecibosemitidos.Text = "Recibos Emitidos"
        Me.rbrecibosemitidos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "&Al"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "&Del"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(53, 99)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker2.TabIndex = 12
        '
        'rbdiarioingreso
        '
        Me.rbdiarioingreso.AutoSize = True
        Me.rbdiarioingreso.Location = New System.Drawing.Point(118, 26)
        Me.rbdiarioingreso.Name = "rbdiarioingreso"
        Me.rbdiarioingreso.Size = New System.Drawing.Size(105, 17)
        Me.rbdiarioingreso.TabIndex = 11
        Me.rbdiarioingreso.TabStop = True
        Me.rbdiarioingreso.Text = "Diario de Ingreso"
        Me.rbdiarioingreso.UseVisualStyleBackColor = True
        '
        'BTNVER
        '
        Me.BTNVER.Image = Global.GUIRentas.My.Resources.Resources._20
        Me.BTNVER.Location = New System.Drawing.Point(257, 51)
        Me.BTNVER.Name = "BTNVER"
        Me.BTNVER.Size = New System.Drawing.Size(87, 69)
        Me.BTNVER.TabIndex = 10
        Me.BTNVER.Text = "&Ver"
        Me.BTNVER.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNVER.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(53, 57)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'rbreportediariocaja
        '
        Me.rbreportediariocaja.AutoSize = True
        Me.rbreportediariocaja.Location = New System.Drawing.Point(27, 26)
        Me.rbreportediariocaja.Name = "rbreportediariocaja"
        Me.rbreportediariocaja.Size = New System.Drawing.Size(76, 17)
        Me.rbreportediariocaja.TabIndex = 8
        Me.rbreportediariocaja.TabStop = True
        Me.rbreportediariocaja.Text = "Diario Caja"
        Me.rbreportediariocaja.UseVisualStyleBackColor = True
        '
        'Frmreportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(379, 135)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Frmreportes"
        Me.Text = "Reportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbrecibosemitidos As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbdiarioingreso As System.Windows.Forms.RadioButton
    Friend WithEvents BTNVER As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbreportediariocaja As System.Windows.Forms.RadioButton
End Class
