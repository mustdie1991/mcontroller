using UserControlsLibrary.PointTab.GraphicConrtols;
using UserControlsLibrary.PointTab.Histograms;
namespace UserControlsLibrary.PointTab
{
    partial class MainWnd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хуйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Launch = new System.Windows.Forms.Button();
            this.zedGraphControl_Dependencies = new ZedGraph.ZedGraphControl();
            this.label63 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_error = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSingleElement1 = new UserControlsLibrary.PointTab.TabSingleElement();
            this.constValuesBlock2 = new UserControlsLibrary.PointTab.ConstValuesBlock();
            this.regulatorInputControl1 = new UserControlsLibrary.PointTab.DependencyControls.RegulatorInputControl();
            this.dependencyControlMenu1 = new UserControlsLibrary.PointTab.DependencyControls.DependencyControlMenu();
            this.mainOutputsControl1 = new UserControlsLibrary.UserOutputsTab.MainOutputsControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.хуйToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // хуйToolStripMenuItem
            // 
            this.хуйToolStripMenuItem.Name = "хуйToolStripMenuItem";
            this.хуйToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.хуйToolStripMenuItem.Text = "Выход";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.mainOutputsControl1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1141, 674);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Результаты";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.zedGraphControl_Dependencies);
            this.tabPage2.Controls.Add(this.label63);
            this.tabPage2.Controls.Add(this.dependencyControlMenu1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1141, 674);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Зависимости";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Launch);
            this.groupBox1.Controls.Add(this.constValuesBlock2);
            this.groupBox1.Controls.Add(this.regulatorInputControl1);
            this.groupBox1.Location = new System.Drawing.Point(775, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 494);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные";
            // 
            // button_Launch
            // 
            this.button_Launch.Location = new System.Drawing.Point(211, 471);
            this.button_Launch.Name = "button_Launch";
            this.button_Launch.Size = new System.Drawing.Size(137, 23);
            this.button_Launch.TabIndex = 41;
            this.button_Launch.Text = "Запуск";
            this.button_Launch.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl_Dependencies
            // 
            this.zedGraphControl_Dependencies.Location = new System.Drawing.Point(9, 10);
            this.zedGraphControl_Dependencies.Name = "zedGraphControl_Dependencies";
            this.zedGraphControl_Dependencies.ScrollGrace = 0D;
            this.zedGraphControl_Dependencies.ScrollMaxX = 0D;
            this.zedGraphControl_Dependencies.ScrollMaxY = 0D;
            this.zedGraphControl_Dependencies.ScrollMaxY2 = 0D;
            this.zedGraphControl_Dependencies.ScrollMinX = 0D;
            this.zedGraphControl_Dependencies.ScrollMinY = 0D;
            this.zedGraphControl_Dependencies.ScrollMinY2 = 0D;
            this.zedGraphControl_Dependencies.Size = new System.Drawing.Size(760, 647);
            this.zedGraphControl_Dependencies.TabIndex = 38;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.ForeColor = System.Drawing.Color.Red;
            this.label63.Location = new System.Drawing.Point(115, 617);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(0, 13);
            this.label63.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabSingleElement1);
            this.tabPage1.Controls.Add(this.label_error);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1141, 674);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Точечные расчеты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(9, 566);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 13);
            this.label_error.TabIndex = 43;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1149, 700);
            this.tabControl1.TabIndex = 4;
            // 
            // tabSingleElement1
            // 
            this.tabSingleElement1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSingleElement1.Location = new System.Drawing.Point(7, 7);
            this.tabSingleElement1.Name = "tabSingleElement1";
            this.tabSingleElement1.Size = new System.Drawing.Size(1134, 664);
            this.tabSingleElement1.TabIndex = 44;
            // 
            // constValuesBlock2
            // 
            this.constValuesBlock2.Location = new System.Drawing.Point(211, 321);
            this.constValuesBlock2.Name = "constValuesBlock2";
            this.constValuesBlock2.Size = new System.Drawing.Size(137, 144);
            this.constValuesBlock2.TabIndex = 50;
            // 
            // regulatorInputControl1
            // 
            this.regulatorInputControl1.Location = new System.Drawing.Point(205, 19);
            this.regulatorInputControl1.Name = "regulatorInputControl1";
            this.regulatorInputControl1.Size = new System.Drawing.Size(143, 119);
            this.regulatorInputControl1.TabIndex = 49;
            // 
            // dependencyControlMenu1
            // 
            this.dependencyControlMenu1.Location = new System.Drawing.Point(775, 10);
            this.dependencyControlMenu1.Name = "dependencyControlMenu1";
            this.dependencyControlMenu1.Size = new System.Drawing.Size(354, 148);
            this.dependencyControlMenu1.TabIndex = 48;
            // 
            // mainOutputsControl1
            // 
            this.mainOutputsControl1.Location = new System.Drawing.Point(4, 4);
            this.mainOutputsControl1.Name = "mainOutputsControl1";
            this.mainOutputsControl1.Size = new System.Drawing.Size(1102, 667);
            this.mainOutputsControl1.TabIndex = 0;
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 742);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MController";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хуйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Launch;
        private ConstValuesBlock constValuesBlock2;
        private DependencyControls.RegulatorInputControl regulatorInputControl1;
        private ZedGraph.ZedGraphControl zedGraphControl_Dependencies;
        private System.Windows.Forms.Label label63;
        private DependencyControls.DependencyControlMenu dependencyControlMenu1;
        private System.Windows.Forms.TabPage tabPage1;
        private TabSingleElement tabSingleElement1;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.TabControl tabControl1;
        private UserOutputsTab.MainOutputsControl mainOutputsControl1;
    }
}

