namespace BRNG
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBRNGButton = new System.Windows.Forms.Button();
            this.lookAtGeneratedNumberButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.fAQToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fAQToolStripMenuItem.Text = "F.A.Q";
            // 
            // newBRNGButton
            // 
            this.newBRNGButton.Location = new System.Drawing.Point(138, 158);
            this.newBRNGButton.Name = "newBRNGButton";
            this.newBRNGButton.Size = new System.Drawing.Size(137, 24);
            this.newBRNGButton.TabIndex = 1;
            this.newBRNGButton.Text = "New random numbers";
            this.newBRNGButton.UseVisualStyleBackColor = true;
            this.newBRNGButton.Click += new System.EventHandler(this.newBRNGButton_Click);
            // 
            // lookAtGeneratedNumberButton
            // 
            this.lookAtGeneratedNumberButton.Location = new System.Drawing.Point(138, 203);
            this.lookAtGeneratedNumberButton.Name = "lookAtGeneratedNumberButton";
            this.lookAtGeneratedNumberButton.Size = new System.Drawing.Size(137, 25);
            this.lookAtGeneratedNumberButton.TabIndex = 2;
            this.lookAtGeneratedNumberButton.Text = "Look At Numbers";
            this.lookAtGeneratedNumberButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 466);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lookAtGeneratedNumberButton);
            this.Controls.Add(this.newBRNGButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "BRNG";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.Button newBRNGButton;
        private System.Windows.Forms.Button lookAtGeneratedNumberButton;
        private System.Windows.Forms.Button button3;
    }
}

