Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Predio
    Dim cFunDb As New cFuncionesDB
    Private _codPredio As String
    Private _direccion As String
    Private _manzana As String
    Private _numero As Integer
    Private _lote As String
    Private _fechaConstruccion As String
    Private _codTipoEdificacion As String
    Private _numeropisos As Integer
    Private _codCli As String
    Private _area As Double
    Private _fechaAdq As String
    Private _situacion As String
    Private _codMaterial As String
    Private _estado As String
    Private _codzona As String
    Private _codconpro As String
    Private _estadoPredio As String
    Private _areatotal As Double
    Public Property AreaTotal() As Double
        Get
            Return _areatotal
        End Get
        Set(ByVal value As Double)
            _areatotal = value
        End Set
    End Property

    Public Property EstadoPredio() As String
        Get
            Return _estadoPredio
        End Get
        Set(ByVal value As String)
            _estadoPredio = value
        End Set
    End Property

    Public Property CondicionPropiedad() As String
        Get
            Return _codconpro
        End Get
        Set(ByVal value As String)
            _codconpro = value
        End Set
    End Property

    Public Property Zona() As String
        Get
            Return _codzona
        End Get
        Set(ByVal value As String)
            _codzona = value
        End Set
    End Property

    Public Property Conservacion() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    Public Property Material() As String
        Get
            Return _codMaterial
        End Get
        Set(ByVal value As String)
            _codMaterial = value
        End Set
    End Property

    Public Property Situacion() As String
        Get
            Return _situacion
        End Get
        Set(ByVal value As String)
            _situacion = value
        End Set
    End Property

    Public Property FechaAdq() As String
        Get
            Return _fechaAdq
        End Get
        Set(ByVal value As String)
            _fechaAdq = value
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

    Public Property CodCli() As String
        Get
            Return _codCli
        End Get
        Set(ByVal value As String)
            _codCli = value
        End Set
    End Property

    Public Property NumeroPisos() As Integer
        Get
            Return _numeropisos
        End Get
        Set(ByVal value As Integer)
            _numeropisos = value
        End Set
    End Property

    Public Property CodTipoEdificacion() As String
        Get
            Return _codTipoEdificacion
        End Get
        Set(ByVal value As String)
            _codTipoEdificacion = value
        End Set
    End Property

    Public Property FechaConstruccion() As String
        Get
            Return _fechaConstruccion
        End Get
        Set(ByVal value As String)
            _fechaConstruccion = value
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

    Public Property Numero() As Integer
        Get
            Return _numero
        End Get
        Set(ByVal value As Integer)
            _numero = value
        End Set
    End Property

    Public Property Manzana() As String
        Get
            Return _manzana
        End Get
        Set(ByVal value As String)
            _manzana = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
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

    Public Function AltaPredio() As Boolean
        Try
            Dim csql As String = "Insert into T_predio(CodPredio,direccion,Manzana,Numero,lote,FechaConstruccion,CodTipoEdificacion,NumeroPisos,CodCli,Area,FechaAdquisicion,situacion,CodMaterial,CodEstado,CodZona,CodCondPro,EstadoPredio,areatotal) values('" + Me.CodPredio.ToString + "','" + Me.Direccion.ToString + "','" + Me.Manzana.ToString + "','" + Me.Numero.ToString + "','" + Me.Lote.ToString + "','" + Me.FechaConstruccion.ToString + "','" + Me.CodTipoEdificacion.ToString + "','" + Me.NumeroPisos.ToString + "','" + Me.CodCli.ToString + "','" + Me.Area.ToString + "','" + Me.FechaAdq.ToString + "','" + Me.Situacion.ToString + "','" + Me.Material.ToString + "','" + Me.Conservacion.ToString + "','" + Me.Zona.ToString + "','" + Me.CondicionPropiedad.ToString + "','" + Me.EstadoPredio.ToString + "','" + AreaTotal.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este Predio ", "Insercion de Predio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("El predio se registro de manera satisfactoria", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Predio" + ex.ToString, "Predio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function EliminarPredio(ByVal predio As String) As Boolean
        Try
            Dim csql As String = "delete t_predio where codpredio='" + predio + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Eliminar este Predio ", "Eliminación de Predio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("El predio se eliminó de manera satisfactoria", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Eliminar Predio" + " " + "No es posible eliminar el predio debido a que ya fue evaluado y/o declarado", "Predio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function GeneraCodpredio() As Integer
        Dim strsql As String
        Dim cod As Integer = 0
        strsql = "SELECT max(RIGHT(codPredio,10)) AS CCOD FROM T_predio"
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

    Public Function ModificarPredio(ByVal predio As String) As Boolean
        Try
            Dim csql As String = "Update T_predio set direccion='" + Me.Direccion.ToString + "',Manzana='" + Me.Manzana.ToString + "',Numero='" + Me.Numero.ToString + "',lote='" + Me.Lote.ToString + "',FechaConstruccion='" + Me.FechaConstruccion.ToString + "',CodTipoEdificacion='" + Me.CodTipoEdificacion.ToString + "',NumeroPisos='" + Me.NumeroPisos.ToString + "',CodCli='" + Me.CodCli.ToString + "',Area='" + Me.Area.ToString + "',FechaAdquisicion='" + Me.FechaAdq.ToString + "',situacion='" + Me.Situacion.ToString + "',CodMaterial='" + Me.Material.ToString + "',CodEstado='" + Me.Conservacion.ToString + "',CodZona='" + Me.Zona.ToString + "',CodCondPro='" + Me.CondicionPropiedad.ToString + "',EstadoPredio='" + Me.EstadoPredio.ToString + "',areatotal='" + AreaTotal.ToString + "' where codpredio='" + predio + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Modificar este Predio", "Modificación de Predio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("El predio se Modificó de manera satisfactoria", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Modificar Predio" + ex.ToString, "Predio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
