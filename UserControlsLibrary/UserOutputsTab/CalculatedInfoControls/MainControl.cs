using System.Windows.Forms;

namespace UserControlsLibrary.UserOutputsTab.CalculatedInfoControls
{
    public partial class SavedBlocksControlMenu : UserControl
    {
        public CalculatedInfoDataController dc { get; private set; }
        public SavedBlocksControlMenu()
        {
            InitializeComponent();
            dc = new CalculatedInfoDataController(blocksControlMenu2, dataGridView1);
        }
    }
}
