using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EngineClasses.Interfaces;
using ZedGraph;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.PointTab.DependencyControls
{
    public class DependencyDataAdapter : IAdapters
    {
        public static readonly DependencyDataAdapter instance;
        private object component;
        static DependencyDataAdapter()
        {
            instance = new DependencyDataAdapter();
        }
        public void Fill(object data)
        {
            throw new NotImplementedException();
        }

        public void SetComponent(object component)
        {
            if (component is ZedGraphControl)
                this.component = component;
            else
                throw new ArgumentException("Не правильный адаптируемый объект!");
        }
        //private void DrawCurveList(List<GraphItem> items)
        //{
        //    if (items != null && graphicsGrid != null && items.Count > 0)
        //    {
        //        ZedGraphControl zcontrol = (ZedGraphControl)graphicsGrid;
        //        zcontrol.GraphPane.CurveList.Clear();
        //        foreach (GraphItem gItem in items)
        //            DrawSingleCurve(gItem);
        //    }
        //    else if (items == null || items.Count == 0)
        //    {
        //        ClearGraphPane();
        //    }
        //    else throw new ArgumentException("Не поддерживаемый формат данных графического адаптера!");
        //}
        //private void DrawSingleCurve(GraphItem item)
        //{
        //    if (graphicsGrid != null)
        //    {
        //        ZedGraphControl zcontrol = (ZedGraphControl)graphicsGrid;
        //        zcontrol.GraphPane.AddCurve(item.Name, item.points, item.gColor, item.sType);
        //        zcontrol.GraphPane.AxisChange();
        //        zcontrol.Invalidate();
        //    }

        //}
    }
}
