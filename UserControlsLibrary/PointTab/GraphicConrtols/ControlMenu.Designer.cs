namespace UserControlsLibrary.PointTab.GraphicConrtols
{
    partial class GraphControlMenu
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
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_selectColor = new System.Windows.Forms.Button();
            this.numericUpDown_Layer = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.button_Build = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox_graphName = new System.Windows.Forms.TextBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.comboBox_BNumber = new System.Windows.Forms.ComboBox();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Layer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.groupBox1);
            this.groupBox8.Controls.Add(this.numericUpDown_Layer);
            this.groupBox8.Controls.Add(this.label36);
            this.groupBox8.Controls.Add(this.button_Build);
            this.groupBox8.Controls.Add(this.label37);
            this.groupBox8.Controls.Add(this.textBox_graphName);
            this.groupBox8.Controls.Add(this.comboBox_Type);
            this.groupBox8.Controls.Add(this.label38);
            this.groupBox8.Controls.Add(this.label39);
            this.groupBox8.Controls.Add(this.comboBox_BNumber);
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(728, 115);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Настройки";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_color);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_selectColor);
            this.groupBox1.Location = new System.Drawing.Point(230, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 84);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры кривых";
            // 
            // comboBox_color
            // 
            this.comboBox_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Location = new System.Drawing.Point(70, 20);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(124, 21);
            this.comboBox_color.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тип точек";
            // 
            // button_selectColor
            // 
            this.button_selectColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_selectColor.AutoSize = true;
            this.button_selectColor.Location = new System.Drawing.Point(6, 52);
            this.button_selectColor.Name = "button_selectColor";
            this.button_selectColor.Size = new System.Drawing.Size(188, 23);
            this.button_selectColor.TabIndex = 5;
            this.button_selectColor.Text = "Выбор цвета";
            this.button_selectColor.UseVisualStyleBackColor = true;
            this.button_selectColor.Click += new System.EventHandler(this.button_selectColor_Click);
            // 
            // numericUpDown_Layer
            // 
            this.numericUpDown_Layer.Location = new System.Drawing.Point(122, 80);
            this.numericUpDown_Layer.Name = "numericUpDown_Layer";
            this.numericUpDown_Layer.Size = new System.Drawing.Size(84, 20);
            this.numericUpDown_Layer.TabIndex = 1;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 82);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(32, 13);
            this.label36.TabIndex = 2;
            this.label36.Text = "Слой";
            // 
            // button_Build
            // 
            this.button_Build.AutoSize = true;
            this.button_Build.Location = new System.Drawing.Point(608, 16);
            this.button_Build.Name = "button_Build";
            this.button_Build.Size = new System.Drawing.Size(106, 84);
            this.button_Build.TabIndex = 5;
            this.button_Build.Text = "Построить";
            this.button_Build.UseVisualStyleBackColor = true;
            this.button_Build.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 19);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(57, 13);
            this.label37.TabIndex = 7;
            this.label37.Text = "Название";
            // 
            // textBox_graphName
            // 
            this.textBox_graphName.Location = new System.Drawing.Point(122, 16);
            this.textBox_graphName.Name = "textBox_graphName";
            this.textBox_graphName.Size = new System.Drawing.Size(84, 20);
            this.textBox_graphName.TabIndex = 6;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(122, 57);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(84, 21);
            this.comboBox_Type.TabIndex = 3;
            this.comboBox_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_Type_SelectedIndexChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 39);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(73, 13);
            this.label38.TabIndex = 0;
            this.label38.Text = "Выбор блока";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 60);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(112, 13);
            this.label39.TabIndex = 2;
            this.label39.Text = "Выбор типа графика";
            // 
            // comboBox_BNumber
            // 
            this.comboBox_BNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BNumber.FormattingEnabled = true;
            this.comboBox_BNumber.Location = new System.Drawing.Point(122, 36);
            this.comboBox_BNumber.Name = "comboBox_BNumber";
            this.comboBox_BNumber.Size = new System.Drawing.Size(84, 21);
            this.comboBox_BNumber.TabIndex = 1;
            // 
            // GraphControlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox8);
            this.Name = "GraphControlMenu";
            this.Size = new System.Drawing.Size(734, 123);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Layer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button_selectColor;
        private System.Windows.Forms.NumericUpDown numericUpDown_Layer;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button button_Build;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBox_graphName;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox comboBox_BNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.Label label1;
    }
}
