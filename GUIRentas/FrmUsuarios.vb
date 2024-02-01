Imports Reglas
Imports Datos
Public Class FrmUsuarios
    Dim csesion As New Cl_Usuarios
    Dim FunDb As New cFuncionesDB
    Dim codusuario As String
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim validar As New Cl_Validar
    Dim flag As Integer
  
    Sub LLenarCombo()
        Dim csql As String = "SELECT codnivel,descripcion from t_nivel"
        FunDb.FillListaOrCombo(csql, Me.CmbClave, "descripcion", "codnivel")
    End Sub
    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.txtnombre.Text = "" Or Me.txtapellidos.Text = "" Or Me.txtusuario.Text = "" Or Me.txtdni.Text = "" Or Me.txtusuario.Text = "" Or Me.txtclave.Text = "" Or Me.txtconfclave.Text = "" Then
            MessageBox.Show("Complete los datos antes de continuar", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Me.txtclave.Text <> Me.txtconfclave.Text Then
                MessageBox.Show("Error la Clave esta mal digitada", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                codusuario = Format(CInt(csesion.GeneraCodUsuario) + 1, "00000")
                csesion.CodUsuario = codusuario
                csesion.Nombreu = Me.txtnombre.Text
                csesion.Apellidou = Me.txtapellidos.Text
                csesion.Dni = Me.txtdni.Text
                csesion.Clave = Me.txtconfclave.Text
                csesion.Usuario = Me.txtusuario.Text
                csesion.CodNivel = Me.CmbClave.SelectedValue.ToString

                If flag = 0 Then
                    If csesion.AltaUsuario() = True Then
                        limpiar()
                        FillGridUsuarios()
                    End If
                Else
                    Dim CodUsu As String = dgvUsuarios.Item(0, dgvUsuarios.CurrentRow.Index).Value
                    If csesion.ActualizaUsuario(CodUsu) = True Then
                        limpiar()
                        FillGridUsuarios()
                    End If
                End If
                End If
            End If
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Dim CodUsu As String = dgvUsuarios.Item(0, dgvUsuarios.CurrentRow.Index).Value
        If csesion.EliminaUsuario(CodUsu) = True Then
            limpiar()
            FillGridUsuarios()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
    Sub limpiar()
        Me.txtnombre.ResetText()
        Me.txtapellidos.ResetText()
        Me.txtdni.ResetText()
        Me.txtusuario.ResetText()
        Me.txtconfclave.ResetText()
        Me.txtclave.ResetText()
    End Sub

    Sub FillGridUsuarios()
        Dim cSql As String = "SELECT T_U.CodUsuario,T_U.Nombres,T_U.Apellidos,T_U.DNI,T_N.Descripcion,T_U.Usuario,T_U.Clave FROM T_USUARIOS T_U INNER JOIN T_NIVEL T_N ON T_U.CodNivel = T_N.CodNivel "
        FunDb.FillDataGridView(cSql, dgvUsuarios)
        EstiloGrid.AplicaStiloBlue(dgvUsuarios)
    End Sub

    Private Sub FrmUsuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LLenarCombo()
        FillGridUsuarios()
    End Sub

    Private Sub dgvUsuarios_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick
        flag = 1
        With dgvUsuarios
            Me.txtnombre.Text = .Item(1, .CurrentRow.Index).Value
            Me.txtapellidos.Text = .Item(2, .CurrentRow.Index).Value
            Me.txtdni.Text = .Item(3, .CurrentRow.Index).Value
            Me.CmbClave.Text = .Item(4, .CurrentRow.Index).Value
            Me.txtusuario.Text = .Item(5, .CurrentRow.Index).Value
            Me.txtclave.Text = .Item(6, .CurrentRow.Index).Value
            Me.txtconfclave.Text = .Item(6, .CurrentRow.Index).Value

        End With
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged
        Me.txtnombre.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtapellidos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapellidos.TextChanged
        Me.txtapellidos.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtdni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdni.KeyPress
        e.Handled = validar.NumerosEnteros(System.Convert.ToInt16(Asc(e.KeyChar)))
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        flag = 0
        Me.txtnombre.Focus()
    End Sub

    Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusuario.TextChanged
        Me.txtusuario.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class