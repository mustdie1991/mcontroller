using System;
using System.Windows.Forms;
using EngineClasses.CoreClasses.Tasks;
using EventClasses.UserEventArgs;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.PointTab
{
    public partial class OutputTabControl : UserControl
    {
        public OutputsDataController dc;
        public event EventHandler<UserEventArgs<LocalDataGraphicsElement>> saveRequested;
        public OutputTabControl()
        {
            InitializeComponent();
            dc = new OutputsDataController(mainMatrixControl1, mainGraphControl2, mainHistogramControl1);
            dc.saveRequested += RoutedSaveData;
        }
        public void SetData(MElementsBlock element)
        {
            dc.GetData(element);
        }
        private void RoutedSaveData(object sender, UserEventArgs<LocalDataGraphicsElement> e)
        {
            saveRequested(sender, new UserEventArgs<LocalDataGraphicsElement>(e.item));
        }
    }
}
