Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_DatosDetalle
    Private _codorden As String
    Private _valorUit As String
    Private _reajuste As String
    Private _tim As String
    Public Property Tim() As String
        Get
            Return _tim
        End Get
        Set(ByVal value As String)
            _tim = value
        End Set
    End Property

    Public Property Reajuste() As String
        Get
            Return _reajuste
        End Get
        Set(ByVal value As String)
            _reajuste = value
        End Set
    End Property

    Public Property ValorUit() As String
        Get
            Return _valorUit
        End Get
        Set(ByVal value As String)
            _valorUit = value
        End Set
    End Property

    Public Property CodOrden() As String
        Get
            Return _codorden
        End Get
        Set(ByVal value As String)
            _codorden = value
        End Set
    End Property
    Public Function AltadetalleDatos() As Boolean
        Try
            Dim csql As String = "Insert into T_DatosDetalle(codorden,valoruit,reajuste,tim) values('" + Me.CodOrden.ToString + "','" + Me.ValorUit.ToString + "','" + Me.Reajuste.ToString + "','" + Me.Tim.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            'Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            'pregunta = MessageBox.Show("Desea dar de Alta esta dVenta ", "Insercion de Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If pregunta = DialogResult.Yes Then
            db.ConfirmarTransaccion()
            'Else
            'db.CancelarTransaccion()
            'End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta detalle datos" + ex.ToString, "datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
