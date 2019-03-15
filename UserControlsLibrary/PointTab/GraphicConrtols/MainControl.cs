using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserControlsLibrary.PointTab.GraphicConrtols
{
    public partial class MainGraphControl : UserControl
    {
        public GraphicsDataController dc { get; private set; }
        public MainGraphControl()
        {
            InitializeComponent();
            dc = new GraphicsDataController(this.zedGraphControl_graphs, this.graphControlMenu1, this.graphsList1);
        }
    }
}
