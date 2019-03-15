namespace UserControlsLibrary.PointTab.DependencyControls
{
    partial class RegulatorInputControl
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
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox_to = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.textBox_from = new System.Windows.Forms.TextBox();
            this.comboBox_regVal = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.numericUpDown2);
            this.groupBox14.Controls.Add(this.label62);
            this.groupBox14.Controls.Add(this.textBox_to);
            this.groupBox14.Controls.Add(this.label64);
            this.groupBox14.Controls.Add(this.textBox_from);
            this.groupBox14.Controls.Add(this.comboBox_regVal);
            this.groupBox14.Controls.Add(this.label65);
            this.groupBox14.Controls.Add(this.label66);
            this.groupBox14.Location = new System.Drawing.Point(3, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(135, 111);
            this.groupBox14.TabIndex = 45;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Зависимости";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(72, 84);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(6, 86);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(35, 13);
            this.label62.TabIndex = 6;
            this.label62.Text = "точек";
            // 
            // textBox_to
            // 
            this.textBox_to.Location = new System.Drawing.Point(72, 63);
            this.textBox_to.Name = "textBox_to";
            this.textBox_to.Size = new System.Drawing.Size(52, 20);
            this.textBox_to.TabIndex = 5;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(6, 66);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(19, 13);
            this.label64.TabIndex = 4;
            this.label64.Text = "до";
            // 
            // textBox_from
            // 
            this.textBox_from.Location = new System.Drawing.Point(72, 40);
            this.textBox_from.Name = "textBox_from";
            this.textBox_from.Size = new System.Drawing.Size(52, 20);
            this.textBox_from.TabIndex = 3;
            // 
            // comboBox_regVal
            // 
            this.comboBox_regVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_regVal.FormattingEnabled = true;
            this.comboBox_regVal.Items.AddRange(new object[] {
            "c9",
            "k2",
            "ll",
            "mrr",
            "km",
            "dd",
            "ke"});
            this.comboBox_regVal.Location = new System.Drawing.Point(72, 17);
            this.comboBox_regVal.Name = "comboBox_regVal";
            this.comboBox_regVal.Size = new System.Drawing.Size(52, 21);
            this.comboBox_regVal.TabIndex = 2;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(6, 43);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(18, 13);
            this.label65.TabIndex = 1;
            this.label65.Text = "от";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(6, 20);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(55, 13);
            this.label66.TabIndex = 0;
            this.label66.Text = "Величина";
            // 
            // RegulatorInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox14);
            this.Name = "RegulatorInputControl";
            this.Size = new System.Drawing.Size(143, 119);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox textBox_to;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox textBox_from;
        private System.Windows.Forms.ComboBox comboBox_regVal;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
    }
}
