Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Zona
    Dim cFunDb As New cFuncionesDB
    Private _CodZona As String
    Private _nombre As String
    Private _estado As String
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property CodZona() As String
        Get
            Return _CodZona
        End Get
        Set(ByVal value As String)
            _CodZona = value
        End Set
    End Property
    Public Function AltaZona() As Boolean
        Try
            Dim csql As String = "Insert into T_Zona(codzona,nombre,estado) values('" + CodZona.ToString + "','" + Nombre.ToString + "','" + Estado.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta esta Zona ", "Insercion de Zona", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error alta Zona" + ex.ToString, "Zona", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function EliminarZona(ByVal czona As String) As Boolean
        Try
            Dim csql As String = "update t_zona set estado='0' where codzona='" + czona + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Eliminar esta Zona ", "Eliminacion de Zona", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Eliminacion de Zona" + ex.ToString, "Zona", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateZona(ByVal czona As String, ByVal descrip As String) As Boolean
        Try
            Dim csql As String = "update t_zona set Nombre='" + descrip.ToString + "' where codzona='" + czona + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Actualizar esta Zona ", "Actualización de Zona", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Actualización de Zona" + ex.ToString, "Zona", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function GeneraCodZona() As String
        Dim strsql As String
        strsql = "SELECT max(RIGHT(codzona,2)) AS CCOD FROM T_zona"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
End Class
