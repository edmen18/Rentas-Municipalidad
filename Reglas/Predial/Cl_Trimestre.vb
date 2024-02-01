Imports System.Windows.Forms
Imports Datos

Public Class Cl_Trimestre
    Private _codTri As String
    Private _numtri As Integer
    Private _fecTri As Date
    Private _estado As String


#Region "Propiedades"
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property


    Public Property Vencimiento() As Date
        Get
            Return _fecTri
        End Get
        Set(ByVal value As Date)
            _fecTri = value
        End Set
    End Property



    Public Property Numero() As Integer
        Get
            Return _numtri
        End Get
        Set(ByVal value As Integer)
            _numtri = value
        End Set
    End Property


    Public Property Codigo() As String
        Get
            Return _codTri
        End Get
        Set(ByVal value As String)
            _codTri = value
        End Set
    End Property

#End Region

#Region "Procesos"

    Public Function AltaTrimestre() As Boolean
        Try
            Dim csql As String = "Insert into T_Trimestres values('" + Me.Codigo.ToString + "','" + Me.Numero.ToString + "','" + Me.Vencimiento.ToShortDateString + "','" + Me.Estado.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta el Trimestre: " + Me.Numero.ToString, "Insercion de Trimestre", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Los datos se almacenaron de manera satisfactoria", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error al insertar Trimestre" + ex.ToString, "SRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ModificarTrimestre(ByVal CodTrimestre As String) As Boolean
        Try
            Dim csql As String = "update T_Trimestres set numero='" + Me.Numero.ToString + "', fechVenc='" + Me.Vencimiento.ToShortDateString + "',estado='" + Me.Estado.ToString + "' where CodTrimestre='" + CodTrimestre.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Modificar Trimestre", "Actualización de Trimestre", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Los datos se almacenaron de manera satisfactoria", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error al insertar Trimestre" + ex.ToString, "SRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function EliminarTrimestre(ByVal CodTrimestre As String) As Boolean
        Try
            Dim csql As String = "update T_Trimestres set estado='" + Me.Estado.ToString + "' where CodTrimestre='" + CodTrimestre.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Va a marcar el Trimestre como Eliminado", "Eliminar Trimestre", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Los datos se almacenaron de manera satisfactoria", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error al Eliminar Trimestre" + ex.ToString, "SRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function GeneraCodTrimestre() As Integer
        Dim strsql As String
        Dim cod As Integer = 0
        strsql = "SELECT MAX(CONVERT(INT,CodTrimestre)) AS CCOD FROM T_Trimestres"
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

#End Region
   
End Class
