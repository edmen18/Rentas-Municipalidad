Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Pagos
    Private _codtrimestre As String
    Private _codPago As String
    Private _codDj As String
    Private _monto As Double
    Private _estado As String
    Dim cFunDb As New cFuncionesDB
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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

    Public Property CodDj() As String
        Get
            Return _codDj
        End Get
        Set(ByVal value As String)
            _codDj = value
        End Set
    End Property

    Public Property CodPago() As String
        Get
            Return _codPago
        End Get
        Set(ByVal value As String)
            _codPago = value
        End Set
    End Property

    Public Property CodTrimestre() As String
        Get
            Return _codtrimestre
        End Get
        Set(ByVal value As String)
            _codtrimestre = value
        End Set
    End Property
    Public Function AltaPago() As Boolean
        Try
            Dim csql As String = "Insert into T_Pagos(CodPago,CodTrimestre,CodDj,Monto,Estado) values('" + Me.CodPago.ToString + "','" + Me.CodTrimestre.ToString + "','" + Me.CodDj.ToString + "','" + Me.Monto.ToString + "','" + Me.Estado.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            'Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            'pregunta = MessageBox.Show("Desea dar de Alta este Predio ", "Insercion de Predio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If pregunta = DialogResult.Yes Then
            db.ConfirmarTransaccion()
            'Else
            '    db.CancelarTransaccion()
            'End If
            'db.Desconectar()
            'Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Pago" + ex.ToString, "Pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function GeneraCodPago() As String
        Dim strsql As String
        strsql = "SELECT max(CONVERT(INT,codPago)) AS CCOD FROM T_pagos"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
    Public Function updatedetalle(ByRef pago As String) As Boolean
        Try
            Dim csql As String = "update t_pagos set estado='C' where codpago='" + pago.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            'Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            'pregunta = MessageBox.Show("Desea dar de Alta este Predio ", "Insercion de Predio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If pregunta = DialogResult.Yes Then
            db.ConfirmarTransaccion()
            'Else
            '    db.CancelarTransaccion()
            'End If
            'db.Desconectar()
            'Return True
        Catch ex As Exception
            MessageBox.Show("Error update estado pago" + ex.ToString, "update pago estado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    'trimestres vencidos
    Public Overloads Function Imprimetrimestresv() As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select distinct tc.codcli,DesCli,DniCli,RucCli,tt.numero,monto,fechvenc from dbo.T_Cliente tc inner join dbo.T_Predio tp on tp.codcli=tc.codcli inner join dbo.T_DetalleDJ tddj on tddj.codpredio=tp.codpredio inner join dbo.T_DJAutovaluo tdj on tdj.coddj=tddj.coddj inner join dbo.T_Pagos tpa on tpa.coddj=tdj.coddj inner join dbo.T_Trimestres tt on tt.codtrimestre=tpa.codtrimestre where tpa.estado='D' and fechvenc < GETDATE()"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "Dt_trimestres")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
End Class
