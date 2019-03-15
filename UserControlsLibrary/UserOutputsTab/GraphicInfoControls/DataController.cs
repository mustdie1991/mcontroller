using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EventClasses.UserEventArgs;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.UserOutputsTab.GraphicInfoControls
{
    public class GraphicsInfoDataController
    {
        private object ListController;
        private object ImageController;
        private BitmapType currentOutputType;

        public GraphicsInfoDataController(object listControl, object pictureControl)
        {
            if (listControl is GraphicsInfoControlMenu && pictureControl is PictureBox)
            {
                ListController = listControl;
                ImageController = pictureControl;
                ((GraphicsInfoControlMenu)listControl).itemSelectionChanged += ChangeItem;
                ((GraphicsInfoControlMenu)listControl).outputTypeChanged += ChangeOutputType;
            }
            else throw new ArgumentException("Не верные элементы управления выбраны!(Шаблон : GraphicsControlMenu, PictureBox");
        }

        private void ChangeItem(object sender, MessageEventArgs e)
        {
            ((PictureBox)ImageController).Image = LocalDataBase.GetElement(e.message, currentOutputType).Picture;
            ((PictureBox)ImageController).SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void ChangeOutputType(object sender, UserEventArgs<BitmapType> e)
        {
            ((PictureBox)ImageController).Image = null;
            currentOutputType = e.item;
            List<LocalDataGraphicsElement> elements = (List<LocalDataGraphicsElement>)LocalDataBase.GetTypedElements(currentOutputType);
            if (elements != null)
                ((GraphicsInfoControlMenu)ListController).SetListBoxItems(elements);
        }
    }
}
