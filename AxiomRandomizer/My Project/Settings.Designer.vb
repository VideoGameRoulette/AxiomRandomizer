﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ExeFilePath() As String
            Get
                Return CType(Me("ExeFilePath"),String)
            End Get
            Set
                Me("ExeFilePath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property VersionString() As String
            Get
                Return CType(Me("VersionString"),String)
            End Get
            Set
                Me("VersionString") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property IldasmSavedPath() As String
            Get
                Return CType(Me("IldasmSavedPath"),String)
            End Get
            Set
                Me("IldasmSavedPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property PreviousSeed() As String
            Get
                Return CType(Me("PreviousSeed"),String)
            End Get
            Set
                Me("PreviousSeed") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property IlasmSavedPath() As String
            Get
                Return CType(Me("IlasmSavedPath"),String)
            End Get
            Set
                Me("IlasmSavedPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property RandoExePath() As String
            Get
                Return CType(Me("RandoExePath"),String)
            End Get
            Set
                Me("RandoExePath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SaveFilePath() As String
            Get
                Return CType(Me("SaveFilePath"),String)
            End Get
            Set
                Me("SaveFilePath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property UpgradeRequired() As Boolean
            Get
                Return CType(Me("UpgradeRequired"),Boolean)
            End Get
            Set
                Me("UpgradeRequired") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ManualDecompilePending() As Boolean
            Get
                Return CType(Me("ManualDecompilePending"),Boolean)
            End Get
            Set
                Me("ManualDecompilePending") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ExeHashString() As String
            Get
                Return CType(Me("ExeHashString"),String)
            End Get
            Set
                Me("ExeHashString") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SteamVersion() As Boolean
            Get
                Return CType(Me("SteamVersion"),Boolean)
            End Get
            Set
                Me("SteamVersion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ExpressExtractUsed() As Boolean
            Get
                Return CType(Me("ExpressExtractUsed"),Boolean)
            End Get
            Set
                Me("ExpressExtractUsed") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0.0.0.0")>  _
        Public Property ExtractionVersion() As String
            Get
                Return CType(Me("ExtractionVersion"),String)
            End Get
            Set
                Me("ExtractionVersion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property XMLLimited() As Boolean
            Get
                Return CType(Me("XMLLimited"),Boolean)
            End Get
            Set
                Me("XMLLimited") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property XMLLimitCount() As Integer
            Get
                Return CType(Me("XMLLimitCount"),Integer)
            End Get
            Set
                Me("XMLLimitCount") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property DebugMode() As Boolean
            Get
                Return CType(Me("DebugMode"),Boolean)
            End Get
            Set
                Me("DebugMode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("""Default""")>  _
        Public Property MapGeneration() As String
            Get
                Return CType(Me("MapGeneration"),String)
            End Get
            Set
                Me("MapGeneration") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property XMLSaveLocation() As String
            Get
                Return CType(Me("XMLSaveLocation"),String)
            End Get
            Set
                Me("XMLSaveLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property VanillaDecompileLocation() As String
            Get
                Return CType(Me("VanillaDecompileLocation"),String)
            End Get
            Set
                Me("VanillaDecompileLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property WorkingDecompileLocation() As String
            Get
                Return CType(Me("WorkingDecompileLocation"),String)
            End Get
            Set
                Me("WorkingDecompileLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property RandomSeedOnLaunch() As Boolean
            Get
                Return CType(Me("RandomSeedOnLaunch"),Boolean)
            End Get
            Set
                Me("RandomSeedOnLaunch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SaveMenuSettings() As Boolean
            Get
                Return CType(Me("SaveMenuSettings"),Boolean)
            End Get
            Set
                Me("SaveMenuSettings") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MenuSavedDifficulty() As String
            Get
                Return CType(Me("MenuSavedDifficulty"),String)
            End Get
            Set
                Me("MenuSavedDifficulty") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MenuSavedMapOptions() As String
            Get
                Return CType(Me("MenuSavedMapOptions"),String)
            End Get
            Set
                Me("MenuSavedMapOptions") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property MenuSavedUkkin_Na1Way() As Boolean
            Get
                Return CType(Me("MenuSavedUkkin_Na1Way"),Boolean)
            End Get
            Set
                Me("MenuSavedUkkin_Na1Way") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property MenuSavedIllusionDelete() As Boolean
            Get
                Return CType(Me("MenuSavedIllusionDelete"),Boolean)
            End Get
            Set
                Me("MenuSavedIllusionDelete") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property MenuSavedZi1Way() As Boolean
            Get
                Return CType(Me("MenuSavedZi1Way"),Boolean)
            End Get
            Set
                Me("MenuSavedZi1Way") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MenuSavedOpenEribu() As Boolean
            Get
                Return CType(Me("MenuSavedOpenEribu"),Boolean)
            End Get
            Set
                Me("MenuSavedOpenEribu") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MenuSavedOpenElsenova() As Boolean
            Get
                Return CType(Me("MenuSavedOpenElsenova"),Boolean)
            End Get
            Set
                Me("MenuSavedOpenElsenova") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MenuSavedOpenAbsu() As Boolean
            Get
                Return CType(Me("MenuSavedOpenAbsu"),Boolean)
            End Get
            Set
                Me("MenuSavedOpenAbsu") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property MenuSavedBatchSize() As Integer
            Get
                Return CType(Me("MenuSavedBatchSize"),Integer)
            End Get
            Set
                Me("MenuSavedBatchSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MenuSavedHideIcons() As Boolean
            Get
                Return CType(Me("MenuSavedHideIcons"),Boolean)
            End Get
            Set
                Me("MenuSavedHideIcons") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.AxiomRandomizer.My.MySettings
            Get
                Return Global.AxiomRandomizer.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
