Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_CondicionPropiedad
    Dim cFunDb As New cFuncionesDB
    Private _codcondpro As String
    Private _condicion As String
    Private _estado As String
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    Public Property Condicion() As String
        Get
            Return _condicion
        End Get
        Set(ByVal value As String)
            _condicion = value
        End Set
    End Property

    Public Property Codcondpro() As String
        Get
            Return _codcondpro
        End Get
        Set(ByVal value As String)
            _codcondpro = value
        End Set
    End Property
    Public Function AltaCondicion() As Boolean
        Try
            Dim csql As String = "Insert into T_condicionpropiedad(codcondpro,condicion,estado) values('" + Codcondpro.ToString + "','" + condicion.ToString + "','" + Estado.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta esta Condicion. ", "Insercion de condicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erro alta Condicion." + ex.ToString, "Condicion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function EliminarCondicion(ByRef ccondicion As String) As Boolean
        Try
            Dim csql As String = "update t_condicionpropiedad set estado='0' where codcondpro='" + ccondicion + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Eliminar esta Condición ", "Eliminacion de Condición", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Eliminacion de Condicion" + ex.ToString, "Condición", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateCondicion(ByRef ccondicion As String, ByRef descrip As String) As Boolean
        Try
            Dim csql As String = "update t_condicionpropiedad set condicion ='" + descrip.ToString + "' where codcondpro='" + ccondicion + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Actualizar esta Condición ", "Actualización de Condición", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Actualización de Condicion" + ex.ToString, "Condicion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function GeneraCodCondicion() As String
        Dim strsql As String
        strsql = "SELECT max(RIGHT(codcondpro,2)) AS CCOD FROM T_condicionpropiedad"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
End Class
