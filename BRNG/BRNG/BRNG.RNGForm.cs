using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        BRNG.MainForm previosForm;
        public BRNGForm(BRNG.MainForm form)
        {
            previosForm = form;
            InitializeComponent();
        }

        private void BRNGPicture_Click(object sender, EventArgs e)
        {
            Random rand = new Random();//556; 382
            
            BRNGPicture.Location= new Point(rand.Next(1, 557), rand.Next(1, 382));

        }
    }
}
