﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Settings
    Inherits DevComponents.DotNetBar.OfficeForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Settings))
        Me.ComboBox_DefaultValueType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.SwitchButton_SearchUpdates = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBox_AreaEditor_DefaultWindowMode = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBox_AreaEditor_DefaultCameraMode = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX()
        Me.ComboBoxEx_HexEditorMode = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.TextBoxX_HexEditorCustomPath = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX_EmulatorPatch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
        Me.ComboBoxEx_LoaderModule = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem4 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ComboBoxEx_AutoScaleMode = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.TabControlPanel4.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox_DefaultValueType
        '
        resources.ApplyResources(Me.ComboBox_DefaultValueType, "ComboBox_DefaultValueType")
        Me.ComboBox_DefaultValueType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_DefaultValueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_DefaultValueType.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_DefaultValueType.FormattingEnabled = True
        Me.ComboBox_DefaultValueType.Items.AddRange(New Object() {resources.GetString("ComboBox_DefaultValueType.Items"), resources.GetString("ComboBox_DefaultValueType.Items1"), resources.GetString("ComboBox_DefaultValueType.Items2"), resources.GetString("ComboBox_DefaultValueType.Items3")})
        Me.ComboBox_DefaultValueType.Name = "ComboBox_DefaultValueType"
        Me.ComboBox_DefaultValueType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX3, "LabelX3")
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        '
        'SwitchButton_SearchUpdates
        '
        resources.ApplyResources(Me.SwitchButton_SearchUpdates, "SwitchButton_SearchUpdates")
        '
        '
        '
        Me.SwitchButton_SearchUpdates.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton_SearchUpdates.Name = "SwitchButton_SearchUpdates"
        Me.SwitchButton_SearchUpdates.OffTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SwitchButton_SearchUpdates.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SwitchButton_SearchUpdates.OnTextColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SwitchButton_SearchUpdates.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton_SearchUpdates.SwitchBackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SwitchButton_SearchUpdates.SwitchBorderColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.SwitchButton_SearchUpdates.SwitchWidth = 15
        Me.SwitchButton_SearchUpdates.Value = True
        Me.SwitchButton_SearchUpdates.ValueObject = "Y"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX1, "LabelX1")
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        '
        'ComboBox_AreaEditor_DefaultWindowMode
        '
        resources.ApplyResources(Me.ComboBox_AreaEditor_DefaultWindowMode, "ComboBox_AreaEditor_DefaultWindowMode")
        Me.ComboBox_AreaEditor_DefaultWindowMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_AreaEditor_DefaultWindowMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_AreaEditor_DefaultWindowMode.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_AreaEditor_DefaultWindowMode.FormattingEnabled = True
        Me.ComboBox_AreaEditor_DefaultWindowMode.Items.AddRange(New Object() {resources.GetString("ComboBox_AreaEditor_DefaultWindowMode.Items"), resources.GetString("ComboBox_AreaEditor_DefaultWindowMode.Items1")})
        Me.ComboBox_AreaEditor_DefaultWindowMode.Name = "ComboBox_AreaEditor_DefaultWindowMode"
        Me.ComboBox_AreaEditor_DefaultWindowMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX7, "LabelX7")
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        '
        'ComboBox_AreaEditor_DefaultCameraMode
        '
        resources.ApplyResources(Me.ComboBox_AreaEditor_DefaultCameraMode, "ComboBox_AreaEditor_DefaultCameraMode")
        Me.ComboBox_AreaEditor_DefaultCameraMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_AreaEditor_DefaultCameraMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_AreaEditor_DefaultCameraMode.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_AreaEditor_DefaultCameraMode.FormattingEnabled = True
        Me.ComboBox_AreaEditor_DefaultCameraMode.Items.AddRange(New Object() {resources.GetString("ComboBox_AreaEditor_DefaultCameraMode.Items"), resources.GetString("ComboBox_AreaEditor_DefaultCameraMode.Items1")})
        Me.ComboBox_AreaEditor_DefaultCameraMode.Name = "ComboBox_AreaEditor_DefaultCameraMode"
        Me.ComboBox_AreaEditor_DefaultCameraMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX6, "LabelX6")
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        '
        'TabControl2
        '
        Me.TabControl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl2.CanReorderTabs = False
        Me.TabControl2.Controls.Add(Me.TabControlPanel1)
        Me.TabControl2.Controls.Add(Me.TabControlPanel4)
        Me.TabControl2.Controls.Add(Me.TabControlPanel2)
        Me.TabControl2.Controls.Add(Me.TabControlPanel3)
        resources.ApplyResources(Me.TabControl2, "TabControl2")
        Me.TabControl2.ForeColor = System.Drawing.Color.Black
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Style = DevComponents.DotNetBar.eTabStripStyle.Metro
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.TabItem1)
        Me.TabControl2.Tabs.Add(Me.TabItem3)
        Me.TabControl2.Tabs.Add(Me.TabItem2)
        Me.TabControl2.Tabs.Add(Me.TabItem4)
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.ComboBoxEx_AutoScaleMode)
        Me.TabControlPanel1.Controls.Add(Me.LabelX5)
        Me.TabControlPanel1.Controls.Add(Me.ButtonX5)
        Me.TabControlPanel1.Controls.Add(Me.ComboBoxEx_HexEditorMode)
        Me.TabControlPanel1.Controls.Add(Me.TextBoxX_HexEditorCustomPath)
        Me.TabControlPanel1.Controls.Add(Me.LabelX4)
        Me.TabControlPanel1.Controls.Add(Me.ButtonX4)
        Me.TabControlPanel1.Controls.Add(Me.ComboBoxEx1)
        Me.TabControlPanel1.Controls.Add(Me.LabelX10)
        Me.TabControlPanel1.Controls.Add(Me.ButtonX3)
        Me.TabControlPanel1.Controls.Add(Me.ButtonX2)
        Me.TabControlPanel1.Controls.Add(Me.TextBoxX_EmulatorPatch)
        Me.TabControlPanel1.Controls.Add(Me.LabelX9)
        Me.TabControlPanel1.Controls.Add(Me.LabelX1)
        Me.TabControlPanel1.Controls.Add(Me.SwitchButton_SearchUpdates)
        Me.TabControlPanel1.Controls.Add(Me.LabelX3)
        Me.TabControlPanel1.Controls.Add(Me.ComboBox_DefaultValueType)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.TabControlPanel1, "TabControlPanel1")
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'ButtonX5
        '
        Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        resources.ApplyResources(Me.ButtonX5, "ButtonX5")
        Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX5.FocusCuesEnabled = False
        Me.ButtonX5.Name = "ButtonX5"
        Me.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX5.Symbol = "58055"
        Me.ButtonX5.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonX5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX5.SymbolSize = 12.0!
        '
        'ComboBoxEx_HexEditorMode
        '
        resources.ApplyResources(Me.ComboBoxEx_HexEditorMode, "ComboBoxEx_HexEditorMode")
        Me.ComboBoxEx_HexEditorMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx_HexEditorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx_HexEditorMode.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx_HexEditorMode.FormattingEnabled = True
        Me.ComboBoxEx_HexEditorMode.Items.AddRange(New Object() {Me.ComboItem7, Me.ComboItem8})
        Me.ComboBoxEx_HexEditorMode.Name = "ComboBoxEx_HexEditorMode"
        Me.ComboBoxEx_HexEditorMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem7
        '
        resources.ApplyResources(Me.ComboItem7, "ComboItem7")
        '
        'ComboItem8
        '
        resources.ApplyResources(Me.ComboItem8, "ComboItem8")
        '
        'TextBoxX_HexEditorCustomPath
        '
        resources.ApplyResources(Me.TextBoxX_HexEditorCustomPath, "TextBoxX_HexEditorCustomPath")
        Me.TextBoxX_HexEditorCustomPath.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX_HexEditorCustomPath.Border.Class = "TextBoxBorder"
        Me.TextBoxX_HexEditorCustomPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_HexEditorCustomPath.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX_HexEditorCustomPath.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX_HexEditorCustomPath.Name = "TextBoxX_HexEditorCustomPath"
        Me.TextBoxX_HexEditorCustomPath.PreventEnterBeep = True
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX4, "LabelX4")
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        resources.ApplyResources(Me.ButtonX4, "ButtonX4")
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboBoxEx1
        '
        resources.ApplyResources(Me.ComboBoxEx1, "ComboBoxEx1")
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx1.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem1
        '
        resources.ApplyResources(Me.ComboItem1, "ComboItem1")
        '
        'ComboItem2
        '
        resources.ApplyResources(Me.ComboItem2, "ComboItem2")
        '
        'ComboItem3
        '
        resources.ApplyResources(Me.ComboItem3, "ComboItem3")
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX10, "LabelX10")
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        resources.ApplyResources(Me.ButtonX3, "ButtonX3")
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.FocusCuesEnabled = False
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        resources.ApplyResources(Me.ButtonX2, "ButtonX2")
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.FocusCuesEnabled = False
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = "58055"
        Me.ButtonX2.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX2.SymbolSize = 12.0!
        '
        'TextBoxX_EmulatorPatch
        '
        resources.ApplyResources(Me.TextBoxX_EmulatorPatch, "TextBoxX_EmulatorPatch")
        Me.TextBoxX_EmulatorPatch.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX_EmulatorPatch.Border.Class = "TextBoxBorder"
        Me.TextBoxX_EmulatorPatch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_EmulatorPatch.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX_EmulatorPatch.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX_EmulatorPatch.Name = "TextBoxX_EmulatorPatch"
        Me.TextBoxX_EmulatorPatch.PreventEnterBeep = True
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX9, "LabelX9")
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        resources.ApplyResources(Me.TabItem1, "TabItem1")
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.ComboBoxEx_LoaderModule)
        Me.TabControlPanel4.Controls.Add(Me.LabelX2)
        Me.TabControlPanel4.DisabledBackColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.TabControlPanel4, "TabControlPanel4")
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabItem = Me.TabItem4
        '
        'ComboBoxEx_LoaderModule
        '
        resources.ApplyResources(Me.ComboBoxEx_LoaderModule, "ComboBoxEx_LoaderModule")
        Me.ComboBoxEx_LoaderModule.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx_LoaderModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx_LoaderModule.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx_LoaderModule.FormattingEnabled = True
        Me.ComboBoxEx_LoaderModule.Name = "ComboBoxEx_LoaderModule"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX2, "LabelX2")
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        '
        'TabItem4
        '
        Me.TabItem4.AttachedControl = Me.TabControlPanel4
        Me.TabItem4.Name = "TabItem4"
        resources.ApplyResources(Me.TabItem4, "TabItem4")
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.LabelX6)
        Me.TabControlPanel2.Controls.Add(Me.ComboBox_AreaEditor_DefaultCameraMode)
        Me.TabControlPanel2.Controls.Add(Me.ComboBox_AreaEditor_DefaultWindowMode)
        Me.TabControlPanel2.Controls.Add(Me.LabelX7)
        Me.TabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.TabControlPanel2, "TabControlPanel2")
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        resources.ApplyResources(Me.TabItem2, "TabItem2")
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.ButtonX1)
        Me.TabControlPanel3.DisabledBackColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.TabControlPanel3, "TabControlPanel3")
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabItem = Me.TabItem3
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.FocusCuesEnabled = False
        resources.ApplyResources(Me.ButtonX1, "ButtonX1")
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel3
        Me.TabItem3.Name = "TabItem3"
        resources.ApplyResources(Me.TabItem3, "TabItem3")
        '
        'ComboBoxEx_AutoScaleMode
        '
        resources.ApplyResources(Me.ComboBoxEx_AutoScaleMode, "ComboBoxEx_AutoScaleMode")
        Me.ComboBoxEx_AutoScaleMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx_AutoScaleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx_AutoScaleMode.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx_AutoScaleMode.FormattingEnabled = True
        Me.ComboBoxEx_AutoScaleMode.Items.AddRange(New Object() {Me.ComboItem6, Me.ComboItem9, Me.ComboItem10})
        Me.ComboBoxEx_AutoScaleMode.Name = "ComboBoxEx_AutoScaleMode"
        Me.ComboBoxEx_AutoScaleMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX5, "LabelX5")
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        '
        'ComboItem6
        '
        resources.ApplyResources(Me.ComboItem6, "ComboItem6")
        '
        'ComboItem9
        '
        resources.ApplyResources(Me.ComboItem9, "ComboItem9")
        '
        'ComboItem10
        '
        resources.ApplyResources(Me.ComboItem10, "ComboItem10")
        '
        'Form_Settings
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl2)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Settings"
        Me.ShowIcon = False
        Me.TopLeftCornerSize = 0
        Me.TopRightCornerSize = 0
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel4.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SwitchButton_SearchUpdates As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBox_DefaultValueType As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboBox_AreaEditor_DefaultWindowMode As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBox_AreaEditor_DefaultCameraMode As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabItem4 As DevComponents.DotNetBar.TabItem
    Friend WithEvents ComboBoxEx_LoaderModule As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX_EmulatorPatch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX_HexEditorCustomPath As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx_HexEditorMode As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ButtonX5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboBoxEx_AutoScaleMode As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
End Class
