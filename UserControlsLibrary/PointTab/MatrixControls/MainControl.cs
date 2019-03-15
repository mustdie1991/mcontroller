using System;
using System.Windows.Forms;
using EventClasses.UserEventArgs;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.PointTab.MatrixControls
{
    public partial class MainMatrixControl : UserControl
    {
        public MatrixDataController dc { get; private set; }
        public event EventHandler<UserEventArgs<LocalDataGraphicsElement>> SaveRequested;
        public MainMatrixControl()
        {
            InitializeComponent();
        }
        private void matrixConrtolMenu1_Load(object sender, EventArgs e)
        {
            dc = new MatrixDataController(dataGridView_Results, matrixConrtolMenu1);
        }
    }
}
