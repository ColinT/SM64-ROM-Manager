using global::SM64Lib.Configuration;

namespace SM64Lib.Objects.ModelBanks
{
    public class CustomModel
    {
        public CustomModelConfig Config { get; set; } = new CustomModelConfig();
        public Geolayout.Geolayout Geolayout { get; set; } = null;
        public Model.ObjectModel Model { get; set; } = null;
        public byte ModelID { get; set; } = 0;

        public int ModelBankOffset { get; internal set; } = 0;
        public int GeolayoutBankOffset { get; internal set; } = 0;
        public int CollisionPointer { get; internal set; } = 0;

        public CustomModel()
        {
            GenerateNewGeolayout();
        }

        public CustomModel(Model.ObjectModel mdl)
        {
            GenerateNewGeolayout();
            Model = mdl;
        }

        public CustomModel(Geolayout.Geolayout geo)
        {
            Geolayout = geo;
        }

        public CustomModel(Geolayout.Geolayout geo, Model.ObjectModel mdl)
        {
            Geolayout = geo;
            Model = mdl;
        }

        public void GenerateNewGeolayout()
        {
            Geolayout = new Geolayout.Geolayout(SM64Lib.Geolayout.Geolayout.NewScriptCreationMode.Object);
        }
    }
}