Imports System
Imports System.IO
Imports System.Windows.Forms
Public Module Housekeeping
    Public Sub BackupImport()
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim backupFileName As String

        fd.Title = "Select BackUp file"
        fd.InitialDirectory = "C:\"
        fd.Filter = "JF-Secure Backup Files|*.jfsbk"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            backupFileName = fd.FileName
        End If

        File.Copy(backupFileName, Environment.CurrentDirectory & "\caddyfile", True)
    End Sub

    Public Sub Savebackup()
        Dim backupsave As String
        Dim objFolderDlg As System.Windows.Forms.FolderBrowserDialog
        objFolderDlg = New System.Windows.Forms.FolderBrowserDialog
        If objFolderDlg.ShowDialog() = DialogResult.OK Then
            MessageBox.Show(objFolderDlg.SelectedPath)
            backupsave = objFolderDlg.SelectedPath
        End If
        File.Copy(Environment.CurrentDirectory & "\caddyfile", backupsave & "\backup-" & Date.Today & ".jfsbk", True)
    End Sub

    Public Sub ServiceChk()

    End Sub
End Module
