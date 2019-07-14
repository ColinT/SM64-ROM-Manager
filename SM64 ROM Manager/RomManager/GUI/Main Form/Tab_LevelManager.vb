﻿Imports System.ComponentModel
Imports System.IO
Imports System.Numerics
Imports DevComponents.DotNetBar
Imports SM64_ROM_Manager.ModelConverterGUI
Imports Pilz.S3DFileParser
Imports SM64_ROM_Manager.LevelEditor
Imports SM64_ROM_Manager.My.Resources
Imports SM64_ROM_Manager.SettingsManager
Imports SM64Lib
Imports SM64Lib.Levels.Script.Commands
Imports SM64Lib.Model
Imports SM64Lib.Script
Imports SM64_ROM_Manager.EventArguments
Imports SM64Lib.Levels
Imports DevComponents.Editors
Imports DevComponents.DotNetBar.Controls

Public Class Tab_LevelManager

    'F i e l d s

    Public WithEvents Controller As MainController

    'F l a g s

    Private LM_LoadingAreaList As Boolean = False
    Private LM_SavingRom As Boolean = False
    Private LM_LoadingArea As Boolean = False
    Private LM_LoadingLevel As Boolean = False

    'P r o p e r t i e s

    Private ReadOnly Property CurrentIndicies As (levelIndex As Integer, areaIndex As Integer)
        Get
            Return (CurrentLevelIndex, CurrentAreaIndex)
        End Get
    End Property

    Private ReadOnly Property CurrentAreaIndex As Integer
        Get
            Return ListBoxAdv_LM_Areas.SelectedIndex
        End Get
    End Property

    Private ReadOnly Property CurrentLevelIndex As Integer
        Get
            Return ListBoxAdv_LM_Levels.SelectedIndex
        End Get
    End Property

    Private ReadOnly Property AllowSavingLevelSettings As Boolean
        Get
            Return Not Controller?.IsLoadingRom AndAlso Not LM_LoadingLevel AndAlso CurrentLevelIndex > -1
        End Get
    End Property

    Private ReadOnly Property AllowSavingAreaSettings As Boolean
        Get
            Return AllowSavingLevelSettings AndAlso Not LM_LoadingAreaList AndAlso Not LM_LoadingArea AndAlso CurrentAreaIndex > -1
        End Get
    End Property

    Private ReadOnly Property CurrentSpecialBoxIndex As Integer
        Get
            Dim indicies = ListViewEx_LM_Specials.SelectedIndices
            If indicies.Count > 0 Then
                Return indicies(0)
            Else
                Return -1
            End If
        End Get
    End Property

    'C o n t r o l l e r   E v e n t s

    Private Sub Controller_RomLoaded() Handles Controller.RomLoaded
        LoadLevelList()
    End Sub

    Private Sub Controller_MusicSequenceAdded(e As MusicSequenceEventArgs) Handles Controller.MusicSequenceAdded
        AddSequenceToList(e.Index)
    End Sub

    Private Sub Controller_MusicSequenceChanged(e As MusicSequenceEventArgs) Handles Controller.MusicSequenceChanged
        UpdateSequenceInList(e.Index)
    End Sub

    Private Sub Controller_MusicSequenceRemoved(e As MusicSequenceEventArgs) Handles Controller.MusicSequenceRemoved
        RemoveSequenceFromList(e.Index)
    End Sub

    Private Sub Controller_RomMusicLoaded() Handles Controller.RomMusicLoaded
        LoadSequenceList()
    End Sub

    Private Sub Controller_LevelSpecialItemAdded(e As SpecialItemEventArgs) Handles Controller.LevelSpecialItemAdded
        If e.AreaIndex = CurrentAreaIndex Then
            AddSpecialItemToList(e.LevelIndex, e.AreaIndex, e.ItemIndex, True)
        End If
    End Sub

    Private Sub Controller_LevelSpecialItemRemoved(e As SpecialItemEventArgs) Handles Controller.LevelSpecialItemRemoved
        RemoveSpecialItemFromList(e.ItemIndex)
    End Sub

    Private Sub Controller_LevelSpecialItemChanged(e As SpecialItemEventArgs) Handles Controller.LevelSpecialItemChanged
        If e.AreaIndex = CurrentAreaIndex Then
            UpdateSpecialBoxItem(e)
        End If
    End Sub

    Private Sub Controller_LevelAdded(e As LevelEventArgs) Handles Controller.LevelAdded
        AddLevelToList(e.LevelID)
    End Sub

    Private Sub Controller_LevelBackgroundModeChanged(e As LevelBackgroundModeChangedEventArgs) Handles Controller.LevelBackgroundModeChanged
        HandleBackgroundModeChange(e)
    End Sub

    Private Sub Controller_LevelAreaBackgroundModeChanged(e As LevelAreaBackgroundModeChangedEventArgs) Handles Controller.LevelAreaBackgroundModeChanged
        If e.BackgroundType = AreaBGs.Color Then
            LoadAreaBackgroundColor(e.BackgroundColor)
        End If
    End Sub

    Private Sub Controller_LevelBackgroundImageChanged(e As LevelBackgroundImageChangedEventArgs) Handles Controller.LevelBackgroundImageChanged
        PictureBox_BGImage.Image = e.BackgroundImage
    End Sub

    Private Sub Controller_LevelRemoved(e As LevelEventArgs) Handles Controller.LevelRemoved
        RemoveLevelFromList(e.LevelIndex)
    End Sub

    Private Sub Controller_LevelIDChanged(e As LevelEventArgs) Handles Controller.LevelIDChanged
        UpdateLevelItemInList(e.LevelIndex, e.LevelID)
    End Sub

    Private Sub Controller_LevelAreaAdded(e As LevelAreaEventArgs) Handles Controller.LevelAreaAdded
        AddAreaToList(e.AreaIndex)
    End Sub

    Private Sub Controller_LevelAreaRemoved(e As LevelAreaEventArgs) Handles Controller.LevelAreaRemoved
        RemoveAreaFromList(e.AreaIndex)
    End Sub

    'F e a t u r e s   &   G U I

    Private Sub LoadSequenceList()
        'Remember old Index
        Dim IndexBefore As Integer = ComboBox_LM_Music.SelectedIndex

        'Clear Items
        ComboBox_LM_Music.Items.Clear()

        'Add new items
        For i As Integer = 0 To Controller.GetMusicSeuenceCount - 1
            AddSequenceToList(i)
        Next

        If IndexBefore < 0 Then IndexBefore = 1
        If ComboBox_LM_Music.Items.Count > IndexBefore Then
            ComboBox_LM_Music.SelectedIndex = IndexBefore
            ComboBox_LM_Music.SelectedIndex = IndexBefore
        ElseIf ComboBox_LM_Music.Items.Count > 1 Then
            ComboBox_LM_Music.SelectedIndex = 1
        End If
    End Sub

    Private Sub RemoveSequenceFromList(index As Integer)
        ComboBox_LM_Music.Items.RemoveAt(index)
    End Sub

    Private Sub AddSequenceToList(index As Integer)
        Dim item As New ComboItem

        UpdateSequenceInList(index, item)

        ComboBox_LM_Music.Items.Insert(index, item)
    End Sub

    Private Sub UpdateSequenceInList(index As Integer)
        UpdateSequenceInList(index, ComboBox_LM_Music.Items(index))
    End Sub

    Private Sub UpdateSequenceInList(index As Integer, item As ComboItem)
        Dim infos = Controller.GetMusicSequenceInfos(index)
        Dim tName As String = $"{TextFromValue(index,, 2)} - {infos.name}"

        item.Text = tName
    End Sub

    Private Sub AddSpecialItemToList(levelIndex As Integer, areaIndex As Integer, itemIndex As Integer, refreshAndVisible As Boolean)
        Dim lvi As New ListViewItem

        For i As Integer = 0 To 7
            lvi.SubItems.Add(New ListViewItem.ListViewSubItem)
        Next

        lvi.Text = ListViewEx_LM_Specials.Items.Count + 1
        SetSpecialBoxDataToItem(levelIndex, areaIndex, itemIndex, lvi)

        ListViewEx_LM_Specials.Items.Add(lvi)

        If refreshAndVisible Then
            lvi.EnsureVisible()
        End If
    End Sub

    Private Sub UpdateSpecialBoxItem(e As SpecialItemEventArgs)
        For Each lvi As ListViewItem In ListViewEx_LM_Specials.Items
            If lvi.Tag = e.ItemIndex Then
                SetSpecialBoxDataToItem(e.LevelIndex, e.AreaIndex, e.ItemIndex, lvi)
            End If
        Next
    End Sub

    Private Sub RemoveSpecialItemFromList(itemIndex As Integer)
        Dim toRemove As New List(Of ListViewItem)

        For Each lvi As ListViewItem In ListViewEx_LM_Specials.Items
            If lvi.Tag = itemIndex Then
                toRemove.Add(lvi)
            End If
        Next

        toRemove.ForEach(Sub(n) ListViewEx_LM_Specials.Items.Remove(n))
    End Sub

    Private Sub SetSpecialBoxDataToItem(levelIndex As Integer, areaIndex As Integer, itemIndex As Integer, lvi As ListViewItem)
        Dim sd = Controller.GetSpecialBoxInfos(levelIndex, areaIndex, itemIndex)
        lvi.Tag = itemIndex
        lvi.SubItems(1).Text = sd.boxType.ToString
        lvi.SubItems(2).Text = sd.x1
        lvi.SubItems(3).Text = sd.z1
        lvi.SubItems(4).Text = sd.x2
        lvi.SubItems(5).Text = sd.z2
        lvi.SubItems(6).Text = sd.y
        lvi.SubItems(7).Text = If(sd.boxType = SpecialBoxType.Water, If(sd.invisibleWater, Form_Main_Resources.Text_Invisible, sd.waterType.ToString), "-")
    End Sub

    Public Sub LoadListBoxEntries()
        Controller.LoadObjectBankData()

        Dim load =
            Sub(sb As ComboBoxEx, number As Byte)
                sb.Items.Clear()
                sb.Items.Add(Form_Main_Resources.Text_Disabled)
                For Each s In ObjectBankData(number).Sections
                    sb.Items.Add(s.SectionName)
                Next
            End Sub

        load(ComboBox_LM_OB0x0C, 1)
        load(ComboBox_LM_OB0x0D, 2)
        load(ComboBox_LM_OB0x09, 3)
    End Sub

    Private Sub LoadLevelList()
        Dim levelIDs As IEnumerable(Of UShort) = Controller.GetUsedLevelIDs

        'Clear Items
        ListBoxAdv_LM_Levels.Items.Clear()

        'Load all Levels
        For Each lvlID As UShort In levelIDs
            Dim btn As New ButtonItem With {
                .Text = Controller.GetLevelName(lvlID)
            }

            'Add event to popup 'More'
            AddHandler btn.MouseUp, Sub(sender As Object, e As MouseEventArgs) If e.Button = MouseButtons.Right Then ButtonX_LM_LevelsMore.Popup(Cursor.Position)

            'Add item
            ListBoxAdv_LM_Levels.Items.Add(btn)
        Next

        'Refresh
        ListBoxAdv_LM_Levels.Refresh()
    End Sub

    Private Sub UpdateLevelItemInList(levelIndex As Integer, levelID As UShort)
        Dim item As ButtonItem = ListBoxAdv_LM_Levels.Items(levelIndex)
        item.Text = Controller.GetLevelName(levelID)
    End Sub

    Private Sub LoadAreaList(selectAreaIndex As Integer)
        LM_LoadingAreaList = True

        'Clear all Items
        ListBoxAdv_LM_Areas.Items.Clear()

        'Load all Areas
        For Each areaID As Byte In Controller.GetUsedLevelAreaIDs(CurrentLevelIndex)
            Dim btn As New ButtonItem With {
                .Text = Form_Main_Resources.Text_Area & " " & areaID
            }

            'Add event to popup 'More'
            AddHandler btn.MouseUp, Sub(sender As Object, e As MouseEventArgs) If e.Button = MouseButtons.Right Then Button_LM_AreaEditor.Popup(Cursor.Position)

            'Add item
            ListBoxAdv_LM_Areas.Items.Add(btn)
        Next

        'Refresh
        ListBoxAdv_LM_Areas.Refresh()

        'Check if can add more areas
        Button_LM_AddArea.Enabled = Controller.GetLevelAreasCount(CurrentLevelIndex) < 8

        LM_LoadingAreaList = False

        'Select first item, if possible
        If ListBoxAdv_LM_Areas.Items.Count > selectAreaIndex Then
            ListBoxAdv_LM_Areas.SelectedItem = ListBoxAdv_LM_Areas.Items(selectAreaIndex)
        End If
    End Sub

    Private Sub AddLevelToList(levelID As UShort)
        Dim btn As New ButtonItem With {
            .Checked = False,
            .Text = Controller.GetLevelName(levelID)
        }

        ListBoxAdv_LM_Levels.Items.Add(btn)
        ListBoxAdv_LM_Areas.EnsureVisible(btn)
        ListBoxAdv_LM_Levels.Refresh()
        ListBoxAdv_LM_Levels.SelectedItem = ListBoxAdv_LM_Levels.Items(ListBoxAdv_LM_Levels.Items.Count - 1)
    End Sub

    Private Sub AddAreaToList(areaIndex As Byte)
        LoadAreaList(areaIndex)
    End Sub

    Private Sub RemoveAreaFromList(areaIndex As Integer)
        LoadAreaList(Math.Max(areaIndex - 1, 0))

        If Controller.GetLevelAreasCount(CurrentLevelIndex) = 0 Then
            TabControl_LM_Area.Enabled = False
        End If
    End Sub

    Private Sub EditLevelInList(levelID As UShort, levelIndex As Integer)
        Dim btn As ButtonItem = ListBoxAdv_LM_Levels.Items(levelIndex)
        btn.Text = Controller.GetLevelName(levelID)
        ListBoxAdv_LM_Levels.Refresh()
    End Sub

    Private Sub SaveLevelSettings()
        If AllowSavingLevelSettings Then
            Controller.SetLevelSettings(CurrentLevelIndex,
                                        NUD_LM_DefaultPositionAreaID.Value,
                                        NUD_LM_DefaultPositionYRotation.Value,
                                        SwitchButton_LM_ActSelector.Value,
                                        SwitchButton_LM_HardcodedCameraSettings.Value,
                                        ComboBox_LM_OB0x0D.SelectedIndex,
                                        ComboBox_LM_OB0x0C.SelectedIndex,
                                        ComboBox_LM_OB0x09.SelectedIndex,
                                        SwitchButton_LM_ShowMsgEnabled.Value,
                                        ValueFromText(TextBoxX_LM_ShowMsgID.Text))
        End If
    End Sub

    Private Sub LoadAreaBackgroundColor(color As Color)
        ColorPickerButton_LM_BackgroundColor.Visible = True
        ColorPickerButton_LM_BackgroundColor.SelectedColor = color
    End Sub

    Private Sub HandleBackgroundModeChange(e As LevelBackgroundModeChangedEventArgs)
        Me.SuspendLayout()

        ComboBox_LM_LevelBG.Visible = False
        Button_LM_LoadLevelBG.Visible = False
        PictureBox_BGImage.Image = Nothing

        Select Case e.BackgroundMode
            Case 0 ' Game Image
                ComboBox_LM_LevelBG.Visible = True
                If e.BackgroundID <> Geolayout.BackgroundIDs.Custom Then
                    ComboBox_LM_LevelBG.SelectedIndex = GetBackgroundIndexOfID(e.BackgroundID)
                Else
                    ComboBox_LM_LevelBG.SelectedIndex = GetBackgroundIndexOfID(Geolayout.BackgroundIDs.Ocean)
                End If
            Case 1 'Custom Image
                Button_LM_LoadLevelBG.Visible = True
                PictureBox_BGImage.Image = e.BackgroundImage
            Case 2 'Disable
        End Select

        Me.ResumeLayout()
    End Sub

    Private Sub SaveAreaSettings()
        If AllowSavingAreaSettings Then
            Controller.SaveLevelAreaSettings(CurrentLevelIndex,
                                             CurrentAreaIndex,
                                             ComboBox_LM_TerrainTyp.SelectedIndex,
                                             ComboBox_LM_Music.SelectedIndex,
                                             GetEnvironmentTypeOfIndex(ComboBox_LM_EnvironmentEffects.SelectedIndex),
                                             GetCameraPresetTypeOfIndex(ComboBox_LM_CameraPreset.SelectedIndex),
                                             CheckBoxX_LM_Enable2DCamera.Value)
        End If
    End Sub

    Private Sub UpdateSpecialItemsList()
        ListViewEx_LM_Specials.SuspendLayout()

        'Clear everything
        ListViewEx_LM_Specials.Items.Clear()

        'List all special boxes
        For sbIndex As Integer = 0 To Controller.GetSpecialBoxesCount(CurrentLevelIndex, CurrentAreaIndex) - 1
            AddSpecialItemToList(CurrentLevelIndex, CurrentAreaIndex, sbIndex, False)
        Next

        ListViewEx_LM_Specials.ResumeLayout()
        ListViewEx_LM_Specials.Refresh()
    End Sub

    Private Sub RemoveLevelFromList(levelIndex As Integer)
        ListBoxAdv_LM_Levels.Items.RemoveAt(levelIndex)
        ListBoxAdv_LM_Levels.Refresh()
    End Sub

    Private Sub LoadAreaSettings(levelIndex As Integer, areaIndex As Integer)
        Dim item = ListBoxAdv_LM_Areas.SelectedItem
        Dim skip As Boolean = item Is Nothing

        TabControl_LM_Area.Enabled = Not skip
        Button_LM_RemoveArea.Enabled = Not skip
        Button_LM_AreaEditor.Enabled = Not skip

        If Not Controller.IsLoadingRom AndAlso Not LM_LoadingLevel AndAlso Not LM_LoadingAreaList AndAlso Not skip Then
            Dim infos = Controller.GetLevelAreaSettings(levelIndex, areaIndex)
            LM_LoadingArea = True

            'Load Area Settings
            ComboBox_LM_TerrainTyp.SelectedIndex = infos.terrainType
            ComboBox_LM_Music.SelectedIndex = infos.bgMusic
            ComboBox_LM_CameraPreset.SelectedIndex = GetCameraPresetIndexOfType(infos.camPreset)
            ComboBox_LM_EnvironmentEffects.SelectedIndex = GetEnvironmentIndexOfType(infos.envEffect)

            'Load 2D-Camera Settings
            CheckBoxX_LM_Enable2DCamera.Value = infos.enable2DCam

            'Area Background
            Select Case infos.bgType
                Case AreaBGs.Levelbackground
                    ComboBoxEx_LM_AreaBG.SelectedIndex = 0
                Case AreaBGs.Color
                    ComboBoxEx_LM_AreaBG.SelectedIndex = 1
                    ColorPickerButton_LM_BackgroundColor.SelectedColor = infos.bgColor
            End Select
            ComboBoxEx_LM_AreaBG_SelectedIndexChanged()

            'Load Show Message
            SwitchButton_LM_ShowMsgEnabled.Value = infos.enableShowMsg
            If infos.enableShowMsg Then
                TextBoxX_LM_ShowMsgID.Text = TextFromValue(infos.showMsgDialogID)
            End If

            UpdateSpecialItemsList()

            LM_LoadingArea = False
        End If
    End Sub

    Private Sub LoadLevelSettings(levelIndex As Integer)
        Dim index As Integer = ListBoxAdv_LM_Levels.Items.IndexOf(ListBoxAdv_LM_Levels.SelectedItem)

        TabControl_LM_Level.Enabled = Not (index < 0)
        TabControl_LM_Level.Enabled = Not (index < 0)

        If LM_LoadingLevel Then Return

        If index < 0 Then
            TabControl_LM_Area.Enabled = False
            GroupBox_LM_Areas.Enabled = False
            Button_LM_AddArea.Enabled = False
            ButtonX_LM_LevelsMore.Enabled = False
            ListBoxAdv_LM_Areas.Items.Clear()
            Return
        End If

        If Not Controller.IsLoadingRom Then
            LM_LoadingLevel = True
            Controller.StatusText = Form_Main_Resources.Status_LoadingLevel

            Dim info = Controller.GetLevelSettings(levelIndex)

            'Load Levelsettings
            ComboBox_LM_OB0x0C.SelectedIndex = info.objBank0x0C
            ComboBox_LM_OB0x0D.SelectedIndex = info.objBank0x0D
            ComboBox_LM_OB0x09.SelectedIndex = info.objBank0x0E
            SwitchButton_LM_ActSelector.Value = info.enableActSelector
            SwitchButton_LM_HardcodedCameraSettings.Value = info.enableHardcodedCamera

            'Default Start Psoition
            If info.hasDefStartPos Then
                NUD_LM_DefaultPositionAreaID.Value = info.defStartPosAreaID
                NUD_LM_DefaultPositionYRotation.Value = info.defStartPosYRot
            End If

            'Load Level Bachground
            ComboBoxEx_LM_BGMode.SelectedIndex = info.bgMode

            Button_LM_AddArea.Enabled = Not (info.areasCount = 8)
            Controller.StatusText = String.Empty
            LM_LoadingLevel = False
            LoadAreaList(0)
            GroupBox_LM_Areas.Enabled = True
            TabControl_LM_Area.Enabled = True
            ButtonX_LM_LevelsMore.Enabled = True
        End If
    End Sub

    Private Sub Button_LM_AddNewLevel_Click() Handles Button_LM_AddNewLevel.Click
        Controller.AddNewLevel()
    End Sub

    Private Sub Button_LM_AddArea_Click() Handles Button_LM_AddArea.Click
        Controller.AddNewArea(CurrentLevelIndex)
    End Sub

    Private Sub Button_LM_RemoveArea_Click() Handles Button_LM_RemoveArea.Click
        Controller.RemoveLevelArea(CurrentLevelIndex, CurrentAreaIndex)
    End Sub

    Private Sub Controls_HandleToSaveLevelSettings() Handles ComboBox_LM_OB0x0D.SelectedIndexChanged, ComboBox_LM_OB0x0C.SelectedIndexChanged, ComboBox_LM_OB0x09.SelectedIndexChanged, NUD_LM_DefaultPositionYRotation.ValueChanged, NUD_LM_DefaultPositionAreaID.ValueChanged, SwitchButton_LM_ActSelector.ValueChanged, SwitchButton_LM_HardcodedCameraSettings.ValueChanged
        SaveLevelSettings()
    End Sub

    Private Sub LM_SaveGameBackground() Handles ComboBox_LM_LevelBG.SelectedIndexChanged
        If AllowSavingLevelSettings Then
            Controller.SetLevelBackgroundID(CurrentLevelIndex, GetBackgroundIDOfIndex(ComboBox_LM_LevelBG.SelectedIndex))
        End If
    End Sub

    Private Sub ComboBoxEx_LM_BGMode_SelectedIndexChanged() Handles ComboBoxEx_LM_BGMode.SelectedIndexChanged
        If AllowSavingLevelSettings Then
            Controller.SetLevelBackgroundMode(CurrentLevelIndex, ComboBoxEx_LM_BGMode.SelectedIndex)
        End If
    End Sub

    Private Sub ComboBoxEx_LM_AreaBG_SelectedIndexChanged() Handles ComboBoxEx_LM_AreaBG.SelectedIndexChanged
        If AllowSavingAreaSettings Then
            Controller.SetLevelAreaBackgroundType(CurrentLevelIndex, CurrentAreaIndex, ComboBoxEx_LM_AreaBG.SelectedIndex)
        End If
    End Sub

    Private Sub LM_SaveAreaBackgorund() Handles ColorPickerButton_LM_BackgroundColor.SelectedColorChanged
        If AllowSavingAreaSettings Then
            Controller.SetLevelAreaBackgroundColor(CurrentLevelIndex, CurrentAreaIndex, ColorPickerButton_LM_BackgroundColor.SelectedColor)
        End If
    End Sub

    Private Sub LM_LoadCustomBackground() Handles Button_LM_LoadLevelBG.Click
        Controller.LoadLevelCustomBackgroundImage(CurrentLevelIndex)
    End Sub

    Private Sub Controls_HandleToSaveAreaSettings() Handles ComboBox_LM_CameraPreset.SelectedIndexChanged, CheckBoxX_LM_Enable2DCamera.ValueChanged, ComboBox_LM_EnvironmentEffects.SelectedIndexChanged, ComboBox_LM_Music.SelectedIndexChanged, ComboBox_LM_TerrainTyp.SelectedIndexChanged
        SaveAreaSettings()
    End Sub

    Private Sub LM_ImportModel(sender As Object, e As EventArgs) Handles ButtonItem9.Click, ButtonItem13.Click, Button_ImportModel.Click
        Controller.ImportLevelAreaModel(CurrentLevelIndex, CurrentAreaIndex,
                                        sender Is Button_ImportModel OrElse sender Is ButtonItem9,
                                        sender Is Button_ImportModel OrElse sender Is ButtonItem13)
    End Sub

    Private Sub LM_UpdateObjectBankList(sender As Object, e As EventArgs) Handles ComboBox_LM_OB0x0C.SelectedIndexChanged, ComboBox_LM_OB0x0D.SelectedIndexChanged, ComboBox_LM_OB0x09.SelectedIndexChanged
        Dim Index As Integer = 1
        Dim Text As String = ""
        Dim SelectedIndex As Integer = 0

        Select Case sender.GetHashCode
            Case ComboBox_LM_OB0x0C.GetHashCode
                SelectedIndex = ComboBox_LM_OB0x0C.SelectedIndex
                Text = ComboBox_LM_OB0x0C.SelectedItem.ToString
                Index = 1
                ListBoxAdv_LM_ContentOfOB0x0C.Items.Clear()
            Case ComboBox_LM_OB0x0D.GetHashCode
                SelectedIndex = ComboBox_LM_OB0x0D.SelectedIndex
                Text = ComboBox_LM_OB0x0D.SelectedItem.ToString
                Index = 2
                ListBoxAdv_LM_ContentOfOB0x0D.Items.Clear()
            Case ComboBox_LM_OB0x09.GetHashCode
                SelectedIndex = ComboBox_LM_OB0x09.SelectedIndex
                Text = ComboBox_LM_OB0x09.SelectedItem.ToString
                Index = 3
                ListBoxAdv_LM_ContentOfOB0x09.Items.Clear()
        End Select

        If SelectedIndex >= 1 Then
            For Each n As String In ObjectBankData(Index).Sections(Text)("List").Split("|")
                Select Case sender.GetHashCode
                    Case ComboBox_LM_OB0x0C.GetHashCode
                        ListBoxAdv_LM_ContentOfOB0x0C.Items.Add(New LabelItem With {.Text = n})
                    Case ComboBox_LM_OB0x0D.GetHashCode
                        ListBoxAdv_LM_ContentOfOB0x0D.Items.Add(New LabelItem With {.Text = n})
                    Case ComboBox_LM_OB0x09.GetHashCode
                        ListBoxAdv_LM_ContentOfOB0x09.Items.Add(New LabelItem With {.Text = n})
                End Select
            Next
        End If

        ListBoxAdv_LM_ContentOfOB0x0C.Refresh()
        ListBoxAdv_LM_ContentOfOB0x0D.Refresh()
        ListBoxAdv_LM_ContentOfOB0x09.Refresh()
    End Sub

    Private Sub Button_LM_AddEditSpecial_Click(sender As Object, e As EventArgs) Handles Button_LM_EditSpecial.Click, Button_LM_AddSpecial.Click
        If Not LM_LoadingLevel Then
            If sender Is Button_LM_EditSpecial Then
                Controller.EditLevelAreaSpecialItem(CurrentLevelIndex, CurrentAreaIndex, CurrentSpecialBoxIndex)
            ElseIf sender Is Button_LM_AddSpecial Then
                Controller.AddLevelAreaSpecialItem(CurrentLevelIndex, CurrentAreaIndex)
            End If
        End If
    End Sub

    Private Sub Button_LM_RemoveSpecial_Click(sender As Object, e As EventArgs) Handles Button_LM_RemoveSpecial.Click
        If Not LM_LoadingLevel Then
            Controller.RemoveLevelSpecialBox(CurrentLevelIndex, CurrentAreaIndex, CurrentSpecialBoxIndex)
        End If
    End Sub

    Private Sub ListViewEx_LM_Specials_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewEx_LM_Specials.SelectedIndexChanged
        Dim isNull As Boolean = CurrentSpecialBoxIndex = -1
        Button_LM_EditSpecial.Enabled = Not isNull
        Button_LM_RemoveSpecial.Enabled = Not isNull
    End Sub

    Private Sub ComboBox_LM_CameraPreset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_LM_CameraPreset.SelectedIndexChanged
        Dim IsE As Boolean = Controller.DoesCameraPresetProvide2DCamera(ComboBox_LM_CameraPreset.SelectedIndex + 1)
        CheckBoxX_LM_Enable2DCamera.Visible = IsE
        If Not IsE Then CheckBoxX_LM_Enable2DCamera.Value = False
    End Sub

    Private Sub LM_OpenAreaEditor() Handles Button_LM_AreaEditor.Click
        If Not LM_SavingRom Then
            Controller.OpenAreaEditor(CurrentLevelIndex, CurrentAreaIndex)
        End If
    End Sub

    Private Sub Button_LM_SetUpOffsetModelPosition_Click(sender As Object, e As EventArgs) Handles Button_LM_SetUpStartPosition.Click
        Controller.SetUpLevelDefaultStartPosition(CurrentLevelIndex)
    End Sub

    Private Sub ListBoxAdv_LM_Areas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAdv_LM_Areas.SelectedIndexChanged
        LoadAreaSettings(CurrentLevelIndex, CurrentAreaIndex)
    End Sub

    Private Sub ListBoxAdv_LM_Levels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAdv_LM_Levels.SelectedItemChanged, ListBoxAdv_LM_Levels.ItemRemoved
        LoadLevelSettings(CurrentLevelIndex)
    End Sub

    Private Sub ButtonItem19_Click(sender As Object, e As EventArgs) Handles ButtonItem19.Click
        Controller.RemoveLevel(CurrentLevelIndex)
    End Sub

    Private Sub ButtonItem20_Click(sender As Object, e As EventArgs) Handles ButtonItem20.Click
        Controller.ChangeLevelID(CurrentLevelIndex)
    End Sub

    Private Sub ButtonItem21_Click(sender As Object, e As EventArgs) Handles ButtonItem21.Click
        Controller.CopyLevelLastRomOffset(CurrentLevelIndex)
    End Sub

    Private Async Sub ButtonItem_ExportVisualMap_Click(sender As Object, e As EventArgs) Handles ButtonItem_ExportVisualMap.Click
        If AllowSavingAreaSettings Then
            Await Controller.ExportLevelVisualMap(CurrentLevelIndex, CurrentAreaIndex)
        End If
    End Sub

    Private Async Sub ButtonItem_ExportCollisionMap_Click(sender As Object, e As EventArgs) Handles ButtonItem_ExportCollisionMap.Click
        If AllowSavingAreaSettings Then
            Await Controller.ExportLevelCollision(CurrentLevelIndex, CurrentAreaIndex)
        End If
    End Sub

    Private Sub SwitchButton_LM_ShowMsgEnabled_ValueChanged(sender As Object, e As EventArgs) Handles SwitchButton_LM_ShowMsgEnabled.ValueChanged
        Dim enabled As Boolean = SwitchButton_LM_ShowMsgEnabled.Value
        TextBoxX_LM_ShowMsgID.Visible = enabled
        LabelX9.Visible = enabled

        SaveLevelSettings()
    End Sub

    Private Sub TextBoxX_LM_ShowMsgID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX_LM_ShowMsgID.TextChanged
        SaveLevelSettings()
    End Sub

    Private Sub ButtonItem15_Click(sender As Object, e As EventArgs) Handles ButtonItem15.Click
        Controller.OpenScriptDumperWithLevelscript(CurrentLevelIndex)
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Controller.OpenScriptDumperWithLevelAreaScript(CurrentLevelIndex, CurrentAreaIndex)
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Controller.OpenScriptDumperWithLevelAreaGeolayoutScript(CurrentLevelIndex, CurrentAreaIndex)
    End Sub

    Private Sub ButtonX_LM_ScrollTexEditor_Click(sender As Object, e As EventArgs) Handles ButtonX_LM_ScrollTexEditor.Click
        Controller.OpenScrollingTextureEditor(CurrentLevelIndex, CurrentAreaIndex)
    End Sub

    Private Sub ButtonItem26_Click(sender As Object, e As EventArgs) Handles ButtonItem26.Click
        Controller.ImportLevel()
    End Sub

    Private Sub ListBoxAdv_LM_Levels_ItemDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBoxAdv_LM_Levels.ItemDoubleClick, ListBoxAdv_LM_Areas.ItemDoubleClick
        If Not LM_SavingRom Then
            Controller.OpenAreaEditor(CurrentLevelIndex, CurrentAreaIndex)
        End If
    End Sub

    Private Sub ButtonItem24_Click(sender As Object, e As EventArgs) Handles ButtonItem24.Click
        Controller.SetLevelBank0x19Length(CurrentLevelIndex)
    End Sub

    Private Sub ButtonX_LM_LevelsMore_PopupOpen(sender As Object, e As EventArgs) Handles ButtonX_LM_LevelsMore.PopupOpen
        ButtonItem24.Visible = Controller.HasLevelBank0x19(CurrentLevelIndex)
    End Sub

    Private Sub ButtonX_CustomObjects_Click(sender As Object, e As EventArgs) Handles ButtonX_CustomObjects.Click
        Controller.OpenCustomBankManager(CurrentLevelIndex, CurrentAreaIndex)
    End Sub

End Class
