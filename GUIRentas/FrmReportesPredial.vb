Imports Datos
Imports Reglas
Imports Reportes

Public Class FrmReportesPredial
    Dim cpagos As New Cl_Pagos
    Dim crec As New Cl_ReciboAutovaluo
    Dim imp As New C_imprime
    Dim corden As New Cl_OrdenPago
    Dim CLEMPOCE As New Cl_Empoce
    Dim Entidad As New Cl_Entidad

    Private Sub FrmReportesPredial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label2.Visible = False
        Me.Label3.Visible = False
        Me.DtAl.Visible = False
        Me.DtDel.Visible = False
    End Sub

    Private Sub BtnVerReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerReporte.Click
        If Me.rbtrimestreactualvencido.Checked = True Then
            Dim cr As New Cr_trimestresvencidos
            cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre + "'"
            cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc + "'"

            imp.reporte(cpagos.Imprimetrimestresv, cr)
        End If
        If Me.RbRecibos.Checked = True Then
            Dim cr As New Cr_RecibosAutovaluo
            cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre + "'"
            cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc + "'"

            cr.DataDefinition.FormulaFields.Item("fechaini").Text = "'" + Me.DtDel.Text + "'"
            cr.DataDefinition.FormulaFields.Item("fechafin").Text = "'" + Me.DtAl.Text + "'"
            imp.reporte(crec.RecibosEmitidos(Me.DtDel.Value.Date, Me.DtAl.Value.Date), cr)
        End If
        If Me.rbordenesd.Checked = True Then
            Dim cr As New Cr_OrdenesD
            cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre + "'"
            cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc + "'"

            imp.reporte(corden.reporteOrdenes(), cr)
        End If
        If Me.rbordenesc.Checked = True Then
            Dim cr As New Cr_OrdenesC
            cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre + "'"
            cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc + "'"

            imp.reporte(corden.reporteOrdenesC(), cr)
        End If
        If Me.RbBalance.Checked = True Then
            Dim cr As New Cr_Balance
            cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre + "'"
            cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc + "'"

            cr.DataDefinition.FormulaFields.Item("fechadel").Text = "'" + Me.DtDel.Text + "'"
            cr.DataDefinition.FormulaFields.Item("fechaal").Text = "'" + Me.DtAl.Text + "'"
            imp.reporte(CLEMPOCE.balance(Me.DtDel.Value.Date, Me.DtAl.Value.Date), cr)
        End If
    End Sub

    Private Sub RbRecibos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RbRecibos.Click
        Me.Label2.Visible = True
        Me.Label3.Visible = True
        Me.DtAl.Visible = True
        Me.DtDel.Visible = True
    End Sub

    Private Sub rbtrimestreactualvencido_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtrimestreactualvencido.Click
        Me.Label2.Visible = False
        Me.Label3.Visible = False
        Me.DtAl.Visible = False
        Me.DtDel.Visible = False
    End Sub

    Private Sub rbordenesd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbordenesd.Click
        Me.Label2.Visible = False
        Me.Label3.Visible = False
        Me.DtAl.Visible = False
        Me.DtDel.Visible = False
    End Sub

    Private Sub RbBalance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RbBalance.Click
        Me.Label2.Visible = True
        Me.Label3.Visible = True
        Me.DtAl.Visible = True
        Me.DtDel.Visible = True
    End Sub
End Class