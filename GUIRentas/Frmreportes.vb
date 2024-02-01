Imports Reglas
Imports Datos
Imports Reportes
Imports CrystalDecisions.CrystalReports.Engine.FormulaFieldDefinition

Public Class Frmreportes
    Dim cventa As New Cl_Venta
    Dim cimp As New C_imprime
    Dim Entidad As New Cl_Entidad
    Private Sub BTNVER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNVER.Click
        If Me.rbreportediariocaja.Checked = False And Me.rbdiarioingreso.Checked = False And Me.rbrecibosemitidos.Checked = False Then
            MsgBox("Seleccione una Opción", MsgBoxStyle.Critical)
        Else
            If Me.DateTimePicker1.Value.Date > Me.DateTimePicker2.Value.Date Then
                MsgBox("El intervalo de fechas ingresado no es correcto", MsgBoxStyle.Critical)
            Else
                If Me.rbreportediariocaja.Checked = True Then
                    Dim cr As New Cr_DiarioCaja
                    cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre.ToString() + "'"
                    cr.DataDefinition.FormulaFields.Item("ruc").Text = "'" + Entidad.Ruc.ToString() + "'"

                    cr.DataDefinition.FormulaFields.Item("fecha").Text = "'" + Me.DateTimePicker1.Text + "'"
                    cimp.reporte(cventa.Reportediariocaja(Me.DateTimePicker1.Value.Date), cr)
                End If
                If Me.rbdiarioingreso.Checked = True Then
                    Dim cr As New Cr_ReporteDiarioIngreso
                    cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre.ToString() + "'"
                    cr.DataDefinition.FormulaFields.Item("ruc").Text = "'" + Entidad.Ruc.ToString() + "'"

                    cr.DataDefinition.FormulaFields.Item("fecha").Text = "'" + Me.DateTimePicker1.Text + "'"
                    cimp.reporte(cventa.ReportediariIngreso(Me.DateTimePicker1.Value.Date), cr)
                End If
                If Me.rbrecibosemitidos.Checked = True Then
                    Dim cr As New Cr_Ventas
                    cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre.ToString() + "'"
                    cr.DataDefinition.FormulaFields.Item("ruc").Text = "'" + Entidad.Ruc.ToString() + "'"

                    cr.DataDefinition.FormulaFields.Item("fechaIni").Text = "'" + Me.DateTimePicker1.Text + "'"
                    cr.DataDefinition.FormulaFields.Item("fechaFin").Text = "'" + Me.DateTimePicker2.Text + "'"
                    cimp.reporte(cventa.ReporteVentaPORFECHAS(Me.DateTimePicker1.Value.Date, Me.DateTimePicker2.Value.Date), cr)
                End If

            End If
        End If

    End Sub


    Private Sub Frmreportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Visible = False
        Me.Label2.Visible = False
        Me.DateTimePicker2.Visible = False
    End Sub

    Private Sub rbreportediariocaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbreportediariocaja.CheckedChanged
        Me.Label1.Visible = False
        Me.Label2.Visible = False
        Me.DateTimePicker2.Visible = False
    End Sub

    Private Sub rbdiarioingreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdiarioingreso.CheckedChanged
        Me.Label1.Visible = False
        Me.Label2.Visible = False
        Me.DateTimePicker2.Visible = False
    End Sub

    Private Sub rbrecibosemitidos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbrecibosemitidos.CheckedChanged
        Me.Label1.Visible = True
        Me.Label2.Visible = True
        Me.DateTimePicker2.Visible = True
    End Sub

End Class