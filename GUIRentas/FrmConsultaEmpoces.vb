Imports Datos
Imports Reglas
Imports Reportes
Public Class FrmConsultaEmpoces
    Dim FunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim cimpr As New C_imprime
    Dim cempoce As New Cl_Empoce
    Dim Entidad As New Cl_Entidad
    Dim validar As New Cl_Validar

    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click
        If rbFechas.Checked = True Then
            LlenarempocexFecha()
        Else
            LlenarempocexNumPapeleta()
        End If

    End Sub
    Sub LlenarempocexFecha()
        Dim cSql As String = "select NumPapeleta,tc.CodCta,tc.Descripcion,entidad,convert(varchar(10),Fechadel,103)+' Al '+convert(varchar(10),Fechaal,103),RESPONSABLE,monto from t_empoce te inner join t_cuenta tc on tc.codcta=te.codcta where te.fechadel>='" + CStr(Me.dtfechadel.Value.Date) + "' and te.fechaal<='" + CStr(Me.dtfechaal.Value.Date) + "'"
        FunDb.FillDataGridView(cSql, dgvEmpoces)
        EstiloGrid.AplicaStiloBlue(dgvEmpoces)
    End Sub

    Sub LlenarempocexNumPapeleta()
        Dim cSql As String = "select NumPapeleta,tc.CodCta,tc.Descripcion,entidad,convert(varchar(10),Fechadel,103)+' Al '+convert(varchar(10),Fechaal,103),RESPONSABLE,monto from t_empoce te inner join t_cuenta tc on tc.codcta=te.codcta where NumPapeleta = '" + Me.txtNumPapeleta.Text + "'"
        FunDb.FillDataGridView(cSql, dgvEmpoces)
        EstiloGrid.AplicaStiloBlue(dgvEmpoces)
    End Sub

    Private Sub btnverdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverdetalle.Click
        If dgvEmpoces.RowCount > 0 Then
            Dim cr As New Cr_DetalleEmpoce

            cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre.ToString() + "'"
            cr.DataDefinition.FormulaFields.Item("ruc").Text = "'" + Entidad.Ruc.ToString() + "'"

            cimpr.reporte(cempoce.detalleempoce(dgvEmpoces.Item(0, dgvEmpoces.CurrentRow.Index).Value), cr)
        Else
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim cr As New Cr_ReporteEmpoces

        cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre.ToString() + "'"
        cr.DataDefinition.FormulaFields.Item("ruc").Text = "'" + Entidad.Ruc.ToString() + "'"

        cr.DataDefinition.FormulaFields.Item("fechadel").Text = "'" + Me.dtfechadel.Text + "'"
        cr.DataDefinition.FormulaFields.Item("fechaal").Text = "'" + Me.dtfechaal.Text + "'"
        cimpr.reporte(cempoce.Reporteempoce(Me.dtfechadel.Value.Date, Me.dtfechaal.Value.Date), cr)
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtNumPapeleta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumPapeleta.KeyPress
        e.Handled = Validar.NumerosEnteros(System.Convert.ToInt16(Asc(e.KeyChar)))
    End Sub

   

 
End Class