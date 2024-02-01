Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_OrdenPago
    Private _codOrden As String
    Private _codCli As String
    Private _monto As Double
    Private _fechaAct As String
    Private _fechaEmision As String
    Private _fechaVenc As String
    Private _tasaInteres As Double
    Private _estadoCd As String
    Dim cFunDb As New cFuncionesDB
    Private _dias As Integer
    Private _coddj As String
    Private _fechadj As String
    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property




    Public Property Fechadj() As String
        Get
            Return _fechadj
        End Get
        Set(ByVal value As String)
            _fechadj = value
        End Set
    End Property

    Public Property CodDj() As String
        Get
            Return _coddj
        End Get
        Set(ByVal value As String)
            _coddj = value
        End Set
    End Property
    Public Property Dias() As Integer
        Get
            Return _dias
        End Get
        Set(ByVal value As Integer)
            _dias = value
        End Set
    End Property

    Public Property EstadoCD() As String
        Get
            Return _estadoCd
        End Get
        Set(ByVal value As String)
            _estadoCd = value
        End Set
    End Property

    Public Property TasaInteres() As Double
        Get
            Return _tasaInteres
        End Get
        Set(ByVal value As Double)
            _tasaInteres = value
        End Set
    End Property

    Public Property FechaVenc() As String
        Get
            Return _fechaVenc
        End Get
        Set(ByVal value As String)
            _fechaVenc = value
        End Set
    End Property

    Public Property FechaEmision() As String
        Get
            Return _fechaEmision
        End Get
        Set(ByVal value As String)
            _fechaEmision = value
        End Set
    End Property

    Public Property FechaAct() As String
        Get
            Return _fechaAct
        End Get
        Set(ByVal value As String)
            _fechaAct = value
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

    Public Property CodCli() As String
        Get
            Return _codCli
        End Get
        Set(ByVal value As String)
            _codCli = value
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




    Public Function AltaOrden() As Boolean
        Try
            Dim csql As String = "Insert into T_OrdenPago(CodOrden,CodCli,Monto,FechaAct,FechaEmision,FechaVenc,TasaInteres,EstadoCD,dias,coddj,fechadj,Usuario) values('" + CodOrden.ToString + "','" + CodCli.ToString + "','" + Monto.ToString + "','" + FechaAct.ToString + "','" + FechaEmision.ToString + "','" + FechaVenc.ToString + "','" + TasaInteres.ToString + "','" + EstadoCD.ToString + "','" + Dias.ToString + "','" + Me.CodDj.ToString + "','" + Me.Fechadj.ToString + "','" + Me.Usuario.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            'Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            'pregunta = MessageBox.Show("Desea dar de Alta esta orden de pago", "Insercion de Orden de pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If pregunta = DialogResult.Yes Then
            db.ConfirmarTransaccion()
            Return True
            'Else
            'db.CancelarTransaccion()
            'Return False
            'End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Alta Orden" + ex.ToString, "Orden Pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function EliminarOrden(ByVal CLIENTE As String) As Boolean
        Try
            Dim csql As String = "UPDATE T_ORDENPAGO SET ESTADOCD='E' WHERE CODCLI='" + CLIENTE + "' and estadocd='D'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Eliminar" + ex.ToString, "Orden Pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function CancelarOrden(ByVal CLIENTE As String, ByVal orden As String) As Boolean
        Try
            Dim csql As String = "UPDATE T_ORDENPAGO SET ESTADOCD='C' WHERE CODCLI='" + CLIENTE + "'and codorden='" + orden + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Cancelar Orden" + ex.ToString, "Orden Pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function GeneraOrden() As String
        Dim strsql As String
        strsql = "SELECT MAX(CONVERT(INT,codOrden)) AS CCOD FROM T_OrdenPago"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
    'para capturar monto minimo
    Function montominimo(ByRef pago As String) As String
        Dim strsql As String
        strsql = "select montomin from t_djautovaluo tdj inner join t_pagos tp on tp.coddj=tdj.coddj where tp.codpago='" + pago.ToString + "'"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
    Public Function Imprimeorden(ByRef orden As String, ByRef cliente As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select t_op.CodOrden,convert(char(10),FechaAct,103) as fechaact,convert(char(10),FechaEmision,103) as FechaEmision,TasaInteres,Dias,Annio,Baseimponible,Tramo,AliCuota,Insolutos,ImpuestoAnual,Trimestres,Insoluto,t_do.Reajuste,Interes,Total,ValorUit,tdd.Reajuste as reajusted,TIM,coddj,fechadj from dbo.T_OrdenPago t_op  inner join dbo.T_DetalleOrden t_do on t_do.codorden=t_op.codorden INNER JOIN	dbo.T_DatosDetalle tdd on tdd.codorden=t_op.codorden where t_op.codorden='" + orden.ToString + "' and codcli='" + cliente.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtOrdenPago")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    'imprime reporte de ordenes de pago D
    Public Function reporteOrdenes() As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select codorden,CONVERT(CHAR(10),fechavenc,103)AS FECHA,monto,descli,dnicli,ruccli from t_ordenpago t_op inner join t_cliente tc on tc.codcli=t_op.codcli where estadocd='D'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DT_ORDENESD")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    'imprime reporte de ordenes de pago c
    Public Function reporteOrdenesC() As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select distinct t_op.codorden,CONVERT(CHAR(10),fechavenc,103)AS FECHA,t_op.monto,descli,dnicli,ruccli,t_dr.codrecibo as campo1 from t_ordenpago t_op inner join t_cliente tc on tc.codcli=t_op.codcli inner join t_orden_pago t_o_p on t_o_p.codorden=t_op.codorden inner join t_pagos t_pa on t_pa.codpago=t_o_p.codpago inner join t_detallerecibo t_dr on t_dr.codpago=t_pa.codpago  where estadocd='c'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DT_ORDENESD")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
End Class
