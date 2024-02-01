<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRestauraBD
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
        Me.TxtServer = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtBackup = New DevExpress.XtraEditors.ButtonEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnRestore = New System.Windows.Forms.Button
        Me.txtBase = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.FileDialog = New System.Windows.Forms.OpenFileDialog
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TxtBackup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TxtServer)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.TxtBackup)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.btnRestore)
        Me.GroupControl1.Controls.Add(Me.txtBase)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(459, 130)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Restaurar Base de datos"
        '
        'TxtServer
        '
        Me.TxtServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtServer.Location = New System.Drawing.Point(96, 23)
        Me.TxtServer.Name = "TxtServer"
        Me.TxtServer.Size = New System.Drawing.Size(351, 18)
        Me.TxtServer.TabIndex = 19
        Me.TxtServer.Text = "(LOCAL)\SQLEXPRESS"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Servidor:"
        '
        'TxtBackup
        '
        Me.TxtBackup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBackup.Location = New System.Drawing.Point(96, 77)
        Me.TxtBackup.Name = "TxtBackup"
        Me.TxtBackup.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBackup.Properties.Appearance.Options.UseFont = True
        Me.TxtBackup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.TxtBackup.Size = New System.Drawing.Size(351, 18)
        Me.TxtBackup.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Backup:"
        '
        'btnRestore
        '
        Me.btnRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestore.Image = Global.GUIRentas.My.Resources.Resources._35
        Me.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestore.Location = New System.Drawing.Point(319, 102)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(128, 23)
        Me.btnRestore.TabIndex = 16
        Me.btnRestore.Text = "Restaurar copia"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'txtBase
        '
        Me.txtBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBase.Location = New System.Drawing.Point(96, 48)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(351, 18)
        Me.txtBase.TabIndex = 14
        Me.txtBase.Text = "DBRENTAS"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Base datos:"
        '
        'FileDialog
        '
        Me.FileDialog.FileName = "OpenFileDialog1"
        '
        'FrmRestauraBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 130)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmRestauraBD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurar Base de Datos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TxtBackup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtBackup As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents btnRestore As System.Windows.Forms.Button
    Private WithEvents txtBase As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents TxtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FileDialog As System.Windows.Forms.OpenFileDialog
End Class
