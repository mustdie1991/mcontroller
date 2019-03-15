using System;
using System.Collections.Generic;
using EngineClasses.Interfaces;
using System.Windows.Forms;
using EventClasses.UserEventArgs;
using EngineClasses.CoreClasses.Tasks;
using EngineClasses.CoreClasses;
using EngineClasses.OutputElementsClasses;

namespace UserControlsLibrary.PointTab.MainWindowControls
{
    public class TasksInputDataController
    {
        private static object controller;
        private MElementsBlock currentBlock;
        private int TemporarySize;
        private int TemporaryLayers;
        private int TemporaryIterations;
        public event EventHandler<UserEventArgs<MElementsBlock>> SendRequestedData;

        public TasksInputDataController(object component)
        {
            if (component is InputControl)
            {
                controller = component;
                var ic = (InputControl)controller;
                ic.SaveDataRequest += SaveDataRequest;
                foreach (Control c in ((InputControl)controller).Controls)
                {
                    if (c is ParametersBox)
                    {
                        var p = (ParametersBox)c;
                        p.SendData += GetInputsData;
                    }
                    else if (c is ExperimentParametersBox)
                        ((ExperimentParametersBox)c).SendData += GetExperimentParameters;
                }
            }
            else throw new ArgumentException("Не подходящий регулирующий элемент ввода!");
        }
        private void SaveDataRequest(object sender, EventArgs e)
        {
            if (currentBlock != null)
            {
                var blDialog = new AskBlocksDialog();
                blDialog.ShowDialog();
                var tempList = new List<BaseModelParameters>();
                if (blDialog.ExitedOnOK)
                {
                    for (var i = 0; i < 3; i++)
                        if (blDialog.SavedBlocks[i])
                            tempList.Add(currentBlock[i].modelData);
                    LocalDataBase.AddBlocks(new MParametersList(blDialog.TextOut, tempList));
                }
            }
            else MessageBox.Show("Не выполнено ни единого расчета!");
        }


        public object TryBuildElementsBlock()
        {
            var ValidationCounter = 0;
            foreach (Control c in ((InputControl)controller).Controls)
            {
                if (c is IValidatable)
                {
                    ((IValidatable)c).ValidateData();
                    if (((IValidatable)c).TotalValidated)
                        ValidationCounter++;
                }
            }
            if (ValidationCounter == 3)
            {
                currentBlock = new MElementsBlock();
                foreach (Control c in ((InputControl)controller).Controls)
                {
                    if (c is ExperimentParametersBox)
                    {
                        ((ExperimentParametersBox)c).GetValues();
                        break;
                    }
                }
                foreach (Control c in ((InputControl)controller).Controls)
                {
                    if (c is ParametersBox)
                    {
                        ((ParametersBox)c).GetValues();
                    }
                }
                currentBlock[0].Calculate();
                var element = currentBlock[0].modelData;
                currentBlock[1].modelData = element;
                currentBlock[1].Calculate();
                currentBlock[2].modelData.CopyOutputs(element);
                currentBlock[2].Calculate();
                SetOutputsData(currentBlock);
                //SendRequestedData(this, new UserEventArgs<MElementsBlock>(currentBlock));
                return currentBlock;
            }
            return null;
        }
        private void SetOutputsData(MElementsBlock blocks)
        {
            var ic = (InputControl)controller;
            foreach (Control c in ic.Controls)
            {
                if (c is BlockOutsBox)
                {
                    switch (((BlockOutsBox)c).Name)
                    {
                        case "blockOutsBox_block1" :
                            ((BlockOutsBox)c).SetData(blocks[0].modelData);
                            break;
                        case "blockOutsBox_block2":
                            ((BlockOutsBox)c).SetData(blocks[1].modelData);
                            break;
                        case "blockOutsBox_block3":
                            ((BlockOutsBox)c).SetData(blocks[2].modelData);
                            break;
                    }
                }
            }
        }
        private void GetInputsData(object sender, InputsEventArgs e)
        {
            var p = sender as ParametersBox;
            if (p != null)
            {
                var element = new ModelElement(e.c9, e.km, e.dd, e.k2, e.ll, e.mrr, e.ke, TemporarySize, TemporaryLayers, TemporaryIterations);
                switch (p.Name)
                {
                    case "parametersBox_block1" :
                        currentBlock[0] = new NonAdaptedTask(element);
                        currentBlock[1] = new AdaptingTask(element);
                        break;
                    case "parametersBox_block3" :
                        currentBlock[2] = new RegulatingTask(element);
                        break;
                }
            }
        }
        public MElementsBlock GetCurrentBlock()
        {
            return currentBlock;
        }
        private void GetExperimentParameters(object sender, ExpParsEventArgs e)
        {
            TemporaryIterations = e.iterations;
            TemporaryLayers = e.layers;
            TemporarySize = e.size;
        }
    }
}
