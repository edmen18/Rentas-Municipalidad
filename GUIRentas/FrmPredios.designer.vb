<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPredios
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
        Me.DgvPredios = New System.Windows.Forms.DataGridView
        CType(Me.DgvPredios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvPredios
        '
        Me.DgvPredios.AllowUserToAddRows = False
        Me.DgvPredios.AllowUserToDeleteRows = False
        Me.DgvPredios.AllowUserToOrderColumns = True
        Me.DgvPredios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPredios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPredios.Location = New System.Drawing.Point(0, 0)
        Me.DgvPredios.Name = "DgvPredios"
        Me.DgvPredios.ReadOnly = True
        Me.DgvPredios.Size = New System.Drawing.Size(604, 154)
        Me.DgvPredios.TabIndex = 0
        '
        'FrmPredios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 154)
        Me.Controls.Add(Me.DgvPredios)
        Me.MaximizeBox = False
        Me.Name = "FrmPredios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Predios declarados"
        CType(Me.DgvPredios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvPredios As System.Windows.Forms.DataGridView
End Class
