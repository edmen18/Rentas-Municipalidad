Imports Datos
Public Class FrmPrueba
    Dim FunDb As New cFuncionesDB

    Private Sub FrmPrueba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim csql As String = "SELECT FECHA FROM T_VENTA"
        FunDb.FillDataGridView(csql, Me.DataGridView1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Me.txtNumDias.Text = DateDiff("d", Me.DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value, dtpFechaAct.Value)
        calcula()
    End Sub

    Sub calcula()
        Try
            For i = 0 To Me.DataGridView1.RowCount
                Dim ndias As Integer
                ndias = DateDiff("d", Me.DataGridView1.Item(0, i).Value, dtpFechaAct.Value)
                MsgBox(ndias)
            Next
        Catch ex As Exception
        End Try
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dif As Integer
        Dim i As Integer
        Dim fecha_inicial As String = Me.dtpFechaAct.Text
        Dim fecha_final As String = dtpfecha2.Text
        dif = Val(CDate(fecha_final)) - Val(CDate(fecha_inicial)) + 1
        For i = 0 To dif - 1
            If Weekday(System.DateTime.FromOADate(CDate(fecha_inicial).ToOADate + i), FirstDayOfWeek.Monday) = 6 Or Weekday(System.DateTime.FromOADate(CDate(fecha_inicial).ToOADate + i), FirstDayOfWeek.Monday) = 7 Then
                dif = dif - 1
            End If
        Next i
        MsgBox("Dias habiles = " & dif, MsgBoxStyle.Information, "Resultado")


    End Sub
End Class