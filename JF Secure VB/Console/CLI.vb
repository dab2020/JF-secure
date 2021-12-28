Module Module1

    Sub Main()
        Console.WriteLine("**********************************************************************")
        Console.WriteLine("** JF-secure")
        Console.WriteLine("** Created by Dab2020 on github, for reverse proxing Jellyfin")
        Console.WriteLine("**********************************************************************")
        Dim answer, answer2 As String
        Dim file As System.IO.StreamWriter
        Dim nssm As New ProcessStartInfo
        Dim caddy As New ProcessStartInfo
        Dim url(2) As String
        Dim dir As String = Environment.CurrentDirectory
        nssm.FileName = dir & "\nssm.exe"
        caddy.FileName = dir & "\caddy.exe"
        Console.WriteLine("Is this your first time running JF-Secure? Type Yes/No")
        answer2 = Console.ReadLine()
        If answer2 = "YES" Or answer2 = "yes" Then
            Console.WriteLine("Enter your Domain in the format of example.com")
            url(1) = Console.ReadLine()
            Console.WriteLine("Enter your Jellyfin's Server url i.e localhost:8096")
            url(2) = Console.ReadLine()
            Console.WriteLine("Do you want to save your Config Type Yes/No")
            answer = Console.ReadLine()
            If answer = "Yes" Or answer = "yes" Then
                file = My.Computer.FileSystem.OpenTextFileWriter(dir & "\caddyfile", True)
                file.WriteLine(url(1) & " {")
                file.WriteLine("	encode gzip")
                file.WriteLine("		}")
                file.WriteLine("    reverse_proxy " & url(2) & " ")
                file.WriteLine("}")
                file.Close()
                Console.WriteLine("File saved.")
                nssm.Arguments = "install JF-Secure caddy.exe [start]"
                Process.Start(nssm)
                caddy.Arguments = "start"
                Process.Start(caddy)
                MsgBox("Service has been started")
                End
            End If
        Else
            Console.WriteLine("JF-Secure should already be running in the background")
        End If
        Console.ReadKey()
    End Sub

End Module
