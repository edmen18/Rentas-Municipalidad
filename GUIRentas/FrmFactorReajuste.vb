Imports Reglas
Imports Datos
Imports Reportes
Public Class FrmFactorReajuste
    Dim cfr As New Cl_FactorReajuste
    Dim FunDb As New cFuncionesDB
    Dim contador As Integer = 0
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim Validar As New Cl_Validar
    Private Sub FrmFactorReajuste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Llenadatagrid()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If cfr.Codinteres = "" Then
            ' grabar factor reajuste
            If Me.txtbase.Text = "" Or Me.txtmensual.Text = "" Or Me.txtacumulado.Text = "" Then
                MessageBox.Show("Complete los datos antes de continuar", "Factor de Reajuste", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cfr.Codinteres = Format(CInt(cfr.GeneraCodInteres) + 1, "0000000000")
                cfr.Base = Me.txtbase.Text
                cfr.Mensual = CDbl(Me.txtmensual.Text)
                cfr.Acumulado = CDbl(Me.txtacumulado.Text)
                cfr.Fecha = CStr(Me.DtFecha.Value.Date)

                For i = 0 To Me.DgvFactores.RowCount - 1
                    If CDate(Me.DgvFactores.Item(3, i).Value).Year = Me.DtFecha.Value.Year And CDate(Me.DgvFactores.Item(3, i).Value).Month = Me.DtFecha.Value.Month Then
                        contador = contador + 1
                    End If
                Next
                If contador = 0 Then
                    If Me.DtFecha.Value.Date > Now.Date Then
                        MessageBox.Show("No puede ingresar un valor mayor a la fecha actual", "Factor de Reajuste", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        cfr.AltaReajuste()
                    End If
                Else
                    MessageBox.Show("Para este mes ya fue ingresado un valor", "Factor de Reajuste", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Else
            'MsgBox(Me.cfr.Codinteres)
            'actualizar factor de reajuste
            cfr.Base = Me.txtbase.Text
            cfr.Mensual = CDbl(Me.txtmensual.Text)
            cfr.Acumulado = CDbl(Me.txtacumulado.Text)
            cfr.Fecha = CStr(Me.DtFecha.Value.Date)
            cfr.updateReajuste(cfr.Codinteres)
        End If
        Llenadatagrid()
        limpiar()
    End Sub
    Sub Encabezadosgrid()
        DgvFactores.Columns(0).HeaderText = "Base"
        DgvFactores.Columns(0).Width = 100
        DgvFactores.Columns(1).HeaderText = "Mensual"
        DgvFactores.Columns(1).Width = 100
        DgvFactores.Columns(2).HeaderText = "Acumulado"
        DgvFactores.Columns(2).Width = 100
        DgvFactores.Columns(3).HeaderText = "Fecha de Establecimiento"
        DgvFactores.Columns(3).Width = 100
    End Sub
    Sub Llenadatagrid()
        Dim cSql As String = "select base,mensual,acumulado,fecha,codinteres from t_factoreajuste where year(fecha)=year(getdate()) order by fecha"
        FunDb.FillDataGridView(cSql, DgvFactores)
        Encabezadosgrid()
        EstiloGrid.AplicaStiloBlue(DgvFactores)
    End Sub

    Private Sub Btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancelar.Click
        limpiar()
    End Sub
    Sub limpiar()
        cfr.Codinteres = ""
        Me.txtbase.ResetText()
        Me.txtacumulado.ResetText()
        Me.txtmensual.ResetText()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        If Me.txtacumulado.Text = "" Or Me.txtbase.Text = "" Or Me.txtmensual.Text = "" And cfr.Codinteres = "" Then
            MessageBox.Show("Seleccione un Factor de Reajuste", "Factor de Reajuste", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If cfr.EliminarReajuste(cfr.Codinteres) = True Then
                Llenadatagrid()
            End If
        End If

    End Sub
    Private Sub DgvFactores_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvFactores.DoubleClick
        cfr.Codinteres = Convert.ToString(Me.DgvFactores.CurrentRow.Cells(4).Value)
        Me.txtbase.Text = Convert.ToString(Me.DgvFactores.CurrentRow.Cells(0).Value)
        Me.txtmensual.Text = Convert.ToString(Me.DgvFactores.CurrentRow.Cells(1).Value)
        Me.txtacumulado.Text = Convert.ToString(Me.DgvFactores.CurrentRow.Cells(2).Value)
        Me.DtFecha.Text = Convert.ToString(Me.DgvFactores.CurrentRow.Cells(3).Value)
    End Sub

    Private Sub txtmensual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmensual.KeyPress
        e.Handled = Validar.NumerosDecimales(System.Convert.ToInt16(Asc(e.KeyChar)))
    End Sub


    Private Sub txtacumulado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtacumulado.KeyPress
        e.Handled = Validar.NumerosDecimales(System.Convert.ToInt16(Asc(e.KeyChar)))
    End Sub


End Class