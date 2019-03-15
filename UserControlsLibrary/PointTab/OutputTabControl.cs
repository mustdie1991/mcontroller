using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
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
            dc = new OutputsDataController(this.mainMatrixControl1, this.mainGraphControl2, this.mainHistogramControl1);
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
