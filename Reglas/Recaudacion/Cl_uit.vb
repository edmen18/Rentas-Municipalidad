Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_uit
    Dim cFunDb As New cFuncionesDB

    Private _valorUIT As Integer
    Private _codUIT As String

#Region "Recuperar datos de la UIT"

    Public ReadOnly Property CodigoUIT() As String
        Get
            GetDatosUIT()
            Return _codUIT
        End Get
    End Property

    Public ReadOnly Property getValorActualUIT() As Integer
        Get
            GetDatosUIT()
            Return _valorUIT
        End Get
    End Property

    Private Sub GetDatosUIT()
        Try
            Dim dt As New DataTable
            Dim csql As String = "SELECT CodUit,Valor FROM T_UIT WHERE ESTADO='A'"
            dt = cFunDb.ConsultaX(csql)
            _codUIT = CStr(dt.Rows(0).Item(0))
            _valorUIT = CInt(dt.Rows(0).Item(1))
            'Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
#End Region


End Class
