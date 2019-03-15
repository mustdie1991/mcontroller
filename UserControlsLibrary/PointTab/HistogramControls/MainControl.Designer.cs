namespace UserControlsLibrary.PointTab.Histograms
{
    partial class MainHistogramControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraph_histograms = new ZedGraph.ZedGraphControl();
            this.histogramList1 = new UserControlsLibrary.PointTab.Histograms.HistogramList();
            this.histogramDataGrid1 = new UserControlsLibrary.PointTab.Histograms.HistogramDataGrid();
            this.histogramControlMenu1 = new UserControlsLibrary.PointTab.Histograms.HistogramControlMenu();
            this.SuspendLayout();
            // 
            // zedGraph_histograms
            // 
            this.zedGraph_histograms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraph_histograms.Location = new System.Drawing.Point(185, 102);
            this.zedGraph_histograms.Name = "zedGraph_histograms";
            this.zedGraph_histograms.Size = new System.Drawing.Size(416, 542);
            this.zedGraph_histograms.TabIndex = 15;
            // 
            // histogramList1
            // 
            this.histogramList1.Location = new System.Drawing.Point(0, 101);
            this.histogramList1.Name = "histogramList1";
            this.histogramList1.Size = new System.Drawing.Size(179, 556);
            this.histogramList1.TabIndex = 18;
            // 
            // histogramDataGrid1
            // 
            this.histogramDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramDataGrid1.Location = new System.Drawing.Point(612, 102);
            this.histogramDataGrid1.Name = "histogramDataGrid1";
            this.histogramDataGrid1.Size = new System.Drawing.Size(195, 555);
            this.histogramDataGrid1.TabIndex = 17;
            // 
            // histogramControlMenu1
            // 
            this.histogramControlMenu1.Location = new System.Drawing.Point(0, 3);
            this.histogramControlMenu1.Name = "histogramControlMenu1";
            this.histogramControlMenu1.Size = new System.Drawing.Size(807, 93);
            this.histogramControlMenu1.TabIndex = 16;
            // 
            // MainHistogramControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.histogramList1);
            this.Controls.Add(this.histogramDataGrid1);
            this.Controls.Add(this.histogramControlMenu1);
            this.Controls.Add(this.zedGraph_histograms);
            this.Name = "MainHistogramControl";
            this.Size = new System.Drawing.Size(809, 660);
            this.ResumeLayout(false);

        }

        #endregion

        private Histograms.HistogramList histogramList1;
        private Histograms.HistogramDataGrid histogramDataGrid1;
        private Histograms.HistogramControlMenu histogramControlMenu1;
        private ZedGraph.ZedGraphControl zedGraph_histograms;
    }
}
