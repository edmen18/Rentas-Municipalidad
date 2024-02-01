Imports Reglas
Imports Datos
Public Class FrmRestauraBD
    Dim cBak As New cBackup

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        cBak.RestauraBackup(Me.TxtServer.Text, Me.txtBase.Text, Me.TxtBackup.Text)
    End Sub

    Private Sub TxtBackup_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles TxtBackup.ButtonClick
        Me.TxtBackup.ResetText()
        FileDialog.ShowDialog()
        Me.TxtBackup.Text = FileDialog.FileName
    End Sub

End Class