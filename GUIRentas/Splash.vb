Imports Microsoft.Win32

Public NotInheritable Class Splash

    Dim variables As New variables
    'TODO: Este formulario se puede establecer fácilmente como pantalla de bienvenida para la aplicación desde la ficha "Aplicación"
    '  del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").


    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configure el texto del cuadro de diálogo en tiempo de ejecución según la información del ensamblado de la aplicación.  

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Información de Copyright
        Copyright.Text = My.Application.Info.Copyright
        Verificacion()
    End Sub

    Sub GetKey()
        Try
            verificaReg = CStr(Registry.LocalMachine.OpenSubKey("Software\SRMTel").GetValue("Green"))
            If verificaReg <> "256" Then
                'RegistroProducto.ShowDialog()
                MessageBox.Show("Software esta en modo Prueba", "Validar Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'FrmInicioSesion.Show()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub Verificacion()
        Try
            Dim verificar As RegistryKey
            verificar = (Registry.LocalMachine.OpenSubKey("Software\SRMTel", True))
            If verificar IsNot Nothing Then
                'MessageBox.Show("La clave ya estaba creada, ahora te muestro lo k tiene", "Validar Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GetKey()
            Else
                RegistroProducto.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub


End Class
