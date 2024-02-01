<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBackup
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.TxtDestino = New DevExpress.XtraEditors.ButtonEdit
        Me.BtnCrearBk = New System.Windows.Forms.Button
        Me.FldrView = New System.Windows.Forms.FolderBrowserDialog
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TxtDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TxtDestino)
        Me.GroupControl1.Controls.Add(Me.BtnCrearBk)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(382, 99)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Seleccione Destino..."
        '
        'TxtDestino
        '
        Me.TxtDestino.Location = New System.Drawing.Point(5, 35)
        Me.TxtDestino.Name = "TxtDestino"
        Me.TxtDestino.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDestino.Properties.Appearance.Options.UseFont = True
        Me.TxtDestino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.TxtDestino.Size = New System.Drawing.Size(366, 18)
        Me.TxtDestino.TabIndex = 3
        '
        'BtnCrearBk
        '
        Me.BtnCrearBk.Image = Global.GUIRentas.My.Resources.Resources._06
        Me.BtnCrearBk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrearBk.Location = New System.Drawing.Point(241, 61)
        Me.BtnCrearBk.Name = "BtnCrearBk"
        Me.BtnCrearBk.Size = New System.Drawing.Size(130, 23)
        Me.BtnCrearBk.TabIndex = 2
        Me.BtnCrearBk.Text = "Realizar Copia"
        Me.BtnCrearBk.UseVisualStyleBackColor = True
        '
        'FrmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 99)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup de la Base de datos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.TxtDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtDestino As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents BtnCrearBk As System.Windows.Forms.Button
    Friend WithEvents FldrView As System.Windows.Forms.FolderBrowserDialog
End Class
