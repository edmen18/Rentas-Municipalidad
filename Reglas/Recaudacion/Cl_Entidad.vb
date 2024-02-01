Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Entidad
    Dim cFunDb As New cFuncionesDB

    Private _ruc As String
    Private _nombre As String
    Private _telefono As String
    Private _direccion As String


    Public ReadOnly Property Direccion() As String
        Get
            GetEntidad()
            Return _direccion
        End Get
    End Property

    Public ReadOnly Property Telefono() As String
        Get
            GetEntidad()
            Return _telefono
        End Get
    End Property

    Public ReadOnly Property Nombre() As String
        Get
            GetEntidad()
            Return _nombre
        End Get
    End Property
    Public ReadOnly Property Ruc() As String
        Get
            GetEntidad()
            Return _ruc
        End Get
    End Property
    Private Sub GetEntidad()
        Try
            Dim dt As New DataTable
            Dim csql As String = "SELECT  * from t_entidad"
            dt = cFunDb.ConsultaX(csql)
            _ruc = CStr(dt.Rows(0).Item(0))
            _nombre = CStr(dt.Rows(0).Item(1))
            _telefono = CStr(dt.Rows(0).Item(2))
            _direccion = CStr(dt.Rows(0).Item(3))
            'Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Function nombreentidad() As String
        Dim strsql As String
        strsql = "SELECT  descripcion from t_entidad"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
    Function RUCentidad() As String
        Dim strsql As String
        strsql = "SELECT  RUCENTIDAD from t_entidad"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
End Class
