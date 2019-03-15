using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserControlsLibrary.UserOutputsTab
{
    public class AccountDataController
    {
        private object mainControl;

        public AccountDataController(object controlled)
        {
            if (controlled is MainOutputsControl)
            {
                mainControl = controlled;
            }
        }
    }
}
