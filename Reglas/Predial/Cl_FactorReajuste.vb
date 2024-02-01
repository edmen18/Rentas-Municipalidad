Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_FactorReajuste
    Private _cosInteres As String
    Private _base As String
    Private _mensual As Double
    Private _acumulado As Double
    Private _fecha As String
    Dim cFunDb As New cFuncionesDB
    Public Property Fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

    Public Property Acumulado() As Double
        Get
            Return _acumulado
        End Get
        Set(ByVal value As Double)
            _acumulado = value
        End Set
    End Property

    Public Property Mensual() As Double
        Get
            Return _mensual
        End Get
        Set(ByVal value As Double)
            _mensual = value
        End Set
    End Property

    Public Property Base() As String
        Get
            Return _base
        End Get
        Set(ByVal value As String)
            _base = value
        End Set
    End Property

    Public Property Codinteres() As String
        Get
            Return _cosInteres
        End Get
        Set(ByVal value As String)
            _cosInteres = value
        End Set
    End Property
    Public Function AltaReajuste() As Boolean
        Try
            Dim csql As String = "Insert into T_FactoReajuste(codinteres,base,mensual,acumulado,fecha) values('" + Me.Codinteres.ToString + "','" + Base.ToString + "','" + Me.Mensual.ToString + "','" + Acumulado.ToString + "','" + Fecha.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este Factor de Reajuste. ", "Insercion de Factor de Reajuste", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Inserción de Factor de Reajuste" + ex.ToString, "Factor de Reajuste", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function EliminarReajuste(ByVal codinteres As String) As Boolean
        Try
            Dim csql As String = "delete t_factoreajuste where codinteres='" + codinteres.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Eliminar este Factor de Reajuste. ", "Eliminacion de Factor de Reajuste", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Eliminar de Factor de Reajuste" + ex.ToString, "Factor de Reajuste", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function updateReajuste(ByVal codinteres As String) As Boolean
        Try
            Dim csql As String = "update t_factoreajuste set base='" + Base.ToString + "',mensual='" + Mensual.ToString + "',acumulado='" + Acumulado.ToString + "',fecha='" + Me.Fecha.ToString + "' where codinteres='" + codinteres.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea Actualizar este Factor de Reajuste. ", "Actualizar de Factor de Reajuste", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Actualizar de Factor de Reajuste" + ex.ToString, "Factor de Reajuste", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function GeneraCodInteres() As String
        Dim strsql As String
        strsql = "SELECT MAX(CONVERT(INT,codInteres,10)) AS CCOD FROM T_FactoReajuste"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
End Class
