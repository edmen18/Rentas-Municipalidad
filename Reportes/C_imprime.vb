Imports CrystalDecisions
Imports System.IO
Public Class C_imprime
    Dim frmrep As New FrmReporte
    Sub reporte(ByVal dsobj As System.Data.DataSet, ByVal report As CrystalReports.Engine.ReportClass)
        report.SetDataSource(dsobj)
        report.Refresh()
        frmrep.CrvwReporte.ReportSource = report
        frmrep.CrvwReporte.RefreshReport()
        frmrep.ShowDialog()
    End Sub
End Class
