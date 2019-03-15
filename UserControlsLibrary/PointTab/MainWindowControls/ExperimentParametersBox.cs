using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EventClasses.UserEventArgs;
using EngineClasses.Interfaces;

namespace UserControlsLibrary.PointTab.MainWindowControls
{
    public partial class ExperimentParametersBox : UserControl, IValidatable
    {
        public event EventHandler<ExpParsEventArgs> SendData;
        public string Title
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }
        private bool validated;
        public bool TotalValidated { get { return validated; } }
        private void ValidateTextBox(object sender)
        {
            int value;
            bool isValid = (int.TryParse(((TextBox)sender).Text, out value) && value > 0);
            if (!isValid)
            {
                validated = false;
                ((TextBox)sender).BackColor = Color.FromArgb(251, 97, 74);
            }
            else
                ((TextBox)sender).BackColor = Color.FromArgb(140, 238, 138);
        }
        public void GetValues()
        {
            if (validated)
            {
                SendData(this, new ExpParsEventArgs(Convert.ToInt32(textBox_scale.Text),
                                                    Convert.ToInt32(textBox_layers.Text),
                                                    Convert.ToInt32(textBox_iterations.Text)));
            }
        }
        public ExperimentParametersBox()
        {
            InitializeComponent();
            SetDefaults();
        }
        private void SetDefaults()
        {
            textBox_scale.Text = "10";
            textBox_layers.Text = "25";
            textBox_iterations.Text = "400";
        }
        public void ValidateData()
        {
            validated = true;
            foreach (Control c in groupBox1.Controls)
                if (c is TextBox)
                    ValidateTextBox(c);
        }
    }
}
