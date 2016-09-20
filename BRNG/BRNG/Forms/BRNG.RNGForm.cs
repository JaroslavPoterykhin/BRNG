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
        MainForm previosForm;
        public BRNGForm(MainForm form)
        {
            InitializeComponent();
            entropy = new Stopwatch();
            previosForm = form;
            Point = new Engine.RandomPointGeneratorEngine();
            entropy.Start();
        }

        private void BRNGPicture_Click(object sender, EventArgs e)
        {
            entropy.Stop();
                   
            if (counter < 10)
            {
                previosForm.mainRichTextBox.AppendText(entropy.ElapsedMilliseconds.ToString()+ " ");
                counter++;
                BRNGPicture.Location = Point.GenerateNewPoint();
                entropy.Reset();
                entropy.Start();
            }
            else
            {
                this.Close();
                
                previosForm.Show();
            }
        }
    }
}
