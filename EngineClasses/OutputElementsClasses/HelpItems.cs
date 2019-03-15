using System.Collections.Generic;
using System.Drawing;
using EngineClasses.CoreClasses;

namespace EngineClasses.OutputElementsClasses
{
    public enum OutputType : int
    {
        CY = 0,
        MR,
        pO2
    }
    public enum FillColourType : int
    {
        Градиент = 0,
        Дискретный,
        Отсутсвует
    }
    public enum TaskType : int
    {
        Блок1 = 0,
        Блок2,
        Блок3
    }
    public enum DependencyOutputs : int
    {
        AVD = 0,
        CY,
        pO2a,
        pO2v,
        pO2t,
        pO2min,
        VO2c
    }
    public enum RegulatingVariable : int
    {
        c9 = 0,
        k2,
        km,
        ke,
        mrr,
        dd,
        ll
    }
    public enum BitmapType : int
    {
        Матрица,
        График,
        Гистограмма,
        Зависимость
    }

    public struct HistogramSteps
    {
        public double[] funcValue;
        public double[] sizeNumber;
        public string[] interval;
        public HistogramSteps(double[] x, double[] y, string[] interval)
        {
            this.interval = interval;
            funcValue = y;
            sizeNumber = x;
        }
    }
    public struct HDataGridDataItem
    {
        public string interval;
        public int points;
        public double percent;
        public HDataGridDataItem(string interval, int points, double percent)
        {
            this.interval = interval;
            this.points = points;
            this.percent = percent;
        }
    }
    public struct DependencyPoint
    {
        public double PointValue;
        public double pO2min;
        public double pO2a;
        public double pO2v;
        public double pO2t;
        public double cy;
        public double avd;
        public DependencyPoint(double value, double pO2min, double pO2a, double pO2v, double pO2t, double cy, double avd)
        {
            PointValue = value;
            this.pO2min = pO2min;
            this.pO2a = pO2a;
            this.pO2v = pO2v;
            this.pO2t = pO2t;
            this.cy = cy;
            this.avd = avd;
        }
    }
    public struct LocalDataGraphicsElement
    {
        public string Name;
        public readonly Bitmap Picture;
        public readonly BitmapType eType;
        public LocalDataGraphicsElement(string name, Bitmap picture, BitmapType type)
        {
            Name = name;
            Picture = picture;
            eType = type;
        }
    }

    public struct MParametersList
    {
        public string Name;
        public List<BaseModelParameters> list;
        public bool Enabled;
        public void SetEnabled(bool enabledState)
        {
            Enabled = enabledState;
        }
        public MParametersList(string Name, List<BaseModelParameters> list, bool Enabled = true)
        {
            this.Name = Name;
            this.list = list;
            this.Enabled = Enabled;
        }
    }
}
