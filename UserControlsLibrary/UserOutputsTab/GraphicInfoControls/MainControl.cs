using System.Windows.Forms;

namespace UserControlsLibrary.UserOutputsTab.GraphicInfoControls
{
    public partial class GraphicsInfoMainControl : UserControl
    {
        private GraphicsInfoDataController dc;
        public GraphicsInfoMainControl()
        {
            InitializeComponent();
            dc = new GraphicsInfoDataController(graphicsInfoControlMenu1, pictureBox_output);
        }
    }
}
