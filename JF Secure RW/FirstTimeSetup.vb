Imports System
Imports System.IO
Public Module FirstTimeSetup
    ' This sub deals with inputting
    Public Sub FTS()
        ' Dim backup As Boolean
        Dim response As MsgBoxResult
        ' Checks if we have a backup. New Feature in *4.0*
        response = MsgBox("Hi Welcome to JF-Secure. We will have you up and running in a few minutes. But Before we do, Do you have a backup from a previous Install?", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then
            BackupImport()
        Else
            ' Has the domain and url inputter by the user and saves them to My.Settings.<>
            My.Settings.Domain = InputBox("Enter the Domain that you want Jellyfin to be accessible to be on: ", "Enter Domain", "jellyfin.duckdns.org")
            My.Settings.Jellyurl = InputBox("Enter the current address that Jellyfin is on: : ", "Enter jellyfin Server Address", "localhost:8096")
            My.Settings.Save()
            Savefile()
            Batfilecreate()
            Startnssmservice()
        End If

    End Sub

    Public Sub Savefile()
        ' Takes the My.Setting variables and saves them into a caddyfile
        Dim dir As String = Environment.CurrentDirectory
        Dim caddyfilewrite As StreamWriter
        caddyfilewrite = New StreamWriter(dir & "\caddyfile")
        caddyfilewrite.WriteLine(My.Settings.Domain)
        caddyfilewrite.WriteLine("reverse_proxy " & My.Settings.Jellyurl)
        caddyfilewrite.Close()
        MsgBox("Config Saved Successfully")
    End Sub

    Public Sub Batfilecreate()
        Dim dir As String = Environment.CurrentDirectory
        Dim batfilewrite As StreamWriter
        batfilewrite = New StreamWriter(dir & "\caddy.bat")
        batfilewrite.WriteLine("cd " & dir)
        batfilewrite.WriteLine("caddy run")
        batfilewrite.Close()
    End Sub
    Public Sub Startnssmservice()
        ' This is for the service manager and caddy. It sets it up as a process
        Dim nssm As New ProcessStartInfo
        Dim caddy As New ProcessStartInfo
        nssm.FileName = Environment.CurrentDirectory & "\nssm.exe"
        caddy.FileName = Environment.CurrentDirectory & "\caddy.exe"
        nssm.Arguments = "install JF-Secure " & Environment.CurrentDirectory & "/caddy.bat"
    End Sub

    Public Sub Removenssm()
        Dim nssmr As New ProcessStartInfo
        nssmr.FileName = Environment.CurrentDirectory & "\nssm.exe"
        nssmr.Arguments = "remove JF-Secure"
    End Sub
End Module
