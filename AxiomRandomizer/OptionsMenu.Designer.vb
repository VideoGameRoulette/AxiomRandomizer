﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBoxRandomizeCustomDrone = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCustomColorDrone = New System.Windows.Forms.CheckBox()
        Me.ButtonDroneDarkColor = New System.Windows.Forms.Button()
        Me.ButtonDroneLightColor = New System.Windows.Forms.Button()
        Me.LabelDroneColor = New System.Windows.Forms.Label()
        Me.CheckBoxRemoveMetallicPing = New System.Windows.Forms.CheckBox()
        Me.ButtonCoatDarkColor = New System.Windows.Forms.Button()
        Me.ButtonCoatLightColor = New System.Windows.Forms.Button()
        Me.LabelCoatColor = New System.Windows.Forms.Label()
        Me.ButtonCheckUpdate = New System.Windows.Forms.Button()
        Me.CheckBoxRandomizeFakeCoat = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSeperateCoat = New System.Windows.Forms.CheckBox()
        Me.CheckBoxNewSeedGenerator = New System.Windows.Forms.CheckBox()
        Me.ButtonClearDecompileFolders = New System.Windows.Forms.Button()
        Me.ButtonResetSettings = New System.Windows.Forms.Button()
        Me.CheckBoxDebug = New System.Windows.Forms.CheckBox()
        Me.LabelXML = New System.Windows.Forms.Label()
        Me.TrackBarXML = New System.Windows.Forms.TrackBar()
        Me.CheckBoxXMLLimit = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDefaultMenuSettings = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSaveMenuSettings = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ButtonXnbcliLocation = New System.Windows.Forms.Button()
        Me.TextBoxXnbcliLocation = New System.Windows.Forms.TextBox()
        Me.Labelxnbcli = New System.Windows.Forms.Label()
        Me.ButtonRandoExeChangeName = New System.Windows.Forms.Button()
        Me.TextBoxRandomExeLocation = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonIlasmLocation = New System.Windows.Forms.Button()
        Me.TextBoxIlasmLocation = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonIldasmLocation = New System.Windows.Forms.Button()
        Me.TextBoxIldasmLocation = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonXMLLocation = New System.Windows.Forms.Button()
        Me.TextBoxXMLSaveLocation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonSaveLocation = New System.Windows.Forms.Button()
        Me.TextBoxSaveFileLocation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonExeLocation = New System.Windows.Forms.Button()
        Me.TextBoxGameLocation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonWorkingFolder = New System.Windows.Forms.Button()
        Me.ButtonVanillaFolder = New System.Windows.Forms.Button()
        Me.TextBoxWorkingDecompile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxVanillaDecompile = New System.Windows.Forms.TextBox()
        Me.TabPageDebugTab = New System.Windows.Forms.TabPage()
        Me.ButtonDelWhiteCoatIl = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonAddWhiteCoatIL = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TrackBarXML, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPageDebugTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPageDebugTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(284, 461)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CheckBoxRandomizeCustomDrone)
        Me.TabPage1.Controls.Add(Me.CheckBoxCustomColorDrone)
        Me.TabPage1.Controls.Add(Me.ButtonDroneDarkColor)
        Me.TabPage1.Controls.Add(Me.ButtonDroneLightColor)
        Me.TabPage1.Controls.Add(Me.LabelDroneColor)
        Me.TabPage1.Controls.Add(Me.CheckBoxRemoveMetallicPing)
        Me.TabPage1.Controls.Add(Me.ButtonCoatDarkColor)
        Me.TabPage1.Controls.Add(Me.ButtonCoatLightColor)
        Me.TabPage1.Controls.Add(Me.LabelCoatColor)
        Me.TabPage1.Controls.Add(Me.ButtonCheckUpdate)
        Me.TabPage1.Controls.Add(Me.CheckBoxRandomizeFakeCoat)
        Me.TabPage1.Controls.Add(Me.CheckBoxSeperateCoat)
        Me.TabPage1.Controls.Add(Me.CheckBoxNewSeedGenerator)
        Me.TabPage1.Controls.Add(Me.ButtonClearDecompileFolders)
        Me.TabPage1.Controls.Add(Me.ButtonResetSettings)
        Me.TabPage1.Controls.Add(Me.CheckBoxDebug)
        Me.TabPage1.Controls.Add(Me.LabelXML)
        Me.TabPage1.Controls.Add(Me.TrackBarXML)
        Me.TabPage1.Controls.Add(Me.CheckBoxXMLLimit)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(276, 435)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Basic Options"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CheckBoxRandomizeCustomDrone
        '
        Me.CheckBoxRandomizeCustomDrone.AutoSize = True
        Me.CheckBoxRandomizeCustomDrone.Enabled = False
        Me.CheckBoxRandomizeCustomDrone.Location = New System.Drawing.Point(9, 249)
        Me.CheckBoxRandomizeCustomDrone.Name = "CheckBoxRandomizeCustomDrone"
        Me.CheckBoxRandomizeCustomDrone.Size = New System.Drawing.Size(263, 17)
        Me.CheckBoxRandomizeCustomDrone.TabIndex = 20
        Me.CheckBoxRandomizeCustomDrone.Text = "Randomize Drone Color When Game Randomized"
        Me.ToolTip1.SetToolTip(Me.CheckBoxRandomizeCustomDrone, "This Randomizes the color of Drone_Custom file for each time the game is randomiz" &
        "ed.")
        Me.CheckBoxRandomizeCustomDrone.UseVisualStyleBackColor = True
        '
        'CheckBoxCustomColorDrone
        '
        Me.CheckBoxCustomColorDrone.AutoSize = True
        Me.CheckBoxCustomColorDrone.Location = New System.Drawing.Point(9, 226)
        Me.CheckBoxCustomColorDrone.Name = "CheckBoxCustomColorDrone"
        Me.CheckBoxCustomColorDrone.Size = New System.Drawing.Size(138, 17)
        Me.CheckBoxCustomColorDrone.TabIndex = 19
        Me.CheckBoxCustomColorDrone.Text = "Customize Drone Colors"
        Me.ToolTip1.SetToolTip(Me.CheckBoxCustomColorDrone, "Creates a second DroneTexture_Custom File to allow custom drones.")
        Me.CheckBoxCustomColorDrone.UseVisualStyleBackColor = True
        '
        'ButtonDroneDarkColor
        '
        Me.ButtonDroneDarkColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDroneDarkColor.Location = New System.Drawing.Point(173, 268)
        Me.ButtonDroneDarkColor.Name = "ButtonDroneDarkColor"
        Me.ButtonDroneDarkColor.Size = New System.Drawing.Size(90, 23)
        Me.ButtonDroneDarkColor.TabIndex = 18
        Me.ButtonDroneDarkColor.UseVisualStyleBackColor = True
        '
        'ButtonDroneLightColor
        '
        Me.ButtonDroneLightColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDroneLightColor.Location = New System.Drawing.Point(83, 268)
        Me.ButtonDroneLightColor.Name = "ButtonDroneLightColor"
        Me.ButtonDroneLightColor.Size = New System.Drawing.Size(90, 23)
        Me.ButtonDroneLightColor.TabIndex = 17
        Me.ButtonDroneLightColor.UseVisualStyleBackColor = True
        '
        'LabelDroneColor
        '
        Me.LabelDroneColor.AutoSize = True
        Me.LabelDroneColor.Location = New System.Drawing.Point(6, 273)
        Me.LabelDroneColor.Name = "LabelDroneColor"
        Me.LabelDroneColor.Size = New System.Drawing.Size(71, 13)
        Me.LabelDroneColor.TabIndex = 16
        Me.LabelDroneColor.Text = "Drone Colors:"
        '
        'CheckBoxRemoveMetallicPing
        '
        Me.CheckBoxRemoveMetallicPing.AutoSize = True
        Me.CheckBoxRemoveMetallicPing.Location = New System.Drawing.Point(9, 297)
        Me.CheckBoxRemoveMetallicPing.Name = "CheckBoxRemoveMetallicPing"
        Me.CheckBoxRemoveMetallicPing.Size = New System.Drawing.Size(139, 17)
        Me.CheckBoxRemoveMetallicPing.TabIndex = 15
        Me.CheckBoxRemoveMetallicPing.Text = "Remove ""Metallic Ping"""
        Me.ToolTip1.SetToolTip(Me.CheckBoxRemoveMetallicPing, "This removes the annoying Metallic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ping that occurs when enemies resist damage.")
        Me.CheckBoxRemoveMetallicPing.UseVisualStyleBackColor = True
        '
        'ButtonCoatDarkColor
        '
        Me.ButtonCoatDarkColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCoatDarkColor.Location = New System.Drawing.Point(173, 197)
        Me.ButtonCoatDarkColor.Name = "ButtonCoatDarkColor"
        Me.ButtonCoatDarkColor.Size = New System.Drawing.Size(90, 23)
        Me.ButtonCoatDarkColor.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.ButtonCoatDarkColor, "This is the current light color of the fake coat." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.ButtonCoatDarkColor.UseVisualStyleBackColor = True
        '
        'ButtonCoatLightColor
        '
        Me.ButtonCoatLightColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCoatLightColor.Location = New System.Drawing.Point(83, 197)
        Me.ButtonCoatLightColor.Name = "ButtonCoatLightColor"
        Me.ButtonCoatLightColor.Size = New System.Drawing.Size(90, 23)
        Me.ButtonCoatLightColor.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.ButtonCoatLightColor, "This is the current light color of the fake coat." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.ButtonCoatLightColor.UseVisualStyleBackColor = True
        '
        'LabelCoatColor
        '
        Me.LabelCoatColor.AutoSize = True
        Me.LabelCoatColor.Location = New System.Drawing.Point(6, 202)
        Me.LabelCoatColor.Name = "LabelCoatColor"
        Me.LabelCoatColor.Size = New System.Drawing.Size(64, 13)
        Me.LabelCoatColor.TabIndex = 12
        Me.LabelCoatColor.Text = "Coat Colors:"
        '
        'ButtonCheckUpdate
        '
        Me.ButtonCheckUpdate.Location = New System.Drawing.Point(9, 349)
        Me.ButtonCheckUpdate.Name = "ButtonCheckUpdate"
        Me.ButtonCheckUpdate.Size = New System.Drawing.Size(100, 23)
        Me.ButtonCheckUpdate.TabIndex = 11
        Me.ButtonCheckUpdate.Text = "Check for Update"
        Me.ButtonCheckUpdate.UseVisualStyleBackColor = True
        '
        'CheckBoxRandomizeFakeCoat
        '
        Me.CheckBoxRandomizeFakeCoat.AutoSize = True
        Me.CheckBoxRandomizeFakeCoat.Enabled = False
        Me.CheckBoxRandomizeFakeCoat.Location = New System.Drawing.Point(9, 177)
        Me.CheckBoxRandomizeFakeCoat.Name = "CheckBoxRandomizeFakeCoat"
        Me.CheckBoxRandomizeFakeCoat.Size = New System.Drawing.Size(258, 17)
        Me.CheckBoxRandomizeFakeCoat.TabIndex = 10
        Me.CheckBoxRandomizeFakeCoat.Text = "Randomize Fake Color When Game Randomized"
        Me.ToolTip1.SetToolTip(Me.CheckBoxRandomizeFakeCoat, "This Randomizes the color of TraceCoat file for each time the game is randomized." &
        "")
        Me.CheckBoxRandomizeFakeCoat.UseVisualStyleBackColor = True
        '
        'CheckBoxSeperateCoat
        '
        Me.CheckBoxSeperateCoat.AutoSize = True
        Me.CheckBoxSeperateCoat.Location = New System.Drawing.Point(9, 154)
        Me.CheckBoxSeperateCoat.Name = "CheckBoxSeperateCoat"
        Me.CheckBoxSeperateCoat.Size = New System.Drawing.Size(176, 17)
        Me.CheckBoxSeperateCoat.TabIndex = 9
        Me.CheckBoxSeperateCoat.Text = "Seperate Fake && Real Lab Coat"
        Me.ToolTip1.SetToolTip(Me.CheckBoxSeperateCoat, "Creates a second TraceCoat_Fake File to allow custom fake coats")
        Me.CheckBoxSeperateCoat.UseVisualStyleBackColor = True
        '
        'CheckBoxNewSeedGenerator
        '
        Me.CheckBoxNewSeedGenerator.AutoSize = True
        Me.CheckBoxNewSeedGenerator.Location = New System.Drawing.Point(9, 57)
        Me.CheckBoxNewSeedGenerator.Name = "CheckBoxNewSeedGenerator"
        Me.CheckBoxNewSeedGenerator.Size = New System.Drawing.Size(178, 17)
        Me.CheckBoxNewSeedGenerator.TabIndex = 8
        Me.CheckBoxNewSeedGenerator.Text = "Generate a new seed on launch"
        Me.ToolTip1.SetToolTip(Me.CheckBoxNewSeedGenerator, "By default the tool uses your last seed when loaded." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enabling this will generate" &
        " a new seed on every launch.")
        Me.CheckBoxNewSeedGenerator.UseVisualStyleBackColor = True
        '
        'ButtonClearDecompileFolders
        '
        Me.ButtonClearDecompileFolders.Location = New System.Drawing.Point(118, 320)
        Me.ButtonClearDecompileFolders.Name = "ButtonClearDecompileFolders"
        Me.ButtonClearDecompileFolders.Size = New System.Drawing.Size(150, 23)
        Me.ButtonClearDecompileFolders.TabIndex = 7
        Me.ButtonClearDecompileFolders.Text = "Clear Decompile Folders"
        Me.ToolTip1.SetToolTip(Me.ButtonClearDecompileFolders, "This will empty your decompile folders." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a good option if you wish to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "r" &
        "e-decompile the game with new settings. ")
        Me.ButtonClearDecompileFolders.UseVisualStyleBackColor = True
        '
        'ButtonResetSettings
        '
        Me.ButtonResetSettings.Location = New System.Drawing.Point(9, 320)
        Me.ButtonResetSettings.Name = "ButtonResetSettings"
        Me.ButtonResetSettings.Size = New System.Drawing.Size(100, 23)
        Me.ButtonResetSettings.TabIndex = 6
        Me.ButtonResetSettings.Text = "Reset Settings"
        Me.ToolTip1.SetToolTip(Me.ButtonResetSettings, "This resets your local settings and closing the tool." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This can be helpful to try" &
        " and fix issues.")
        Me.ButtonResetSettings.UseVisualStyleBackColor = True
        '
        'CheckBoxDebug
        '
        Me.CheckBoxDebug.AutoSize = True
        Me.CheckBoxDebug.Location = New System.Drawing.Point(9, 131)
        Me.CheckBoxDebug.Name = "CheckBoxDebug"
        Me.CheckBoxDebug.Size = New System.Drawing.Size(133, 17)
        Me.CheckBoxDebug.TabIndex = 5
        Me.CheckBoxDebug.Text = "Enable Debug Options"
        Me.ToolTip1.SetToolTip(Me.CheckBoxDebug, "This allows a larger printout of the randomizer function." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THIS WILL SPOIL SEEDS." &
        "")
        Me.CheckBoxDebug.UseVisualStyleBackColor = True
        '
        'LabelXML
        '
        Me.LabelXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelXML.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelXML.Location = New System.Drawing.Point(49, 100)
        Me.LabelXML.Name = "LabelXML"
        Me.LabelXML.Size = New System.Drawing.Size(39, 13)
        Me.LabelXML.TabIndex = 4
        Me.LabelXML.Text = "10"
        Me.LabelXML.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TrackBarXML
        '
        Me.TrackBarXML.Enabled = False
        Me.TrackBarXML.Location = New System.Drawing.Point(94, 80)
        Me.TrackBarXML.Maximum = 100
        Me.TrackBarXML.Name = "TrackBarXML"
        Me.TrackBarXML.Size = New System.Drawing.Size(179, 45)
        Me.TrackBarXML.TabIndex = 3
        Me.TrackBarXML.TickFrequency = 10
        Me.TrackBarXML.Value = 10
        '
        'CheckBoxXMLLimit
        '
        Me.CheckBoxXMLLimit.AutoSize = True
        Me.CheckBoxXMLLimit.Location = New System.Drawing.Point(9, 80)
        Me.CheckBoxXMLLimit.Name = "CheckBoxXMLLimit"
        Me.CheckBoxXMLLimit.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxXMLLimit.TabIndex = 2
        Me.CheckBoxXMLLimit.Text = "Limit XMLS"
        Me.ToolTip1.SetToolTip(Me.CheckBoxXMLLimit, "The tool by default creates a spoiler XML file in the XML Folder." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This can autom" &
        "atically limit xml files to a certain number.")
        Me.CheckBoxXMLLimit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonDefaultMenuSettings)
        Me.GroupBox1.Controls.Add(Me.RadioButtonSaveMenuSettings)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonDefaultMenuSettings
        '
        Me.RadioButtonDefaultMenuSettings.AutoSize = True
        Me.RadioButtonDefaultMenuSettings.Checked = True
        Me.RadioButtonDefaultMenuSettings.Location = New System.Drawing.Point(103, 19)
        Me.RadioButtonDefaultMenuSettings.Name = "RadioButtonDefaultMenuSettings"
        Me.RadioButtonDefaultMenuSettings.Size = New System.Drawing.Size(100, 17)
        Me.RadioButtonDefaultMenuSettings.TabIndex = 1
        Me.RadioButtonDefaultMenuSettings.TabStop = True
        Me.RadioButtonDefaultMenuSettings.Text = "Default Settings"
        Me.RadioButtonDefaultMenuSettings.UseVisualStyleBackColor = True
        '
        'RadioButtonSaveMenuSettings
        '
        Me.RadioButtonSaveMenuSettings.AutoSize = True
        Me.RadioButtonSaveMenuSettings.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonSaveMenuSettings.Name = "RadioButtonSaveMenuSettings"
        Me.RadioButtonSaveMenuSettings.Size = New System.Drawing.Size(91, 17)
        Me.RadioButtonSaveMenuSettings.TabIndex = 0
        Me.RadioButtonSaveMenuSettings.Text = "Save Settings"
        Me.RadioButtonSaveMenuSettings.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ButtonXnbcliLocation)
        Me.TabPage2.Controls.Add(Me.TextBoxXnbcliLocation)
        Me.TabPage2.Controls.Add(Me.Labelxnbcli)
        Me.TabPage2.Controls.Add(Me.ButtonRandoExeChangeName)
        Me.TabPage2.Controls.Add(Me.TextBoxRandomExeLocation)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.ButtonIlasmLocation)
        Me.TabPage2.Controls.Add(Me.TextBoxIlasmLocation)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.ButtonIldasmLocation)
        Me.TabPage2.Controls.Add(Me.TextBoxIldasmLocation)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.ButtonXMLLocation)
        Me.TabPage2.Controls.Add(Me.TextBoxXMLSaveLocation)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.ButtonSaveLocation)
        Me.TabPage2.Controls.Add(Me.TextBoxSaveFileLocation)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.ButtonExeLocation)
        Me.TabPage2.Controls.Add(Me.TextBoxGameLocation)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.ButtonWorkingFolder)
        Me.TabPage2.Controls.Add(Me.ButtonVanillaFolder)
        Me.TabPage2.Controls.Add(Me.TextBoxWorkingDecompile)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.TextBoxVanillaDecompile)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(276, 435)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Folder Options"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ButtonXnbcliLocation
        '
        Me.ButtonXnbcliLocation.Location = New System.Drawing.Point(243, 328)
        Me.ButtonXnbcliLocation.Name = "ButtonXnbcliLocation"
        Me.ButtonXnbcliLocation.Size = New System.Drawing.Size(25, 23)
        Me.ButtonXnbcliLocation.TabIndex = 28
        Me.ButtonXnbcliLocation.Text = "..."
        Me.ToolTip1.SetToolTip(Me.ButtonXnbcliLocation, "This is where the tool stores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the location of a texture converter." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.ButtonXnbcliLocation.UseVisualStyleBackColor = True
        Me.ButtonXnbcliLocation.Visible = False
        '
        'TextBoxXnbcliLocation
        '
        Me.TextBoxXnbcliLocation.Location = New System.Drawing.Point(8, 331)
        Me.TextBoxXnbcliLocation.Name = "TextBoxXnbcliLocation"
        Me.TextBoxXnbcliLocation.ReadOnly = True
        Me.TextBoxXnbcliLocation.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxXnbcliLocation.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.TextBoxXnbcliLocation, "This is where the tool stores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the location of a texture converter." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.TextBoxXnbcliLocation.Visible = False
        '
        'Labelxnbcli
        '
        Me.Labelxnbcli.AutoSize = True
        Me.Labelxnbcli.Location = New System.Drawing.Point(8, 315)
        Me.Labelxnbcli.Name = "Labelxnbcli"
        Me.Labelxnbcli.Size = New System.Drawing.Size(115, 13)
        Me.Labelxnbcli.TabIndex = 26
        Me.Labelxnbcli.Text = "xnbcli Saved Location:"
        Me.ToolTip1.SetToolTip(Me.Labelxnbcli, "This is where the tool stores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the location of a texture converter.")
        Me.Labelxnbcli.Visible = False
        '
        'ButtonRandoExeChangeName
        '
        Me.ButtonRandoExeChangeName.Location = New System.Drawing.Point(213, 134)
        Me.ButtonRandoExeChangeName.Name = "ButtonRandoExeChangeName"
        Me.ButtonRandoExeChangeName.Size = New System.Drawing.Size(55, 23)
        Me.ButtonRandoExeChangeName.TabIndex = 25
        Me.ButtonRandoExeChangeName.Text = "Change"
        Me.ToolTip1.SetToolTip(Me.ButtonRandoExeChangeName, "This sets what your randomized" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "game exe will be named.")
        Me.ButtonRandoExeChangeName.UseVisualStyleBackColor = True
        '
        'TextBoxRandomExeLocation
        '
        Me.TextBoxRandomExeLocation.Enabled = False
        Me.TextBoxRandomExeLocation.Location = New System.Drawing.Point(8, 136)
        Me.TextBoxRandomExeLocation.Name = "TextBoxRandomExeLocation"
        Me.TextBoxRandomExeLocation.ReadOnly = True
        Me.TextBoxRandomExeLocation.Size = New System.Drawing.Size(199, 20)
        Me.TextBoxRandomExeLocation.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.TextBoxRandomExeLocation, "This sets what your randomized" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "game exe will be named.")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Randomized Game Name:"
        Me.ToolTip1.SetToolTip(Me.Label8, "This sets what your randomized" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "game exe will be named.")
        '
        'ButtonIlasmLocation
        '
        Me.ButtonIlasmLocation.Location = New System.Drawing.Point(243, 290)
        Me.ButtonIlasmLocation.Name = "ButtonIlasmLocation"
        Me.ButtonIlasmLocation.Size = New System.Drawing.Size(25, 23)
        Me.ButtonIlasmLocation.TabIndex = 20
        Me.ButtonIlasmLocation.Text = "..."
        Me.ToolTip1.SetToolTip(Me.ButtonIlasmLocation, "This is where the tool stores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the location of the recompiler.")
        Me.ButtonIlasmLocation.UseVisualStyleBackColor = True
        '
        'TextBoxIlasmLocation
        '
        Me.TextBoxIlasmLocation.Location = New System.Drawing.Point(8, 292)
        Me.TextBoxIlasmLocation.Name = "TextBoxIlasmLocation"
        Me.TextBoxIlasmLocation.ReadOnly = True
        Me.TextBoxIlasmLocation.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxIlasmLocation.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.TextBoxIlasmLocation, "This is where the tool stores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the location of the recompiler.")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Ilasm.exe Saved Location:"
        Me.ToolTip1.SetToolTip(Me.Label7, "This is where the tool stores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the location of the recompiler.")
        '
        'ButtonIldasmLocation
        '
        Me.ButtonIldasmLocation.Location = New System.Drawing.Point(243, 251)
        Me.ButtonIldasmLocation.Name = "ButtonIldasmLocation"
        Me.ButtonIldasmLocation.Size = New System.Drawing.Size(25, 23)
        Me.ButtonIldasmLocation.TabIndex = 17
        Me.ButtonIldasmLocation.Text = "..."
        Me.ToolTip1.SetToolTip(Me.ButtonIldasmLocation, "This is where the tool stores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the location of the decompiler.")
        Me.ButtonIldasmLocation.UseVisualStyleBackColor = True
        '
        'TextBoxIldasmLocation
        '
        Me.TextBoxIldasmLocation.Location = New System.Drawing.Point(8, 253)
        Me.TextBoxIldasmLocation.Name = "TextBoxIldasmLocation"
        Me.TextBoxIldasmLocation.ReadOnly = True
        Me.TextBoxIldasmLocation.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxIldasmLocation.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.TextBoxIldasmLocation, "This is where the tool stores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the location of the decompiler.")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Ildasm.exe Saved Location:"
        Me.ToolTip1.SetToolTip(Me.Label6, "This is where the tool stores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the location of the decompiler.")
        '
        'ButtonXMLLocation
        '
        Me.ButtonXMLLocation.Location = New System.Drawing.Point(243, 212)
        Me.ButtonXMLLocation.Name = "ButtonXMLLocation"
        Me.ButtonXMLLocation.Size = New System.Drawing.Size(25, 23)
        Me.ButtonXMLLocation.TabIndex = 14
        Me.ButtonXMLLocation.Text = "..."
        Me.ToolTip1.SetToolTip(Me.ButtonXMLLocation, "This is where the tool stores the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "spoiler xml files generated on randomization.")
        Me.ButtonXMLLocation.UseVisualStyleBackColor = True
        '
        'TextBoxXMLSaveLocation
        '
        Me.TextBoxXMLSaveLocation.Location = New System.Drawing.Point(8, 214)
        Me.TextBoxXMLSaveLocation.Name = "TextBoxXMLSaveLocation"
        Me.TextBoxXMLSaveLocation.ReadOnly = True
        Me.TextBoxXMLSaveLocation.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxXMLSaveLocation.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.TextBoxXMLSaveLocation, "This is where the tool stores the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "spoiler xml files generated on randomization.")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "XML Save Folder:"
        Me.ToolTip1.SetToolTip(Me.Label5, "This is where the tool stores the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "spoiler xml files generated on randomization.")
        '
        'ButtonSaveLocation
        '
        Me.ButtonSaveLocation.Location = New System.Drawing.Point(243, 173)
        Me.ButtonSaveLocation.Name = "ButtonSaveLocation"
        Me.ButtonSaveLocation.Size = New System.Drawing.Size(25, 23)
        Me.ButtonSaveLocation.TabIndex = 11
        Me.ButtonSaveLocation.Text = "..."
        Me.ToolTip1.SetToolTip(Me.ButtonSaveLocation, "This is where the tool stores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "where Axiom Verge saves.")
        Me.ButtonSaveLocation.UseVisualStyleBackColor = True
        '
        'TextBoxSaveFileLocation
        '
        Me.TextBoxSaveFileLocation.Location = New System.Drawing.Point(8, 175)
        Me.TextBoxSaveFileLocation.Name = "TextBoxSaveFileLocation"
        Me.TextBoxSaveFileLocation.ReadOnly = True
        Me.TextBoxSaveFileLocation.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxSaveFileLocation.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.TextBoxSaveFileLocation, "This is where the tool stores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "where Axiom Verge saves.")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Game Save Location:"
        Me.ToolTip1.SetToolTip(Me.Label4, "This is where the tool stores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "where Axiom Verge saves.")
        '
        'ButtonExeLocation
        '
        Me.ButtonExeLocation.Location = New System.Drawing.Point(243, 95)
        Me.ButtonExeLocation.Name = "ButtonExeLocation"
        Me.ButtonExeLocation.Size = New System.Drawing.Size(25, 23)
        Me.ButtonExeLocation.TabIndex = 8
        Me.ButtonExeLocation.Text = "..."
        Me.ToolTip1.SetToolTip(Me.ButtonExeLocation, "This is where the tool stores your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "actual game directory.")
        Me.ButtonExeLocation.UseVisualStyleBackColor = True
        '
        'TextBoxGameLocation
        '
        Me.TextBoxGameLocation.Location = New System.Drawing.Point(8, 97)
        Me.TextBoxGameLocation.Name = "TextBoxGameLocation"
        Me.TextBoxGameLocation.ReadOnly = True
        Me.TextBoxGameLocation.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxGameLocation.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.TextBoxGameLocation, "This is where the tool stores your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "actual game directory.")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Game Location:"
        Me.ToolTip1.SetToolTip(Me.Label3, "This is where the tool stores your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "actual game directory.")
        '
        'ButtonWorkingFolder
        '
        Me.ButtonWorkingFolder.Location = New System.Drawing.Point(243, 56)
        Me.ButtonWorkingFolder.Name = "ButtonWorkingFolder"
        Me.ButtonWorkingFolder.Size = New System.Drawing.Size(25, 23)
        Me.ButtonWorkingFolder.TabIndex = 5
        Me.ButtonWorkingFolder.Text = "..."
        Me.ToolTip1.SetToolTip(Me.ButtonWorkingFolder, "This is where the tool stores the game " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "code that has been randomized.")
        Me.ButtonWorkingFolder.UseVisualStyleBackColor = True
        '
        'ButtonVanillaFolder
        '
        Me.ButtonVanillaFolder.Location = New System.Drawing.Point(243, 17)
        Me.ButtonVanillaFolder.Name = "ButtonVanillaFolder"
        Me.ButtonVanillaFolder.Size = New System.Drawing.Size(25, 23)
        Me.ButtonVanillaFolder.TabIndex = 4
        Me.ButtonVanillaFolder.Text = "..."
        Me.ToolTip1.SetToolTip(Me.ButtonVanillaFolder, "This is where the tool stores the base " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "game code for randomizing.")
        Me.ButtonVanillaFolder.UseVisualStyleBackColor = True
        '
        'TextBoxWorkingDecompile
        '
        Me.TextBoxWorkingDecompile.Location = New System.Drawing.Point(8, 58)
        Me.TextBoxWorkingDecompile.Name = "TextBoxWorkingDecompile"
        Me.TextBoxWorkingDecompile.ReadOnly = True
        Me.TextBoxWorkingDecompile.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxWorkingDecompile.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TextBoxWorkingDecompile, "This is where the tool stores the game " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "code that has been randomized.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Working Decompiled Folder:"
        Me.ToolTip1.SetToolTip(Me.Label2, "This is where the tool stores the game " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "code that has been randomized." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vanilla Decompiled Folder:"
        Me.ToolTip1.SetToolTip(Me.Label1, "This is where the tool stores the Base " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Game Code for Randomizing")
        '
        'TextBoxVanillaDecompile
        '
        Me.TextBoxVanillaDecompile.Location = New System.Drawing.Point(8, 19)
        Me.TextBoxVanillaDecompile.Name = "TextBoxVanillaDecompile"
        Me.TextBoxVanillaDecompile.ReadOnly = True
        Me.TextBoxVanillaDecompile.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxVanillaDecompile.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TextBoxVanillaDecompile, "This is where the tool stores the Base " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Game Code for Randomizing")
        '
        'TabPageDebugTab
        '
        Me.TabPageDebugTab.Controls.Add(Me.ButtonDelWhiteCoatIl)
        Me.TabPageDebugTab.Controls.Add(Me.Label9)
        Me.TabPageDebugTab.Controls.Add(Me.ButtonAddWhiteCoatIL)
        Me.TabPageDebugTab.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDebugTab.Name = "TabPageDebugTab"
        Me.TabPageDebugTab.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDebugTab.Size = New System.Drawing.Size(276, 435)
        Me.TabPageDebugTab.TabIndex = 2
        Me.TabPageDebugTab.Text = "Debug"
        Me.TabPageDebugTab.UseVisualStyleBackColor = True
        '
        'ButtonDelWhiteCoatIl
        '
        Me.ButtonDelWhiteCoatIl.Location = New System.Drawing.Point(143, 6)
        Me.ButtonDelWhiteCoatIl.Name = "ButtonDelWhiteCoatIl"
        Me.ButtonDelWhiteCoatIl.Size = New System.Drawing.Size(125, 23)
        Me.ButtonDelWhiteCoatIl.TabIndex = 2
        Me.ButtonDelWhiteCoatIl.Text = "Del WhiteCoat IL"
        Me.ButtonDelWhiteCoatIl.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 404)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 26)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "This tab is intended for Testing " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and implementing odd fixes"
        '
        'ButtonAddWhiteCoatIL
        '
        Me.ButtonAddWhiteCoatIL.Location = New System.Drawing.Point(8, 6)
        Me.ButtonAddWhiteCoatIL.Name = "ButtonAddWhiteCoatIL"
        Me.ButtonAddWhiteCoatIL.Size = New System.Drawing.Size(125, 23)
        Me.ButtonAddWhiteCoatIL.TabIndex = 0
        Me.ButtonAddWhiteCoatIL.Text = "Add WhiteCoat IL"
        Me.ButtonAddWhiteCoatIL.UseVisualStyleBackColor = True
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        '
        'OptionsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OptionsMenu"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TrackBarXML, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPageDebugTab.ResumeLayout(False)
        Me.TabPageDebugTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonDefaultMenuSettings As RadioButton
    Friend WithEvents RadioButtonSaveMenuSettings As RadioButton
    Friend WithEvents TextBoxWorkingDecompile As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxVanillaDecompile As TextBox
    Friend WithEvents LabelXML As Label
    Friend WithEvents TrackBarXML As TrackBar
    Friend WithEvents CheckBoxXMLLimit As CheckBox
    Friend WithEvents ButtonXMLLocation As Button
    Friend WithEvents TextBoxXMLSaveLocation As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonSaveLocation As Button
    Friend WithEvents TextBoxSaveFileLocation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonExeLocation As Button
    Friend WithEvents TextBoxGameLocation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonWorkingFolder As Button
    Friend WithEvents ButtonVanillaFolder As Button
    Friend WithEvents CheckBoxDebug As CheckBox
    Friend WithEvents ButtonIldasmLocation As Button
    Friend WithEvents TextBoxIldasmLocation As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonIlasmLocation As Button
    Friend WithEvents TextBoxIlasmLocation As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonClearDecompileFolders As Button
    Friend WithEvents ButtonResetSettings As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ButtonRandoExeChangeName As Button
    Friend WithEvents TextBoxRandomExeLocation As TextBox
    Friend WithEvents CheckBoxNewSeedGenerator As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBoxRandomizeFakeCoat As CheckBox
    Friend WithEvents CheckBoxSeperateCoat As CheckBox
    Friend WithEvents Labelxnbcli As Label
    Friend WithEvents ButtonXnbcliLocation As Button
    Friend WithEvents TextBoxXnbcliLocation As TextBox
    Friend WithEvents TabPageDebugTab As TabPage
    Friend WithEvents ButtonAddWhiteCoatIL As Button
    Friend WithEvents ButtonDelWhiteCoatIl As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonCoatDarkColor As Button
    Friend WithEvents ButtonCoatLightColor As Button
    Friend WithEvents LabelCoatColor As Label
    Friend WithEvents ButtonCheckUpdate As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents CheckBoxRemoveMetallicPing As CheckBox
    Friend WithEvents CheckBoxRandomizeCustomDrone As CheckBox
    Friend WithEvents CheckBoxCustomColorDrone As CheckBox
    Friend WithEvents ButtonDroneDarkColor As Button
    Friend WithEvents ButtonDroneLightColor As Button
    Friend WithEvents LabelDroneColor As Label
End Class
