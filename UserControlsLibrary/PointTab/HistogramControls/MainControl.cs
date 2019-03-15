using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EngineClasses.CoreClasses.Tasks;

namespace UserControlsLibrary.PointTab.Histograms
{
    public partial class MainHistogramControl : UserControl
    {
        public HistogramDataController dc { get; private set; }
        public MainHistogramControl()
        {
            InitializeComponent();
            dc = new HistogramDataController(this.zedGraph_histograms, this.histogramDataGrid1, this.histogramControlMenu1, this.histogramList1);
        }
    }
}
