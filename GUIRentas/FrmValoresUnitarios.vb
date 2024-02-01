Imports Reglas
Imports Datos
Public Class FrmValoresUnitarios
    Dim cFunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim Denominacion As New Cl_Denominacion
    
#Region "Cargar Datos"
    Sub FillGridDenominacion()
        Dim csql As String = "SELECT CodDenominacion, Descripcion, Estado FROM T_Denominacion"
        cFunDb.FillDataGridView(csql, dgvDenominacion)
        HeadGridDenominacion()
        EstiloGrid.AplicaStiloOrange(dgvDenominacion)
    End Sub
    Sub FillCategorias()
        Dim codDenom As String = dgvDenominacion.Item(0, dgvDenominacion.CurrentRow.Index).Value
        Dim csql As String = "SELECT CodContenido, CodIngresado, Descripcion, CodDenominacion, Valor FROM T_Contenidos WHERE CodDenominacion = '" + codDenom + "' order by CodIngresado"
        cFunDb.FillDataGridView(csql, dgvCategorias)
        HeadGridCateg()
        EstiloGrid.AplicaStiloBlue(dgvCategorias)
    End Sub

#End Region

#Region "Eventos"
    Private Sub FrmValoresUnitarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillGridDenominacion()
    End Sub

    Private Sub btnAgrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgrega.Click
        FrmCategorias.lblFlag.Text = "New"
        LLenaFormCategNew()
        FrmCategorias.txtCodigo.Text = Denominacion.GeneraCodDenominacion() + 1
        FrmCategorias.ShowDialog()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        FrmCategorias.lblFlag.Text = "Edit"
        LLenaFormCategEdit()
        FrmCategorias.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim codD As String = dgvCategorias.Item(0, dgvCategorias.CurrentRow.Index).Value
        Denominacion.EliminarContenidos(codD)
        FillCategorias()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
#End Region

#Region "Funciones varias"
    Sub HeadGridDenominacion()
        With dgvDenominacion
            .Columns(0).Width = 50
            .Columns(0).HeaderText = "Cod"
            .Columns(1).Width = 250
            .Columns(1).HeaderText = "Descripcion"
            .Columns(2).Width = 50
            .Columns(2).HeaderText = "Estado"
        End With
    End Sub

    Sub HeadGridCateg()
        Try
            With dgvCategorias
                .Columns(0).Width = 40
                .Columns(0).HeaderText = "Cod"
                .Columns(1).Width = 40
                .Columns(1).HeaderText = "Cat"
                .Columns(2).Width = .Width - (.Columns(0).Width + .Columns(1).Width + .Columns(3).Width + .Columns(4).Width)
                .Columns(2).HeaderText = "Descripcion"
                .Columns(3).Width = 50
                .Columns(3).HeaderText = "CodDen"
                .Columns(4).Width = 80
                .Columns(4).HeaderText = "Valor"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
       
    End Sub
        
    Sub LLenaFormCategNew()
        With FrmCategorias
            .txtColumna.Text = dgvDenominacion.Item(0, dgvDenominacion.CurrentRow.Index).Value
            .txtDenominacion.Text = dgvDenominacion.Item(1, dgvDenominacion.CurrentRow.Index).Value
        End With


    End Sub

    Sub LLenaFormCategEdit()
        With FrmCategorias
            If dgvCategorias.RowCount > 0 Then
                .txtCodigo.Text = dgvCategorias.Item(0, dgvCategorias.CurrentRow.Index).Value
                .txtLetra.Text = dgvCategorias.Item(1, dgvCategorias.CurrentRow.Index).Value
                .txtContenido.Text = dgvCategorias.Item(2, dgvCategorias.CurrentRow.Index).Value
                .txtColumna.Text = dgvDenominacion.Item(0, dgvDenominacion.CurrentRow.Index).Value
                .txtDenominacion.Text = dgvDenominacion.Item(1, dgvDenominacion.CurrentRow.Index).Value
                .txtValor.Text = dgvCategorias.Item(4, dgvCategorias.CurrentRow.Index).Value
            Else
                MessageBox.Show("No se ha seleccionado un dato a Modificar", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    
    Private Sub dgvDenominacion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDenominacion.CellDoubleClick
        FillCategorias()
    End Sub
#End Region

   
End Class