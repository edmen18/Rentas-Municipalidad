Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_DetalleOrden
    Private _codOrden As String
    Private _annio As String
    Private _baseImponible As Double
    Private _insolutos As String
    Private _impuestoAnual As Double
    Private _trimestres As String
    Private _insoluto As Double
    Private _reajuste As Double
    Private _interes As Double
    Private _total As Double
    Private _tramo As String
    Private _alicuota As String
    Public Property AliCuota() As String
        Get
            Return _alicuota
        End Get
        Set(ByVal value As String)
            _alicuota = value
        End Set
    End Property

    Public Property Tramo() As String
        Get
            Return _tramo
        End Get
        Set(ByVal value As String)
            _tramo = value
        End Set
    End Property

    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property

    Public Property Interes() As Double
        Get
            Return _interes
        End Get
        Set(ByVal value As Double)
            _interes = value
        End Set
    End Property

    Public Property Reajuste() As Double
        Get
            Return _reajuste
        End Get
        Set(ByVal value As Double)
            _reajuste = value
        End Set
    End Property

    Public Property Insoluto() As Double
        Get
            Return _insoluto
        End Get
        Set(ByVal value As Double)
            _insoluto = value
        End Set
    End Property

    Public Property Trimestres() As String
        Get
            Return _trimestres
        End Get
        Set(ByVal value As String)
            _trimestres = value
        End Set
    End Property

    Public Property ImpuestoAnual() As Double
        Get
            Return _impuestoAnual
        End Get
        Set(ByVal value As Double)
            _impuestoAnual = value
        End Set
    End Property

    Public Property Insolutos() As String
        Get
            Return _insolutos
        End Get
        Set(ByVal value As String)
            _insolutos = value
        End Set
    End Property

    Public Property BaseImponible() As Double
        Get
            Return _baseImponible
        End Get
        Set(ByVal value As Double)
            _baseImponible = value
        End Set
    End Property

    Public Property Annio() As String
        Get
            Return _annio
        End Get
        Set(ByVal value As String)
            _annio = value
        End Set
    End Property

    Public Property CodOrden() As String
        Get
            Return _codOrden
        End Get
        Set(ByVal value As String)
            _codOrden = value
        End Set
    End Property
    Public Function AltaDetalleOrden() As Boolean
        Try
            Dim csql As String = "Insert into T_detalleOrden(CodOrden,annio,baseimponible,insolutos,impuestoanual,trimestres,insoluto,reajuste,interes,total,tramo,alicuota) values('" + CodOrden.ToString + "','" + Annio.ToString + "','" + BaseImponible.ToString + "','" + Insolutos.ToString + "','" + ImpuestoAnual.ToString + "','" + Trimestres.ToString + "','" + Insoluto.ToString + "','" + Reajuste.ToString + "','" + Interes.ToString + "','" + Total.ToString + "','" + Tramo.ToString + "','" + AliCuota.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Alta Detalle Orden" + ex.ToString, "Orden Pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
