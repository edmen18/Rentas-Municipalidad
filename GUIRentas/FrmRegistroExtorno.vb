Imports Reglas
Imports Datos
Public Class FrmRegistroExtorno
    Dim extorno As New Cl_Extorno
    Dim cFunDb As New cFuncionesDB
    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.lbloperacion.Text <> "" Or Me.lblmonto.Text <> "" Then
            extorno.CodExtorno = Format(CInt(extorno.Generaextorno()) + 1, "0000000000")
            extorno.FechaExtorno = Now.Date
            extorno.CodOperacion = Me.lbloperacion.Text
            extorno.FechaOperacion = Me.Dtfecha.Value.Date
            extorno.Monto = CDbl(Me.lblmonto.Text)
            extorno.MotivoExtorno = cmbMotivo.SelectedValue.ToString
            extorno.Usuario = MdiPrincipal.tsbDniUsu.Caption
            If extorno.AltaExtorno = True Then
                extorno.EliminarVenta(Me.lbloperacion.Text)
            End If
        End If
        limpiar()
        FrmExtorno.LlenaOperaciones()
        Me.Close()
    End Sub
    Sub limpiar()
        Me.Dtfecha.ResetText()
        Me.lbloperacion.ResetText()
        Me.lblmonto.ResetText()
    End Sub
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Sub FillMotivoExtorno()
        Dim csql As String = "SELECT CODMOTIVO, DESCRIPCION FROM T_MOTIVOEXTORNO"
        cFunDb.FillListaOrCombo(csql, cmbMotivo, "DESCRIPCION", "CODMOTIVO")
    End Sub

    Private Sub FrmRegistroExtorno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillMotivoExtorno()
    End Sub
End Class