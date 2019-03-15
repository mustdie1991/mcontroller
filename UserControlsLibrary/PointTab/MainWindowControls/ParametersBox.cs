using System;
using System.Drawing;
using System.Windows.Forms;
using EventClasses.UserEventArgs;
using EngineClasses.Interfaces;

namespace UserControlsLibrary.PointTab.MainWindowControls
{
    public partial class ParametersBox : UserControl, IValidatable
    {
        public event EventHandler<InputsEventArgs> SendData;

        private bool validated;
        public bool TotalValidated { get { return validated; } }
        public string Title
        {
            get { return groupBox_Block1.Text; }
            set { groupBox_Block1.Text = value; }
        }
        public ParametersBox()
        {
            InitializeComponent();
            SetDefaults();
        }
        private void SetDefaults()
        {
            textBox_c9.Text = "0.19";
            textBox_k2.Text = "20";
            textBox_ke.Text = "0.2";
            textBox_km.Text = "0.01";
            textBox_ll.Text = "0.1";
            textBox_mrr.Text = "5";
            textBox_dd.Text = "0.006";
        }
        public void GetValues()
        {
            if (validated)
            {
                SendData(this, new InputsEventArgs(Convert.ToDouble(textBox_c9.Text),
                                                    Convert.ToDouble(textBox_km.Text),
                                                    Convert.ToDouble(textBox_k2.Text),
                                                    Convert.ToDouble(textBox_ll.Text),
                                                    Convert.ToDouble(textBox_mrr.Text),
                                                    Convert.ToDouble(textBox_ke.Text),
                                                    Convert.ToDouble(textBox_dd.Text)));
            }
        }
        private void ValidateTextBox(object sender)
        {
            double value;
            var isValid = (double.TryParse(((TextBox)sender).Text, out value) && value > 0);
            if (!isValid)
            {
                validated = false;
                ((TextBox)sender).BackColor = Color.FromArgb(251, 97, 74);
            }
            else
                ((TextBox)sender).BackColor = Color.FromArgb(140, 238, 138);
        }
        public void ValidateData()
        {
            validated = true;
            foreach (Control c in groupBox_Block1.Controls)
                if (c is TextBox)
                    ValidateTextBox(c);
        }
    }
}
