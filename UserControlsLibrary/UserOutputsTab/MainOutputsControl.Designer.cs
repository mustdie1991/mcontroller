namespace UserControlsLibrary.UserOutputsTab
{
    partial class MainOutputsControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.savedBlocksControlMenu1 = new UserControlsLibrary.UserOutputsTab.CalculatedInfoControls.SavedBlocksControlMenu();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.graphicsInfoMainControl1 = new UserControlsLibrary.UserOutputsTab.GraphicInfoControls.GraphicsInfoMainControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.savedBlocksControlMenu1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(511, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Числовые выводы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // savedBlocksControlMenu1
            // 
            this.savedBlocksControlMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.savedBlocksControlMenu1.Location = new System.Drawing.Point(7, 7);
            this.savedBlocksControlMenu1.Name = "savedBlocksControlMenu1";
            this.savedBlocksControlMenu1.Size = new System.Drawing.Size(503, 265);
            this.savedBlocksControlMenu1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.graphicsInfoMainControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Графические выводы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // graphicsInfoMainControl1
            // 
            this.graphicsInfoMainControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.graphicsInfoMainControl1.Location = new System.Drawing.Point(7, 7);
            this.graphicsInfoMainControl1.Name = "graphicsInfoMainControl1";
            this.graphicsInfoMainControl1.Size = new System.Drawing.Size(580, 330);
            this.graphicsInfoMainControl1.TabIndex = 0;
            // 
            // MainOutputsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "MainOutputsControl";
            this.Size = new System.Drawing.Size(610, 379);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CalculatedInfoControls.SavedBlocksControlMenu savedBlocksControlMenu1;
        private GraphicInfoControls.GraphicsInfoMainControl graphicsInfoMainControl1;
    }
}
