Imports Reglas
Imports Datos
Public Class FrmEstadoConserv

    Dim Conservacion As New Cl_EstadoConservacion
    Dim FunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim flag As String

    ''' <summary>
    ''' Metodos de Control de Formulario
    ''' </summary>
    ''' <remarks></remarks>
  
    Sub FillGridConservacion()
        Dim Csql As String = "SELECT CODESTADO AS CODIGO,ESTADO FROM T_EstadoConservacion"
        FunDb.FillDataGridView(Csql, dgvConservacion)
    End Sub

    Sub ResetTextBox()
        Me.txtCodigo.ResetText()
        Me.txtDescripcion.ResetText()
    End Sub


    Private Sub FrmTipoConservacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGridConservacion()
        EstiloGrid.AplicaStiloBlue(dgvConservacion)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try
            flag = "Agrega"
            ResetTextBox()
            Me.txtDescripcion.Focus()

            If dgvConservacion.Rows.Count > 0 Then
                Me.txtCodigo.Text = Format(CDbl(Conservacion.GeneraCodEstado()) + 1, "00")
            Else
                Me.txtCodigo.Text = "01"
            End If

            Me.btnGuardar.Enabled = True
            Me.btnCancelar.Enabled = True
            Me.btnNuevo.Enabled = False
            Me.btnEliminar.Enabled = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Conservacion.Codigo = txtCodigo.Text
        Conservacion.Descripcion = txtDescripcion.Text
        If flag = "Agrega" Then
            Conservacion.AltaEstadoCoservacion()
        Else
            Conservacion.ModificarEstadoConservacion(Me.txtCodigo.Text)
        End If
        FillGridConservacion()
        ResetTextBox()
        Me.btnGuardar.Enabled = False
        Me.btnNuevo.Enabled = True
        Me.btnEliminar.Enabled = False
    End Sub


    Private Sub dgvConservacion_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvConservacion.CellMouseDoubleClick
        If dgvConservacion.Rows.Count > 0 Then
            flag = "Editar"
            Try
                Me.txtCodigo.Text = dgvConservacion.Item(0, dgvConservacion.CurrentRow.Index).Value.ToString()
                Me.txtDescripcion.Text = dgvConservacion.Item(1, dgvConservacion.CurrentRow.Index).Value.ToString()
                Me.btnGuardar.Enabled = True
                Me.btnNuevo.Enabled = False
                Me.btnEliminar.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.ToString(), "Error al operar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        ResetTextBox()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Conservacion.EliminaEstadoConservacion(Me.txtCodigo.Text)
        ResetTextBox()
        FillGridConservacion()
    End Sub


    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        Me.txtDescripcion.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class