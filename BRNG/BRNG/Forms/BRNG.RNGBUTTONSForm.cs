using BRNG.Forms;
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
        Engine.RandomPointGeneratorEngine Point;
        Stopwatch entropy;
        MainForm previousForm;
        private BRNGStatistics statistics;

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
            if (entropy.ElapsedMilliseconds % 2 ==0)
            {
                previousForm.mainRichTextBox.AppendText("0 ");
            }
            else
            {
                previousForm.mainRichTextBox.AppendText("1 ");
            }
            
            statistics.LengthOfSeq--;
            BRNGPicture.Location = Point.GenerateNewPoint(this.Size.Height, this.Size.Width);
            entropy.Reset();
            entropy.Start();
            if (statistics.LengthOfSeq == 0)
            {
                this.Close();
                statistics.Close();
                statistics.Dispose();
                previousForm.Show();
            }
        }

        private void BRNGForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Для генерации случайных чисел нажимайте на картинку самолета.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            statistics = new BRNGStatistics((int)previousForm.lengthOfSeqBox.Value);
            statistics.Show();
            statistics.Left += this.Size.Width+statistics.Size.Width;
        }

        private void BRNGForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            statistics.Close();
            statistics.Dispose();
            previousForm.Show();
        }
    }
}
