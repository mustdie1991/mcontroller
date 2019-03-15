using System;
using System.Collections.Generic;
using EngineClasses.Interfaces;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.PointTab.Histograms
{
    public class HistogramsDataModel : IAdvancedDataModel
    {
        private List<HistogramData> hData;

        public HistogramsDataModel()
        {
            hData = new List<HistogramData>();
        }

        public void EnableItem(string name, OutputType outs)
        {
            try
            {
                hData.Find((x) => x.name == name && x.outType == outs).SetEnabled(true);
            }
            catch (NullReferenceException ex)
            {
            }
        }
        public void DisableItem(string name, OutputType outs)
        {
            try
            {
                hData.Find((x) => x.name == name && x.outType == outs).SetEnabled(false);
            }
            catch (NullReferenceException ex)
            {
            }
        }
        public object GetEnabledItems(OutputType outs)
        {
            return hData.FindAll((x) => x.outType == outs && x.Enabled == true);
        }
        public object GetTypedItems(OutputType outs)
        {
            return hData.FindAll((x) => x.outType == outs);
        }
        public void DeleteItem(string name)
        {
            hData.Remove(hData.Find((x) => x.name == name));
        }
        public void AddItem(object item)
        {
            hData.Add((HistogramData)item);
        }
        public void DeleteItem(int index)
        {
            hData.RemoveAt(index);
        }
        public void DeleteItem(object item)
        {
            hData.Remove((HistogramData)item);
        }
        public void ClearAllItems()
        {
            hData.Clear();
        }
        public object GetItem(int index)
        {
            return hData[index];
        }
        public object GetItem(string name)
        {
            return hData.Find(x => x.name == name);
        }
        public object GetTypedItem(string name, OutputType outs)
        {
            return hData.Find(x => x.name == name && x.outType == outs);
        }
    }
}
