using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EventClasses.UserEventArgs;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.UserOutputsTab.GraphicInfoControls
{
    public partial class GraphicsInfoControlMenu : UserControl
    {
        public event EventHandler<UserEventArgs<BitmapType>> outputTypeChanged;
        public event EventHandler<MessageEventArgs> itemSelectionChanged;
        public GraphicsInfoControlMenu()
        {
            InitializeComponent();
            comboBox_type.Items.AddRange((string[])Enum.GetNames(typeof(BitmapType)));
        }
        public void SetListBoxItems(object items)
        {
            listBox_outs.Items.Clear();
            List<LocalDataGraphicsElement> elements = (List<LocalDataGraphicsElement>)items;
            foreach (LocalDataGraphicsElement l in elements)
                listBox_outs.Items.Add(l.Name);
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputTypeChanged(this, new UserEventArgs<BitmapType>((BitmapType)(Enum.GetValues(typeof(BitmapType)).GetValue(comboBox_type.SelectedIndex))));
        }

        private void listBox_outs_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemSelectionChanged(this, new MessageEventArgs(listBox_outs.SelectedItem.ToString()));
        }
    }
}
