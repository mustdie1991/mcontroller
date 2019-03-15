using System.Windows.Forms;

namespace UserControlsLibrary.PointTab.GraphicConrtols
{
    public partial class MainGraphControl : UserControl
    {
        public GraphicsDataController dc { get; private set; }
        public MainGraphControl()
        {
            InitializeComponent();
            dc = new GraphicsDataController(zedGraphControl_graphs, graphControlMenu1, graphsList1);
        }
    }
}
