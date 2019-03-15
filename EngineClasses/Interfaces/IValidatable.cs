using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineClasses.Interfaces
{
    public interface IValidatable
    {
        bool TotalValidated { get; }
        void ValidateData();
    }
}
