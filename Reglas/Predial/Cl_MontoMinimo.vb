Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_MontoMinimo
    Private _valor As Double
    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property
    Public Function AltaCondicion() As Boolean
        Try
            Dim csql As String = "update t_montominimo set valor='" + Valor.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta este Monto Minimo ", "Insercion de Monto Mínimo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error alta Monto Mínimo" + ex.ToString, "Monto Mínimo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
