Imports Reglas
Imports Datos
Public Class FrmClases
    Dim clclase As New Cl_clase
    Dim uit As New Cl_uit
    Dim FunDb As New cFuncionesDB
    Dim Validar As New Cl_Validar
    Private Sub FrmClases_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cancelar()
    End Sub

    Private Sub FrmClases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LLenarComboclase()
        LLenarCombocuenta()
        If Me.lblflg.Text = "0" Then
            Dim xCod As Integer = CInt(clclase.GeneraCodClase(Me.lblnumeroGrupo.Text)) + 1
            Me.lblNumClase.Text = Me.lblnumeroGrupo.Text & "." & Format(xCod)
            Me.nudannio.Value = CInt(Now.Year)
        Else
            GetDatosClase(Me.lblNumClase.Text)
        End If
    End Sub
    Sub LLenarComboclase()
        Dim csql As String = "select codtipo,descripcion from t_tipo "
        FunDb.FillListaOrCombo(csql, cbotiposervicio, "descripcion", "codtipo")
    End Sub
    Sub LLenarCombocuenta()
        Dim csql As String = "select codcta,descripcion from t_cuenta "
        FunDb.FillListaOrCombo(csql, cbocta, "descripcion", "codcta")
    End Sub
    Sub GetDatosClase(ByVal codigoClase As String)
        'Try
        Dim dt As New DataTable
        Dim cFun As New cFuncionesDB
        Dim csql As String = "SELECT numcla,descla,numgru,tc.porcentaje,tt.codtipo,tt.descripcion,tc.codcta,tct.descripcion,tc.annio from t_clase tc inner join t_tipo tt on tt.codtipo=tc.codtipo inner join t_cuenta tct on tct.codcta=tc.codcta where tc.numcla='" + codigoClase.ToString + "'"
        dt = cFun.ConsultaX(csql)
        Me.lblNumClase.Text = CStr(dt.Rows(0).Item(0))
        Me.txtclase.Text = CStr(dt.Rows(0).Item(1))
        Me.lblnumeroGrupo.Text = CStr(dt.Rows(0).Item(2))
        Me.txtuitclase.Text = CStr(dt.Rows(0).Item(3))
        Me.cbotiposervicio.Text = CStr(dt.Rows(0).Item(5))
        Me.cbotiposervicio.SelectedValue = CStr(dt.Rows(0).Item(4))
        Me.cbocta.SelectedValue = CStr(dt.Rows(0).Item(6))
        Me.cbocta.Text = CStr(dt.Rows(0).Item(7))
        Me.nudannio.Value = (dt.Rows(0).Item(8))
        'Catch ex As Exception
        '    MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try
    End Sub

    Sub cancelar()
        Me.lblflg.Text = "0"
        Me.lblNumClase.Text = ""
        Me.txtclase.Text = ""
        Me.lblnumeroGrupo.Text = ""
        Me.txtuitclase.Text = ""
        Me.cbotiposervicio.Text = ""
    End Sub

    Private Sub btnGrabarClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarClase.Click
        If Me.lblNumClase.Text = "" Or Me.txtclase.Text = "" Or Me.txtuitclase.Text = "" Then
            MsgBox("Complete los datos antes de continuar", MsgBoxStyle.Critical)
        Else
            clclase.Annio = CStr(Me.nudannio.ToString)
            clclase.NumGru = Me.lblnumeroGrupo.Text
            clclase.NumCla = Me.lblNumClase.Text
            clclase.DesCla = Me.txtclase.Text
            clclase.Porcentaje = CDbl(Me.txtuitclase.Text)
            clclase.CodTipo = Me.cbotiposervicio.SelectedValue.ToString
            clclase.CodCta = Me.cbocta.SelectedValue.ToString
            verificaValor()
            If Me.lblflg.Text = "0" Then
                clclase.Altaclase()
            Else
                clclase.Modificarclase(Me.lblNumClase.Text)
            End If
            FrmRegistros.LlenaLstViewclase()
            cancelar()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelarClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarClase.Click
        cancelar()
        Me.Close()
    End Sub

    Private Sub txtclase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtclase.TextChanged
        Me.txtclase.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtuitclase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuitclase.KeyPress
        e.Handled = Validar.NumerosDecimales(System.Convert.ToInt16(Asc(e.KeyChar)))
    End Sub

    Sub verificaValor()
        If Me.cbotiposervicio.SelectedValue = "1" Then
            clclase.Valor = Format(CDbl(txtuitclase.Text) / 100 * CDbl(uit.getValorActualUIT()), "#,##0.00")
        Else
            clclase.Valor = Format(CDbl(txtuitclase.Text), "#,##0,0.00")
        End If
    End Sub

End Class