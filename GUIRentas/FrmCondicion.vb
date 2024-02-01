Imports Datos
Imports Reglas
Imports Reportes
Public Class FrmCondicion
    Dim FunDb As New cFuncionesDB
    Dim ccondicion As New Cl_CondicionPropiedad
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim flag As Integer = 0
    Private Sub FrmCondicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Llenadatagrid()
    End Sub
    Sub Encabezadosgrid()
        dgvcondiciones.Columns(0).HeaderText = "Cod. Condicion"
        dgvcondiciones.Columns(0).Width = 100
        dgvcondiciones.Columns(1).HeaderText = "Condición"
        dgvcondiciones.Columns(1).Width = 300
    End Sub
    Sub Llenadatagrid()
        Dim cSql As String = "select codcondpro as Código,condicion from t_condicionpropiedad where estado='1'"
        FunDb.FillDataGridView(cSql, dgvcondiciones)
        Encabezadosgrid()
        EstiloGrid.AplicaStiloBlue(dgvcondiciones)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.lblcodigo.Text = Format(CInt(ccondicion.GeneraCodCondicion()) + 1, "00")
        Me.txtdescripcion.ResetText()
        flag = 0
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.lblcodigo.Text = "" Or Me.txtdescripcion.Text = "" Then
            MessageBox.Show("Complete los Datos antes de Continuar", "Registro de Condición de la Propiedad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Me.flag = 0 Then
                ccondicion.Codcondpro = Me.lblcodigo.Text
                ccondicion.Condicion = Me.txtdescripcion.Text
                ccondicion.Estado = "1"
                If Me.ccondicion.AltaCondicion = True Then
                    MessageBox.Show("Información Guardada", "Registro de Condición de la Propiedad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf flag = 1 Then
                ccondicion.UpdateCondicion(Me.lblcodigo.Text, Me.txtdescripcion.Text)
            End If
        End If
        Llenadatagrid()
        btnCancelar.PerformClick()
        flag = 0
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
    End Sub
    Private Sub dgvcondiciones_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvcondiciones.DoubleClick
        Me.lblcodigo.Text = Convert.ToString(Me.dgvcondiciones.CurrentRow.Cells(0).Value)
        Me.txtdescripcion.Text = Convert.ToString(Me.dgvcondiciones.CurrentRow.Cells(1).Value)
        flag = 1
        Me.btnGuardar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnNuevo.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.flag = 1 Then
            Me.ccondicion.EliminarCondicion(Me.lblcodigo.Text)
        Else
            MessageBox.Show("Seleccione un elemento de la lista", "Registro de Condición de la Propiedad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged
        txtdescripcion.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class