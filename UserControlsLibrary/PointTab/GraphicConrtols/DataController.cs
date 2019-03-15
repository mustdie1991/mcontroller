using System;
using System.Collections.Generic;
using EngineClasses.OutputElementsClasses;
using EventClasses.UserEventArgs;
using EngineClasses.CoreClasses.Tasks;
using System.Drawing;
using ZedGraph;
using GraphItem = EngineClasses.OutputElementsClasses.GraphItem;

namespace UserControlsLibrary.PointTab.GraphicConrtols
{
    public class GraphicsDataController
    {
        private readonly object ControllerComponent;
        private readonly object CurveDisplayController;
        private readonly GraphsDataModel mDataModel;
        private OutputType outsType;

        public GraphicsDataController(object Controlled, object Controller, object CurveController)
        {
            if (Controlled is ZedGraphControl && Controller is GraphControlMenu && CurveController is GraphsList)
            {
                GraphicsAdapter.instance.SetComponent(Controlled);
                ControllerComponent = Controller;
                CurveDisplayController = CurveController;
                var gl = CurveDisplayController as GraphsList;
                var gMenu = ControllerComponent as GraphControlMenu;
                mDataModel = new GraphsDataModel();

                //Events on GraphList changes 
                gl.DisableCurve += DisableCurve;
                gl.EnableCurve += EnableCurve;
                gl.DeleteCurve += DeleteCurve;
                gl.ClearAllCurves += ClearAllCurves;
                gl.SaveAllCurves += SaveCurves;
                gMenu.TypeChanged += ChangeGraphType;
                gMenu.BuildGraph += BuildGraph;
            }
            else throw new ArgumentException("Не верные входные параметры!");
        }
        public void SendDataToControlMenu(MElementsBlock element)
        {
            ((GraphControlMenu)ControllerComponent).SetBlock(element);
        }

        #region Обработчики событий
        //Сохранение в рисунок
        private void SaveCurves(object sender, EventArgs e)
        {
            var bmp = GraphicsAdapter.instance.DrawToBitmap();
            var type = BitmapType.График;
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
        //Посроение графика
        private void BuildGraph(object sender, UserEventArgs<GraphItem> e)
        {
            var gl = (GraphsList)CurveDisplayController;
            if (gl.AddCurveToList(e.item.Name))
            {
                mDataModel.AddItem(e.item);
                GraphicsAdapter.instance.Fill(e.item);
            }
        }
        //Отмена прорисовки кривой
        private void DisableCurve(object sender, MessageEventArgs e)
        {
            mDataModel.DisableItem(e.message, outsType);
            var gItems = (List<GraphItem>)mDataModel.GetEnabledItems(outsType);
            GraphicsAdapter.instance.Fill(gItems);
        }
        //Применить кривую
        private void EnableCurve(object sender, MessageEventArgs e)
        {
            mDataModel.EnableItem(e.message, outsType);
            var gItems = (List<GraphItem>)mDataModel.GetEnabledItems(outsType);
            GraphicsAdapter.instance.Fill(gItems);
        }
        //Удалить кривую
        private void DeleteCurve(object sender, MessageEventArgs e)
        {
            mDataModel.DeleteItem(e.message);
        }
        //Удалить все кривые
        private void ClearAllCurves(object sender, EventArgs e)
        {
            mDataModel.ClearAllItems();
            GraphicsAdapter.instance.ClearGraphPane();
        }
        //Сменить тип отображаемых кривых
        private void ChangeGraphType(object sender, TypeEventArgs e)
        {
            outsType = e.type;
            var gItems = (List<GraphItem>)mDataModel.GetTypedItems(outsType);
            var gl = (GraphsList)CurveDisplayController;
            var gToDraw = gItems.FindAll((x) => x.enabled == true);
            GraphicsAdapter.instance.Fill(gItems);
            gl.ResetCurvelist(gItems);
            GraphicsAdapter.instance.ResetTitles(outsType);
            //GraphicsAdapter.instance.
        }
        #endregion
    }
}
