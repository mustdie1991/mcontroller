using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EngineClasses.OutputElementsClasses;
using EventClasses.UserEventArgs;

namespace UserControlsLibrary.PointTab.GraphicConrtols
{
    public partial class GraphsList : UserControl
    {
        public event EventHandler<MessageEventArgs> DisableCurve;
        public event EventHandler<MessageEventArgs> EnableCurve;
        public event EventHandler<EventArgs> ClearAllCurves;
        public event EventHandler<MessageEventArgs> DeleteCurve;
        public event EventHandler<EventArgs> SaveAllCurves;

        public GraphsList()
        {
            InitializeComponent();
        }
        public bool AddCurveToList(string name)
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
        public void ResetCurvelist(List<GraphItem> gItem)
        {
            checkedListBox1.Items.Clear();
            foreach (var item in gItem)
            {
                checkedListBox1.Items.Add(item.Name);
                checkedListBox1.SetItemChecked(checkedListBox1.Items.Count - 1, item.enabled);
            }
        }
        private void GraphsList_CheckedChanged(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                EnableCurve(this, new MessageEventArgs(checkedListBox1.Items[e.Index].ToString()));
            else
                DisableCurve(this, new MessageEventArgs(checkedListBox1.Items[e.Index].ToString()));
        }

        private void button_cleadAll_Click(object sender, EventArgs e)
        {
            var dlg = MessageBox.Show("Действительно очистить все данные графиков?", "Очистка графиков", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                checkedListBox1.Items.Clear();
                ClearAllCurves(this, new EventArgs());
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            var dlg = MessageBox.Show("Сохранить графики?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                SaveAllCurves(this, new EventArgs());
            }
        }
    }
}
