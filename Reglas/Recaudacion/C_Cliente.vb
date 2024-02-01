Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class C_Cliente
    Dim cFunDb As New cFuncionesDB

    Private _codCli As String
    Private _codTipPer As String
    Private _nomCli As String
    Private _dirCli As String
    Private _dniCli As String
    Private _rucCli As String
    Private _repLeg As String
    Private _telCli As String
    Private _email As String
    Private _numero As String
    Private _lote As String
    Private _manzana As String
    Public Property Manzana() As String
        Get
            Return _manzana
        End Get
        Set(ByVal value As String)
            _manzana = value
        End Set
    End Property

    Public Property Lote() As String
        Get
            Return _lote
        End Get
        Set(ByVal value As String)
            _lote = value
        End Set
    End Property

    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
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
    Public Property CodTipoPer() As String
        Get
            Return _codTipPer
        End Get
        Set(ByVal value As String)
            _codTipPer = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property
    Public Property TelCli() As String
        Get
            Return _telCli
        End Get
        Set(ByVal value As String)
            _telCli = value
        End Set
    End Property
    Public Property RepLeg() As String
        Get
            Return _repLeg
        End Get
        Set(ByVal value As String)
            _repLeg = value
        End Set
    End Property
    Public Property RucCli() As String
        Get
            Return _rucCli
        End Get
        Set(ByVal value As String)
            _rucCli = value
        End Set
    End Property
    Public Property DniCli() As String
        Get
            Return _dniCli
        End Get
        Set(ByVal value As String)
            _dniCli = value
        End Set
    End Property
    Public Property DirCli() As String
        Get
            Return _dirCli
        End Get
        Set(ByVal value As String)
            _dirCli = value
        End Set
    End Property
    Public Property NomCli() As String
        Get
            Return _nomCli
        End Get
        Set(ByVal value As String)
            _nomCli = value
        End Set
    End Property


    Public Function AltaCliente() As Boolean
        Try
            Dim csql As String = "Insert into T_Cliente(CodCli,CodTipPer,DesCli,DirCli,DniCli,RucCli,RepLeg,TelCli,email,numero,lote,manzana) values('" + Me.CodCli.ToString + "','" + Me.CodTipoPer.ToString + "','" + Me.NomCli.ToString + "', '" + Me.DirCli.ToString + "', '" + Me.DniCli.ToString + "','" + Me.RucCli.ToString + "', '" + Me.RepLeg.ToString + "','" + Me.TelCli.ToString + "','" + Me.Email.ToString + "','" + Me.Numero.ToString + "','" + Me.Lote.ToString + "','" + Me.Manzana.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este Cliente ", "Insercion de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Los datos se almacenaron satisfactoriamente", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Cliente" + ex.ToString, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ModificarCliente(ByVal CodigoCliente As String) As Boolean
        Try
            Dim csql As String = "update T_Cliente set DesCli='" + Me.NomCli.ToString + "',CodTipPer='" + Me.CodTipoPer.ToString + "',DirCli='" + Me.DirCli.ToString + "',DniCli='" + Me.DniCli.ToString + "',RucCli='" + Me.RucCli.ToString + "',RepLeg='" + Me.RepLeg.ToString + "',TelCli='" + Me.TelCli.ToString + "',email ='" + Me.Email.ToString + "',numero='" + Me.Numero.ToString + "',lote='" + Me.Lote.ToString + "',manzana='" + Me.Manzana.ToString + "' where CodCli='" + CodigoCliente + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea actualizar los datos del cliente ", "Actualizar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Los datos se almacenaron satisfactoriamente", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Modificar Cliente" + ex.ToString, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function EliminarCliente(ByVal CodigoCliente As String) As Boolean
        Try
            Dim csql As String = "Delete From T_Cliente where CodCli='" + CodigoCliente + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()

            pregunta = MessageBox.Show("Desea Eliminar los datos del cliente ", "Actualizar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("La transaccion se realizo satisfactoriamente", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("No es posible eliminar este contribuyente debido a que tiene predios y declaraciones juradas asignadas", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Function GeneraCodCliente() As String
        Dim strsql As String
        strsql = "SELECT MAX(CONVERT(INT,CodCli)) AS CCOD FROM T_Cliente"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function

    Public Function ReporteCliente() As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select CodCli,DesCli,DniCli,RucCli,TelCli,DirCli FROM T_Cliente order by DesCli asc"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DTCLIENTE")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

End Class
