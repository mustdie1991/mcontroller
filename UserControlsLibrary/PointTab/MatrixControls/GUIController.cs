using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserControlsLibrary;
using EventClasses.UserEventArgs;
using EngineClasses.OutputElementsClasses;
using EngineClasses.CoreClasses.Tasks;
using EngineClasses.CoreClasses;
using System.Drawing;
using EventClasses.UserEventArgs;

namespace UserControlsLibrary.PointTab.MatrixControls
{
    public class MatrixDataController
    {
        private object ControllerComponent;
        public event EventHandler<UserEventArgs<LocalDataGraphicsElement>> DataSaveRequested;

        public MatrixDataController(object Controlled, object Controller)
        {
            MatrixAdapter.instance.SetComponent(Controlled);
            ControllerComponent = Controller;
            ((MatrixControlMenu)ControllerComponent).BuildMatix += BuildMatrix;
            ((MatrixControlMenu)ControllerComponent).SaveMatrix += SaveResultsToBitmap;
        }
        public void BuildMatrix(object sender, UserEventArgs<MatrixData> e)
        {
            MatrixAdapter.instance.Fill(e.item);
        }
        public void SaveResultsToBitmap(object sender, UserEventArgs<BaseModelParameters> e)
        {
            Bitmap bmp = MatrixAdapter.instance.DrawToBitmap(e.item);
            BitmapType type = BitmapType.Матрица;
            AskBlockNameDialog nameDialog = new AskBlockNameDialog();
            nameDialog.bmpType = type;
            nameDialog.ShowDialog();
            if (nameDialog.OKExited && nameDialog.OutText != null)
            {
                LocalDataGraphicsElement element = new LocalDataGraphicsElement(nameDialog.OutText, bmp, type);
                LocalDataBase.AddData(element);
                System.Windows.Forms.MessageBox.Show("Данные успешно внесены!");
            }
        }
        public void SendDataToControlMenu(MElementsBlock element)
        {
            ((MatrixControlMenu)ControllerComponent).SetBlock(element);
        }
    }
}
