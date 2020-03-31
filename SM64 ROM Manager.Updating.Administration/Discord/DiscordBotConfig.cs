using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.Updating.Administration.Discord
{
    public class DiscordBotConfig
    {
        public bool DiscordUploadEnabled { get; set; } = false;
        public string DiscordBotToken { get; set; } = string.Empty;
        public ulong DiscordGuildID { get; set; } = default;
        public ulong DiscordChannelID { get; set; } = default;
        public string DiscordMsgBaseURL { get; set; } = string.Empty;
        public string DiscordMsgParamCounter { get; set; } = string.Empty;
    }
}
