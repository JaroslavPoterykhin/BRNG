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
            BRNG.Engine.BRNGEntropyGenerator generator = new Engine.BRNGEntropyGenerator();
            if (counter < 10)
            {
                
                previousForm.mainRichTextBox.AppendText(generator.Generate(entropy.ElapsedMilliseconds).ToString() + " ");
                counter++;
                BRNGPicture.Location = Point.GenerateNewPoint();
                entropy.Reset();
                entropy.Start();
            }
            else
            {
                this.Close();

                previousForm.Show();
            }
        }
    }
}
