using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRNG
{
    public partial class MainForm : Form
    {
        string path;
        public MainForm()
        {
            path = Environment.CurrentDirectory;
            InitializeComponent();
        }

        private void newBRNGButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BRNGForm numberGenerator = new BRNGForm(this);
            numberGenerator.Show();            
        }

        private void lookAtGeneratedNumberButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BRNG.Forms.BRNGKeyForm numberGeneratorByKeys = new Forms.BRNGKeyForm(this);
            numberGeneratorByKeys.Show();
        }

        private void ThirdButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BRNG.Forms.BRNGMOUSEForm numberGeneratorByMouse = new Forms.BRNGMOUSEForm(this);
            numberGeneratorByMouse.Show();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to use this programme", "How to use this programme", MessageBoxButtons.OK ,  MessageBoxIcon.Question);
        }

        private void saveNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText (path+@"\\randomNumbers.txt" , mainRichTextBox.Text);
        }

        private void dirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(path);
        }
    }
}
