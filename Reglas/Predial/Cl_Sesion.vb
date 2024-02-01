Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Sesion
    Private _dni As String
    Dim cFunDb As New cFuncionesDB
    Public ReadOnly Property Dni(ByVal cUsuario As String) As String
        Get
            getDni(cUsuario)
            Return _dni
        End Get
    End Property

    Private Sub getDni(ByVal CodUsuario As String)
        Try
            Dim dt As New DataTable
            Dim csql As String = "SELECT  DNI from t_usuarios where codusuario = '" + CodUsuario + "'"
            dt = cFunDb.ConsultaX(csql)
            _dni = CStr(dt.Rows(0).Item(0))
          
            'Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
