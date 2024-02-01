Friend Class Cl_Ribbon
    Private Sub New()
    End Sub
    Shared Sub Main()
        DevExpress.UserSkins.OfficeSkins.Register()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New FrmInicioSesion())
    End Sub
End Class

