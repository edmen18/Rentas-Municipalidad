Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_PredioCategoria
    Dim cFunDb As New cFuncionesDB
    Private _codPredio As String
    Private _CodContenido As String
    Private _usuario As String
    Private _valorunitario As Double
    Private _depreciacion As Double
    Private _valordepreciado As Double
    Private _area As Double
    Private _valorconstruccion As Double
    Private _fechaev As String
    Public Property FechaEv() As String
        Get
            Return _fechaev
        End Get
        Set(ByVal value As String)
            _fechaev = value
        End Set
    End Property

    Public Property ValorConstruccion() As Double
        Get
            Return _valorconstruccion
        End Get
        Set(ByVal value As Double)
            _valorconstruccion = value
        End Set
    End Property

    Public Property Area() As Double
        Get
            Return _area
        End Get
        Set(ByVal value As Double)
            _area = value
        End Set
    End Property

    Public Property ValorDepreciado() As Double
        Get
            Return _valordepreciado
        End Get
        Set(ByVal value As Double)
            _valordepreciado = value
        End Set
    End Property


    Public Property Depreciacion() As Double
        Get
            Return _depreciacion
        End Get
        Set(ByVal value As Double)
            _depreciacion = value
        End Set
    End Property

    Public Property ValorUnitario() As Double
        Get
            Return _valorunitario
        End Get
        Set(ByVal value As Double)
            _valorunitario = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
    Public Property CodContenido() As String
        Get
            Return _CodContenido
        End Get
        Set(ByVal value As String)
            _CodContenido = value
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
    Public Function AltaAsignacion() As Boolean
        Try
            Dim csql As String = "Insert into T_Predio_Contenido(CodPredio,CodContenido,fecha_Evaluacion,Usuario,valorunitario,depreciacion,valordepreciado,area,valorconstruccion)values('" + Me.CodPredio.ToString + "','" + Me.CodContenido.ToString + "','" + Me.FechaEv.ToString + "','" + Me.Usuario.ToString + "','" + Me.ValorUnitario.ToString + "','" + Me.Depreciacion.ToString + "','" + Me.ValorDepreciado.ToString + "','" + Me.Area.ToString + "','" + Me.ValorConstruccion.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            'pregunta = MessageBox.Show("Desea dar de Alta este Predio ", "Insercion de Predio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If pregunta = DialogResult.Yes Then
            db.ConfirmarTransaccion()
            'Else
            'db.CancelarTransaccion()
            'End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Predio" + ex.ToString, "Predio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function UltimoAnnio(ByRef predio As String) As String
        Dim strsql As String
        strsql = "select top(1)annio from t_djautovaluo t_dj inner join t_detalledj t_ddj on t_ddj.coddj=t_dj.coddj where codpredio='" + predio + "' order by fechaemision desc "
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
End Class
