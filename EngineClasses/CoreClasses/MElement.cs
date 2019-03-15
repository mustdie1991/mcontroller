using System;

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
            return $"[c9 = {c9}, km = {km}, dd = {dd}, k2 = {k2}, ll = {ll}, mrr = {mrr}, ke = {ke}]" +
                   $"\n[Size = {Size} Layers = {Layers} Iterations = {ICount}]" +
                   $"\n[VO2c = {VO2c:0.000}, Cv = {Cv:0.000}, pO2a = {pO2a:0.000}, pO2v = {pO2v:0.000}, pO2t = {pO2t:0.000}. pO2min = {pO2min:0.000}, avd ={avd:0.000}, cy = {cy:0.000}]";
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
            var tUH = new double[Size + 1, Size + 1, Layers + 1];
            var tNO = new double[Size + 1, Size + 1, Layers + 1];
            var tqO2 = new double[Size + 1, Size + 1, Layers + 1];
            Array.Copy(element.u_h, tUH, element.u_h.Length);
            Array.Copy(element.no, tNO, element.u_h.Length);
            Array.Copy(element.a_qO2, tqO2, element.u_h.Length);
            u_h = tUH;
            no = tNO;
            a_qO2 = tqO2;
            avd = element.avd;
            VO2c = element.VO2c;
            avd = ((mrr / element.mrr) * element.VO2c) / element.k2;;
            v1 = element.v1; 
        }
        public ModelElement()
        {
        }
        public object Clone()
        {
            var element = (ModelElement)MemberwiseClone();
            var tUH = new double[Size + 1, Size + 1, Layers + 1];
            var tNO = new double[Size + 1, Size + 1, Layers + 1];
            var tqO2 = new double[Size + 1, Size + 1, Layers + 1];
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
