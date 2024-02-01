Imports Reglas
Imports Datos
Public Class FrmMontoMinimo
    Dim cmm As New Cl_MontoMinimo
    Dim FunDb As New cFuncionesDB
    Dim Validar As New Cl_Validar
    Private Sub FrmMontoMinimo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Llenadatagrid()
        Me.txtmonto.ResetText()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        cmm.Valor = CDbl(Me.txtmonto.Text)
        cmm.AltaCondicion()
        Llenadatagrid()
        Me.txtmonto.ResetText()
        Me.btnGrabar.Enabled = False
    End Sub
    Sub Encabezadosgrid()
        dgvMontos.Columns(0).HeaderText = "Monto Minimo"
        dgvMontos.Columns(0).Width = 100
    End Sub
    Sub Llenadatagrid()
        Dim cSql As String = "select valor from t_montominimo"
        FunDb.FillDataGridView(cSql, dgvMontos)
        Encabezadosgrid()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.txtmonto.ResetText()
        Me.Close()
    End Sub

    Private Sub txtmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmonto.KeyPress
        e.Handled = Validar.NumerosDecimales(System.Convert.ToInt16(Asc(e.KeyChar)))
    End Sub

    Private Sub dgvMontos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMontos.CellDoubleClick
        Me.txtmonto.Text = dgvMontos.Item(0, dgvMontos.CurrentRow.Index).Value
        Me.btnGrabar.Enabled = True
    End Sub

End Class