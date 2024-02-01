<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaHRPU
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
        Me.lblcodigocliente = New System.Windows.Forms.Label
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.lblruc = New System.Windows.Forms.Label
        Me.lbldni = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LvwDj = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.LvwTrimestres = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.btnhHR = New System.Windows.Forms.Button
        Me.BtnPU = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnCoactivos = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblcodigocliente)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.lblruc)
        Me.GroupBox1.Controls.Add(Me.lbldni)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 77)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Contribuyente"
        '
        'lblcodigocliente
        '
        Me.lblcodigocliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigocliente.Location = New System.Drawing.Point(19, 78)
        Me.lblcodigocliente.Name = "lblcodigocliente"
        Me.lblcodigocliente.Size = New System.Drawing.Size(93, 18)
        Me.lblcodigocliente.TabIndex = 7
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.GUIRentas.My.Resources.Resources._08
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(337, 49)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(95, 23)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.Text = "&Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'lblruc
        '
        Me.lblruc.BackColor = System.Drawing.Color.White
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblruc.Location = New System.Drawing.Point(233, 49)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(98, 20)
        Me.lblruc.TabIndex = 5
        Me.lblruc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldni
        '
        Me.lbldni.BackColor = System.Drawing.Color.White
        Me.lbldni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldni.Location = New System.Drawing.Point(85, 49)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(86, 20)
        Me.lbldni.TabIndex = 4
        Me.lbldni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.Color.White
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescripcion.Location = New System.Drawing.Point(85, 23)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(347, 20)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "R.U.C."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "D.N.I."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion"
        '
        'LvwDj
        '
        Me.LvwDj.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader8})
        Me.LvwDj.GridLines = True
        Me.LvwDj.Location = New System.Drawing.Point(6, 19)
        Me.LvwDj.Name = "LvwDj"
        Me.LvwDj.Size = New System.Drawing.Size(194, 153)
        Me.LvwDj.TabIndex = 5
        Me.LvwDj.UseCompatibleStateImageBehavior = False
        Me.LvwDj.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Declaración Jurada Nª"
        Me.ColumnHeader1.Width = 121
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Año"
        Me.ColumnHeader2.Width = 68
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Arancel"
        Me.ColumnHeader8.Width = 0
        '
        'LvwTrimestres
        '
        Me.LvwTrimestres.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LvwTrimestres.GridLines = True
        Me.LvwTrimestres.Location = New System.Drawing.Point(8, 19)
        Me.LvwTrimestres.Name = "LvwTrimestres"
        Me.LvwTrimestres.Size = New System.Drawing.Size(458, 152)
        Me.LvwTrimestres.TabIndex = 6
        Me.LvwTrimestres.UseCompatibleStateImageBehavior = False
        Me.LvwTrimestres.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = " codtrim"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Trimestre"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Fech. Venc."
        Me.ColumnHeader5.Width = 224
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Monto"
        Me.ColumnHeader6.Width = 103
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Estado"
        '
        'btnhHR
        '
        Me.btnhHR.Image = Global.GUIRentas.My.Resources.Resources._12g
        Me.btnhHR.Location = New System.Drawing.Point(463, 21)
        Me.btnhHR.Name = "btnhHR"
        Me.btnhHR.Size = New System.Drawing.Size(75, 63)
        Me.btnhHR.TabIndex = 7
        Me.btnhHR.Text = "HR"
        Me.btnhHR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnhHR.UseVisualStyleBackColor = True
        '
        'BtnPU
        '
        Me.BtnPU.Image = Global.GUIRentas.My.Resources.Resources._16g
        Me.BtnPU.Location = New System.Drawing.Point(544, 21)
        Me.BtnPU.Name = "BtnPU"
        Me.BtnPU.Size = New System.Drawing.Size(75, 63)
        Me.BtnPU.TabIndex = 8
        Me.BtnPU.Text = "PU"
        Me.BtnPU.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPU.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LvwDj)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 183)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Declaraciones Juradas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LvwTrimestres)
        Me.GroupBox3.Location = New System.Drawing.Point(225, 95)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(472, 183)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Trimestres de Pagos"
        '
        'btnCoactivos
        '
        Me.btnCoactivos.Image = Global.GUIRentas.My.Resources.Resources._65
        Me.btnCoactivos.Location = New System.Drawing.Point(625, 21)
        Me.btnCoactivos.Name = "btnCoactivos"
        Me.btnCoactivos.Size = New System.Drawing.Size(75, 63)
        Me.btnCoactivos.TabIndex = 11
        Me.btnCoactivos.Text = "&Salir"
        Me.btnCoactivos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCoactivos.UseVisualStyleBackColor = True
        '
        'FrmConsultaHRPU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 284)
        Me.Controls.Add(Me.btnCoactivos)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnPU)
        Me.Controls.Add(Me.btnhHR)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmConsultaHRPU"
        Me.Text = "Consulta de Pagos HR PU"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcodigocliente As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblruc As System.Windows.Forms.Label
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LvwDj As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LvwTrimestres As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnhHR As System.Windows.Forms.Button
    Friend WithEvents BtnPU As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCoactivos As System.Windows.Forms.Button
End Class
