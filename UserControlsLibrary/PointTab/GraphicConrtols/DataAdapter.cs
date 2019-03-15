using System;
using System.Collections.Generic;
using EngineClasses.Interfaces;
using EngineClasses.OutputElementsClasses;
using System.Drawing;

namespace UserControlsLibrary.PointTab.GraphicConrtols
{
    public class GraphicsAdapter : IAdapters
    {
        public static GraphicsAdapter instance { get; private set; }
        private object graphicsGrid;
        protected GraphicsAdapter()
        {

        }
        static GraphicsAdapter()
        {
            instance = new GraphicsAdapter();
        }
        public void SaveAll()
        {
            ZedGraphControl zcontrol = (ZedGraphControl)graphicsGrid;
            zcontrol.SaveAsBitmap();
        }
        public void Fill(object data)
        {
            if (data is List<GraphItem>)
                DrawCurveList((List<GraphItem>)data);
            else if (data is GraphItem)
                DrawSingleCurve((GraphItem)data);
        }
        public void SetComponent(object component)
        {
            if (component is ZedGraphControl)
                graphicsGrid = component;
        }
        private void DrawCurveList(List<GraphItem> items)
        {
            if (items != null && graphicsGrid != null && items.Count > 0)
            {
                ZedGraphControl zcontrol = (ZedGraphControl)graphicsGrid;
                zcontrol.GraphPane.CurveList.Clear();
                foreach (var gItem in items)
                    DrawSingleCurve(gItem);
            }
            else if (items == null || items.Count == 0)
            {
                ClearGraphPane();
            }
            else throw new ArgumentException("Не поддерживаемый формат данных графического адаптера!");
        }
        private void DrawSingleCurve(GraphItem item)
        {
            if (graphicsGrid != null)
            {
                ZedGraphControl zcontrol = (ZedGraphControl)graphicsGrid;
                zcontrol.GraphPane.AddCurve(item.Name, item.points, item.gColor, item.sType);
                zcontrol.GraphPane.AxisChange();
                zcontrol.Invalidate();
            }

        }
        public void ResetTitles(OutputType outs)
        {
            if (graphicsGrid != null)
            {
                ZedGraphControl zcontrol = (ZedGraphControl)graphicsGrid;
                string finalY;
                string title;
                switch (outs)
                {
                    case OutputType.MR:
                        finalY = "мл/мин/100г ткани";
                        title = "График MR";
                        break;
                    case OutputType.pO2:
                        finalY = "мм.рт.ст.";
                        title = "График pO2";
                        break;
                    default:
                        finalY = "";
                        title = "График CY";
                        break;
                }
                zcontrol.GraphPane.Title.Text = title;
                zcontrol.GraphPane.XAxis.Title.Text = "Cетка";
                zcontrol.GraphPane.YAxis.Title.Text = finalY;
                zcontrol.Invalidate();
            }
        }
        public void ClearGraphPane()
        {
            ZedGraphControl zcontrol = (ZedGraphControl)graphicsGrid;
            zcontrol.GraphPane.CurveList.Clear();
            zcontrol.AxisChange();
            zcontrol.Invalidate();
        }

        public Bitmap DrawToBitmap()
        {
            ZedGraphControl zcontrol = (ZedGraphControl)graphicsGrid;
            return new Bitmap(zcontrol.GraphPane.GetImage());
        }
    }
}
