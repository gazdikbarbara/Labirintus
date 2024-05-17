using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirintus
{
    public partial class FormRestart : Form
    {
        public FormRestart()
        {
            InitializeComponent();
        }

        private void FormRestart_Load(object sender, EventArgs e)
        {
            label1.Text = "Gratulálok, kijutottál! Szeretnéd újrakezdeni?";
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Form1 jatek = new Form1();
            jatek.ShowDialog();
        }
    }
}
