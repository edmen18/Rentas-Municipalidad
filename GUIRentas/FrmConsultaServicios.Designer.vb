<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaServicios
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
        Me.cbogrupo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtclase = New System.Windows.Forms.TextBox
        Me.lblflag = New System.Windows.Forms.Label
        Me.dgvServicios = New System.Windows.Forms.DataGridView
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbogrupo
        '
        Me.cbogrupo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbogrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbogrupo.FormattingEnabled = True
        Me.cbogrupo.Location = New System.Drawing.Point(5, 25)
        Me.cbogrupo.Name = "cbogrupo"
        Me.cbogrupo.Size = New System.Drawing.Size(579, 21)
        Me.cbogrupo.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Seleccionar Division"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Servicio"
        '
        'txtclase
        '
        Me.txtclase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtclase.Location = New System.Drawing.Point(5, 66)
        Me.txtclase.Name = "txtclase"
        Me.txtclase.Size = New System.Drawing.Size(578, 20)
        Me.txtclase.TabIndex = 73
        '
        'lblflag
        '
        Me.lblflag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblflag.Location = New System.Drawing.Point(495, 4)
        Me.lblflag.Name = "lblflag"
        Me.lblflag.Size = New System.Drawing.Size(62, 18)
        Me.lblflag.TabIndex = 74
        Me.lblflag.Visible = False
        '
        'dgvServicios
        '
        Me.dgvServicios.AllowUserToAddRows = False
        Me.dgvServicios.AllowUserToDeleteRows = False
        Me.dgvServicios.AllowUserToOrderColumns = True
        Me.dgvServicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServicios.Location = New System.Drawing.Point(5, 92)
        Me.dgvServicios.Name = "dgvServicios"
        Me.dgvServicios.ReadOnly = True
        Me.dgvServicios.Size = New System.Drawing.Size(578, 179)
        Me.dgvServicios.TabIndex = 75
        '
        'FrmConsultaServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(587, 272)
        Me.Controls.Add(Me.dgvServicios)
        Me.Controls.Add(Me.lblflag)
        Me.Controls.Add(Me.txtclase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbogrupo)
        Me.Name = "FrmConsultaServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Servicios"
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbogrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtclase As System.Windows.Forms.TextBox
    Friend WithEvents lblflag As System.Windows.Forms.Label
    Friend WithEvents dgvServicios As System.Windows.Forms.DataGridView
End Class
