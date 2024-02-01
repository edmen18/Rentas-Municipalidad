Imports System.Windows.Forms
Imports Datos


Public Class Cl_Depreciacion
    Private _codDeprec As String
    Private _codtipoEdi As String
    Private _desde As Integer
    Private _hasta As Integer
    Private _codMat As String
    Private _estadoConser As String
    Private _valor As Double

    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property
    Public Property Conservacion() As String
        Get
            Return _estadoConser
        End Get
        Set(ByVal value As String)
            _estadoConser = value
        End Set
    End Property
    Public Property Material() As String
        Get
            Return _codMat
        End Get
        Set(ByVal value As String)
            _codMat = value
        End Set
    End Property
    Public Property Hasta() As Integer
        Get
            Return _hasta
        End Get
        Set(ByVal value As Integer)
            _hasta = value
        End Set
    End Property
    Public Property Desde() As Integer
        Get
            Return _desde
        End Get
        Set(ByVal value As Integer)
            _desde = value
        End Set
    End Property
    Public Property TipoEdificacion() As String
        Get
            Return _codtipoEdi
        End Get
        Set(ByVal value As String)
            _codtipoEdi = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return _codDeprec
        End Get
        Set(ByVal value As String)
            _codDeprec = value
        End Set
    End Property


    Public Function AltaDepreciacion() As Boolean
        Try
            Dim csql As String = "Insert into T_Depreciacion values('" + Me.Codigo.ToString + "','" + Me.TipoEdificacion.ToString + "','" + Me.Desde.ToString + "','" + Me.Hasta.ToString + "','" + Me.Material.ToString + "','" + Me.Conservacion.ToString + "','" + Me.Valor.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta la depreciacion", "Insercion de Nueva depreciacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()

        Catch ex As Exception
            MessageBox.Show("Error al insertar Depreciacion" + ex.ToString, "Depreciacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ModificarDepreciacion(ByVal CodDepreciacion As String) As Boolean
        Try
            Dim csql As String = "update T_Depreciacion set CodTipoEdificacion='" + Me.TipoEdificacion.ToString + "',Desde='" + Me.Desde.ToString + "',Hasta='" + Me.Hasta.ToString + "',CodMaterial='" + Me.Material.ToString + "',CodEstado='" + Me.Conservacion.ToString + "',valor='" + Me.Valor.ToString + "' where CodDepreciacion='" + CodDepreciacion.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Modificar Depreciacion", "Actualización de Depreciacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al insertar depreciacion" + ex.ToString, "Depreciacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function EliminaDepreciacion(ByVal codDepreciacion As String) As Boolean
        Try
            Dim csql As String = "DELETE FROM T_Depreciacion WHERE CodEstado ='" + codDepreciacion + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Si Elimina esta depreciacion, ya no podra recuperar el valor de la Base de datos ", "Eliminar Tipo Edificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Registro eliminado con exito", "Estado de Conservacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al eliminar registro" + ex.ToString, "Eliminar.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Function GeneraCodDepreciacion() As Integer
        Dim strsql As String
        Dim cod As Integer = 0
        strsql = "SELECT MAX(CONVERT(INT,(CODDEPRECIACION))) AS CCOD FROM T_Depreciacion"
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
