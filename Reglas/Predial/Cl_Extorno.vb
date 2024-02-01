Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Extorno
    Dim cFunDb As New cFuncionesDB
    Private _codextorno As String
    Private _fechaextorno As Date
    Private _codoperacion As String
    Private _fechaoperacion As Date
    Private _monto As Double
    Private __codMotExt As String
    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property


    Public Property MotivoExtorno() As String
        Get
            Return __codMotExt
        End Get
        Set(ByVal value As String)
            __codMotExt = value
        End Set
    End Property

    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    Public Property FechaOperacion() As Date
        Get
            Return _fechaoperacion
        End Get
        Set(ByVal value As Date)
            _fechaoperacion = value
        End Set
    End Property

    Public Property CodOperacion() As String
        Get
            Return _codoperacion
        End Get
        Set(ByVal value As String)
            _codoperacion = value
        End Set
    End Property

    Public Property FechaExtorno() As Date
        Get
            Return _fechaextorno
        End Get
        Set(ByVal value As Date)
            _fechaextorno = value
        End Set
    End Property

    Public Property CodExtorno() As String
        Get
            Return _codextorno
        End Get
        Set(ByVal value As String)
            _codextorno = value
        End Set
    End Property
    Public Function AltaExtorno() As Boolean
        Try
            Dim csql As String = "Insert into T_Extorno(codextorno,fechaextorno,codoperacion,fechaoperacion,monto,CodMotivo,Usuario) values('" + CodExtorno.ToString + "','" + FechaExtorno.ToShortDateString + "','" + CodOperacion.ToString + "','" + FechaOperacion.ToShortDateString + "','" + Monto.ToString + "','" + MotivoExtorno.ToString + "','" + Me.Usuario.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Extornar la operacion. ", "Extorno de operacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error al Extornar la Operacion" + ex.ToString, "SRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function Generaextorno() As String
        Dim strsql As String
        strsql = "SELECT MAX(CONVERT(INT,codextorno)) AS CCOD FROM T_extorno"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function

    Public Function EliminarVenta(ByRef codventa As String) As Boolean
        Try
            Dim csql As String = "delete t_venta where codventa='" + codventa + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Eliminación Venta" + ex.ToString, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    'reporte de extornos
    Public Function ReporteExtornos(ByRef fechadel As Date, ByRef fechaal As Date) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select CodExtorno,convert(char(10),FechaExtorno,103) as FechaExtorno,CodOperacion,convert(char(10),FechaOperacion,103) as FechaOperacion,Monto,t_e.usuario,descripcion from dbo.T_Extorno t_e inner join t_motivoextorno t_me on t_me.codmotivo=t_e.codmotivo where FechaExtorno>='" + fechadel.Date.ToShortDateString + "' and FechaExtorno<='" + fechaal.Date.ToShortDateString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DTEXTORNOS")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
End Class
