using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserControlsLibrary.PointTab;
using UserControlsLibrary.UserOutputsTab;
using EventClasses.UserEventArgs;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary
{
    public class MainDataController
    {
        private object AccountTab;
        private object SenderTab;

        public MainDataController(object accountTab, object sendingDataTab)
        {
            if (accountTab is AccountDataController && sendingDataTab is TabSingleElement)
            {
                AccountTab = accountTab;
                SenderTab = sendingDataTab;
                ((TabSingleElement)SenderTab).saveDataRequested += SaveDataToGraphicsTab;
            }
        }
        private void SaveDataToGraphicsTab(object sender, UserEventArgs<LocalDataGraphicsElement> e)
        {
        }
    }
}
