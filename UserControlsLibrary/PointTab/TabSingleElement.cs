using System;
using System.Windows.Forms;
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
            output_dc = new SingleTabDataController(outputTabControl1, inputControl1);
        }
        private void SaveRequest(object sender, UserEventArgs<LocalDataGraphicsElement> e)
        {

        }
    }
}
