using System;
using System.Collections.Generic;
using EngineClasses.OutputElementsClasses;
using EngineClasses.Interfaces;
using EngineClasses.CoreClasses.Tasks;

namespace UserControlsLibrary.PointTab.DependencyControls
{
    public class DependencyDataModel : IAdvancedDataModel
    {
        private List<List<MElementsBlock>> blocksChainCollection;
        public DependencyDataModel()
        {
            //NullReferenceException.blocksChain = new List<MElementsBlock>();
        }
        public void EnableItem(string name, OutputType outs)
        {
            try
            {
            }
            catch (NullReferenceException ex)
            {
            }
        }

        public void DisableItem(string name, OutputType outs)
        {
            try
            {
            }
            catch (NullReferenceException ex)
            {
            }
        }

        public object GetEnabledItems(OutputType outs)
        {
            throw new NotImplementedException();
        }

        public object GetTypedItems(OutputType outs)
        {
            throw new NotImplementedException();
        }

        public object GetItem(string name)
        {
            throw new NotImplementedException();
        }

        public object GetItem(int index)
        {
            throw new NotImplementedException();
        }

        public object GetTypedItem(string name, OutputType outs)
        {
            throw new NotImplementedException();
        }

        public void AddItem(object item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(int index)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(object item)
        {
            throw new NotImplementedException();
        }

        public void ClearAllItems()
        {
            throw new NotImplementedException();
        }
    }
}
