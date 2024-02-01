Imports Reglas
Imports Datos

Public Class FrmEvaluacionPredio
    Dim FunDb As New cFuncionesDB
    Dim EstiloView As New Cl_EstiloListView
    Dim c As Integer
    Dim clprediocategoria As New Cl_PredioCategoria
    Dim clins As New Cl_Instalaciones
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        LLenarCombo()
        FrmBuscarCliente.lblflag.Text = "4"
        FrmBuscarCliente.Show()

    End Sub
    Sub LlenaLstViewPredio()
        Me.lvwpredios.Items.Clear()
        Dim cSql As String = "select codpredio,direccion+' Nª'+numero+' Mz' +manzana+' Lt'+lote as direccion, convert(numeric(9,2),areatotal)as area,convert (int,year(getdate()))-convert(int,year(fechaconstruccion)) as antiguedad,codtipoedificacion from t_predio where codcli='" + Me.lblcodigocliente.Text + "'"
        FunDb.FillListview(cSql, lvwpredios)
        'validar.colorearListView(lvwpredios)
    End Sub
    Sub LlenaLstViewCategoria()
        Me.lvwCategoria.Items.Clear()
        Dim cSql As String = "select CodContenido,CodIngresado,Descripcion,Valor from dbo.T_Contenidos where CodDenominacion='" + Me.Cmbdenominacion.SelectedValue.ToString + "'"
        FunDb.FillListview(cSql, lvwCategoria)
        'validar.colorearListView(lvwCategoria)
    End Sub
    Sub LLenarEstadoConservacion()
        Dim csql As String = "SELECT CodEstado,Estado from T_EstadoConservacion "
        FunDb.FillListaOrCombo(csql, cmbConservacion, "Estado", "CodEstado")
    End Sub
    Sub LLenarMaterial()
        Dim csql As String = "SELECT CodMaterial,Descripcion from T_Material "
        FunDb.FillListaOrCombo(csql, cmbMaterial, "Descripcion", "CodMaterial")
    End Sub
    Sub GetDatosdep()
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "select valor from dbo.T_Depreciacion where CodTipoEdificacion='" + Me.lblte.Text + "' and CodEstado='" + Me.cmbConservacion.SelectedValue.ToString + "' and CodMaterial='" + Me.cmbMaterial.SelectedValue.ToString + "' and '" + Me.lblantiguedad.Text + "'>=desde and '" + Me.lblantiguedad.Text + "'<=hasta"
            dt = cFun.ConsultaX(csql)
            Me.lbldepre.Text = CStr(CDbl(dt.Rows(0).Item(0)))
        Catch ex As Exception
            ' MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Sub LLenarCombo()
        Dim csql As String = "SELECT codDenominacion,descripcion from t_denominacion"
        FunDb.FillListaOrCombo(csql, Cmbdenominacion, "descripcion", "coddenominacion")
    End Sub

    Private Sub Cmbdenominacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbdenominacion.SelectedIndexChanged
        LlenaLstViewCategoria()
    End Sub

    Private Sub lvwpredios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwpredios.DoubleClick
        EnviaPredio()
        LLenarEstadoConservacion()
        LLenarMaterial()
    End Sub

    Sub EnviaPredio()
        If lvwpredios.SelectedItems.Count < 0 Then
            MessageBox.Show("Operación no válida, debe seleccionar un predio", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Me.lblannio.Text = clprediocategoria.UltimoAnnio(Me.lvwpredios.SelectedItems(0).SubItems(0).Text)
        If CInt(Me.lblannio.Text) = CInt(Now.Year) Then
            MessageBox.Show("El predio ya fue evaluado en el presente año y Colocado en su respectiva Declaración Jurada", "Evaluación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.lblcodpredio.Text = Me.lvwpredios.SelectedItems(0).SubItems(0).Text
            Me.lbldireccion.Text = Me.lvwpredios.SelectedItems(0).SubItems(1).Text
            Me.lblarea.Text = Me.lvwpredios.SelectedItems(0).SubItems(2).Text
            Me.lblte.Text = Me.lvwpredios.SelectedItems(0).SubItems(4).Text
            Me.lblantiguedad.Text = Me.lvwpredios.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    Private Sub lvwCategoria_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwCategoria.DoubleClick
        agregaItem()
    End Sub

    Sub agregaItem()
        If lvwCategoria.SelectedItems.Count > 0 Then
            If Me.lblcodpredio.Text = "" Then
                MessageBox.Show("Operación no válida, debe seleccionar un predio", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                c = Me.lvwasisgnacion.Items.Count
                Me.lvwasisgnacion.Items.Add(Me.lblcodpredio.Text)
                Me.lvwasisgnacion.Items(c).SubItems.Add(Me.lvwCategoria.SelectedItems(0).SubItems(0).Text)
                Me.lvwasisgnacion.Items(c).SubItems.Add(Me.lvwCategoria.SelectedItems(0).SubItems(1).Text)
                Me.lvwasisgnacion.Items(c).SubItems.Add(Me.lvwCategoria.SelectedItems(0).SubItems(3).Text)
                Me.lvwasisgnacion.Items(c).SubItems.Add(Format((CDbl(Me.lvwCategoria.SelectedItems(0).SubItems(3).Text) * (CDbl(Me.lbldepre.Text) / 100)), "#,##0.00"))
                Me.lvwasisgnacion.Items(c).SubItems.Add(Format((CDbl(Me.lvwCategoria.SelectedItems(0).SubItems(3).Text) - (CDbl(Me.lvwCategoria.SelectedItems(0).SubItems(3).Text) * (CDbl(Me.lbldepre.Text) / 100))), "#,##0.00"))
                Me.lvwasisgnacion.Items(c).SubItems.Add(Format(CDbl(Me.txtarea.Text), "#,##0.00"))
                Me.lvwasisgnacion.Items(c).SubItems.Add(Format(((CDbl(Me.txtarea.Text)) * (CDbl(Me.lvwCategoria.SelectedItems(0).SubItems(3).Text) - (CDbl(Me.lvwCategoria.SelectedItems(0).SubItems(3).Text) * (CDbl(Me.lbldepre.Text) / 100)))), "#,##0.00"))
            End If
            EstiloView.AplicaColorTotales(lvwasisgnacion, 3, Color.LightSkyBlue)
            sumar()
        Else
            MessageBox.Show("Porfavor seleccione una categoria para agregar", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        Dim pregunta As DialogResult
        pregunta = MessageBox.Show("Desea dar de Alta este Predio ", "Insercion de Predio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pregunta = DialogResult.Yes Then
            For i = 0 To Me.lvwasisgnacion.Items.Count - 1
                clprediocategoria.CodPredio = Me.lvwasisgnacion.Items(i).SubItems(0).Text
                clprediocategoria.CodContenido = Me.lvwasisgnacion.Items(i).SubItems(1).Text
                clprediocategoria.Usuario = MdiPrincipal.tsbDniUsu.Caption
                clprediocategoria.ValorUnitario = Me.lvwasisgnacion.Items(i).SubItems(3).Text
                clprediocategoria.Depreciacion = Me.lvwasisgnacion.Items(i).SubItems(4).Text
                clprediocategoria.ValorDepreciado = Me.lvwasisgnacion.Items(i).SubItems(5).Text
                clprediocategoria.Area = Me.lvwasisgnacion.Items(i).SubItems(6).Text
                clprediocategoria.ValorConstruccion = Me.lvwasisgnacion.Items(i).SubItems(7).Text
                clprediocategoria.FechaEv = CStr(Now.Date)
                clprediocategoria.AltaAsignacion()
            Next
            For i = 0 To Me.lvwInstalaciones.Items.Count - 1
                clins.CodPredio = Me.lvwInstalaciones.Items(i).SubItems(0).Text
                clins.Instalacion = Me.lvwInstalaciones.Items(i).SubItems(1).Text
                clins.Valor = Me.lvwInstalaciones.Items(i).SubItems(2).Text
                clins.AltaIntalacion()
            Next

        End If

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.lvwCategoria.Items.Clear()
        Me.lvwasisgnacion.Items.Clear()
        Me.lblcodpredio.ResetText()
        Me.lblarea.ResetText()
        Me.lbldireccion.ResetText()
    End Sub
   
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        agregaItem()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        delOne()
    End Sub


    Sub delOne()
        If Me.lvwasisgnacion.SelectedItems.Count > 0 Then
            Me.lvwasisgnacion.Items.RemoveAt(Me.lvwasisgnacion.SelectedItems(0).Index)
        Else
            MessageBox.Show("No ha seleccionado el elemento a quitar", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        sumar()
    End Sub

    Sub sumar()
        Try
            Me.lblSumaCat.Text = "0.00"
            For i = 0 To lvwasisgnacion.Items.Count - 1
                Me.lblSumaCat.Text = Format(CDbl(Me.lblSumaCat.Text) + CDbl(lvwasisgnacion.Items(i).SubItems(7).Text), "#,#.#0")
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        EnviaPredio()
    End Sub


    Sub EscalaGridAsignacion()
        With lvwasisgnacion
            .Columns(2).Width = .Width - (.Columns(1).Width + .Columns(3).Width) - 5
            .Columns(3).Width = 100
        End With

    End Sub

    Private Sub FrmEvaluacionPredio_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        EscalaGridAsignacion()
    End Sub

    
    Private Sub lvwpredios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwpredios.SelectedIndexChanged

    End Sub

    Private Sub lvwpredios_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwpredios.SizeChanged

    End Sub

    Private Sub lvwpredios_StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwpredios.StyleChanged

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub FrmEvaluacionPredio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbConservacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConservacion.SelectedIndexChanged
        GetDatosdep()
    End Sub

    Private Sub cmbMaterial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMaterial.SelectedIndexChanged
        GetDatosdep()
    End Sub

    Private Sub lvwCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwCategoria.SelectedIndexChanged

    End Sub

    Private Sub btnai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnai.Click
        If Me.txtinstalacion.Text = "" Or Me.txtvalorsoles.Text = "" Or Me.lvwpredios.SelectedItems.Count = 0 Then
            MessageBox.Show("No ha ingresado la instalacion y/o el valor", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            c = Me.lvwInstalaciones.Items.Count
            Me.lvwInstalaciones.Items.Add(Me.lvwpredios.SelectedItems(0).SubItems(0).Text)
            Me.lvwInstalaciones.Items(c).SubItems.Add(Me.txtinstalacion.Text)
            Me.lvwInstalaciones.Items(c).SubItems.Add(CStr(Format(CDbl(Me.txtvalorsoles.Text), "#,##0.00")))
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvalorsoles.TextChanged

    End Sub
End Class