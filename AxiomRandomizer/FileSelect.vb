﻿Imports System.IO    'Files
Imports System.ComponentModel 'Backgroundworker
Imports System.Environment 'appdata
Imports System.Threading 'Multithreading
Public Class FileSelect
#Region "Form Events"
    Dim SteamAppID As String = "332200"
    Private Sub FileSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Here we force the express setup even if this a second use of the menu.
        ExpressSettings()
        'My.Settings.Reset()
        My.Settings.Save()
        Me.Text = Me.Text & " Ver: " & My.Application.Info.Version.ToString
        CheckUpdate()
        CheckSettings()
    End Sub
    Private Sub FileSelect_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Application.OpenForms().OfType(Of RandomMenu).Any Then
            RandomMenu.Show()
        End If
    End Sub
#End Region
#Region "EXE Updater"
    Sub CheckUpdate()
        'Dim Temp As ThreadStart = New ThreadStart With (OnlineVersion.CheckUpdate)
        Dim checkUpdateThread = New Thread(AddressOf OnlineVersion.CheckUpdate)
        checkUpdateThread.SetApartmentState(ApartmentState.STA)
        checkUpdateThread.Start()
    End Sub
#End Region
#Region "Exe Already Setup"
    Private Sub CheckSettings()
        If My.Settings.UpgradeRequired = True Then
            My.Settings.Upgrade()
            My.Settings.UpgradeRequired = False
            My.Settings.Save()
        End If
        '1 time moving PackUnpack Files
        If My.Settings.IldasmSavedPath = "" OrElse
           My.Settings.IlasmSavedPath = "" Then
            CheckPackUnpackFiles()
        End If
        'Setting Default Coat Colors
        If My.Settings.CurrentCoatLightColor.ToArgb = 0 Then My.Settings.CurrentCoatLightColor = Color.FromArgb(223, 215, 201)
        If My.Settings.CurrentCoatDarkColor.ToArgb = 0 Then My.Settings.CurrentCoatDarkColor = Color.FromArgb(127, 115, 105)
        'Setting Default Drone Colors
        If My.Settings.CurrentDroneLightColor.ToArgb = 0 Then My.Settings.CurrentDroneLightColor = Color.FromArgb(214, 134, 98)
        If My.Settings.CurrentDroneDarkColor.ToArgb = 0 Then My.Settings.CurrentDroneDarkColor = Color.FromArgb(114, 66, 44)
        If My.Settings.ExeFilePath <> "" Then
            'Making Sure Save File is located
            If My.Settings.SaveFilePath = "" Then
                GetSaveFile()
            End If
            'Making Sure Xml Setting is initalised
            If My.Settings.XMLSaveLocation = "" Then
                My.Settings.XMLSaveLocation = Path.GetDirectoryName(My.Settings.ExeFilePath) & Path.DirectorySeparatorChar
            End If
            'Making Sure the Random Exe Setting is initalised
            If My.Settings.RandoExePath = "" Then
                My.Settings.RandoExePath = Path.GetDirectoryName(My.Settings.ExeFilePath) & Path.DirectorySeparatorChar & "RandomAV.exe"
            End If
            'Adding in a function to Undo the randomized white coat and adding ion the fake coat.
            PackUnpack.WhiteCoatCheck()
            If CheckChangeLog() = True Then
                If CheckVanillaFolder() = True Then
                    If Not Application.OpenForms().OfType(Of RandomMenu).Any Then
                        RandomMenu.Show()
                    End If
                End If
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
        If My.Settings.VanillaDecompileLocation = "" Then
            Return False
        ElseIf Not Directory.Exists(My.Settings.VanillaDecompileLocation) Then
            Return False
        ElseIf My.Settings.ManualDecompilePending = True Then
            PackUnpack.ModifyCode(My.Settings.VanillaDecompileLocation & Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".iL")
            Return True
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
                PackUnpack.GetUnpackerPath()
                PackUnpack.GetpackerPath()
            End If
        End If
    End Sub
#End Region
    Private Sub AVFileSelector_Click(sender As Object, e As EventArgs) Handles AVFileSelector.Click
        GetExeFile()
    End Sub
    Shared Sub GetExeFile()
        If Not My.Settings.ExeFilePath = "" Then
            If File.Exists(My.Settings.ExeFilePath) Then
                FileSelect.OpenFileExe.InitialDirectory = Path.GetDirectoryName(My.Settings.ExeFilePath)
            End If
        End If
        If FileSelect.OpenFileExe.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            If FileSelect.OpenFileExe.FileName.Contains("AxiomVerge") Then
                FileSelect.CheckVersion(FileSelect.OpenFileExe.FileName)
            Else
                MessageBox.Show("Please Select Axiom Verge exe file.")
            End If
        End If
    End Sub
    Shared Sub GetSaveFile()
        If My.Settings.SteamVersion Then
            If Directory.Exists("C:\Steam\userdata") Then
                Dim UserDirectories() As String = Directory.GetDirectories("C:\Steam\userdata")
                For Each TestDirectory As String In UserDirectories
                    If Directory.Exists(TestDirectory & "\" & FileSelect.SteamAppID) Then
                        FileSelect.OpenFileSave.InitialDirectory = TestDirectory & "\" & FileSelect.SteamAppID & "\remote"
                    End If
                Next
            ElseIf Directory.Exists("C:\Program Files (x86)\Steam\userdata") Then
                Dim UserDirectories() As String = Directory.GetDirectories("C:\Program Files (x86)\Steam\userdata")
                For Each TestDirectory As String In UserDirectories
                    If Directory.Exists(TestDirectory & "\" & FileSelect.SteamAppID) Then
                        FileSelect.OpenFileSave.InitialDirectory = TestDirectory & "\" & FileSelect.SteamAppID & "\remote"
                    End If
                Next
            End If
            If FileSelect.OpenFileSave.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim filename As String = Path.GetFileName(FileSelect.OpenFileSave.FileName)
                filename = filename.ToLower
                If filename.Contains("save") Then
                    My.Settings.SaveFilePath = Path.GetDirectoryName(FileSelect.OpenFileSave.FileName)
                Else
                    MessageBox.Show("Save Location Error: Reopen exe")
                End If
            End If
        Else 'Epic Version
            If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\SavedGames\AxiomVerge\Saves\Player1\") Then
                FileSelect.OpenFileSave.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\SavedGames\AxiomVerge\Saves\Player1\"
            End If
            If FileSelect.OpenFileSave.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim filename As String = Path.GetFileName(FileSelect.OpenFileSave.FileName)
                filename = filename.ToLower
                If filename.Contains("save") Then
                    My.Settings.SaveFilePath = Path.GetDirectoryName(FileSelect.OpenFileSave.FileName)
                Else
                    MessageBox.Show("Save Location Error: Reopen exe")
                End If
            End If
        End If
    End Sub
    Private Sub CheckVersion(EXEFilePath As String)
        TextBoxFilePath.Text = EXEFilePath
        If ExeVersions.CheckExe(EXEFilePath) = True Then
            CheckBackup(EXEFilePath)
            My.Settings.ExeFilePath = EXEFilePath
            My.Settings.XMLSaveLocation = Path.GetDirectoryName(My.Settings.ExeFilePath) & Path.DirectorySeparatorChar
            My.Settings.RandoExePath = Path.GetDirectoryName(EXEFilePath) & Path.DirectorySeparatorChar & "RandomAV.exe"
            GetSaveFile()
            My.Settings.ExpressExtractUsed = RadioExpress.Checked
            If PackUnpack.UnpacktoAppdata(EXEFilePath,
                                CheckBoxSave.Checked,
                                CheckBoxLabcoat.Checked,
                                CheckBoxAnimations.Checked,
                                CheckBoxBackground.Checked,
                                CheckBoxWakeUp.Checked,
                                CheckBoxDisruptorTrace.Checked) = True Then
                If My.Settings.SeperateLabCoats Then
                    If Not PackUnpack.Graphics.CreateFakeCoat() Then
                        My.Settings.SeperateLabCoats = False
                        My.Settings.RandomizeFakeCoat = False
                    End If
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
            If Not ExeVersions.CheckBackup(BackupPath, EXEFilePath) Then
                Dim x As Integer = 0
                Do
                    x = x + 1
                    BackupPath = BackupFolder & BackupFileName & " - (" & CStr(x) & ")" & BackupFileExtension
                Loop While File.Exists(BackupPath)
            Else
                ' if the hashes for the backup and the tested exe are the same, then we do not have to make a backup file.
                Exit Sub
            End If
        End If
        Try
            File.Copy(EXEFilePath, BackupPath, Overwrite)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "Express and custom settings"
    Private Sub RadioExpress_CheckedChanged(sender As Object, e As EventArgs) Handles RadioExpress.CheckedChanged 'Radio Custom would be redunant
        If RadioExpress.Checked = True Then
            ExpressSettings()
        Else
            Me.Width = 250
            Me.Height = 260
        End If
    End Sub
    Sub ExpressSettings()
        Me.Width = 250
        Me.Height = 140
        RadioExpress.Checked = True
        CheckBoxSave.Checked = True
        CheckBoxLabcoat.Checked = True
        CheckBoxAnimations.Checked = True
        CheckBoxBackground.Checked = True
        CheckBoxWakeUp.Checked = True
        CheckBoxDisruptorTrace.Checked = True
    End Sub
#End Region

End Class
