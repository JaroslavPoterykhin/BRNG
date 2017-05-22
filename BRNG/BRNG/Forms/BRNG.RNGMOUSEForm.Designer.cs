namespace BRNG.Forms
{
    partial class BRNGMOUSEForm
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
            this.BRNGMouseFormProgressBar = new System.Windows.Forms.ProgressBar();
            this.mouseFormPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mouseFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BRNGMouseFormProgressBar
            // 
            this.BRNGMouseFormProgressBar.Location = new System.Drawing.Point(29, 531);
            this.BRNGMouseFormProgressBar.Maximum = (int)previusForm.lengthOfSeqBox.Value;
            this.BRNGMouseFormProgressBar.Name = "BRNGMouseFormProgressBar";
            this.BRNGMouseFormProgressBar.RightToLeftLayout = true;
            this.BRNGMouseFormProgressBar.Size = new System.Drawing.Size(794, 34);
            this.BRNGMouseFormProgressBar.Step = 1;
            this.BRNGMouseFormProgressBar.TabIndex = 1;
            // 
            // mouseFormPictureBox
            // 
            this.mouseFormPictureBox.BackgroundImage = global::BRNG.Properties.Resources._14790978201620583571;
            this.mouseFormPictureBox.Location = new System.Drawing.Point(29, 12);
            this.mouseFormPictureBox.Name = "mouseFormPictureBox";
            this.mouseFormPictureBox.Size = new System.Drawing.Size(794, 497);
            this.mouseFormPictureBox.TabIndex = 0;
            this.mouseFormPictureBox.TabStop = false;
            this.mouseFormPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseFormPictureBox_MouseMove);
            // 
            // BRNGMOUSEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 589);
            this.Controls.Add(this.BRNGMouseFormProgressBar);
            this.Controls.Add(this.mouseFormPictureBox);
            this.Name = "BRNGMOUSEForm";
            this.Text = "RNGMOUSEForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BRNGMOUSEForm_FormClosed);
            this.Load += new System.EventHandler(this.BRNGMOUSEForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mouseFormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mouseFormPictureBox;
        private System.Windows.Forms.ProgressBar BRNGMouseFormProgressBar;
    }
}