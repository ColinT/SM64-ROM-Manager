﻿using global::System.Drawing;
using System.Linq;
using global::DevComponents.DotNetBar;
using global::DevComponents.DotNetBar.Metro.ColorTables;
using Newtonsoft.Json;

namespace SM64_ROM_Manager.SettingsManager
{
    public class StyleManagerSettingsStruc
    {
        public bool AlwaysKeepBlueColors { get; set; }
        public MetroColorGeneratorParameters MetroColorParams { get; set; }
        [JsonProperty("UseWindows10Style")]
        public bool UseSystemTheme { get; set; }

        public void ResetValues()
        {
            AlwaysKeepBlueColors = false;
            MetroColorParams = VisualThemeLight; // MetroColorGeneratorParameters.Office2016Purple
            UseSystemTheme = true;
        }

        public bool IsDarkTheme()
        {
            return IsDarkTheme(MetroColorParams);
        }

        public bool IsWhiteTheme()
        {
            return IsWhiteTheme(MetroColorParams);
        }

        public static bool IsDarkTheme(MetroColorGeneratorParameters theme)
        {
            return new[] { VisualThemeDark }.Contains(theme);
        }

        public static bool IsWhiteTheme(MetroColorGeneratorParameters theme)
        {
            return theme.CanvasColor.ToArgb() == Color.White.ToArgb();
        }

        public static MetroColorGeneratorParameters VisualThemeLight
        {
            get
            {
                return new MetroColorGeneratorParameters(ColorScheme.GetColor("FFFFFF"), ColorScheme.GetColor("80397B"), "Light");
            }
        }

        public static MetroColorGeneratorParameters VisualThemeGray
        {
            get
            {
                return new MetroColorGeneratorParameters(ColorScheme.GetColor("EFEFF2"), ColorScheme.GetColor("662D62"), "Gray");
            }
        }

        public static MetroColorGeneratorParameters VisualThemeDark
        {
            get
            {
                return new MetroColorGeneratorParameters(ColorScheme.GetColor("262626"), ColorScheme.GetColor("4C2249"), "Dark");
            }
        }
    }
}