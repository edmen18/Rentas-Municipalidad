<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExtorno
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
        Me.dgvoperaciones = New System.Windows.Forms.DataGridView
        Me.btnextornar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        CType(Me.dgvoperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvoperaciones
        '
        Me.dgvoperaciones.AllowUserToAddRows = False
        Me.dgvoperaciones.AllowUserToDeleteRows = False
        Me.dgvoperaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvoperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvoperaciones.Location = New System.Drawing.Point(2, 3)
        Me.dgvoperaciones.Name = "dgvoperaciones"
        Me.dgvoperaciones.ReadOnly = True
        Me.dgvoperaciones.Size = New System.Drawing.Size(653, 204)
        Me.dgvoperaciones.TabIndex = 1
        '
        'btnextornar
        '
        Me.btnextornar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnextornar.Image = Global.GUIRentas.My.Resources.Resources._19s
        Me.btnextornar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnextornar.Location = New System.Drawing.Point(220, 213)
        Me.btnextornar.Name = "btnextornar"
        Me.btnextornar.Size = New System.Drawing.Size(102, 23)
        Me.btnextornar.TabIndex = 2
        Me.btnextornar.Text = "&Extornar"
        Me.btnextornar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSalir.Image = Global.GUIRentas.My.Resources.Resources._41
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(328, 213)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(95, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FrmExtorno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 248)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnextornar)
        Me.Controls.Add(Me.dgvoperaciones)
        Me.Name = "FrmExtorno"
        Me.Text = "Extorno de operaciones del dia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvoperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvoperaciones As System.Windows.Forms.DataGridView
    Friend WithEvents btnextornar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
