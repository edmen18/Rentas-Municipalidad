<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportesPredial
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
        Me.rbtrimestreactualvencido = New System.Windows.Forms.RadioButton
        Me.BtnVerReporte = New System.Windows.Forms.Button
        Me.RbRecibos = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtDel = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.DtAl = New System.Windows.Forms.DateTimePicker
        Me.rbordenesd = New System.Windows.Forms.RadioButton
        Me.rbordenesc = New System.Windows.Forms.RadioButton
        Me.RbBalance = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'rbtrimestreactualvencido
        '
        Me.rbtrimestreactualvencido.AutoSize = True
        Me.rbtrimestreactualvencido.Location = New System.Drawing.Point(12, 7)
        Me.rbtrimestreactualvencido.Name = "rbtrimestreactualvencido"
        Me.rbtrimestreactualvencido.Size = New System.Drawing.Size(120, 17)
        Me.rbtrimestreactualvencido.TabIndex = 0
        Me.rbtrimestreactualvencido.TabStop = True
        Me.rbtrimestreactualvencido.Text = "Trimestres Vencidos"
        Me.rbtrimestreactualvencido.UseVisualStyleBackColor = True
        '
        'BtnVerReporte
        '
        Me.BtnVerReporte.Image = Global.GUIRentas.My.Resources.Resources._20
        Me.BtnVerReporte.Location = New System.Drawing.Point(297, 22)
        Me.BtnVerReporte.Name = "BtnVerReporte"
        Me.BtnVerReporte.Size = New System.Drawing.Size(86, 80)
        Me.BtnVerReporte.TabIndex = 1
        Me.BtnVerReporte.Text = "&Ver Reporte"
        Me.BtnVerReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnVerReporte.UseVisualStyleBackColor = True
        '
        'RbRecibos
        '
        Me.RbRecibos.AutoSize = True
        Me.RbRecibos.Location = New System.Drawing.Point(12, 33)
        Me.RbRecibos.Name = "RbRecibos"
        Me.RbRecibos.Size = New System.Drawing.Size(106, 17)
        Me.RbRecibos.TabIndex = 4
        Me.RbRecibos.TabStop = True
        Me.RbRecibos.Text = "Recibos Emitidos"
        Me.RbRecibos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Desde"
        '
        'DtDel
        '
        Me.DtDel.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtDel.Location = New System.Drawing.Point(205, 22)
        Me.DtDel.Name = "DtDel"
        Me.DtDel.Size = New System.Drawing.Size(86, 20)
        Me.DtDel.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hasta"
        '
        'DtAl
        '
        Me.DtAl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtAl.Location = New System.Drawing.Point(205, 82)
        Me.DtAl.Name = "DtAl"
        Me.DtAl.Size = New System.Drawing.Size(86, 20)
        Me.DtAl.TabIndex = 8
        '
        'rbordenesd
        '
        Me.rbordenesd.AutoSize = True
        Me.rbordenesd.Location = New System.Drawing.Point(12, 58)
        Me.rbordenesd.Name = "rbordenesd"
        Me.rbordenesd.Size = New System.Drawing.Size(167, 17)
        Me.rbordenesd.TabIndex = 9
        Me.rbordenesd.TabStop = True
        Me.rbordenesd.Text = "Ordenes de pago sin cancelar"
        Me.rbordenesd.UseVisualStyleBackColor = True
        '
        'rbordenesc
        '
        Me.rbordenesc.AutoSize = True
        Me.rbordenesc.Location = New System.Drawing.Point(12, 85)
        Me.rbordenesc.Name = "rbordenesc"
        Me.rbordenesc.Size = New System.Drawing.Size(167, 17)
        Me.rbordenesc.TabIndex = 10
        Me.rbordenesc.TabStop = True
        Me.rbordenesc.Text = "Ordenes de Pago Canceladas"
        Me.rbordenesc.UseVisualStyleBackColor = True
        '
        'RbBalance
        '
        Me.RbBalance.AutoSize = True
        Me.RbBalance.Location = New System.Drawing.Point(12, 108)
        Me.RbBalance.Name = "RbBalance"
        Me.RbBalance.Size = New System.Drawing.Size(64, 17)
        Me.RbBalance.TabIndex = 11
        Me.RbBalance.TabStop = True
        Me.RbBalance.Text = "Balance"
        Me.RbBalance.UseVisualStyleBackColor = True
        '
        'FrmReportesPredial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 151)
        Me.Controls.Add(Me.RbBalance)
        Me.Controls.Add(Me.rbordenesc)
        Me.Controls.Add(Me.rbordenesd)
        Me.Controls.Add(Me.DtAl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DtDel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RbRecibos)
        Me.Controls.Add(Me.BtnVerReporte)
        Me.Controls.Add(Me.rbtrimestreactualvencido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmReportesPredial"
        Me.Text = "Reportes Predial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtrimestreactualvencido As System.Windows.Forms.RadioButton
    Friend WithEvents BtnVerReporte As System.Windows.Forms.Button
    Friend WithEvents RbRecibos As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtDel As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtAl As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbordenesd As System.Windows.Forms.RadioButton
    Friend WithEvents rbordenesc As System.Windows.Forms.RadioButton
    Friend WithEvents RbBalance As System.Windows.Forms.RadioButton
End Class
