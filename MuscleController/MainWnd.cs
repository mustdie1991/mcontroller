using System;
using System.Windows.Forms;
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
