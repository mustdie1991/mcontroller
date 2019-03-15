using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EngineClasses.OutputElementsClasses;

namespace EngineClasses.Interfaces
{
    public interface IDataModel
    {
        object GetItem(string name);
        object GetItem(int index);
        object GetTypedItem(string name, OutputType outs);
        void AddItem(object item);
        void DeleteItem(string name);
        void DeleteItem(int index);
        void DeleteItem(object item);
        void ClearAllItems();
    }
}
