Imports Datos
Imports Reglas
Public Class FrmCliente

    Dim FunDb As New cFuncionesDB
    Dim Cliente As New C_Cliente
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim validar As New Cl_Validar
    Dim Sw As String
    Dim contador As Integer = 0
    Dim contador2 As Integer = 0

    Private Sub FrmCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LLenarTipoPersona()
        LlenaLstViewCliente()
        EstiloGrid.AplicaStiloBlue(dgvClientes)
        HeadGrid()
    End Sub

    ''' <summary>
    ''' Metodos
    ''' </summary>
    ''' <remarks></remarks>

    Sub AsignarVariables()
        Cliente.CodCli = Me.txtCodCli.Text
        Cliente.CodTipoPer = Me.cmbTipoPer.SelectedValue.ToString
        Cliente.NomCli = Me.txtNomCli.Text
        Cliente.DirCli = Me.txtDirCli.Text
        Cliente.DniCli = Me.txtDni.Text
        Cliente.RucCli = Me.txtRuc.Text
        Cliente.RepLeg = Me.txtRepLeg.Text
        Cliente.TelCli = Me.txtTel.Text
        Cliente.Email = Me.txtEmail.Text
        Cliente.Numero = Me.txtnumero.Text
        Cliente.Manzana = Me.txtmz.Text
        Cliente.Lote = Me.txtlote.Text
    End Sub

    Sub LLenarTipoPersona()
        Dim cSql As String = "SELECT * FROM T_TIPOPERSONA"
        FunDb.FillListaOrCombo(cSql, Me.cmbTipoPer, "DesTipPer", "CodTipPer")
    End Sub

    Sub LlenaLstViewCliente()
        Dim cSql As String = "SELECT C.CodCli,P.DesTipPer,C.DesCli,C.DirCli,C.DniCli,C.RucCli,C.RepLeg,C.TelCli,C.email  FROM T_CLIENTE C INNER JOIN T_TIPOPERSONA P ON C.CodTipPer = P.CodTipPer"
        FunDb.FillDataGridView(cSql, dgvClientes)
    End Sub
    Sub LlenaLstViewPredios()
        Dim cSql As String = "select CodPredio from dbo.T_Predio where codcli='" + Me.txtCodCli.Text + "'"
        FunDb.FillListview(cSql, lvwpredios)
    End Sub
    Sub LlenaLstViewventas()
        Dim cSql As String = "select Codventa from dbo.T_venta where codcli='" + Me.txtCodCli.Text + "'"
        FunDb.FillListview(cSql, lvwventas)
    End Sub

    Sub GetDatosCliente(ByVal codigoCliente As String)
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "SELECT C.CodCli,P.DesTipPer,C.DesCli,C.DirCli,C.DniCli,C.RucCli,C.RepLeg,C.TelCli,C.email,NUMERO,LOTE,MANZANA  FROM T_CLIENTE C INNER JOIN T_TIPOPERSONA P ON C.CodTipPer = P.CodTipPer WHERE C.CodCli = '" + codigoCliente + "'"
            dt = cFun.ConsultaX(csql)
            Me.txtCodCli.Text = CStr(dt.Rows(0).Item(0))
            Me.cmbTipoPer.Text = CStr(dt.Rows(0).Item(1))
            Me.txtNomCli.Text = CStr(dt.Rows(0).Item(2))
            Me.txtDirCli.Text = CStr(dt.Rows(0).Item(3))
            Me.txtDni.Text = CStr(dt.Rows(0).Item(4))
            Me.txtRuc.Text = CStr(dt.Rows(0).Item(5))
            Me.txtRepLeg.Text = CStr(dt.Rows(0).Item(6))
            Me.txtTel.Text = CStr(dt.Rows(0).Item(7))
            Me.txtEmail.Text = CStr(dt.Rows(0).Item(8))
            Me.txtnumero.Text = CStr(dt.Rows(0).Item(9))
            Me.txtlote.Text = CStr(dt.Rows(0).Item(10))
            Me.txtmz.Text = CStr(dt.Rows(0).Item(11))
            'Return True
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub HeadGrid()
        Try
            With dgvClientes
                .Columns(0).HeaderText = "Codigo"
                .Columns(0).Width = 90
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "Nombre de Contribuyente"
                .Columns(2).Width = 200
                .Columns(3).HeaderText = "Direccion"
                .Columns(3).Width = 200
                .Columns(4).HeaderText = "Dni"
                .Columns(4).Width = 80
                .Columns(5).HeaderText = "Ruc"
                .Columns(5).Width = 80
                .Columns(6).Visible = False
                .Columns(7).HeaderText = "Telefono"
                .Columns(7).Width = 80
                .Columns(8).HeaderText = "Email"
                .Columns(8).Width = 120
            End With
        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub

    Private Sub Limpiar_Cajas(ByVal f As GroupBox)
        ' recorrer todos los controles del formulario indicado   
        For Each c As Control In f.Controls
            If TypeOf c Is TextBox Then
                c.ResetText() ' eliminar el texto   
            End If
        Next
    End Sub


    ''' <summary>
    ''' Mantenimiento
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub btnNuevo_Clic(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Sw = "Agregar"
        btnCancelar.PerformClick()
        Me.txtCodCli.Text = Format(CDbl(Cliente.GeneraCodCliente()) + 1, "0000000000")
        Me.txtNomCli.Focus()
        btnActualizar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        If Me.txtCodCli.Text = "" Or Me.txtNomCli.Text = "" Then
            MessageBox.Show("No hay datos que Agregar o Modificar", "Registro Contribuyente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        AsignarVariables()
        If Sw = "Agregar" Then

            Cliente.AltaCliente()
        Else
            Cliente.ModificarCliente(Me.txtCodCli.Text)
        End If
        LlenaLstViewCliente()
        btnActualizar.Enabled = False
        btnNuevo.Enabled = True
    End Sub

    Private Sub txtBusqueda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBusqueda.Click
        Me.txtBusqueda.ResetText()
    End Sub

    

    Private Sub txtBusqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim cSql As String = "SELECT C.CodCli,P.DesTipPer,C.DesCli,C.DirCli,C.DniCli,C.RucCli,C.RepLeg,C.TelCli,C.email  FROM T_CLIENTE C INNER JOIN T_TIPOPERSONA P ON C.CodTipPer = P.CodTipPer WHERE C.Descli like '" + Me.txtBusqueda.Text + "%'"
            FunDb.FillDataGridView(cSql, dgvClientes)
        End If
    End Sub

    Private Sub txtBusqueda_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBusqueda.LostFocus
        If Me.txtBusqueda.Text = "" Then
            Me.txtBusqueda.Text = "ingrese contribuyente a consultar..."
        End If
    End Sub

    ''' <summary>
    ''' Controladores de Eventos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
 

    Private Sub cmbTipoPer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoPer.SelectedIndexChanged
        If Me.cmbTipoPer.SelectedIndex = 0 Then
            Me.txtRuc.Enabled = False
            Me.txtRepLeg.Enabled = False
        Else
            Me.txtRuc.Enabled = True
            Me.txtRepLeg.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Textos a Mayusculas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 

    Private Sub txtNomCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomCli.TextChanged
        txtNomCli.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub txtDirCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDirCli.TextChanged
        Me.txtDirCli.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub txtRepLeg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRepLeg.TextChanged
        Me.txtRepLeg.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged
        Me.txtEmail.CharacterCasing = CharacterCasing.Lower
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        For i = 0 To Me.lvwpredios.Items.Count - 1
            contador = contador + 1
        Next
        For i = 0 To Me.lvwventas.Items.Count - 1
            contador2 = contador2 + 1
        Next
        If contador > 0 Or contador2 > 0 Then
            MessageBox.Show("No es posible eliminar este contribuyente ya que ha realizado transacciones en el sistema", "Contribuyente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnCancelar.PerformClick()
        ElseIf contador = 0 And contador2 = 0 Then
            If Cliente.EliminarCliente(Me.txtCodCli.Text) = True Then
                LlenaLstViewCliente()
                Limpiar_Cajas(gruCliente)
            End If
        End If
        contador = 0
        contador2 = 0

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call Limpiar_Cajas(gruCliente)
        Me.lvwpredios.Items.Clear()
        lvwventas.Items.Clear()
        btnActualizar.Enabled = False
        btnNuevo.Enabled = True
    End Sub
    
    Private Sub dgvClientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        Sw = "Editar"
        Try
            Dim codCliente As String = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value
            GetDatosCliente(codCliente)
            Me.btnActualizar.Enabled = True
            Me.btnEliminar.Enabled = True
            LlenaLstViewPredios()
            LlenaLstViewventas()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmCliente_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            With dgvClientes
                .Columns(2).Width = .Width - (.Columns(0).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width)
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtnumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumero.KeyPress
        e.Handled = Validar.NumerosEnteros(System.Convert.ToInt16(Asc(e.KeyChar)))
    End Sub

    Private Sub txtmz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmz.TextChanged
        Me.txtmz.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub dgvClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick

    End Sub
End Class