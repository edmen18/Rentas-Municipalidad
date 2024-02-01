Imports Datos
Imports Reglas
Public Class FrmRegistros
    Dim clgrupo As New Cl_grupo
    Dim clclase As New Cl_clase
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim FunDb As New cFuncionesDB
    'Dim Validar As New C_Validar
    Private Sub FrmRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaLstViewGrupo()
        Me.gbxClase.Enabled = False
        HeadGridDivision()
        HeadGridTasas()
    End Sub

    Sub LlenaLstViewGrupo()
        Dim cSql As String = "SELECT numgru as Codigo,desgru as Nombre from t_grupo where annio='" + CStr(Now.Year) + "'"
        FunDb.FillDataGridView(cSql, dgvDivision)
        EstiloGrid.AplicaStiloBlue(dgvDivision)
    End Sub
    Sub LlenaLstViewclase()
        Dim cSql As String = "SELECT numcla,descla,porcentaje,codtipo,Valor from t_clase where numgru='" + dgvDivision.Item(0, dgvDivision.CurrentRow.Index).Value + "' and annio='" + CStr(Now.Year) + "'"
        FunDb.FillDataGridView(cSql, dgvClase)
        EstiloGrid.AplicaStiloBlue(dgvClase)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Frmgrupo.lblflag.Text = "0"
        Frmgrupo.ShowDialog()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Me.gbxClase.Enabled = False
            Frmgrupo.lblflag.Text = "1"
            Frmgrupo.lblnumerogrupo.Text = dgvDivision.Item(0, dgvDivision.CurrentRow.Index).Value
            Frmgrupo.txtnombregrupo.Text = dgvDivision.Item(1, dgvDivision.CurrentRow.Index).Value
            Frmgrupo.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.gbxClase.Enabled = False
    End Sub

    Private Sub btnNuevaClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaClase.Click
        Try
            FrmClases.lblflg.Text = "0"
            FrmClases.lblnumeroGrupo.Text = dgvDivision.Item(0, dgvDivision.CurrentRow.Index).Value
            FrmClases.lblDivision.Text = dgvDivision.Item(1, dgvDivision.CurrentRow.Index).Value
            FrmClases.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub btnGrabarClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarClase.Click
        Try
            If dgvClase.RowCount > 0 Then
                FrmClases.lblflg.Text = "1"
                FrmClases.lblNumClase.Text = dgvClase.Item(0, dgvClase.CurrentRow.Index).Value
                FrmClases.lblDivision.Text = dgvDivision.Item(1, dgvDivision.CurrentRow.Index).Value
                FrmClases.ShowDialog()
            Else
                MessageBox.Show("Seleccione un elemento para Editar", "Rentas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub divDivision_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDivision.CellDoubleClick
        Me.gbxClase.Enabled = True
        LlenaLstViewclase()
        HeadGridTasas()
    End Sub

    Sub HeadGridDivision()
        Try
            With dgvDivision
                .Columns(0).HeaderText = "Cod."
                .Columns(0).Width = 50
                .Columns(1).HeaderText = "Nombre de Division"
                .Columns(1).Width = .Width - .Columns(0).Width
            End With
        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub

    Sub HeadGridTasas()
        Try
            With dgvClase
                .Columns(0).HeaderText = "Cod. Tasa"
                .Columns(0).Width = 90
                .Columns(1).HeaderText = "Descripcion de la Tasa"
                .Columns(1).Width = .Width - (.Columns(0).Width + .Columns(2).Width + 150)
                .Columns(2).HeaderText = "Porcentaje"
                .Columns(2).Width = 80
                .Columns(3).Width = 200
                .Columns(3).Visible = False
                .Columns(4).Width = 100
                .Columns(4).Width = "Valor"
            End With
        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    MsgBox(DateDiff("d", Me.DateTimePicker1.Value, DateTimePicker2.Value))

    'End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class