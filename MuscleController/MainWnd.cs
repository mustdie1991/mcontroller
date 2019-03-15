using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using ZedGraph;
using UserControlsLibrary.PointTab.MatrixControls;
using UserControlsLibrary.PointTab.GraphicConrtols;
using UserControlsLibrary.PointTab.Histograms;
using EngineClasses.CoreClasses.Tasks;
using UserControlsLibrary.PointTab.MainWindowControls;
using UserControlsLibrary.PointTab;
using EngineClasses.OutputElementsClasses;
using EventClasses.UserEventArgs;

namespace UserControlsLibrary.PointTab
{
    public partial class MainWnd : Form
    {
        public event EventHandler<UserEventArgs<LocalDataGraphicsElement>> saveRequest;
        private void OnLoad(object sender, EventArgs e)
        {
        }
        public MainWnd()
        {
            InitializeComponent();
            tabControl1.Width = SystemInformation.PrimaryMonitorSize.Width - 20;
            tabControl1.Height = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height - 80;
        }

    }
}
