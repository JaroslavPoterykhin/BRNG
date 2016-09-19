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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newBRNGButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BRNGForm numberGenerator = new BRNGForm(this);
            numberGenerator.Show();            
        }
    }
}
