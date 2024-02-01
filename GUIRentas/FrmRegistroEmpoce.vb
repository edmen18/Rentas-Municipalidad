Imports Reglas
Imports Reportes
Imports Datos
Public Class FrmRegistroEmpoce
    Dim cempoce As New Cl_Empoce
    Dim cdetalleventa As New Cl_DetalleVenta
    Dim FunDb As New cFuncionesDB
    Dim validar As New Cl_Validar
    Private Sub FrmRegistroEmpoce_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblentidad.Text = cempoce.getEntidad(Me.lblcuenta.Text)
    End Sub

    Sub Actualiza_detalle_venta()
        Dim ilist As Integer
        For ilist = 0 To FrmEmpoce.dgvEmpoce.RowCount - 1
            cdetalleventa.editarDetalleVenta(FrmEmpoce.dgvEmpoce.Item(0, ilist).Value, FrmEmpoce.dgvEmpoce.Item(3, ilist).Value, Me.txtpapeleta.Text)
        Next
        FrmEmpoce.btnver.PerformClick()
    End Sub

    Private Sub btnGrabar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        If Me.txtpapeleta.Text = "" Or Len(txtpapeleta.Text) < 8 Then
            MessageBox.Show("El Numero de papeleta no es valido", "Empoce", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpapeleta.Focus()
            Exit Sub
        Else
            cempoce.CodCta = Me.lblcuenta.Text
            cempoce.Monto = Format(CDbl(Me.lblmonto.Text), "#,##0.00")
            cempoce.Fecha = CStr(FrmEmpoce.dtfechadel.Value.Date)
            cempoce.FechaAl = CStr(FrmEmpoce.dtfechaal.Value.Date)
            cempoce.NumPapeleta = Me.txtpapeleta.Text
            cempoce.Responsable = MdiPrincipal.tsbDniUsu.Caption
            If cempoce.AltaEmpoce() = True Then
                Actualiza_detalle_venta()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtpapeleta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpapeleta.KeyPress
        e.Handled = Validar.NumerosEnteros(System.Convert.ToInt16(Asc(e.KeyChar)))
    End Sub

   
End Class