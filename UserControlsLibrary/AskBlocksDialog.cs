using System;
using System.Drawing;
using System.Windows.Forms;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary
{
    public partial class AskBlocksDialog : Form
    {
        public bool[] SavedBlocks { get; private set; }
        public string TextOut { get; private set; }
        public bool ExitedOnOK { get; private set; }

        public AskBlocksDialog()
        {
            InitializeComponent();
            checkedListBox1.Items.AddRange((string[])Enum.GetNames(typeof(TaskType)));
            SavedBlocks = new bool[3];
            for(var i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
                SavedBlocks[i] = true;
            }
            ExitedOnOK = false;
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            if (LocalDataBase.ContrainsBlockElement(textBox_name.Text))
            {
                textBox_name.BackColor = Color.FromArgb(251, 97, 74);
                button_OK.Enabled = false;
            }
            else
            {
                textBox_name.BackColor = Color.FromArgb(140, 238, 138);
                button_OK.Enabled = true;
            }
        }

        private void ItemCheckedChanged(object sender, ItemCheckEventArgs e)
        {
            SavedBlocks[e.Index] = (e.NewValue == CheckState.Checked) ? true : false;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            TextOut = textBox_name.Text;
            ExitedOnOK = true;
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
