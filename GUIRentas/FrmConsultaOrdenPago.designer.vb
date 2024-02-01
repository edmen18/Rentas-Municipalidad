<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaOrdenPago
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
        Me.lvwDetalle = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.lvwordenes = New System.Windows.Forms.ListView
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.BtnImprimir = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblcodigocliente)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.lblruc)
        Me.GroupBox1.Controls.Add(Me.lbldni)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(281, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 77)
        Me.GroupBox1.TabIndex = 13
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
        Me.BtnBuscar.Image = Global.GUIRentas.My.Resources.Resources._30
        Me.BtnBuscar.Location = New System.Drawing.Point(438, 23)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(83, 48)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'lblruc
        '
        Me.lblruc.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblruc.Location = New System.Drawing.Point(334, 49)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(98, 20)
        Me.lblruc.TabIndex = 5
        '
        'lbldni
        '
        Me.lbldni.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lbldni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldni.Location = New System.Drawing.Point(85, 49)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(86, 20)
        Me.lbldni.TabIndex = 4
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescripcion.Location = New System.Drawing.Point(85, 23)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(347, 20)
        Me.lblDescripcion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "R.U.C."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 56)
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
        'lvwDetalle
        '
        Me.lvwDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwDetalle.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvwDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwDetalle.FullRowSelect = True
        Me.lvwDetalle.GridLines = True
        Me.lvwDetalle.Location = New System.Drawing.Point(12, 95)
        Me.lvwDetalle.Name = "lvwDetalle"
        Me.lvwDetalle.Size = New System.Drawing.Size(1122, 218)
        Me.lvwDetalle.TabIndex = 30
        Me.lvwDetalle.UseCompatibleStateImageBehavior = False
        Me.lvwDetalle.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Año"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Base Imponible"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 103
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tramo de Autovaluo"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 115
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ali Cuota"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 148
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Insolutos"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 149
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Imp Anual"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 76
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Trimestres"
        Me.ColumnHeader7.Width = 132
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Insoluto"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 81
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Reajuste"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 79
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Interes"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 71
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Total"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 99
        '
        'lvwordenes
        '
        Me.lvwordenes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwordenes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lvwordenes.FullRowSelect = True
        Me.lvwordenes.Location = New System.Drawing.Point(825, 13)
        Me.lvwordenes.Name = "lvwordenes"
        Me.lvwordenes.Size = New System.Drawing.Size(215, 77)
        Me.lvwordenes.TabIndex = 31
        Me.lvwordenes.UseCompatibleStateImageBehavior = False
        Me.lvwordenes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Orden de Pago"
        Me.ColumnHeader12.Width = 98
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Fecha"
        Me.ColumnHeader13.Width = 104
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImprimir.Image = Global.GUIRentas.My.Resources.Resources._20
        Me.BtnImprimir.Location = New System.Drawing.Point(1046, 12)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(88, 78)
        Me.BtnImprimir.TabIndex = 32
        Me.BtnImprimir.Text = "&Imprime"
        Me.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUIRentas.My.Resources.Resources.SRM
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'FrmConsultaOrdenPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1140, 317)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.lvwordenes)
        Me.Controls.Add(Me.lvwDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmConsultaOrdenPago"
        Me.Text = "Consultar Orden de Pago"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lvwDetalle As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwordenes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
