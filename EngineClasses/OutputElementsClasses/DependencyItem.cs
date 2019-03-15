using System.Collections.Generic;
using System.Drawing;
using ZedGraph;

namespace EngineClasses.OutputElementsClasses
{
    public class DependencyItem
    {
        public TaskType tType { get; private set; }
        public RegulatingVariable rVariable { get; private set; }
        public DependencyOutputs outType { get; private set; }
        public List<DependencyItem> points;
        public SymbolType sType { get; private set; }
        public Color gColor { get; private set; }
        public string Name { get; private set; }
        public bool enabled { get; private set; }

        public void SetEnabled(bool enabled)
        {
            this.enabled = enabled;
        }
        public DependencyItem(TaskType _tType, DependencyOutputs _outs, RegulatingVariable _regVariable, Color _gColor, 
            List<DependencyItem> _points, string _name = "NoName", bool _enabled = true, SymbolType st = SymbolType.Default)
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
