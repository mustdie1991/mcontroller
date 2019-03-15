using System;
using System.Windows.Forms;
using EventClasses.UserEventArgs;
using EngineClasses.CoreClasses.Tasks;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.PointTab.GraphicConrtols
{
    public partial class GraphControlMenu : UserControl
    {
        public event EventHandler<UserEventArgs<GraphItem>> BuildGraph;
        public event EventHandler<TypeEventArgs> TypeChanged;
        ColorDialog dlg = new ColorDialog();
        private MElementsBlock mBlock;
        
        public GraphControlMenu()
        {
            InitializeComponent();
            comboBox_BNumber.Items.AddRange((string[])Enum.GetNames(typeof(TaskType)));
            comboBox_Type.Items.AddRange((string[])Enum.GetNames(typeof(OutputType)));
            comboBox_color.Items.AddRange((string[])Enum.GetNames(typeof(ZedGraph.SymbolType)));
        }
        public void SetBlock(MElementsBlock block)
        {
            mBlock = block;
            ReloadNumericUpDown();
        }
        private void ReloadNumericUpDown()
        {
            numericUpDown_Layer.Maximum = mBlock[0].modelData.Layers - 1;
            numericUpDown_Layer.Minimum = 1;
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            if (comboBox_BNumber.SelectedIndex != -1 && comboBox_Type.SelectedIndex != -1 && !String.IsNullOrEmpty(textBox_graphName.Text) && numericUpDown_Layer.Value > 0)
            {
                BuildGraph(this, new UserEventArgs<GraphItem>(Converters.ConvertToGraphItem
                                                             (mBlock[comboBox_BNumber.SelectedIndex].modelData,
                                                             (TaskType)(Enum.GetValues(typeof(TaskType)).GetValue(comboBox_BNumber.SelectedIndex)),
                                                             (OutputType)(Enum.GetValues(typeof(OutputType)).GetValue(comboBox_Type.SelectedIndex)),
                                                             (int)numericUpDown_Layer.Value,
                                                             dlg.Color, 
                                                             string.Format("{0}({1})", textBox_graphName.Text, Enum.GetValues(typeof(TaskType)).GetValue(comboBox_BNumber.SelectedIndex).ToString()),
                                                             (comboBox_color.SelectedIndex > -1) ? (SymbolType)(Enum.GetValues(typeof(SymbolType)).GetValue(comboBox_color.SelectedIndex)) : SymbolType.Default)));
            } 
        }

        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != -1)
            {
                TypeChanged(this, new TypeEventArgs((OutputType)(Enum.GetValues(typeof(OutputType)).GetValue(comboBox_Type.SelectedIndex))));
                
            }
        }

        private void button_selectColor_Click(object sender, EventArgs e)
        {
            dlg.ShowDialog();
        }
    }
}
