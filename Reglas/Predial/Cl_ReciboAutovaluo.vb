Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_ReciboAutovaluo
    Private _codRecibo As String
    Private _fecha As String
    Private _total As Double
    Dim cFundb As New cFuncionesDB
    Private _codcta As String
    Private _observacion As String
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
        End Set
    End Property

    Public Property CodCta() As String
        Get
            Return _codcta
        End Get
        Set(ByVal value As String)
            _codcta = value
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

    Public Property Fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

    Public Property CodRecibo() As String
        Get
            Return _codRecibo
        End Get
        Set(ByVal value As String)
            _codRecibo = value
        End Set
    End Property

    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property


    Public Function AltaRecibo() As Boolean
        Try
            Dim csql As String = "Insert into T_ReciboAutovaluo(CodRecibo,fecha,total,codcta,observacion,Usuario) values('" + Me.CodRecibo.ToString + "','" + Me.Fecha.ToString + "','" + Me.Total.ToString + "','" + CodCta.ToString + "','" + Me.Observacion.ToString + "','" + Me.Usuario.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este Recibo ", "Insercion de Recibo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("La transaccion se realizo de manera satisfactoriamente", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Alta Recibo" + ex.ToString, "Recibo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function GeneraRecibo() As String
        Dim strsql As String
        strsql = "SELECT MAX(CONVERT(INT,codRecibo)) AS CCOD FROM T_reciboautovaluo"
        Dim dato As String = cFundb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
    'imprimir recibo
    Public Overloads Function ImprimeRecibo(ByRef dato As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select distinct rc.codrecibo,convert(char(10),fecha,103)as fecha,tr.numero as trimestre,direccion,tpr.manzana,tpr.lote,tpr.numero,rc.total,condicion,descli,DirCli,tcl.Manzana as Manzana1,tcl.lote as Lote1,tcl.Numero as numero1 from dbo.T_ReciboAutovaluo rc inner join dbo.T_DetalleRecibo dr on dr.codrecibo=rc.codrecibo inner join dbo.T_Pagos tp on tp.codpago=dr.codpago inner join dbo.T_Trimestres tr on tr.codtrimestre=tp.codtrimestre inner join dbo.T_DJAutovaluo dja on dja.coddj=tp.coddj inner join dbo.T_DetalleDJ tddj on tddj.coddj=dja.coddj inner join dbo.T_Predio tpr on tpr.codpredio=tddj.codpredio inner join dbo.T_CondicionPropiedad tcp on tcp.CodCondPro=tpr.CodCondPro inner join t_cliente tcl on tcl.codcli=tpr.codcli where tp.estado='c' and rc.codrecibo='" + dato + "'order by tpr.direccion "
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtReciboautovaluo")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    ' informe de recibos emitidos
    Public Overloads Function RecibosEmitidos(ByRef fechaini As Date, ByRef fechafin As Date) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select distinct ra.codrecibo,convert(char(10),fecha,103) as fecha,total,pa.codpago,tr.numero,descli,dnicli,ruccli from dbo.T_ReciboAutovaluo ra inner join dbo.T_DetalleRecibo dr on dr.codrecibo=ra.codrecibo inner join t_pagos pa on pa.codpago=dr.codpago inner join t_trimestres tr on tr.codtrimestre=pa.codtrimestre inner join dbo.T_DJAutovaluo dj on dj.coddj=pa.coddj inner join  dbo.T_DetalleDJ ddj on ddj.coddj=dj.coddj inner join dbo.T_Predio pr on pr.codpredio=ddj.codpredio inner join dbo.T_Cliente c on c.codcli=pr.codcli where fecha>='" + CStr(fechaini.Date) + "' and  fecha<='" + CStr(fechafin.Date) + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtRecibosEmitidos")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
End Class
