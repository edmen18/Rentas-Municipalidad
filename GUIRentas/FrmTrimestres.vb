Imports Datos
Imports Reglas
Public Class FrmTrimestres

    Dim Trimestre As New Cl_Trimestre
    Dim FuncDB As New cFuncionesDB
    Dim Estilo As New Cl_EstiloGrid

    Dim flag As String

#Region "Acciones de la Aplicacion"

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        flag = "New"
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.lblCod.Text = Format(Trimestre.GeneraCodTrimestre + 1, "000")
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If flag = "New" Then
            PropiedadesBD()
            Trimestre.Estado = "1"
            Trimestre.AltaTrimestre()
        Else
            PropiedadesBD()
            Trimestre.Estado = "1"
            Trimestre.ModificarTrimestre(Me.lblCod.Text)
            LlenaGridTrimestres()
        End If
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        'PropiedadesBD()
        Trimestre.Estado = "0"
        Trimestre.EliminarTrimestre(Me.dgvTrimestres.Item(0, dgvTrimestres.CurrentRow.Index).Value)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        Me.lblCod.ResetText()
    End Sub
#End Region

  
#Region "Funciones y Procedimientos"
    Sub LLenaTrimestres()
        Me.cmbNumero.Items.Clear()
        For i = 1 To 4
            Me.cmbNumero.Items.Add(i)
        Next
    End Sub

    Sub LlenaGridTrimestres()
        Dim csql As String = "SELECT * FROM T_TRIMESTRES WHERE YEAR(FechVenc)='" + Now.Year.ToString + "' AND ESTADO ='1'"
        FuncDB.FillDataGridView(csql, dgvTrimestres)
        Estilo.AplicaStiloBlue(dgvTrimestres)
    End Sub

    Sub PropiedadesBD()
        Trimestre.Codigo = Me.lblCod.Text
        Trimestre.Numero = Me.cmbNumero.Text
        Trimestre.Vencimiento = Me.dtpFecVen.Value
    End Sub

#End Region

    Private Sub FrmTrimestres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaGridTrimestres()
        LLenaTrimestres()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dgvTrimestres_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvTrimestres.SelectionChanged
        If dgvTrimestres.RowCount > 0 Then
            Me.lblCod.Text = dgvTrimestres.Item(0, dgvTrimestres.CurrentRow.Index).Value
            Me.cmbNumero.Text = dgvTrimestres.Item(1, dgvTrimestres.CurrentRow.Index).Value
            Me.dtpFecVen.Text = dgvTrimestres.Item(2, dgvTrimestres.CurrentRow.Index).Value
            Me.btnGuardar.Enabled = True
            Me.btnEliminar.Enabled = True
        Else
            Me.btnEliminar.Enabled = False
        End If
    End Sub

End Class