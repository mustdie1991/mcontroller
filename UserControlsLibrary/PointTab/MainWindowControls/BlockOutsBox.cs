using System.Windows.Forms;
using EngineClasses.CoreClasses;

namespace UserControlsLibrary.PointTab
{
    public partial class BlockOutsBox : UserControl
    {
        public string TitleText
        {
            get
            {
                return groupBox_Main.Text;
            }
            set
            {
                groupBox_Main.Text = value;
            }
        }

        public BlockOutsBox()
        {
            InitializeComponent();
        }
        public void SetData(ModelElement mElement)
        {
            label_avd.Text = mElement.avd.ToString("N3");
            label_pO2min.Text = mElement.cy.ToString("N3");
            label_pO2a.Text = mElement.pO2a.ToString("N3");
            label_pO2t.Text = mElement.pO2t.ToString("N3");
            label_pO2v.Text = mElement.pO2v.ToString("N3");
            label_VO2c.Text = mElement.VO2c.ToString("N3");
            label_pO2min.Text = mElement.pO2min.ToString("N3");
            label_cy.Text = mElement.cy.ToString("N3");
        }
        public void SetHeader(string name)
        {
            groupBox_Main.Text = name;
        }
    }
}
