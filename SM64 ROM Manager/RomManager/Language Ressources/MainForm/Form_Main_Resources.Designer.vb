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
    Friend Class Form_Main_Resources
        
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SM64_ROM_Manager.Form_Main_Resources", GetType(Form_Main_Resources).Assembly)
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
        '''  Sucht eine lokalisierte Zeichenfolge, die Open ROM ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Button_OpenRom() As String
            Get
                Return ResourceManager.GetString("Button_OpenRom", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Size of Bank 0x19 changed successfully! ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_BankSizeChangedSuccess() As String
            Get
                Return ResourceManager.GetString("MsgBox_BankSizeChangedSuccess", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Size changed ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_BankSizeChangedSuccess_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_BankSizeChangedSuccess_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die An Error happend at saving sequence. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_ErrorSavingSequence() As String
            Get
                Return ResourceManager.GetString("MsgBox_ErrorSavingSequence", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die The Game Name probably contains invalid chars. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_GameNameHasInvalidChars() As String
            Get
                Return ResourceManager.GetString("MsgBox_GameNameHasInvalidChars", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die This size is too small. The minimum size is {0}. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_InvalidBankSize() As String
            Get
                Return ResourceManager.GetString("MsgBox_InvalidBankSize", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Invalid Size ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_InvalidBankSize_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_InvalidBankSize_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die This Image has not a valid Size.&lt;br/&gt;The &lt;b&gt;recommed&lt;/b&gt; Size is 248x248. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_InvalidBgImageSize() As String
            Get
                Return ResourceManager.GetString("MsgBox_InvalidBgImageSize", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Invalid Size ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_InvalidBgImageSize_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_InvalidBgImageSize_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die The limit of possible music sequences in the original game is 127. Do you want to add more anyway? ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_LimitSequenceCountReached() As String
            Get
                Return ResourceManager.GetString("MsgBox_LimitSequenceCountReached", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Limit reached ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_LimitSequenceCountReached_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_LimitSequenceCountReached_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die The maximum count of Areas per Level is 8. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_MaxCountAreasReached() As String
            Get
                Return ResourceManager.GetString("MsgBox_MaxCountAreasReached", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Maximum reached ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_MaxCountAreasReached_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_MaxCountAreasReached_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die The maximum count of possible music sequences reached! It is not possible to add any more. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_MaxSequenceCountReached() As String
            Get
                Return ResourceManager.GetString("MsgBox_MaxSequenceCountReached", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Maximum reached ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_MaxSequenceCountReached_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_MaxSequenceCountReached_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die This ROM will be prepaired now to load it. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_PrepaireRom() As String
            Get
                Return ResourceManager.GetString("MsgBox_PrepaireRom", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Prepaire ROM ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_PrepaireRom_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_PrepaireRom_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die The ROM can&apos;t be started. Make sure you selected the correct path to the emulator. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_RomCanNotBestarted() As String
            Get
                Return ResourceManager.GetString("MsgBox_RomCanNotBestarted", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Launch Game ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_RomCanNotBestarted_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_RomCanNotBestarted_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Your texts needs more space then allowed! Please reduce them before saving ROM. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_TextsOverLimit() As String
            Get
                Return ResourceManager.GetString("MsgBox_TextsOverLimit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Over Limit ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_TextsOverLimit_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_TextsOverLimit_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die If there are unsaved changes left, you will lose them all.&lt;br/&gt;Do you want to save the ROM? ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_UnsavedChanges() As String
            Get
                Return ResourceManager.GetString("MsgBox_UnsavedChanges", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Unsaved changes ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_UnsavedChanges_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_UnsavedChanges_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die There are update-patches avaibale for this ROM providing code improvements and new features.&lt;br/&gt;It is &lt;u&gt;heightly recommend&lt;/u&gt; to patch them.&lt;br/&gt;&lt;br/&gt;Do you want to patch them now? ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_UpdatePatchesAvaiable() As String
            Get
                Return ResourceManager.GetString("MsgBox_UpdatePatchesAvaiable", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Update-Patches avaiable ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_UpdatePatchesAvaiable_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_UpdatePatchesAvaiable_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die You should load a ROM first. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Notify_ShouldLoadRomFirst() As String
            Get
                Return ResourceManager.GetString("Notify_ShouldLoadRomFirst", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Calculating space ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_CalculatingTextSpace() As String
            Get
                Return ResourceManager.GetString("Status_CalculatingTextSpace", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Checking ROM ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_Checking() As String
            Get
                Return ResourceManager.GetString("Status_Checking", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Creating new Sequence ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_CreatingNewSequence() As String
            Get
                Return ResourceManager.GetString("Status_CreatingNewSequence", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Creating Text List ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_CreatingTextList() As String
            Get
                Return ResourceManager.GetString("Status_CreatingTextList", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Exporting Model Map ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_ExportingModel() As String
            Get
                Return ResourceManager.GetString("Status_ExportingModel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Exporting Sequence ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_ExportingSequence() As String
            Get
                Return ResourceManager.GetString("Status_ExportingSequence", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Importing Sequence ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_ImportingSequence() As String
            Get
                Return ResourceManager.GetString("Status_ImportingSequence", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Loading Level ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_LoadingLevel() As String
            Get
                Return ResourceManager.GetString("Status_LoadingLevel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Loading Model Map ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_LoadingModel() As String
            Get
                Return ResourceManager.GetString("Status_LoadingModel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Loading Music ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_LoadingMusic() As String
            Get
                Return ResourceManager.GetString("Status_LoadingMusic", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Loading ROM ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_LoadingRom() As String
            Get
                Return ResourceManager.GetString("Status_LoadingRom", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Loading Texts from ROM ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_LoadingTexts() As String
            Get
                Return ResourceManager.GetString("Status_LoadingTexts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Ready ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_Ready() As String
            Get
                Return ResourceManager.GetString("Status_Ready", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Saving ROM ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_SavingRom() As String
            Get
                Return ResourceManager.GetString("Status_SavingRom", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Starting up ... ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Status_StartingUp() As String
            Get
                Return ResourceManager.GetString("Status_StartingUp", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Area ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Text_Area() As String
            Get
                Return ResourceManager.GetString("Text_Area", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Change Replacing Level ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Text_ChangeReplacingLevel() As String
            Get
                Return ResourceManager.GetString("Text_ChangeReplacingLevel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Disabled ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Text_Disabled() As String
            Get
                Return ResourceManager.GetString("Text_Disabled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Invisible ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Text_Invisible() As String
            Get
                Return ResourceManager.GetString("Text_Invisible", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Level {0}, Star {1} ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Text_LevelStar() As String
            Get
                Return ResourceManager.GetString("Text_LevelStar", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Mist ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Text_Mist() As String
            Get
                Return ResourceManager.GetString("Text_Mist", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die New Length ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Text_NewLength() As String
            Get
                Return ResourceManager.GetString("Text_NewLength", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Secret Star ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Text_SecretStar() As String
            Get
                Return ResourceManager.GetString("Text_SecretStar", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Start Position ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Text_StartPosition() As String
            Get
                Return ResourceManager.GetString("Text_StartPosition", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Toxic Haze ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Text_ToxicHaze() As String
            Get
                Return ResourceManager.GetString("Text_ToxicHaze", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Unknown ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Text_Unknown() As String
            Get
                Return ResourceManager.GetString("Text_Unknown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die {0} of {1} used / {2} left ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Text_UsedOfMaxLeft() As String
            Get
                Return ResourceManager.GetString("Text_UsedOfMaxLeft", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Water ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property Text_Water() As String
            Get
                Return ResourceManager.GetString("Text_Water", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
