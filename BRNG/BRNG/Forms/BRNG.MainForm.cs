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

        private void GenerateByButtonsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BRNGForm numberGenerator = new BRNGForm(this);
            numberGenerator.Show();
        }

        private void GenerateByLettersButton_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
            {
                InputLanguage.CurrentInputLanguage = language;
            }
            this.Hide();
            BRNG.Forms.BRNGKeyForm numberGeneratorByKeys = new Forms.BRNGKeyForm(this);
            numberGeneratorByKeys.Show();
        }

        private void GenerateByMouseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BRNG.Forms.BRNGMOUSEForm numberGeneratorByMouse = new Forms.BRNGMOUSEForm(this);
            numberGeneratorByMouse.Show();
        }
        public void CheckResultOfGeneration(bool result)
        {
            if (!result)
            {
                MessageBox.Show("Неудачная попытка генерации случайных чисел.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
