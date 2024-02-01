Imports Reglas
Public Class FrmCategorias
    Dim Denominacion As New Cl_Denominacion
    Dim validar As New Cl_Validar
    Private Sub btnAgrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgrega.Click

        If Me.txtCodigo.Text = "" Or Me.txtLetra.Text = "" Or Me.txtContenido.Text = "" Or Me.txtValor.Text = "" Then
            MessageBox.Show("Debe completar los datos antes de continuar", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Denominacion.CodContenido = Me.txtCodigo.Text
        Denominacion.CodIngresado = Me.txtLetra.Text
        Denominacion.Descripcion = Me.txtContenido.Text
        Denominacion.CodDenominacion = Me.txtColumna.Text
        Denominacion.Valor = CDbl(Me.txtValor.Text)

        If Me.lblFlag.Text = "New" Then
            If Denominacion.AltaContenidos() = True Then
                FrmValoresUnitarios.FillCategorias()
                LimpiaDatos()
            End If
        Else
            If Denominacion.ModificarContenidos(Me.txtCodigo.Text) = True Then
                FrmValoresUnitarios.FillCategorias()
                LimpiaDatos()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        LimpiaDatos()
        Me.Close()
    End Sub

    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        e.Handled = Validar.NumerosDecimales(System.Convert.ToInt16(Asc(e.KeyChar)))
    End Sub

    Private Sub txtLetra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLetra.TextChanged
        Me.txtLetra.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtContenido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContenido.TextChanged
        Me.txtContenido.CharacterCasing = CharacterCasing.Upper
    End Sub

    Sub LimpiaDatos()
        With Me
            .txtCodigo.ResetText()
            .txtColumna.ResetText()
            .txtContenido.ResetText()
            .txtDenominacion.ResetText()
            .txtLetra.ResetText()
            .txtValor.ResetText()
        End With
    End Sub

End Class