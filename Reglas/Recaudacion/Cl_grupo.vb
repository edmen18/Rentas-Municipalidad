Imports System.Data
Imports System.Windows.Forms
Imports Datos

Public Class Cl_grupo
    Private _numeroGrupo As String
    Private _nombreGrupo As String
    Dim cFundb As New cFuncionesDB
    Private _annio As String
    Public Property Annio() As String
        Get
            Return _annio
        End Get
        Set(ByVal value As String)
            _annio = value
        End Set
    End Property

    Public Property NombreGrupo() As String
        Get
            Return _nombreGrupo
        End Get
        Set(ByVal value As String)
            _nombreGrupo = value
        End Set
    End Property

    Public Property NumeroGrupo() As String
        Get
            Return _numeroGrupo
        End Get
        Set(ByVal value As String)
            _numeroGrupo = value
        End Set
    End Property

    Public Function AltaGrupo() As Boolean
        Try
            Dim csql As String = "Insert into T_grupo(numgru,desgru,annio) values('" + Me.NumeroGrupo.ToString + "','" + Me.NombreGrupo.ToString + "','" + Annio.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta esta Division ", "Insercion de Division", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error Alta Division" + ex.ToString, "Division", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function GeneraCodArea() As String
        Dim strsql As String
        strsql = "SELECT count(*) AS CCOD FROM T_grupo"
        Dim dato As String = cFundb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
    Public Function ModificarGrupo(ByVal grupo As String) As Boolean
        Try
            Dim csql As String = "update t_grupo set numgru='" + Me.NumeroGrupo.ToString + "',desgru='" + Me.NombreGrupo.ToString + "' where numgru='" + grupo.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Modificar este Division ", "Actualización de Division", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()

        Catch ex As Exception
            MessageBox.Show("Error Modificar Division" + ex.ToString, "Division", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Class
