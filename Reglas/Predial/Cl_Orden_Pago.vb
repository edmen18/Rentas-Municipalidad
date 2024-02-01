Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Orden_Pago
    Private _codpago As String
    Private _codorden As String
    Public Property CodOrden() As String
        Get
            Return _codorden
        End Get
        Set(ByVal value As String)
            _codorden = value
        End Set
    End Property

    Public Property CodPago() As String
        Get
            Return _codpago
        End Get
        Set(ByVal value As String)
            _codpago = value
        End Set
    End Property
    Public Function AltaOrden_Pago() As Boolean
        Try
            Dim csql As String = "Insert into T_Orden_Pago(codOrden,codpago) values('" + CodOrden.ToString + "','" + CodPago.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erro alta Condicion." + ex.ToString, "Condicion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
