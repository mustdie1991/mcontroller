namespace UserControlsLibrary.PointTab
{
    partial class OutputTabControl
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.mainGraphControl2 = new UserControlsLibrary.PointTab.GraphicConrtols.MainGraphControl();
            this.mainHistogramControl1 = new UserControlsLibrary.PointTab.Histograms.MainHistogramControl();
            this.mainMatrixControl1 = new UserControlsLibrary.PointTab.MatrixControls.MainMatrixControl();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(8, 8);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(825, 686);
            this.tabControl2.TabIndex = 49;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.mainMatrixControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(817, 660);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Матрица";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.mainGraphControl2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(809, 660);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "График";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.mainHistogramControl1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(809, 660);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Гистограмма";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // mainGraphControl2
            // 
            this.mainGraphControl2.Location = new System.Drawing.Point(7, 7);
            this.mainGraphControl2.Name = "mainGraphControl2";
            this.mainGraphControl2.Size = new System.Drawing.Size(796, 647);
            this.mainGraphControl2.TabIndex = 0;
            // 
            // mainHistogramControl1
            // 
            this.mainHistogramControl1.Location = new System.Drawing.Point(4, 4);
            this.mainHistogramControl1.Name = "mainHistogramControl1";
            this.mainHistogramControl1.Size = new System.Drawing.Size(802, 653);
            this.mainHistogramControl1.TabIndex = 0;
            // 
            // mainMatrixControl1
            // 
            this.mainMatrixControl1.Location = new System.Drawing.Point(7, 7);
            this.mainMatrixControl1.Name = "mainMatrixControl1";
            this.mainMatrixControl1.Size = new System.Drawing.Size(796, 650);
            this.mainMatrixControl1.TabIndex = 0;
            // 
            // OutputTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl2);
            this.Name = "OutputTabControl";
            this.Size = new System.Drawing.Size(849, 694);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private GraphicConrtols.MainGraphControl mainGraphControl2;
        private Histograms.MainHistogramControl mainHistogramControl1;
        private MatrixControls.MainMatrixControl mainMatrixControl1;
    }
}
