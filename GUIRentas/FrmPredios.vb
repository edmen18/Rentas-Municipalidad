Imports Datos
Imports Reglas
Public Class FrmPredios
    Dim FunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    Private Sub FrmPredios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaLstViewtrim()
    End Sub
    Sub LlenaLstViewtrim() ' llenamos la lista de trimestres y pagos de una dj
        Dim cSql As String = "select tp.codpredio,Direccion,numero,'Mz '+Manzana as manzana,'Lt '+lote as lote from dbo.T_Predio tp inner join dbo.T_DetalleDJ tdj  on tdj.codpredio=tp.codpredio where coddj='" + FrmPagos.DgvDj.Item(0, FrmPagos.DgvDj.CurrentRow.Index).Value.ToString + "'"
        FunDb.FillDataGridView(cSql, DgvPredios)
        EncabezadosgridDj()
        EstiloGrid.AplicaStiloBlue(DgvPredios)
    End Sub
    Sub EncabezadosgridDj()
        DgvPredios.Columns(0).HeaderText = "Cod. Predio"
        DgvPredios.Columns(0).Width = 100
        DgvPredios.Columns(1).HeaderText = "Dirección"
        DgvPredios.Columns(1).Width = 250
        DgvPredios.Columns(2).HeaderText = "Numero"
        DgvPredios.Columns(2).Width = 70
        DgvPredios.Columns(3).HeaderText = "Manzana"
        DgvPredios.Columns(3).Width = 70
        DgvPredios.Columns(4).HeaderText = "Lote"
        DgvPredios.Columns(4).Width = 70
    End Sub
End Class