Imports Reglas
Imports Datos
Public Class FrmBuscarCliente
    Dim FunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    'Dim var As New variables

    Private Sub FrmBuscarCliente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.TXTDATO.ResetText()
    End Sub

    Sub HeadGrid()
        With dgvClientes
            .Columns(0).HeaderText = "Codigo"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "Nombre del Cliente"
            .Columns(1).Width = 300
            .Columns(2).HeaderText = "Dni"
            .Columns(2).Width = 90
            .Columns(3).HeaderText = "Ruc"
            .Columns(3).Width = 90
        End With
    End Sub

    Sub LlenaLstViewnombre()
        Dim cSql As String = "select codCli,DesCli,DniCli,RucCli from t_cliente where desCli like '%" + Me.TXTDATO.Text + "%' "
        FunDb.FillDataGridView(cSql, dgvClientes)
    End Sub
    
    Private Sub TXTDATO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDATO.TextChanged
        Me.TXTDATO.CharacterCasing = CharacterCasing.Upper
        If Me.rbnombreapellidos.Checked = True Then
            LlenaLstViewnombre()
        ElseIf Me.rbdni.Checked = True Then
            LlenaLstViewdni()
        ElseIf Me.rbruc.Checked = True Then
            LlenaLstViewruc()
        End If
        HeadGrid()
    End Sub
    Sub LlenaLstViewdni()

        Dim cSql As String = "select codCli,DesCli,DniCli,RucCli from t_cliente where dniCli like '%" + Me.TXTDATO.Text + "%' "
        FunDb.FillDataGridView(cSql, dgvClientes)
    End Sub
    Sub LlenaLstViewruc()

        Dim cSql As String = "select codCli,DesCli,DniCli,RucCli from t_cliente where rucCli like '%" + Me.TXTDATO.Text + "%' "
        FunDb.FillDataGridView(cSql, dgvClientes)
    End Sub

    Private Sub rbnombreapellidos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnombreapellidos.CheckedChanged
        Me.TXTDATO.ResetText()
    End Sub

    Private Sub rbdni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdni.CheckedChanged
        Me.TXTDATO.ResetText()
    End Sub

    Private Sub rbruc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbruc.CheckedChanged
        Me.TXTDATO.ResetText()
    End Sub

    Private Sub FrmBuscarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstiloGrid.AplicaStiloBlue(dgvClientes)
    End Sub

    Private Sub dgvClientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        If Me.lblflag.Text = "1" Then
            With FrmRealizaVenta
                .lblcodigo_cli.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblnombre_cliente.Text = dgvClientes.Item(1, dgvClientes.CurrentRow.Index).Value.ToString()
                .lbldni.Text = dgvClientes.Item(2, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblruc.Text = dgvClientes.Item(3, dgvClientes.CurrentRow.Index).Value.ToString()

            End With
        ElseIf Me.lblflag.Text = "2" Then
            With FrmConsultaVenta
                .lblcodcliente.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblnombre.Text = dgvClientes.Item(1, dgvClientes.CurrentRow.Index).Value.ToString()
                .lbldni.Text = dgvClientes.Item(2, dgvClientes.CurrentRow.Index).Value.ToString()
                .HeadGrid()
                .Llenarcliente()
            End With
        ElseIf Me.lblflag.Text = "3" Then
            With FrmPredio
                .lblcodigocliente.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblDescripcion.Text = dgvClientes.Item(1, dgvClientes.CurrentRow.Index).Value.ToString()
                .lbldni.Text = dgvClientes.Item(2, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblruc.Text = dgvClientes.Item(3, dgvClientes.CurrentRow.Index).Value.ToString()
            End With
        ElseIf Me.lblflag.Text = "4" Then
            With FrmEvaluacionPredio
                .lblcodigocliente.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblDescripcion.Text = dgvClientes.Item(1, dgvClientes.CurrentRow.Index).Value.ToString()
                .lbldni.Text = dgvClientes.Item(2, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblruc.Text = dgvClientes.Item(3, dgvClientes.CurrentRow.Index).Value.ToString()
                .LlenaLstViewPredio()
            End With
        ElseIf Me.lblflag.Text = "5" Then
            With FrmDJAutovaluo
                .lblcodigocliente.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblDescripcion.Text = dgvClientes.Item(1, dgvClientes.CurrentRow.Index).Value.ToString()
                .lbldni.Text = dgvClientes.Item(2, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblruc.Text = dgvClientes.Item(3, dgvClientes.CurrentRow.Index).Value.ToString()
                .GetDatosPredio(.lblcodigocliente.Text)
            End With

        ElseIf Me.lblflag.Text = "6" Then
            With FrmConsultaHRPU
                .lblcodigocliente.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblDescripcion.Text = dgvClientes.Item(1, dgvClientes.CurrentRow.Index).Value.ToString()
                .lbldni.Text = dgvClientes.Item(2, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblruc.Text = dgvClientes.Item(3, dgvClientes.CurrentRow.Index).Value.ToString()
                .LlenaLstViewDj()
            End With
        ElseIf Me.lblflag.Text = "7" Then
            With FrmPagos
                .lblcodigocliente.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblDescripcion.Text = dgvClientes.Item(1, dgvClientes.CurrentRow.Index).Value.ToString()
                .lbldni.Text = dgvClientes.Item(2, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblruc.Text = dgvClientes.Item(3, dgvClientes.CurrentRow.Index).Value.ToString()
                .LlenadgvDj()
            End With
        ElseIf Me.lblflag.Text = "8" Then
            With FrmOrdenPago
                .lblcodigocliente.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblDescripcion.Text = dgvClientes.Item(1, dgvClientes.CurrentRow.Index).Value.ToString()
                .lbldni.Text = dgvClientes.Item(2, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblruc.Text = dgvClientes.Item(3, dgvClientes.CurrentRow.Index).Value.ToString()
                .AplicaEstilo()
                .LlenaLstViewtrim()
                .HeadGrid()
                .ultimadj()
            End With
        ElseIf Me.lblflag.Text = "9" Then
            With FrmConsultaOrdenPago
                .lblcodigocliente.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblDescripcion.Text = dgvClientes.Item(1, dgvClientes.CurrentRow.Index).Value.ToString()
                .lbldni.Text = dgvClientes.Item(2, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblruc.Text = dgvClientes.Item(3, dgvClientes.CurrentRow.Index).Value.ToString()
                .LlenaLstViewOrdenes()
            End With

        ElseIf Me.lblflag.Text = "10" Then
            With FrmCancelarOP
                .lblcodigocliente.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblDescripcion.Text = dgvClientes.Item(1, dgvClientes.CurrentRow.Index).Value.ToString()
                .lbldni.Text = dgvClientes.Item(2, dgvClientes.CurrentRow.Index).Value.ToString()
                .lblruc.Text = dgvClientes.Item(3, dgvClientes.CurrentRow.Index).Value.ToString()
                .LlenaLstViewOrdenes()
            End With
        End If

        Me.Close()
    End Sub


    Private Sub dgvClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick

    End Sub
End Class