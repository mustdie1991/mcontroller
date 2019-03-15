using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EngineClasses.OutputElementsClasses
{
    public class HistogramData
    {
        public string name { get; private set; }
        public TaskType tType { get; private set; }
        public OutputType outType { get; private set; }
        public HistogramSteps steps;
        public Color color { get; private set; }
        public bool Enabled { get; set; }
        public void SetEnabled(bool enabled)
        {
            this.Enabled = enabled;
        }
        public HistogramData(TaskType tt, OutputType outs, HistogramSteps steps, Color col, string name = "NoName", bool _enabled = true)
        {
            this.steps = steps;
            this.name = name;
            color = col;
            tType = tt;
            Enabled = _enabled;
            this.outType = outs;
        }
    }
    
}
