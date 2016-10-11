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
            this.mouseFormPictureBox = new System.Windows.Forms.PictureBox();
            this.BRNGMouseFormProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.mouseFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mouseFormPictureBox
            // 
            this.mouseFormPictureBox.BackgroundImage = global::BRNG.Properties.Resources._14734053208530;
            this.mouseFormPictureBox.Location = new System.Drawing.Point(29, 12);
            this.mouseFormPictureBox.Name = "mouseFormPictureBox";
            this.mouseFormPictureBox.Size = new System.Drawing.Size(794, 555);
            this.mouseFormPictureBox.TabIndex = 0;
            this.mouseFormPictureBox.TabStop = false;
            this.mouseFormPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseFormPictureBox_MouseMove);
            // 
            // BRNGMouseFormProgressBar
            // 
            this.BRNGMouseFormProgressBar.Location = new System.Drawing.Point(29, 597);
            this.BRNGMouseFormProgressBar.MarqueeAnimationSpeed = 10;
            this.BRNGMouseFormProgressBar.Maximum = 10;
            this.BRNGMouseFormProgressBar.Name = "BRNGMouseFormProgressBar";
            this.BRNGMouseFormProgressBar.RightToLeftLayout = true;
            this.BRNGMouseFormProgressBar.Size = new System.Drawing.Size(794, 34);
            this.BRNGMouseFormProgressBar.Step = 1;
            this.BRNGMouseFormProgressBar.TabIndex = 1;
            // 
            // BRNGMOUSEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 673);
            this.Controls.Add(this.BRNGMouseFormProgressBar);
            this.Controls.Add(this.mouseFormPictureBox);
            this.Name = "BRNGMOUSEForm";
            this.Text = "RNGMOUSEForm";
            ((System.ComponentModel.ISupportInitialize)(this.mouseFormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mouseFormPictureBox;
        private System.Windows.Forms.ProgressBar BRNGMouseFormProgressBar;
    }
}