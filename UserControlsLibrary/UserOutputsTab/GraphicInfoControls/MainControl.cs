using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserControlsLibrary.UserOutputsTab.GraphicInfoControls
{
    public partial class GraphicsInfoMainControl : UserControl
    {
        private GraphicsInfoDataController dc;
        public GraphicsInfoMainControl()
        {
            InitializeComponent();
            dc = new GraphicsInfoDataController(this.graphicsInfoControlMenu1, this.pictureBox_output);
        }
    }
}
