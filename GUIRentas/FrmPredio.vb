Imports Reglas
Imports Datos
Public Class FrmPredio
    Dim clpredio As New Cl_Predio
    Dim FunDb As New cFuncionesDB
    Dim EstiloGrid As New Cl_EstiloGrid
    Dim Validar As New Cl_Validar
    Dim flg As Integer = 0
    Dim contador As Integer = 0

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        FrmBuscarCliente.lblflag.Text = "3"
        FrmBuscarCliente.ShowDialog()
    End Sub

    Private Sub FrmPredio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LLenarCombogrupo()
        LLenarMaterial()
        LLenarEstadoConser()
        LLenarZona()
        LLenarCondicionPropiedad()
        LLenarEstadoConservacion()
        Me.btnBuscar.Enabled = True
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        LIMPIAR()
        Me.TabControl1.Enabled = True
        Me.lblcodpredio.Text = Format(CInt(clpredio.GeneraCodpredio) + 1, "0000000000")
        Me.btnBuscar.Enabled = True
        btnNuevo.Enabled = False
        btnGrabar.Enabled = True

    End Sub
    Sub LLenarCombogrupo()
        Dim csql As String = "SELECT CODTIPOEDIFICACION,DESCRIPCION from t_TIPOEDIFICACION "
        FunDb.FillListaOrCombo(csql, cmbTipoConstruccion, "DESCRIPCION", "CODTIPOEDIFICACION")
    End Sub

    Sub LLenarMaterial()
        Dim csql As String = "SELECT CodMaterial,Descripcion from T_Material "
        FunDb.FillListaOrCombo(csql, cmbMaterial, "Descripcion", "CodMaterial")
    End Sub

    Sub LLenarEstadoConser()
        Dim csql As String = "SELECT CodEstado,Estado from T_EstadoConservacion "
        FunDb.FillListaOrCombo(csql, cmbConservacion, "Estado", "CodEstado")
    End Sub

    Sub LLenarZona()
        Dim csql As String = "SELECT CodZona,Nombre from T_Zona"
        FunDb.FillListaOrCombo(csql, cmbZona, "Nombre", "CodZona")
    End Sub

    Sub LLenarCondicionPropiedad()
        Dim csql As String = "SELECT CodCondPro,Condicion from T_CondicionPropiedad "
        FunDb.FillListaOrCombo(csql, cmbCondicion, "Condicion", "CodCondPro")
    End Sub

    Sub LLenarEstadoConservacion()
        Dim csql As String = "SELECT CodEstado,Estado from T_EstadoConservacion "
        FunDb.FillListaOrCombo(csql, cmbConservacion, "Estado", "CodEstado")
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        If Me.lblcodpredio.Text = "" Or Me.lblcodigocliente.Text = "" Or Me.txtarea.Text = "" Or Me.txtdireccion.Text = "" Or Me.cmbDireccion.Text = "" Or Me.cmbSituacion.Text = "" Or Me.cmbTipoConstruccion.Text = "" Then
            MessageBox.Show("Complete los Datos antes de continuar", "Predio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If Me.txtnumero.Text = "" Then
                Me.txtnumero.Text = "0"
            End If
            If Me.txtlote.Text = "" Then
                Me.txtlote.Text = "0"
            End If
            clpredio.AreaTotal = CDbl(Me.txtareatotal.Text)
            clpredio.CodPredio = Me.lblcodpredio.Text
            clpredio.Direccion = Me.cmbDireccion.Text + " " + Me.txtdireccion.Text
            clpredio.Manzana = Me.txtmanzana.Text
            clpredio.Numero = CInt(Me.txtnumero.Text)
            clpredio.Lote = Me.txtlote.Text
            clpredio.FechaConstruccion = CStr(Me.dtFechaConst.Value.Date)
            clpredio.CodTipoEdificacion = Me.cmbTipoConstruccion.SelectedValue.ToString
            clpredio.NumeroPisos = CInt(Me.nudPisos.Value.ToString)
            clpredio.CodCli = Me.lblcodigocliente.Text
            clpredio.Area = CDbl(Me.txtarea.Text)
            clpredio.Situacion = Me.cmbSituacion.Text
            clpredio.Material = Me.cmbMaterial.SelectedValue.ToString
            clpredio.Conservacion = Me.cmbConservacion.SelectedValue.ToString
            clpredio.FechaAdq = CStr(Me.DtfechaAdq.Value.Date)
            clpredio.Zona = Me.cmbZona.SelectedValue.ToString
            clpredio.CondicionPropiedad = Me.cmbCondicion.SelectedValue.ToString
            If chkEstado.Checked = True Then
                clpredio.EstadoPredio = "1"
            Else
                clpredio.EstadoPredio = "0"
            End If

            If Me.flg = 0 Then
                clpredio.AltaPredio()
            Else
                clpredio.ModificarPredio(Me.lblcodpredio.Text)
            End If
        End If
        btnNuevo.Enabled = True
        btnGrabar.Enabled = False
        getDatos()
        flg = 0
        Me.btnCancelar.PerformClick()
    End Sub
    Sub LIMPIAR()
        Me.cmbDireccion.Text = ""
        Me.txtdireccion.ResetText()
        Me.txtnumero.ResetText()
        Me.txtmanzana.ResetText()
        Me.txtlote.ResetText()
        Me.cmbTipoConstruccion.Text = ""
        Me.cmbSituacion.Text = ""
        Me.lblcodigocliente.ResetText()
        Me.lblruc.ResetText()
        Me.lbldni.ResetText()
        Me.lblDescripcion.ResetText()
        Me.nudPisos.ResetText()
        Me.txtarea.ResetText()

    End Sub
    
    Sub encabezadosGrid()
        DgvPredios.Columns(0).HeaderText = "Predio"
        DgvPredios.Columns(0).Width = 100
        DgvPredios.Columns(1).HeaderText = "Dirección"
        DgvPredios.Columns(1).Width = 360
        DgvPredios.Columns(2).HeaderText = "Area"
        DgvPredios.Columns(2).Width = 100
    End Sub

    Sub getDatos()
        Try
            Dim csql As String = "select codpredio,direccion+' Nª '+numero+' Mz ' +manzana+' Lt '+lote as direccion, area from t_predio where codcli='" + Me.lblcodigocliente.Text + "' "
            FunDb.FillDataGridView(csql, Me.DgvPredios)
            EstiloGrid.AplicaStiloBlue(DgvPredios)
            encabezadosGrid()
        Catch ex As Exception
        End Try
    End Sub
    Sub GETEVALUACION()
        Try
            Dim csql As String = "select CODCONTENIDO FROM t_predio_contenido where codpredio='" + Me.lblcodpredio.Text + "' "
            FunDb.FillListview(csql, Me.ListView1)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        LIMPIAR()
        btnNuevo.Enabled = True
        btnGrabar.Enabled = False
        Me.flg = 0
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub lblcodigocliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblcodigocliente.TextChanged
        getDatos()
    End Sub

    Private Sub txtdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.TextChanged
        Me.txtdireccion.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtnumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumero.KeyPress
        e.Handled = Validar.NumerosEnteros(System.Convert.ToInt16(Asc(e.KeyChar)))
    End Sub

    Private Sub txtarea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtarea.KeyPress
        e.Handled = Validar.NumerosDecimales(System.Convert.ToInt16(Asc(e.KeyChar)))
    End Sub
 
    Private Sub txtmanzana_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmanzana.TextChanged
        Me.txtmanzana.CharacterCasing = CharacterCasing.Upper
    End Sub
    Sub GetDatosPredio(ByVal codpredio As String)
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "select codpredio,Direccion,Numero,Manzana,Lote,FechaConstruccion,FechaAdquisicion,Area,AreaTotal,predio.codzona,zona.nombre,Situacion,predio.CodCondPro,condicion.condicion,predio.CodMaterial, material.Descripcion,predio.CodTipoEdificacion,tipoedificacion.Descripcion,predio.CodEstado,estado.Estado,EstadoPredio,numeropisos from dbo.T_Predio predio inner join t_zona zona on zona.codzona=predio.codzona inner join dbo.T_CondicionPropiedad condicion on condicion.codcondpro=predio.CodCondPro inner join dbo.T_Material material on material.CodMaterial=predio.CodMaterial inner join dbo.T_TipoEdificacion tipoedificacion on tipoedificacion.CodTipoEdificacion=predio.CodTipoEdificacion inner join dbo.T_EstadoConservacion estado on estado.CodEstado=predio.CodEstado where codpredio='" + codpredio + "'"
            dt = cFun.ConsultaX(csql)
            Me.lblcodpredio.Text = CStr(dt.Rows(0).Item(0))
            Dim IND As Integer = CStr(dt.Rows(0).Item(1)).IndexOf(" ")
            Me.cmbDireccion.Text = Microsoft.VisualBasic.Left(CStr(dt.Rows(0).Item(1)), IND)
            Me.txtdireccion.Text = Trim(CStr(dt.Rows(0).Item(1)).Substring(IND, CStr(dt.Rows(0).Item(1)).Length - IND))
            Me.txtnumero.Text = CStr(dt.Rows(0).Item(2))
            Me.txtmanzana.Text = CStr(dt.Rows(0).Item(3))
            Me.txtlote.Text = CStr(dt.Rows(0).Item(4))
            Me.dtFechaConst.Text = CStr(dt.Rows(0).Item(5))
            Me.DtfechaAdq.Text = CStr(dt.Rows(0).Item(6))
            Me.txtarea.Text = CStr(dt.Rows(0).Item(7))
            Me.txtareatotal.Text = (dt.Rows(0).Item(8))
            Me.cmbZona.SelectedValue = CStr(dt.Rows(0).Item(9))
            Me.cmbZona.Text = CStr(dt.Rows(0).Item(10))
            Me.cmbSituacion.Text = CStr(dt.Rows(0).Item(11))
            Me.cmbCondicion.SelectedValue = CStr(dt.Rows(0).Item(12))
            Me.cmbCondicion.Text = CStr(dt.Rows(0).Item(13))
            Me.cmbMaterial.SelectedValue = CStr(dt.Rows(0).Item(14))
            Me.cmbMaterial.Text = CStr(dt.Rows(0).Item(15))
            Me.cmbTipoConstruccion.SelectedValue = CStr(dt.Rows(0).Item(16))
            Me.cmbTipoConstruccion.Text = CStr(dt.Rows(0).Item(17))
            Me.cmbConservacion.SelectedValue = CStr(dt.Rows(0).Item(18))
            Me.cmbConservacion.Text = CStr(dt.Rows(0).Item(19))
            Me.nudPisos.Value = CInt(dt.Rows(0).Item(21))
            If CStr(dt.Rows(0).Item(20)) > 0 Then
                Me.chkEstado.Checked = True
            Else
                Me.chkEstado.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub DgvPredios_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvPredios.CellDoubleClick
        Me.btnGrabar.Enabled = True
        GETEVALUACION()
    End Sub
    Private Sub DgvPredios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvPredios.DoubleClick
        If Me.DgvPredios.RowCount > 0 Then
            GetDatosPredio(DgvPredios.Item(0, DgvPredios.CurrentRow.Index).Value)
            Me.flg = 1
        End If
    End Sub
    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click

        For i = 0 To Me.ListView1.Items.Count - 1
            contador = contador + 1
        Next
        If contador = 0 Then
            Me.clpredio.EliminarPredio(Me.lblcodpredio.Text)
        Else
            MessageBox.Show("Error Eliminar Predio" + " " + "No es posible eliminar el predio debido a que ya fue evaluado y/o declarado", "Predio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.btnCancelar.PerformClick()
        contador = 0
        Me.ListView1.Items.Clear()
    End Sub

   
    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub DgvPredios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvPredios.CellContentClick

    End Sub
End Class