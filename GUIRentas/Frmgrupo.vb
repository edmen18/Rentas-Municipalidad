Imports Reglas
Imports Datos
Public Class Frmgrupo
    Dim clgrupo As New Cl_grupo
    Dim clDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
   
    Private Sub Frmgrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.lblflag.Text = "0" Then
            Me.lblnumerogrupo.ResetText()
            Me.txtnombregrupo.ResetText()
            Me.Nudannio.Value = CInt(Now.Year)
            Dim xCod As Integer = CInt(clgrupo.GeneraCodArea()) + 1
            Me.lblnumerogrupo.Text = Format(xCod)
        End If
        If Me.lblflag.Text = "1" Then
            GetDatosGrupo(Me.lblnumerogrupo.Text)
        End If
    End Sub

    Private Sub txtnombregrupo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombregrupo.TextChanged
        Me.txtnombregrupo.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.lblnumerogrupo.ResetText()
        Me.txtnombregrupo.ResetText()
    End Sub

    Private Sub btnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.lblnumerogrupo.Text = "" Or Me.txtnombregrupo.Text = "" Then
            MsgBox("Complete los datos antes de continuar", MsgBoxStyle.Critical)
        Else
            clgrupo.NumeroGrupo = Me.lblnumerogrupo.Text
            clgrupo.NombreGrupo = Me.txtnombregrupo.Text
            clgrupo.Annio = CStr(Nudannio.Value)
            If Me.lblflag.Text = "0" Then
                clgrupo.AltaGrupo()
            Else
                clgrupo.ModificarGrupo(Me.lblnumerogrupo.Text)
            End If
            Me.txtnombregrupo.ResetText()
            Me.lblflag.Text = "0"
            Me.lblnumerogrupo.ResetText()
            Me.Nudannio.ResetText()
            FrmRegistros.LlenaLstViewGrupo()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Sub GetDatosGrupo(ByVal codigo As String)
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "SELECT * from t_grupo where numgru='" + codigo.ToString + "'"
            dt = cFun.ConsultaX(csql)
            Me.lblnumerogrupo.Text = CStr(dt.Rows(0).Item(0))
            Me.txtnombregrupo.Text = CStr(dt.Rows(0).Item(1))
            Me.Nudannio.Value = CStr(dt.Rows(0).Item(2))
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class