Imports System.Windows.Forms
Imports Datos


Public Class Cl_EstadoConservacion

    Private _codEstado As String
    Private _desEstado As String

    Public Property Descripcion() As String
        Get
            Return _desEstado
        End Get
        Set(ByVal value As String)
            _desEstado = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return _codEstado
        End Get
        Set(ByVal value As String)
            _codEstado = value
        End Set
    End Property

    Public Function AltaEstadoCoservacion() As Boolean
        Try
            Dim csql As String = "Insert into T_EstadoConservacion values('" + Me.Codigo.ToString + "','" + Me.Descripcion.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta el estado : " + Me.Descripcion.ToString, "Insercion de Nuevo Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()

        Catch ex As Exception
            MessageBox.Show("Error al registrar Estado" + ex.ToString, "Estado de Coserv.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ModificarEstadoConservacion(ByVal CodEstado As String) As Boolean
        Try
            Dim csql As String = "update T_EstadoConservacion set Estado='" + Me.Descripcion.ToString + "' where CodEstado='" + CodEstado.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea modificar el estado: " + Me.Descripcion.ToString, "Actualización de Estado de Conserv.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al Modificar Estado" + ex.ToString, "Estado de Coserv.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Public Function EliminaEstadoConservacion(ByVal codEstado As String) As Boolean
        Try
            Dim csql As String = "DELETE FROM T_EstadoConservacion WHERE CodEstado ='" + codEstado + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Si Elimina el estado de conservacion, ya no podra recuperarlo de la Base de datos ", "Eliminar Tipo Edificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Estado de conservacion eliminado con exito", "Estado de Conservacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al Eliminar Estado" + ex.ToString, "Estado de Coserv.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function GeneraCodEstado() As String
        Dim strsql As String
        strsql = "SELECT MAX(RIGHT(CODESTADO,2)) AS CCOD FROM T_EstadoConservacion"
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearComando(strsql)
        Dim cod As String = CStr(db.EjecutarEscalar())
        Return cod
    End Function


End Class
