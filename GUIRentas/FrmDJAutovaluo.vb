Imports Reglas
Imports Datos
Imports Reportes
Public Class FrmDJAutovaluo
    Dim FunDb As New cFuncionesDB
    Dim validar As New Cl_Validar
    Dim var As New variables
    Dim CLDJ As New Cl_DeclaracionJurada
    Dim CLDDJ As New Cl_DetalleDJ
    Dim IMP As New C_imprime
    Dim Entidad As New Cl_Entidad
    Dim clpago As New Cl_Pagos
    Dim c As Integer
    Dim categoria As String
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        LLenarCombo()
        FrmBuscarCliente.lblflag.Text = "5"
        FrmBuscarCliente.ShowDialog()
        LLenarmotivo()
    End Sub

    Private Sub FrmDJAutovaluo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblcoddj.Text = Format(CInt(CLDJ.GeneraCoddj) + 1, "0000000000")
        GetDatosuit()
        LlenaLstViewTrimestres()
    End Sub
    '*********************** FUNCIONES *****************************
    Sub calcularpago() 'para calcular el pago total  del autovaluo
        Me.lblpagototal.Text = "0.00"
        If Chkmontomin.Checked = True Then
            Try
                Dim dt As New DataTable
                Dim dt1 As New DataTable
                Dim cFun As New cFuncionesDB
                Dim csql As String = "SELECT valor from t_uit where estado='A'"
                dt = cFun.ConsultaX(csql)
                Dim csqls As String = "select valor from t_montominimo"
                dt1 = cFun.ConsultaX(csqls)
                Me.lblpagototal.Text = CStr(CDbl(dt.Rows(0).Item(0)) * (CDbl(dt1.Rows(0).Item(0)) / 100))
            Catch ex As Exception
                MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            If CDbl(Me.lblbaseimponible.Text) <= CDbl(Me.lbl15uit.Text) Then
                Me.lblpagototal.Text = CDbl(Me.lblbaseimponible.Text) * 0.002
                Me.lblpagototal.Text = CStr(CDbl(Me.lblpagototal.Text) / 4)
            ElseIf CDbl(Me.lblbaseimponible.Text) > CDbl(Me.lbl15uit.Text) And CDbl(Me.lblbaseimponible.Text) <= CDbl(Me.lblmas15uit.Text) Then
                Me.lblpagototal.Text = CStr(CDbl(Me.lbl15uit.Text) * 0.002)
                Me.lblpagototal.Text = CStr(CDbl(Me.lblpagototal.Text) + ((CDbl(Me.lblbaseimponible.Text) - CDbl(Me.lbl15uit.Text)) * 0.006))
                Me.lblpagototal.Text = CStr(CDbl(Me.lblpagototal.Text) / 4)
            ElseIf CDbl(Me.lblbaseimponible.Text) > CDbl(Me.lblmas15uit.Text) And CDbl(Me.lblbaseimponible.Text) >= CDbl(Me.lbl60uit.Text) Then
                Me.lblpagototal.Text = CStr(CDbl(Me.lbl15uit.Text) * 0.002)
                Me.lblpagototal.Text = CStr(CDbl(Me.lblpagototal.Text) + (CDbl(Me.lblmas15uit.Text) * 0.006))
                Me.lblpagototal.Text = CStr(CDbl(Me.lblpagototal.Text) + ((CDbl(Me.lblbaseimponible.Text) - (CDbl(Me.lblmas15uit.Text) + CDbl(Me.lbl15uit.Text))) * 0.01))
                Me.lblpagototal.Text = CStr(CDbl(Me.lblpagototal.Text) / 4)
            End If
        End If
    End Sub
    Sub GetDatosuit() ' para filtar los valores de la uit segun 15, 60 o mas de 60 uit 
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "SELECT valor from t_uit where estado='A'"
            dt = cFun.ConsultaX(csql)
            Me.lbl15uit.Text = CStr(CDbl(dt.Rows(0).Item(0)) * 15)
            Me.lblmas15uit.Text = CStr(CDbl(dt.Rows(0).Item(0)) * 60)
            Me.lbl60uit.Text = CStr(CDbl(dt.Rows(0).Item(0)) * 61)
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub GetDatosPredio(ByVal codigoCliente As String)
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "SELECT TP.CODPREDIO,Nombre, CONDICION,Descripcion,SITUACION,Direccion+''+Numero+''+Manzana+''+Lote AS DIRECICION,MANZANA, LOTE,CONVERT(VARCHAR(10),FECHAADQUISICION,103)AS FECHAADQ,NUMERO FROM T_PREDIO TP INNER JOIN T_CONDICIONPROPIEDAD TCP ON TCP.CODCONDPRO=TP.CODCONDPRO INNER JOIN T_TIPOEDIFICACION TTE  ON TP.CODTIPOEDIFICACION=TTE.CODTIPOEDIFICACION INNER JOIN T_ZONA AS TZ ON TZ.CODZONA=TP.CODZONA WHERE ESTADOPREDIO='1' AND CODCLI='" + Me.lblcodigocliente.Text + "'"
            dt = cFun.ConsultaX(csql)
            var._codPredio = CStr(dt.Rows(0).Item(0))
            var._nombre = CStr(dt.Rows(0).Item(1))
            var._condicion = CStr(dt.Rows(0).Item(2))
            var._descripcion = CStr(dt.Rows(0).Item(3))
            var._situacion = CStr(dt.Rows(0).Item(4))
            var._direccion = CStr(dt.Rows(0).Item(5))
            var._manzana = CStr(dt.Rows(0).Item(6))
            var._lote = CStr(dt.Rows(0).Item(7))
            var._fechAdq = CStr(dt.Rows(0).Item(8))
            var._numero = CStr(dt.Rows(0).Item(9))
        Catch ex As Exception
            'MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Sub LlenaLstViewPredio() ' LLENAMOS LA LISTA DE PREDIOS SEGUN EL CLIENTE Y EL TIPO DE CONSTRUCCION 
        Me.lvwpredios.Items.Clear()
        Dim cSql As String = "select codpredio,direccion+' Nª'+numero+' Mz' +manzana+' Lt'+lote as direccion, convert(numeric(9,2),areatotal)as area,convert (int,year(getdate()))-convert(int,year(fechaconstruccion)) as antiguedad,codmaterial,codestado from t_predio where codcli='" + Me.lblcodigocliente.Text + "'AND codtipoedificacion='" + Me.cbmtipoconstruccion.SelectedValue.ToString + "'"
        FunDb.FillListview(cSql, lvwpredios)
        'validar.colorearListView(lvwpredios)
    End Sub
    Sub LlenaLstViewTrimestres() 'LLENAMOS LA LISTA DE TRIMESTRES 
        Me.LvwTrimestres.Items.Clear()
        Dim cSql As String = "select CODTRIMESTRE,NUMERO,CONVERT (CHAR(10),FECHVENC,103)AS FECHA FROM T_TRIMESTRES WHERE ESTADO='1' order by numero"
        FunDb.FillListview(cSql, LvwTrimestres)
        'validar.colorearListView(LvwTrimestres)
    End Sub
    Sub LlenaLstViewdetallePredio() ' LLENAMOS LA LISTA DE DETALLE DE PEDIO CON LAS CATEGORIAS
        Me.lvwdetalle.Items.Clear()
        Dim cSql As String = "select tp.CodPredio,CodIngresado+' '+CodDenominacion as categoria,ValorUnitario,Depreciacion,ValorDepreciado,tpc.Area,ValorConstruccion from dbo.T_predio tp inner join t_predio_contenido tpc  on tp.codpredio=tpc.codpredio inner join t_contenidos tc  on tc.codcontenido=tpc.codcontenido where tp.codpredio='" + Me.lvwpredios.SelectedItems(0).SubItems(0).Text + "'"
        FunDb.FillListview(cSql, lvwdetalle)
        'validar.colorearListView(lvwdetalle)
    End Sub

    Sub LLenarCombo() ' CARGAMOS EL COMBO CON EL TIPO DE EDIFICACION 
        Dim csql As String = "SELECT codtipoedificacion,descripcion from t_tipoedificacion "
        FunDb.FillListaOrCombo(csql, cbmtipoconstruccion, "descripcion", "codtipoedificacion")
    End Sub

    Sub LLenarmotivo() ' CARGAMOS EL COMBO CON EL motivo de la declaración
        Dim csql As String = "SELECT codmotivo,descripcion from t_motivodj where estado='1'"
        FunDb.FillListaOrCombo(csql, cmbmotivo, "descripcion", "codmotivo")
    End Sub
    Sub SUMAR() ' OBTENER EL VALOR VUNIT DE CADA PREDIO 
        Me.lblvunit.Text = "0.00"
        For i = 0 To Me.lvwdetalle.Items.Count - 1
            Me.lblvunit.Text = CStr(Format(CDbl(Me.lblvunit.Text) + CDbl(Me.lvwdetalle.Items(i).SubItems(2).Text), "#,##0.00"))
        Next
    End Sub
    Sub VALORDEPR() ' PARA OBTENER EL VALOR DE LA DEPRECIACION SEGUN EL TIPO DE CONSTRUCCION
        'Me.LBLDEPRECIACION.Text = CLDJ.PorcentajeDepreciacion(Me.cbmtipoconstruccion.SelectedValue.ToString, Me.lvwpredios.SelectedItems(0).SubItems(4).Text, Me.lvwpredios.SelectedItems(0).SubItems(5).Text, CInt(Me.lvwpredios.SelectedItems(0).SubItems(3).Text))
    End Sub
    Sub CALCULAR() ' PARA CALCULAR EL VALOR DE UNA PROPIEDAD 
        Me.lblmontod.Text = "0.00"
        Me.LBLVUD.Text = "0.00"
        Me.LBLVALOR.Text = "0.00"
        For i = 0 To Me.lvwdetalle.Items.Count - 1
            Me.lblmontod.Text = CStr(Format((CDbl(Me.lblmontod.Text) + CDbl(Me.lvwdetalle.Items(i).SubItems(3).Text)), "#,##0.00"))
            Me.LBLVUD.Text = CStr(Format((CDbl(Me.LBLVUD.Text) + CDbl(Me.lvwdetalle.Items(i).SubItems(4).Text)), "#,##0.00"))
            Me.LBLVALOR.Text = CStr(Format((CDbl(Me.LBLVALOR.Text) + CDbl(Me.lvwdetalle.Items(i).SubItems(6).Text)), "#,##0.00"))
        Next

    End Sub
    Sub categorias() ' PARA CONCATENAR LAS CATEGORIAS 
        For i = 0 To Me.lvwdetalle.Items.Count - 1
            If categoria = "" Then
                categoria = categoria & "" & Me.lvwdetalle.Items(i).SubItems(1).Text
            Else
                categoria = categoria & "," & Me.lvwdetalle.Items(i).SubItems(1).Text
            End If
        Next
    End Sub
    Sub calculartotal() ' para calcular el monto total y final de la declaración jurada
        Me.lblareatotal.Text = "0.00"
        Me.lblvalorconstruccion.Text = "0.00"
        For i = 0 To Me.LvwDetalleDj.Items.Count - 1
            Me.lblareatotal.Text = Format(CDbl(Me.lblareatotal.Text) + CDbl(Me.LvwDetalleDj.Items(i).SubItems(7).Text), "#,##0.00")
            Me.lblvalorconstruccion.Text = Format(CDbl(Me.lblvalorconstruccion.Text) + (Me.LvwDetalleDj.Items(i).SubItems(6).Text), "#,##0.00")
        Next
        Me.lblvalorarancel.Text = Format(CDbl(Me.lblarancel.Text) * CDbl(Me.lblareatotal.Text), "#,##0.00")
        Dim base_imp As Double
        base_imp = CDbl(Me.lblvalorconstruccion.Text) + CDbl(Me.lblvalorarancel.Text)
        Me.lblbaseimponible.Text = Format(base_imp, "#,##0.00")
    End Sub
    '****************************++ FIN FUNCIONES ******************************+

    Private Sub cbmtipoconstruccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbmtipoconstruccion.SelectedIndexChanged
        LlenaLstViewPredio()
        Me.lblarancel.Text = CLDJ.Mostrar_Arancel(Me.cbmtipoconstruccion.SelectedValue.ToString)
        Me.lblcodarancel.Text = CLDJ.Mostrar_codgoarancel(Me.cbmtipoconstruccion.SelectedValue.ToString)
    End Sub

    Private Sub lvwpredios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwpredios.DoubleClick
        If filtrarultimoannio() = True Then
            LlenaLstViewdetallePredio()
            SUMAR()
            CALCULAR()

        End If
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click

        If Me.lblvunit.Text = "" Or Me.LBLVUD.Text = "" Or Me.lblmontod.Text = "" Or Me.LBLVALOR.Text = "" Then
            MessageBox.Show("Complete los Datos antes de continuar", " Registro de Declaración Jurada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim contador As Integer = 0
            For i = 0 To Me.LvwDetalleDj.Items.Count - 1
                If Me.LvwDetalleDj.Items(i).SubItems(0).Text = Me.lvwpredios.SelectedItems(0).SubItems(0).Text Then
                    contador = contador + 1
                End If
            Next
            If contador = 0 Then
                c = Me.LvwDetalleDj.Items.Count
                Me.LvwDetalleDj.Items.Add(Me.lvwpredios.SelectedItems(0).SubItems(0).Text)
                categorias()
                Me.LvwDetalleDj.Items(c).SubItems.Add(categoria)
                Me.LvwDetalleDj.Items(c).SubItems.Add(Me.lblvunit.Text)
                Me.LvwDetalleDj.Items(c).SubItems.Add("")
                Me.LvwDetalleDj.Items(c).SubItems.Add(Me.lblmontod.Text)
                Me.LvwDetalleDj.Items(c).SubItems.Add(Me.LBLVUD.Text)
                Me.LvwDetalleDj.Items(c).SubItems.Add(Me.LBLVALOR.Text)
                Me.LvwDetalleDj.Items(c).SubItems.Add(Me.lvwpredios.SelectedItems(0).SubItems(2).Text)
                categoria = ""
                calculartotal()
                calcularpago()
            Else
                MsgBox("El predio ya fue Evaluado", MsgBoxStyle.Critical)
            End If
            contador = 0
        End If

    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If Me.lblbaseimponible.Text = "" Or Me.lblareatotal.Text = "" Or Me.lblvalorconstruccion.Text = "" Or Me.lblvalorarancel.Text = "" Or Me.lblpagototal.Text = "" Or Me.LvwDetalleDj.Items.Count = 0 Then
            MessageBox.Show("Complete los Datos antes de continuar", " Registro de Declaración Jurada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.CLDJ.CodDJ = Me.lblcoddj.Text
            Me.CLDJ.Annio = CStr(Now.Year)
            Me.CLDJ.CodArancel = Me.lblcodarancel.Text
            Me.CLDJ.ValorConstruccon = CDbl(Me.lblvalorconstruccion.Text)
            Me.CLDJ.ValorArancel = CDbl(Me.lblarancel.Text)
            Me.CLDJ.MontoArancel = CDbl(Me.lblvalorarancel.Text)
            Me.CLDJ.BaseImponible = CDbl(Me.lblbaseimponible.Text)
            Me.CLDJ.AreaTotal = CDbl(Me.lblareatotal.Text)
            Me.CLDJ.FechaEmision = CStr(Now.Date)
            Me.CLDJ.Motivo = Me.cmbmotivo.SelectedValue.ToString
            Me.CLDJ.ImpuestoAnual = CDbl(Me.lblpagototal.Text) * 4
            If Me.Chkmontomin.Checked = True Then
                Me.CLDJ.Indicador = "1"
            Else
                Me.CLDJ.Indicador = "0"
            End If
            Me.CLDJ.Usuario = MdiPrincipal.tsbDniUsu.Caption
            If Me.CLDJ.AltaDJ = True Then
                For i = 0 To Me.LvwDetalleDj.Items.Count - 1
                    Me.CLDDJ.CodDj = Me.lblcoddj.Text
                    Me.CLDDJ.CodPredio = Me.LvwDetalleDj.Items(i).SubItems(0).Text
                    Me.CLDDJ.Categorias = Me.LvwDetalleDj.Items(i).SubItems(1).Text
                    Me.CLDDJ.Vunit = CDbl(Me.LvwDetalleDj.Items(i).SubItems(2).Text)
                    Me.CLDDJ.Depr = CDbl(Me.LvwDetalleDj.Items(i).SubItems(3).Text)
                    Me.CLDDJ.MontoD = CDbl(Me.LvwDetalleDj.Items(i).SubItems(4).Text)
                    Me.CLDDJ.Vud = CDbl(Me.LvwDetalleDj.Items(i).SubItems(5).Text)
                    Me.CLDDJ.ValorConstruccion = CDbl(Me.LvwDetalleDj.Items(i).SubItems(6).Text)
                    Me.CLDDJ.AreaConstruida = CDbl(Me.LvwDetalleDj.Items(i).SubItems(7).Text)
                    Me.CLDDJ.AltadetalleDJ()
                Next
                For i = 0 To Me.LvwTrimestres.Items.Count - 1
                    Me.clpago.CodTrimestre = Me.LvwTrimestres.Items(i).SubItems(0).Text
                    Me.clpago.CodDj = Me.lblcoddj.Text
                    Me.clpago.Monto = CDbl(Me.lblpagototal.Text)
                    Me.clpago.Estado = "D"
                    Me.clpago.CodPago = Format(CInt(clpago.GeneraCodPago()) + 1, "0000000000")
                    Me.clpago.AltaPago()
                Next
            End If
        End If
    End Sub


    Private Sub Btnpu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnpu.Click
        Dim cr As New Cr_PU
        cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre.ToString() + "'"
        cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc.ToString() + "'"

        cr.DataDefinition.FormulaFields.Item("CODPREDIO").Text = "'" + var._codPredio + "'"
        cr.DataDefinition.FormulaFields.Item("ZONA").Text = "'" + var._nombre + "'"
        cr.DataDefinition.FormulaFields.Item("TIPO_EDIFICACION").Text = "'" + var._descripcion + "'"
        cr.DataDefinition.FormulaFields.Item("CONDICION").Text = "'" + var._condicion + "'"
        cr.DataDefinition.FormulaFields.Item("SITUACION").Text = "'" + var._situacion + "'"
        cr.DataDefinition.FormulaFields.Item("DIRECCION").Text = "'" + var._direccion + "'"
        cr.DataDefinition.FormulaFields.Item("MANZANA").Text = "'" + var._manzana + "'"
        cr.DataDefinition.FormulaFields.Item("NUMERO").Text = "'" + var._lote + "'"
        cr.DataDefinition.FormulaFields.Item("FECHAADQ").Text = "'" + var._fechAdq + "'"
        cr.DataDefinition.FormulaFields.Item("NUMEROCASA").Text = "'" + var._numero + "'"
        IMP.reporte(CLDJ.ImprimePU(Me.lblcodigocliente.Text, Me.lblcoddj.Text), cr)
    End Sub

    Private Sub BtnHR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHR.Click
        Dim cr As New Cr_HR
        cr.DataDefinition.FormulaFields.Item("Entidad").Text = "'" + Entidad.Nombre.ToString() + "'"
        cr.DataDefinition.FormulaFields.Item("Ruc").Text = "'" + Entidad.Ruc.ToString() + "'"

        cr.DataDefinition.FormulaFields.Item("Arancel").Text = "'" + CStr(CDbl(Me.lblarancel.Text)) + "'"
        cr.DataDefinition.FormulaFields.Item("ImpTrimestral").Text = "'" + CStr(CDbl(Me.lblpagototal.Text)) + "'"
        For i = 0 To Me.LvwTrimestres.Items.Count - 1
            If i = 0 Then
                cr.DataDefinition.FormulaFields.Item("Trim1").Text = "'" + Me.LvwTrimestres.Items(i).SubItems(2).Text + "'"
            End If
            If i = 1 Then
                cr.DataDefinition.FormulaFields.Item("Trim2").Text = "'" + Me.LvwTrimestres.Items(i).SubItems(2).Text + "'"
            End If
            If i = 2 Then
                cr.DataDefinition.FormulaFields.Item("Trim3").Text = "'" + Me.LvwTrimestres.Items(i).SubItems(2).Text + "'"
            End If
            If i = 3 Then
                cr.DataDefinition.FormulaFields.Item("Trim4").Text = "'" + Me.LvwTrimestres.Items(i).SubItems(2).Text + "'"
            End If
        Next
        IMP.reporte(CLDJ.ImprimeHR(Me.lblcodigocliente.Text, Me.lblcoddj.Text), cr)
    End Sub

    Private Sub Chkmontomin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkmontomin.CheckedChanged
        Me.lblpagototal.Text = "0.00"
        Try
            Dim dt As New DataTable
            Dim dt1 As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "SELECT valor from t_uit where estado='A'"
            dt = cFun.ConsultaX(csql)
            Dim csqls As String = "select valor from t_montominimo"
            dt1 = cFun.ConsultaX(csqls)
            Me.lblpagototal.Text = CStr(CDbl(dt.Rows(0).Item(0)) * (CDbl(dt1.Rows(0).Item(0)) / 100))
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Function filtrarultimoannio() As Boolean
        Dim annio As Integer
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "select top (1) annio from dbo.T_DetalleDJ tddj inner join dbo.T_DJAutovaluo tda on tda.coddj=tddj.coddj where codpredio='" + Me.lvwpredios.SelectedItems(0).SubItems(0).Text + "' order by annio desc"
            dt = cFun.ConsultaX(csql)
            annio = CInt(dt.Rows(0).Item(0))
        Catch ex As Exception
            'MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        If annio = Now.Year Then
            MessageBox.Show("Este Predio ya fue declarado en el presente año", " Consulta de Predios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
        annio = 0
    End Function

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If Me.LvwDetalleDj.SelectedItems.Count > 0 Then
            Me.LvwDetalleDj.Items.RemoveAt(Me.LvwDetalleDj.SelectedItems(0).Index)
        Else
            MessageBox.Show("Seleccione un elemento de la lista", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub lvwpredios_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvwpredios.DragOver

    End Sub

    Private Sub lvwpredios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwpredios.SelectedIndexChanged

    End Sub
End Class