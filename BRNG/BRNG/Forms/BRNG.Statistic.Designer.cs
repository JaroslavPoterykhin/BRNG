namespace BRNG.Forms
{
    partial class BRNGStatistics
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.AmmountOfNumbersToBeGenerated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Errors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AmmountOfNumbersToBeGenerated,
            this.Errors});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(245, 326);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.VirtualMode = true;
            // 
            // AmmountOfNumbersToBeGenerated
            // 
            this.AmmountOfNumbersToBeGenerated.HeaderText = "Осталось нажатий";
            this.AmmountOfNumbersToBeGenerated.Name = "AmmountOfNumbersToBeGenerated";
            this.AmmountOfNumbersToBeGenerated.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AmmountOfNumbersToBeGenerated.DataPropertyName = "Value";
            // 
            // Errors
            // 
            this.Errors.HeaderText = "Ошибочные нажатия";
            this.Errors.Name = "Errors";
            this.Errors.DataPropertyName = "Error";
            this.Errors.ReadOnly = true;
            // 
            // BRNGStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 326);
            this.ControlBox = false;
            this.Controls.Add(this.dataGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BRNGStatistics";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmmountOfNumbersToBeGenerated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Errors;
    }
}