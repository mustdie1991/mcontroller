using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EngineClasses.Interfaces;
using EngineClasses.CoreClasses;

namespace EngineClasses.CoreClasses.Tasks
{
    abstract public class Tasking : ICalculateAble
    {
        //входы
        private ModelElement ModelData;
        public ModelElement modelData
        { 
            get { return ModelData; } 
            set{ModelData = (ModelElement)value.Clone();} 
        }
        //временные параметры для решения задачи
        protected double mr_ha;
        protected double av;

        internal protected double a1;
        internal protected double a3;
        internal protected double zr1;
        internal protected double zr2;
        internal protected double hm;
        internal protected double hn;
        internal protected double kno;
        internal protected double ss;
        internal protected double v1;
        internal protected double c7;
        internal protected int Size;
        internal protected int Layers;
        internal protected int ICount;


        internal protected double[, ,] u_h;
        internal protected double[, ,] no;
        internal protected double[, ,] a_qO2;

        protected abstract double CountAVD();
        protected abstract double CountMRHA(double _k, int _x, int _y, int _z);
        protected abstract void PartCalculate(int _x, int _y, int _z, double _kA1uh, double _kA3uh, double _kA1no, double _kA3no, double _Kmrha);
        protected abstract void SetArrays(ModelElement mElement);
        protected virtual void CountGeneralValues()
        {
            modelData.pO2a = u_h[1, 1, 1] * 100;
            modelData.pO2v = u_h[1, 1, Layers] * 100;
            double sum = 0;
            int counter = 0;
            foreach (double d in u_h)
            {
                if (d > 0)
                {
                    sum += d;
                    counter++;
                }
            }
            modelData.pO2t = (sum/counter) *100;
            modelData.cy = modelData.avd / av;
            modelData.Cv = modelData.c9 - modelData.avd;
            modelData.VO2c = modelData.cy * modelData.mrr;
            modelData.pO2min = getKin(Size, Size, Layers);
        }
        public void CoreCalculation()
        {
            ICount = modelData.ICount;
            for (int a = 0; a < ICount; a++)
            {
                mr_ha = 0;
                PartCalculate(Size, Size, 1,
                              4 * u_h[Size - 1, Size, 1],
                              2 * u_h[Size, Size, 2],
                              4 * no[Size - 1, Size, 1],
                              2 * no[Size, Size, 2],
                              0.0625);
                PartCalculate(Size, Size, Layers,
                              4 * u_h[Size - 1, Size, Layers],
                              2 * u_h[Size, Size, Layers - 1],
                              4 * no[Size - 1, Size, Layers],
                              2 * no[Size, Size, Layers - 1],
                              0.0625);
                PartCalculate(1, Size, 1,
                              2 * (u_h[2, Size, 1] + u_h[1, Size - 1, 1]),
                              2 * u_h[1, Size, 2],
                              2 * (no[2, Size, 1] + no[1, Size - 1, 1]),
                              2 * no[1, Size, 2],
                              0.125);
                PartCalculate(1, Size, Layers,
                              2 * (u_h[2, Size, Layers] + u_h[1, Size - 1, Layers]),
                              2 * u_h[1, Size, Layers - 1],
                              2 * (no[2, Size, Layers] + no[1, Size - 1, Layers]),
                              2 * no[1, Size, Layers - 1],
                              0.125);
                for (int m = 2; m <= Size - 1; m++)
                {
                    PartCalculate(1, m, 1,
                                  2 * u_h[2, m, 1] + u_h[1, m + 1, 1] + u_h[1, m - 1, 1],
                                  2 * u_h[1, m, 2],
                                  2 * no[2, m, 1] + no[1, m + 1, 1] + no[1, m - 1, 1],
                                  2 * no[1, m, 2],
                                  0.25);
                    PartCalculate(1, m, Layers,
                                  2 * u_h[2, m, Layers] + u_h[1, m + 1, Layers] + u_h[1, m - 1, Layers],
                                  2 * u_h[1, m, Layers - 1],
                                  2 * no[2, m, Layers] + no[1, m + 1, Layers] + no[1, m - 1, Layers],
                                  2 * no[1, m, Layers - 1],
                                  0.25);
                }

                for (int n = 2; n <= Layers - 1; n++)
                    for (int m = 2; m <= Size - 1; m++)
                        PartCalculate(1, m, n,
                                      2 * u_h[2, m, n] + u_h[1, m + 1, n] + u_h[1, m - 1, n],
                                      u_h[1, m, n + 1] + u_h[1, m, n - 1],
                                      2 * no[2, m, n] + no[1, m + 1, n] + no[1, m - 1, n],
                                      no[1, m, n + 1] + no[1, m, n - 1],
                                      0.5);

                for (int k = 2; k <= Size - 1; k++)
                {
                    PartCalculate(k, Size, Layers,
                                  2 * u_h[k, Size - 1, Layers] + u_h[k + 1, Size, Layers] + u_h[k - 1, Size, Layers],
                                  2 * u_h[k, Size, Layers - 1],
                                  2 * no[k, Size - 1, Layers] + no[k + 1, Size, Layers] + no[k - 1, Size, Layers],
                                  2 * no[k, Size, Layers - 1],
                                  0.25);
                    PartCalculate(k, Size, 1,
                                  2 * u_h[k, Size - 1, 1] + u_h[k + 1, Size, 1] + u_h[k - 1, Size, 1],
                                  2 * u_h[k, Size, 2],
                                  2 * no[k, Size - 1, 1] + no[k + 1, Size, 1] + no[k - 1, Size, 1],
                                  2 * no[k, Size, 2],
                                  0.25);
                }
                u_h[Size, Size - 1, 1] = u_h[Size - 1, Size, 1];
                no[Size, Size - 1, 1] = no[Size - 1, Size, 1];
                u_h[Size, Size - 1, Layers] = u_h[Size - 1, Size, Layers];
                no[Size, Size - 1, Layers] = no[Size - 1, Size, Layers];
                for (int k = 2; k <= Size - 1; k++)
                {
                    u_h[k, k - 1, 1] = u_h[k - 1, k, 1];
                    no[k, k - 1, 1] = no[k - 1, k, 1];
                    u_h[k, k - 1, Layers] = u_h[k - 1, k, Layers];
                    no[k, k - 1, Layers] = no[k - 1, k, Layers];
                    PartCalculate(k, k, 1,
                                  u_h[k + 1, k, 1] + u_h[k - 1, k, 1] + u_h[k, k + 1, 1] + u_h[k, k - 1, 1],
                                  2 * u_h[k, k, 2],
                                  no[k + 1, k, 1] + no[k - 1, k, 1] + no[k, k + 1, 1] + no[k, k - 1, 1],
                                  2 * no[k, k, 2],
                                  0.25);
                    PartCalculate(k, k, Layers,
                                  u_h[k + 1, k, Layers] + u_h[k - 1, k, Layers] + u_h[k, k + 1, Layers] + u_h[k, k - 1, Layers],
                                  2 * u_h[k, k, Layers - 1],
                                  no[k + 1, k, Layers] + no[k - 1, k, Layers] + no[k, k + 1, Layers] + no[k, k - 1, Layers],
                                  2 * no[k, k, Layers - 1],
                                  0.25);
                }
                for (int n = 2; n <= Layers - 1; n++)
                {
                    u_h[Size, Size - 1, n] = u_h[Size - 1, Size, n];
                    for (int k = 2; k <= Size - 1; k++)
                    {
                        PartCalculate(k, Size, n,
                                      u_h[k + 1, Size, n] + u_h[k - 1, Size, n] + 2 * u_h[k, Size - 1, n],
                                      u_h[k, Size, n + 1] + u_h[k, Size, n - 1],
                                      no[k + 1, Size, n] + no[k - 1, Size, n] + 2 * no[k, Size - 1, n],
                                      no[k, Size, n + 1] + no[k, Size, n - 1],
                                      0.5);
                        u_h[k, k - 1, n] = u_h[k - 1, k, n];
                        no[k, k - 1, n] = no[k - 1, k, n];
                        PartCalculate(k, k, n,
                                      u_h[k + 1, k, n] + u_h[k - 1, k, n] + u_h[k, k + 1, n] + u_h[k, k - 1, n],
                                      u_h[k, k, n + 1] + u_h[k, k, n - 1],
                                      no[k + 1, k, n] + no[k - 1, k, n] + no[k, k + 1, n] + no[k, k - 1, n],
                                      no[k, k, n + 1] + no[k, k, n - 1],
                                      0.5);
                    }
                }
                for (int m = 3; m <= Size - 1; m++)
                    for (int k = 2; k <= m - 1; k++)
                    {
                        PartCalculate(k, m, 1,
                                      u_h[k + 1, m, 1] + u_h[k - 1, m, 1] + u_h[k, m + 1, 1] + u_h[k, m - 1, 1],
                                      2 * u_h[k, m, 2],
                                      no[k + 1, m, 1] + u_h[k - 1, m, 1] + no[k, m + 1, 1] + no[k, m - 1, 1],
                                      2 * no[k, m, 2],
                                      0.5);

                        PartCalculate(k, m, Layers,
                                      u_h[k + 1, m, Layers] + u_h[k - 1, m, Layers] + u_h[k, m + 1, Layers] + u_h[k, m - 1, Layers],
                                      2 * u_h[k, m, Layers - 1],
                                      no[k + 1, m, Layers] + no[k - 1, m, Layers] + no[k, m + 1, Layers] + no[k, m - 1, Layers],
                                      2 * no[k, m, Layers - 1],
                                      0.5);
                    }
                for (int n = 2; n <= Layers - 1; n++)
                {
                    PartCalculate(1, Size, n,
                                  2 * u_h[1, Size - 1, n] + 2 * u_h[2, Size, n],
                                  u_h[1, Size, n + 1] + u_h[1, Size, n - 1],
                                  2 * no[1, Size - 1, n] + 2 * no[2, Size, n],
                                  no[1, Size, n + 1] + no[1, Size, n - 1],
                                  0.25);

                    u_h[Size, Size - 1, n] = u_h[Size - 1, Size, n];
                    no[Size, Size - 1, n] = no[Size - 1, Size, n];
                    PartCalculate(Size, Size, n,
                                  4 * u_h[Size - 1, Size, n],
                                  u_h[Size, Size, n + 1] + u_h[Size, Size, n - 1],
                                  4 * no[Size - 1, Size, n],
                                  no[Size, Size, n + 1] + no[Size, Size, n - 1],
                                  0.125);
                }
                for (int n = 2; n <= Layers - 1; n++)
                    for (int m = 3; m <= Size - 1; m++)
                        for (int k = 2; k <= m - 1; k++)
                            PartCalculate(k, m, n,
                                          u_h[k + 1, m, n] + u_h[k - 1, m, n] + u_h[k, m + 1, n] + u_h[k, m - 1, n],
                                          u_h[k, m, n + 1] + u_h[k, m, n - 1],
                                          no[k + 1, m, n] + no[k - 1, m, n] + no[k, m + 1, n] + no[k, m - 1, n],
                                          no[k, m, n + 1] + no[k, m, n - 1],
                                          1);

                modelData.avd = CountAVD();
                double g1 = 0;
                for (int n = 1; n <= Layers; n++)
                    g1 += (u_h[1, 1, n] - u_h[2, 1, n]) * 100;
                double c1k = modelData.c9;
                for (int n = 1; n <= Layers; n++)
                {
                    double a_ha = (-Math.Log(Math.Abs(1 - Math.Sqrt(c1k / modelData.ke)))) / ss;
                    u_h[1, 1, n] = a_ha / 100;
                    no[1, 1, n] = 1;
                    c1k -= modelData.avd * (u_h[1, 1, n] - u_h[2, 1, n]) * 100 / g1;
                    if (c1k <= 0)
                        c1k = 0.0000001;
                    if (u_h[1, 1, n] <= 0)
                        u_h[1, 1, n] = 0.0001;
                }
            }
            c7 = 0;
            List<double> u_h_temp = new List<double>();
            for (int i = 1; i < Size; i++)
                for (int j = 1; j < Size; j++)
                    for (int k = 1; k < Layers; k++)
                        u_h_temp.Add(u_h[i, j, k]);
            u_h_temp.RemoveAll(x => x == 0);
            c7 = u_h_temp.Sum() / u_h_temp.Count;
        }
        protected virtual void Initials()
        {
            ss = 0.4492 * ModelElement.pH - 0.10098 * Math.Pow(ModelElement.pH, 2) + 0.0066815 * Math.Pow(ModelElement.pH, 3) - 0.454;
            hm = modelData.dd / (2 * (Size - 1));
            hn = modelData.ll / (Layers - 1);
            kno = (ModelElement.mn * 10e-9) / ModelElement.kk;
            double y = (Math.Pow(hn, 2) * 2 + Math.Pow(hm, 2)) * 2;
            a1 = Math.Pow(hn, 2) / y;
            a3 = Math.Pow(hm, 2) / y;
            zr1 = -1 / (ModelElement.alfac * ModelElement.d) * Math.Pow((hm * hn), 2) / y / 100;
            zr2 = -1 / ModelElement.dno * Math.Pow(hm * hn, 2) / y * 0.538 * (10e+8) * (ModelElement.mn * 10e-9) * ModelElement.alfac * 100;
        }
        public double getKin(int a, int b, int c)
        {
            return u_h[a, b, c] / (u_h[a, b, c] + modelData.km); //* (1 + no[a, b, c] + kno));
        }
        protected void FillModelArrays()
        {
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    for (int k = 0; k < Layers; k++)
                    {
                        modelData.u_h[i, j, k] = u_h[i, j, k];
                        modelData.no[i, j, k] = no[i, j, k];
                        modelData.a_qO2[i, j, k] = a_qO2[i, j, k];
                    }
        }
        public void Calculate()
        {
            if (modelData != null)
            {
                SetArrays(modelData);
                Initials();
                CoreCalculation();
                FillModelArrays();
                CountGeneralValues();
            }
        }
    }  
}
