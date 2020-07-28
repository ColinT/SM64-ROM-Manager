using DevComponents.DotNetBar;
using DevComponents.Editors;
using SM64Lib.Geolayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    public partial class ObjectShadowEditor : OfficeForm
    {
        public ObjectShadow ObjectShadow { get; private set; }

        private readonly BindingList<KeyValuePair<string, ObjectShadowType>> ComboBoxEx_Type_Items = new BindingList<KeyValuePair<string, ObjectShadowType>>();

        public ObjectShadowEditor(ObjectShadow shadow)
        {
            ObjectShadow = shadow;

            // Initialize GUI
            InitializeComponent();
            ComboBoxEx_Type.DisplayMember = "Key";
            ComboBoxEx_Type.ValueMember = "Value";

            // Add values to combobox
            var objectShadowTypeNames = Enum.GetNames(typeof(ObjectShadowType));
            var objectShadowTypeValues = (ObjectShadowType[])Enum.GetValues(typeof(ObjectShadowType));
            for (int i = 0; i < objectShadowTypeNames.Length; i++)
            {
                ComboBoxEx_Type_Items.Add(new KeyValuePair<string, ObjectShadowType>(objectShadowTypeNames[i], objectShadowTypeValues[i]));
            }
            ComboBoxEx_Type.DataSource = ComboBoxEx_Type_Items;
        }

        private void LoadProps()
        {
            ComboBoxEx_Type.SelectedValue = ObjectShadow.Type;
            IntegerInput_Diameter.Value = ObjectShadow.Scale;
            IntegerInput_Opacity.Value = ObjectShadow.Solidity;
        }

        private void SaveProps()
        {
            ObjectShadow.Type = (ObjectShadowType)ComboBoxEx_Type.SelectedValue;
            ObjectShadow.Scale = (short)IntegerInput_Diameter.Value;
            ObjectShadow.Solidity = (byte)IntegerInput_Opacity.Value;
        }

        private void ButtonX_Save_Click(object sender, EventArgs e)
        {
            SaveProps();
        }

        private void ObjectShadowEditor_Load(object sender, EventArgs e)
        {
            LoadProps();
        }
    }
}
