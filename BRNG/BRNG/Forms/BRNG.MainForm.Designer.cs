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
            this.mainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ThirdButton = new System.Windows.Forms.Button();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.fAQToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem});
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fAQToolStripMenuItem.Text = "F.A.Q";
            // 
            // newBRNGButton
            // 
            this.newBRNGButton.Location = new System.Drawing.Point(35, 57);
            this.newBRNGButton.Name = "newBRNGButton";
            this.newBRNGButton.Size = new System.Drawing.Size(137, 24);
            this.newBRNGButton.TabIndex = 1;
            this.newBRNGButton.Text = "Generate by Button";
            this.newBRNGButton.UseVisualStyleBackColor = true;
            this.newBRNGButton.Click += new System.EventHandler(this.newBRNGButton_Click);
            // 
            // lookAtGeneratedNumberButton
            // 
            this.lookAtGeneratedNumberButton.Location = new System.Drawing.Point(242, 57);
            this.lookAtGeneratedNumberButton.Name = "lookAtGeneratedNumberButton";
            this.lookAtGeneratedNumberButton.Size = new System.Drawing.Size(137, 25);
            this.lookAtGeneratedNumberButton.TabIndex = 2;
            this.lookAtGeneratedNumberButton.Text = "Generate by Letters";
            this.lookAtGeneratedNumberButton.UseVisualStyleBackColor = true;
            this.lookAtGeneratedNumberButton.Click += new System.EventHandler(this.lookAtGeneratedNumberButton_Click);
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.Location = new System.Drawing.Point(51, 229);
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.Size = new System.Drawing.Size(328, 197);
            this.mainRichTextBox.TabIndex = 3;
            this.mainRichTextBox.Text = "";
            // 
            // ThirdButton
            // 
            this.ThirdButton.Location = new System.Drawing.Point(135, 143);
            this.ThirdButton.Name = "ThirdButton";
            this.ThirdButton.Size = new System.Drawing.Size(137, 23);
            this.ThirdButton.TabIndex = 4;
            this.ThirdButton.Text = "Generate by Mouse";
            this.ThirdButton.UseVisualStyleBackColor = true;
            this.ThirdButton.Click += new System.EventHandler(this.ThirdButton_Click);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToUseToolStripMenuItem.Text = "How to use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 466);
            this.Controls.Add(this.ThirdButton);
            this.Controls.Add(this.mainRichTextBox);
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
        public System.Windows.Forms.RichTextBox mainRichTextBox;
        private System.Windows.Forms.Button ThirdButton;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
    }
}

