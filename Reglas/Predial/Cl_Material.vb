Imports System.Windows.Forms
Imports Datos


Public Class Cl_Material
    Private _codMat As String
    Private _desMat As String
    Dim BaseDatos As New BaseDatos

    Public Property Descripcion() As String
        Get
            Return _desMat
        End Get
        Set(ByVal value As String)
            _desMat = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return _codMat
        End Get
        Set(ByVal value As String)
            _codMat = value
        End Set
    End Property

    Public Function AltaTipoEdificacion() As Boolean
        Try
            Dim csql As String = "Insert into T_Material values('" + Me.Codigo.ToString + "','" + Me.Descripcion.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta el Material: " + Me.Descripcion.ToString, "Insercion de Material", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
            MessageBox.Show("Error al insertar Material" + ex.ToString, "Tipo Material", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ModificarTipoEdificacion(ByVal CodMaterial As String) As Boolean
        Try
            Dim csql As String = "update T_Material set descripcion='" + Me.Descripcion.ToString + "' where CodMaterial='" + CodMaterial.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Modificar Material", "Actualización de Material", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
            MessageBox.Show("Error al insertar Material" + ex.ToString, "Tipo Material", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function



End Class
