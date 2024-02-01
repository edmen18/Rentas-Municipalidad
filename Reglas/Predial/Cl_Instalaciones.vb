Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_Instalaciones
    Private _cod_predio As String
    Private _instalacion As String
    Private _valor As Double
    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property

    Public Property Instalacion() As String
        Get
            Return _instalacion
        End Get
        Set(ByVal value As String)
            _instalacion = value
        End Set
    End Property

    Public Property CodPredio() As String
        Get
            Return _cod_predio
        End Get
        Set(ByVal value As String)
            _cod_predio = value
        End Set
    End Property
    Public Function AltaIntalacion() As Boolean
        Try
            Dim csql As String = "Insert into T_Instalaciones values('" + Me.CodPredio.ToString + "','" + Me.Instalacion.ToString + "','" + Me.Valor.ToString + "','A')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta estas Instalaciones ", "Insercion de Instalacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()

        Catch ex As Exception
            MessageBox.Show("Error al insertar Instalación" + ex.ToString, "Instalación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Class
