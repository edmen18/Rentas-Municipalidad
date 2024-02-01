Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_DeclaracionJurada
    Dim cFunDb As New cFuncionesDB
    Private _codDJ As String
    Private _annio As String
    Private _codArancel As String
    Private _valorConstruccon As Double
    Private _valorArancel As Double
    Private _baseImponible As Double
    Private _areaTotal As Double
    Private _montoArancel As Double
    Private _fechaemision As String
    Private _motivo As String
    Private _impuestoanual As Double
    Private _indicador As String
    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Public Property Indicador() As String
        Get
            Return _indicador
        End Get
        Set(ByVal value As String)
            _indicador = value
        End Set
    End Property

    Public Property ImpuestoAnual() As Double
        Get
            Return _impuestoanual
        End Get
        Set(ByVal value As Double)
            _impuestoanual = value
        End Set
    End Property

    Public Property Motivo() As String
        Get
            Return _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
        End Set
    End Property

    Public Property FechaEmision() As String
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As String)
            _fechaemision = value
        End Set
    End Property

    Public Property MontoArancel() As Double
        Get
            Return _montoArancel
        End Get
        Set(ByVal value As Double)
            _montoArancel = value
        End Set
    End Property

    Public Property AreaTotal() As Double
        Get
            Return _areaTotal
        End Get
        Set(ByVal value As Double)
            _areaTotal = value
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

    Public Property ValorArancel() As Double
        Get
            Return _valorArancel
        End Get
        Set(ByVal value As Double)
            _valorArancel = value
        End Set
    End Property


    Public Property ValorConstruccon() As Double
        Get
            Return _valorConstruccon
        End Get
        Set(ByVal value As Double)
            _valorConstruccon = value
        End Set
    End Property

    Public Property CodArancel() As String
        Get
            Return _codArancel
        End Get
        Set(ByVal value As String)
            _codArancel = value
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

    Public Property CodDJ() As String
        Get
            Return _codDJ
        End Get
        Set(ByVal value As String)
            _codDJ = value
        End Set
    End Property
    Public Function AltaDJ() As Boolean
        Try
            Dim csql As String = "Insert into T_DJAutovaluo(CodDj,annio,codarancel,valorconstruccion,valorarancel,baseImponible,areaTotal,montoarancel,fechaemision,codmotivo,Impuestoanual,indicador,Usuario) values('" + CodDJ.ToString + "','" + Annio.ToString + "','" + CodArancel.ToString + "','" + ValorConstruccon.ToString + "','" + ValorArancel.ToString + "','" + BaseImponible.ToString + "','" + AreaTotal.ToString + "','" + MontoArancel.ToString + "','" + Me.FechaEmision.ToString + "','" + Me.Motivo.ToString + "','" + ImpuestoAnual.ToString + "','" + Indicador.ToString + "','" + Usuario.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta esta Declaracion ", "Insercion de Declaracion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("La declaracion jurada se registro de manera satisfactoria", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Alta Declaracion" + ex.ToString, "declaracion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function GeneraCoddj() As String
        Dim strsql As String
        strsql = "SELECT max(CONVERT(INT,coddj)) AS CCOD FROM T_djautovaluo"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function

    Function PorcentajeDepreciacion(ByVal tipoedificacion As String, ByRef material As String, ByRef estado As String, ByRef valor As Integer) As String
        Dim strsql As String
        strsql = "SELECT Valor FROM T_DEPRECIACION TD INNER JOIN T_TIPOEDIFICACION TTE ON TTE.CODTIPOEDIFICACION=TD.CODTIPOEDIFICACION WHERE TTE.CODTIPOEDIFICACION='" + tipoedificacion + "' AND DESDE<='" + CStr(valor) + "' AND HASTA>='" + CStr(valor) + "' and codmaterial='" + material + "' and codestado='" + estado + "'"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
    Function Mostrar_Arancel(ByVal codigoTE As String) As String
        Dim strsql As String
        strsql = "select ta.Monto from dbo.T_Arancel ta inner join dbo.T_TipoEdificacion tte on tte.CodArancel=ta.CodArancel where CodTipoEdificacion='" + codigoTE + "'"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
    Function Mostrar_codgoarancel(ByVal codigoTE As String) As String
        Dim strsql As String
        strsql = "select ta.codarancel from dbo.T_Arancel ta inner join dbo.T_TipoEdificacion tte on tte.CodArancel=ta.CodArancel where CodTipoEdificacion='" + codigoTE + "'"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function

    Public Overloads Function ImprimePU(ByRef CODCLI As String, ByRef CODDJ As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select TC.CodCli,DniCli+' '+RucCli AS DNIRUC,DesCli,convert(varchar(100),TC.Dircli+''+TC.Numero+''+TC.Manzana+''+TC.Lote )as direccion,BaseImponible,TP.CodPredio,CONVERT(INT,YEAR(GETDATE())-YEAR(TP.FECHACONSTRUCCION)) AS ANTIGUEDAD,TP.CODMATERIAL,CATEGORIAS,VUNIT,DEPR AS DPR,CONVERT(NUMERIC(9,2),MONTOD)AS MONTOD,CONVERT(NUMERIC(9,2),VUD)AS VUD,CONVERT(NUMERIC(9,2),AREA) AS AREACONSTRUIDA,CONVERT(NUMERIC(9,2),TDDJ.VALORCONSTRUCCION)AS VALORCONSTRUCCION,CONVERT (NUMERIC(9,2),TDJ.ValorConstruccion) AS VALORTOTALCONSTRUCCION,CONVERT (NUMERIC(9,2),MontoArancel)AS MONTOARANCEL,CONVERT (NUMERIC(9,2),ValorArancel) AS VALORARANCEL,CONVERT (NUMERIC(9,2),tp.AreaTotal) AS AREATOTAL,annio from t_cliente tc INNER JOIN T_PREDIO TP ON TP.CodCli=TC.CodCli INNER JOIN dbo.T_DetalleDJ TDDJ ON TDDJ.CodPredio=TP.CodPredio INNER JOIN dbo.T_DJAutovaluo TDJ ON TDJ.CodDj=TDDJ.CodDj WHERE TC.CODCLI='" + CODCLI.ToString + "' AND TDJ.CODDJ='" + CODDJ.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "Dt_PU")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

    Public Overloads Function ImprimeHR(ByRef CODCLI As String, ByRef CODDJ As String) As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select TC.CodCli,DniCli+' '+RucCli AS DNIRUC,DesCli,convert(varchar(100),TC.Dircli+''+TC.Numero+''+TC.Manzana+''+TC.Lote )as direccion,TC.MANZANA,TC.LOTE,BaseImponible,TP.CodPredio,TP.Direccion+''+TP.Numero+''+TP.Manzana+''+TP.Lote AS DIRECCION1,FECHAEMISION,ANNIO from t_cliente tc INNER JOIN T_PREDIO TP ON TP.CodCli=TC.CodCli INNER JOIN dbo.T_DetalleDJ TDDJ ON TDDJ.CodPredio=TP.CodPredio INNER JOIN dbo.T_DJAutovaluo TDJ ON TDJ.CodDj=TDDJ.CodDj WHERE TC.CODCLI='" + CODCLI.ToString + "' AND TDJ.CODDJ='" + CODDJ.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "Dt_HR")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function
End Class
