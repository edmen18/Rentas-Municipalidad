Imports Datos
Imports Reglas
Imports Reportes
Public Class FrmExtorno
    Dim FunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    Private Sub FrmExtorno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaOperaciones()
    End Sub
    Sub LlenaOperaciones()
        Dim cSql As String = "SELECT distinct t_v.codventa as Operacion,Monto,Fecha,descli as Cliente,dnicli as DNI,ruccli AS RUC from t_venta t_v inner join t_detalleventa t_dv on t_v.codventa=t_dv.codventa inner join t_cliente t_c on t_c.codcli=t_v.codcli where fecha='" + CStr(Now.Date) + "'and t_dv.estado='0'"
        FunDb.FillDataGridView(cSql, Me.dgvoperaciones)
        EstiloGrid.AplicaStiloOrange(dgvoperaciones)
        EncabezadoGrid()
    End Sub

    Sub EncabezadoGrid()
        With dgvoperaciones
            .Columns(0).Width = 100
            .Columns(1).Width = 150
            .Columns(2).Width = 120
            .Columns(3).Width = 550
            .Columns(4).Width = 100
            .Columns(5).Width = 100
        End With
    End Sub
    Private Sub btnextornar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnextornar.Click
        Try
            If Me.dgvoperaciones.RowCount > 0 Then
                FrmRegistroExtorno.lbloperacion.Text = CStr(Me.dgvoperaciones.Item(0, dgvoperaciones.CurrentRow.Index).Value)
                FrmRegistroExtorno.lblmonto.Text = Format((Me.dgvoperaciones.Item(1, dgvoperaciones.CurrentRow.Index).Value), "#,##0.00")
                FrmRegistroExtorno.Dtfecha.Text = CStr(Me.dgvoperaciones.Item(2, dgvoperaciones.CurrentRow.Index).Value)
                FrmRegistroExtorno.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("seleccione un elemento de la lista", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class