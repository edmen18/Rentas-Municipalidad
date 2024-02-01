Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Venta
    Dim cFunDb As New cFuncionesDB

    Private _codVenta As String
    Private _codCli As String
    Private _monto As Double
    Private _fecha As String
    Private _codForma As String
    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property


    Public Property CodForma() As String
        Get
            Return _codForma
        End Get
        Set(ByVal value As String)
            _codForma = value
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

    Public Property CodCli() As String
        Get
            Return _codCli
        End Get
        Set(ByVal value As String)
            _codCli = value
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

    Public Function AltaVenta() As Boolean
        Try
            Dim csql As String = "Insert into T_Venta(codventa,codcli,monto,fecha,codforma,Usuario) values('" + Me.CodVenta.ToString + "','" + Me.CodCli.ToString + "','" + Me.Monto.ToString + "','" + Me.Fecha.ToString + "','" + Me.CodForma.ToString + "','" + Me.Usuario.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta esta Venta ", "Insercion de Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("La transaccion se realizo de manera Satisfactoria", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()

        Catch ex As Exception
            MessageBox.Show("Error Alta Venta" + ex.ToString, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function GeneraCodventa() As Integer
        Dim strsql As String
        Dim cod As Integer = 0
        strsql = "SELECT max(CONVERT(INT,RIGHT(codventa,8))) AS CCOD FROM T_venta"
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearComando(strsql)

        Try
            cod = db.EjecutarEscalar()

        Catch ex As Exception

        End Try
        Return cod
    End Function


    Public Overloads Function ReporteVentaPORFECHAS(ByRef fi As Date, ByRef ff As Date) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select tv.codventa,tcli.descli,convert(char(10),fecha,103)as fecha,tv.monto,tfp.descripcion from t_venta tv inner join t_cliente tcli on tcli.codcli=tv.codcli inner join t_formapago tfp on tfp.codforma=tv.codforma where fecha>='" + CStr(fi.Date) + " ' and fecha<='" + CStr(ff.Date) + "'order by fecha"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtVENTAS")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Overloads Function ReporteVentaPORCliente(ByRef cliente As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select tv.codventa,tcli.descli,convert(char(10),fecha,103)as fecha,tv.monto,tfp.descripcion from t_venta tv inner join t_cliente tcli on tcli.codcli=tv.codcli inner join t_formapago tfp on tfp.codforma=tv.codforma where tcli.codcli= '" + cliente.ToString() + "' order by tv.fecha"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtVENTAS")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Overloads Function ReporteVentaPORservicio(ByRef servicio As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select tv.codventa,tcli.descli,convert(char(10),fecha,103)as fecha,dv.subtotal,tfp.descripcion from t_venta tv inner join t_cliente tcli on tcli.codcli=tv.codcli inner join t_detalleventa dv on dv.codventa=tv.codventa inner join t_clase tc on tc.numcla=dv.numcla inner join t_formapago tfp on tfp.codforma=tv.codforma where tc.numcla='" + servicio.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtVENTAS")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Overloads Function ReporteVentaPORPAPELETA(ByRef PAPELETA As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select tv.codventa,tcli.descli,convert(char(10),fecha,103)as fecha,dv.subtotal,tfp.descripcion from t_venta tv inner join t_cliente tcli on tcli.codcli=tv.codcli inner join t_detalleventa dv on dv.codventa=tv.codventa inner join t_clase tc on tc.numcla=dv.numcla inner join t_formapago tfp on tfp.codforma=tv.codforma where tv.codventa='" + PAPELETA.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtVENTAS")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

    Public Function Reportediariocaja(ByRef fecha As Date) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select tv.codventa,monto,tcli.descli from t_venta tv inner join t_cliente tcli on tcli.codcli=tv.codcli inner join t_formapago tfp on tfp.codforma=tv.codforma where fecha ='" + CStr(fecha.Date) + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtVENTAS")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
    Public Function ReportediariIngreso(ByRef fecha As Date) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select tc.numcla,descla,round(sum(PrecioVenta*Cantidad),2) as total from t_clase tc inner join t_detalleVenta tdv on tdv.numcla=tc.numcla inner join t_venta tv on tv.codventa=tdv.codventa where tv.fecha='" + CStr(fecha.Date) + "' group by DesCla,tc.NumCla"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DT_REPINGRESODIARIO")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function


    Public Function ImprimeRecibo(ByRef NumVenta As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select v.CodVenta,c.descla,dv.precioventa,dv.cantidad,v.monto,cl.DesCli,CONVERT(CHAR(10),v.fecha,103)AS FECHA,subtotal from t_detalleventa dv inner join t_venta v on v.codventa=dv.codventa inner join t_clase c on c.numcla=dv.numcla inner join t_cliente cl on cl.codcli=v.codcli where v.codventa ='" + NumVenta + "' "
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DtRecibo")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

End Class
