using System;
using System.Windows.Forms;
using EventClasses.UserEventArgs;
using EngineClasses.CoreClasses.Tasks;

namespace UserControlsLibrary.PointTab.MainWindowControls
{
    public partial class InputControl : UserControl
    {
        public TasksInputDataController dc { get; private set; }
        public event EventHandler<UserEventArgs<MElementsBlock>> SendDataRequest;

        public event EventHandler<EventArgs> SaveDataRequest;
        public InputControl()
        {
            InitializeComponent();
            dc = new TasksInputDataController(this);
        }
        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            if (dc.TryBuildElementsBlock() != null)
                SendDataRequest(this, new UserEventArgs<MElementsBlock>(dc.GetCurrentBlock()));
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveDataRequest(this, new EventArgs());
        }
    }
}
