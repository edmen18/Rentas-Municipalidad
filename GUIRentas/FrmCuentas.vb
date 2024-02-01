Imports Datos
Imports Reglas
Public Class FrmCuentas
    Dim clcuenta As New Cl_Cuentas
    Dim FunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim flg As Integer = 0 'para validar si guardamos o modificamos en boton guardar
    Dim v As Integer  ' validar si estamos insertando un código repetido
    Private Sub FrmCuentas_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
        cancelar()
    End Sub
    Private Sub FrmCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaGridCuenta()
        EstiloGrid.AplicaStiloOrange(dgvCuentas)
        Me.txtnumero.Enabled = False
        Me.txtcuenta.Enabled = False
        Me.txtBco.Enabled = False
    End Sub
    Sub LlenaGridCuenta()
        Dim cSql As String = "SELECT codcta, descripcion, Entidad from t_cuenta"
        FunDb.FillDataGridView(cSql, dgvCuentas)
        HeadGrid()
    End Sub

    Sub HeadGrid()
        With dgvCuentas
            .Columns(0).HeaderText = "Nro. Cta"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "Nombre Cuenta"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Entidad Financiera"
            .Columns(2).Width = .Width - .Columns(0).Width - .Columns(1).Width
        End With
    End Sub

    Sub cancelar()
        Me.txtnumero.Enabled = False
        Me.txtcuenta.Enabled = False
        Me.txtBco.Enabled = False
        Me.txtBco.ResetText()
        Me.txtnumero.ResetText()
        Me.txtcuenta.ResetText()
        Me.v = 0
    End Sub

    Private Sub txtcuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcuenta.TextChanged
        txtcuenta.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.txtnumero.Enabled = True
        Me.txtcuenta.Enabled = True
        Me.txtBco.Enabled = True
        Me.txtnumero.ResetText()
        Me.txtcuenta.ResetText()
        Me.txtBco.ResetText()
        Me.txtnumero.Focus()
        Me.flg = 0  'Agregar
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.txtnumero.Text = "" Or Me.txtcuenta.Text = "" Then
            MessageBox.Show("Complete los datos antes de continuar", "Rentas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            clcuenta.CodCta = Me.txtnumero.Text
            clcuenta.Descripcion = Me.txtcuenta.Text
            clcuenta.Banco = Me.txtBco.Text
            If Me.flg = 0 Then
                clcuenta.AltaCuenta()
                cancelar()
            ElseIf flg = 1 Then
                clcuenta.Modificarcuenta(Me.txtnumero.Text)
                cancelar()
            End If
        End If
        LlenaGridCuenta()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        cancelar()
    End Sub

   
    Private Sub dgvCuentas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentas.CellDoubleClick
        flg = 1
        Try
            Me.txtnumero.Text = dgvCuentas.Item(0, dgvCuentas.CurrentRow.Index).Value
            Me.txtcuenta.Text = dgvCuentas.Item(1, dgvCuentas.CurrentRow.Index).Value
            Me.txtBco.Text = dgvCuentas.Item(2, dgvCuentas.CurrentRow.Index).Value
        Catch ex As Exception
        End Try
        Me.txtnumero.Enabled = False
        Me.txtcuenta.Enabled = True
        Me.txtBco.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        clcuenta.EliminaCuenta(Me.txtnumero.Text)
        LlenaGridCuenta()
    End Sub

  
    Private Sub txtBco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBco.TextChanged
        Me.txtBco.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class