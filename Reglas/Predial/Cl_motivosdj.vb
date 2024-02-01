Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_motivosdj
    Private _codmotivo As String
    Private _descripcion As String
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

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property CodMotivo() As String
        Get
            Return _codmotivo
        End Get
        Set(ByVal value As String)
            _codmotivo = value
        End Set
    End Property

    Public Function AltaMotivo() As Boolean
        Try
            Dim csql As String = "Insert into T_motivodj(codmotivo,descripcion,estado) values('" + CodMotivo.ToString + "','" + Descripcion.ToString + "','" + Estado.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este Motivo DJ. ", "Insercion de Motivo DJ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Datos registrados correctamente", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()

        Catch ex As Exception
            MessageBox.Show("Erro alta de Motivo DJ." + ex.ToString, "Motivo Dj.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function EliminarMotivo(ByRef cmotivo As String) As Boolean
        Try
            Dim csql As String = "update t_motivodj set estado='0' where codmotivo='" + cmotivo + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Eliminar este Motivo ", "Eliminacion de Motivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Eliminacion de Motivo" + ex.ToString, "Motivo DJ.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateMotivo(ByRef cmotivo As String, ByRef descrip As String) As Boolean
        Try
            Dim csql As String = "update t_motivodj set Descripcion ='" + descrip.ToString + "' where codmotivo='" + cmotivo + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Actualizar este Motivo ", "Actualización de Motivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Actualización de Motivo" + ex.ToString, "Motivo DJ.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function GeneraCodMotivo() As String
        Dim strsql As String
        strsql = "SELECT max(RIGHT(codmotivo,2)) AS CCOD FROM T_motivodj"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
End Class
