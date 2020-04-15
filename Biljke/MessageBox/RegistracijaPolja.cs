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
    public partial class RegistracijaPolja : Form
    {
        public RegistracijaPolja()
        {
            InitializeComponent();
        }

        private void min_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Polja_uredu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
