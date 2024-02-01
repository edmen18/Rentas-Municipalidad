Imports Reglas
Imports Datos
Public Class FrmDepreciacion

    Dim Depreciacion As New Cl_Depreciacion
    Dim FunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim flag As String
    Dim validar As New Cl_Validar

    ''' <summary>
    ''' Metodos de Control de Formulario
    ''' </summary>
    ''' <remarks></remarks>
    Sub FillEdificacion()
        Dim Csql As String = "SELECT CodTipoEdificacion, Descripcion FROM T_TIPOEDIFICACION"
        FunDb.FillListaOrCombo(Csql, cmbEdificacion, "Descripcion", "CodTipoEdificacion")
    End Sub

    Sub FillMaterial()
        Dim Csql As String = "SELECT CodMaterial, Descripcion FROM T_MATERIAL"
        FunDb.FillListaOrCombo(Csql, cmbMaterial, "Descripcion", "CodMaterial")
    End Sub

    Sub FillConservacion()
        Dim Csql As String = "SELECT CodEstado, Estado FROM T_EstadoConservacion"
        FunDb.FillListaOrCombo(Csql, cmbConservacion, "Estado", "CodEstado")
    End Sub

    Sub FillGridDepreciacion()
        Dim Csql As String = "SELECT D.CodDepreciacion as Cod,E.Descripcion,D.Desde,D.Hasta,M.Descripcion AS Material,C.Estado,D.Valor FROM T_Depreciacion D INNER JOIN T_TipoEdificacion E ON E.CodTipoEdificacion = D.CodTipoEdificacion INNER JOIN T_Material M ON M.CodMaterial = D.CodMaterial INNER JOIN T_EstadoConservacion C ON C.CodEstado = D.CodEstado"
        FunDb.FillDataGridView(Csql, dgvDepreciacion)
        HeadGridDepre()
    End Sub

    Sub ResetTextBox()
        Me.txtCodigo.ResetText()

    End Sub

    Private Sub FrmTipoDepreciacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = MdiPrincipal.ClientPanel.Height - MdiPrincipal.stbSistema.Height

        FillEdificacion()
        FillMaterial()
        FillConservacion()
        FillGridDepreciacion()
        EstiloGrid.AplicaStiloBlue(dgvDepreciacion)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            flag = "Agrega"
            ResetTextBox()
            If dgvDepreciacion.Rows.Count > 0 Then
                Me.txtCodigo.Text = Format(CDbl(Depreciacion.GeneraCodDepreciacion()) + 1, "000")
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
        Depreciacion.Codigo = txtCodigo.Text
        Depreciacion.TipoEdificacion = Me.cmbEdificacion.SelectedValue.ToString
        Depreciacion.Material = Me.cmbMaterial.SelectedValue.ToString
        Depreciacion.Conservacion = Me.cmbConservacion.SelectedValue.ToString
        Depreciacion.Desde = CInt(nudDesde.Value.ToString)
        Depreciacion.Hasta = CInt(nudHasta.Value.ToString)
        Depreciacion.Valor = CInt(Me.txtValor.Text)
        If flag = "Agrega" Then
            Depreciacion.AltaDepreciacion()
        Else
            Depreciacion.ModificarDepreciacion(Me.txtCodigo.Text)
        End If
        FillGridDepreciacion()
        ResetTextBox()
        Me.btnGuardar.Enabled = False
        Me.btnNuevo.Enabled = True
        Me.btnEliminar.Enabled = False
    End Sub


    Private Sub dgvDepreciacion_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDepreciacion.CellMouseDoubleClick
        If dgvDepreciacion.Rows.Count > 0 Then
            flag = "Editar"
            Try
                Me.txtCodigo.Text = dgvDepreciacion.Item(0, dgvDepreciacion.CurrentRow.Index).Value.ToString()
                Me.cmbEdificacion.Text = dgvDepreciacion.Item(1, dgvDepreciacion.CurrentRow.Index).Value.ToString()
                Me.nudDesde.Text = dgvDepreciacion.Item(2, dgvDepreciacion.CurrentRow.Index).Value.ToString()
                Me.nudHasta.Text = dgvDepreciacion.Item(3, dgvDepreciacion.CurrentRow.Index).Value.ToString()
                Me.cmbMaterial.Text = dgvDepreciacion.Item(4, dgvDepreciacion.CurrentRow.Index).Value.ToString()
                Me.cmbConservacion.Text = dgvDepreciacion.Item(5, dgvDepreciacion.CurrentRow.Index).Value.ToString()
                Me.txtValor.Text = dgvDepreciacion.Item(6, dgvDepreciacion.CurrentRow.Index).Value.ToString()

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
        If Depreciacion.EliminaDepreciacion(Me.txtCodigo.Text) = True Then
            ResetTextBox()
            FillGridDepreciacion()
        End If
      
    End Sub

    Sub HeadGridDepre()
        With dgvDepreciacion
            .Columns(0).Width = 50
            .Columns(1).Width = 150
            .Columns(2).Width = 60
            .Columns(3).Width = 60
            .Columns(4).Width = 100
            .Columns(5).Width = 100
            .Columns(6).Width = 80
        End With
    End Sub
    
    Private Sub txtValor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        e.Handled = validar.NumerosDecimales(System.Convert.ToInt16(Asc(e.KeyChar)))

    End Sub

End Class