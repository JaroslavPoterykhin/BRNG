namespace BRNG.Forms
{
    partial class BRNGKeyForm
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
            this.keyFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyFormLabel
            // 
            this.keyFormLabel.AutoSize = true;
            this.keyFormLabel.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyFormLabel.Location = new System.Drawing.Point(324, 201);
            this.keyFormLabel.Name = "keyFormLabel";
            this.keyFormLabel.Size = new System.Drawing.Size(56, 61);
            this.keyFormLabel.TabIndex = 0;
            this.keyFormLabel.Text = "S";
            // 
            // BRNGKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 546);
            this.Controls.Add(this.keyFormLabel);
            this.Name = "BRNGKeyForm";
            this.Text = "BRNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BRNGKeyForm_FormClosed);
            this.Load += new System.EventHandler(this.BRNGKeyForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BRNG_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label keyFormLabel;
    }
}