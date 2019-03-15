using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineClasses.CoreClasses.Tasks
{
    sealed public class RegulatingTask : Tasking
    {
        protected override void CountGeneralValues()
        {
            base.CountGeneralValues();
            double sum = 0;
            int counter = 0;
            foreach (double d in a_qO2)
            {
                if (d > 0)
                {
                    sum += d;
                    counter++;
                }
            }
            modelData.VO2c = modelData.cy * ((sum / 7.4e-9) / counter);
        }
        protected override void Initials()
        {
            base.Initials();
            av = modelData.avd;
            v1 = modelData.v1;
        }
        protected override double CountAVD()
        {
            return (mr_ha * hn * Math.Pow(hm, 2) / 6000) / (Math.Pow(ModelElement.r0, 2) * v1 * 2);
        }

        protected override double CountMRHA(double _k, int _x, int _y, int _z)
        {
            return _k * (a_qO2[_x, _y, _z] / 7.4e-9) * getKin(_x, _y, _z);
        }

        protected override void PartCalculate(int _x, int _y, int _z, double _kA1uh, double _kA3uh, double _kA1no, double _kA3no, double _Kmrha)
        {
            mr_ha += CountMRHA(_Kmrha, _x, _y, _z);
            u_h[_x, _y, _z] = _kA1uh * a1 + _kA3uh * a3 + a_qO2[_x, _y, _z] * zr1 * getKin(_x, _y, _z);
            no[Size, Size, 1] = _kA1no * a1 + _kA3no * a3 + no[_x, _y, _z] * u_h[_x, _y, _z] * zr2;
        }

        protected override void SetArrays(ModelElement mElement)
        {
            if (mElement != null)
            {
                Size = mElement.Size;
                Layers = mElement.Layers;
                u_h = new double[mElement.Size + 1, mElement.Size + 1, mElement.Layers + 1];
                no = new double[mElement.Size + 1, mElement.Size + 1, mElement.Layers + 1];
                a_qO2 = new double[mElement.Size + 1, mElement.Size + 1, mElement.Layers + 1];
                for (int i = 0; i < mElement.Size + 1; i++)
                    for (int j = 0; j < mElement.Size + 1; j++)
                        for (int k = 0; k < mElement.Layers + 1; k++)
                        {
                            u_h[i, j, k] = mElement.u_h[i, j, k];
                            no[i, j, k] = mElement.no[i, j, k];
                            a_qO2[i, j, k] = mElement.mrr * 7.4e-9 * getKin(i, j, k);
                        }
            }
        }
        public RegulatingTask(ModelElement mElement)
        {
            modelData = (ModelElement)mElement.Clone();
        }
        public RegulatingTask()
        {
        }
    }
}
