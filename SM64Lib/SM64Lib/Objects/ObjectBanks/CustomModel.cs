using global::SM64Lib.Configuration;

namespace SM64Lib.ModelBanks
{
    public class CustomModel
    {
        public CustomObjectConfig Config { get; set; } = new CustomObjectConfig();
        public Geolayout.Geolayout Geolayout { get; set; } = null;
        public Model.ObjectModel Model { get; set; } = null;
        public byte ModelID { get; set; } = 0;

        private int modelOffset = 0;
        private int geolayoutOffset = 0;
        private int colPointer = 0;

        public int ModelBankOffset
        {
            get
            {
                return modelOffset;
            }

            internal set
            {
                modelOffset = value;
            }
        }

        public int GeolayoutBankOffset
        {
            get
            {
                return geolayoutOffset;
            }

            internal set
            {
                geolayoutOffset = value;
            }
        }

        public int CollisionPointer
        {
            get
            {
                return colPointer;
            }

            internal set
            {
                colPointer = value;
            }
        }

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