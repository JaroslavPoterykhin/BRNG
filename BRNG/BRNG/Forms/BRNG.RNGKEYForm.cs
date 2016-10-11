using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRNG.Forms
{
    public partial class BRNGKeyForm : Form
    {
        private MainForm previousForm;
        private int counter = 0;
        System.Diagnostics.Stopwatch entropy;
        public BRNGKeyForm(MainForm _previusForm)
        {
            previousForm = _previusForm;
            InitializeComponent();
            entropy = new System.Diagnostics.Stopwatch();
            entropy.Start();
        }

        private void BRNG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (keyFormLabel.Text == e.KeyChar.ToString().ToUpper())
            {
                counter++;
                entropy.Stop();
                previousForm.mainRichTextBox.AppendText(entropy.ElapsedMilliseconds.ToString() + " "); //don't forget to add entropy generator
                Engine.RandomPointGeneratorEngine newChar = new Engine.RandomPointGeneratorEngine();
                keyFormLabel.Text = newChar.GenerateNewChar().ToString();
                entropy.Reset();
                entropy.Start();
                keyFormLabel.Location = newChar.GenerateNewPoint();
            }
                if (counter >9)
                {
                    previousForm.Show();
                    this.Close();
                }
        }
    }
}
