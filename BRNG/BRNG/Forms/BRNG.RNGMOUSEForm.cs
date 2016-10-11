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
        private int counter;
        public BRNGMOUSEForm(MainForm _PreviusForm)
        {
            previusForm = _PreviusForm;
            InitializeComponent();
            controler = new Stopwatch();
            controler.Start();
        }

        private void mouseFormPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (controler.Elapsed.TotalSeconds > 1)
            {
                controler.Reset();
                counter++;  
                int cursorX = Cursor.Position.X;
                int cursorY = Cursor.Position.Y;
                previusForm.mainRichTextBox.AppendText((cursorX*cursorY).ToString()+ "  ");
                controler.Start();
                BRNGMouseFormProgressBar.Value = counter;
            }
            if (counter >9)
            {
                this.Close();
                previusForm.Show();
            }
        }

        //private void mouseFormPictureBox_MouseHover(object sender, EventArgs e)
        //{
        //    int cursorX = Cursor.Position.X;
        //    int cursorY = Cursor.Position.Y;
        //    previusForm.mainRichTextBox.AppendText(cursorX.ToString() + ", " + cursorY.ToString());

        //}
    }
}
