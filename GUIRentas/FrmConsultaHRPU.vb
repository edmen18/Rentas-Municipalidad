Imports Reglas
Imports Datos
Imports Reportes
Public Class FrmConsultaHRPU
    Dim validar As New Cl_EstiloListView
    Dim FunDb As New cFuncionesDB
    Dim CLDJ As New Cl_DeclaracionJurada
    Dim corden As New Cl_OrdenPago
    Dim IMP As New C_imprime
    Dim Entidad As New Cl_Entidad
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        FrmBuscarCliente.lblflag.Text = "6"
        FrmBuscarCliente.ShowDialog()
    End Sub
    '**************************+ funciones ********************
    Sub LlenaLstViewDj() ' llenamos la lista de declaraciones juradas de ese cliente
        Me.LvwDj.Items.Clear()
        Dim cSql As String = "select top (1) tdj.Coddj, annio,valorArancel from t_djautovaluo tdj inner join t_detalleDj tddj on tdj.coddj=tddj.coddj inner join t_Predio tp on tp.codpredio=tddj.codpredio where codcli='" + Me.lblcodigocliente.Text + "' order by annio desc  "
        FunDb.FillListview(cSql, LvwDj)
        validar.colorearListView(LvwDj)
    End Sub
    Sub LlenaLstViewtrim() ' llenamos la lista de trimestres y pagos de una dj
        Me.LvwTrimestres.Items.Clear()
        Dim cSql As String = "select ttr.CodTrimestre,Numero,convert(char(10),FechVenc,103),Monto,tp.estado from t_djautovaluo tdj inner join t_pagos tp on tp.coddj=tdj.coddj inner join t_trimestres ttr on ttr.codtrimestre=tp.codtrimestre  where tdj.coddj='" + Me.LvwDj.SelectedItems(0).SubItems(0).Text + "' order by numero asc  "
        FunDb.FillListview(cSql, LvwTrimestres)
        validar.colorearListView(LvwTrimestres)
    End Sub
    '************************* fin funciones *************
    Private Sub LvwDj_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LvwDj.DoubleClick
        LlenaLstViewtrim()
    End Sub

    Private Sub btnhHR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhHR.Click
        If Me.LvwDj.SelectedItems.Count > 0 And Me.LvwTrimestres.Items.Count > 0 Then
            Dim cr As New Cr_HR
            cr.DataDefinition.FormulaFields.Item("Arancel").Text = "'" + CStr(CDbl(Me.LvwDj.SelectedItems(0).SubItems(2).Text)) + "'"
            For i = 0 To Me.LvwTrimestres.Items.Count - 1
                If i = 0 Then
                    cr.DataDefinition.FormulaFields.Item("Trim1").Text = "'" + Me.LvwTrimestres.Items(i).SubItems(2).Text + "'"
                End If
                If i = 1 Then
                    cr.DataDefinition.FormulaFields.Item("Trim2").Text = "'" + Me.LvwTrimestres.Items(i).SubItems(2).Text + "'"
                End If
                If i = 2 Then
                    cr.DataDefinition.FormulaFields.Item("Trim3").Text = "'" + Me.LvwTrimestres.Items(i).SubItems(2).Text + "'"
                End If
                If i = 3 Then
                    cr.DataDefinition.FormulaFields.Item("Trim4").Text = "'" + Me.LvwTrimestres.Items(i).SubItems(2).Text + "'"
                    cr.DataDefinition.FormulaFields.Item("ImpTrimestral").Text = "'" + Me.LvwTrimestres.Items(i).SubItems(3).Text + "'"
                End If
            Next
            cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre + "'"
            cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc + "'"

            IMP.reporte(CLDJ.ImprimeHR(Me.lblcodigocliente.Text, Me.LvwDj.SelectedItems(0).SubItems(0).Text), cr)
        Else
            MessageBox.Show("Error no ha seleccionado ninguna declaracion jurada o antes de visualizar el informe debe cargar primero los Trimestres de pagos dando doble click en la lista de declaraciones juradas", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FrmConsultaHRPU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            End Sub

    Private Sub BtnPU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPU.Click
        If Me.LvwDj.SelectedItems.Count > 0 Then
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "SELECT TP.CODPREDIO,Nombre, CONDICION,Descripcion,SITUACION,Direccion+''+Numero+''+Manzana+''+Lote AS DIRECICION,MANZANA, LOTE,CONVERT(VARCHAR(10),FECHAADQUISICION,103)AS FECHAADQ,NUMERO FROM T_PREDIO TP INNER JOIN T_CONDICIONPROPIEDAD TCP ON TCP.CODCONDPRO=TP.CODCONDPRO INNER JOIN T_TIPOEDIFICACION TTE  ON TP.CODTIPOEDIFICACION=TTE.CODTIPOEDIFICACION INNER JOIN T_ZONA AS TZ ON TZ.CODZONA=TP.CODZONA WHERE ESTADOPREDIO='1' AND CODCLI='" + Me.lblcodigocliente.Text + "'"
            dt = cFun.ConsultaX(csql)
            Dim cr As New Cr_PU
            cr.DataDefinition.FormulaFields.Item("CODPREDIO").Text = "'" + CStr(dt.Rows(0).Item(0)) + "'"
            cr.DataDefinition.FormulaFields.Item("ZONA").Text = "'" + CStr(dt.Rows(0).Item(1)) + "'"
            cr.DataDefinition.FormulaFields.Item("TIPO_EDIFICACION").Text = "'" + CStr(dt.Rows(0).Item(3)) + "'"
            cr.DataDefinition.FormulaFields.Item("CONDICION").Text = "'" + CStr(dt.Rows(0).Item(2)) + "'"
            cr.DataDefinition.FormulaFields.Item("SITUACION").Text = "'" + CStr(dt.Rows(0).Item(4)) + "'"
            cr.DataDefinition.FormulaFields.Item("DIRECCION").Text = "'" + CStr(dt.Rows(0).Item(5)) + "'"
            cr.DataDefinition.FormulaFields.Item("MANZANA").Text = "'" + CStr(dt.Rows(0).Item(6)) + "'"
            cr.DataDefinition.FormulaFields.Item("NUMERO").Text = "'" + CStr(dt.Rows(0).Item(7)) + "'"
            cr.DataDefinition.FormulaFields.Item("FECHAADQ").Text = "'" + CStr(dt.Rows(0).Item(8)) + "'"
            cr.DataDefinition.FormulaFields.Item("NUMEROCASA").Text = "'" + CStr(dt.Rows(0).Item(9)) + "'"
            cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre + "'"
            cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc + "'"
            IMP.reporte(CLDJ.ImprimePU(Me.lblcodigocliente.Text, Me.LvwDj.SelectedItems(0).SubItems(0).Text), cr)

        Else
            MessageBox.Show("Seleccione una Declaración Jurada", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        
    End Sub

    Private Sub btnCoactivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCoactivos.Click
        Me.Close()
    End Sub
End Class