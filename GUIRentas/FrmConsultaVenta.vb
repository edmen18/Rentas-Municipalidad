Imports Reglas
Imports Datos
Imports Reportes
Imports CrystalDecisions.CrystalReports.Engine.FormulaFieldDefinition
Public Class FrmConsultaVenta
    Dim FunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim imp As New C_imprime

    Dim CVENTA As New Cl_Venta
    Dim Entidad As New Cl_Entidad
    Private Sub rbcliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcliente.CheckedChanged
        Me.gbcliente.Visible = True
        Me.Gbservicio.Visible = False
        Me.gbfecha.Visible = False
        LIMPIARCLIENTE()
        LIMPIARSERVICIO()
    End Sub

    Private Sub rbservicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbservicio.CheckedChanged
        Me.gbcliente.Visible = False
        Me.gbfecha.Visible = False
        Me.Gbservicio.Visible = True
        LIMPIARCLIENTE()
        LIMPIARSERVICIO()
    End Sub

    Private Sub rbfecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbfecha.CheckedChanged
        Me.gbcliente.Visible = False
        Me.gbfecha.Visible = True
        Me.Gbservicio.Visible = False
        LIMPIARCLIENTE()
        LIMPIARSERVICIO()
       
    End Sub

    Private Sub FrmConsultaVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gbcliente.Visible = False
        Me.gbfecha.Visible = False
        HeadGrid()
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        FrmBuscarCliente.lblflag.Text = "2"
        FrmBuscarCliente.ShowDialog()
    End Sub

    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub Llenarcliente()
        Dim cSql As String = "select tv.codventa,tcli.descli,convert(char(10),fecha,103)as fecha,tv.monto,tfp.descripcion from t_venta tv inner join t_cliente tcli on tcli.codcli=tv.codcli inner join t_formapago tfp on tfp.codforma=tv.codforma where tcli.codcli= '" + Me.lblcodcliente.Text + "' order by tv.fecha"
        FunDb.FillDataGridView(cSql, dgvVentas)
        EstiloGrid.AplicaStiloOrange(dgvVentas)
    End Sub
    Sub Llenarfechas()
        Dim cSql As String = "select tv.codventa,tcli.descli,convert(char(10),fecha,103)as fecha,tv.monto,tfp.descripcion from t_venta tv inner join t_cliente tcli on tcli.codcli=tv.codcli inner join t_formapago tfp on tfp.codforma=tv.codforma where fecha>='" + CStr(Me.dtdel.Value.Date) + " ' and fecha<='" + CStr(Me.dtal.Value.Date) + "'order by fecha"
        FunDb.FillDataGridView(cSql, dgvVentas)
        EstiloGrid.AplicaStiloOrange(dgvVentas)
    End Sub
    Sub LlenarSERVICIO()
        Dim cSql As String = "select tv.codventa,tcli.descli,convert(char(10),fecha,103)as fecha,tv.monto,tfp.descripcion from t_venta tv inner join t_cliente tcli on tcli.codcli=tv.codcli inner join t_detalleventa dv on dv.codventa=tv.codventa inner join t_clase tc on tc.numcla=dv.numcla inner join t_formapago tfp on tfp.codforma=tv.codforma where tc.numcla='" + Me.lblcodigoservicio.Text + "'"
        FunDb.FillDataGridView(cSql, dgvVentas)
        EstiloGrid.AplicaStiloOrange(dgvVentas)
    End Sub

    Public Sub HeadGrid()
        Try
            With dgvVentas
                .Columns(0).HeaderText = "Recibo"
                .Columns(0).Width = 90
                .Columns(1).HeaderText = "Nombre de Contribuyente"
                .Columns(1).Width = 300
                .Columns(2).HeaderText = "Fecha"
                .Columns(2).Width = 100
                .Columns(3).HeaderText = "Monto"
                .Columns(3).Width = 80
                .Columns(4).HeaderText = "F. Pago"
                .Columns(4).Width = 80
            End With
        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub
    Private Sub btnbuscarserv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarserv.Click
        FrmConsultaServicios.lblflag.Text = "2"
        FrmConsultaServicios.ShowDialog()
    End Sub
    Sub LIMPIARCLIENTE()
        Me.lblcodcliente.ResetText()
        Me.lbldni.ResetText()
        Me.lblnombre.ResetText()
    End Sub
    Sub LIMPIARSERVICIO()
        Me.lblcodigoservicio.ResetText()
        Me.lbldescripcion.ResetText()
    End Sub

    Private Sub btnVerdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerdetalle.Click
        Try
            If dgvVentas.RowCount <= 0 Then
                MessageBox.Show("Seleccione un Item para ver su detalle", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim cr As New Cr_Recibo
                cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre.ToString() + "'"
                cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc.ToString() + "'"
                imp.reporte(CVENTA.ImprimeRecibo(dgvVentas.Item(0, dgvVentas.CurrentRow.Index).Value), cr)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub lblcodcliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblcodcliente.TextChanged
        Llenarcliente()
    End Sub


    Private Sub lblcodigoservicio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblcodigoservicio.TextChanged
        LlenarSERVICIO()
    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.rbfecha.Checked = True Then
            Dim cr As New Cr_Ventas
            cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre.ToString() + "'"
            cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc.ToString() + "'"

            cr.DataDefinition.FormulaFields.Item("fechaini").Text = "'" + Me.dtdel.Text + "'"
            cr.DataDefinition.FormulaFields.Item("fechafin").Text = "'" + Me.dtal.Text + "'"
            imp.reporte(CVENTA.ReporteVentaPORFECHAS(Me.dtdel.Value.Date, Me.dtal.Value.Date), cr)
        End If
        If Me.rbcliente.Checked = True Then
            Dim cr As New Cr_VentasxCliente
            cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre.ToString() + "'"
            cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc.ToString() + "'"
            imp.reporte(CVENTA.ReporteVentaPORCliente(Me.lblcodcliente.Text), cr)
        End If
        If Me.rbservicio.Checked = True Then
            Dim cr As New Cr_VentasxServicio
            cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre.ToString() + "'"
            cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc.ToString() + "'"
            cr.DataDefinition.FormulaFields.Item("UnboundString1").Text = "'" + Me.lbldescripcion.Text + "'"
            imp.reporte(CVENTA.ReporteVentaPORservicio(Me.lblcodigoservicio.Text), cr)
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
        LIMPIARCLIENTE()
        LIMPIARSERVICIO()
    End Sub

    Private Sub dtdel_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtdel.ValueChanged
        If Me.rbfecha.Checked = True Then
            Llenarfechas()
        End If
    End Sub

    Private Sub dtal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtal.ValueChanged
        If Me.rbfecha.Checked = True Then
            Llenarfechas()
        End If
    End Sub

    Private Sub rbfecha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbfecha.Click
        Llenarfechas()
    End Sub
End Class