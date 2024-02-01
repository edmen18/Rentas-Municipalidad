<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpoce
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
        Me.btnver = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtfechaal = New System.Windows.Forms.DateTimePicker
        Me.dtfechadel = New System.Windows.Forms.DateTimePicker
        Me.CmbCuenta = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgvEmpoce = New System.Windows.Forms.DataGridView
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.btnRegistro = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvEmpoce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnver)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtfechaal)
        Me.GroupBox1.Controls.Add(Me.dtfechadel)
        Me.GroupBox1.Controls.Add(Me.CmbCuenta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 196)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una Opción"
        '
        'btnver
        '
        Me.btnver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnver.Image = Global.GUIRentas.My.Resources.Resources._30
        Me.btnver.Location = New System.Drawing.Point(414, 24)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(78, 46)
        Me.btnver.TabIndex = 7
        Me.btnver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnver.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(253, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Al"
        '
        'dtfechaal
        '
        Me.dtfechaal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechaal.Location = New System.Drawing.Point(275, 53)
        Me.dtfechaal.Name = "dtfechaal"
        Me.dtfechaal.Size = New System.Drawing.Size(95, 20)
        Me.dtfechaal.TabIndex = 5
        '
        'dtfechadel
        '
        Me.dtfechadel.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechadel.Location = New System.Drawing.Point(62, 53)
        Me.dtfechadel.Name = "dtfechadel"
        Me.dtfechadel.Size = New System.Drawing.Size(95, 20)
        Me.dtfechadel.TabIndex = 3
        '
        'CmbCuenta
        '
        Me.CmbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCuenta.FormattingEnabled = True
        Me.CmbCuenta.Location = New System.Drawing.Point(62, 24)
        Me.CmbCuenta.Name = "CmbCuenta"
        Me.CmbCuenta.Size = New System.Drawing.Size(308, 21)
        Me.CmbCuenta.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Del"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(425, 418)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(90, 24)
        Me.lbltotal.TabIndex = 4
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(365, 426)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total S/."
        '
        'dgvEmpoce
        '
        Me.dgvEmpoce.AllowUserToAddRows = False
        Me.dgvEmpoce.AllowUserToDeleteRows = False
        Me.dgvEmpoce.AllowUserToOrderColumns = True
        Me.dgvEmpoce.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmpoce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpoce.Location = New System.Drawing.Point(11, 108)
        Me.dgvEmpoce.Name = "dgvEmpoce"
        Me.dgvEmpoce.ReadOnly = True
        Me.dgvEmpoce.Size = New System.Drawing.Size(504, 301)
        Me.dgvEmpoce.TabIndex = 6
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Image = Global.GUIRentas.My.Resources.Resources._41
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(93, 415)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(73, 28)
        Me.BtnSalir.TabIndex = 82
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'btnRegistro
        '
        Me.btnRegistro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRegistro.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnRegistro.ForeColor = System.Drawing.Color.Black
        Me.btnRegistro.Image = Global.GUIRentas.My.Resources.Resources._15
        Me.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistro.Location = New System.Drawing.Point(11, 415)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(76, 28)
        Me.btnRegistro.TabIndex = 81
        Me.btnRegistro.Text = "&Registrar"
        Me.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'FrmEmpoce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(532, 448)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.dgvEmpoce)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmEmpoce"
        Me.Text = "Empoce"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvEmpoce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtfechadel As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtfechaal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvEmpoce As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents btnRegistro As System.Windows.Forms.Button
    Friend WithEvents btnver As System.Windows.Forms.Button
End Class
