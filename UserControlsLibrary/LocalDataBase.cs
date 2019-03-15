using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EngineClasses.OutputElementsClasses;
using EngineClasses.CoreClasses;

namespace UserControlsLibrary
{
    public static class LocalDataBase
    {
        static private List<LocalDataGraphicsElement> graphicElements;
        static private List<MParametersList> SavedModelBlocks;

        public static event EventHandler<EventArgs> OnUpdateBlocks;
        public static event EventHandler<EventArgs> OnUpdateGraphics;

        public static event EventHandler<EventArgs> OnDelete;
        public static void AddBlocks(object item)
        {
            SavedModelBlocks.Add((MParametersList)item);
            //OnUpdateBlocks(null, new EventArgs());
        }
        public static void EnableBlocks(bool enableState, string name)
        {
            SavedModelBlocks.Find(x => x.Name == name).SetEnabled(enableState);
        }
        public static List<MParametersList> GetEnabledBlocksList()
        {
            return SavedModelBlocks.FindAll(x => x.Enabled == true);
        }
        public static List<MParametersList> GetAllBlocksList()
        {
            return SavedModelBlocks;
        }
        public static MParametersList GetBlockItem(string name)
        {
            return SavedModelBlocks.Find(x => x.Name == name);
        }

        static public LocalDataGraphicsElement GetElement(string name, BitmapType type)
        {
            return graphicElements.Find(x => x.Name == name && x.eType == type);
        }
        static public object GetTypedElements(BitmapType type)
        {
            return graphicElements.FindAll(x => x.eType == type);
        }

        static public void AddData(object item)
        {
            if (item is LocalDataGraphicsElement)
            {
                graphicElements.Add((LocalDataGraphicsElement)item);
                //OnUpdateGraphics(null, new EventArgs());
            }
            else if (item is IEnumerable<LocalDataGraphicsElement>)
            {
                graphicElements.AddRange((List<LocalDataGraphicsElement>)item);
                //OnUpdateGraphics(null, new EventArgs());
            }
        }
        static public void DeleteItem()
        {
        }
        static LocalDataBase()
        {
            graphicElements = new List<LocalDataGraphicsElement>();
            SavedModelBlocks = new List<MParametersList>();
        }
        public static bool ContrainsElement(string name, BitmapType type)
        {
            if ((graphicElements.FindAll(x => x.Name == name && x.eType == type).Count > 0))
            {
                return true;
            }
            return false;
        }
        public static bool ContrainsBlockElement(string name)
        {
            if ((SavedModelBlocks.FindAll(x => x.Name == name).Count > 0))
            {
                return true;
            }
            return false;
        }
    }
}
