using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EngineClasses.CoreClasses;

namespace EngineClasses.CoreClasses.Tasks
{
    sealed public class NonAdaptedTask : Tasking
    {
        double a_ha;
        protected override void Initials()
        {
            base.Initials();
            double grad = (Math.Pow(hm * (Size - 1), 2) * 2 * Math.Log(hm * (Size - 1) / ModelElement.r0) + Math.Pow(hm * (Size - 1), 2) + Math.Pow(ModelElement.r0, 2)) * modelData.mrr / (6000 * 4 * ModelElement.alfa * ModelElement.d);
            modelData.avd = modelData.mrr / modelData.k2;
            if (modelData.avd >= modelData.c9)
                modelData.avd = modelData.c9 - 0.00001;
            double c1k = modelData.c9;
            for (int n = 1; n <= Layers; n++)
            {
                a_ha = (-Math.Log(Math.Abs(1.00 - Math.Sqrt(c1k / modelData.ke)))) / ss;
                u_h[1, 1, n] = a_ha / 100;
                c1k -= modelData.avd / Layers;
                for (int m = 2; m <= Size; m++)
                {
                    u_h[1, m, n] = u_h[1, m - 1, n] - grad / (Size - 1) / 100;
                    for (int k = 2; k <= m; k++)
                    {
                        u_h[k, m, n] = u_h[k - 1, m, n] - (u_h[1, 1, n] - u_h[1, m, n]) / (m - 1) * 1.42;

                        if (u_h[k, m, n] < 0)
                            u_h[k, m, n] = 0.00001;
                        no[k, m, n] = u_h[k, m, n];
                    }
                }
            }

            av = modelData.mrr / modelData.k2;
            v1 = Math.Pow(hm, 2) * Math.Pow((Size - 1), 2) * hn * (Layers - 1) * modelData.mrr / 6000 / ((2 * Math.Pow(ModelElement.r0, 2)) * 2 * av);
            modelData.v1 = v1;
        }
        protected override double CountAVD()
        {
            return (mr_ha * hn * Math.Pow(hm, 2) * modelData.mrr / 6000) / (Math.Pow(ModelElement.r0, 2) * v1 * 2);
        }

        protected override double CountMRHA(double _k, int _x, int _y, int _z)
        {
            return _k * getKin(_x, _y, _z);
        }

        protected override void PartCalculate(int _x, int _y, int _z, double _kA1uh, double _kA3uh, double _kA1no, double _kA3no, double _Kmrha)
        {
            mr_ha += CountMRHA(_Kmrha, _x, _y, _z);
            u_h[_x, _y, _z] = _kA1uh * a1 + _kA3uh * a3 + modelData.mrr * 7.4e-9 * zr1 * getKin(_x, _y, _z);
            no[Size, Size, 1] = _kA1no * a1 + _kA3no * a3 + no[_x, _y, _z] * u_h[_x, _y, _z] * zr2;
            if (u_h[_x, _y, _z] <= 0)
                u_h[_x, _y, _z] = 0;
            if (no[_x, _y, _z] <= 0)
                no[_x, _y, _z] = 0;
        }


        protected override void SetArrays(ModelElement mElement)
        {
            if (mElement != null)
            {
                Size = mElement.Size;
                Layers = mElement.Layers;
                u_h = new double[Size + 1, Size + 1, Layers + 1];
                no = new double[Size + 1, Size + 1, Layers + 1];
                a_qO2 = new double[Size + 1, Size + 1, Layers + 1];
                for (int i = 0; i < Size + 1; i++)
                    for (int j = 0; j < Size + 1; j++)
                        for (int k = 0; k < Layers + 1; k++)
                        {
                            u_h[i, j, k] = 0;
                            no[i, j, k] = 0;
                            a_qO2[i, j, k] = 0;
                        }
            }
        }
        public NonAdaptedTask(ModelElement el)
        {
            modelData = (ModelElement)el;
        }
        public NonAdaptedTask()
        {
        }
    }
}
