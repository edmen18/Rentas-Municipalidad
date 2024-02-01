Imports Reglas
'Imports Datos
Public Class FrmBackup
    Dim cBak As New cBackup
   
    Private Sub BtnCrearBk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrearBk.Click
        'Dim db As BaseDatos = New BaseDatos()
        'db.Desconectar()
        cBak.CreaBackup(Me.TxtDestino.Text)
    End Sub

    Private Sub TxtDestino_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles TxtDestino.ButtonClick
        Me.TxtDestino.ResetText()
        FldrView.ShowDialog()
        Me.TxtDestino.Text = FldrView.SelectedPath & "\DBRENTAS.BAK"
    End Sub

   
   
End Class