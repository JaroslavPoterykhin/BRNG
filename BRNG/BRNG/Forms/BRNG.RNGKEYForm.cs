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
        private int lettersCounter = 0;
        private int errorsCounter = 0;
        Engine.RandomPointGeneratorEngine newChar;
        System.Diagnostics.Stopwatch entropy;


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
            if (keyFormLabel.Text == e.KeyChar.ToString().ToUpper())
            {
                lettersCounter++;
                entropy.Stop();
                previousForm.mainRichTextBox.AppendText(entropy.ElapsedMilliseconds.ToString() + " ");
                keyFormLabel.Text = newChar.GenerateNewChar().ToString();
                entropy.Reset();
                entropy.Start();
                keyFormLabel.Location = newChar.GenerateNewPoint(this.Size.Height, this.Size.Width);
            }
            else
            {
                errorsCounter++;
                lettersCounter--;
                if (lettersCounter < 0)
                {
                    MessageBox.Show("Слишком много ошибочных нажатий, попробуйте еще раз!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    previousForm.mainRichTextBox.Clear();
                    previousForm.CheckResultOfGeneration(false);
                    previousForm.Show();
                    this.Close();
                    return;
                }
            }
            if (lettersCounter >= previousForm.lengthOfSeqBox.Value)
            {
                previousForm.Show();
                this.Close();
            }
        }

        private void BRNGKeyForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Нажимайте на клавиатуре клавиши соответстующие показанным на экране.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BRNGStatistics statistics = new BRNGStatistics((int)previousForm.lengthOfSeqBox.Value);
            statistics.Show();
            statistics.Left += 718;
        }

        private void BRNGKeyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            previousForm.Show();
        }
    }
}
