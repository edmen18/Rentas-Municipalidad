Imports Datos
Imports Reglas
Public Class FrmInicioSesion
    Public var As String
    Dim Sesion As New Cl_Sesion
    Dim variables As New variables
    Sub GetDatosCliente()
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "SELECT dni,usuario,clave,CodNivel from t_usuarios where usuario='" + Me.txtusuario.Text + "'and clave='" + Me.txtcontraseña.Text + "'"
            dt = cFun.ConsultaX(csql)
            If Me.txtusuario.Text = CStr(dt.Rows(0).Item(1)) And Me.txtcontraseña.Text = CStr(dt.Rows(0).Item(2)) Then
                MdiPrincipal.tsbDniUsu.Caption = CStr(dt.Rows(0).Item(0))
                MdiPrincipal.tsbUsuario.Caption = "Usted esta logueado como " & CStr(dt.Rows(0).Item(1))
                If CStr(dt.Rows(0).Item(3)) = "00002" Then
                    MdiPrincipal.btnUsuarios.Enabled = False
                End If
                Me.Hide()
                MdiPrincipal.Show()
            Else
                MessageBox.Show("Error de Inicio de Sesion el usuario y/o contraseña son incorrectos", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtcontraseña.ResetText()
                Me.txtusuario.ResetText()
            End If

        Catch ex As Exception
            MessageBox.Show("Error de Inicio de Sesion el usuario y/o contraseña son incorrectos", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtcontraseña.ResetText()
            Me.txtusuario.ResetText()
        End Try
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        GetDatosCliente()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusuario.TextChanged
        Me.txtusuario.CharacterCasing = CharacterCasing.Upper
    End Sub

#Region "Inicia Splash"
    Private Sub ShowSplash()
        Dim fSplash As New Splash
        Me.Hide()
        fSplash.Owner = Me
        fSplash.Show()
        Application.DoEvents()
        Threading.Thread.Sleep(1000)
        'CargaDsIniciales()
        fSplash.Close()
        fSplash.Dispose()
        Me.WindowState = FormWindowState.Normal
        Me.Show()
    End Sub
#End Region

    Private Sub FrmInicioSesion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ShowSplash()
        ActivaTrial()
    End Sub

    Sub Trial()
        MdiPrincipal.btnOrden.Enabled = False
    End Sub

    Sub ActivaTrial()
        Try
            If verificaReg <> "256" Then
                Trial()
            Else
                MdiPrincipal.btnRegistro.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class