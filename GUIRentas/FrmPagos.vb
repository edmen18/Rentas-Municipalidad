Imports Reglas
Imports Datos
Imports Reportes
Public Class FrmPagos
    Dim clrecibo As New Cl_ReciboAutovaluo
    Dim clpago As New Cl_Pagos
    Dim cldetallere As New Cl_DetalleRecibo
    'Dim validar As New C_Validar
    Dim FunDb As New cFuncionesDB
    Dim CLDJ As New Cl_DeclaracionJurada
    Dim IMP As New C_imprime
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim EstiloView As New Cl_EstiloListView
    Dim Entidad As New Cl_Entidad
    Dim c As Integer
    Dim flag As Integer = 0
    Private Sub FrmPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LLenarCombocta()
    End Sub
    Sub LLenarCombocta()
        Dim csql As String = "SELECT codcta,descripcion from t_cuenta  WHERE descripcion = 'PREDIAL' order by descripcion"
        FunDb.FillListaOrCombo(csql, CmbCuenta, "descripcion", "codcta")
    End Sub
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        FrmBuscarCliente.lblflag.Text = "7"
        FrmBuscarCliente.ShowDialog()
    End Sub
    '**************************+ funciones ********************
    Sub LlenadgvDj() ' llenamos la lista de declaraciones juradas de ese cliente
        Dim cSql As String = "select top (1) tdj.Coddj, annio,valorArancel from t_djautovaluo tdj inner join t_detalleDj tddj on tdj.coddj=tddj.coddj inner join t_Predio tp on tp.codpredio=tddj.codpredio where codcli='" + Me.lblcodigocliente.Text + "' order by annio desc  "
        FunDb.FillDataGridView(cSql, DgvDj)
        EncabezadosgridDj()
        EstiloGrid.AplicaStiloBlue(DgvDj)
    End Sub
    Sub LlenaLstViewtrim() ' llenamos la lista de trimestres y pagos de una dj
        Dim cSql As String = "select ttr.CodTrimestre,Numero,convert(char(10),FechVenc,103),Monto,tp.codpago,tp.estado from t_djautovaluo tdj inner join t_pagos tp on tp.coddj=tdj.coddj inner join t_trimestres ttr on ttr.codtrimestre=tp.codtrimestre  where tdj.coddj='" + Me.DgvDj.Item(0, DgvDj.CurrentRow.Index).Value.ToString + "' and tp.estado='D' order by numero asc  "
        FunDb.FillDataGridView(cSql, DgvTrimestres)
        EncabezadosgridTrimestre()
        EstiloGrid.AplicaStiloOrange(DgvTrimestres)
    End Sub

    Sub EncabezadosgridDj()
        DgvDj.Columns(0).HeaderText = "Declaracion Jurada Nª"
        DgvDj.Columns(0).Width = 100
        DgvDj.Columns(1).HeaderText = "Año"
        DgvDj.Columns(1).Width = 100
        DgvDj.Columns(2).HeaderText = ""
        DgvDj.Columns(2).Width = 0
    End Sub
    Sub EncabezadosgridTrimestre()
        DgvTrimestres.Columns(0).HeaderText = ""
        DgvTrimestres.Columns(0).Visible = False
        DgvTrimestres.Columns(1).HeaderText = "Trimestre"
        DgvTrimestres.Columns(1).Width = 70
        DgvTrimestres.Columns(2).HeaderText = "Fecha"
        DgvTrimestres.Columns(2).Width = 100
        DgvTrimestres.Columns(3).HeaderText = "Monto"
        DgvTrimestres.Columns(3).Width = 100
        DgvTrimestres.Columns(4).HeaderText = "Cod.Pago"
        DgvTrimestres.Columns(4).Visible = False
        DgvTrimestres.Columns(5).HeaderText = "Estado"
        DgvTrimestres.Columns(5).Width = 70
    End Sub
    '************************* fin funciones *************

    Private Sub DgvDj_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvDj.DoubleClick
        LlenaLstViewtrim()
    End Sub
    Private Sub DgvTrimestres_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvTrimestres.DoubleClick
        Me.dtfecha.Text = Me.DgvTrimestres.Item(2, DgvTrimestres.CurrentRow.Index).Value.ToString
        If Me.dtfecha.Value.Date.AddDays(10) < Now.Date Then
            MsgBox("La operación no es posible debido a que ya venció el plazo para cancelar este trimestre y debe generarse una orden de pago", MsgBoxStyle.Critical)
            Me.dtfecha.ResetText()
            Me.lbltrimestre.ResetText()
            Me.lblmonto.ResetText()
            Me.lblcodpago.ResetText()
        Else
            Me.lbltrimestre.Text = Me.DgvTrimestres.Item(1, DgvTrimestres.CurrentRow.Index).Value.ToString
            Me.lblmonto.Text = Me.DgvTrimestres.Item(3, DgvTrimestres.CurrentRow.Index).Value.ToString
            Me.lblcodpago.Text = Me.DgvTrimestres.Item(4, DgvTrimestres.CurrentRow.Index).Value.ToString
            Me.dtfecha.Text = Me.DgvTrimestres.Item(2, DgvTrimestres.CurrentRow.Index).Value.ToString
        End If

    End Sub

    Private Sub BtnVerPredios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerPredios.Click
        If Me.DgvDj.SelectedRows.Count > 0 Then
            FrmPredios.ShowDialog()
        Else
            MsgBox("Seleccione una Declaracion Jurada de la Lista", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        If Me.lblcodpago.Text = "" Or Me.lbltrimestre.Text = "" Or Me.lblmonto.Text = "" Then
            MsgBox("Complete los Datos antes de continuar", MsgBoxStyle.Critical)
        Else
            For i = 0 To Me.LvwPagos.Items.Count - 1
                If Me.LvwPagos.Items(i).SubItems(0).Text = Me.lblcodpago.Text Then
                    flag = flag + 1
                End If
            Next

            If flag = 0 Then
                Me.lbltotal.Text = "0.00"
                c = Me.LvwPagos.Items.Count
                Me.LvwPagos.Items.Add(Me.lblcodpago.Text)
                Me.LvwPagos.Items(c).SubItems.Add(Me.lbltrimestre.Text)
                Me.LvwPagos.Items(c).SubItems.Add(Me.lblmonto.Text)
                total()
                Me.btngrabar.Enabled = True
            Else
                MessageBox.Show("Este item ya se encuentra agregado", "Registro de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = 0
            End If
        End If
        EstiloView.AplicaColorTotales(LvwPagos, 2, Color.LightGreen)
    End Sub
    Sub total()
        Me.lbltotal.Text = "0,00"
        For i = 0 To Me.LvwPagos.Items.Count - 1
            Me.lbltotal.Text = CStr(Val(Me.lbltotal.Text) + Val(Me.LvwPagos.Items(i).SubItems(2).Text))
        Next
    End Sub
    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        Me.clrecibo.CodRecibo = Format(CInt(clrecibo.GeneraRecibo()) + 1, "0000000000")
        Me.clrecibo.Fecha = CStr(Now.Date)
        Me.clrecibo.Total = CDbl(Me.lbltotal.Text)
        Me.clrecibo.CodCta = Me.CmbCuenta.SelectedValue.ToString
        Me.clrecibo.Observacion = "Ninguna"
        Me.clrecibo.Usuario = MdiPrincipal.tsbDniUsu.Caption
        If Me.clrecibo.AltaRecibo() = True Then
            For I = 0 To Me.LvwPagos.Items.Count - 1
                Me.cldetallere.CodPago = Me.LvwPagos.Items(I).SubItems(0).Text
                Me.cldetallere.CodRecibo = clrecibo.CodRecibo
                cldetallere.Altadetalle()
                clpago.updatedetalle(Me.LvwPagos.Items(I).SubItems(0).Text)
            Next
            Me.DgvTrimestres.Refresh()
            Me.Btnimprimir.Enabled = True
            Me.btngrabar.Enabled = False
        End If
    End Sub

    Private Sub Btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnimprimir.Click
        Dim cr As New Cr_ReciboAutovaluo
        cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre + "'"
        cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc + "'"

        IMP.reporte(Me.clrecibo.ImprimeRecibo(Me.clrecibo.CodRecibo), cr)
    End Sub

    
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

   
    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If Me.LvwPagos.SelectedItems.Count > 0 Then
            Me.LvwPagos.Items.RemoveAt(Me.LvwPagos.SelectedItems(0).Index)
            total()
        Else
            MessageBox.Show("Seleccione un elemento de la lista", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If LvwPagos.Items.Count = 0 Then
            Me.btngrabar.Enabled = False
        End If
    End Sub

    
    Private Sub DgvDj_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvDj.SelectionChanged
        'LlenaLstViewtrim()
    End Sub
End Class