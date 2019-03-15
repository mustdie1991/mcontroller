using System;
using EngineClasses.Interfaces;
using System.Drawing;
using System.Windows.Forms;
using EngineClasses.OutputElementsClasses;
using EngineClasses.CoreClasses;

namespace UserControlsLibrary.PointTab.MatrixControls
{
    public class MatrixAdapter : IAdapters
    {
        public static MatrixAdapter instance { get; private set; }
        private object CustomDataGrid;
        private MatrixData mData;
        protected MatrixAdapter()
        {
        }

        private DataGridView ConvertToGrid()
        {
            return (DataGridView)CustomDataGrid;
        }

        private static Color SelectColor(FillColourType mFill, double value)
        {
            switch (mFill)
            {
                case FillColourType.Дискретный:
                    if (value >= 0 && value < 0.2)
                        return Color.Green;
                    if (value >= 0.2 && value < 0.4)
                        return Color.LightYellow;
                    if (value >= 0.4 && value < 0.6)
                        return Color.Yellow;
                    if (value >= 0.6 && value < 0.8)
                        return Color.Orange;
                    else
                        return Color.Red;
                case FillColourType.Градиент:
                    return Color.FromArgb((value >= 0.5) ? 255 : (int)(255 * Math.Pow(2 * value, 0.5)), (value < 0.5) ? 255 : (int)(255 * Math.Pow((1 - value) * 2, 0.5)), 0);
                default:
                    return Color.White;
            }
        }

        private void Resize(int horizontalCells, int verticalCells)
        {
            if (CustomDataGrid != null)
            {
                ((DataGridView)CustomDataGrid).Rows.Clear();
                ((DataGridView)CustomDataGrid).Columns.Clear();
                var dataGrid = ConvertToGrid();
                dataGrid.RowCount = verticalCells;
                dataGrid.ColumnCount = horizontalCells;
                double tempSize = dataGrid.Height / verticalCells;
                var resizing = tempSize - (int)tempSize;
                double resizingCounter = 0;
                if (verticalCells > 40)
                    dataGrid.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                else
                {
                    foreach (DataGridViewRow dgw in dataGrid.Rows)
                    {
                        dgw.Height = dataGrid.Height / verticalCells;
                        resizingCounter += resizing;
                        if (resizingCounter > 1)
                        {
                            dgw.Height += (int)resizingCounter;
                            resizingCounter -= (int)resizingCounter;
                        }

                    }
                }
            }
        }
        public void Fill(object data)
        {
            if (data is MatrixData)
            {
                mData = (MatrixData)data;
                Resize(mData.horizontalCells, mData.verticalCells);
                var dataGrid = ConvertToGrid();
                for (var i = 0; i < mData.horizontalCells; i++)
                    for (var j = 0; j < mData.verticalCells; j++)
                    {
                        dataGrid[i, j].Value = mData.matrix[i, j].ToString("N4");
                        dataGrid[i, j].Style.BackColor = SelectColor(mData.mColor, mData.matrix[i, j]);
                    }
            }
        }
        public void SetComponent(object component)
        {
            if (component is DataGridView)
                CustomDataGrid = component;
        }
        public Bitmap DrawToBitmap(BaseModelParameters parametersToDraw)
        {
            var MyGrid = (DataGridView)CustomDataGrid;
            var bmp = new Bitmap(MyGrid.Width, MyGrid.Height + 50);
            var bmpDataGrid = new Bitmap(MyGrid.Width, MyGrid.Height);
            MyGrid.DrawToBitmap(bmpDataGrid, new Rectangle(0, 0, MyGrid.Width, MyGrid.Height));
            var g = Graphics.FromImage(bmp);
            g.DrawString(parametersToDraw.ToString(), new Font("Arial", 10), new SolidBrush(Color.Red), new PointF(0.0f, 0.0f));
            g.DrawImage(bmpDataGrid, 0.0f, 50.0f);
            return bmp;
        }
        static MatrixAdapter()
        {
            instance = new MatrixAdapter();
        }
    }
}
