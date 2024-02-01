Imports Datos
Imports Reglas
Imports Reportes
Public Class FrmZona
    Dim FunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim czona As New Cl_Zona
    Dim flag As Integer = 0
    Private Sub FrmZona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Llenadatagrid()
    End Sub

    Sub Encabezadosgrid()
        dgvzona.Columns(0).HeaderText = "Cod.Zona"
        dgvzona.Columns(0).Width = 100
        dgvzona.Columns(1).HeaderText = "Zona"
        dgvzona.Columns(1).Width = 300
    End Sub

    Sub Llenadatagrid()
        Dim cSql As String = "select codzona as Código,nombre from t_zona where estado='1'"
        FunDb.FillDataGridView(cSql, dgvzona)
        Encabezadosgrid()
        EstiloGrid.AplicaStiloBlue(dgvzona)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.lblcodigo.Text = Format(CInt(czona.GeneraCodZona()) + 1, "00")
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
                czona.CodZona = Me.lblcodigo.Text
                czona.Nombre = Me.txtdescripcion.Text
                czona.Estado = "1"
                If Me.czona.AltaZona = True Then
                    MessageBox.Show("Información Guardada", "Registro de Zona", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf flag = 1 Then
                czona.UpdateZona(Me.lblcodigo.Text, Me.txtdescripcion.Text)
            End If
        End If
        Llenadatagrid()
        btnCancelar.PerformClick()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        flag = 0
    End Sub

    Private Sub dgvzona_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvzona.DoubleClick
        Me.lblcodigo.Text = Convert.ToString(Me.dgvzona.CurrentRow.Cells(0).Value)
        Me.txtdescripcion.Text = Convert.ToString(Me.dgvzona.CurrentRow.Cells(1).Value)
        flag = 1
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnEliminar.Enabled = True
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.flag = 1 Then
            Me.czona.EliminarZona(Me.lblcodigo.Text)
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

End Class