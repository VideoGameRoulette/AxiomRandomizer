﻿Imports System.IO    'Files
Imports System.ComponentModel 'Backgroundworker
Imports System.Environment 'appdata
Imports System.Threading 'Multithreading
Public Class FileSelect
    Dim SteamAppID As String = "332200"
    Private Sub FileSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Settings.Reset()
        'My.Settings.Save()
        Me.Text = Me.Text & " Ver: " & My.Application.Info.Version.ToString
        CheckUpdate()
        CheckSettings()
    End Sub
    Private Sub FileSelect_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Application.OpenForms().OfType(Of RandomMenu).Any Then
            RandomMenu.Show()
        End If
    End Sub
#Region "Exe Already Setup"
    Private Sub CheckSettings()
        If My.Settings.UpgradeRequired = True Then
            My.Settings.Upgrade()
            My.Settings.UpgradeRequired = False
            My.Settings.Save()
        End If
        If My.Settings.ExeFilePath <> "" Then
            If My.Settings.SaveFilePath = "" Then
                GetSaveFile()
            End If
            If CheckChangeLog() = True Then
                If CheckVanillaFolder() = True Then
                    If Not Application.OpenForms().OfType(Of RandomMenu).Any Then
                        RandomMenu.Show()
                    End If
                End If
            End If
        Else '1 time moving PackUnpack Files
            If My.Settings.IldasmSavedPath = "" OrElse
           My.Settings.IlasmSavedPath = "" Then
                CheckPackUnpackFiles()
            End If
        End If
    End Sub
    Private Function CheckChangeLog()
        Dim ChangeLogPath As String = Path.GetDirectoryName(My.Settings.ExeFilePath) & Path.DirectorySeparatorChar & "changelog.txt"
        If File.Exists(ChangeLogPath) Then
            Dim reader As New StreamReader(ChangeLogPath)
            For i As Integer = 0 To 3 '4 lines, text should match 3rd line however
                If reader.ReadLine() = My.Settings.VersionString Then
                    Return True
                End If
            Next
            'if no lines return true.
            MessageBox.Show("Game version has changed!" & vbNewLine &
                "Game has to be backup & extracted again")
            Return False
        Else
            If MessageBox.Show("Change log not found" & vbNewLine &
                "Continue without backing up? (Not reccomended)", "Version not found!", MessageBoxButtons.YesNo) =
                DialogResult.Yes Then
                Return True
            Else
                Return False
            End If
            Return False
        End If
    End Function
    Function CheckVanillaFolder()
        If Directory.Exists(GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\Dump") Then
            GeneralTools.DeleteAllItems(GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\Dump")
            Return False
        ElseIf Not Directory.Exists(GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\VanillaFiles") Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub CheckPackUnpackFiles()
        If File.Exists(Path.GetDirectoryName(Application.ExecutablePath) &
                       Path.DirectorySeparatorChar & "PackUnpack\ildasm.exe") Then
            If MessageBox.Show("Would you like to move the Packing & Unpacking Tools to Appdata?" & vbNewLine & "(Recommended)", "Move tools to appdata?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim AppDataStorage As String = GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\"
                GeneralTools.FolderCheck(AppDataStorage)
                GeneralTools.MoveAllItems(Path.GetDirectoryName(Application.ExecutablePath) &
                       Path.DirectorySeparatorChar & "PackUnpack\", AppDataStorage &
                       Path.DirectorySeparatorChar & "PackUnpack\")
            End If
        End If
    End Sub
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not My.Settings.ExeFilePath = "" Then
            If File.Exists(My.Settings.ExeFilePath) Then
                OpenFileExe.InitialDirectory = Path.GetDirectoryName(My.Settings.ExeFilePath)
            End If
        End If
        If OpenFileExe.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            If OpenFileExe.FileName.Contains("AxiomVerge") Then
                CheckVersion(OpenFileExe.FileName)
            Else
                MessageBox.Show("Please Select Axiom Verge exe file.")
            End If
        End If
    End Sub
    Sub GetSaveFile()
        If Directory.Exists("C:\Steam\userdata") Then
            Dim UserDirectories() As String = Directory.GetDirectories("C:\Steam\userdata")
            For Each TestDirectory As String In UserDirectories
                If Directory.Exists(TestDirectory & "\" & SteamAppID) Then
                    OpenFileSave.InitialDirectory = TestDirectory & "\" & SteamAppID
                End If
            Next
        ElseIf Directory.Exists("C:\Program Files (x86)\Steam\userdata") Then
            Dim UserDirectories() As String = Directory.GetDirectories("C:\Program Files (x86)\Steam\userdata")
            For Each TestDirectory As String In UserDirectories
                If Directory.Exists(TestDirectory & "\" & SteamAppID) Then
                    OpenFileSave.InitialDirectory = TestDirectory & "\" & SteamAppID
                End If
            Next
        End If
        If OpenFileSave.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim filename As String = Path.GetFileName(OpenFileSave.FileName)
            filename = filename.ToLower
            If filename = "remotecache.vdf" Then
                My.Settings.SaveFilePath = Path.GetDirectoryName(OpenFileSave.FileName)
            Else
                MessageBox.Show("Save Location Error: Reopen exe")
            End If
        End If
    End Sub
    Private Sub CheckVersion(EXEFilePath As String)
        TextBoxFilePath.Text = EXEFilePath
        If ExeVersions.CheckExe(EXEFilePath) = True Then
            CheckBackup(EXEFilePath)
            My.Settings.ExeFilePath = EXEFilePath
            If My.Settings.SaveFilePath = "" Then
                GetSaveFile()
            End If
            If PackUnpack.UnpacktoAppdata(EXEFilePath) = True Then
                If Application.OpenForms().OfType(Of RandomMenu).Any Then
                    RandomMenu.SetExePath()
                End If
                RandomMenu.Show()
            End If
        End If
    End Sub
    Private Sub CheckBackup(EXEFilePath)
        Dim Overwrite As Boolean = False
        Dim BackupFolder As String = Path.GetDirectoryName(EXEFilePath) & Path.DirectorySeparatorChar
        Dim BackupFileName As String = Path.GetFileNameWithoutExtension(EXEFilePath)
        Dim BackupFileExtension As String = ".bak"
        Dim BackupPath As String = BackupFolder & BackupFileName & BackupFileExtension
        If File.Exists(BackupPath) Then
            ExeVersions.CheckBackup(BackupPath, EXEFilePath)
            Dim x As Integer = 0
            Do
                x = x + 1
                BackupPath = BackupFolder & BackupFileName & " - (" & CStr(x) & ")" & BackupFileExtension
            Loop While File.Exists(BackupPath)
        End If
        Try
            File.Copy(EXEFilePath, BackupPath, Overwrite)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#Region "EXE Updater"
    Public Shared WithEvents BackgroundApplicationUpdate As BackgroundWorker = New BackgroundWorker
    Public Shared Sub BackgroundApplicationUpdate_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundApplicationUpdate.DoWork
        OnlineVersion.CheckUpdate()
    End Sub
    Sub CheckUpdate()
        'Dim Temp As ThreadStart = New ThreadStart With (OnlineVersion.CheckUpdate)
        Dim checkUpdateThread = New Thread(AddressOf OnlineVersion.CheckUpdate)
        checkUpdateThread.SetApartmentState(ApartmentState.STA)
        checkUpdateThread.Start()
    End Sub
#End Region

End Class