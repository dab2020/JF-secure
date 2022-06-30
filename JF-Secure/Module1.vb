Module Module1

    Sub Main()
        Console.WriteLine("**********************************************************************")
        Console.WriteLine("** JF-secure")
        Console.WriteLine("** Created by Dab2020 on github, for reverse proxing Jellyfin")
        Console.WriteLine("**********************************************************************")
        ' Creating Message boxes to be used later
        Dim answer, answer2, answer3 As MsgBoxResult
        ' To open files (Temporary Solution, the file saving system is to be improved)
        Dim file As System.IO.StreamWriter
        ' This is for the service manager and caddy. It sets it up as a process
        Dim nssm As New ProcessStartInfo
        Dim caddy As New ProcessStartInfo
        ' This portion is for Creating input boxes
        Dim Message(4), Title(4), Deafault(4)
        Dim url(4) As String
        Dim duckyes As Boolean
        ' For compatibality i could have just /
        Dim dir As String = Environment.CurrentDirectory
        ' Process exe location using above dir variable
        nssm.FileName = dir & "\nssm.exe"
        caddy.FileName = dir & "\caddy.exe"
        ' Message boxs
        answer2 = MsgBox("Is this your First time running JF-Secure", MsgBoxStyle.YesNo)
        If answer2 = MsgBoxResult.Yes Then
            Message(1) = "Enter your domain"    ' Set prompt.
            Message(2) = "Enter the url of Jellyfin in the following format: localhost:8096"
            Message(3) = "Enter DuckDNS domain"
            Message(4) = "Enter your DuckDNS token"
            Title(1) = "JF-Secure Domian Inputter"    ' Set title.
            Title(2) = "JF-Secure Server URL inputter"
            Title(3) = "JF-Secure DuckDNS inputter"
            Title(4) = "JF-Secure DuckDNS inputter"
            Deafault(1) = "example.org"    ' Set default.
            Deafault(2) = "localhost:8096"
            Deafault(3) = "example.duckdns.org"
            Deafault(4) = "00000000000"
            ' Display message, title, and default value.
            url(1) = InputBox(Message(1), Title(1), Deafault(1))
            url(2) = InputBox(Message(2), Title(2), Deafault(2))
            ' Implementation is in progress
            answer3 = MsgBox("Do you want to add DuckDNS support", MsgBoxStyle.YesNo)
            If answer3 = MsgBoxResult.Yes Then
                url(3) = InputBox(Message(3), Title(3), Deafault(3))
                url(4) = InputBox(Message(4), Title(4), Deafault(4))
                duckyes = True
            End If

            answer = MsgBox("Do you want to save your config?", MsgBoxStyle.YesNo)
            If answer = MsgBoxResult.Yes Then
                If duckyes Then
                    Dim fileReader As String = My.Computer.FileSystem.ReadAllText(dir & "\duckdnsbasefile").Replace("example.org", url(1)).Replace("00token00", "Help")
                    My.Computer.FileSystem.WriteAllText(dir & "\caddyfile", fileReader, False)
                End If
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
        Process.Start(caddy)
    End Sub
End Module