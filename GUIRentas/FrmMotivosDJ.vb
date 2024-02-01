Imports Datos
Imports Reglas
Imports Reportes
Public Class FrmMotivosDJ
    Dim FunDb As New cFuncionesDB
    Dim cmotivos As New Cl_motivosdj
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim flag As Integer = 0
    Private Sub FrmMotivosDJ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Llenadatagrid()
    End Sub
    Sub Encabezadosgrid()
        dgvmotivos.Columns(0).HeaderText = "Cod. Motivo"
        dgvmotivos.Columns(0).Width = 100
        dgvmotivos.Columns(1).HeaderText = "Motivo"
        dgvmotivos.Columns(1).Width = 300
    End Sub
    Sub Llenadatagrid()
        Dim cSql As String = "select codmotivo as Código, descripcion as Motivo from t_motivodj where estado='1'"
        FunDb.FillDataGridView(cSql, dgvmotivos)
        Encabezadosgrid()
        EstiloGrid.AplicaStiloBlue(dgvmotivos)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.lblcodigo.Text = Format(CInt(cmotivos.GeneraCodMotivo()) + 1, "00")
        Me.txtdescripcion.ResetText()
        flag = 0
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.lblcodigo.Text = "" Or Me.txtdescripcion.Text = "" Then
            MessageBox.Show("Complete los Datos antes de Continuar", "Registro de Motivos DJ.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Me.flag = 0 Then
                cmotivos.CodMotivo = Me.lblcodigo.Text
                cmotivos.Descripcion = Me.txtdescripcion.Text
                cmotivos.Estado = "1"
                If Me.cmotivos.AltaMotivo = True Then
                    MessageBox.Show("Información Guardada", "Registro de Motivos DJ.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf flag = 1 Then
                cmotivos.UpdateMotivo(Me.lblcodigo.Text, Me.txtdescripcion.Text)
            End If
        End If

        Llenadatagrid()
        btnCancelar.PerformClick()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        flag = 0
    End Sub

    Private Sub dgvmotivos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvmotivos.DoubleClick
        Me.lblcodigo.Text = Convert.ToString(Me.dgvmotivos.CurrentRow.Cells(0).Value)
        Me.txtdescripcion.Text = Convert.ToString(Me.dgvmotivos.CurrentRow.Cells(1).Value)
        flag = 1
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnEliminar.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.flag = 1 Then
            Me.cmotivos.EliminarMotivo(Me.lblcodigo.Text)
        Else
            MessageBox.Show("Seleccione un elemento de la lista", "Registro de Motivos DJ.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Llenadatagrid()
        btnCancelar.PerformClick()
        flag = 0
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.lblcodigo.ResetText()
        Me.txtdescripcion.ResetText()
        flag = 0
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnEliminar.Enabled = False
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class