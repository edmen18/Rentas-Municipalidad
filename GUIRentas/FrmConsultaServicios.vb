Imports Datos
Imports Reglas
Public Class FrmConsultaServicios
    Dim FunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim UIT As New Cl_uit

    Private Sub FrmConsultaServicios_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.txtclase.ResetText()
    End Sub
    Private Sub FrmConsultaServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LLenarCombogrupo()
        EstiloGrid.AplicaStiloOrange(dgvServicios)
    End Sub
    Sub LLenarCombogrupo()
        Dim csql As String = "SELECT numgru,desgru from t_grupo "
        FunDb.FillListaOrCombo(csql, cbogrupo, "desgru", "numgru")
    End Sub
    Sub LlenaLstViewclase()
        Dim cSql As String = "SELECT numcla,descla,porcentaje,codtipo,TC.CODCTA from t_clase TCL INNER JOIN T_CUENTA TC ON TC.CODCTA=TCL.CODCTA where numgru='" + Me.cbogrupo.SelectedValue.ToString + "' and descla like '%" + Me.txtclase.Text + "%'"
        FunDb.FillDataGridView(cSql, dgvServicios)
    End Sub
    Private Sub lvwgrupos_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        LlenaLstViewclase()
    End Sub

    Sub HeadGrid()
        With dgvServicios
            .Columns(0).HeaderText = "Codigo"
            .Columns(0).Width = 60
            .Columns(1).HeaderText = "Descripcion de la Tasa"
            .Columns(1).Width = 300
            .Columns(2).HeaderText = "Porcentaje"
            .Columns(2).Width = 80
            .Columns(3).Visible = False
            .Columns(4).HeaderText = "Cta.Corriente"
            .Columns(4).Width = 120
        End With
    End Sub

    Private Sub txtclase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtclase.TextChanged
        LlenaLstViewclase()
        HeadGrid()
    End Sub

    Private Sub dgvServicios_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServicios.CellDoubleClick
        If Me.lblflag.Text = "2" Then
            FrmConsultaVenta.lblcodigoservicio.Text = dgvServicios.Item(0, dgvServicios.CurrentRow.Index).Value.ToString()
            FrmConsultaVenta.lbldescripcion.Text = dgvServicios.Item(1, dgvServicios.CurrentRow.Index).Value.ToString()
            FrmConsultaVenta.HeadGrid()
            FrmConsultaVenta.LlenarSERVICIO()
        End If
        Me.Close()
    End Sub

    Private Sub dgvServicios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServicios.CellContentClick

    End Sub
End Class