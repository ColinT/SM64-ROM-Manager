﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.42000
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    '-Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    'Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    'mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    '''<summary>
    '''  Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class UserRequestGuiLangRes
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SM64_ROM_Manager.UserRequests.GUI.UserRequestGuiLangRes", GetType(UserRequestGuiLangRes).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        '''  Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die An error happend at sending your request. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_ErrorSendingRequest() As String
            Get
                Return ResourceManager.GetString("MsgBox_ErrorSendingRequest", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Error sending request ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_ErrorSendingRequest_Titel() As String
            Get
                Return ResourceManager.GetString("MsgBox_ErrorSendingRequest_Titel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die The maximum size of all attachments together is 250 MiB for security reasons. Please reduce it e.g. packing your files to an archive. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_IncludedBigFiles() As String
            Get
                Return ResourceManager.GetString("MsgBox_IncludedBigFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Files to big ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_IncludedBigFiles_Titel() As String
            Get
                Return ResourceManager.GetString("MsgBox_IncludedBigFiles_Titel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die The request was send successfully! ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_SendingRequestSuccess() As String
            Get
                Return ResourceManager.GetString("MsgBox_SendingRequestSuccess", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Request sent successfull! ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_SendingRequestSuccess_Titel() As String
            Get
                Return ResourceManager.GetString("MsgBox_SendingRequestSuccess_Titel", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
