Imports Reportes
Imports Reglas
Public Class MdiPrincipal
    Dim Imprime As New C_imprime
    Dim Clase As New Cl_clase
    Dim Entidad As New Cl_Entidad

    Sub MostrarForm(ByRef Formx As Form)
        Formx.TopLevel = False
        Formx.Parent = ClientPanel
        Formx.Show()
    End Sub

    Private Sub btnContribuyente_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnContribuyente.ItemClick
        MostrarForm(FrmCliente)
    End Sub

    Private Sub btnFacturar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFacturar.ItemClick
        MostrarForm(FrmRealizaVenta)
    End Sub

    Private Sub btnEmpoces_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmpoces.ItemClick
        MostrarForm(FrmEmpoce)
    End Sub

    Private Sub btnTasas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTasas.ItemClick
        MostrarForm(FrmRegistros)
    End Sub

    Private Sub btnCuentasCts_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCuentasCts.ItemClick
        MostrarForm(FrmCuentas)
    End Sub

    Private Sub btnDepreciacion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDepreciacion.ItemClick
        MostrarForm(FrmDepreciacion)
    End Sub

    Private Sub btnConsultaEmpoce_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultaEmpoce.ItemClick
        MostrarForm(FrmConsultaEmpoces)
    End Sub

    Private Sub btnServicios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnServicios.ItemClick
        MostrarForm(FrmConsultaVenta)
    End Sub

    Private Sub btnEvaluacionPredio_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEvaluacionPredio.ItemClick
        MostrarForm(FrmEvaluacionPredio)
    End Sub

    Private Sub btnPredios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPredios.ItemClick
        MostrarForm(FrmPredio)
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        MostrarForm(FrmPrueba)
    End Sub

    Private Sub btnDeclaracionJurada_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeclaracionJurada.ItemClick
        MostrarForm(FrmDJAutovaluo)
    End Sub

    Private Sub btnTrimestres_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTrimestres.ItemClick
        MostrarForm(FrmTrimestres)
    End Sub

    Private Sub btnMotivos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMotivos.ItemClick
        MostrarForm(FrmMotivosDJ)
    End Sub

    Private Sub btnZona_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnZona.ItemClick
        MostrarForm(FrmZona)
    End Sub

    Private Sub btnCondicion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCondicion.ItemClick
        MostrarForm(FrmCondicion)
    End Sub

    Private Sub btnConsultaHRPu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultaHRPu.ItemClick
        MostrarForm(FrmConsultaHRPU)
    End Sub

    Private Sub btnMontoMinimo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMontoMinimo.ItemClick
        MostrarForm(FrmMontoMinimo)
    End Sub

    Private Sub btnFactorReajuste_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFactorReajuste.ItemClick
        MostrarForm(FrmFactorReajuste)
    End Sub

    Private Sub btnPagos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPagos.ItemClick
        MostrarForm(FrmPagos)
    End Sub

    Private Sub btnReportes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReportes.ItemClick
        MostrarForm(Frmreportes)
    End Sub

    Private Sub btnExtornos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExtornos.ItemClick
        MostrarForm(FrmExtorno)
    End Sub

    Private Sub btnConsulExt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsulExt.ItemClick
        MostrarForm(FrmConsultaExtorno)
    End Sub

    Private Sub btnRepPredial_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepPredial.ItemClick
        MostrarForm(FrmReportesPredial)
    End Sub

    Private Sub btnOrden_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOrden.ItemClick
        MostrarForm(FrmOrdenPago)
    End Sub

    Private Sub btnPagarOrden_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPagarOrden.ItemClick
        MostrarForm(FrmCancelarOP)
    End Sub

    Private Sub btnConsultaOrden_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultaOrden.ItemClick
        MostrarForm(FrmConsultaOrdenPago)
    End Sub

    Private Sub btnUsuarios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUsuarios.ItemClick
        MostrarForm(FrmUsuarios)
    End Sub


    Private Sub btnSalir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Me.Close()
    End Sub



    Private Sub MdiPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim respuesta As DialogResult
        respuesta = MessageBox.Show("Desea abondar el Sistema", "SRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = Windows.Forms.DialogResult.Yes Then
            Me.Dispose()
            End
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub btnCopiaBD_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCopiaBD.ItemClick
        MostrarForm(FrmBackup)
    End Sub

    Private Sub btnRestauraBd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRestauraBd.ItemClick
        MostrarForm(FrmRestauraBD)
    End Sub

    Private Sub btnAcerca_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAcerca.ItemClick
        MostrarForm(FrmAbout)
    End Sub

    Private Sub btnListaTUO_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnListaTUO.ItemClick
        Dim cr As New Cr_TUOT
        cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre + "'"
        cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc + "'"
        Imprime.reporte(Clase.TOUOT, cr)
    End Sub

    Private Sub MdiPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FrmInicioSesion.Close()
    End Sub


    Private Sub btnRegistro_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRegistro.ItemClick
        MostrarForm(RegistroProducto)
    End Sub

    Private Sub btnCliente_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCliente.ItemClick
        Dim cr As New Cr_Clientes
        Dim Cliente As New C_Cliente
        cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre + "'"
        cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc + "'"
        Imprime.reporte(Cliente.ReporteCliente, cr)
    End Sub

    Private Sub btnValores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValores.ItemClick
        MostrarForm(FrmValoresUnitarios)
    End Sub
End Class