namespace UserControlsLibrary.PointTab.MainWindowControls
{
    partial class InputControl
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
            this.button_launch = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.experimentParametersBox1 = new UserControlsLibrary.PointTab.MainWindowControls.ExperimentParametersBox();
            this.parametersBox_block3 = new UserControlsLibrary.PointTab.MainWindowControls.ParametersBox();
            this.parametersBox_block1 = new UserControlsLibrary.PointTab.MainWindowControls.ParametersBox();
            this.constValuesBlock1 = new UserControlsLibrary.PointTab.ConstValuesBlock();
            this.blockOutsBox_block3 = new UserControlsLibrary.PointTab.BlockOutsBox();
            this.blockOutsBox_block2 = new UserControlsLibrary.PointTab.BlockOutsBox();
            this.blockOutsBox_block1 = new UserControlsLibrary.PointTab.BlockOutsBox();
            this.SuspendLayout();
            // 
            // button_launch
            // 
            this.button_launch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_launch.Location = new System.Drawing.Point(3, 514);
            this.button_launch.Name = "button_launch";
            this.button_launch.Size = new System.Drawing.Size(180, 23);
            this.button_launch.TabIndex = 50;
            this.button_launch.Text = "Запуск";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Location = new System.Drawing.Point(4, 485);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(179, 23);
            this.button_save.TabIndex = 52;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // experimentParametersBox1
            // 
            this.experimentParametersBox1.Location = new System.Drawing.Point(3, 356);
            this.experimentParametersBox1.Name = "experimentParametersBox1";
            this.experimentParametersBox1.Size = new System.Drawing.Size(180, 90);
            this.experimentParametersBox1.TabIndex = 51;
            this.experimentParametersBox1.Title = "Параметры расчетов";
            // 
            // parametersBox_block3
            // 
            this.parametersBox_block3.Location = new System.Drawing.Point(3, 180);
            this.parametersBox_block3.Name = "parametersBox_block3";
            this.parametersBox_block3.Size = new System.Drawing.Size(180, 170);
            this.parametersBox_block3.TabIndex = 49;
            this.parametersBox_block3.Title = "Входные параметры блока 3";
            // 
            // parametersBox_block1
            // 
            this.parametersBox_block1.Location = new System.Drawing.Point(3, 4);
            this.parametersBox_block1.Name = "parametersBox_block1";
            this.parametersBox_block1.Size = new System.Drawing.Size(180, 170);
            this.parametersBox_block1.TabIndex = 48;
            this.parametersBox_block1.Title = "Входные параметры блока 1";
            // 
            // constValuesBlock1
            // 
            this.constValuesBlock1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.constValuesBlock1.Location = new System.Drawing.Point(186, 408);
            this.constValuesBlock1.Name = "constValuesBlock1";
            this.constValuesBlock1.Size = new System.Drawing.Size(141, 129);
            this.constValuesBlock1.TabIndex = 47;
            // 
            // blockOutsBox_block3
            // 
            this.blockOutsBox_block3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blockOutsBox_block3.Location = new System.Drawing.Point(179, 269);
            this.blockOutsBox_block3.Name = "blockOutsBox_block3";
            this.blockOutsBox_block3.Size = new System.Drawing.Size(148, 136);
            this.blockOutsBox_block3.TabIndex = 46;
            this.blockOutsBox_block3.TitleText = "Выводы блока 3";
            // 
            // blockOutsBox_block2
            // 
            this.blockOutsBox_block2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blockOutsBox_block2.Location = new System.Drawing.Point(180, 137);
            this.blockOutsBox_block2.Name = "blockOutsBox_block2";
            this.blockOutsBox_block2.Size = new System.Drawing.Size(150, 136);
            this.blockOutsBox_block2.TabIndex = 45;
            this.blockOutsBox_block2.TitleText = "Выводы блока 2";
            // 
            // blockOutsBox_block1
            // 
            this.blockOutsBox_block1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blockOutsBox_block1.Location = new System.Drawing.Point(180, 4);
            this.blockOutsBox_block1.Name = "blockOutsBox_block1";
            this.blockOutsBox_block1.Size = new System.Drawing.Size(150, 136);
            this.blockOutsBox_block1.TabIndex = 44;
            this.blockOutsBox_block1.TitleText = "Выводы блока1";
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.experimentParametersBox1);
            this.Controls.Add(this.button_launch);
            this.Controls.Add(this.parametersBox_block3);
            this.Controls.Add(this.parametersBox_block1);
            this.Controls.Add(this.constValuesBlock1);
            this.Controls.Add(this.blockOutsBox_block3);
            this.Controls.Add(this.blockOutsBox_block2);
            this.Controls.Add(this.blockOutsBox_block1);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(330, 543);
            this.ResumeLayout(false);

        }

        #endregion

        private BlockOutsBox blockOutsBox_block1;
        private BlockOutsBox blockOutsBox_block2;
        private BlockOutsBox blockOutsBox_block3;
        private ConstValuesBlock constValuesBlock1;
        private MainWindowControls.ParametersBox parametersBox_block1;
        private MainWindowControls.ParametersBox parametersBox_block3;
        private System.Windows.Forms.Button button_launch;
        private MainWindowControls.ExperimentParametersBox experimentParametersBox1;
        private System.Windows.Forms.Button button_save;
    }
}
