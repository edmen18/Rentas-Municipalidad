Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Cuentas
    Private _codCta As String
    Private _descripcion As String
    Private _bco As String
    Public Property Banco() As String
        Get
            Return _bco
        End Get
        Set(ByVal value As String)
            _bco = value
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

    Public Property CodCta() As String
        Get
            Return _codCta
        End Get
        Set(ByVal value As String)
            _codCta = value
        End Set
    End Property
    Public Function AltaCuenta() As Boolean
        Try
            Dim csql As String = "Insert into T_cuenta(codcta,descripcion,Entidad) values('" + Me.CodCta.ToString + "','" + Me.Descripcion.ToString + "','" + Me.Banco.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta esta Cuenta ", "Insercion de Cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()

        Catch ex As Exception
            MessageBox.Show("Error Alta Cuenta" + ex.ToString, "Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function Modificarcuenta(ByVal cuenta As String) As Boolean
        Try
            Dim csql As String = "update t_cuenta set descripcion='" + Me.Descripcion.ToString + "',Entidad='" + Me.Banco.ToString + "' where codcta='" + cuenta.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Modificar esta Cuenta", "Actualización de cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Modificar Cuenta" + ex.ToString, "Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function EliminaCuenta(ByVal codigoCta As String) As Boolean
        Try
            Dim csql As String = "DELETE FROM T_Cuenta WHERE codcta ='" + codigoCta + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Si Elimina la Cuenta, ya no podra recuperarla de la Base de datos ", "Eliminar Cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
                MessageBox.Show("Cuenta eliminada con exito", "Eliminar Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()

        Catch ex As Exception
            MessageBox.Show("Error Eliminando Cuenta" + ex.ToString, "Eliminar Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


End Class
