using System;
using EventClasses.UserEventArgs;
using EngineClasses.OutputElementsClasses;
using EngineClasses.CoreClasses.Tasks;
using EngineClasses.CoreClasses;
using System.Drawing;

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
            var bmp = MatrixAdapter.instance.DrawToBitmap(e.item);
            var type = BitmapType.Матрица;
            var nameDialog = new AskBlockNameDialog();
            nameDialog.bmpType = type;
            nameDialog.ShowDialog();
            if (nameDialog.OKExited && nameDialog.OutText != null)
            {
                var element = new LocalDataGraphicsElement(nameDialog.OutText, bmp, type);
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
