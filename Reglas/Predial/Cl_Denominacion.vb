Imports Reglas
Imports Datos
Imports System.Windows.Forms

Public Class Cl_Denominacion
    Private _codContenido As String
    Private _codIngresado As String
    Private _Descripcion As String
    Private _codDenominacion As String
    Private _valor As Double

    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property

    Public Property CodDenominacion() As String
        Get
            Return _codDenominacion
        End Get
        Set(ByVal value As String)
            _codDenominacion = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property CodIngresado() As String
        Get
            Return _codIngresado
        End Get
        Set(ByVal value As String)
            _codIngresado = value
        End Set
    End Property

    Public Property CodContenido() As String
        Get
            Return _codContenido
        End Get
        Set(ByVal value As String)
            _codContenido = value
        End Set
    End Property

    Public Function AltaContenidos() As Boolean
        Try
            Dim csql As String = "Insert into T_Contenidos(CodContenido,CodIngresado,Descripcion,CodDenominacion,Valor) values('" + CodContenido.ToString + "','" + CodIngresado.ToString + "','" + Descripcion.ToString + "','" + CodDenominacion.ToString + "','" + Valor.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea registrar este contenido. ", "SRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Datos procesados con exito", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error al realizar la Operacion" + ex.ToString, "SRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ModificarContenidos(ByVal codDenom As String) As Boolean
        Try
            Dim csql As String = "update T_Contenidos set CodIngresado='" + Me.CodIngresado.ToString + "',Descripcion='" + Me.Descripcion.ToString + "', CodDenominacion='" + Me.CodDenominacion.ToString + "', Valor='" + Me.Valor.ToString + "' where CodContenido='" + codDenom.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Modificar este registro ", "SRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Datos procesados con exito", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Modificando Datos" + ex.ToString, "SRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function EliminarContenidos(ByVal codDenom As String) As Boolean
        Try
            Dim csql As String = "DELETE FROM T_CONTENIDOS where CodContenido='" + codDenom.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Eliminar este registro ", "SRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Datos procesados con exito", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Modificando Datos" + ex.ToString, "SRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Function GeneraCodDenominacion() As Integer
        Dim strsql As String
        Dim cod As Integer = 0
        strsql = "SELECT MAX(CONVERT(INT,(CodContenido))) AS CCOD FROM T_Contenidos"
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

End Class
