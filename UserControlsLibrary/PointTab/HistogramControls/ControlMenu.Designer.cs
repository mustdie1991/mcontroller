namespace UserControlsLibrary.PointTab.Histograms
{
    partial class HistogramControlMenu
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
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_launch = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.button_ChColor = new System.Windows.Forms.Button();
            this.numericUpDown_cols = new System.Windows.Forms.NumericUpDown();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.comboBox_block = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cols)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.textBox_name);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.button_launch);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.comboBox_type);
            this.groupBox10.Controls.Add(this.label41);
            this.groupBox10.Controls.Add(this.comboBox_block);
            this.groupBox10.Controls.Add(this.label42);
            this.groupBox10.Location = new System.Drawing.Point(6, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(792, 91);
            this.groupBox10.TabIndex = 11;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Настройки";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(150, 13);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(142, 20);
            this.textBox_name.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название :";
            // 
            // button_launch
            // 
            this.button_launch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_launch.Location = new System.Drawing.Point(659, 13);
            this.button_launch.Name = "button_launch";
            this.button_launch.Size = new System.Drawing.Size(127, 72);
            this.button_launch.TabIndex = 5;
            this.button_launch.Text = "Показать";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label40);
            this.groupBox11.Controls.Add(this.button_ChColor);
            this.groupBox11.Controls.Add(this.numericUpDown_cols);
            this.groupBox11.Location = new System.Drawing.Point(309, 13);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(251, 72);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Дополнительно";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 16);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(116, 13);
            this.label40.TabIndex = 7;
            this.label40.Text = "Количество столбцов";
            // 
            // button_ChColor
            // 
            this.button_ChColor.Location = new System.Drawing.Point(9, 40);
            this.button_ChColor.Name = "button_ChColor";
            this.button_ChColor.Size = new System.Drawing.Size(236, 25);
            this.button_ChColor.TabIndex = 5;
            this.button_ChColor.Text = "Выбор цвета";
            this.button_ChColor.UseVisualStyleBackColor = true;
            this.button_ChColor.Click += new System.EventHandler(this.button_ChColor_Click);
            // 
            // numericUpDown_cols
            // 
            this.numericUpDown_cols.Location = new System.Drawing.Point(161, 14);
            this.numericUpDown_cols.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_cols.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_cols.Name = "numericUpDown_cols";
            this.numericUpDown_cols.Size = new System.Drawing.Size(84, 20);
            this.numericUpDown_cols.TabIndex = 6;
            this.numericUpDown_cols.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // comboBox_type
            // 
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(150, 56);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(143, 21);
            this.comboBox_type.TabIndex = 3;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(11, 59);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(133, 13);
            this.label41.TabIndex = 2;
            this.label41.Text = "Выбор типа гистораммы";
            // 
            // comboBox_block
            // 
            this.comboBox_block.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_block.FormattingEnabled = true;
            this.comboBox_block.Location = new System.Drawing.Point(151, 34);
            this.comboBox_block.Name = "comboBox_block";
            this.comboBox_block.Size = new System.Drawing.Size(142, 21);
            this.comboBox_block.TabIndex = 1;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(11, 37);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(73, 13);
            this.label42.TabIndex = 0;
            this.label42.Text = "Выбор блока";
            // 
            // HistogramControlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox10);
            this.Name = "HistogramControlMenu";
            this.Size = new System.Drawing.Size(807, 100);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cols)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button button_launch;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button button_ChColor;
        private System.Windows.Forms.NumericUpDown numericUpDown_cols;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox comboBox_block;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
    }
}
