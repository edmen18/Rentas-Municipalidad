Imports Datos
Imports Reglas
Imports Reportes
Imports CrystalDecisions.CrystalReports.Engine.FormulaFieldDefinition


Public Class FrmRealizaVenta
    Dim FunDb As New cFuncionesDB
    Dim clventas As New Cl_Venta
    Dim cldetalleventa As New Cl_DetalleVenta
    Dim UIT As New Cl_uit
    Dim ENTIDAD As New Cl_Entidad
    Dim imp As New C_imprime
    Dim validar As New Cl_Validar
    Dim c As Integer
    Dim i As Integer


    '''Metodos

    Sub EscalaGrid()
        Me.lvwclase.Columns(1).Width = 0
        Me.lvwclase.Columns(1).Width = lvwclase.Width - (Me.lvwclase.Columns(0).Width + Me.lvwclase.Columns(2).Width + Me.lvwclase.Columns(4).Width)
        Me.Lvwdetalle_venta.Columns(1).Width = Lvwdetalle_venta.Width - (Lvwdetalle_venta.Columns(0).Width + Lvwdetalle_venta.Columns(2).Width + Lvwdetalle_venta.Columns(3).Width + Lvwdetalle_venta.Columns(4).Width)
    End Sub

    Sub LLenarComboclase()
        Dim csql As String = "select codforma,descripcion from t_formapago "
        FunDb.FillListaOrCombo(csql, cboformapago, "descripcion", "codforma")
    End Sub

    Sub LLenarCombogrupo()
        Dim csql As String = "SELECT numgru,desgru from t_grupo where annio='" + CStr(Now.Year) + "'"
        FunDb.FillListaOrCombo(csql, cbogrupo, "desgru", "numgru")
    End Sub

    Sub LlenaLstViewclase()
        Me.lvwclase.Items.Clear()
        Dim cSql As String = "SELECT numcla,descla,Valor,codtipo,TC.CODCTA,Porcentaje from t_clase TCL INNER JOIN T_CUENTA TC ON TC.CODCTA=TCL.CODCTA where numgru='" + Me.cbogrupo.SelectedValue.ToString + "' and descla like '%" + Me.txtclase.Text + "%' and tcl.annio='" + CStr(Now.Year) + "'"
        FunDb.FillListview(cSql, lvwclase)
    End Sub

    Sub validarVenta()
        txtuitmonto.ResetText()
        lbluitmonto.ResetText()
        If lbltiposervicio.Text = "1" Then
            txtuitmonto.Text = UIT.getValorActualUIT()
            lbluitmonto.Text = "Valor de la UIT"
            txtuitmonto.Enabled = False
            txtcantidad.Enabled = True
        ElseIf lbltiposervicio.Text = "2" Then
            txtuitmonto.Enabled = True
            txtcantidad.Enabled = False
            txtcantidad.Text = 0
            lbluitmonto.Text = "Valor del Proyecto"
            lblpreciounitario.Text = Me.lvwclase.SelectedItems(0).SubItems(5).Text
        ElseIf lbltiposervicio.Text = "3" Then
            txtuitmonto.Enabled = True
            lbluitmonto.Text = "Valor del Autovaluo"
        End If
    End Sub
  

    Sub limpiar()
        Me.LBLCODCTA.ResetText()
        Me.lblcodservicio.ResetText()
        Me.lbldescripcion.ResetText()
        Me.lblpreciounitario.ResetText()
        Me.txtcantidad.ResetText()
        Me.lbltiposervicio.ResetText()
        Me.lbluitmonto.Text = "Valor"
        Me.txtuitmonto.ResetText()
        Me.txtuitmonto.Enabled = False
    End Sub
    Sub sumar()
        c = 0
        Me.lbltotal.Text = "0.00"
        For Me.c = 0 To Me.Lvwdetalle_venta.Items.Count - 1
            Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.Lvwdetalle_venta.Items(c).SubItems(4).Text), "#,##0.00")
        Next
    End Sub

    Sub limpiaresto()
        Me.Lvwdetalle_venta.Items.Clear()
        Me.lblcod_venta.ResetText()
        Me.LBLCODCTA.ResetText()
        Me.lblcodigo_cli.ResetText()
        Me.lblnombre_cliente.ResetText()
        Me.lbldni.ResetText()
        Me.lblruc.ResetText()
        Me.lbltotal.ResetText()
        Me.cboformapago.Text = ""
        Me.lbltiposervicio.ResetText()
        Me.txtclase.ResetText()
        'Me.btnGrabar.Enabled = False
    End Sub
   
    Sub DesactivaControles()
        Me.cbogrupo.Enabled = False
        Me.cboformapago.Enabled = False
        Me.txtclase.Enabled = False
        Me.txtcantidad.Enabled = False
        Me.btnbuscar.Enabled = False
        Me.btnGrabar.Enabled = False
        Me.btnNuevo.Enabled = True
    End Sub

    Sub ActivaControles()
        Me.cbogrupo.Enabled = True
        Me.cboformapago.Enabled = True
        Me.txtclase.Enabled = True
        Me.txtcantidad.Enabled = True
        Me.btnbuscar.Enabled = True
        Me.btnGrabar.Enabled = True
        Me.btnNuevo.Enabled = False
    End Sub

    Sub grabarServicio()
        Me.clventas.CodVenta = Me.lblcod_venta.Text
        Me.clventas.CodCli = Me.lblcodigo_cli.Text
        Me.clventas.Monto = Val(Me.lbltotal.Text)
        Me.clventas.Fecha = CStr(Now.Date)
        Me.clventas.CodForma = Me.cboformapago.SelectedValue.ToString
        Me.clventas.Usuario = MdiPrincipal.tsbDniUsu.Caption

        If Me.clventas.AltaVenta() = True Then
            grabardetalleventa()
            reporte()
            limpiar()
            limpiaresto()
            DesactivaControles()
        End If
    End Sub
    Sub grabardetalleventa()
        Me.cldetalleventa.CodVenta = Me.lblcod_venta.Text
        For Me.i = 0 To Me.Lvwdetalle_venta.Items.Count - 1
            Me.cldetalleventa.Cantidad = CInt(Me.Lvwdetalle_venta.Items(i).SubItems(3).Text)
            Me.cldetalleventa.PrecioVenta = CDbl(Me.Lvwdetalle_venta.Items(i).SubItems(8).Text)
            Me.cldetalleventa.CodUit = CStr(Me.Lvwdetalle_venta.Items(i).SubItems(6).Text)
            Me.cldetalleventa.NumCla = CStr(Me.Lvwdetalle_venta.Items(i).SubItems(0).Text)
            Me.cldetalleventa.Subtotal = CDbl(Me.Lvwdetalle_venta.Items(i).SubItems(4).Text)
            Me.cldetalleventa.AltaDetalleVenta()
        Next
    End Sub
    Sub reporte()
        Dim cr As New Cr_Recibo
        cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + ENTIDAD.Nombre.ToString() + "'"
        cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + ENTIDAD.Ruc.ToString() + "'"
        imp.reporte(clventas.ImprimeRecibo(Me.lblcod_venta.Text), cr)
    End Sub

    Private Sub FrmRealizaVenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LLenarCombogrupo()
    End Sub

    Private Sub FrmRealizaVenta_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        EscalaGrid()
    End Sub


    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        FrmBuscarCliente.lblflag.Text = "1"
        FrmBuscarCliente.ShowDialog()
    End Sub

    Private Sub txtclase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtclase.TextChanged
        Me.txtclase.CharacterCasing = CharacterCasing.Upper
        LlenaLstViewclase()
    End Sub

    Private Sub lvwclase_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwclase.DoubleClick
        lblcodservicio.Text = Me.lvwclase.SelectedItems(0).SubItems(0).Text
        lbldescripcion.Text = Me.lvwclase.SelectedItems(0).SubItems(1).Text
        lblpreciounitario.Text = Me.lvwclase.SelectedItems(0).SubItems(2).Text
        lbltiposervicio.Text = Me.lvwclase.SelectedItems(0).SubItems(3).Text
        LBLCODCTA.Text = Me.lvwclase.SelectedItems(0).SubItems(4).Text
        validarVenta()
        Me.txtcantidad.Focus()
    End Sub

    Private Sub tsbAgregaItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregaItem.Click
        If Me.lblcodservicio.Text = "" Or Me.LBLCODCTA.Text = "" Or Me.lbldescripcion.Text = "" Or Me.txtcantidad.Text = "" Or Me.txtuitmonto.Text = "" Then
            MessageBox.Show("Complete los datos antes de continuar", "Facturar servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            c = Me.Lvwdetalle_venta.Items.Count
            Me.Lvwdetalle_venta.Items.Add(Me.lblcodservicio.Text)
            Me.Lvwdetalle_venta.Items(c).SubItems.Add(Me.lbldescripcion.Text)
            Me.Lvwdetalle_venta.Items(c).SubItems.Add(Me.lblpreciounitario.Text)
            Me.Lvwdetalle_venta.Items(c).SubItems.Add(Me.txtcantidad.Text)

            If Me.lbltiposervicio.Text = "1" Then

                Me.Lvwdetalle_venta.Items(c).SubItems.Add(CStr(Format(Val(Me.txtcantidad.Text) * ((Val(Me.lblpreciounitario.Text))), "#,##0.00")))
            Else
                Me.Lvwdetalle_venta.Items(c).SubItems.Add(CStr(Format(Val(Me.lblpreciounitario.Text) / 100 * ((Val(Me.txtuitmonto.Text))), "#,##0.00")))
            End If

            Me.Lvwdetalle_venta.Items(c).SubItems.Add(Me.lbltiposervicio.Text)
            Me.Lvwdetalle_venta.Items(c).SubItems.Add(UIT.CodigoUIT())
            Me.Lvwdetalle_venta.Items(c).SubItems.Add(Me.LBLCODCTA.Text)
            Me.Lvwdetalle_venta.Items(c).SubItems.Add(Format(Val(Me.lblpreciounitario.Text), "#,##0.00"))

            limpiar()
            sumar()
            Me.btngrabar.Enabled = True
        End If
    End Sub


    Private Sub tsbRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRemoveItem.Click
        If Me.Lvwdetalle_venta.SelectedItems.Count > 0 Then
            Me.Lvwdetalle_venta.Items.RemoveAt(Me.Lvwdetalle_venta.SelectedItems(0).Index)
            sumar()
        Else
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub tsbEditaItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEditaItem.Click
        Me.lblcodservicio.Text = Me.Lvwdetalle_venta.SelectedItems(0).SubItems(0).Text
        Me.lbldescripcion.Text = Me.Lvwdetalle_venta.SelectedItems(0).SubItems(1).Text
        Me.lblpreciounitario.Text = Me.Lvwdetalle_venta.SelectedItems(0).SubItems(2).Text
        Me.txtcantidad.Text = Me.Lvwdetalle_venta.SelectedItems(0).SubItems(3).Text

        Me.lbltiposervicio.Text = Me.Lvwdetalle_venta.SelectedItems(0).SubItems(5).Text
        Me.LBLCODCTA.Text = CStr(Me.Lvwdetalle_venta.SelectedItems(0).SubItems(7).Text)

        Me.Lvwdetalle_venta.Items.RemoveAt(Me.Lvwdetalle_venta.SelectedItems(0).Index)
        sumar()
        validarVenta()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiaresto()
        LLenarComboclase()
        Dim xCod As Integer = CInt(clventas.GeneraCodventa) + 1
        Me.lblcod_venta.Text = "R-" & Format(xCod, "00000000")
        ActivaControles()
        btnBuscar.Enabled = True
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        If Me.lbltotal.Text = "" Or Me.lblcodigo_cli.Text = "" Or Me.lblcod_venta.Text = "" Then
            MsgBox("Complete los datos antes de continuar", MsgBoxStyle.Critical)
        Else
            grabarServicio()
            btnBuscar.Enabled = False
        End If
    End Sub

   
    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        e.Handled = Validar.NumerosEnteros(System.Convert.ToInt16(Asc(e.KeyChar)))
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            tsbAgregaItem.PerformClick()
        End If
    End Sub

    Private Sub Lvwdetalle_venta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lvwdetalle_venta.KeyDown
        If e.KeyCode = Keys.Delete Then
            tsbRemoveItem.PerformClick()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        'limpiaresto()
        'limpiar()
        'DesactivaControles()
        'Me.lvwclase.Items.Clear()
    End Sub

    Private Sub txtuitmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuitmonto.KeyPress
        e.Handled = validar.NumerosEnteros(System.Convert.ToInt16(Asc(e.KeyChar)))

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            tsbAgregaItem.PerformClick()
        End If
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class