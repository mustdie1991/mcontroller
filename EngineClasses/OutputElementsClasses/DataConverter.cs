using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EngineClasses.CoreClasses;
using ZedGraph;
using System.Drawing;
using EngineClasses.CoreClasses.Tasks;

namespace EngineClasses.OutputElementsClasses
{
    public static class Converters
    {
        //Пользовательская getKin для расчетов внутри класса
        private static double getKinetics(double uh, double km)
        {
            return uh / (uh + km);
        }
        //3D matrix conversion(гистограммы)
        private static HistogramSteps ConvertToHistogramSteps(double[, ,] matrix, int dencity)
        {
            double[] xVal = new double[dencity];
            double[] yVal = new double[dencity];
            string[] interval = new string[dencity];
            double Lower_bound = (matrix.Cast<double>().Max() / dencity);
            double Current_bound = 0;
            var query = matrix.Cast<double>().Select(p => p).Where(p => p > 0).ToArray();
            for (int i = 0; i < dencity; i++)
            {
                xVal[i] = i + 1;
                yVal[i] = matrix.Cast<double>().Select(p => p).Where(p => p > Current_bound && p <= Current_bound + Lower_bound).Count();
                interval[i] = string.Format("{0:0.000} - {1:0.000}", Current_bound, Current_bound + Lower_bound);
                Current_bound += Lower_bound;
            }
            return new HistogramSteps(xVal, yVal, interval);
        }
        public static List<HDataGridDataItem> ConvertToHDataGridItems(HistogramData hData)
        {
            List<HDataGridDataItem> outputData = new List<HDataGridDataItem>();
            for (int i = 0; i < hData.steps.funcValue.Length; i++)
            {
                string name = hData.steps.interval[i];
                double x = (int)hData.steps.funcValue[i];
                double percent = x / (hData.steps.funcValue.Sum());
                outputData.Add(new HDataGridDataItem(name, (int)x, percent));
            }
            return outputData;
        }
        private static double[, ,] ConvertToCY3D(ModelElement mElement)
        {
            double[, ,] matrix = new double[mElement.Size, mElement.Size, mElement.Layers];
            for (int i = 0; i < mElement.Size; i++)
                for (int j = 0; j < mElement.Size; j++)
                    for (int k = 0; k < mElement.Layers; k++)
                        matrix[i, j, k] = getKinetics(mElement.u_h[i + 1, j + 1, k + 1], mElement.km);
            return matrix;
        }
        private static double[, ,] ConvertToMR3D(ModelElement mElement)
        {
            double[, ,] matrix = new double[mElement.Size, mElement.Size, mElement.Layers];
            for (int i = 0; i < mElement.Size; i++)
                for (int j = 0; j < mElement.Size; j++)
                    for (int k = 0; k < mElement.Layers; k++)
                        matrix[i, j, k] = mElement.mrr * getKinetics(mElement.u_h[i + 1, j + 1, k + 1], mElement.km);
            return matrix;
        }
        private static double[, ,] ConvertToPO23D(ModelElement mElement)
        {
            double[, ,] matrix = new double[mElement.Size, mElement.Size, mElement.Layers];
            for (int i = 0; i < mElement.Size; i++)
                for (int j = 0; j < mElement.Size; j++)
                    for (int k = 0; k < mElement.Layers; k++)
                        matrix[i, j, k] = mElement.u_h[i + 1, j + 1, k + 1] * 100;
            return matrix;
        }
        //2D matrix conversion(матрицы)
        private static double[,] ConvertToCY2D(ModelElement mElement, int Layer = 0)
        {
            int x = (Layer == 0) ? mElement.Layers : mElement.Size;
            double[,] matrix = new double[mElement.Size, x];
            for (int i = 0; i < mElement.Size; i++)
                for (int j = 0; j < x; j++)
                {
                    if(Layer > 0)
                        matrix[i, j] = getKinetics(mElement.u_h[i + 1, j + 1, Layer], mElement.km);
                    else
                        matrix[i, j] = getKinetics(mElement.u_h[i + 1, i + 1, j + 1], mElement.km);
                }
            return matrix;
        }
        private static double[,] ConvertToMR2D(ModelElement mElement, int Layer = 0)
        {
            int x = (Layer == 0) ? mElement.Layers : mElement.Size;
            double[,] matrix = new double[mElement.Size, x];
            for (int i = 0; i < mElement.Size; i++)
                for (int j = 0; j < x; j++)
                {
                    if (Layer > 0)
                        matrix[i, j] = mElement.mrr * getKinetics(mElement.u_h[i + 1, j + 1, Layer], mElement.km);
                    else
                        matrix[i, j] = mElement.mrr * getKinetics(mElement.u_h[i + 1, i + 1, j + 1], mElement.km);
                }
            return matrix;
        }
        private static double[,] ConvertToPO22D(ModelElement mElement, int Layer = 0)
        {
            int x = (Layer == 0) ? mElement.Layers : mElement.Size;
            double[,] matrix = new double[mElement.Size, (Layer == 0) ? mElement.Layers : mElement.Size];
            for (int i = 0; i < mElement.Size; i++)
                for (int j = 0; j < x; j++)
                {
                    if (Layer > 0)
                        matrix[i, j] = mElement.u_h[i + 1, j + 1, Layer] * 100;
                    else
                        matrix[i, j] = mElement.u_h[i + 1, i + 1, j + 1] * 100;
                }
            return matrix;
        }
        //PointPairs conversion (для графики)
        private static PointPairList ConvertToCYPPList(ModelElement mElement, int Layer)
        {
            double[] matrixValues = new double[mElement.Size - 1];
            double[] matrixScale = new double[mElement.Size - 1];
            for (int i = 0; i < mElement.Size - 1; i++)
            {
                matrixValues[i] = getKinetics(mElement.u_h[i + 1, i + 1, Layer], mElement.km);
                matrixScale[i] = i + 1;
            }
            return new PointPairList(matrixScale, matrixValues);
        }
        private static PointPairList ConvertToPO2PPList(ModelElement mElement, int Layer)
        {
            double[] matrixValues = new double[mElement.Size - 1];
            double[] matrixScale = new double[mElement.Size - 1];
            for (int i = 0; i < mElement.Size - 1; i++)
            {
                matrixValues[i] = mElement.u_h[i + 1, i + 1, Layer] * 100;
                matrixScale[i] = i + 1;
            }
            return new PointPairList(matrixScale, matrixValues);
        }
        private static PointPairList ConvertToMRPPList(ModelElement mElement, int Layer)
        {
            double[] matrixValues = new double[mElement.Size - 1];
            double[] matrixScale = new double[mElement.Size - 1];
            for (int i = 0; i < mElement.Size - 1; i++)
            {
                matrixValues[i] = getKinetics(mElement.u_h[i + 1, i + 1, Layer], mElement.km) * mElement.mrr;
                matrixScale[i] = i + 1;
            }
            return new PointPairList(matrixScale, matrixValues);
        }
        //Converter to ModelData
        public static HistogramData ConvertToHistogramData(ModelElement mElement, int dencity, OutputType outs, TaskType tt, Color color, string name = "NoName")
        {
            double[, ,] matrix = new double[mElement.Size, mElement.Size, mElement.Layers];
            switch (outs)
            {
                case OutputType.CY:
                    matrix = Converters.ConvertToCY3D(mElement);
                    break;
                case OutputType.MR:
                    matrix = ConvertToMR3D(mElement);
                    break;
                case OutputType.pO2:
                    matrix = ConvertToPO23D(mElement);
                    break;
            }
            HistogramSteps steps = ConvertToHistogramSteps(matrix, dencity);

            return new HistogramData(tt, outs, steps, color, name, true);
        }
        public static MatrixData ConvertToMatrixData(ModelElement mElement, TaskType tt, OutputType outs, int Layer = 0, FillColourType fill = FillColourType.Отсутсвует)
        {

            double[,] matrix = new double[mElement.Size, mElement.Layers];
            switch (outs)
            {
                case OutputType.CY:
                    matrix = ConvertToCY2D(mElement, Layer);
                    break;
                case OutputType.MR:
                    matrix = ConvertToMR2D(mElement, Layer);
                    break;
                case OutputType.pO2:
                    matrix = ConvertToPO22D(mElement, Layer);
                    break;
            }
            return new MatrixData(tt, (Layer > 0) ?  mElement.Size - 1 : mElement.Layers - 1 , mElement.Size - 1, matrix, fill);

        }
        public static GraphItem ConvertToGraphItem(ModelElement mElement, TaskType tt, OutputType outs, int layer, Color color, string name = "NoName", SymbolType st = SymbolType.Default)
        {
            PointPairList ppr_list;
            switch (outs)
            {
                case OutputType.CY:
                    ppr_list = ConvertToCYPPList(mElement, layer);
                    break;
                case OutputType.MR:
                    ppr_list = ConvertToMRPPList(mElement, layer);
                    break;
                case OutputType.pO2:
                    ppr_list = ConvertToPO2PPList(mElement, layer);
                    break;
                default:
                    ppr_list = new PointPairList();
                    break;
            }
            return new GraphItem(tt, outs, color, ppr_list, name, true, st);
        }

        //public static DependencyItem ConvertToDependencyItem(List<ModelElement> mElements, TaskType tt, DependencyOutputs outs, Color color, string name = "NoName", SymbolType st = SymbolType.Default)
        //{
        //    List<DependencyPoint> points = new List<DependencyPoint>();
        //    foreach (ModelElement m in mElements)
        //    {
        //       // points.Add(new DependencyPoint(
        //    }
        //}
    }
}
