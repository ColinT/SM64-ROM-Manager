using System.Collections.Generic;
using global::System.IO;
using Microsoft.VisualBasic.CompilerServices;
using global::Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace SM64Lib.Configuration
{
    public class RomConfig
    {
        public Dictionary<byte, LevelConfig> LevelConfigs { get; private set; } = new Dictionary<byte, LevelConfig>();
        public ObjectModelConfig GlobalObjectBankConfig { get; private set; } = new ObjectModelConfig();
        public MusicConfiguration MusicConfig { get; private set; } = new MusicConfiguration();
        public string SelectedTextProfileInfo { get; set; } = string.Empty;

        public LevelConfig GetLevelConfig(ushort levelID)
        {
            if (LevelConfigs.ContainsKey(Conversions.ToByte(levelID)))
            {
                return LevelConfigs[Conversions.ToByte(levelID)];
            }
            else
            {
                var conf = new LevelConfig();
                LevelConfigs.Add(Conversions.ToByte(levelID), conf);
                return conf;
            }
        }

        public static RomConfig Load(string filePath)
        {
            var serializer = JsonSerializer.CreateDefault();
            serializer.PreserveReferencesHandling = PreserveReferencesHandling.All;
            return JObject.Parse(File.ReadAllText(filePath)).ToObject<RomConfig>(serializer);
        }

        public void Save(string filePath)
        {
            var serializer = JsonSerializer.CreateDefault();
            serializer.PreserveReferencesHandling = PreserveReferencesHandling.All;
            File.WriteAllText(filePath, JObject.FromObject(this).ToString(serializer));
        }
    }
}