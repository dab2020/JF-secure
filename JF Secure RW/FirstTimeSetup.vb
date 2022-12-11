Imports System.IO
Public Module FirstTimeSetup
    ' This sub deals with inputting
    Public Sub FTS()
        ' Dim backup As Boolean
        Dim response As MsgBoxResult
        ' Checks if we have a backup. New Feature in *4.0*
        response = MsgBox("Hi Welcome to JF-Secure. We will have you up and running in a few minutes. (Make Sure ports are open & DNS set before proceeding) But Before we do, Do you have a backup from a previous Install?", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then
            BackupImport()
        Else
            ' Has the domain and url inputter by the user and saves them to My.Settings.<>
            My.Settings.Domain = InputBox("Enter the Domain that you want Jellyfin to be accessible to be on: ", "Enter Domain", "jellyfin.duckdns.org")
            My.Settings.Jellyurl = InputBox("Enter the current address that Jellyfin is on: : ", "Enter jellyfin Server Address", "localhost:8096")
            My.Settings.Save()
            Savefile()
            Batfilecreate()
            StartWinsswservice()
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
        ' Creates a Bat file that Nssm uses to start and stop the Caddy Service
        Dim dir As String = Environment.CurrentDirectory
        Dim batfilewrite As StreamWriter
        batfilewrite = New StreamWriter(dir & "\caddy.bat")
        batfilewrite.WriteLine("cd " & dir)
        batfilewrite.WriteLine("caddy run")
        batfilewrite.Close()
    End Sub
    Public Sub StartWinsswservice()
        ' This is for the service manager and caddy. It sets it up as a background service
        Shell("JF-Secure(WinSSW).exe install")
        Threading.Thread.Sleep(5000)
        Shell("JF-Secure(WinSSW).exe start")
        Threading.Thread.Sleep(5000)
        Shell("JF-Secure(WinSSW).exe start")
        Threading.Thread.Sleep(5000)
        Console.WriteLine("Press Any Key to Exit...")
    End Sub

    Public Sub RemoveWinSSW()
        ' Removes the WinSSW service that allows for a clean uninstall
        Shell("JF-Secure(WinSSW).exe stop")
        Threading.Thread.Sleep(5000)
        Shell("JF-Secure(WinSSW).exe uninstall")
        Threading.Thread.Sleep(5000)
        Console.WriteLine("Press Any Key to Exit...")
    End Sub
End Module
