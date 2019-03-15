namespace UserControlsLibrary.UserOutputsTab.GraphicInfoControls
{
    partial class GraphicsInfoMainControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_output = new System.Windows.Forms.PictureBox();
            this.graphicsInfoControlMenu1 = new UserControlsLibrary.UserOutputsTab.GraphicInfoControls.GraphicsInfoControlMenu();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox_output);
            this.groupBox1.Controls.Add(this.graphicsInfoControlMenu1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Графические выводы";
            // 
            // pictureBox_output
            // 
            this.pictureBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_output.Location = new System.Drawing.Point(158, 10);
            this.pictureBox_output.Name = "pictureBox_output";
            this.pictureBox_output.Size = new System.Drawing.Size(301, 302);
            this.pictureBox_output.TabIndex = 1;
            this.pictureBox_output.TabStop = false;
            // 
            // graphicsInfoControlMenu1
            // 
            this.graphicsInfoControlMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.graphicsInfoControlMenu1.Location = new System.Drawing.Point(7, 20);
            this.graphicsInfoControlMenu1.Name = "graphicsInfoControlMenu1";
            this.graphicsInfoControlMenu1.Size = new System.Drawing.Size(145, 292);
            this.graphicsInfoControlMenu1.TabIndex = 0;
            // 
            // GraphicsInfoMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "GraphicsInfoMainControl";
            this.Size = new System.Drawing.Size(472, 325);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox_output;
        private GraphicsInfoControlMenu graphicsInfoControlMenu1;
    }
}
