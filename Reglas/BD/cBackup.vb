Option Strict On

Imports Datos
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class cBackup

    Public Function CreaBackup(ByVal oDirDestino As String) As Boolean
        Try
            Dim csql As String = "BACKUP DATABASE [DBRENTAS] TO  DISK = N'" & oDirDestino & "' WITH NOFORMAT, NOINIT,  NAME = N'DBRENTAS-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.CrearComando(csql)
            db.EjecutarComando()
            MessageBox.Show("La copia de la Base de datos se realizó satisfactoriamente", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error creando copia de Base de datos" + ex.ToString, "SRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function RestauraBackup(ByVal oServer As String, ByVal oBase As String, ByVal oRuta As String) As Boolean
        Try
            Dim csql As String = "RESTORE DATABASE " & oBase & _
                                " FROM DISK = '" & oRuta & "'" & _
                                " WITH REPLACE"
            Dim csb As New SqlConnectionStringBuilder
            csb.DataSource = oServer
            ' Es mejor abrir la conexión con la base Master
            csb.InitialCatalog = "master"
            'csb.IntegratedSecurity = True
            csb.UserID = "sa"
            csb.Password = "binroot"

            Using con As New SqlConnection(csb.ConnectionString)
                Try
                    con.Open()

                    Dim cmdBackUp As New SqlCommand(csql, con)
                    cmdBackUp.ExecuteNonQuery()
                    MessageBox.Show("Se ha restaurado la copia de la base de datos.", _
                                    "Restaurar base de datos", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)

                    con.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, _
                                    "Error al restaurar la base de datos", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using

        Catch ex As Exception
            MessageBox.Show("Error... restaurando Base de datos" + ex.ToString, "SRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function



End Class
