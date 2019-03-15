using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EngineClasses.CoreClasses.Tasks;
using UserControlsLibrary.PointTab.MainWindowControls;
using EventClasses.UserEventArgs;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.PointTab
{
    public partial class TabSingleElement : UserControl
    {
        public SingleTabDataController output_dc { get; private set; }
        public event EventHandler<UserEventArgs<LocalDataGraphicsElement>> saveDataRequested;
        public TabSingleElement()
        {
            InitializeComponent();
            output_dc = new SingleTabDataController(this.outputTabControl1, this.inputControl1);
        }
        private void SaveRequest(object sender, UserEventArgs<LocalDataGraphicsElement> e)
        {

        }
    }
}
