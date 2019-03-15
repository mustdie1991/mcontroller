using System;
using UserControlsLibrary.PointTab.Histograms;
using UserControlsLibrary.PointTab.GraphicConrtols;
using UserControlsLibrary.PointTab.MatrixControls;
using UserControlsLibrary.PointTab.MainWindowControls;
using EngineClasses.CoreClasses.Tasks;
using EventClasses.UserEventArgs;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.PointTab
{
    public class SingleTabDataController
    {
        private object OutputControl;
        private object InputControl;
        public event EventHandler<UserEventArgs<LocalDataGraphicsElement>> saveRequested;
        public SingleTabDataController(object outControl, object inControl)
        {
            if (outControl is OutputTabControl || inControl is InputControl)
            {
                OutputControl = outControl;
                InputControl = inControl;
                ((InputControl)inControl).SendDataRequest += SendDataToOutputsControl;
                ((OutputTabControl)outControl).saveRequested += SaveDataRoutedRequest;
            }
            else throw new ArgumentException("Не подходящие элементы ввода/вывода!");
        }
        public void SendDataToOutputsControl(object sender, UserEventArgs<MElementsBlock> e)
        {
            ((OutputTabControl)OutputControl).dc.GetData(e.item);
        }
        private void SaveDataRoutedRequest(object sender, UserEventArgs<LocalDataGraphicsElement> e)
        {
            saveRequested(this, new UserEventArgs<LocalDataGraphicsElement>(e.item));
        }
    }
    public class OutputsDataController
    {
        private object MatrixControlOut;
        private object GraphControlOut;
        private object HistogramControlOut;

        public event EventHandler<UserEventArgs<LocalDataGraphicsElement>> saveRequested;

        public OutputsDataController(object mControl, object gControl, object hControl)
        {
            if (mControl is MainMatrixControl && gControl is MainGraphControl && hControl is MainHistogramControl)
            {
                MatrixControlOut = mControl;
                GraphControlOut = gControl;
                HistogramControlOut = hControl;
                //((MainMatrixControl)mControl).SaveRequested += 
            }
            else throw new ArgumentException("Не подходящие элементы вывода! (Шаблон : матрица, график, гистограмма)");
        }
        public void GetData(MElementsBlock e)
        {
            ((MainHistogramControl)HistogramControlOut).dc.SendDataToControlMenu(e);
            ((MainGraphControl)GraphControlOut).dc.SendDataToControlMenu(e);
            ((MainMatrixControl)MatrixControlOut).dc.SendDataToControlMenu(e);
        }
        private void RoutedSaveRequest(object sender, UserEventArgs<LocalDataGraphicsElement> e)
        {
            saveRequested(this, new UserEventArgs<LocalDataGraphicsElement>(e.item));
        }
    }
}
