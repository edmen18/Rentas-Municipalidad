Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Empoce
    Private _codCta As String
    Private _monto As Double
    Private _fecha As String
    Private _numPapeleta As String
    Private _responsable As String
    Dim cFunDb As New cFuncionesDB
    Private _fechaal As String
    Public Property FechaAl() As String
        Get
            Return _fechaal
        End Get
        Set(ByVal value As String)
            _fechaal = value
        End Set
    End Property


    Public Property Responsable() As String
        Get
            Return _responsable
        End Get
        Set(ByVal value As String)
            _responsable = value
        End Set
    End Property

    Public Property NumPapeleta() As String
        Get
            Return _numPapeleta
        End Get
        Set(ByVal value As String)
            _numPapeleta = value
        End Set
    End Property


    Public Property Fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
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

    Public Property CodCta() As String
        Get
            Return _codCta
        End Get
        Set(ByVal value As String)
            _codCta = value
        End Set
    End Property
    Public Function AltaEmpoce() As Boolean
        Try
            Dim csql As String = "Insert into T_Empoce(codcta,monto,fechadel,fechaal,numpapeleta,Responsable) values('" + Me.CodCta.ToString + "','" + Me.Monto.ToString + "','" + Me.Fecha.ToString + "','" + Me.FechaAl.ToString + "','" + Me.NumPapeleta.ToString + "','" + Me.Responsable.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este Empoce ", "Insercion de Empoce", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Empoce" + ex.ToString, "Empoce", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function getEntidad(ByVal cuenta As String) As String
        Dim strsql As String
        strsql = "SELECT entidad FROM T_cuenta where codcta='" + cuenta + "'"
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearComando(strsql)
        Dim NomEntidad As String = CStr(db.EjecutarEscalarSring())
        Return NomEntidad
    End Function


    Public Function detalleempoce(ByVal dato As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select tdv.codventa,tcl.descla,tdv.subtotal,te.NumPapeleta,te.responsable from t_empoce te inner join t_detalleventa tdv on tdv.numpapeleta=te.numpapeleta inner join t_clase tcl on tcl.numcla=tdv.numcla where te.numpapeleta='" + dato + "' and tdv.estado='1'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "Dtdetallempoce")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Function Reporteempoce(ByRef dtdel As Date, ByRef detal As Date) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select NumPapeleta,tc.CodCta,tc.Descripcion,entidad,convert(varchar(10),Fechadel,103)+' Al '+convert(varchar(10),Fechadel,103) as fecha,monto,responsable as responsab from t_empoce te inner join t_cuenta tc on tc.codcta=te.codcta where te.fechadel>='" + CStr(dtdel.Date) + "' and te.fechaal<='" + CStr(detal.Date) + "' "
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "Dt_Empoces")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

    Public Overloads Function balance(ByRef fechadel As Date, ByRef fechaal As Date) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "SELECT TC.CODCTA,DESCRIPCION,SUM(MONTO)AS MONTO FROM T_EMPOCE TE INNER JOIN T_CUENTA TC ON TC.CODCTA=TE.CODCTA where fechadel>='" + fechadel.Date.ToShortDateString + "' and fechaal<='" + fechaal.Date.ToShortDateString + "' GROUP BY TC.CODCTA,DESCRIPCION"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DTBALANCE")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
End Class
