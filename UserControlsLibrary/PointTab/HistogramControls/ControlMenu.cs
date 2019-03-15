using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using EventClasses.UserEventArgs;
using EngineClasses.CoreClasses.Tasks;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.PointTab.Histograms
{
    public partial class HistogramControlMenu : UserControl
    {
        private ColorDialog dlg;

        public event EventHandler<UserEventArgs<HistogramData>> BuildHistogram;
        public event EventHandler<TypeEventArgs> TypeChanged;
        
        private MElementsBlock block;

        public HistogramControlMenu()
        {
            InitializeComponent();
            comboBox_block.Items.AddRange((string[])Enum.GetNames(typeof(TaskType)));
            comboBox_type.Items.AddRange((string[])Enum.GetNames(typeof(OutputType)));
            numericUpDown_cols.Maximum = 100;
            numericUpDown_cols.Minimum = 1;
            dlg = new ColorDialog();
        }
        public void SetBlock(MElementsBlock block)
        {
            if (block != null)
            {
                this.block = block;
            }
        }

        private void button_launch_Click(object sender, EventArgs e)
        {
            if (comboBox_block.SelectedIndex != -1 && comboBox_type.SelectedIndex != -1 && !String.IsNullOrEmpty(textBox_name.Text))
            {
                BuildHistogram(this, 
                    new UserEventArgs<HistogramData>(Converters.ConvertToHistogramData(block[comboBox_block.SelectedIndex].modelData, (int)numericUpDown_cols.Value,
                                                    (OutputType)(Enum.GetValues(typeof(OutputType)).GetValue(comboBox_type.SelectedIndex)),
                                                    (TaskType)(Enum.GetValues(typeof(TaskType)).GetValue(comboBox_block.SelectedIndex)),
                                                    dlg.Color,
                                                    string.Format("{0}({1})", textBox_name.Text, Enum.GetValues(typeof(TaskType)).GetValue(comboBox_block.SelectedIndex).ToString()))));
            }
        }

        private void button_ChColor_Click(object sender, EventArgs e)
        {
            dlg.ShowDialog();
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != -1)
            {
                TypeChanged(this, new TypeEventArgs((OutputType)(Enum.GetValues(typeof(OutputType)).GetValue(comboBox_type.SelectedIndex))));
            }
        }
    }
}
