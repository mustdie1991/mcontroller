using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EngineClasses.Interfaces;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.PointTab.GraphicConrtols
{
    public class GraphsDataModel : IAdvancedDataModel
    {
        private List<GraphItem> gItems;

        public GraphsDataModel()
        {
            gItems = new List<GraphItem>();
        }
        public void DisableItem(string name, OutputType outs)
        {
            try
            {
                gItems.Find((x) => x.Name.Equals(name) && x.outType == outs).SetEnabled(false);
            }
            catch (NullReferenceException ex)
            {
            }
        }
        public void EnableItem(string name, OutputType outs)
        {
            try
            {
                gItems.Find((x) => x.Name.Equals(name) && x.outType == outs).SetEnabled(true);
            }
            catch (NullReferenceException ex)
            {
            }
        }
        public void DeleteItem(string name)
        {
            gItems.Remove(gItems.Find((x) => x.Name == name));
        }
        public void AddItem(object item)
        {
            gItems.Add((GraphItem)item);
        }
        public void DeleteItem(int index)
        {
            gItems.RemoveAt(index);
        }
        public void DeleteItem(object item)
        {
            gItems.Remove((GraphItem)item);
        }
        public void ClearAllItems()
        {
            gItems.Clear();
        }
        public object GetEnabledItems(OutputType outs)
        {
            return gItems.FindAll((x) => x.outType == outs && x.enabled == true);
        }
        public object GetTypedItems(OutputType outs)
        {
            return gItems.FindAll((x) => x.outType == outs);
        }

        public object GetItem(string name)
        {
            return gItems.Find(x => x.Name == name);
        }

        public object GetItem(int index)
        {
            return gItems[index];
        }

        public object GetTypedItem(string name, OutputType outs)
        {
            return gItems.Find(x => x.Name == name && x.outType == outs);
        }
    }
}
