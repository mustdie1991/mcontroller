using System;
using System.Collections.Generic;
using System.Linq;
using EngineClasses.OutputElementsClasses;
using EventClasses.UserEventArgs;
using EngineClasses.CoreClasses.Tasks;
using System.Drawing;

namespace UserControlsLibrary.PointTab.Histograms
{
    public class HistogramDataController
    {
        private object ControllerComponent;
        private object HistogramDisplayController;
        private object GridResultsDisplay;
        private HistogramsDataModel hDataModel;
        private OutputType outsType;

        public void SendDataToControlMenu(MElementsBlock element)
        {
            ((HistogramControlMenu)ControllerComponent).SetBlock(element);
        }
        public HistogramDataController(object ControlledGraph, object ControlledGrid, object Controller, object HistsController)
        {
            if (ControlledGraph is ZedGraphControl && ControlledGrid is HistogramDataGrid && Controller is HistogramControlMenu && HistsController is HistogramList)
            {
                HistogramAdapter.instance.SetComponent(ControlledGraph);
                ControllerComponent = Controller;
                HistogramDisplayController = HistsController;
                GridResultsDisplay = ControlledGrid;
                hDataModel = new HistogramsDataModel();

                //Event Handlers
                ((HistogramList)HistsController).HistogramEnabled += EnableHistogram;
                ((HistogramList)HistsController).HistogramDisabled += DisableHistogram;
                ((HistogramList)HistsController).AllHistsCleared += ClearAllHistograms;
                ((HistogramList)HistsController).SaveHists += SaveHistogram;
                ((HistogramControlMenu)Controller).BuildHistogram += BuildHistogram;
                ((HistogramControlMenu)Controller).TypeChanged += ChangeHistogramType;
                ((HistogramDataGrid)ControlledGrid).histogramChanged += ChangeHistogram;
            }
            else throw new ArgumentException("Не верные элементы управления для вывода гистограм");
        }
        private void DisableHistogram(object sender, MessageEventArgs e)
        {
            var hGrid = (HistogramDataGrid)GridResultsDisplay;
            hDataModel.DisableItem(e.message, outsType);
            var hItems = (List<HistogramData>)hDataModel.GetEnabledItems(outsType);
            hGrid.FillComboHists(hItems.Select(x => x.name).ToArray<string>());
            HistogramAdapter.instance.Fill(hItems);
        }
        private void EnableHistogram(object sender, MessageEventArgs e)
        {
            var hGrid = (HistogramDataGrid)GridResultsDisplay;
            hDataModel.EnableItem(e.message, outsType);
            var hItems = (List<HistogramData>)hDataModel.GetEnabledItems(outsType);
            hGrid.FillComboHists(hItems.Select(x => x.name).ToArray<string>());
            HistogramAdapter.instance.Fill(hItems);
        }
        private void DeleteHistogram(object sender, MessageEventArgs e)
        {
            hDataModel.DeleteItem(e.message);
        }
        private void ClearAllHistograms(object sender, EventArgs e)
        {
            hDataModel.ClearAllItems();
            var hGrid = (HistogramDataGrid)GridResultsDisplay;
            hGrid.ClearAllData();
            HistogramAdapter.instance.ClearAll();
        }
        private void ChangeHistogramType(object sender, TypeEventArgs e)
        {
            outsType = e.type;
            var hItems = (List<HistogramData>)hDataModel.GetTypedItems(outsType);
            var hl = (HistogramList)HistogramDisplayController;
            var hGrid = (HistogramDataGrid)GridResultsDisplay;
            var hToDraw = hItems.FindAll((x) => x.Enabled == true);
            hGrid.FillComboHists(hToDraw.Select(x => x.name).ToArray<string>());
            hl.ReloadHistlist(hItems);
            HistogramAdapter.instance.SetTitle(outsType);
            HistogramAdapter.instance.ClearAll();
            HistogramAdapter.instance.Fill(hToDraw);
        }
        private void BuildHistogram(object sender, UserEventArgs<HistogramData> e)
        {
            var hl = (HistogramList)HistogramDisplayController;
            if (hl.AddHistToList(e.item.name))
            {
                hDataModel.AddItem(e.item);
                var hGrid = (HistogramDataGrid)GridResultsDisplay;
                hGrid.AddSingleComboitem(e.item.name);
                HistogramAdapter.instance.Fill(e.item);
            }
        }
        private void ChangeHistogram(object sender, MessageEventArgs e)
        {
            var hGrid = (HistogramDataGrid)GridResultsDisplay;
            hGrid.FillDataGrid(Converters.ConvertToHDataGridItems((HistogramData)hDataModel.GetTypedItem(e.message, outsType)));
        }
        private void SaveHistogram(object sender, EventArgs e)
        {
            var bmp = HistogramAdapter.instance.DrawToBitmap();
            var type = BitmapType.Гистограмма;
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
    }
}
