Imports Reglas
Imports Datos
Imports Reportes
Public Class FrmConsultaExtorno
    Dim FunDb As New cFuncionesDB
    Dim clextorno As New Cl_Extorno
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim Entidad As New Cl_Entidad
    Dim cimp As New C_imprime
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        LlenaExtornos()
        sumar()
    End Sub
    Sub LlenaExtornos()
        Dim cSql As String = "select CodExtorno,FechaExtorno,CodOperacion,FechaOperacion,Monto,t_e.usuario,descripcion from dbo.T_Extorno t_e inner join t_motivoextorno t_me on t_me.codmotivo=t_e.codmotivo where FechaExtorno>='" + CStr(Me.dtdel.Value.Date) + "' and FechaExtorno<='" + CStr(Me.dtal.Value.Date) + "'"
        FunDb.FillDataGridView(cSql, Me.dgvextorno)
        HeadGrid()
        EstiloGrid.AplicaStiloOrange(dgvextorno)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim cr As New Cr_Extornos
        cr.DataDefinition.FormulaFields.Item("fechadel").Text = "'" + Me.dtdel.Text + "'"
        cr.DataDefinition.FormulaFields.Item("fechaal").Text = "'" + Me.dtal.Text + "'"
        cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre + "'"
        cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc + "'"

        cimp.reporte(clextorno.ReporteExtornos(Me.dtdel.Value.Date, Me.dtal.Value.Date), cr)
    End Sub
    Sub sumar()
        Me.lbltotal.Text = "0.00"
        For i = 0 To Me.dgvextorno.RowCount - 1
            Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.dgvextorno.Item(4, i).Value), "#,##0.00")
        Next
    End Sub

    Sub HeadGrid()
        With dgvextorno
            .Columns(0).HeaderText = "Codigo"
            .Columns(1).HeaderText = "Fecha Extorno"
            .Columns(2).HeaderText = "Recibo"
            .Columns(3).HeaderText = "Fecha Operacion"
            .Columns(4).HeaderText = "Monto"
            .Columns(4).Width = 120
        End With
    End Sub
End Class