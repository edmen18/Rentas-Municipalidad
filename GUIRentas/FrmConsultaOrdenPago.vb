Imports Datos
Imports Reglas
Imports Reportes
Public Class FrmConsultaOrdenPago
    Dim FunDb As New cFuncionesDB
    'Dim validar As New C_Validar
    Dim clop As New Cl_OrdenPago
    Dim cimp As New C_imprime
    Dim clentidad As New Cl_Entidad
    Dim EstiloView As New Cl_EstiloListView
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        FrmBuscarCliente.lblflag.Text = "9"
        FrmBuscarCliente.ShowDialog()
    End Sub
    Sub LlenaLstViewOrdenes() ' 
        Me.lvwordenes.Items.Clear()
        Dim cSql As String = "select codorden,fechaemision from t_ordenpago where codcli='" + Me.lblcodigocliente.Text + "' and estadocd='D' order by fechaemision desc  "
        FunDb.FillListview(cSql, lvwordenes)
        'validar.colorearListView(lvwordenes)
    End Sub
    Sub LlenaLstViewdetallesOrdenes() ' 
        Me.lvwDetalle.Items.Clear()
        Dim cSql As String = "select Annio,Baseimponible,Tramo,AliCuota,Insolutos,ImpuestoAnual,Trimestres,Insoluto,Reajuste,Interes,total from t_detalleorden where codorden='" + Me.lvwordenes.SelectedItems(0).SubItems(0).Text + "'"
        FunDb.FillListview(cSql, lvwDetalle)
        'validar.colorearListView(lvwDetalle)
        EstiloView.AplicaColorTotales(lvwDetalle, 10, Color.LightSteelBlue)
    End Sub

    Private Sub lvwordenes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwordenes.SelectedIndexChanged
        If Me.lvwordenes.SelectedItems.Count > 0 Then
            LlenaLstViewdetallesOrdenes()
        End If
    End Sub

    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        If Me.lvwordenes.SelectedItems.Count > 0 Then
            Dim cr As New Cr_OrdenPago
            cr.DataDefinition.FormulaFields.Item("descli").Text = "'" + Me.lblDescripcion.Text + "'"
            cr.DataDefinition.FormulaFields.Item("dni").Text = "'" + Me.lbldni.Text + "'"
            cr.DataDefinition.FormulaFields.Item("ruccli").Text = "'" + Me.lblruc.Text + "'"
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

   
End Class