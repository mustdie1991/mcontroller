using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineClasses.OutputElementsClasses
{
    public class MatrixData
    {
        public TaskType tType { get; private set; }
        public int verticalCells { get; private set; }
        public int horizontalCells { get; private set; }
        public double[,] matrix { get; private set; }
        public FillColourType mColor { get; private set; }
        public MatrixData(TaskType _tType, int _verticalCells, int _horizontalCells, double[,] _matrix, FillColourType colType = FillColourType.Отсутсвует)
        {
            verticalCells = _verticalCells;
            horizontalCells = _horizontalCells;
            matrix = _matrix;
            mColor = colType;
            tType = _tType;
        }
    }
}
