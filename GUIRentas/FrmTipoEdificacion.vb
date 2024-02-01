Imports Reglas
Imports Datos
Public Class FrmTipoEdificacion

    Dim Edificacion As New Cl_TipoEdificacion
    Dim FunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim flag As String

    ''' <summary>
    ''' Metodos de Control de Formulario
    ''' </summary>
    ''' <remarks></remarks>
    Sub FillArancel()
        Dim Csql As String = "SELECT CODARANCEL, MONTO, ESTADO FROM T_ARANCEL"
        FunDb.FillListaOrCombo(Csql, cmbArancel, "monto", "CodArancel")
    End Sub

    Sub FillGridEdificacion()
        Dim Csql As String = "SELECT E.CODTIPOEDIFICACION AS CODIGO,E.DESCRIPCION,A.MONTO FROM T_TIPOEDIFICACION E INNER JOIN T_ARANCEL A ON A.CODARANCEL = E.CODARANCEL"
        FunDb.FillDataGridView(Csql, dgvEdificacion)
    End Sub

    Sub ResetTextBox()
        Me.txtCodigo.ResetText()
        Me.txtDescripcion.ResetText()
    End Sub


    Private Sub FrmTipoEdificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillArancel()
        FillGridEdificacion()
        EstiloGrid.AplicaStiloBlue(dgvEdificacion)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try
            flag = "Agrega"
            ResetTextBox()
            Me.txtDescripcion.Focus()

            If dgvEdificacion.Rows.Count > 0 Then
                Me.txtCodigo.Text = Format(CDbl(Edificacion.GeneraCodEdif()) + 1, "00")
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
        Edificacion.Codigo = txtCodigo.Text
        Edificacion.Descripcion = txtDescripcion.Text
        Edificacion.Arancel = cmbArancel.SelectedValue.ToString
        If flag = "Agrega" Then
            Edificacion.AltaTipoEdificacion()
        Else
            Edificacion.ModificarTipoEdificacion(Me.txtCodigo.Text)
        End If
        FillGridEdificacion()
        ResetTextBox()
        Me.btnGuardar.Enabled = False
        Me.btnNuevo.Enabled = True
        Me.btnEliminar.Enabled = False
    End Sub


    Private Sub dgvEdificacion_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvEdificacion.CellMouseDoubleClick
        If dgvEdificacion.Rows.Count > 0 Then
            flag = "Editar"
            Try
                Me.txtCodigo.Text = dgvEdificacion.Item(0, dgvEdificacion.CurrentRow.Index).Value.ToString()
                Me.txtDescripcion.Text = dgvEdificacion.Item(1, dgvEdificacion.CurrentRow.Index).Value.ToString()
                Me.cmbArancel.Text = dgvEdificacion.Item(2, dgvEdificacion.CurrentRow.Index).Value.ToString()
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
        Edificacion.EliminaTipoEdificacion(Me.txtCodigo.Text)
        ResetTextBox()
        FillGridEdificacion()
    End Sub

    
    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        Me.txtDescripcion.CharacterCasing = CharacterCasing.Upper
    End Sub

End Class