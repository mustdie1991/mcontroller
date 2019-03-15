namespace UserControlsLibrary.PointTab.GraphicConrtols
{
    partial class MainGraphControl
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
            this.zedGraphControl_graphs = new ZedGraph.ZedGraphControl();
            this.graphsList1 = new UserControlsLibrary.PointTab.GraphicConrtols.GraphsList();
            this.graphControlMenu1 = new UserControlsLibrary.PointTab.GraphicConrtols.GraphControlMenu();
            this.SuspendLayout();
            // 
            // zedGraphControl_graphs
            // 
            this.zedGraphControl_graphs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl_graphs.Location = new System.Drawing.Point(170, 112);
            this.zedGraphControl_graphs.Name = "zedGraphControl_graphs";
            this.zedGraphControl_graphs.Size = new System.Drawing.Size(618, 494);
            this.zedGraphControl_graphs.TabIndex = 11;
            // 
            // graphsList1
            // 
            this.graphsList1.AutoSize = true;
            this.graphsList1.Location = new System.Drawing.Point(3, 112);
            this.graphsList1.Name = "graphsList1";
            this.graphsList1.Size = new System.Drawing.Size(161, 505);
            this.graphsList1.TabIndex = 13;
            // 
            // graphControlMenu1
            // 
            this.graphControlMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.graphControlMenu1.Location = new System.Drawing.Point(3, 3);
            this.graphControlMenu1.Name = "graphControlMenu1";
            this.graphControlMenu1.Size = new System.Drawing.Size(785, 103);
            this.graphControlMenu1.TabIndex = 12;
            // 
            // MainGraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.graphsList1);
            this.Controls.Add(this.zedGraphControl_graphs);
            this.Controls.Add(this.graphControlMenu1);
            this.Name = "MainGraphControl";
            this.Size = new System.Drawing.Size(802, 621);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GraphsList graphsList1;
        private ZedGraph.ZedGraphControl zedGraphControl_graphs; 
        private GraphControlMenu graphControlMenu1;
    }
}
