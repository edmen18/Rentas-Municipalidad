Imports System.Windows.Forms
Imports Datos
Public Class Cl_TipoEdificacion
    Private _codTipEdi As String
    Private _desTipEdi As String
    Private _codArancel As String

    Public Property Arancel() As String
        Get
            Return _codArancel
        End Get
        Set(ByVal value As String)
            _codArancel = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return _desTipEdi
        End Get
        Set(ByVal value As String)
            _desTipEdi = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return _codTipEdi
        End Get
        Set(ByVal value As String)
            _codTipEdi = value
        End Set
    End Property

    Dim BaseDatos As New BaseDatos

    Public Function AltaTipoEdificacion() As Boolean
        Try
            Dim csql As String = "Insert into T_TipoEdificacion values('" + Me.Codigo.ToString + "','" + Me.Descripcion.ToString + "','" + Me.Arancel.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Desea dar de Alta el tipo de edicacion " + Me.Descripcion.ToString, "Insercion de Tipo de Edificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()

        Catch ex As Exception
            MessageBox.Show("Tipo de Edificacion" + ex.ToString, "Tipo Edificacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ModificarTipoEdificacion(ByVal codTipoEdif As String) As Boolean
        Try
            Dim csql As String = "update T_TipoEdificacion set descripcion='" + Me.Descripcion.ToString + "',codArancel='" + Me.Arancel.ToString + "' where CodTipoEdificacion='" + codTipoEdif.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Modificar tipo de edicacion", "Actualización de Tipo de Edificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Tipo de Edificacion" + ex.ToString, "Tipo Edificacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function EliminaTipoEdificacion(ByVal codTipoEdif As String) As Boolean
        Try
            Dim csql As String = "DELETE FROM T_TipoEdificacion WHERE CodTipoEdificacion ='" + codTipoEdif + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Si Elimina el tipo de Edificacion, ya no podra recuperarlo de la Base de datos ", "Eliminar Tipo Edificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                MessageBox.Show("Tipo de Edificacion eliminado con exito", "Eliminar Tipo Edificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Eliminando Tipo de Edificacion" + ex.ToString, "Tipo de Edificacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function GeneraCodEdif() As String
        Dim strsql As String
        strsql = "SELECT MAX(RIGHT(CODTIPOEDIFICACION,2)) AS CCOD FROM T_TIPOEDIFICACION"
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.ComenzarTransaccion()
        db.CrearComando(strsql)
        Dim cod As String = CStr(db.EjecutarEscalar())
        Return cod
    End Function



End Class
