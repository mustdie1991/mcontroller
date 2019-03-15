using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EngineClasses.OutputElementsClasses;

namespace EngineClasses.Interfaces
{
    public interface IAdvancedDataModel : IDataModel
    {
        void EnableItem(string name, OutputType outs);
        void DisableItem(string name, OutputType outs);
        object GetEnabledItems(OutputType outs);
        object GetTypedItems(OutputType outs);
    }
}
