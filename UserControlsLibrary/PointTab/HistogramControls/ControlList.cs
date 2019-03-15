using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EngineClasses.OutputElementsClasses;
using EventClasses.UserEventArgs;

namespace UserControlsLibrary.PointTab.Histograms
{
    public partial class HistogramList : UserControl
    {
        public event EventHandler<MessageEventArgs> HistogramDisabled;
        public event EventHandler<MessageEventArgs> HistogramEnabled;
        public event EventHandler<EventArgs> AllHistsCleared;
        public event EventHandler<EventArgs> SaveHists;
        public HistogramList()
        {
            InitializeComponent();
        }
        public bool AddHistToList(string name)
        {
            if (checkedListBox1.Items.Contains(name))
            {
                return false;
            }
            else
            {
                checkedListBox1.Items.Add(name);
                checkedListBox1.SetItemChecked(checkedListBox1.Items.Count - 1, true);
                return true;
            }
        }
        public void ResetHistlist(List<HistogramData> hItem)
        {
            checkedListBox1.Items.Clear();
            foreach (var item in hItem)
            {
                checkedListBox1.Items.Add(item.name);
                checkedListBox1.SetItemChecked(checkedListBox1.Items.Count - 1, item.Enabled);
            }
        }
        public void ReloadHistlist(List<HistogramData> hItems)
        {
            checkedListBox1.Items.Clear();
            foreach (var item in hItems)
            {
                checkedListBox1.Items.Add(item.name);
                checkedListBox1.SetItemChecked(checkedListBox1.Items.Count - 1, item.Enabled);
            }
        }

        private void button_cleadAll_Click(object sender, EventArgs e)
        {
            var dlg = MessageBox.Show("Действительно очистить все данные графиков?", "Очистка графиков", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                checkedListBox1.Items.Clear();
                AllHistsCleared(this, new EventArgs());
            }
        }

        private void checkBox_ItemChecked(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                HistogramEnabled(this, new MessageEventArgs(checkedListBox1.Items[e.Index].ToString()));
            else
                HistogramDisabled(this, new MessageEventArgs(checkedListBox1.Items[e.Index].ToString()));
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveHists(this, new EventArgs());
        }
    }
}
