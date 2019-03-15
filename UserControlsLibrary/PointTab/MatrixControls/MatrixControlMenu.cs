using System;
using System.Windows.Forms;
using EngineClasses.CoreClasses.Tasks;
using EventClasses.UserEventArgs;
using EngineClasses.OutputElementsClasses;
using EngineClasses.CoreClasses;

namespace UserControlsLibrary.PointTab
{
    public partial class MatrixControlMenu : UserControl
    {
        /*Текущий блок*/
        private MElementsBlock elBlock;

        /*Событие построения матрицы*/
        public event EventHandler<UserEventArgs<MatrixData>> BuildMatix;
        public event EventHandler<UserEventArgs<BaseModelParameters>> SaveMatrix;

        /*Загрузка элементов формы*/
        public MatrixControlMenu()
        {
            InitializeComponent();
            comboBox_NBlock.Items.AddRange((string[])Enum.GetNames(typeof(TaskType)));
            comboBox_Type.Items.AddRange((string[])Enum.GetNames(typeof(OutputType)));
            comboBox_color.Items.AddRange((string[])Enum.GetNames(typeof(FillColourType)));
            LoadComponentItems();
        }
        public void LoadComponentItems()
        {
            if (elBlock != null)
            {
                numericUpDown_Layer.Minimum = 1;
                numericUpDown_Layer.Maximum = (decimal)elBlock[0].modelData.Layers - 1;
            }
        }
        public void SetBlock(MElementsBlock elBlock)
        {
            this.elBlock = elBlock;
            LoadComponentItems();
        }

        /*Обработчики событий GUI*/
        private void comboBox_SelIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Type.SelectedIndex != -1 && comboBox_Type.SelectedItem.ToString() == "CY")
                comboBox_color.Enabled = true;
            else
                comboBox_color.Enabled = false;
        }
        private void checkBox_diag_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_Layer.Enabled = !((CheckBox)sender).Checked;
            comboBox_color.Enabled = ((CheckBox)sender).Checked;
        }
        private void button_Build_Click(object sender, EventArgs e)
        {
            if (comboBox_NBlock.SelectedIndex != -1 && comboBox_Type.SelectedIndex != -1)
            {
                try
                {
                        BuildMatix(this, new UserEventArgs<MatrixData>(
                           Converters.ConvertToMatrixData(elBlock[comboBox_NBlock.SelectedIndex].modelData,
                           (TaskType)(Enum.GetValues(typeof(TaskType)).GetValue(comboBox_NBlock.SelectedIndex)),
                           (OutputType)(Enum.GetValues(typeof(OutputType)).GetValue(comboBox_Type.SelectedIndex)),
                           (checkBox_diag.Checked) ? 0 : (int)numericUpDown_Layer.Value,
                           (comboBox_color.SelectedIndex > -1) ? (FillColourType)(Enum.GetValues(typeof(FillColourType)).GetValue(comboBox_color.SelectedIndex)) : FillColourType.Отсутсвует
                           )));
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Обработчик события построения не подключен");
                }

            }
            else
                MessageBox.Show("Не все данные введены!");
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (elBlock != null)
            {
                SaveMatrix(this, new UserEventArgs<BaseModelParameters>((BaseModelParameters)elBlock[comboBox_NBlock.SelectedIndex].modelData));
            }
        }
    }
}
