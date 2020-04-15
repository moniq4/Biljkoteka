using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Biljke
{
    public partial class Ljekovitost : Form
    {
        public Ljekovitost()
        {
            InitializeComponent();
        }

        private void Profil_Ljekovitost_Click(object sender, EventArgs e)
        {
            Profil obj = new Profil();
            obj.Show();
            this.Hide();

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.info;
            popup.TitleText = "Obavijest o biljkama";
            popup.BodyColor = Color.Green;
            popup.TitleColor = Color.White;
            popup.ContentColor = Color.White;
            popup.ContentText = "Jesi li provjerio/la temperaturu danas?" +
                                "Jesi li zalio / la sve biljke danas ? ";
            popup.Popup();
        }

        private void Unos_Ljekovitost_Click(object sender, EventArgs e)
        {
            UnosBiljke obj = new UnosBiljke();
            obj.Show();
            this.Hide();
        }

        private void Ljekovitost_ljekovitost_Click(object sender, EventArgs e)
        {
            Ljekovitost obj = new Ljekovitost();
            obj.Show();
            this.Hide();
        }

        private void Pregled_Ljekovitost_Click(object sender, EventArgs e)
        {
            Pregled obj = new Pregled();
            obj.Show();
            this.Hide();
        }

        private void Exit_Ljekovitost_Click(object sender, EventArgs e)
        {
            button obj = new button();
            obj.Show();
            this.Hide();
        }

        private void nazivb_Click(object sender, EventArgs e)
        {
            Pregled obj = new Pregled();
            obj.Show();
            this.Hide();
        }

        private void bolestib_Click(object sender, EventArgs e)
        {
            Bolesti obj = new Bolesti();
            obj.Show();
            this.Hide();
        }

        private void Ljekovitost_Load(object sender, EventArgs e)
        {

        }    
    }
}

