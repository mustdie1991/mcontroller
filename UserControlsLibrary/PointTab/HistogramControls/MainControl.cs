using System.Windows.Forms;

namespace UserControlsLibrary.PointTab.Histograms
{
    public partial class MainHistogramControl : UserControl
    {
        public HistogramDataController dc { get; private set; }
        public MainHistogramControl()
        {
            InitializeComponent();
            dc = new HistogramDataController(zedGraph_histograms, histogramDataGrid1, histogramControlMenu1, histogramList1);
        }
    }
}
