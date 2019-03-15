using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineClasses.CoreClasses
{
    public class BaseModelParameters
    {
        public readonly double c9;
        public readonly double km;
        public readonly double dd;
        public readonly double k2;
        public readonly double ll;
        public readonly double mrr;
        public readonly double ke;

        public readonly int Size;
        public readonly int Layers;
        public readonly int ICount;

        public double VO2c { get; set; }
        public double Cv { get; set; }
        public double pO2a { get; set; }
        public double pO2v { get; set; }
        public double pO2t { get; set; }
        public double pO2min { get; set; }
        public double avd { get; set; }
        public double cy { get; set; }
        public double v1 { get; set; }

        public BaseModelParameters(double _c9, double _km, double _dd, double _k2, double _ll, double _mrr, double _ke, //Входные данные
            int _size, int _layers, int _iterations)
        {
            c9 = _c9;
            km = _km;
            dd = _dd;
            k2 = _k2;
            ll = _ll;
            mrr = _mrr;
            ke = _ke;
            Size = _size;
            Layers = _layers;
            ICount = _iterations;
        }
        public BaseModelParameters()
        {
        }
        public override string ToString()
        {
            return string.Format("[c9 = {0}, km = {1}, dd = {2}, k2 = {3}, ll = {4}, mrr = {5}, ke = {6}]" +
                "\n[Size = {7} Layers = {8} Iterations = {9}]" +
                "\n[VO2c = {10:0.000}, Cv = {11:0.000}, pO2a = {12:0.000}, pO2v = {13:0.000}, pO2t = {14:0.000}. pO2min = {15:0.000}, avd ={16:0.000}, cy = {17:0.000}]", 
                c9, km, dd, k2, ll, mrr, ke, 
                Size, Layers, ICount,
                VO2c, Cv, pO2a, pO2v, pO2t, pO2min, avd, cy);
        }
    }

   
    public class ModelElement : BaseModelParameters, ICloneable
    {
        public static readonly double pH = 7.3;
        public static readonly double alfa = 2.8e-5;
        public static readonly double alfac = 1.25e-9;
        public static readonly double kk = 5.5e-9;
        public static readonly double mn = 0.001;
        public static readonly double dno = 3e-5;
        public static readonly double d = 1.3e-5;
        public static readonly double r0 = 0.0002;

        //Выходные данные
        
        //Массивы
        public double[, ,] a_qO2 { get; set; }
        public double[, ,] u_h { get; set; }
        public double[, ,] no { get; set; }

        //Конструкторы
        public ModelElement(double _c9, double _km, double _dd, double _k2, double _ll, double _mrr, double _ke, //Входные данные
            int _size, int _layers, int _iterations) : base(_c9, _km, _dd, _k2, _ll, _mrr, _ke, _size, _layers, _iterations)
        {
            u_h = new double[Size + 1, Size + 1, Layers + 1];
            no = new double[Size + 1, Size + 1, Layers + 1];
            a_qO2 = new double[Size + 1, Size + 1, Layers + 1];
        }
        public ModelElement(double _c9, double _km, double _dd, double _k2, double _ll, double _mrr, double _ke) 
            : this(_c9, _km, _dd, _k2, _ll, _mrr, _ke, 0, 0, 0)
        {
        }
        public void CopyOutputs(ModelElement element)
        {
            double[, ,] tUH = new double[Size + 1, Size + 1, Layers + 1];
            double[, ,] tNO = new double[Size + 1, Size + 1, Layers + 1];
            double[, ,] tqO2 = new double[Size + 1, Size + 1, Layers + 1];
            Array.Copy(element.u_h, tUH, element.u_h.Length);
            Array.Copy(element.no, tNO, element.u_h.Length);
            Array.Copy(element.a_qO2, tqO2, element.u_h.Length);
            this.u_h = tUH;
            this.no = tNO;
            this.a_qO2 = tqO2;
            this.avd = element.avd;
            this.VO2c = element.VO2c;
            this.avd = ((this.mrr / element.mrr) * element.VO2c) / element.k2;;
            this.v1 = element.v1; 
        }
        public ModelElement()
        {
        }
        public object Clone()
        {
            ModelElement element = (ModelElement)this.MemberwiseClone();
            double[, ,] tUH = new double[Size + 1, Size + 1, Layers + 1];
            double[, ,] tNO = new double[Size + 1, Size + 1, Layers + 1];
            double[, ,] tqO2 = new double[Size + 1, Size + 1, Layers + 1];
            Array.Copy(u_h, tUH, u_h.Length);
            Array.Copy(no, tNO, u_h.Length);
            Array.Copy(a_qO2, tqO2, u_h.Length);
            element.u_h = tUH;
            element.no = tNO;
            element.a_qO2 = tqO2;
            return element;
        }
    }
}
