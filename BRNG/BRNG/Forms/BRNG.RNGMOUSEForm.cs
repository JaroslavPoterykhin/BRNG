using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        private List<PictureBox> trace;
        private Bitmap saveTrace;
        public BRNGMOUSEForm(MainForm _PreviusForm)
        {
            previusForm = _PreviusForm;
            InitializeComponent();
            this.BRNGMouseFormProgressBar.Maximum = (int)previusForm.lengthOfSeqBox.Value;
            controler = new Stopwatch();
            controler.Start();
            var pixel = new Bitmap (1, 1);
            pixel.SetPixel(0, 0, Color.White);
            saveTrace = new Bitmap(pixel, mouseFormPictureBox.Width, mouseFormPictureBox.Height);
            
            trace = new List<PictureBox>();
        }

        private void mouseFormPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            int cursorX = e.Location.X;
            int cursorY = e.Location.Y;
            ShowLocationOnScreen(cursorX, cursorY, false);
            if (counter >= previusForm.lengthOfSeqBox.Value)
            {
                var path = Directory.GetCurrentDirectory();
                path += "trace.jpeg";
                saveTrace.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
                this.Close();
                previusForm.Show();
            }
            if (controler.Elapsed.Milliseconds > 500)
            {

                counter++;


                ShowLocationOnScreen(cursorX, cursorY, true);
                previusForm.mainRichTextBox.AppendText((cursorX * cursorY).ToString() + "  ");



                controler.Reset();
                controler.Start();
                BRNGMouseFormProgressBar.Value = counter;
            }

        }

        private void ShowLocationOnScreen(int cursorX, int cursorY, bool show)
        {
            locationOfMause = new PictureBox();
            locationOfMause.Location = new Point(
                cursorX,
                cursorY
                );
            locationOfMause.Size = new System.Drawing.Size(5, 5);
            locationOfMause.BackColor = Color.Red;

            locationOfMause.Visible = show ? true : false;
            locationOfMause.BringToFront();
            locationOfMause.Name = "locaton" + cursorX.ToString();
            locationOfMause.Parent = mouseFormPictureBox;
            mouseFormPictureBox.SendToBack();
            mouseFormPictureBox.Controls.Add(locationOfMause);
            mouseFormPictureBox.Invalidate();

            locationOfMause.DrawToBitmap(saveTrace, new Rectangle(new Point(cursorX, cursorY), new Size(5,5)));

        }

        private void BRNGMOUSEForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Для генерации случайных чисел перемещайте курсор мыши над картинкой.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BRNGMOUSEForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            previusForm.Show();
        }
    }
}
