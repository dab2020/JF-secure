Module Module1

    Sub Main()
        Console.WriteLine("**********************************************************************")
        Console.WriteLine("** JF-secure")
        Console.WriteLine("** Created by Dab2020 on github, for reverse proxing Jellyfin")
        Console.WriteLine("**********************************************************************")
        Dim answer, answer2 As MsgBoxResult
        Dim file As System.IO.StreamWriter
        Dim nssm As New ProcessStartInfo
        Dim caddy As New ProcessStartInfo
        Dim Message(2), Title(2), Deafault(2)
        Dim url(2) As String
        Dim dir As String = Environment.CurrentDirectory
        nssm.FileName = dir & "\nssm.exe"
        caddy.FileName = dir & "\caddy.exe"
        answer2 = MsgBox("Is this your First time running JF-Secure", MsgBoxStyle.YesNo)
        If answer2 = MsgBoxResult.Yes Then
            Message(1) = "Enter your domain"    ' Set prompt.
            Message(2) = "Enter the url of Jellyfin in the following format: localhost:8096"
            Title(1) = "JF-Secure Domian Inputter"    ' Set title.
            Title(2) = "JF-Secure Server URL inputter"
            Deafault(1) = "example.org"    ' Set default.
            Deafault(2) = "localhost:8096"
            ' Display message, title, and default value.
            url(1) = InputBox(Message(1), Title(1), Deafault(1))
            url(2) = InputBox(Message(2), Title(2), Deafault(2))
            answer = MsgBox("Do you want to save your config?", MsgBoxStyle.YesNo)
            If answer = MsgBoxResult.Yes Then
                file = My.Computer.FileSystem.OpenTextFileWriter(dir & "\caddyfile", True)
                file.WriteLine(url(1) & " {")
                file.WriteLine("	encode gzip")
                file.WriteLine("		}")
                file.WriteLine("    reverse_proxy " & url(2) & " ")
                file.WriteLine("}")
                file.Close()
                MsgBox("File saved.")
                nssm.Arguments = "install JF-Secure caddy.exe [start]"
                Process.Start(nssm)
                caddy.Arguments = "start"
                Process.Start(caddy)
                MsgBox("Service has been started")
                End
            End If
        Else
            MsgBox("JF-Secure should already be running in the background")
        End If
        Console.ReadKey()
    End Sub

End Module
