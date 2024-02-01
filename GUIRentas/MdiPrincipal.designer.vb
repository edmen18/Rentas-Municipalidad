<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MdiPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdiPrincipal))
        Me.imgSmall = New DevExpress.Utils.ImageCollection(Me.components)
        Me.imgLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.rbcPrincipal = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.ApplicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.btnSalir = New DevExpress.XtraBars.BarButtonItem
        Me.btnContribuyente = New DevExpress.XtraBars.BarButtonItem
        Me.btnPredios = New DevExpress.XtraBars.BarButtonItem
        Me.btnEvaluacionPredio = New DevExpress.XtraBars.BarButtonItem
        Me.btnDeclaracionJurada = New DevExpress.XtraBars.BarButtonItem
        Me.btnFacturar = New DevExpress.XtraBars.BarButtonItem
        Me.btnEmpoces = New DevExpress.XtraBars.BarButtonItem
        Me.btnTasas = New DevExpress.XtraBars.BarButtonItem
        Me.btnCuentasCts = New DevExpress.XtraBars.BarButtonItem
        Me.btnDepreciacion = New DevExpress.XtraBars.BarButtonItem
        Me.btnConsultaEmpoce = New DevExpress.XtraBars.BarButtonItem
        Me.btnServicios = New DevExpress.XtraBars.BarButtonItem
        Me.btnTrimestres = New DevExpress.XtraBars.BarButtonItem
        Me.btnMotivos = New DevExpress.XtraBars.BarButtonItem
        Me.btnZona = New DevExpress.XtraBars.BarButtonItem
        Me.btnCondicion = New DevExpress.XtraBars.BarButtonItem
        Me.btnConsultaHRPu = New DevExpress.XtraBars.BarButtonItem
        Me.btnMontoMinimo = New DevExpress.XtraBars.BarButtonItem
        Me.btnFactorReajuste = New DevExpress.XtraBars.BarButtonItem
        Me.btnPagos = New DevExpress.XtraBars.BarButtonItem
        Me.btnUsuarios = New DevExpress.XtraBars.BarButtonItem
        Me.btnCopiaBD = New DevExpress.XtraBars.BarButtonItem
        Me.btnRestauraBd = New DevExpress.XtraBars.BarButtonItem
        Me.btnExtornos = New DevExpress.XtraBars.BarButtonItem
        Me.btnReportes = New DevExpress.XtraBars.BarButtonItem
        Me.btnConsulExt = New DevExpress.XtraBars.BarButtonItem
        Me.btnRepPredial = New DevExpress.XtraBars.BarButtonItem
        Me.btnOrden = New DevExpress.XtraBars.BarButtonItem
        Me.btnPagarOrden = New DevExpress.XtraBars.BarButtonItem
        Me.btnConsultaOrden = New DevExpress.XtraBars.BarButtonItem
        Me.tsbDniUsu = New DevExpress.XtraBars.BarStaticItem
        Me.btnAcerca = New DevExpress.XtraBars.BarButtonItem
        Me.btnListaTUO = New DevExpress.XtraBars.BarButtonItem
        Me.tsbUsuario = New DevExpress.XtraBars.BarStaticItem
        Me.btnRegistro = New DevExpress.XtraBars.BarButtonItem
        Me.btnCliente = New DevExpress.XtraBars.BarButtonItem
        Me.btnValores = New DevExpress.XtraBars.BarButtonItem
        Me.rpgRegistro = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpcRegistro = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgOrdenPago = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgRecaudacion = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpcServicios = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpcMaestro = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgConsultas = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpcConsultas = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpcConsulPredial = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgControl = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpcControlDatos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgAdmin = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpcExtornos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpcBaseDatos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.stbSistema = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.LookOffice = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.ClientPanel = New DevExpress.XtraEditors.PanelControl
        CType(Me.imgSmall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbcPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgSmall
        '
        Me.imgSmall.ImageStream = CType(resources.GetObject("imgSmall.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imgSmall.Images.SetKeyName(0, "04.png")
        Me.imgSmall.Images.SetKeyName(1, "10.png")
        Me.imgSmall.Images.SetKeyName(2, "05.png")
        Me.imgSmall.Images.SetKeyName(3, "46.png")
        Me.imgSmall.Images.SetKeyName(4, "51.png")
        Me.imgSmall.Images.SetKeyName(5, "04.png")
        Me.imgSmall.Images.SetKeyName(6, "08.png")
        Me.imgSmall.Images.SetKeyName(7, "21.png")
        Me.imgSmall.Images.SetKeyName(8, "33.png")
        Me.imgSmall.Images.SetKeyName(9, "52.png")
        Me.imgSmall.Images.SetKeyName(10, "02.png")
        Me.imgSmall.Images.SetKeyName(11, "11.png")
        Me.imgSmall.Images.SetKeyName(12, "18.png")
        '
        'imgLarge
        '
        Me.imgLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.imgLarge.ImageStream = CType(resources.GetObject("imgLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imgLarge.Images.SetKeyName(0, "103.png")
        Me.imgLarge.Images.SetKeyName(1, "04.png")
        Me.imgLarge.Images.SetKeyName(2, "19.png")
        Me.imgLarge.Images.SetKeyName(3, "25.png")
        Me.imgLarge.Images.SetKeyName(4, "30.png")
        Me.imgLarge.Images.SetKeyName(5, "52.png")
        Me.imgLarge.Images.SetKeyName(6, "53.png")
        Me.imgLarge.Images.SetKeyName(7, "54.png")
        Me.imgLarge.Images.SetKeyName(8, "55.png")
        Me.imgLarge.Images.SetKeyName(9, "60.png")
        Me.imgLarge.Images.SetKeyName(10, "74.png")
        Me.imgLarge.Images.SetKeyName(11, "87.png")
        Me.imgLarge.Images.SetKeyName(12, "99.png")
        Me.imgLarge.Images.SetKeyName(13, "49.png")
        Me.imgLarge.Images.SetKeyName(14, "10.png")
        Me.imgLarge.Images.SetKeyName(15, "60.png")
        Me.imgLarge.Images.SetKeyName(16, "11.png")
        Me.imgLarge.Images.SetKeyName(17, "14.png")
        Me.imgLarge.Images.SetKeyName(18, "29.png")
        Me.imgLarge.Images.SetKeyName(19, "31.png")
        Me.imgLarge.Images.SetKeyName(20, "39.png")
        Me.imgLarge.Images.SetKeyName(21, "44.png")
        Me.imgLarge.Images.SetKeyName(22, "47.png")
        Me.imgLarge.Images.SetKeyName(23, "48.png")
        Me.imgLarge.Images.SetKeyName(24, "51.png")
        Me.imgLarge.Images.SetKeyName(25, "52.png")
        Me.imgLarge.Images.SetKeyName(26, "53.png")
        Me.imgLarge.Images.SetKeyName(27, "78.png")
        Me.imgLarge.Images.SetKeyName(28, "103.png")
        Me.imgLarge.Images.SetKeyName(29, "106.png")
        Me.imgLarge.Images.SetKeyName(30, "07.png")
        Me.imgLarge.Images.SetKeyName(31, "72b.png")
        Me.imgLarge.Images.SetKeyName(32, "80.png")
        Me.imgLarge.Images.SetKeyName(33, "85.png")
        Me.imgLarge.Images.SetKeyName(34, "38.png")
        Me.imgLarge.Images.SetKeyName(35, "65.png")
        Me.imgLarge.Images.SetKeyName(36, "84.png")
        Me.imgLarge.Images.SetKeyName(37, "06.png")
        Me.imgLarge.Images.SetKeyName(38, "16g.png")
        Me.imgLarge.Images.SetKeyName(39, "Exit_one.png")
        Me.imgLarge.Images.SetKeyName(40, "43.png")
        '
        'rbcPrincipal
        '
        Me.rbcPrincipal.ApplicationButtonDropDownControl = Me.ApplicationMenu1
        Me.rbcPrincipal.ApplicationButtonText = Nothing
        Me.rbcPrincipal.Images = Me.imgSmall
        Me.rbcPrincipal.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnContribuyente, Me.btnPredios, Me.btnEvaluacionPredio, Me.btnDeclaracionJurada, Me.btnFacturar, Me.btnEmpoces, Me.btnTasas, Me.btnCuentasCts, Me.btnDepreciacion, Me.btnConsultaEmpoce, Me.btnServicios, Me.btnTrimestres, Me.btnMotivos, Me.btnZona, Me.btnCondicion, Me.btnConsultaHRPu, Me.btnMontoMinimo, Me.btnFactorReajuste, Me.btnPagos, Me.btnUsuarios, Me.btnCopiaBD, Me.btnRestauraBd, Me.btnExtornos, Me.btnReportes, Me.btnConsulExt, Me.btnRepPredial, Me.btnOrden, Me.btnPagarOrden, Me.btnConsultaOrden, Me.tsbDniUsu, Me.btnSalir, Me.btnAcerca, Me.btnListaTUO, Me.tsbUsuario, Me.btnRegistro, Me.btnCliente, Me.btnValores})
        Me.rbcPrincipal.LargeImages = Me.imgLarge
        Me.rbcPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.rbcPrincipal.MaxItemId = 50
        Me.rbcPrincipal.Name = "rbcPrincipal"
        Me.rbcPrincipal.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpgRegistro, Me.rpgRecaudacion, Me.rpgConsultas, Me.rpgControl, Me.rpgAdmin})
        Me.rbcPrincipal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.rbcPrincipal.SelectedPage = Me.rpgRegistro
        Me.rbcPrincipal.Size = New System.Drawing.Size(642, 144)
        Me.rbcPrincipal.StatusBar = Me.stbSistema
        '
        'ApplicationMenu1
        '
        Me.ApplicationMenu1.BottomPaneControlContainer = Nothing
        Me.ApplicationMenu1.ItemLinks.Add(Me.btnSalir)
        Me.ApplicationMenu1.Name = "ApplicationMenu1"
        Me.ApplicationMenu1.Ribbon = Me.rbcPrincipal
        Me.ApplicationMenu1.RightPaneControlContainer = Nothing
        '
        'btnSalir
        '
        Me.btnSalir.Caption = "Salir del Sistema"
        Me.btnSalir.Description = "Pulse CTRL + X para Salir"
        Me.btnSalir.Id = 41
        Me.btnSalir.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
        Me.btnSalir.LargeImageIndex = 39
        Me.btnSalir.Name = "btnSalir"
        '
        'btnContribuyente
        '
        Me.btnContribuyente.Caption = "Contribuyente"
        Me.btnContribuyente.Id = 0
        Me.btnContribuyente.LargeImageIndex = 12
        Me.btnContribuyente.Name = "btnContribuyente"
        '
        'btnPredios
        '
        Me.btnPredios.Caption = "Registra Predios"
        Me.btnPredios.Id = 1
        Me.btnPredios.LargeImageIndex = 11
        Me.btnPredios.Name = "btnPredios"
        '
        'btnEvaluacionPredio
        '
        Me.btnEvaluacionPredio.Caption = "Evaluar Predio"
        Me.btnEvaluacionPredio.Id = 2
        Me.btnEvaluacionPredio.ImageIndex = 1
        Me.btnEvaluacionPredio.Name = "btnEvaluacionPredio"
        '
        'btnDeclaracionJurada
        '
        Me.btnDeclaracionJurada.Caption = "Declaracion Jurada"
        Me.btnDeclaracionJurada.Id = 3
        Me.btnDeclaracionJurada.ImageIndex = 0
        Me.btnDeclaracionJurada.Name = "btnDeclaracionJurada"
        '
        'btnFacturar
        '
        Me.btnFacturar.Caption = "Facturacion"
        Me.btnFacturar.Id = 4
        Me.btnFacturar.LargeImageIndex = 13
        Me.btnFacturar.Name = "btnFacturar"
        '
        'btnEmpoces
        '
        Me.btnEmpoces.Caption = "Empoces"
        Me.btnEmpoces.Id = 5
        Me.btnEmpoces.LargeImageIndex = 9
        Me.btnEmpoces.Name = "btnEmpoces"
        '
        'btnTasas
        '
        Me.btnTasas.Caption = "Texto Unico de Tasas"
        Me.btnTasas.Id = 6
        Me.btnTasas.LargeImageIndex = 16
        Me.btnTasas.Name = "btnTasas"
        '
        'btnCuentasCts
        '
        Me.btnCuentasCts.Caption = "Ctas. Corrientes"
        Me.btnCuentasCts.Id = 7
        Me.btnCuentasCts.ImageIndex = 4
        Me.btnCuentasCts.Name = "btnCuentasCts"
        '
        'btnDepreciacion
        '
        Me.btnDepreciacion.Caption = "Depreciaciones"
        Me.btnDepreciacion.Id = 8
        Me.btnDepreciacion.LargeImageIndex = 16
        Me.btnDepreciacion.Name = "btnDepreciacion"
        '
        'btnConsultaEmpoce
        '
        Me.btnConsultaEmpoce.Caption = "Conulta Empoces"
        Me.btnConsultaEmpoce.Id = 9
        Me.btnConsultaEmpoce.LargeImageIndex = 35
        Me.btnConsultaEmpoce.Name = "btnConsultaEmpoce"
        '
        'btnServicios
        '
        Me.btnServicios.Caption = "Consulta Servicios"
        Me.btnServicios.Id = 10
        Me.btnServicios.LargeImageIndex = 22
        Me.btnServicios.Name = "btnServicios"
        '
        'btnTrimestres
        '
        Me.btnTrimestres.Caption = "Trimestres"
        Me.btnTrimestres.Id = 12
        Me.btnTrimestres.LargeImageIndex = 22
        Me.btnTrimestres.Name = "btnTrimestres"
        '
        'btnMotivos
        '
        Me.btnMotivos.Caption = "Motivos"
        Me.btnMotivos.Id = 13
        Me.btnMotivos.ImageIndex = 0
        Me.btnMotivos.Name = "btnMotivos"
        '
        'btnZona
        '
        Me.btnZona.Caption = "Zona"
        Me.btnZona.Id = 14
        Me.btnZona.ImageIndex = 7
        Me.btnZona.Name = "btnZona"
        '
        'btnCondicion
        '
        Me.btnCondicion.Caption = "Condicion Propiedad"
        Me.btnCondicion.Id = 15
        Me.btnCondicion.ImageIndex = 12
        Me.btnCondicion.Name = "btnCondicion"
        '
        'btnConsultaHRPu
        '
        Me.btnConsultaHRPu.Caption = "Consulta PU - HR"
        Me.btnConsultaHRPu.Id = 16
        Me.btnConsultaHRPu.LargeImageIndex = 4
        Me.btnConsultaHRPu.Name = "btnConsultaHRPu"
        '
        'btnMontoMinimo
        '
        Me.btnMontoMinimo.Caption = "Monto Minimo"
        Me.btnMontoMinimo.Id = 17
        Me.btnMontoMinimo.ImageIndex = 3
        Me.btnMontoMinimo.Name = "btnMontoMinimo"
        '
        'btnFactorReajuste
        '
        Me.btnFactorReajuste.Caption = "Factor de Reajuste"
        Me.btnFactorReajuste.Id = 18
        Me.btnFactorReajuste.ImageIndex = 11
        Me.btnFactorReajuste.Name = "btnFactorReajuste"
        '
        'btnPagos
        '
        Me.btnPagos.Caption = "Pagar Trimestre"
        Me.btnPagos.Id = 19
        Me.btnPagos.LargeImageIndex = 3
        Me.btnPagos.Name = "btnPagos"
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Caption = "Usuarios"
        Me.btnUsuarios.Id = 20
        Me.btnUsuarios.LargeImageIndex = 20
        Me.btnUsuarios.Name = "btnUsuarios"
        '
        'btnCopiaBD
        '
        Me.btnCopiaBD.Caption = "Copiar Base Datos"
        Me.btnCopiaBD.Id = 23
        Me.btnCopiaBD.LargeImageIndex = 5
        Me.btnCopiaBD.Name = "btnCopiaBD"
        '
        'btnRestauraBd
        '
        Me.btnRestauraBd.Caption = "Restaurar Base Datos"
        Me.btnRestauraBd.Id = 24
        Me.btnRestauraBd.LargeImageIndex = 6
        Me.btnRestauraBd.Name = "btnRestauraBd"
        '
        'btnExtornos
        '
        Me.btnExtornos.Caption = "Extornar Pago"
        Me.btnExtornos.Id = 25
        Me.btnExtornos.LargeImageIndex = 31
        Me.btnExtornos.Name = "btnExtornos"
        '
        'btnReportes
        '
        Me.btnReportes.Caption = "Reportes de Ingresos"
        Me.btnReportes.Id = 27
        Me.btnReportes.LargeImageIndex = 38
        Me.btnReportes.Name = "btnReportes"
        '
        'btnConsulExt
        '
        Me.btnConsulExt.Caption = "Consultar Extornos"
        Me.btnConsulExt.Id = 28
        Me.btnConsulExt.LargeImageIndex = 9
        Me.btnConsulExt.Name = "btnConsulExt"
        '
        'btnRepPredial
        '
        Me.btnRepPredial.Caption = "Reportes Predial"
        Me.btnRepPredial.Id = 29
        Me.btnRepPredial.LargeImageIndex = 19
        Me.btnRepPredial.Name = "btnRepPredial"
        '
        'btnOrden
        '
        Me.btnOrden.Caption = "Orden de Pago"
        Me.btnOrden.Id = 30
        Me.btnOrden.LargeImageIndex = 7
        Me.btnOrden.Name = "btnOrden"
        '
        'btnPagarOrden
        '
        Me.btnPagarOrden.Caption = "Pagar Orden"
        Me.btnPagarOrden.Id = 31
        Me.btnPagarOrden.LargeImageIndex = 37
        Me.btnPagarOrden.Name = "btnPagarOrden"
        '
        'btnConsultaOrden
        '
        Me.btnConsultaOrden.Caption = "Consulta Orden"
        Me.btnConsultaOrden.Id = 32
        Me.btnConsultaOrden.LargeImageIndex = 34
        Me.btnConsultaOrden.Name = "btnConsultaOrden"
        '
        'tsbDniUsu
        '
        Me.tsbDniUsu.Id = 40
        Me.tsbDniUsu.Name = "tsbDniUsu"
        Me.tsbDniUsu.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'btnAcerca
        '
        Me.btnAcerca.Caption = "Acerca de ..."
        Me.btnAcerca.Id = 42
        Me.btnAcerca.LargeImageIndex = 32
        Me.btnAcerca.Name = "btnAcerca"
        '
        'btnListaTUO
        '
        Me.btnListaTUO.Caption = "Imprimir TUO"
        Me.btnListaTUO.Id = 43
        Me.btnListaTUO.LargeImageIndex = 21
        Me.btnListaTUO.Name = "btnListaTUO"
        '
        'tsbUsuario
        '
        Me.tsbUsuario.Id = 45
        Me.tsbUsuario.Name = "tsbUsuario"
        Me.tsbUsuario.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'btnRegistro
        '
        Me.btnRegistro.Caption = "Registrar Producto"
        Me.btnRegistro.Id = 47
        Me.btnRegistro.LargeImageIndex = 36
        Me.btnRegistro.Name = "btnRegistro"
        '
        'btnCliente
        '
        Me.btnCliente.Caption = "Reporte Contribuyente"
        Me.btnCliente.Id = 48
        Me.btnCliente.LargeImageIndex = 40
        Me.btnCliente.Name = "btnCliente"
        '
        'btnValores
        '
        Me.btnValores.Caption = "Valores Unitarios de Edificacion"
        Me.btnValores.Id = 49
        Me.btnValores.LargeImageIndex = 11
        Me.btnValores.Name = "btnValores"
        '
        'rpgRegistro
        '
        Me.rpgRegistro.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpcRegistro, Me.rpgOrdenPago})
        Me.rpgRegistro.Name = "rpgRegistro"
        Me.rpgRegistro.Text = "Predial"
        '
        'rpcRegistro
        '
        Me.rpcRegistro.ItemLinks.Add(Me.btnContribuyente)
        Me.rpcRegistro.ItemLinks.Add(Me.btnPredios, True, "", "", True)
        Me.rpcRegistro.ItemLinks.Add(Me.btnEvaluacionPredio, True)
        Me.rpcRegistro.ItemLinks.Add(Me.btnDeclaracionJurada)
        Me.rpcRegistro.ItemLinks.Add(Me.btnPagos, True)
        Me.rpcRegistro.Name = "rpcRegistro"
        Me.rpcRegistro.ShowCaptionButton = False
        Me.rpcRegistro.Text = "Registro Predial"
        '
        'rpgOrdenPago
        '
        Me.rpgOrdenPago.ItemLinks.Add(Me.btnOrden)
        Me.rpgOrdenPago.ItemLinks.Add(Me.btnPagarOrden, True)
        Me.rpgOrdenPago.ItemLinks.Add(Me.btnConsultaOrden, True)
        Me.rpgOrdenPago.Name = "rpgOrdenPago"
        Me.rpgOrdenPago.Text = "Orden de Pago"
        '
        'rpgRecaudacion
        '
        Me.rpgRecaudacion.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpcServicios, Me.rpcMaestro})
        Me.rpgRecaudacion.Name = "rpgRecaudacion"
        Me.rpgRecaudacion.Text = "Recaudacion"
        '
        'rpcServicios
        '
        Me.rpcServicios.ItemLinks.Add(Me.btnFacturar)
        Me.rpcServicios.ItemLinks.Add(Me.btnEmpoces, True, "", "", True)
        Me.rpcServicios.Name = "rpcServicios"
        Me.rpcServicios.ShowCaptionButton = False
        Me.rpcServicios.Text = "Servicios "
        '
        'rpcMaestro
        '
        Me.rpcMaestro.ItemLinks.Add(Me.btnTasas)
        Me.rpcMaestro.ItemLinks.Add(Me.btnListaTUO, True)
        Me.rpcMaestro.Name = "rpcMaestro"
        Me.rpcMaestro.ShowCaptionButton = False
        Me.rpcMaestro.Text = "Texto Unico de Tasas"
        '
        'rpgConsultas
        '
        Me.rpgConsultas.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpcConsultas, Me.rpcConsulPredial})
        Me.rpgConsultas.Name = "rpgConsultas"
        Me.rpgConsultas.Text = "Consultas"
        '
        'rpcConsultas
        '
        Me.rpcConsultas.ItemLinks.Add(Me.btnConsultaEmpoce)
        Me.rpcConsultas.ItemLinks.Add(Me.btnServicios, True)
        Me.rpcConsultas.Name = "rpcConsultas"
        Me.rpcConsultas.ShowCaptionButton = False
        Me.rpcConsultas.Text = "Consultas de Servicios"
        '
        'rpcConsulPredial
        '
        Me.rpcConsulPredial.ItemLinks.Add(Me.btnConsultaHRPu)
        Me.rpcConsulPredial.ItemLinks.Add(Me.btnRepPredial, True)
        Me.rpcConsulPredial.ItemLinks.Add(Me.btnReportes, True)
        Me.rpcConsulPredial.ItemLinks.Add(Me.btnCliente, True)
        Me.rpcConsulPredial.Name = "rpcConsulPredial"
        Me.rpcConsulPredial.ShowCaptionButton = False
        Me.rpcConsulPredial.Text = "Consultas Diversas"
        '
        'rpgControl
        '
        Me.rpgControl.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpcControlDatos})
        Me.rpgControl.Name = "rpgControl"
        Me.rpgControl.Text = "Control Maestro"
        '
        'rpcControlDatos
        '
        Me.rpcControlDatos.ItemLinks.Add(Me.btnTrimestres, True)
        Me.rpcControlDatos.ItemLinks.Add(Me.btnMotivos, True)
        Me.rpcControlDatos.ItemLinks.Add(Me.btnCondicion)
        Me.rpcControlDatos.ItemLinks.Add(Me.btnZona)
        Me.rpcControlDatos.ItemLinks.Add(Me.btnDepreciacion, True)
        Me.rpcControlDatos.ItemLinks.Add(Me.btnMontoMinimo, True)
        Me.rpcControlDatos.ItemLinks.Add(Me.btnFactorReajuste)
        Me.rpcControlDatos.ItemLinks.Add(Me.btnCuentasCts)
        Me.rpcControlDatos.ItemLinks.Add(Me.btnValores, True)
        Me.rpcControlDatos.Name = "rpcControlDatos"
        Me.rpcControlDatos.ShowCaptionButton = False
        Me.rpcControlDatos.Text = "Control de Datos"
        '
        'rpgAdmin
        '
        Me.rpgAdmin.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpcExtornos, Me.rpcBaseDatos})
        Me.rpgAdmin.Name = "rpgAdmin"
        Me.rpgAdmin.Text = "Administracion"
        '
        'rpcExtornos
        '
        Me.rpcExtornos.ItemLinks.Add(Me.btnUsuarios)
        Me.rpcExtornos.ItemLinks.Add(Me.btnExtornos, True)
        Me.rpcExtornos.ItemLinks.Add(Me.btnConsulExt, True)
        Me.rpcExtornos.Name = "rpcExtornos"
        Me.rpcExtornos.ShowCaptionButton = False
        '
        'rpcBaseDatos
        '
        Me.rpcBaseDatos.ItemLinks.Add(Me.btnCopiaBD)
        Me.rpcBaseDatos.ItemLinks.Add(Me.btnRestauraBd, True)
        Me.rpcBaseDatos.ItemLinks.Add(Me.btnAcerca, True)
        Me.rpcBaseDatos.ItemLinks.Add(Me.btnRegistro, True)
        Me.rpcBaseDatos.Name = "rpcBaseDatos"
        Me.rpcBaseDatos.ShowCaptionButton = False
        Me.rpcBaseDatos.Text = "Base de Datos"
        '
        'stbSistema
        '
        Me.stbSistema.ItemLinks.Add(Me.tsbDniUsu)
        Me.stbSistema.ItemLinks.Add(Me.tsbUsuario)
        Me.stbSistema.Location = New System.Drawing.Point(0, 226)
        Me.stbSistema.Name = "stbSistema"
        Me.stbSistema.Ribbon = Me.rbcPrincipal
        Me.stbSistema.Size = New System.Drawing.Size(642, 25)
        '
        'LookOffice
        '
        Me.LookOffice.LookAndFeel.SkinName = "Office 2010 Blue"
        '
        'ClientPanel
        '
        Me.ClientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ClientPanel.ContentImageAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.ClientPanel.Controls.Add(Me.stbSistema)
        Me.ClientPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClientPanel.Location = New System.Drawing.Point(0, 144)
        Me.ClientPanel.Name = "ClientPanel"
        Me.ClientPanel.Size = New System.Drawing.Size(642, 251)
        Me.ClientPanel.TabIndex = 2
        '
        'MdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 395)
        Me.Controls.Add(Me.ClientPanel)
        Me.Controls.Add(Me.rbcPrincipal)
        Me.IsMdiContainer = True
        Me.Name = "MdiPrincipal"
        Me.Ribbon = Me.rbcPrincipal
        Me.StatusBar = Me.stbSistema
        Me.Text = "Sistema de Recaudacion Municipal - SRM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.imgSmall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbcPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LookOffice As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents ClientPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents imgSmall As DevExpress.Utils.ImageCollection
    Friend WithEvents imgLarge As DevExpress.Utils.ImageCollection
    Friend WithEvents rbcPrincipal As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnContribuyente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPredios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEvaluacionPredio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeclaracionJurada As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFacturar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEmpoces As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgRegistro As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpcRegistro As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgRecaudacion As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpcServicios As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgConsultas As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnTasas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCuentasCts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpcMaestro As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnDepreciacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConsultaEmpoce As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpcConsultas As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpcConsulPredial As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnServicios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTrimestres As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpcControlDatos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnMotivos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnZona As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCondicion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConsultaHRPu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMontoMinimo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFactorReajuste As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPagos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgControl As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgAdmin As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpcBaseDatos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnUsuarios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCopiaBD As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRestauraBd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExtornos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpcExtornos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnReportes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConsulExt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRepPredial As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOrden As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPagarOrden As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConsultaOrden As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgOrdenPago As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents tsbDniUsu As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents stbSistema As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents ApplicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents btnSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAcerca As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnListaTUO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tsbUsuario As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btnRegistro As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCliente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnValores As DevExpress.XtraBars.BarButtonItem


End Class
