using System.Windows.Forms;
using EventClasses.UserEventArgs;

namespace UserControlsLibrary.UserOutputsTab.CalculatedInfoControls
{
    public class CalculatedInfoDataController
    {
        
        private static object CustomMenu;
        private object CustomGrid;
        //static CalculatedInfoDataController()
        //{
        //    LocalDataBase.OnUpdateBlocks += OnDatabaseUpdate;
        //}

        public CalculatedInfoDataController(object controllerMenu, object controlledGrid)
        {
            if (controllerMenu is BlocksControlMenu && controlledGrid is DataGridView)
            {
                CustomMenu = controllerMenu;
                CustomGrid = controlledGrid;
                BlocksDataAdapter.instance.SetComponent(controlledGrid);
                ((BlocksControlMenu)CustomMenu).ListCheckedStateChanged += ListCheckedStateChanged;
            }
        }
        public void ListCheckedStateChanged(object sender, ListCheckedEventArgs e)
        {
            LocalDataBase.EnableBlocks(e.checkState, e.message);
            ((BlocksControlMenu)CustomMenu).ResetListData(LocalDataBase.GetAllBlocksList());
            BlocksDataAdapter.instance.Fill(LocalDataBase.GetEnabledBlocksList());
        }
    }
}
