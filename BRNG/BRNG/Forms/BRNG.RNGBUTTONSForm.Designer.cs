namespace BRNG
{
    partial class BRNGForm
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
            this.BRNGPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BRNGPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BRNGPicture
            // 
            this.BRNGPicture.BackgroundImage = global::BRNG.Properties.Resources.plane;
            this.BRNGPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BRNGPicture.Location = new System.Drawing.Point(245, 212);
            this.BRNGPicture.Name = "BRNGPicture";
            this.BRNGPicture.Size = new System.Drawing.Size(90, 86);
            this.BRNGPicture.TabIndex = 0;
            this.BRNGPicture.TabStop = false;
            this.BRNGPicture.Click += new System.EventHandler(this.BRNGPicture_Click);
            // 
            // BRNGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BRNG.Properties.Resources.sky;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.BRNGPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BRNGForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BRNGForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BRNGForm_FormClosed);
            this.Load += new System.EventHandler(this.BRNGForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BRNGPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BRNGPicture;
    }
}