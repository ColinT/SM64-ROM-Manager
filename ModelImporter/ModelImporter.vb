﻿Imports DevComponents.DotNetBar
Imports SM64Lib.Model
Imports Publics
Imports SM64_ROM_Manager.SettingsManager
Imports TextValueConverter
Imports ModelConverterGUI
Imports System.IO
Imports System.Text
Imports SM64Lib.Geolayout
Imports ModelImporterGUI.ImporterPresets
Imports DevComponents.Editors
Imports System.Reflection

Public Class ModelImporter

    Private _RomFile As String = ""
    Private mdl As ObjectModel = Nothing
    Private presets As New List(Of ImporterProfile)
    Private rommgr As SM64Lib.RomManager = Nothing

    Public Property RomFile As String
        Get
            Return _RomFile
        End Get
        Set(value As String)
            _RomFile = value
            If value <> "" Then
                LabelX1.Text = Path.GetFileName(value)
                LabelX1.Symbol = ""
            End If
        End Set
    End Property

    Public Sub New()
        SetDPIAware

        InitializeComponent()

        If Assembly.GetExecutingAssembly = Assembly.GetEntryAssembly Then
            Settings.SettingsConfigFilePath = Path.Combine(Application.StartupPath, "Data\Settings.json")
            StyleManager.Style = eStyle.Metro
            StyleManager.MetroColorGeneratorParameters = Settings.StyleManager.MetroColorParams
        End If

        UpdateAmbientColors()

        ComboBoxEx1.Items.Clear()
        Dim layers As String() = [Enum].GetNames(GetType(Geolayer))
        ComboBoxEx1.Items.Add("Don't force")
        ComboBoxEx1.Items.AddRange(layers)
        ComboBoxEx1.SelectedIndex = Array.IndexOf(layers, [Enum].GetName(GetType(Geolayer), &H4)) + 1
        ComboBoxEx1.UpdateAmbientColors
    End Sub

    Public Sub New(rommgr As SM64Lib.RomManager)
        Me.New
        Me.rommgr = rommgr
    End Sub

    Private Sub ClearOutput()
        TextBoxX_Output.Text = ""
    End Sub
    Private Sub WriteOutput()
        TextBoxX_Output.AppendText(vbNewLine)
    End Sub
    Private Sub WriteOutput(msg As String)
        TextBoxX_Output.AppendText(msg & vbNewLine)
    End Sub

    Private Sub ButtonX_OpenRom_Click(sender As Object, e As EventArgs) Handles ButtonX_OpenRom.Click
        Dim ofd As New OpenFileDialog With {.Filter = "SM64 ROMs (*.z64)|*.z64|All files (*.*)|*.*"}

        If ofd.ShowDialog = DialogResult.OK Then
            RomFile = ofd.FileName
            rommgr = New SM64Lib.RomManager(RomFile)
        End If
    End Sub

    Private Sub ButtonX_ConvertMdl_Click(sender As Object, e As EventArgs) Handles ButtonX_ConvertMdl.Click
        Dim frm As New MainModelConverter

        If ComboBoxEx1.SelectedIndex > 0 Then
            frm.ForceDisplaylist = [Enum].GetValues(GetType(Geolayer))(ComboBoxEx1.SelectedIndex - 1)
        End If

        If frm.ShowDialog = DialogResult.OK Then
            mdl = frm.ResModel
            ButtonX_ConvertMdl.Symbol = ""
            ButtonX_ImportMdl.Enabled = True
        End If
    End Sub

    Private Sub ButtonX_ImportMdl_Click(sender As Object, e As EventArgs) Handles ButtonX_ImportMdl.Click
        ButtonX_ImportMdl.Symbol = ""
        Dim preset As ImporterPreset = SelectedPreset()

        Dim romAddr As Integer = preset.RomAddress 'ValueFromText(TextBoxX_RomAddr.Text)
        Dim bankAddr As Integer = preset.RamAddress 'ValueFromText(TextBoxX_BankAddr.Text)
        Dim maxLength As Integer = preset.MaxLength 'ValueFromText(TextBoxX_MaxLength.Text)

        If maxLength > 0 AndAlso mdl.Length > maxLength Then
            MessageBoxEx.Show("Model is bigger then the max allowed length!", "Model too big", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim col As Integer = -1
        Dim geo() As Geopointer = {}
        Dim len As Integer = 0
        Dim sr As ObjectModel.SaveResult = Nothing
        Dim iscollisionempty As Boolean = mdl.Collision Is Nothing
        Dim isf3disempty As Boolean = mdl.Fast3DBuffer Is Nothing
        Dim fs As New FileStream(_RomFile, FileMode.Open, FileAccess.ReadWrite)
        Dim bw As New BinaryWriter(fs)

        'Write to stream
        sr = mdl.ToStream(fs, romAddr, romAddr - (bankAddr And &HFFFFFF), bankAddr And &HFF000000)

        'Write Collision Pointer
        If col > -1 Then
            For Each cp As Integer In SelectedPreset.CollisionPointers
                fs.Position = cp
                bw.Write(SwapInts.SwapInt32(col))
            Next
        End If

        'Write Geopointer
        If geo.Length > 0 Then
            For Each gp As Integer In SelectedPreset.GeometryPointers
                fs.Position = gp
                bw.Write(SwapInts.SwapInt32(geo(0).SegPointer))

                fs.Position = gp - 4
                If fs.ReadByte = &H15 Then
                    fs.WriteByte(geo(0).Layer)
                Else
                    fs.Position = gp - 8
                    If fs.ReadByte = &H13 Then
                        fs.WriteByte(geo(0).Layer)
                    End If
                End If
            Next
        End If

        fs.Close()

        If sr IsNot Nothing Then
            geo = sr.GeoPointers.ToArray
            col = sr.CollisionPointer
            len = sr.Length
        End If

        ClearOutput()
        If col > -1 Then
            WriteOutput($"Collision Pointer:{vbTab}{sr.CollisionPointer.ToString("X")}")
        End If
        For Each g As Geopointer In geo
            WriteOutput($"DL-Pointer:{vbTab}{g.SegPointer.ToString("X")} ({g.Layer.ToString})")
        Next

        If preset.Script IsNot Nothing AndAlso Not String.IsNullOrEmpty(preset.Script.Script) Then
            WriteOutput("Executing Script ...")
            Dim pm As New PatchScripts.PatchingManager
            pm.Patch(preset.Script, RomFile, "", Me)
        End If

        WriteOutput()
        WriteOutput(Now.ToShortTimeString & " - Done")

        'MessageBoxEx.Show("Model has been imported succesfully!", "Model imported", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ButtonX_ImportMdl.Symbol = ""
    End Sub

    Private Sub LoadPresets()
        'Add Custom Preset

        Dim custom As New ImporterProfile
        custom.Name = "Custom"
        custom.Presets.Add(New ImporterPreset)
        presets.Add(custom)

        'Load Files

        Dim mgr As New ImporterProfileManager
        Dim files As String() = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory, "Data\Importer Presets"), "*", SearchOption.AllDirectories)

        For Each f As String In files
            If Path.GetExtension(f).ToLower = ".xml" Then
                Dim preset As ImporterProfile = mgr.Read(f)
                presets.Add(preset)
            End If
        Next

        'Create List

        ComboBoxEx2.SuspendLayout()
        ComboBoxEx2.Items.Clear()

        For Each preset As ImporterProfile In presets
            Dim ci As New ComboItem
            ci.Text = preset.Name
            ci.Tag = preset
            ComboBoxEx2.Items.Add(ci)
        Next

        ComboBoxEx2.SelectedIndex = 0
        ComboBoxEx2.ResumeLayout()
    End Sub

    Private Function SelectedProfile() As ImporterProfile
        Return CType(ComboBoxEx2.SelectedItem, ComboItem)?.Tag
    End Function
    Private Function SelectedPreset() As ImporterPreset
        Return SelectedProfile()?.Presets.FirstOrDefault
    End Function

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Flyout1.Close()
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        Dim custom As New ImporterProfile
        custom.Name = "New Importer Preset _" & presets.Count
        custom.Presets.Add(New ImporterPreset)
        presets.Add(custom)

        Dim ci As New ComboItem
        ci.Text = custom.Name
        ci.Tag = custom
        ComboBoxEx2.Items.Add(ci)
        ComboBoxEx2.SelectedItem = ci
    End Sub

    Private Sub SaveProfile(p As ImporterProfile)
        If p IsNot Nothing Then
            Dim mgr As New ImporterProfileManager
            mgr.Save(p, Path.Combine(Directory.GetCurrentDirectory, "Data\Importer Presets"))
        End If
    End Sub

    Private Sub ButtonX7_Click(sender As Object, e As EventArgs) Handles ButtonX7.Click
        ComboBoxEx2.SuspendLayout()
        File.Delete(SelectedProfile.FileName)
        presets.Remove(SelectedProfile)
        ComboBoxEx2.Items.Remove(ComboBoxEx2.SelectedItem)
        ComboBoxEx2.SelectedIndex = 0
        ComboBoxEx2.ResumeLayout()
        Flyout1.Close()
    End Sub

    Private Sub ButtonX6_Click(sender As Object, e As EventArgs) Handles ButtonX6.Click
        Dim preset As ImporterPreset = SelectedPreset()
        If preset.Script Is Nothing Then preset.Script = New PatchScripts.PatchScript

        Dim editor As New PatchScripts.TweakScriptEditor(preset.Script)
        If editor.ShowDialog(Me) = DialogResult.OK Then
            If editor.NeedToSave Then
                SaveProfile(SelectedProfile)
            End If
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Dim editor As New PatchScripts.TweakProfileEditor
        Dim profile As ImporterProfile = SelectedProfile()

        editor.Titel = profile.Name
        editor.Description = profile.Description

        If editor.ShowDialog(Me) = DialogResult.OK Then

            profile.Name = editor.Titel.Trim
            profile.Description = editor.Description.Trim
            CType(ComboBoxEx2.SelectedItem, ComboItem).Text = profile.Name
            ShowProfileInfo(SelectedProfile)
            SaveProfile(profile)

        End If
    End Sub

    Private Sub ShowProfileInfo(preset As ImporterProfile)
        LabelX_PatchName.Text = preset?.Name
        LabelX_Description.Text = preset?.Description
    End Sub

    Private Sub Flyout1_PrepareContent(sender As Object, e As EventArgs) Handles Flyout1.PrepareContent
        ShowProfileInfo(SelectedProfile)
    End Sub

    Private Sub ModelImporter_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadPresets()
    End Sub

    Private Sub LoadPreset(preset As ImporterPreset)
        TextBoxX_BankAddr.Text = TextFromValue(preset.RamAddress)
        TextBoxX_RomAddr.Text = TextFromValue(preset.RomAddress)
        TextBoxX_MaxLength.Text = TextFromValue(preset.MaxLength)

        Dim colText As String = ""
        For Each cp As Integer In preset.CollisionPointers
            If colText <> "" Then
                colText &= ", "
            End If
            colText &= TextFromValue(cp)
        Next
        TextBoxX2.Text = colText

        Dim geoText As String = ""
        For Each gp As Integer In preset.GeometryPointers
            If geoText <> "" Then
                geoText &= ", "
            End If
            geoText &= TextFromValue(gp)
        Next
        TextBoxX1.Text = geoText
    End Sub

    Private Sub ComboBoxEx2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEx2.SelectedIndexChanged
        If SelectedProfile() IsNot Nothing Then
            LoadPreset(SelectedPreset)
        End If
    End Sub

    Private Sub TextBoxX2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX2.LostFocus
        Dim preset As ImporterPreset = SelectedPreset()
        If preset IsNot Nothing Then
            preset.CollisionPointers.Clear()
            For Each cp As String In TextBoxX2.Text.Split(",")
                preset.CollisionPointers.Add(ValueFromText(cp.Trim))
            Next
        End If
    End Sub

    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX1.LostFocus
        Dim preset As ImporterPreset = SelectedPreset()
        If preset IsNot Nothing Then
            preset.GeometryPointers.Clear()
            For Each gp As String In TextBoxX1.Text.Split(",")
                preset.GeometryPointers.Add(ValueFromText(gp.Trim))
            Next
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        SaveProfile(SelectedProfile)
    End Sub

    Private Sub TextBoxX_RomAddr_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX_RomAddr.TextChanged
        Dim p As ImporterPreset = SelectedPreset()
        If p IsNot Nothing Then
            p.RomAddress = ValueFromText(TextBoxX_RomAddr.Text)
        End If
    End Sub

    Private Sub TextBoxX_BankAddr_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX_BankAddr.TextChanged
        Dim p As ImporterPreset = SelectedPreset()
        If p IsNot Nothing Then
            p.RamAddress = ValueFromText(TextBoxX_BankAddr.Text)
        End If
    End Sub

    Private Sub TextBoxX_MaxLength_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX_MaxLength.TextChanged
        Dim p As ImporterPreset = SelectedPreset()
        If p IsNot Nothing Then
            p.MaxLength = ValueFromText(TextBoxX_MaxLength.Text)
        End If
    End Sub

    Private Sub Flyout1_FlyoutShowing(sender As Object, e As DevComponents.DotNetBar.Controls.FlyoutShowingEventArgs) Handles Flyout1.FlyoutShowing
        e.Cancel = ComboBoxEx2.SelectedIndex = 0
    End Sub
End Class
