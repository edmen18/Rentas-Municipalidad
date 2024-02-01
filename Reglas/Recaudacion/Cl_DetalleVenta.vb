Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_DetalleVenta
    Private _codVenta As String
    Private _numCla As String
    Private _precioVenta As Double
    Private _cantidad As Integer
    Private _codUit As String
    Private _subtotal As Double

    Public Property Subtotal() As Double
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Double)
            _subtotal = value
        End Set
    End Property


    Public Property CodUit() As String
        Get
            Return _codUit
        End Get
        Set(ByVal value As String)
            _codUit = value
        End Set
    End Property

    Public Property Cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
        End Set
    End Property
    Public Property PrecioVenta() As Double
        Get
            Return _precioVenta
        End Get
        Set(ByVal value As Double)
            _precioVenta = value
        End Set
    End Property

    Public Property NumCla() As String
        Get
            Return _numCla
        End Get
        Set(ByVal value As String)
            _numCla = value
        End Set
    End Property

    Public Property CodVenta() As String
        Get
            Return _codVenta
        End Get
        Set(ByVal value As String)
            _codVenta = value
        End Set
    End Property
    Public Function AltaDetalleVenta() As Boolean
        Try
            Dim csql As String = "Insert into T_DetalleVenta(codventa,NumCla,precioventa,cantidad,subtotal,coduit,estado,numpapeleta) values('" + Me.CodVenta.ToString + "','" + Me.NumCla.ToString + "','" + Me.PrecioVenta.ToString + "','" + Me.Cantidad.ToString + "','" + Me.Subtotal.ToString + "','" + Me.CodUit.ToString + "','0','0')"
            Dim db As BaseDatos = New BaseDatos()
            'Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            'pregunta = MessageBox.Show("Desea dar de Alta esta dVenta ", "Insercion de Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If pregunta = DialogResult.Yes Then
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta dVenta" + ex.ToString, "dVenta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function editarDetalleVenta(ByVal venta As String, ByVal numcla As String, ByVal numpapeleta As String) As Boolean
        Try
            Dim csql As String = "update T_DetalleVenta set estado='1',numpapeleta='" + numpapeleta.ToString + "' where codventa='" + venta + "'and numcla='" + numcla + "'"
            Dim db As BaseDatos = New BaseDatos()
            ' Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            ' pregunta = MessageBox.Show("Desea modificar este detalle ", "Edicion de Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If pregunta = DialogResult.Yes Then
            db.ConfirmarTransaccion()
            'Else
            '    db.CancelarTransaccion()
            'End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Edicion Detalle Venta" + ex.ToString, "Detalle Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
