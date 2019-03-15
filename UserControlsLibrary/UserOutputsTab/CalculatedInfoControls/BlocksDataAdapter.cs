using System;
using System.Collections.Generic;
using EngineClasses.Interfaces;
using System.Windows.Forms;
using EngineClasses.CoreClasses;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.UserOutputsTab.CalculatedInfoControls
{
    public class BlocksDataAdapter : IAdapters
    {
        public static BlocksDataAdapter instance { get; private set; }
        private object ControlledObject;
        private static List<BaseModelParameters> localDataModel;
        static BlocksDataAdapter()
        {
            instance = new BlocksDataAdapter();
            localDataModel = new List<BaseModelParameters>();
        }
        private BlocksDataAdapter()
        {
        }
        private void FillSingleElement(MParametersList p)
        {
            var dgv = (DataGridView)ControlledObject;
            for (var i = 0; i < p.list.Count; i++)
            {
                dgv.Rows.Add();
                dgv[0, i].Value = p.Name;
                dgv[1, i].Value = 0;
                dgv[2, i].Value = p.list[i].c9;
                dgv[3, i].Value = p.list[i].c9;
                dgv[4, i].Value = p.list[i].c9;
                dgv[5, i].Value = p.list[i].c9;
                dgv[6, i].Value = p.list[i].c9;
                dgv[7, i].Value = p.list[i].c9;
                dgv[8, i].Value = p.list[i].c9;
                dgv[9, i].Value = p.list[i].c9;
                dgv[10, i].Value = p.list[i].c9;
                dgv[11, i].Value = p.list[i].c9;
                dgv[12, i].Value = p.list[i].c9;
                dgv[13, i].Value = p.list[i].c9;
                dgv[14, i].Value = p.list[i].c9;
                dgv[15, i].Value = p.list[i].c9;
            }
        }
        private void FillAllElements(List<MParametersList> list)
        {
            var dgv = (DataGridView)ControlledObject;
            dgv.Rows.Clear();
            foreach (var m in list)
            {
                FillSingleElement(m);
            }
        }
        public void Fill(object data)
        {
            if (data != null && data is List<MParametersList>)
            {
                var list = (List<MParametersList>)data;
                FillAllElements(list);
            }
            else throw new ArgumentException("На ввод подан не правильный формат данных!");
        }
        public void SetComponent(object component)
        {
            if (component is DataGridView)
            {
                ControlledObject = component;
                var dgv = (DataGridView)ControlledObject;
                //dgv.DataSource = localDataModel;
            }
        }
    }
}
