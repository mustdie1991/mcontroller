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
