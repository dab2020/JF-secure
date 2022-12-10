Imports System.IO
Imports System.Windows.Forms
Public Module Housekeeping
    Public Sub BackupImport()
        ' Imports the Backup (the caddy file) for quick and easy startup
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim backupFileName As String
        backupFileName = ""
        fd.Title = "Select BackUp file"
        fd.InitialDirectory = "C:\"
        fd.Filter = "JF-Secure Backup Files|*.jfsbk"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            backupFileName = fd.FileName
        End If

        File.Copy(backupFileName, Environment.CurrentDirectory & "\caddyfile", True)
        Batfilecreate()
        StartWinsswservice()
    End Sub

    Public Sub Savebackup()
        ' Saves the Backup (the caddy file) for quick and easy startup
        Dim backupsave As String
        backupsave = ""
        Dim objFolderDlg As System.Windows.Forms.FolderBrowserDialog
        objFolderDlg = New System.Windows.Forms.FolderBrowserDialog
        If objFolderDlg.ShowDialog() = DialogResult.OK Then
            MessageBox.Show(objFolderDlg.SelectedPath)
            backupsave = objFolderDlg.SelectedPath
        End If
        Dim fs As FileStream = File.Create(backupsave & "\backup.jfsbk")
        File.Copy(Environment.CurrentDirectory & "\caddyfile", backupsave & "\backup.jfsbk", True)
    End Sub

    Public Sub ServiceChk()

    End Sub
End Module
