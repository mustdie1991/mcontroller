namespace UserControlsLibrary.PointTab
{
    partial class MatrixControlMenu
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
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Layer = new System.Windows.Forms.NumericUpDown();
            this.comboBox_NBlock = new System.Windows.Forms.ComboBox();
            this.checkBox_diag = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Build = new System.Windows.Forms.Button();
            this.groupBox_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Layer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_main
            // 
            this.groupBox_main.Controls.Add(this.button_Save);
            this.groupBox_main.Controls.Add(this.comboBox_color);
            this.groupBox_main.Controls.Add(this.comboBox_Type);
            this.groupBox_main.Controls.Add(this.label4);
            this.groupBox_main.Controls.Add(this.label3);
            this.groupBox_main.Controls.Add(this.label2);
            this.groupBox_main.Controls.Add(this.numericUpDown_Layer);
            this.groupBox_main.Controls.Add(this.comboBox_NBlock);
            this.groupBox_main.Controls.Add(this.checkBox_diag);
            this.groupBox_main.Controls.Add(this.label1);
            this.groupBox_main.Controls.Add(this.button_Build);
            this.groupBox_main.Location = new System.Drawing.Point(0, 0);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(786, 69);
            this.groupBox_main.TabIndex = 8;
            this.groupBox_main.TabStop = false;
            this.groupBox_main.Text = "Настройки";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(622, 7);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(158, 24);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // comboBox_color
            // 
            this.comboBox_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_color.Enabled = false;
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Location = new System.Drawing.Point(261, 42);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(99, 21);
            this.comboBox_color.TabIndex = 4;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(85, 40);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(114, 21);
            this.comboBox_Type.TabIndex = 3;
            this.comboBox_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Заливка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Слой";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип матрицы";
            // 
            // numericUpDown_Layer
            // 
            this.numericUpDown_Layer.Location = new System.Drawing.Point(261, 17);
            this.numericUpDown_Layer.Name = "numericUpDown_Layer";
            this.numericUpDown_Layer.Size = new System.Drawing.Size(99, 20);
            this.numericUpDown_Layer.TabIndex = 1;
            // 
            // comboBox_NBlock
            // 
            this.comboBox_NBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_NBlock.FormattingEnabled = true;
            this.comboBox_NBlock.Location = new System.Drawing.Point(85, 17);
            this.comboBox_NBlock.Name = "comboBox_NBlock";
            this.comboBox_NBlock.Size = new System.Drawing.Size(114, 21);
            this.comboBox_NBlock.TabIndex = 1;
            this.comboBox_NBlock.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelIndexChanged);
            // 
            // checkBox_diag
            // 
            this.checkBox_diag.AutoSize = true;
            this.checkBox_diag.Location = new System.Drawing.Point(379, 18);
            this.checkBox_diag.Name = "checkBox_diag";
            this.checkBox_diag.Size = new System.Drawing.Size(102, 17);
            this.checkBox_diag.TabIndex = 0;
            this.checkBox_diag.Text = "Диагональный";
            this.checkBox_diag.UseVisualStyleBackColor = true;
            this.checkBox_diag.CheckedChanged += new System.EventHandler(this.checkBox_diag_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Блок";
            // 
            // button_Build
            // 
            this.button_Build.Location = new System.Drawing.Point(622, 32);
            this.button_Build.Name = "button_Build";
            this.button_Build.Size = new System.Drawing.Size(158, 26);
            this.button_Build.TabIndex = 5;
            this.button_Build.Text = "Построить";
            this.button_Build.UseVisualStyleBackColor = true;
            this.button_Build.Click += new System.EventHandler(this.button_Build_Click);
            // 
            // MatrixControlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_main);
            this.Name = "MatrixControlMenu";
            this.Size = new System.Drawing.Size(790, 72);
            this.groupBox_main.ResumeLayout(false);
            this.groupBox_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Layer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_main;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Layer;
        private System.Windows.Forms.ComboBox comboBox_NBlock;
        private System.Windows.Forms.CheckBox checkBox_diag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Build;
        private System.Windows.Forms.Button button_Save;
    }
}
