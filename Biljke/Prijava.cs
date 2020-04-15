using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace Biljke
{
    public partial class button : Form
    {
        public button()
        { 
            InitializeComponent();
        }

        private void registr_Click(object sender, EventArgs e)
        {
            Registracija obj = new Registracija();
            obj.Show();
            this.Hide();
        }

        private void Prijava_Click(object sender, EventArgs e)
        {
            if (Email.Text == "" || Lozinka.Text == "") 
            {
                RegistracijaPolja reg = new RegistracijaPolja();
                reg.Show();
            }

            else
            {
                var con = DB.GetSqlkonekcija();
                con.Open();

                string query = "Select * from Registracija where Email= '" + Email.Text + "' and Lozinka = '" + Lozinka.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader nadi = cmd.ExecuteReader();

                if (nadi.Read())
                {
                    PrijavaKorisnika.imePrijavljenog = (string)nadi["Email"];
                    PrijavaKorisnika.ime = (string)nadi["Ime"];

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
                else
                {
                    PrijavaPopuni prijava = new PrijavaPopuni();
                    prijava.Show();
                    Email.Clear();
                    Lozinka.Clear();
                }

                con.Close();
            }
        }
    }

}
