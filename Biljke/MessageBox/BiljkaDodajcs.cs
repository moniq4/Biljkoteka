using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biljke
{
    public partial class BiljkaDodajcs : Form
    {
        public BiljkaDodajcs()
        {
            InitializeComponent();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dodaj_uredu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
