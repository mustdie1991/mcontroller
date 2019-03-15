using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary
{
    public partial class AskBlockNameDialog : Form
    {
        public BitmapType bmpType { get; set; }
        public bool OKExited { get; private set; }
        private List<LocalDataGraphicsElement> checkList;

        public string OutText { get; private set; }

        public AskBlockNameDialog()
        {
            InitializeComponent();
        }
        private void AskNameDialog_Load(object sender, EventArgs e)
        {
            checkList = (List<LocalDataGraphicsElement>)LocalDataBase.GetTypedElements(bmpType);
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            if (LocalDataBase.ContrainsElement(textBox_name.Text, bmpType))
            {
                textBox_name.BackColor = Color.FromArgb(251, 97, 74);
                buttonOK.Enabled = false;
            }
            else
            {
                textBox_name.BackColor = Color.FromArgb(140, 238, 138);
                buttonOK.Enabled = true;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            OutText = textBox_name.Text;
            OKExited = true;
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            OKExited = false;
            Close();
        }
    }
}
