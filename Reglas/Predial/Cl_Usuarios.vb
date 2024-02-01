Imports Datos
Imports System.Data
Imports System.Windows.Forms
Public Class Cl_Usuarios
    Private _codusuario As String
    Private _nombre As String
    Private _apellido As String
    Private _dni As String
    Private _usuario As String
    Private _clave As String
    Private _codnivel As String
    Dim cFunDb As New cFuncionesDB
    Public Property CodNivel() As String
        Get
            Return _codnivel
        End Get
        Set(ByVal value As String)
            _codnivel = value
        End Set
    End Property

    Public Property Clave() As String
        Get
            Return _clave
        End Get
        Set(ByVal value As String)
            _clave = value
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

    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    Public Property Apellidou() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Public Property Nombreu() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property CodUsuario() As String
        Get
            Return _codusuario
        End Get
        Set(ByVal value As String)
            _codusuario = value
        End Set
    End Property
    Public Function AltaUsuario() As Boolean
        Try
            Dim csql As String = "Insert into T_usuarios(CodUsuario,Apellidos,Nombres,Dni,Usuario,Clave,CodNivel) values('" + CodUsuario.ToString + "','" + Apellidou.ToString + "','" + Nombreu.ToString + "','" + Dni.ToString + "','" + Usuario.ToString + "','" + Clave.ToString + "','" + CodNivel.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este Usuario ", "Insercion de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error alta Usuarios" + ex.ToString, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function ActualizaUsuario(ByVal codigoUsu As String) As Boolean
        Try
            Dim csql As String = "Update T_usuarios set Apellidos = '" + Apellidou.ToString + "', Nombres = '" + Nombreu.ToString + "',Dni='" + Dni.ToString + "', Usuario = '" + Usuario.ToString + "', Clave = '" + Clave.ToString + "', CodNivel = '" + CodNivel.ToString + "' Where CodUsuario = '" + codigoUsu + "' "
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Cambiar los datos del Usuario ", "Editar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
            MessageBox.Show("Error Registro Usuarios" + ex.ToString, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Public Function EliminaUsuario(ByVal codigoUsu As String) As Boolean
        Try
            Dim csql As String = " Delete From T_usuarios Where CodUsuario = '" + codigoUsu + "'  "
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Eliminar los datos del Usuario ", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
            MessageBox.Show("Error Registro Usuarios" + ex.ToString, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Function GeneraCodUsuario() As String
        Dim strsql As String
        strsql = "SELECT max(RIGHT(codusuario,5)) AS CCOD FROM T_usuarios"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
End Class
