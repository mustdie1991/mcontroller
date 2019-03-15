using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EngineClasses.CoreClasses.Tasks;
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
            dc = new MatrixDataController(this.dataGridView_Results, this.matrixConrtolMenu1);
        }
    }
}
