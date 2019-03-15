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

namespace UserControlsLibrary.UserOutputsTab.CalculatedInfoControls
{
    public partial class BlocksControlMenu : UserControl
    {
        public event EventHandler<ListCheckedEventArgs> ListCheckedStateChanged;
        public event EventHandler<EventArgs> RefreshRequest;

        public BlocksControlMenu()
        {
            InitializeComponent();  
        }
        private void ItemCheckedStateChanged(object sender, ItemCheckEventArgs e)
        {
            try
            {
                ListCheckedStateChanged(this, new ListCheckedEventArgs(checkedListBox1.Items[e.Index].ToString(), (e.NewValue == CheckState.Checked) ? true : false));
            }
            catch
            {
            }
        }
        public void ResetListData(object items)
        {
            this.checkedListBox1.Items.Clear();
            if (items is List<MParametersList>)
            {
                List<MParametersList> pList = (List<MParametersList>)items;
                foreach (MParametersList p in pList)
                {
                    this.checkedListBox1.Items.Add(p.Name);
                    this.checkedListBox1.SetItemChecked(checkedListBox1.Items.Count - 1, p.Enabled);
                }
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            ResetListData(LocalDataBase.GetAllBlocksList());
        }
    }
}
