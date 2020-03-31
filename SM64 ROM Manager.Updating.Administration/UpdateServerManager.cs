using global::System.IO;
using global::Newtonsoft.Json.Linq;

namespace SM64_ROM_Manager.Updating.Administration
{
    public class UpdateServerManager
    {
        public UpdateInfo UpdateInfo { get; private set; }
        public UpdateServerConfig Config { get; private set; }

        public UpdateServerManager(UpdateServerConfig config)
        {
            Config = config;
            NewInfo();
        }

        public void LoadInfoFromServer()
        {

        }

        public void SaveInfoToServer()
        {

        }

        public void LoadInfoFromFile(string filePath)
        {
            UpdateInfo = JObject.Parse(File.ReadAllText(filePath)).ToObject<UpdateInfo>();
        }

        public void SaveInfoToFile(string filePath)
        {
            File.WriteAllText(filePath, JObject.FromObject(UpdateInfo).ToString());
        }

        public void NewInfo()
        {
            UpdateInfo = new UpdateInfo();
        }
    }
}