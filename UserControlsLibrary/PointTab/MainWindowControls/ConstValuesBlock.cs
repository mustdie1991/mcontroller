using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EngineClasses.CoreClasses;

namespace UserControlsLibrary.PointTab
{
    public partial class ConstValuesBlock : UserControl
    {
        public ConstValuesBlock()
        {
            InitializeComponent();
            SetValues();
        }
        public void SetValues()
        {
            label_alfa.Text = ModelElement.alfa.ToString();
            label_alfac.Text = ModelElement.alfac.ToString();
            label_d.Text = ModelElement.d.ToString();
            label_dno.Text = ModelElement.dno.ToString();
            label_kk.Text = ModelElement.kk.ToString();
            label_mn.Text = ModelElement.mn.ToString();
            label_pH.Text = ModelElement.pH.ToString();
            label_r0.Text = ModelElement.r0.ToString();
        }
    }
}
