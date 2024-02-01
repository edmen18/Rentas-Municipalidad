Imports System.Management
Imports Microsoft.Win32

Public Class RegistroProducto
    Private clavevalida As String

    Private Sub RegistroProducto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub RegistroProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ObtenerSerieHD()
        ObtenerClaveValida()
    End Sub

    Sub ObtenerSerieHD()
        Dim DriveLetter As String = "C"  'Letra de la unidad de disco
        Dim SerialNumber As String       'Numero de serie
        Dim disk As ManagementObject = New ManagementObject("win32_logicaldisk.deviceid=""" & DriveLetter & ":""")
        disk.Get()
        If Not disk("VolumeSerialNumber") Is Nothing Then
            SerialNumber = disk("VolumeSerialNumber").ToString
        Else
            SerialNumber = "No Information Avalaible"
        End If
        Me.lblSerieHD.Text = SerialNumber & "TS010"
    End Sub

    Sub ObtenerClaveValida()
        Try
            ' Si el texto de usuario tiene mde 1 caracter, entonces seguimos adelante
            If Me.lblSerieHD.Text.Trim.Length > 1 Then
                ' Pasamos a la funciel texto de usuario para generar su
                ' clave de usuario de aplicaci
                clavevalida = GenerarClave(Me.lblSerieHD.Text.Trim)
            Else
                ' Mensaje de aviso de que el texto de usuario debe tener
                ' al menos dos caracteres
                MessageBox.Show("Debe introducir al menos dos caracteres")
            End If
        Catch ex As Exception
            ' Mensaje de error en la generacide la clave de usuario
            MessageBox.Show("Se ha producido un error en la generacide la clave")
            'Me.TextBox1.Text = "Error"
        End Try
    End Sub

    Private Function GenerarClave(ByVal usuario As String) As String
        ' Obtenemos la longitud de la cadena de usuario
        Dim longitud As Byte = usuario.Length
        ' Declaramos valorEntrada para obtener el valor general
        ' correspondiente a la entrada de usuario
        Dim valorEntrada As Long = 0
        ' Recorremos la cadena entera para sumar el valor
        ' total de sus cASCII
        For I As Byte = 0 To longitud - 1
            valorEntrada += Asc(usuario.Substring(I, 1))
        Next
        ' Dividimos el valor final resultante de la suma de
        ' sus valores ASCII entre la longitud de la cadena
        valorEntrada \= longitud
        ' Obtenemos un valor base que corresponde con el
        ' cdel producto entre el valor de entrada 
        ' anteriormente calcula por su longitud
        Dim valorBase As Integer = valorEntrada * longitud
        Dim key As String = ""
        ' Empezamos obteniento valores
        ' Obtenemos el valor hexadecimal
        Dim valor As String = Hex(valorBase + (120 * 10000))
        key &= valor.Substring(valor.Length - 6, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (98 * 12400))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(0, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (77 * 14800))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(valor.Length - 6, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (121 * 17500))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(0, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (55 * 20000))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(valor.Length - 6, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (134 * 22300))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(0, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (63 * 25000))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(valor.Length - 6, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (117 * 27200))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(0, 6)
        ' Devolvemos el valor final (xxxxxx-xxxxxx-xxxxxx-xxxxxx-xxxxxx-xxxxxx-xxxxxx-xxxxxx)
        Return key
    End Function

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged
        Me.txtUsuario.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtClaveProducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClaveProducto.TextChanged
        Me.txtClaveProducto.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub btnActivarAhora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivarAhora.Click
        If Trim(Me.txtClaveProducto.Text) = Trim(clavevalida) And Me.txtClaveProducto.Text <> "" Then
            MessageBox.Show("Gracias por adquirir el producto... vuelva a ingresar al Sistema", "SRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Guarda en el Regedit la activacion
            CrearKey()
            End
            'activa caracetristicas
        Else
            MessageBox.Show("Licencia no es valida...", "SIAMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Sub CrearKey()
        Try
            Registry.LocalMachine.CreateSubKey("Software\SRMTel").SetValue("Green", 256)
            Registry.LocalMachine.CreateSubKey("Software\SRMTel").Close()
        Catch ex As Exception
        End Try
    End Sub
    Sub CrearLicTemp()
        Try
            Registry.LocalMachine.CreateSubKey("Software\SRMTel").SetValue("Green", 150)
            Registry.LocalMachine.CreateSubKey("Software\SRMTel").Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnActivarDespues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivarDespues.Click
        CrearLicTemp()
        MessageBox.Show("Programa activado en modo Prueba", "Validar Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub

    
End Class