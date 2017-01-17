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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.lettersLeftLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Letters left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Errors";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.errorsLabel);
            this.panel1.Controls.Add(this.lettersLeftLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 90);
            this.panel1.TabIndex = 3;
            // 
            // errorsLabel
            // 
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorsLabel.Location = new System.Drawing.Point(100, 59);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(0, 19);
            this.errorsLabel.TabIndex = 4;
            // 
            // lettersLeftLabel
            // 
            this.lettersLeftLabel.AutoSize = true;
            this.lettersLeftLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lettersLeftLabel.Location = new System.Drawing.Point(100, 20);
            this.lettersLeftLabel.Name = "lettersLeftLabel";
            this.lettersLeftLabel.Size = new System.Drawing.Size(0, 19);
            this.lettersLeftLabel.TabIndex = 3;
            // 
            // BRNGKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.keyFormLabel);
            this.Name = "BRNGKeyForm";
            this.Text = "BRNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BRNGKeyForm_FormClosed);
            this.Load += new System.EventHandler(this.BRNGKeyForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BRNG_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label keyFormLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label errorsLabel;
        private System.Windows.Forms.Label lettersLeftLabel;
    }
}