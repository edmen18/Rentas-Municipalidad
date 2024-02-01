<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaEmpoces
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
        Me.rbFechas = New System.Windows.Forms.RadioButton
        Me.rbtNumPapeleta = New System.Windows.Forms.RadioButton
        Me.txtNumPapeleta = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtfechaal = New System.Windows.Forms.DateTimePicker
        Me.dtfechadel = New System.Windows.Forms.DateTimePicker
        Me.btnverdetalle = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.dgvEmpoces = New System.Windows.Forms.DataGridView
        Me.btnver = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvEmpoces, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbFechas)
        Me.GroupBox1.Controls.Add(Me.rbtNumPapeleta)
        Me.GroupBox1.Controls.Add(Me.txtNumPapeleta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtfechaal)
        Me.GroupBox1.Controls.Add(Me.dtfechadel)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 68)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione un tipo de consulta"
        '
        'rbFechas
        '
        Me.rbFechas.AutoSize = True
        Me.rbFechas.Location = New System.Drawing.Point(198, 19)
        Me.rbFechas.Name = "rbFechas"
        Me.rbFechas.Size = New System.Drawing.Size(134, 17)
        Me.rbFechas.TabIndex = 10
        Me.rbFechas.Text = "Por intervalo de fechas"
        Me.rbFechas.UseVisualStyleBackColor = True
        '
        'rbtNumPapeleta
        '
        Me.rbtNumPapeleta.AutoSize = True
        Me.rbtNumPapeleta.Checked = True
        Me.rbtNumPapeleta.Location = New System.Drawing.Point(15, 19)
        Me.rbtNumPapeleta.Name = "rbtNumPapeleta"
        Me.rbtNumPapeleta.Size = New System.Drawing.Size(138, 17)
        Me.rbtNumPapeleta.TabIndex = 9
        Me.rbtNumPapeleta.TabStop = True
        Me.rbtNumPapeleta.Text = "Por numero de papeleta"
        Me.rbtNumPapeleta.UseVisualStyleBackColor = True
        '
        'txtNumPapeleta
        '
        Me.txtNumPapeleta.Location = New System.Drawing.Point(15, 42)
        Me.txtNumPapeleta.Name = "txtNumPapeleta"
        Me.txtNumPapeleta.Size = New System.Drawing.Size(141, 20)
        Me.txtNumPapeleta.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(329, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Al"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Del"
        '
        'dtfechaal
        '
        Me.dtfechaal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechaal.Location = New System.Drawing.Point(356, 42)
        Me.dtfechaal.Name = "dtfechaal"
        Me.dtfechaal.Size = New System.Drawing.Size(105, 20)
        Me.dtfechaal.TabIndex = 1
        '
        'dtfechadel
        '
        Me.dtfechadel.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechadel.Location = New System.Drawing.Point(224, 43)
        Me.dtfechadel.Name = "dtfechadel"
        Me.dtfechadel.Size = New System.Drawing.Size(101, 20)
        Me.dtfechadel.TabIndex = 0
        '
        'btnverdetalle
        '
        Me.btnverdetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnverdetalle.Image = Global.GUIRentas.My.Resources.Resources._65
        Me.btnverdetalle.Location = New System.Drawing.Point(646, 34)
        Me.btnverdetalle.Name = "btnverdetalle"
        Me.btnverdetalle.Size = New System.Drawing.Size(75, 65)
        Me.btnverdetalle.TabIndex = 3
        Me.btnverdetalle.Text = "&Ver Detalle"
        Me.btnverdetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnverdetalle.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.GUIRentas.My.Resources.Resources._20
        Me.btnImprimir.Location = New System.Drawing.Point(727, 34)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 65)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.Image = Global.GUIRentas.My.Resources.Resources._75
        Me.btnsalir.Location = New System.Drawing.Point(808, 34)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 65)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "&Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'dgvEmpoces
        '
        Me.dgvEmpoces.AllowUserToAddRows = False
        Me.dgvEmpoces.AllowUserToDeleteRows = False
        Me.dgvEmpoces.AllowUserToOrderColumns = True
        Me.dgvEmpoces.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmpoces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpoces.Location = New System.Drawing.Point(8, 103)
        Me.dgvEmpoces.Name = "dgvEmpoces"
        Me.dgvEmpoces.ReadOnly = True
        Me.dgvEmpoces.Size = New System.Drawing.Size(875, 271)
        Me.dgvEmpoces.TabIndex = 6
        '
        'btnver
        '
        Me.btnver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnver.Image = Global.GUIRentas.My.Resources.Resources._30
        Me.btnver.Location = New System.Drawing.Point(565, 34)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(75, 65)
        Me.btnver.TabIndex = 2
        Me.btnver.Text = "&Ver"
        Me.btnver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnver.UseVisualStyleBackColor = True
        '
        'FrmConsultaEmpoces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(900, 386)
        Me.Controls.Add(Me.dgvEmpoces)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnverdetalle)
        Me.Controls.Add(Me.btnver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmConsultaEmpoces"
        Me.Text = "Consulta de Empoces"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvEmpoces, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtfechaal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfechadel As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnver As System.Windows.Forms.Button
    Friend WithEvents btnverdetalle As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents dgvEmpoces As System.Windows.Forms.DataGridView
    Friend WithEvents txtNumPapeleta As System.Windows.Forms.TextBox
    Friend WithEvents rbFechas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNumPapeleta As System.Windows.Forms.RadioButton
End Class
