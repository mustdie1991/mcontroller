using EngineClasses.Interfaces;
using System.Collections.Generic;
using EngineClasses.OutputElementsClasses;
using System.Drawing;
using ZedGraph;

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
            var zcontrol = (ZedGraphControl)histogramGrid;
            switch (data)
            {
                case HistogramData _:
                    DrawSingleBar((HistogramData)data);
                    break;
                case List<HistogramData> _:
                    DrawCollectionOfHists((List<HistogramData>)data);
                    break;
            }
            zcontrol.AxisChange();
            zcontrol.Invalidate();
        }
        private void DrawSingleBar(HistogramData item)
        {
            var zcontrol = (ZedGraphControl)histogramGrid;
            zcontrol.GraphPane.AddBar(item.name, item.steps.sizeNumber, item.steps.funcValue, item.color);
        }
        private void DrawCollectionOfHists(List<HistogramData> items)
        {
            var zcontrol = (ZedGraphControl)histogramGrid;
            zcontrol.GraphPane.CurveList.Clear();
            zcontrol.GraphPane.BarType = BarType.SortedOverlay;
            foreach (var h in items)
            {
                DrawSingleBar(h);
            }
            zcontrol.GraphPane.MinClusterGap = 0.0f;
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
            var zcontrol = (ZedGraphControl)histogramGrid;
            zcontrol.GraphPane.XAxis.Title = "Номер столбца";
            zcontrol.GraphPane.YAxis.Title = "Количество точек";
            ((ZedGraphControl)histogramGrid).GraphPane.BarType = BarType.SortedOverlay;
        }
        public void SetTitle(OutputType outs)
        {
            ((ZedGraphControl)histogramGrid).GraphPane.Title = "Гистограмма " + outs.ToString();
        }
        public Bitmap DrawToBitmap()
        {
            var zcontrol = (ZedGraphControl)histogramGrid;
            return new Bitmap(zcontrol.GraphPane.Image);
        }
    }
}
