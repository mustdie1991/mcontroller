using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZedGraph;
using System.Drawing;

namespace EngineClasses.OutputElementsClasses
{
    public class GraphItem
    {
        public TaskType tType { get; private set; }
        public OutputType outType { get; private set; }
        public PointPairList points { get; private set; }
        public SymbolType sType { get; private set; }
        public Color gColor { get; private set; }
        public string Name { get; private set; }
        public bool enabled { get; private set; }
        public void SetEnabled(bool enabled)
        {
            this.enabled = enabled;
        }
        public GraphItem(TaskType _tType, OutputType _outs, Color _gColor, PointPairList _points, string _name = "NoName", bool _enabled = true, SymbolType st = SymbolType.Default)
        {
            tType = _tType;
            outType = _outs;
            points = _points;
            gColor = _gColor;
            Name = _name;
            enabled = _enabled;
            sType = st;
        }
    }
}
