﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
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
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsSRRArea() As Global.System.Collections.ArrayList
            Get
                Return CType(Me("settingsSRRArea"),Global.System.Collections.ArrayList)
            End Get
            Set
                Me("settingsSRRArea") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsSRRDescription() As Global.System.Collections.ArrayList
            Get
                Return CType(Me("settingsSRRDescription"),Global.System.Collections.ArrayList)
            End Get
            Set
                Me("settingsSRRDescription") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsSRRSurveyors() As Global.System.Collections.ArrayList
            Get
                Return CType(Me("settingsSRRSurveyors"),Global.System.Collections.ArrayList)
            End Get
            Set
                Me("settingsSRRSurveyors") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property settingsProjectFolderPath() As String
            Get
                Return CType(Me("settingsProjectFolderPath"),String)
            End Get
            Set
                Me("settingsProjectFolderPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property settingsDbServerName() As String
            Get
                Return CType(Me("settingsDbServerName"),String)
            End Get
            Set
                Me("settingsDbServerName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property settingDbUserId() As String
            Get
                Return CType(Me("settingDbUserId"),String)
            End Get
            Set
                Me("settingDbUserId") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property settingsDbPassword() As String
            Get
                Return CType(Me("settingsDbPassword"),String)
            End Get
            Set
                Me("settingsDbPassword") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsIsActiveSetup() As Boolean
            Get
                Return CType(Me("settingsIsActiveSetup"),Boolean)
            End Get
            Set
                Me("settingsIsActiveSetup") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsIsActiveTest() As Boolean
            Get
                Return CType(Me("settingsIsActiveTest"),Boolean)
            End Get
            Set
                Me("settingsIsActiveTest") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsIsActiveModify() As Boolean
            Get
                Return CType(Me("settingsIsActiveModify"),Boolean)
            End Get
            Set
                Me("settingsIsActiveModify") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsIsActiveServer() As Boolean
            Get
                Return CType(Me("settingsIsActiveServer"),Boolean)
            End Get
            Set
                Me("settingsIsActiveServer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsIsActiveUser() As Boolean
            Get
                Return CType(Me("settingsIsActiveUser"),Boolean)
            End Get
            Set
                Me("settingsIsActiveUser") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsIsActivePass() As Boolean
            Get
                Return CType(Me("settingsIsActivePass"),Boolean)
            End Get
            Set
                Me("settingsIsActivePass") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsIsActiveMessage() As Boolean
            Get
                Return CType(Me("settingsIsActiveMessage"),Boolean)
            End Get
            Set
                Me("settingsIsActiveMessage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsIsActiveWarning() As Boolean
            Get
                Return CType(Me("settingsIsActiveWarning"),Boolean)
            End Get
            Set
                Me("settingsIsActiveWarning") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsFDRArea() As Global.System.Collections.ArrayList
            Get
                Return CType(Me("settingsFDRArea"),Global.System.Collections.ArrayList)
            End Get
            Set
                Me("settingsFDRArea") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsFDRJobType() As Global.System.Collections.ArrayList
            Get
                Return CType(Me("settingsFDRJobType"),Global.System.Collections.ArrayList)
            End Get
            Set
                Me("settingsFDRJobType") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsFDRInstrumentA() As Global.System.Collections.ArrayList
            Get
                Return CType(Me("settingsFDRInstrumentA"),Global.System.Collections.ArrayList)
            End Get
            Set
                Me("settingsFDRInstrumentA") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property settingsTQRArea() As Global.System.Collections.ArrayList
            Get
                Return CType(Me("settingsTQRArea"),Global.System.Collections.ArrayList)
            End Get
            Set
                Me("settingsTQRArea") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property activationKey() As Long
            Get
                Return CType(Me("activationKey"),Long)
            End Get
            Set
                Me("activationKey") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property settingsIsActiveCreateTables() As String
            Get
                Return CType(Me("settingsIsActiveCreateTables"),String)
            End Get
            Set
                Me("settingsIsActiveCreateTables") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property settingsDbServerPort() As String
            Get
                Return CType(Me("settingsDbServerPort"),String)
            End Get
            Set
                Me("settingsDbServerPort") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")> _
        Friend ReadOnly Property Settings() As Global.XCELregister.My.MySettings
            Get
                Return Global.XCELregister.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
