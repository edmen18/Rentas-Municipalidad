Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_DetalleRecibo
    Private _codrecibo As String
    Private _codpago As String
    Public Property CodPago() As String
        Get
            Return _codpago
        End Get
        Set(ByVal value As String)
            _codpago = value
        End Set
    End Property

    Public Property CodRecibo() As String
        Get
            Return _codrecibo
        End Get
        Set(ByVal value As String)
            _codrecibo = value
        End Set
    End Property
    Public Function Altadetalle() As Boolean
        Try
            Dim csql As String = "Insert into T_detallerecibo(codrecibo,CodPago) values('" + Me.CodRecibo.ToString + "','" + Me.CodPago.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
        Catch ex As Exception
            MessageBox.Show("Error Alta Detalle Recibo" + ex.ToString, "Detalle Recibo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Class
