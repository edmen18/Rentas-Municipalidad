Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_DetalleDJ
    Private _codDJ As String
    Private _codPredio As String
    Private _categorias As String
    Private _vunit As Double
    Private _depr As Double
    Private _montod As Double
    Private _vud As Double
    Private _areaContruida As Double
    Private _valorConstruccon As Double

    Public Property ValorConstruccion() As Double
        Get
            Return _valorConstruccon
        End Get
        Set(ByVal value As Double)
            _valorConstruccon = value
        End Set
    End Property

    Public Property AreaConstruida() As Double
        Get
            Return _areaContruida
        End Get
        Set(ByVal value As Double)
            _areaContruida = value
        End Set
    End Property

    Public Property Vud() As Double
        Get
            Return _vud
        End Get
        Set(ByVal value As Double)
            _vud = value
        End Set
    End Property

    Public Property MontoD() As Double
        Get
            Return _montod
        End Get
        Set(ByVal value As Double)
            _montod = value
        End Set
    End Property

    Public Property Depr() As Double
        Get
            Return _depr
        End Get
        Set(ByVal value As Double)
            _depr = value
        End Set
    End Property

    Public Property Vunit() As Double
        Get
            Return _vunit
        End Get
        Set(ByVal value As Double)
            _vunit = value
        End Set
    End Property

    Public Property Categorias() As String
        Get
            Return _categorias
        End Get
        Set(ByVal value As String)
            _categorias = value
        End Set
    End Property

    Public Property CodPredio() As String
        Get
            Return _codPredio
        End Get
        Set(ByVal value As String)
            _codPredio = value
        End Set
    End Property

    Public Property CodDj() As String
        Get
            Return _codDJ
        End Get
        Set(ByVal value As String)
            _codDJ = value
        End Set
    End Property
    Public Function AltadetalleDJ() As Boolean
        Try
            Dim csql As String = "Insert into T_DetalleDJ(CodDJ, CodPredio,Categorias,Vunit,Depr,MontoD,Vud,AreaConstruida,ValorConstruccion) values('" + CodDj.ToString + "','" + CodPredio.ToString + "','" + Categorias.ToString + "','" + Vunit.ToString + "','" + Depr.ToString + "','" + MontoD.ToString + "','" + Vud.ToString + "','" + AreaConstruida.ToString + "','" + ValorConstruccion.ToString + "')"
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
            MessageBox.Show("Error Alta dVenta" + ex.ToString, "dVenta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
