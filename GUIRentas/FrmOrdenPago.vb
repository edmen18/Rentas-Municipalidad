Imports Datos
Imports Reglas
Imports Reportes
Public Class FrmOrdenPago
    Dim coyp As New Cl_Orden_Pago
    Dim clop As New Cl_OrdenPago
    Dim cldop As New Cl_DetalleOrden
    Dim FunDb As New cFuncionesDB
    Dim cimp As New C_imprime
    Dim cdatos As New Cl_DatosDetalle
    Dim clentidad As New Cl_Entidad
    Dim dias As Integer ' para obtener el número de dias antes de emitir la Orden de pago.
    Dim c As Integer   ' PARA CAPTURAR EL INDICE DE LA LISTA
    Dim FLAG As Integer = 0   'PARA 
    Dim d As Integer ''para obtener el nmero de item de la lista de detalles uit , fr,tim
    Dim EstiloView As New Cl_EstiloListView
    Dim EstiloGrid As New Cl_EstiloGrid

    Private Sub FrmOrdenPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblorden.Text = Format(CInt(clop.GeneraOrden()) + 1, "00000000")
        GetDatosuit()
    End Sub
    '**********************funciones para obtener los detalles de la orden de pago uit factores reajuste y tim
    Sub ultimadj()
        Try
            Me.lblfechadj.ResetText()
            Me.lblcoddj.ResetText()
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "select top(1)tdj.coddj,convert(char(10),fechaemision,103)as fecha from t_djautovaluo tdj inner join t_detalledj tddj on tddj.coddj=tdj.coddj inner join t_predio tpre on tpre.codpredio=tddj.codpredio inner join t_cliente tc on tc.codcli=tpre.codcli where tc.codcli='" + Me.lblcodigocliente.Text + "' order by fechaemision  desc"
            dt = cFun.ConsultaX(csql)
            Me.lblcoddj.Text = CStr(dt.Rows(0).Item(0))
            Me.lblfechadj.Text = CStr(dt.Rows(0).Item(1))
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Sub DatosDetalle()
        Dim i As Integer
        Dim j As Integer
        d = Me.Lvwdetalles.Items.Count
        For i = 0 To Me.DgvTrimestres.RowCount - 1
            'para obtener uit
            Dim dtuit As New DataTable
            Try
                Dim cFun As New cFuncionesDB
                Dim csql As String = "SELECT valor from t_uit where Año='" + CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year) + "'"
                dtuit = cFun.ConsultaX(csql)
            Catch ex As Exception
                MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            'fin para obtener uit

            'para obtener reajuste
            Dim dtreajuste As New DataTable
            Try
                Dim cFun As New cFuncionesDB
                Dim csql As String = "SELECT mensual from t_factoreajuste where datepart(mm,fecha)='" + CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Month) + "' and datepart(yy,fecha)='" + CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year) + "'"
                dtreajuste = cFun.ConsultaX(csql)
            Catch ex As Exception
                MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            'fin para obtener reajuste
            If Me.Lvwdetalles.Items.Count = 0 Then
                Me.Lvwdetalles.Items.Add(CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year))
                Me.Lvwdetalles.Items(d).SubItems.Add(CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year) & "=S/." & CStr(dtuit.Rows(0).Item(0)))
                Me.Lvwdetalles.Items(d).SubItems.Add(CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year) & "-" & CStr(Me.DgvTrimestres.Item(1, i).Value) & "=" & CStr(dtreajuste.Rows(0).Item(0)))
                dias = CInt(DateDiff("d", Me.DgvTrimestres.Item(2, i).Value, Now))
                Me.Lvwdetalles.Items(d).SubItems.Add(CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year) & "-" & CStr(Me.DgvTrimestres.Item(1, i).Value) & "=" & CStr(dias * Val(Me.txttasa.Text)) & "%")
            Else
                For j = 0 To Me.Lvwdetalles.Items.Count - 1
                    If Me.Lvwdetalles.Items(j).SubItems(0).Text = CStr(CDate(DgvTrimestres.Item(2, i).Value).Year) Then
                        'Me.Lvwdetalles.Items(j).SubItems(1).Text = CStr(Me.Lvwdetalles.Items(j).SubItems(1).Text) & "," & CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year) & "-" & CStr(dtuit.Rows(0).Item(0))
                        Me.Lvwdetalles.Items(j).SubItems(2).Text = CStr(Me.Lvwdetalles.Items(j).SubItems(2).Text) & "," & CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year) & "-" & CStr(Me.DgvTrimestres.Item(1, i).Value) & "=" & CStr(dtreajuste.Rows(0).Item(0))
                        dias = CInt(DateDiff("d", Me.DgvTrimestres.Item(2, i).Value, Now))
                        Me.Lvwdetalles.Items(j).SubItems(3).Text = CStr(Me.Lvwdetalles.Items(j).SubItems(3).Text) & "," & CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year) & "-" & CStr(Me.DgvTrimestres.Item(1, i).Value) & "=" & CStr(dias * Val(Me.txttasa.Text)) & "%"
                    Else
                        Me.Lvwdetalles.Items(j).SubItems(1).Text = CStr(Me.Lvwdetalles.Items(j).SubItems(1).Text) & "," & CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year) & "-" & CStr(dtuit.Rows(0).Item(0))
                        Me.Lvwdetalles.Items(j).SubItems(2).Text = CStr(Me.Lvwdetalles.Items(j).SubItems(2).Text) & "," & CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year) & "-" & CStr(Me.DgvTrimestres.Item(1, i).Value) & "=" & CStr(dtreajuste.Rows(0).Item(0))
                        dias = CInt(DateDiff("d", Me.DgvTrimestres.Item(2, i).Value, Now))
                        Me.Lvwdetalles.Items(j).SubItems(3).Text = CStr(Me.Lvwdetalles.Items(j).SubItems(3).Text) & "," & CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year) & "-" & CStr(Me.DgvTrimestres.Item(1, i).Value) & "=" & CStr(dias * Val(Me.txttasa.Text)) & "%"
                    End If
                Next
            End If
        Next

    End Sub

    '***********************fin funciones ***********************************

    '********************+ funciones ***********************+
    Sub limpiar()
        Me.lblcoddj.ResetText()
        Me.lblfechadj.ResetText()
        Me.lblcodigocliente.ResetText()
        Me.lblDescripcion.ResetText()
        Me.lblruc.ResetText()
        Me.lbldni.ResetText()
        Me.lvwDetalle.Items.Clear()
        Me.Lvwdetalles.Items.Clear()
        Me.lblorden.ResetText()
        Me.lbltotal.ResetText()
        Me.txttasa.ResetText()
        Me.txtDias.ResetText()

        Me.lbl15uit.ResetText()
        Me.lbl60uit.ResetText()
        Me.lblmas15uit.ResetText()
        Me.lblorden.ResetText()

        Me.dtpfechaactualizacion.ResetText()
        LlenaLstViewtrim()
        Me.btnagregar.Enabled = True
        Me.lblorden.Text = Format(CInt(clop.GeneraOrden()) + 1, "00000000")
    End Sub
    Sub GetDatosuit() ' para filtar los valores de la uit segun 15, 60 o mas de 60 uit 
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "SELECT valor from t_uit where estado='A'"
            dt = cFun.ConsultaX(csql)
            Me.lbl15uit.Text = Format(CDbl(dt.Rows(0).Item(0)) * 15, "#,##0.00")
            Me.lblmas15uit.Text = Format(CDbl(dt.Rows(0).Item(0)) * 60, "#,##0.00")
            Me.lbl60uit.Text = Format(CDbl(dt.Rows(0).Item(0)) * 61, "#,##0.00")
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Sub LlenaLstViewtrim() ' llenamos la lista de trimestres y pagos de una dj
        Dim cSql As String = "select distinct ttr.CodTrimestre,ttr.Numero,FechVenc ,monto,tp.codpago,tp.estado,baseimponible,impuestoanual,indicador from t_cliente tc inner join t_predio tpr  on tpr.codcli=tc.codcli inner join t_detalledj tddj on tddj.codpredio=tpr.codpredio  inner join t_djautovaluo tdj on tdj.coddj=tddj.coddj inner join t_pagos tp on  tp.coddj=tdj.coddj inner join t_trimestres ttr on ttr.codtrimestre=tp.codtrimestre  where tp.estado='D' and fechvenc< getdate() and tc.codcli='" + Me.lblcodigocliente.Text + "'"
        FunDb.FillDataGridView(cSql, DgvTrimestres)
    End Sub
    Sub diasfecha()
        Dim d As Date = Now
        Dim i As Integer
        While i < CInt(Me.txtdias.Text)
            d = d.AddDays(1)
            If d.DayOfWeek = DayOfWeek.Saturday Or d.DayOfWeek = DayOfWeek.Sunday Then
                i = i
            Else
                i = i + 1
            End If
        End While
        clop.FechaVenc = CStr(d.Date)
    End Sub
    Sub ordenact() ' calculamos el monto acualizado de los pagos atrasados q no estan en coactivos
        Me.lbltotal.Text = "0.00"
        For i = 0 To Me.lvwDetalle.Items.Count - 1
            Me.lbltotal.Text = Format(CDbl(Me.lbltotal.Text) + CDbl(Me.lvwDetalle.Items(i).SubItems(10).Text), "#,##0.00")
            dias = CInt(DateDiff("d", Me.DgvTrimestres.Item(2, i).Value, dtpfechaactualizacion.Value))
        Next
    End Sub
    Sub CALCULARTOTALES()
        For i = 0 To Me.lvwDetalle.Items.Count - 1
            Me.lvwDetalle.Items(i).SubItems(10).Text = Format(CDbl(Me.lvwDetalle.Items(i).SubItems(7).Text) + CDbl(Me.lvwDetalle.Items(i).SubItems(8).Text) + CDbl(Me.lvwDetalle.Items(i).SubItems(9).Text), "#,##0.00")
        Next
    End Sub
    Sub grabarordenypago()
        For i = 0 To Me.DgvTrimestres.RowCount - 1
            Me.coyp.CodPago = Me.DgvTrimestres.Item(4, i).Value.ToString
            Me.coyp.CodOrden = Me.lblorden.Text
            coyp.AltaOrden_Pago()
        Next

    End Sub
    '********************* fin funciones **********************************
    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        clop.CodOrden = Me.lblorden.Text
        clop.CodCli = Me.lblcodigocliente.Text
        clop.Monto = CDbl(Me.lbltotal.Text)
        clop.EstadoCD = "D"
        clop.FechaAct = CStr(Me.dtpfechaactualizacion.Value.Date)
        clop.FechaEmision = CStr(Now.Date)
        diasfecha()
        clop.Dias = CInt(Me.txtdias.Text)
        clop.TasaInteres = CDbl(Me.txttasa.Text)
        clop.CodDj = Me.lblcoddj.Text
        clop.Fechadj = Me.lblfechadj.Text
        clop.Usuario = MdiPrincipal.tsbDniUsu.Caption
        '''''''''''
        Dim pregunta As DialogResult
        pregunta = MessageBox.Show("Desea dar de Alta esta orden de pago", "Insercion de Orden de pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pregunta = DialogResult.Yes Then
            clop.EliminarOrden(Me.lblcodigocliente.Text)
            If clop.AltaOrden = True Then
                For i = 0 To Me.lvwDetalle.Items.Count - 1
                    cldop.CodOrden = Me.lblorden.Text
                    cldop.Annio = Me.lvwDetalle.Items(i).SubItems(0).Text
                    cldop.BaseImponible = Val(Me.lvwDetalle.Items(i).SubItems(1).Text)
                    cldop.Tramo = Me.lvwDetalle.Items(i).SubItems(2).Text
                    cldop.AliCuota = Me.lvwDetalle.Items(i).SubItems(3).Text
                    cldop.Insolutos = Me.lvwDetalle.Items(i).SubItems(4).Text
                    cldop.ImpuestoAnual = Val(Me.lvwDetalle.Items(i).SubItems(5).Text)
                    cldop.Trimestres = Me.lvwDetalle.Items(i).SubItems(6).Text
                    cldop.Insoluto = Val(Me.lvwDetalle.Items(i).SubItems(7).Text)
                    cldop.Reajuste = Val(Me.lvwDetalle.Items(i).SubItems(8).Text)
                    cldop.Interes = Val(Me.lvwDetalle.Items(i).SubItems(9).Text)
                    cldop.Total = Val(Me.lvwDetalle.Items(i).SubItems(10).Text)
                    cldop.AltaDetalleOrden()
                    MessageBox.Show("La transaccion se realizo de manera satisfactoria", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Next
                For i = 0 To Me.Lvwdetalles.Items.Count - 1
                    cdatos.CodOrden = Me.lblorden.Text
                    cdatos.ValorUit = Me.Lvwdetalles.Items(i).SubItems(1).Text
                    cdatos.Reajuste = Me.Lvwdetalles.Items(i).SubItems(2).Text
                    cdatos.Tim = Me.Lvwdetalles.Items(i).SubItems(3).Text
                    cdatos.AltadetalleDatos()
                Next
            End If
        End If
        '''''''''''''''''''''
        grabarordenypago()   'PARA GRABAR EN LA TABLE T_ORDEN_PAGO (DETALLE DE LA ORDEN Y LOS PAGOS Q INCLUYE)
        Dim cr As New Cr_OrdenPago
        cr.DataDefinition.FormulaFields.Item("descli").Text = "'" + Me.lblDescripcion.Text + "'"
        cr.DataDefinition.FormulaFields.Item("dni").Text = "'" + Me.lbldni.Text + "'"
        cr.DataDefinition.FormulaFields.Item("ruccli").Text = "'" + Me.lblruc.Text + "'"
        cr.DataDefinition.FormulaFields.Item("descripcion").Text = "'" + clentidad.Nombre + "'"
        cr.DataDefinition.FormulaFields.Item("ruc").Text = "'" + clentidad.Ruc + "'"
        cr.DataDefinition.FormulaFields.Item("direccion").Text = "'" + clentidad.Direccion + "'"
        cr.DataDefinition.FormulaFields.Item("telefono").Text = "'" + clentidad.Telefono + "'"
        Try
            Dim dt As New DataTable
            Dim cFun As New cFuncionesDB
            Dim csql As String = "SELECT dircli+' Nº'+numero+' Mz.'+manzana+' Lt.'+lote from t_cliente where codcli='" + Me.lblcodigocliente.Text + "'"
            dt = cFun.ConsultaX(csql)
            cr.DataDefinition.FormulaFields.Item("domiciliofiscal").Text = "'" + CStr(dt.Rows(0).Item(0)) + "'"
        Catch ex As Exception
            MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim annios As String = ""
        For i = 0 To Me.lvwDetalle.Items.Count - 1
            annios = annios & "-" & Me.lvwDetalle.Items(i).SubItems(0).Text
        Next
        cr.DataDefinition.FormulaFields.Item("Annios").Text = "'" + annios + "'"
        cimp.reporte(clop.Imprimeorden(Me.lblorden.Text, Me.lblcodigocliente.Text), cr)
        limpiar()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        FrmBuscarCliente.lblflag.Text = "8"
        FrmBuscarCliente.ShowDialog()
    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        limpiar()
    End Sub
    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        If Me.lblcodigocliente.Text = "" Or Me.txttasa.Text = "" Or Me.txtdias.Text = "" Or Me.dtpfechaactualizacion.Value.Date = Now.Date Then
            MessageBox.Show("Complete los Datos antes de continuar", "Registro de Orden de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim j As Integer
            For i = 0 To Me.DgvTrimestres.RowCount - 1
                If Me.lvwDetalle.Items.Count = 0 Then
                    c = Me.lvwDetalle.Items.Count
                    lvwDetalle.Items.Add(CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year))
                    Me.lvwDetalle.Items(c).SubItems.Add(CStr(Format(Me.DgvTrimestres.Item(6, i).Value, "#,##0.00")))
                    If CInt(Me.DgvTrimestres.Item(8, i).Value) = 0 Then
                        Me.lvwDetalle.Items(c).SubItems.Add("Hasta 15 UIT   Mas 15 a 60 UIT  Mas de 60 UIT.")
                        Me.lvwDetalle.Items(c).SubItems.Add("0,2% ,0,6%, 1.0% ")
                        If CDbl(Me.DgvTrimestres.Item(6, i).Value) <= Val(Me.lbl15uit.Text) Then
                            Me.lvwDetalle.Items(c).SubItems.Add(CStr(Format(CDbl(Me.DgvTrimestres.Item(6, i).Value) * 0.002, "#,##0.00")))
                        ElseIf CDbl(Me.DgvTrimestres.Item(6, i).Value) > CDbl(Me.lbl15uit.Text) And CDbl(Me.DgvTrimestres.Item(6, i).Value) <= CDbl(Me.lblmas15uit.Text) Then
                            Me.lvwDetalle.Items(c).SubItems.Add(CStr(CStr(Format(CDbl(Me.lbl15uit.Text) * 0.002, "#,##0.00")) & ChrW(Keys.Enter) & CStr(Format((CDbl(Me.DgvTrimestres.Item(6, i).Value) - CDbl(Me.lbl15uit.Text)) * 0.006, "#,##0.00"))))
                        ElseIf CDbl(Me.DgvTrimestres.Item(6, i).Value) > CDbl(Me.lblmas15uit.Text) And CDbl(Me.DgvTrimestres.Item(6, i).Value) >= CDbl(Me.lbl60uit.Text) Then
                            Me.lvwDetalle.Items(c).SubItems.Add(CStr(CStr(Format(CDbl(Me.lbl15uit.Text) * 0.002, "#,##0.00"))) & ChrW(Keys.Enter) & CStr(Format(CDbl(Me.lblmas15uit.Text) * 0.006, "#,##0.00")) & ChrW(Keys.Enter) & CStr(Format((CDbl(Me.DgvTrimestres.Item(6, i).Value) - (CDbl(Me.lblmas15uit.Text) + CDbl(Me.lbl15uit.Text))) * 0.01, "#,##0.00")))
                        End If
                    Else
                        Me.lvwDetalle.Items(c).SubItems.Add("Monto mínimo")
                        Me.lvwDetalle.Items(c).SubItems.Add(clop.montominimo(CStr(Me.DgvTrimestres.Item(4, i).Value)))
                        Me.lvwDetalle.Items(c).SubItems.Add("Monto mínimo")
                    End If
                    Me.lvwDetalle.Items(c).SubItems.Add(CStr(Me.DgvTrimestres.Item(7, i).Value))
                    Me.lvwDetalle.Items(c).SubItems.Add(CStr(Me.DgvTrimestres.Item(1, i).Value))
                    Me.lvwDetalle.Items(c).SubItems.Add(CStr(Val(Me.DgvTrimestres.Item(7, i).Value) / 4))
                    Try
                        'PARA CALCULAR EL REAJUSTE
                        Dim dt As New DataTable
                        Dim cFun As New cFuncionesDB
                        Dim csql As String = "SELECT Acumulado from t_factoreajuste where datepart(month , fecha)='" + CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Month) + "'"
                        dt = cFun.ConsultaX(csql)
                        Me.lvwDetalle.Items(c).SubItems.Add(CStr(CDbl(CDbl(dt.Rows(0).Item(0)) / 100) * (Val(Me.DgvTrimestres.Item(7, i).Value) / 4)))

                        'PARA CALCULAR EL INTERES
                        dias = CInt(DateDiff("d", Me.DgvTrimestres.Item(2, i).Value, Now))
                        Me.lvwDetalle.Items(c).SubItems.Add(CStr(((Val(Me.DgvTrimestres.Item(7, i).Value) / 4) + CDbl(CDbl(dt.Rows(0).Item(0)) / 100) * (CDbl(Me.DgvTrimestres.Item(7, i).Value) / 4)) * (CDbl(Me.txttasa.Text) / 100) * dias))
                        Me.lvwDetalle.Items(c).SubItems.Add("0.00")
                    Catch ex As Exception
                        MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try

                Else
                    Dim y As Integer
                    Dim contador As Integer = 0
                    For j = 0 To Me.lvwDetalle.Items.Count - 1
                        If Me.lvwDetalle.Items(j).SubItems(0).Text = CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year) Then
                            FLAG = FLAG + 1
                            Me.lvwDetalle.Items(j).SubItems(6).Text = Me.lvwDetalle.Items(j).SubItems(6).Text & "," & CStr(Me.DgvTrimestres.Item(1, i).Value)
                            For y = 0 To Me.DgvTrimestres.RowCount - 1
                                contador = contador + 1
                            Next
                            Me.lvwDetalle.Items(j).SubItems(7).Text = CStr((Val(Me.lvwDetalle.Items(j).SubItems(5).Text) / 4) * contador)
                            Try
                                'CALCULAR REAJUSTE
                                Dim dt As New DataTable
                                Dim cFun As New cFuncionesDB
                                Dim csql As String = "SELECT Acumulado from t_factoreajuste where datepart(month , fecha)='" + CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Month) + "'"
                                dt = cFun.ConsultaX(csql)
                                Me.lvwDetalle.Items(j).SubItems(8).Text = CStr(CDbl(Me.lvwDetalle.Items(j).SubItems(8).Text) + (CDbl(CDbl(dt.Rows(0).Item(0)) / 100) * (Val(Me.DgvTrimestres.Item(7, i).Value) / 4)))

                                'CALCULAR INTERES
                                dias = CInt(DateDiff("d", Me.DgvTrimestres.Item(2, i).Value, Now))

                                Me.lvwDetalle.Items(j).SubItems(9).Text = Format(CDbl(Me.lvwDetalle.Items(j).SubItems(9).Text) + ((CDbl(CDbl(dt.Rows(0).Item(0)) / 100) * (CDbl(Me.DgvTrimestres.Item(7, i).Value) / 4)) + (CDbl(Me.lvwDetalle.Items(j).SubItems(7).Text) / contador)) * (CDbl(Me.txttasa.Text) / 100) * dias, "#,##0.00")
                                Me.lvwDetalle.Items(j).SubItems(10).Text = "0.00"
                            Catch ex As Exception
                                MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End Try
                        End If
                    Next
                    If FLAG = 0 Then
                        c = Me.lvwDetalle.Items.Count
                        lvwDetalle.Items.Add(CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Year))
                        Me.lvwDetalle.Items(c).SubItems.Add(CStr(Me.DgvTrimestres.Item(6, i).Value))
                        If CInt(Me.DgvTrimestres.Item(8, i).Value) = 0 Then
                            Me.lvwDetalle.Items(c).SubItems.Add("Hasta 15 UIT   ,Mas 15 a 60 UIT,Mas de 60 UIT.")
                            Me.lvwDetalle.Items(c).SubItems.Add("0,2% ,0,6%, 1.0% ")
                            If CDbl(Me.DgvTrimestres.Item(6, i).Value) <= Val(Me.lbl15uit.Text) Then
                                Me.lvwDetalle.Items(c).SubItems.Add(CStr(Format(CDbl(Me.DgvTrimestres.Item(6, i).Value) * 0.002, "#,##0.00")))
                            ElseIf CDbl(Me.DgvTrimestres.Item(6, i).Value) > Val(Me.lbl15uit.Text) And Val(Me.DgvTrimestres.Item(6, i).Value) <= Val(Me.lblmas15uit.Text) Then
                                Me.lvwDetalle.Items(c).SubItems.Add(CStr(CStr(Format(CDbl(Me.lbl15uit.Text) * 0.002, "#,##0.00")) & ChrW(Keys.Enter) & CStr(Format((CDbl(Me.DgvTrimestres.Item(6, i).Value) - CDbl(Me.lbl15uit.Text)) * 0.006, "#,##0.00"))))
                            ElseIf CDbl(Me.DgvTrimestres.Item(6, i).Value) > Val(Me.lblmas15uit.Text) And Val(Me.DgvTrimestres.Item(6, i).Value) >= Val(Me.lbl60uit.Text) Then
                                Me.lvwDetalle.Items(c).SubItems.Add(CStr(CStr(Format(CDbl(Me.lbl15uit.Text) * 0.002, "#,##0.00"))) & ChrW(Keys.Enter) & CStr(Format(CDbl(Me.lblmas15uit.Text) * 0.006, "#,##0.00")) & ChrW(Keys.Enter) & CStr(Format((CDbl(Me.DgvTrimestres.Item(6, i).Value) - (CDbl(Me.lblmas15uit.Text) + CDbl(Me.lbl15uit.Text))) * 0.01, "#,##0.00")))
                            End If
                        Else
                            Me.lvwDetalle.Items(c).SubItems.Add("Monto mínimo")
                            Me.lvwDetalle.Items(c).SubItems.Add("")
                        End If
                        Me.lvwDetalle.Items(c).SubItems.Add(CStr(Me.DgvTrimestres.Item(7, i).Value))
                        Me.lvwDetalle.Items(c).SubItems.Add(CStr(Me.DgvTrimestres.Item(1, i).Value))
                        Me.lvwDetalle.Items(c).SubItems.Add(CStr(CDbl(Me.DgvTrimestres.Item(7, i).Value) / 4))
                        Try
                            'PARA CALCULAR EL REAJUSTE
                            Dim dt As New DataTable
                            Dim cFun As New cFuncionesDB
                            Dim csql As String = "SELECT Acumulado from t_factoreajuste where datepart(month , fecha)='" + CStr(CDate(Me.DgvTrimestres.Item(2, i).Value).Month) + "'"
                            dt = cFun.ConsultaX(csql)
                            Me.lvwDetalle.Items(c).SubItems.Add(CStr(CDbl(CDbl(dt.Rows(0).Item(0)) / 100) * (CDbl(Me.DgvTrimestres.Item(7, i).Value) / 4)))
                            'PARA CALCULAR EL INTERES
                            dias = CInt(DateDiff("d", Me.DgvTrimestres.Item(2, i).Value, Now))

                            Me.lvwDetalle.Items(c).SubItems.Add(CStr(((CDbl(Me.DgvTrimestres.Item(7, i).Value) / 4) + CDbl(CDbl(dt.Rows(0).Item(0)) / 100) * (CDbl(Me.DgvTrimestres.Item(7, i).Value) / 4)) * (CDbl(Me.txttasa.Text) / 100) * dias))
                            Me.lvwDetalle.Items(c).SubItems.Add("0.00")
                        Catch ex As Exception
                            MessageBox.Show("Es probable que el Bien no este registrado", " Consulta de Bienes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                    End If
                End If
            Next
            dias = 0
            CALCULARTOTALES()
            ordenact()
            DatosDetalle()
            EstiloView.AplicaColorTotales(lvwDetalle, 10, Color.LightBlue)
            Me.btnagregar.Enabled = False
        End If
    End Sub


    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        limpiar()
        Me.Close()
    End Sub

    Public Sub AplicaEstilo()
        EstiloGrid.AplicaStiloBlue(DgvTrimestres)
    End Sub

    Sub HeadGrid()
        With DgvTrimestres
            .Columns(0).HeaderText = "Cod. Trim"
            .Columns(1).HeaderText = "Nro. Trim"
            .Columns(2).HeaderText = "Fecha Venc"
            .Columns(3).HeaderText = "Monto"
            .Columns(4).HeaderText = "Cod. Pago"
            .Columns(5).HeaderText = "Estado"
            .Columns(6).HeaderText = "Base Impon."
            .Columns(7).HeaderText = "Imp. Anual"
            .Columns(8).HeaderText = "Indicador"
        End With
    End Sub

End Class