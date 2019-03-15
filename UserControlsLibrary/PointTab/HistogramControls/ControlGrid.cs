using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses.UserEventArgs;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.PointTab.Histograms
{
    public partial class HistogramDataGrid : UserControl
    {
        public event EventHandler<MessageEventArgs> histogramChanged;

        public HistogramDataGrid()
        {
            InitializeComponent();
        }
        public void FillDataGrid(List<HDataGridDataItem> items)
        {
            dataGridView_All.Rows.Clear();
            dataGridView_All.RowCount = items.Count;
            for (var i = 0; i < items.Count; i++)
            {
                dataGridView_All[0, i].Value = items[i].interval;
                dataGridView_All[1, i].Value = items[i].points;
                dataGridView_All[2, i].Value = $"{items[i].percent:0.00%}";
            }
        }
        public void AddSingleComboitem(string name)
        {
            comboBox_number.Items.Add(name);
        }
        public void FillComboHists(string[] names)
        {
            ClearAllData();
            for (var i = 0; i < names.Length; i++)
                comboBox_number.Items.Add(names[i]);
        }
        public void ClearAllData()
        {
            comboBox_number.Items.Clear();
            dataGridView_All.Rows.Clear();
        }
        private void comboBox_number_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((ComboBox)sender).SelectedIndex != -1)
                histogramChanged(this, new MessageEventArgs(comboBox_number.SelectedItem.ToString()));
        }
    }
}
