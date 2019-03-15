using System;
using System.Windows.Forms;
using EngineClasses.OutputElementsClasses;
using EngineClasses.CoreClasses.Tasks;
using EventClasses.UserEventArgs;

namespace UserControlsLibrary.PointTab.DependencyControls
{
    public partial class DependencyControlMenu : UserControl
    {
        private MElementsBlock block;
        public event EventHandler<UserEventArgs<GraphItem>> BuildGraph;
        public event EventHandler<TypeEventArgs> TypeChanged;

        public DependencyControlMenu()
        {
            InitializeComponent();
            comboBox_value.Items.AddRange((string[])Enum.GetNames(typeof(DependencyOutputs)));
            checkedListBox1.Items.AddRange((string[])Enum.GetNames(typeof(TaskType)));
        }
        public void SetBlock(MElementsBlock block)
        {
            if (block != null)
                this.block = block;
        }

        private void button_Build_Click(object sender, EventArgs e)
        {
            if (comboBox_value.SelectedIndex != -1 && block != null)
            {
                //BuildGraph(this, new UserEventArgs<DependencyGraphItem>(
            }     
        }
    }
}
