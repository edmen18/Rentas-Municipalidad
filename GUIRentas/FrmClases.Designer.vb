<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClases
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.nudannio = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDivision = New System.Windows.Forms.Label
        Me.cbocta = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbotiposervicio = New System.Windows.Forms.ComboBox
        Me.txtuitclase = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblNumClase = New System.Windows.Forms.Label
        Me.txtclase = New System.Windows.Forms.TextBox
        Me.lblflg = New System.Windows.Forms.Label
        Me.lblnumeroGrupo = New System.Windows.Forms.Label
        Me.btnCancelarClase = New System.Windows.Forms.Button
        Me.btnGrabarClase = New System.Windows.Forms.Button
        Me.GroupBox4.SuspendLayout()
        CType(Me.nudannio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.nudannio)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.lblDivision)
        Me.GroupBox4.Controls.Add(Me.cbocta)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.cbotiposervicio)
        Me.GroupBox4.Controls.Add(Me.txtuitclase)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.lblNumClase)
        Me.GroupBox4.Controls.Add(Me.txtclase)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(501, 184)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'nudannio
        '
        Me.nudannio.Location = New System.Drawing.Point(427, 12)
        Me.nudannio.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.nudannio.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudannio.Name = "nudannio"
        Me.nudannio.Size = New System.Drawing.Size(62, 20)
        Me.nudannio.TabIndex = 74
        Me.nudannio.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Division"
        '
        'lblDivision
        '
        Me.lblDivision.BackColor = System.Drawing.Color.Gray
        Me.lblDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.ForeColor = System.Drawing.Color.White
        Me.lblDivision.Location = New System.Drawing.Point(95, 53)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(394, 23)
        Me.lblDivision.TabIndex = 13
        '
        'cbocta
        '
        Me.cbocta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocta.FormattingEnabled = True
        Me.cbocta.Location = New System.Drawing.Point(95, 119)
        Me.cbocta.Name = "cbocta"
        Me.cbocta.Size = New System.Drawing.Size(394, 21)
        Me.cbocta.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cuenta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Tipo Servicio"
        '
        'cbotiposervicio
        '
        Me.cbotiposervicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotiposervicio.FormattingEnabled = True
        Me.cbotiposervicio.Location = New System.Drawing.Point(95, 146)
        Me.cbotiposervicio.Name = "cbotiposervicio"
        Me.cbotiposervicio.Size = New System.Drawing.Size(228, 21)
        Me.cbotiposervicio.TabIndex = 8
        '
        'txtuitclase
        '
        Me.txtuitclase.Location = New System.Drawing.Point(389, 146)
        Me.txtuitclase.Name = "txtuitclase"
        Me.txtuitclase.Size = New System.Drawing.Size(100, 20)
        Me.txtuitclase.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(339, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Valor (%)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tasa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cod. Division"
        '
        'lblNumClase
        '
        Me.lblNumClase.BackColor = System.Drawing.Color.Gray
        Me.lblNumClase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumClase.ForeColor = System.Drawing.Color.White
        Me.lblNumClase.Location = New System.Drawing.Point(95, 25)
        Me.lblNumClase.Name = "lblNumClase"
        Me.lblNumClase.Size = New System.Drawing.Size(100, 23)
        Me.lblNumClase.TabIndex = 1
        '
        'txtclase
        '
        Me.txtclase.Location = New System.Drawing.Point(95, 81)
        Me.txtclase.Multiline = True
        Me.txtclase.Name = "txtclase"
        Me.txtclase.Size = New System.Drawing.Size(394, 33)
        Me.txtclase.TabIndex = 0
        '
        'lblflg
        '
        Me.lblflg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblflg.Location = New System.Drawing.Point(38, 110)
        Me.lblflg.Name = "lblflg"
        Me.lblflg.Size = New System.Drawing.Size(59, 21)
        Me.lblflg.TabIndex = 5
        Me.lblflg.Visible = False
        '
        'lblnumeroGrupo
        '
        Me.lblnumeroGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnumeroGrupo.Location = New System.Drawing.Point(38, 110)
        Me.lblnumeroGrupo.Name = "lblnumeroGrupo"
        Me.lblnumeroGrupo.Size = New System.Drawing.Size(59, 21)
        Me.lblnumeroGrupo.TabIndex = 6
        Me.lblnumeroGrupo.Visible = False
        '
        'btnCancelarClase
        '
        Me.btnCancelarClase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarClase.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnCancelarClase.ForeColor = System.Drawing.Color.Black
        Me.btnCancelarClase.Image = Global.GUIRentas.My.Resources.Resources._28
        Me.btnCancelarClase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelarClase.Location = New System.Drawing.Point(393, 190)
        Me.btnCancelarClase.Name = "btnCancelarClase"
        Me.btnCancelarClase.Size = New System.Drawing.Size(96, 28)
        Me.btnCancelarClase.TabIndex = 73
        Me.btnCancelarClase.Text = "&Cancelar"
        Me.btnCancelarClase.UseVisualStyleBackColor = True
        '
        'btnGrabarClase
        '
        Me.btnGrabarClase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGrabarClase.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnGrabarClase.ForeColor = System.Drawing.Color.Black
        Me.btnGrabarClase.Image = Global.GUIRentas.My.Resources.Resources._15
        Me.btnGrabarClase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabarClase.Location = New System.Drawing.Point(291, 190)
        Me.btnGrabarClase.Name = "btnGrabarClase"
        Me.btnGrabarClase.Size = New System.Drawing.Size(96, 28)
        Me.btnGrabarClase.TabIndex = 72
        Me.btnGrabarClase.Text = "&Actualizar"
        Me.btnGrabarClase.UseVisualStyleBackColor = True
        '
        'FrmClases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(501, 220)
        Me.Controls.Add(Me.btnCancelarClase)
        Me.Controls.Add(Me.btnGrabarClase)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblnumeroGrupo)
        Me.Controls.Add(Me.lblflg)
        Me.Name = "FrmClases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Tasas"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nudannio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbotiposervicio As System.Windows.Forms.ComboBox
    Friend WithEvents txtuitclase As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNumClase As System.Windows.Forms.Label
    Friend WithEvents txtclase As System.Windows.Forms.TextBox
    Friend WithEvents lblflg As System.Windows.Forms.Label
    Friend WithEvents lblnumeroGrupo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbocta As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDivision As System.Windows.Forms.Label
    Friend WithEvents btnGrabarClase As System.Windows.Forms.Button
    Friend WithEvents btnCancelarClase As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nudannio As System.Windows.Forms.NumericUpDown
End Class
