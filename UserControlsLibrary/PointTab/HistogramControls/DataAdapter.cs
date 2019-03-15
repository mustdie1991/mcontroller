using System.Text;
using ZedGraph;
using EngineClasses.Interfaces;
using UserControlsLibrary;
using System.Collections.Generic;
using EngineClasses.OutputElementsClasses;
using System.Drawing;

namespace UserControlsLibrary.PointTab.Histograms
{
    public class HistogramAdapter : IAdapters
    {
        public static HistogramAdapter instance { get; private set; }
        public static object histogramGrid;
        static HistogramAdapter()
        {
            instance = new HistogramAdapter();
        }
        protected HistogramAdapter()
        {
        }
        public void Fill(object data)
        {
            ZedGraphControl zcontrol = (ZedGraphControl)histogramGrid;
            if (data is HistogramData)
            {
                DrawSingleBar((HistogramData)data);
            }
            else if (data is List<HistogramData>)
            {
                DrawCollectionOfHists((List<HistogramData>)data);
            }
            zcontrol.AxisChange();
            zcontrol.Invalidate();
        }
        private void DrawSingleBar(HistogramData item)
        {
            ZedGraphControl zcontrol = (ZedGraphControl)histogramGrid;
            zcontrol.GraphPane.AddBar(item.name, item.steps.sizeNumber, item.steps.funcValue, item.color);
        }
        private void DrawCollectionOfHists(List<HistogramData> items)
        {
            ZedGraphControl zcontrol = (ZedGraphControl)histogramGrid;
            zcontrol.GraphPane.CurveList.Clear();
            zcontrol.GraphPane.BarSettings.Type = BarType.SortedOverlay;
            foreach (HistogramData h in items)
            {
                DrawSingleBar(h);
            }
            zcontrol.GraphPane.BarSettings.MinClusterGap = 0.0f;
        }
        public void ClearAll()
        {
            ((ZedGraphControl)histogramGrid).GraphPane.CurveList.Clear();
            ((ZedGraphControl)histogramGrid).AxisChange();
            ((ZedGraphControl)histogramGrid).Invalidate();
        }
        public void SetComponent(object component)
        {
            if (component is ZedGraphControl)
                histogramGrid = component;
            ZedGraphControl zcontrol = (ZedGraphControl)histogramGrid;
            zcontrol.GraphPane.XAxis.Title.Text = "Номер столбца";
            zcontrol.GraphPane.YAxis.Title.Text = "Количество точек";
            ((ZedGraphControl)histogramGrid).GraphPane.BarSettings.Type = BarType.SortedOverlay;
        }
        public void SetTitle(OutputType outs)
        {
            ((ZedGraphControl)histogramGrid).GraphPane.Title.Text = "Гистограмма " + outs.ToString();
        }
        public Bitmap DrawToBitmap()
        {
            ZedGraphControl zcontrol = (ZedGraphControl)histogramGrid;
            return new Bitmap(zcontrol.GraphPane.GetImage());
        }
    }
}
