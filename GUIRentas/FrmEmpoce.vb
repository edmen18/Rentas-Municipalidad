Imports Reglas
Imports Datos
Public Class FrmEmpoce
    Dim FunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim i As Integer = 0
    Sub Llenarlista()
        Dim cSql As String = "select tv.CodVenta as Codigo,tc.descla as Tasa,tdv.subtotal as Monto,tdv.numcla from t_venta tv inner join t_detalleventa tdv on tdv.codventa=tv.codventa inner join t_clase tc on tc.numcla=tdv.numcla where tv.fecha>='" + CStr(Me.dtfechadel.Value.Date) + "' and tv.fecha<='" + CStr(Me.dtfechaal.Value.Date) + "'  and codcta='" + Me.CmbCuenta.SelectedValue.ToString + "' and tdv.estado='0' and tv.codforma='01' order by tv.codventa"
        FunDb.FillDataGridView(cSql, dgvEmpoce)
        EstiloGrid.AplicaStiloBlue(dgvEmpoce)
    End Sub
    Sub LLenarCombocta()
        Dim csql As String = "SELECT codcta,descripcion from t_cuenta "
        FunDb.FillListaOrCombo(csql, CmbCuenta, "descripcion", "codcta")
    End Sub

    Sub HeadGrid()
        Try
            With dgvEmpoce
                .Columns(0).HeaderText = "Codigo"
                .Columns(0).Width = 80
                .Columns(1).HeaderText = "Descripcion de la tasa"
                .Columns(1).Width = 280
                .Columns(2).HeaderText = "Monto"
                .Columns(2).Width = 80
                '.Columns(3).HeaderText = "Clase"
                '.Columns(3).Width = 80
                .Columns(3).Visible = False
            End With
        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub

    Private Sub FrmEmpoce_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.lbltotal.ResetText()
    End Sub

    Private Sub FrmEmpoce_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LLenarCombocta()
        Me.lbltotal.Text = "0.00"
    End Sub

    Sub sumar()
        Try
            Me.lbltotal.Text = "0.00"
            For Me.i = 0 To Me.dgvEmpoce.RowCount
                Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.dgvEmpoce.Item(2, i).Value), "#,#.#0")
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click
        Llenarlista()
        sumar()
        HeadGrid()
    End Sub

    Private Sub btnRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistro.Click
        If Me.lbltotal.Text = "0.00" Or Me.lbltotal.Text = "" Then
            MsgBox("No hay datos que mostrar", MsgBoxStyle.Critical)
        Else
            FrmRegistroEmpoce.lblcuenta.Text = Me.CmbCuenta.SelectedValue.ToString
            FrmRegistroEmpoce.lblmonto.Text = Me.lbltotal.Text
            FrmRegistroEmpoce.ShowDialog()
        End If

    End Sub

    Private Sub BtnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.lbltotal.ResetText()
        Me.Close()
    End Sub
End Class