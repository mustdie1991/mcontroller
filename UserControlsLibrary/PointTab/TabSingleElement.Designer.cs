namespace UserControlsLibrary.PointTab
{
    partial class TabSingleElement
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
            this.inputControl1 = new UserControlsLibrary.PointTab.MainWindowControls.InputControl();
            this.outputTabControl1 = new UserControlsLibrary.PointTab.OutputTabControl();
            this.SuspendLayout();
            // 
            // inputControl1
            // 
            this.inputControl1.Location = new System.Drawing.Point(0, 3);
            this.inputControl1.Name = "inputControl1";
            this.inputControl1.Size = new System.Drawing.Size(323, 694);
            this.inputControl1.TabIndex = 49;
            // 
            // outputTabControl1
            // 
            this.outputTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTabControl1.Location = new System.Drawing.Point(318, 0);
            this.outputTabControl1.Name = "outputTabControl1";
            this.outputTabControl1.Size = new System.Drawing.Size(828, 697);
            this.outputTabControl1.TabIndex = 50;
            // 
            // TabSingleElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outputTabControl1);
            this.Controls.Add(this.inputControl1);
            this.Name = "TabSingleElement";
            this.Size = new System.Drawing.Size(1149, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private MainWindowControls.InputControl inputControl1;
        private OutputTabControl outputTabControl1;
    }
}
