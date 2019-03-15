//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using System.Collections;
//using ZedGraph;

//namespace MuscleController
//{
//    public partial class Variation_wnd : Form
//    {
//        struct OutputsForGraph
//        {
//            public double depVal;
//            public double pO2t;
//            public double pO2v;
//            public double pO2a;
//            public double pO2min;
//            public double avd;
//            public double cy;
//            public double VO2;
//        }
//        private List<OutputsForGraph> depOutsBlock1 = new List<OutputsForGraph>();
//        private List<OutputsForGraph> depOutsBlock2 = new List<OutputsForGraph>();
//        private List<OutputsForGraph> depOutsBlock31 = new List<OutputsForGraph>();
//        private List<OutputsForGraph> depOutsBlock32 = new List<OutputsForGraph>();
//        private Params par_initial = new Params();
//        private Params par_block3 = new Params();

//        private int CurrentTask;
//        private int TaskNum;
//        private int Progress;

//        private short bSize;
//        private short Layers;
//        private short Iterations;

//        private double fromRegVal;
//        private double toRegVal;
//        private int stepCount;
//        private double[] steps;

//        private List<Params> parametersArray = new List<Params>();
//        private List<Params> parametersArrayB3 = new List<Params>();
  

//        public Variation_wnd()
//        {
//            InitializeComponent();
//        }
//        private void SetDefaults()
//        {
//            textBox_c9.Text = "0,19";
//            textBox_k2.Text = "20";
//            textBox_ke.Text = "0,2";
//            textBox_km.Text = "0,01";
//            textBox_ll.Text = "0,1";
//            textBox_mrr.Text = "5";
//            textBox_dd.Text = "0,006";

//            textBox_c9_b3.Text = "0,19";
//            textBox_k2_b3.Text = "20";
//            textBox_ke_b3.Text = "0,2";
//            textBox_km_b3.Text = "0,01";
//            textBox_ll_b3.Text = "0,1";
//            textBox_mrr_b3.Text = "5";
//            textBox_dd_b3.Text = "0,006";

//            label_alfa.Text = Params.alfa.ToString();
//            label_alfac.Text = Params.alfac.ToString();
//            label_d.Text = Params.d.ToString();
//            label_dno.Text = Params.dno.ToString();
//            label_kk.Text = Params.kk.ToString();
//            label_mn.Text = Params.mn.ToString();
//            label_pH.Text = Params.pH.ToString();
//            label_r0.Text = Params.r0.ToString();

//            textBox_L.Text = "10";
//            textBox_Layers.Text = "25";
//            textBox_ICount.Text = "400";
//        }
//        private bool testInput()
//        {
//            try
//            {
//                string checkString = comboBox_regVal.SelectedItem.ToString();

//                fromRegVal = Convert.ToDouble(textBox_from.Text);
//                toRegVal = Convert.ToDouble(textBox_to.Text);
//                stepCount = Convert.ToInt16(numericUpDown1.Value);

//                par_initial.c9 = checkString.Equals("c9") ? fromRegVal : Convert.ToDouble(textBox_c9.Text);
//                par_initial.dd = checkString.Equals("dd") ? fromRegVal : Convert.ToDouble(textBox_dd.Text);
//                par_initial.k2 = checkString.Equals("k2") ? fromRegVal : Convert.ToDouble(textBox_k2.Text);
//                par_initial.ke = checkString.Equals("ke") ? fromRegVal : Convert.ToDouble(textBox_ke.Text);
//                par_initial.km = checkString.Equals("km") ? fromRegVal : Convert.ToDouble(textBox_km.Text);
//                par_initial.ll = checkString.Equals("ll") ? fromRegVal : Convert.ToDouble(textBox_ll.Text);
//                par_initial.mrr = checkString.Equals("mrr") ? fromRegVal : Convert.ToDouble(textBox_mrr.Text);
//                if (checkBox_b3.Checked)
//                {
//                    par_block3.c9 = Convert.ToDouble(textBox_c9_b3.Text);
//                    par_block3.dd = Convert.ToDouble(textBox_dd_b3.Text);
//                    par_block3.k2 = Convert.ToDouble(textBox_k2_b3.Text);
//                    par_block3.ke = Convert.ToDouble(textBox_ke_b3.Text);
//                    par_block3.km = Convert.ToDouble(textBox_km_b3.Text);
//                    par_block3.ll = Convert.ToDouble(textBox_ll_b3.Text);
//                    par_block3.mrr = Convert.ToDouble(textBox_mrr_b3.Text);
//                }
//                bSize = Convert.ToInt16(textBox_L.Text);
//                Layers = Convert.ToInt16(textBox_Layers.Text);
//                Iterations = Convert.ToInt16(textBox_ICount.Text);
//                label_error.Text = "";
//                return true;
//            }
//            catch (Exception ex)
//            {
//                label_error.Text = ex.Message;
//            }
//            return false;
//        }
//        private void button1_Click(object sender, EventArgs e)
//        {
//            if (testInput())
//            {
//                depOutsBlock1.Clear();
//                depOutsBlock2.Clear();
//                depOutsBlock31.Clear();
//                depOutsBlock32.Clear();

//                TaskNum = (2 + ((checkBox_b3.Checked) ? 1 : 0)) * stepCount;
//                CurrentTask = 0;
//                CountSteps();
//                CountDependent();
//            }
//        }

//        private void checkBox_b3_CheckedChanged(object sender, EventArgs e)
//        {
//            groupBox1.Enabled = !groupBox1.Enabled;
//        }

//        private void OnLoad(object sender, EventArgs e)
//        {
//            SetDefaults();
//        }

//        private void CountSteps()
//        {
//            parametersArray.Clear();
//            double singleStep = (toRegVal - fromRegVal) / (stepCount - 1);
//            double currentStep = 0;
//            for (int i = 0; i < stepCount; i++)
//            {
//                parametersArray.Add(new Params{
//                    c9 = par_initial.c9 + (comboBox_regVal.SelectedItem.Equals("c9") ? currentStep : 0),
//                    dd = par_initial.dd + (comboBox_regVal.SelectedItem.Equals("dd") ? currentStep : 0),
//                    k2 = par_initial.k2 + (comboBox_regVal.SelectedItem.Equals("k2") ? currentStep : 0),
//                    mrr = par_initial.mrr + (comboBox_regVal.SelectedItem.Equals("mrr") ? currentStep : 0),
//                    ll = par_initial.ll + (comboBox_regVal.SelectedItem.Equals("ll") ? currentStep : 0),
//                    ke = par_initial.ke + (comboBox_regVal.SelectedItem.Equals("ke") ? currentStep : 0),
//                    km = par_initial.km + (comboBox_regVal.SelectedItem.Equals("km") ? currentStep : 0)
//                });
//                //if (checkBox_b3.Checked)
//                //{
//                //    parametersArrayB3.Add(new Params
//                //    {
//                //        c9 = par_block3.c9,
//                //        dd = par_block3.dd,
//                //        k2 = par_block3.k2,
//                //        mrr = par_block3.mrr,
//                //        ll = par_block3.ll,
//                //        ke = par_block3.ke,
//                //        km = par_block3.km
//                //    });
//                //}
//                currentStep += singleStep;
//            }
//        }
//        private void SaveOuts(Blocks bl, ref List<OutputsForGraph> dependencyList, Experiment exp)
//        {
//            Progress = CurrentTask / TaskNum;
//            progressBar1.Value = (CurrentTask / TaskNum) * 100;
//            progressBar1.Invalidate();
//            OutputsForGraph outs = new OutputsForGraph();
//            outs.avd = bl.avd;
//            outs.pO2a = bl.pO2a;
//            outs.pO2min = bl.pO2min;
//            outs.pO2t = bl.pO2t;
//            outs.pO2v = bl.pO2v;
//            outs.cy = bl.cy;
//            outs.VO2 = bl.VO2c;
//            switch (comboBox_regVal.SelectedItem.ToString())
//            {
//                case "c9":
//                    outs.depVal = exp.Main_pars.c9;
//                    break;
//                case "k2":
//                    outs.depVal = exp.Main_pars.k2;
//                    break;
//                case "dd":
//                    outs.depVal = exp.Main_pars.dd;
//                    break;
//                case "mrr":
//                    outs.depVal = exp.Main_pars.mrr;
//                    break;
//                case "ll":
//                    outs.depVal = exp.Main_pars.ll;
//                    break;
//                case "ke":
//                    outs.depVal = exp.Main_pars.ke;
//                    break;
//                case "km":
//                    outs.depVal = exp.Main_pars.km;
//                    break;
//                default:
//                    break;
//            }
//            dependencyList.Add(outs);
//        }
//        private void CountDependent()
//        {
//            int i = 0;
//            foreach (Params p in parametersArray)
//            {
//                Experiment exp = new Experiment();
//                exp.Main_pars = p;
//                exp.Block3_pars = par_block3;//parametersArrayB3[i];
                
//                exp.Size = this.bSize;
//                exp.Layers = this.Layers;
//                exp.ICount = this.Iterations;
//                exp.bl_list = new List<Blocks>();
//                exp.bl_list.Add(new Block1(exp));
//                exp.bl_list[0].Calculations();
//                CurrentTask++;
                
//                SaveOuts(exp.bl_list[0], ref depOutsBlock1, exp); 
//                exp.bl_list.Add(new Block2(exp));
//                exp.bl_list[1].Calculations();
//                CurrentTask++;
//                SaveOuts(exp.bl_list[1], ref depOutsBlock2, exp);
//                exp.bl_list.Add(new Block31(exp));
//                exp.bl_list[2].Calculations();
//                SaveOuts(exp.bl_list[2], ref depOutsBlock31, exp); 
//                exp.bl_list.Add(new Block32(exp));
//                exp.bl_list[3].Calculations();
//                CurrentTask++;
//                SaveOuts(exp.bl_list[3], ref depOutsBlock32, exp);
                
//            }
//        }
   
//        private void comboBox_regVal_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            string selectedRegVal = this.comboBox_regVal.SelectedItem.ToString();
//            textBox_c9.Enabled = !selectedRegVal.Equals("c9");
//            textBox_dd.Enabled = !selectedRegVal.Equals("dd");
//            textBox_k2.Enabled = !selectedRegVal.Equals("k2");
//            textBox_ke.Enabled = !selectedRegVal.Equals("ke");
//            textBox_km.Enabled = !selectedRegVal.Equals("km");
//            textBox_ll.Enabled = !selectedRegVal.Equals("ll");
//            textBox_mrr.Enabled = !selectedRegVal.Equals("mrr");
//        }

//        private void BuildPoints(ref PointPairList points, List<OutputsForGraph> outs)
//        {
//            foreach (OutputsForGraph d in outs)
//            {
//                double val = 0;
//                switch(comboBox_depValue.SelectedItem.ToString())
//                {
//                    case "pO2a" : 
//                        val = d.pO2a;
//                        break;
//                    case "pO2v" : 
//                        val = d.pO2v;
//                        break;
//                    case "pO2t" :
//                        val = d.pO2t;
//                        break;
//                    case "pO2min" :
//                        val = d.pO2min;
//                        break;
//                    case "cy" :
//                        val = d.cy;
//                        break;
//                    case "avd" :
//                        val = d.avd;
//                        break;
//                    case "VO2" :
//                        val = d.VO2;
//                        break;
//                }
//                points.Add(d.depVal, val);
//            }
//        }

//        private void comboBoxDepValue_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            PointPairList ppr_list = new PointPairList();
//            PointPairList ppr_list1 = new PointPairList();
//            PointPairList ppr_list2 = new PointPairList();
//            PointPairList ppr_list3 = new PointPairList();
//            zedGraphControl1.GraphPane.CurveList.Clear();
//            BuildPoints(ref ppr_list, depOutsBlock1);
//            BuildPoints(ref ppr_list1, depOutsBlock2);
//            BuildPoints(ref ppr_list2, depOutsBlock32);
//            BuildPoints(ref ppr_list3, depOutsBlock31);
//            zedGraphControl1.GraphPane.AddCurve("Блок 1", ppr_list, Color.Black, SymbolType.Diamond);
//            zedGraphControl1.GraphPane.AddCurve("Блок 2", ppr_list1, Color.Red, SymbolType.Circle);
//            zedGraphControl1.GraphPane.AddCurve("Блок 31", ppr_list3, Color.DarkGreen, SymbolType.XCross);
//            zedGraphControl1.GraphPane.AddCurve("Блок 32", ppr_list2, Color.Blue, SymbolType.Plus);
//            zedGraphControl1.GraphPane.Title.Text = "Зависимость " + comboBox_depValue.SelectedItem.ToString() + " от " + comboBox_regVal.SelectedItem.ToString(); 
//            zedGraphControl1.GraphPane.AxisChange();
//            zedGraphControl1.Invalidate();
//        }
//    }
//}
