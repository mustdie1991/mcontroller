using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserControlsLibrary.UserOutputsTab.CalculatedInfoControls
{
    public partial class SavedBlocksControlMenu : UserControl
    {
        public CalculatedInfoDataController dc { get; private set; }
        public SavedBlocksControlMenu()
        {
            InitializeComponent();
            dc = new CalculatedInfoDataController(this.blocksControlMenu2, this.dataGridView1);
        }
    }
}
