Imports System.Data
Imports System.Windows.Forms
Imports Datos
Public Class Cl_clase
    Private _numGru As String
    Private _numCla As String
    Private _desCla As String
    Private cFunDb As New cFuncionesDB
    Private _porcentaje As Double
    Private _codTipo As String
    Private _codCta As String
    Private _valor As Double
    Private _annio As String
    Public Property Annio() As String
        Get
            Return _annio
        End Get
        Set(ByVal value As String)
            _annio = value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property

    Public Property CodCta() As String
        Get
            Return _codCta
        End Get
        Set(ByVal value As String)
            _codCta = value
        End Set
    End Property


    Public Property CodTipo() As String
        Get
            Return _codTipo
        End Get
        Set(ByVal value As String)
            _codTipo = value
        End Set
    End Property

    Public Property Porcentaje() As Double
        Get
            Return _porcentaje
        End Get
        Set(ByVal value As Double)
            _porcentaje = value
        End Set
    End Property


    Public Property DesCla() As String
        Get
            Return _desCla
        End Get
        Set(ByVal value As String)
            _desCla = value
        End Set
    End Property

    Public Property NumCla() As String
        Get
            Return _numCla
        End Get
        Set(ByVal value As String)
            _numCla = value
        End Set
    End Property

    Public Property NumGru() As String
        Get
            Return _numGru
        End Get
        Set(ByVal value As String)
            _numGru = value
        End Set
    End Property
    Public Function Altaclase() As Boolean
        Try
            Dim csql As String = "Insert into T_clase(numcla,numgru,descla,porcentaje,codtipo,codcta,valor,annio) values('" + Me.NumCla.ToString + "','" + Me.NumGru.ToString + "','" + DesCla.ToString + "','" + Porcentaje.ToString + "','" + CodTipo.ToString + "','" + CodCta.ToString + "','" + Valor.ToString + "','" + Annio.ToString + "')"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Porfavor confirme el registro de la Nueva Tasa ", "Insercion de Tasas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
                Return True
            Else
                db.CancelarTransaccion()
                Return False
            End If
            db.Desconectar()

        Catch ex As Exception
            MessageBox.Show("Error registrando Tasas" + ex.ToString, "Registro de Tasas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function GeneraCodClase(ByVal CODIGO As String) As String
        Dim strsql As String
        strsql = "SELECT count(*) AS CCOD FROM T_clase WHERE NUMGRU='" + CODIGO + "'"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
    Public Function Modificarclase(ByVal clase As String) As Boolean
        Try
            Dim csql As String = "update t_clase set numgru='" + Me.NumGru.ToString + "',numcla='" + Me.NumCla.ToString + "',descla='" + DesCla.ToString + "',porcentaje='" + Porcentaje.ToString + "',codtipo='" + CodTipo.ToString + "',CODCTA='" + CodCta.ToString + "',Valor='" + Valor.ToString + "' where numcla='" + clase.ToString + "'"
            Dim db As BaseDatos = New BaseDatos()
            Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            pregunta = MessageBox.Show("Modificar informacion de Tasas", "Actualización de informacion de Tasas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                db.ConfirmarTransaccion()
            Else
                db.CancelarTransaccion()
            End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Modificar Tasas" + ex.ToString, "Modificar Tasas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Overloads Function TOUOT() As DataSet
        Dim dset As New DataSet
        Try
            Dim csql As String = "select tg.NumGru,DesGru,NumCla,DesCla,Porcentaje,Valor from dbo.T_Clase tc inner join dbo.T_Grupo tg on tg.numgru=tc.numgru "
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            dset = db.Mapeadataset(csql, "DT_TUO")
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return dset
    End Function

End Class
