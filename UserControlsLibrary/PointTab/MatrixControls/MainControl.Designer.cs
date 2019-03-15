namespace UserControlsLibrary.PointTab.MatrixControls
{
    partial class MainMatrixControl
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
            this.matrixConrtolMenu1 = new UserControlsLibrary.PointTab.MatrixControlMenu();
            this.dataGridView_Results = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixConrtolMenu1
            // 
            this.matrixConrtolMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.matrixConrtolMenu1.Location = new System.Drawing.Point(5, 6);
            this.matrixConrtolMenu1.Name = "matrixConrtolMenu1";
            this.matrixConrtolMenu1.Size = new System.Drawing.Size(798, 73);
            this.matrixConrtolMenu1.TabIndex = 9;
            this.matrixConrtolMenu1.Load += new System.EventHandler(this.matrixConrtolMenu1_Load);
            // 
            // dataGridView_Results
            // 
            this.dataGridView_Results.AllowUserToAddRows = false;
            this.dataGridView_Results.AllowUserToDeleteRows = false;
            this.dataGridView_Results.AllowUserToResizeColumns = false;
            this.dataGridView_Results.AllowUserToResizeRows = false;
            this.dataGridView_Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Results.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Results.ColumnHeadersVisible = false;
            this.dataGridView_Results.Location = new System.Drawing.Point(5, 85);
            this.dataGridView_Results.MultiSelect = false;
            this.dataGridView_Results.Name = "dataGridView_Results";
            this.dataGridView_Results.ReadOnly = true;
            this.dataGridView_Results.RowHeadersVisible = false;
            this.dataGridView_Results.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Results.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_Results.Size = new System.Drawing.Size(798, 565);
            this.dataGridView_Results.TabIndex = 8;
            // 
            // MainMatrixControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.matrixConrtolMenu1);
            this.Controls.Add(this.dataGridView_Results);
            this.Name = "MainMatrixControl";
            this.Size = new System.Drawing.Size(809, 668);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MatrixControlMenu matrixConrtolMenu1;
        private System.Windows.Forms.DataGridView dataGridView_Results;
    }
}
