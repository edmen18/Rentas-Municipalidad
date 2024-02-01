Imports Datos
Imports Reglas
Imports Reportes
Public Class FrmCancelarOP
    Dim FunDb As New cFuncionesDB
    'Dim validar As New C_Validar
    Dim clop As New Cl_OrdenPago
    Dim cimp As New C_imprime
    Dim clentidad As New Cl_Entidad
    Dim cpagos As New Cl_Pagos
    Dim CRECIBOA As New Cl_ReciboAutovaluo
    Dim cdetallerecibo As New Cl_DetalleRecibo
    Private Sub FrmCancelarOP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblrecibo.Text = Format(CInt(CRECIBOA.GeneraRecibo()) + 1, "0000000000")
        LLenarCombocta()
    End Sub
    '************ funciones ************
    Sub LLenarCombocta()
        Dim csql As String = "SELECT codcta,descripcion from t_cuenta  WHERE descripcion = 'PREDIAL' order by descripcion"
        FunDb.FillListaOrCombo(csql, CmbCuenta, "descripcion", "codcta")
    End Sub
    Sub LlenaLstViewPagos() ' llenamos la lista de trimestres y pagos de una dj
        Dim cSql As String = "select DISTINCT TPA.codpago,numero,convert(char(10),fechvenc,103) as fecha from T_ORDENPAGO TOPA INNER JOIN T_ORDEN_PAGO TOPA1 ON TOPA1.CODORDEN=TOPA.CODORDEN INNER JOIN T_PAGOS TPA ON TPA.CODPAGO=TOPA1.CODPAGO INNER JOIN T_TRIMESTRES TTR ON TTR.CODTRIMESTRE=TPA.CODTRIMESTRE  where TOPA.codorden='" + Me.lvwordenes.SelectedItems(0).SubItems(0).Text + "' and tpa.estado='D' and ttr.fechvenc<getdate() order by numero asc  "
        FunDb.FillListview(cSql, LvwPagos)
    End Sub
    '**************fin*************+
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        FrmBuscarCliente.lblflag.Text = "10"
        FrmBuscarCliente.ShowDialog()
    End Sub

    Sub LlenaLstViewOrdenes() ' 
        Me.lvwordenes.Items.Clear()
        Dim cSql As String = "select codorden,fechaemision from t_ordenpago where codcli='" + Me.lblcodigocliente.Text + "' and estadocd='D' order by fechaemision desc  "
        FunDb.FillListview(cSql, lvwordenes)
        'validar.colorearListView(lvwordenes)
    End Sub

    Sub LlenaLstViewdetallesOrdenes()
        Me.lvwDetalle.Items.Clear()
        Dim cSql As String = "select Annio,Baseimponible,Tramo,AliCuota,Insolutos,ImpuestoAnual,Trimestres,Insoluto,Reajuste,Interes,total from t_detalleorden where codorden='" + Me.lvwordenes.SelectedItems(0).SubItems(0).Text + "'"
        FunDb.FillListview(cSql, lvwDetalle)
        'validar.colorearListView(lvwDetalle)
    End Sub

    Private Sub lvwordenes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwordenes.SelectedIndexChanged
        If Me.lvwordenes.SelectedItems.Count > 0 Then
            LlenaLstViewdetallesOrdenes()
            LlenaLstViewPagos()
        End If
        Me.lbltotal.Text = "0.00"
        For i = 0 To Me.lvwDetalle.Items.Count - 1
            Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwDetalle.Items(i).SubItems(10).Text), "#,##0.00")
        Next
        Me.BtnGrabar.Enabled = True
    End Sub

    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        If Me.lvwordenes.SelectedItems.Count > 0 Then
            Dim cr As New Cr_OrdenPago
            cr.DataDefinition.FormulaFields.Item("descli").Text = "'" + Me.lblDescripcion.Text + "'"
            'cr.DataDefinition.FormulaFields.Item("dniruc").Text = CStr("'" + Me.lbldni.Text + "'" & "-" & "'" + Me.lblruc.Text + "'")
            cr.DataDefinition.FormulaFields.Item("descripcion").Text = "'" + clentidad.Nombre + "'"
            cr.DataDefinition.FormulaFields.Item("ruc").Text = "'" + clentidad.Ruc + "'"
            cr.DataDefinition.FormulaFields.Item("direccion").Text = "'" + clentidad.Direccion + "'"
            cr.DataDefinition.FormulaFields.Item("telefono").Text = "'" + clentidad.Telefono + "'"
            Try
                Dim dt As New DataTable
                Dim cFun As New cFuncionesDB
                Dim csql As String = "SELECT dircli+' Nº'+numero+' Mz.'+manzana+' Lt.'+lote from t_cliente where codcli='" + Me.lblcodigocliente.Text + "'"
                dt = cFun.ConsultaX(csql)
                cr.DataDefinition.FormulaFields.Item("domiciliofiscal").Text = "'" + CStr(dt.Rows(0).Item(0)) + "'"
            Catch ex As Exception
                MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Dim annios As String = ""
            For i = 0 To Me.lvwDetalle.Items.Count - 1
                annios = annios & "-" & Me.lvwDetalle.Items(i).SubItems(0).Text
            Next
            cr.DataDefinition.FormulaFields.Item("Annios").Text = "'" + annios + "'"
            cimp.reporte(clop.Imprimeorden(Me.lvwordenes.SelectedItems(0).SubItems(0).Text, Me.lblcodigocliente.Text), cr)
        Else
            MessageBox.Show("Debe seleccionar una Orden de Pago", "Orden de Pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        clop.CancelarOrden(Me.lblcodigocliente.Text, Me.lvwordenes.SelectedItems(0).SubItems(0).Text)
        CRECIBOA.CodRecibo = Me.lblrecibo.Text
        CRECIBOA.Fecha = CStr(Now.Date)
        CRECIBOA.Total = CDbl(Me.lbltotal.Text)
        CRECIBOA.CodCta = Me.CmbCuenta.SelectedValue.ToString
        CRECIBOA.Observacion = "Orden de Pago Nº" & " " & Me.lvwordenes.SelectedItems(0).SubItems(0).Text
        CRECIBOA.Usuario = MdiPrincipal.tsbDniUsu.Caption
        If CRECIBOA.AltaRecibo() = True Then
            For i = 0 To Me.LvwPagos.Items.Count - 1
                cdetallerecibo.CodRecibo = Me.lblrecibo.Text
                cdetallerecibo.CodPago = CStr(Me.LvwPagos.Items(i).SubItems(0).Text)
                cdetallerecibo.Altadetalle()
                cpagos.updatedetalle(CStr(Me.LvwPagos.Items(i).SubItems(0).Text))
            Next

            Dim CR As New Cr_ReciboAutovaluo
            cimp.reporte(CRECIBOA.ImprimeRecibo(Me.lblrecibo.Text), CR)
            Me.lblrecibo.Text = Format(CInt(CRECIBOA.GeneraRecibo()) + 1, "0000000000")
            Me.BtnGrabar.Enabled = False

        End If
       
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        limpiar()
        Me.BtnCancelar.Enabled = False
    End Sub

    Sub limpiar()
        Me.lvwordenes.Items.Clear()
        Me.lvwDetalle.Items.Clear()
        Me.LvwPagos.Items.Clear()
        Me.lblDescripcion.ResetText()
        Me.lblcodigocliente.ResetText()
        Me.lbldni.ResetText()
        Me.lblruc.ResetText()
        Me.lbltotal.ResetText()
        Me.BtnImprimir.Enabled = False
        Me.BtnGrabar.Enabled = True
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class