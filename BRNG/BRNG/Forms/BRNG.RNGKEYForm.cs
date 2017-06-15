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
        Engine.RandomPointGeneratorEngine newChar;
        System.Diagnostics.Stopwatch entropy;
        private BRNGStatistics statistics;

        public BRNGKeyForm(MainForm _previusForm)
        {
            newChar = new Engine.RandomPointGeneratorEngine();
            previousForm = _previusForm;
            InitializeComponent();
            entropy = new System.Diagnostics.Stopwatch();
            entropy.Start();
        }

        private void BRNG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.Equals(keyFormLabel.Text, e.KeyChar.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                statistics.LengthOfSeq = statistics.LengthOfSeq - 1;
                entropy.Stop();
                if (entropy.ElapsedMilliseconds % 2 ==0)
                {
                    previousForm.mainRichTextBox.AppendText("0 ");
                }
                else
                {
                    previousForm.mainRichTextBox.AppendText("1 ");
                }
                keyFormLabel.Text = newChar.GenerateNewChar().ToString();
                entropy.Reset();
                entropy.Start();
                keyFormLabel.Location = newChar.GenerateNewPoint(this.Size.Height, this.Size.Width);
            }
            else
            {
                statistics.ErrorsCounter++;
                statistics.LengthOfSeq = statistics.LengthOfSeq + 1;
                if (statistics.ErrorsCounter > 5)
                {
                    MessageBox.Show("Слишком много ошибочных нажатий, попробуйте еще раз!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    previousForm.mainRichTextBox.Clear();
                    previousForm.CheckResultOfGeneration(false);
                    previousForm.Show();
                    this.Close();
                }
            }
            if (statistics.LengthOfSeq ==0 )
            {
                CustomClose(false);
            }
        }

        private void BRNGKeyForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Нажимайте на клавиатуре клавиши соответстующие показанным на экране.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            statistics = new BRNGStatistics((int)previousForm.lengthOfSeqBox.Value);
            statistics.Show();
            statistics.Left += this.Size.Width;
        }

        private void BRNGKeyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomClose(true);
        }
        private void CustomClose(bool closed)
        {
            if (!closed)
            {
                this.Close();
            }
            statistics.Close();
            statistics.Dispose();
            previousForm.Show();
        }
    }
}
