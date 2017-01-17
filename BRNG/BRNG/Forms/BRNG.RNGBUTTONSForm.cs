using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRNG
{
    public partial class BRNGForm : Form
    {
        private bool clicked = false;
        public bool Clicked
        {
            get { return clicked; }
            set { clicked = value; }
        }
        private int counter = 0;
        Engine.RandomPointGeneratorEngine Point;
        Stopwatch entropy;
        MainForm previousForm;
        public BRNGForm(MainForm form)
        {
            InitializeComponent();
            entropy = new Stopwatch();
            previousForm = form;
            Point = new Engine.RandomPointGeneratorEngine();
            entropy.Start();
        }

        private void BRNGPicture_Click(object sender, EventArgs e)
        {
            entropy.Stop();

            if (counter < 10)
            {
                previousForm.mainRichTextBox.AppendText((entropy.ElapsedMilliseconds).ToString() + " ");
                counter++;
                BRNGPicture.Location = Point.GenerateNewPoint(this.Size.Height, this.Size.Width);
                entropy.Reset();
                entropy.Start();
            }
            else
            {
                this.Close();
                previousForm.Show();
            }
        }

        private void BRNGForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Click on picture of plane to generate random numbers .", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BRNGForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            previousForm.Show();
        }
    }
}
