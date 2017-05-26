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

namespace BRNG.Forms
{
    public partial class BRNGMOUSEForm : Form
    {
        private MainForm previusForm;
        private Stopwatch controler;
        private PictureBox locationOfMause;
        private int counter;
        public BRNGMOUSEForm(MainForm _PreviusForm)
        {
            previusForm = _PreviusForm;
            InitializeComponent();
            this.BRNGMouseFormProgressBar.Maximum = (int)previusForm.lengthOfSeqBox.Value;
            controler = new Stopwatch();
            controler.Start();

        }

        private void mouseFormPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (counter >= previusForm.lengthOfSeqBox.Value)
            {
                this.Close();
                previusForm.Show();
            }
            if (controler.Elapsed.TotalSeconds > 1)
            {
               
                counter++;
                int cursorX = e.Location.X;
                int cursorY = e.Location.Y;
                
                previusForm.mainRichTextBox.AppendText((cursorX * cursorY).ToString() + "  ");
                
                
                ShowLocationOnScreen(cursorX, cursorY);
                controler.Reset();
                controler.Start();
                BRNGMouseFormProgressBar.Value = counter;
            }

        }

        private void ShowLocationOnScreen(int cursorX, int cursorY)
        {
            locationOfMause = new PictureBox();
            locationOfMause.Location = new Point(
                cursorX,
                cursorY
                );
            locationOfMause.Size = new System.Drawing.Size(5, 5);
            locationOfMause.BackColor = Color.Red;
            locationOfMause.Visible = true;
            locationOfMause.BringToFront();
            locationOfMause.Name = "locaton" + cursorX.ToString();
            locationOfMause.Parent = mouseFormPictureBox;
            mouseFormPictureBox.SendToBack();
            mouseFormPictureBox.Controls.Add(locationOfMause);
            mouseFormPictureBox.Invalidate();
        }

        private void BRNGMOUSEForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Для генерации случайных чисел перемещайте курсор мыши над картинкой." , "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BRNGMOUSEForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            previusForm.Show();
        }
    }
}
