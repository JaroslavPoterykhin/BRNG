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
            this.generateByButtonsButton = new System.Windows.Forms.Button();
            this.GenerateByLettersButton = new System.Windows.Forms.Button();
            this.mainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GenerateByMouseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generateByButtonsButton
            // 
            this.generateByButtonsButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateByButtonsButton.Location = new System.Drawing.Point(119, 27);
            this.generateByButtonsButton.Name = "generateByButtonsButton";
            this.generateByButtonsButton.Size = new System.Drawing.Size(165, 35);
            this.generateByButtonsButton.TabIndex = 1;
            this.generateByButtonsButton.Text = "Generate by Button";
            this.generateByButtonsButton.UseVisualStyleBackColor = true;
            this.generateByButtonsButton.Click += new System.EventHandler(this.GenerateByButtonsButton_Click);
            // 
            // GenerateByLettersButton
            // 
            this.GenerateByLettersButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateByLettersButton.Location = new System.Drawing.Point(119, 83);
            this.GenerateByLettersButton.Name = "GenerateByLettersButton";
            this.GenerateByLettersButton.Size = new System.Drawing.Size(165, 35);
            this.GenerateByLettersButton.TabIndex = 2;
            this.GenerateByLettersButton.Text = "Generate by Letters";
            this.GenerateByLettersButton.UseVisualStyleBackColor = true;
            this.GenerateByLettersButton.Click += new System.EventHandler(this.GenerateByLettersButton_Click);
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.Location = new System.Drawing.Point(25, 200);
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.Size = new System.Drawing.Size(372, 226);
            this.mainRichTextBox.TabIndex = 3;
            this.mainRichTextBox.Text = "";
            // 
            // GenerateByMouseButton
            // 
            this.GenerateByMouseButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateByMouseButton.Location = new System.Drawing.Point(119, 138);
            this.GenerateByMouseButton.Name = "GenerateByMouseButton";
            this.GenerateByMouseButton.Size = new System.Drawing.Size(165, 34);
            this.GenerateByMouseButton.TabIndex = 4;
            this.GenerateByMouseButton.Text = "Generate by Mouse";
            this.GenerateByMouseButton.UseVisualStyleBackColor = true;
            this.GenerateByMouseButton.Click += new System.EventHandler(this.GenerateByMouseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 466);
            this.Controls.Add(this.GenerateByMouseButton);
            this.Controls.Add(this.mainRichTextBox);
            this.Controls.Add(this.GenerateByLettersButton);
            this.Controls.Add(this.generateByButtonsButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 505);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(425, 505);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BRNG";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button generateByButtonsButton;
        private System.Windows.Forms.Button GenerateByLettersButton;
        public System.Windows.Forms.RichTextBox mainRichTextBox;
        private System.Windows.Forms.Button GenerateByMouseButton;
    }
}

