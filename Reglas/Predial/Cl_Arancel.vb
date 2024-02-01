Imports System.Windows.Forms
Imports Datos

Public Class Cl_Arancel
    Private _codArancel As String
    Private _monto As Double
    Private _estado As Char
    Dim BaseDatos As New BaseDatos


    Public Property Estado() As Char
        Get
            Return _estado
        End Get
        Set(ByVal value As Char)
            _estado = value
        End Set
    End Property
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return _codArancel
        End Get
        Set(ByVal value As String)
            _codArancel = value
        End Set
    End Property

    Public Function AltaArancel() As Boolean
        Try
            Dim csql As String = "Insert into T_Arancel values('" + Me.Codigo.ToString + "','" + Me.Monto.ToString + "','" + Me.Estado.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta el Arancel ", "Insercion de Arancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()

        Catch ex As Exception
            MessageBox.Show("Error al insertar Arancel" + ex.ToString, "Arancel", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ModificarArancel(ByVal CodigoArancel As String) As Boolean
        Try
            Dim csql As String = "update T_Material set monto='" + Me.Monto.ToString + "', estado ='" + Me.Estado.ToString + "' where CodArancel='" + CodigoArancel.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea modificar el arancel", "Actualización de Arancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al insertar Arancel" + ex.ToString, "Arancel", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function





End Class
