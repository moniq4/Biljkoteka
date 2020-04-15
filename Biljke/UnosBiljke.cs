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
using System.IO;
using Tulpep.NotificationWindow;

namespace Biljke
{

    public partial class UnosBiljke : Form
    {
        public UnosBiljke()
        {
            InitializeComponent();
            label8_Click();
        }

        string vrsta;
        string suhakoza;
        string masnakoza;
        string izgorjelakoza;
        string akne;
        string prehlada;
        string bronhitis;
        string astma;
        string upalapluca;
        string zgaravica;
        string nadutost;
        string proljev;
        string zatvor;
        string glavobolja;
        string bolutrbuhu;
        string zubobolja;

        private void Profil_unos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profil profil = new Profil();
            profil.Show();

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

        private void Unos_unos_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosBiljke biljke = new UnosBiljke();
            biljke.Show();
        }

        private void Ljekovitost_unos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ljekovitost profil = new Ljekovitost();
            profil.Show();
        }

        private void Pregled_unos_Click(object sender, EventArgs e)
        {

            this.Hide();
            Pregled profil = new Pregled();
            profil.Show();
        }

        private void Exit_unos_Click(object sender, EventArgs e)
        {

            this.Hide();
            button profil = new button();
            profil.Show();
        }

        private void ButtonSpremi_Click(object sender, EventArgs e)
        {

            if (opis.Text == "" || naziv.Text == "" || vrsta != "Cvjetnica" && vrsta != "Bezcvjetnica")
            {
                RegistracijaPolja reg = new RegistracijaPolja();
                reg.Show();

            }

            else
            {

                var con = DB.GetSqlkonekcija();

                con.Open();

                byte[] images = null;
                if (imgLocation == "")
                {

                    BiljkaSlika biljka = new BiljkaSlika();
                    biljka.Show();
                }
                
                else
                {
                    FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Stream);
                    images = brs.ReadBytes((int)Stream.Length);

                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [unos] WHERE naziv=@naziv", con);
                    command.Parameters.AddWithValue("@naziv", naziv.Text);
                    object result = command.ExecuteScalar();


                    int unos_biljke = Convert.ToInt32(result);


                    if (unos_biljke > 0)
                    {
                        BiljkaPostoji biljka = new BiljkaPostoji();
                        biljka.Show();
                    }

                    else
                    {
                       
                        string query = "INSERT INTO unos(naziv, opis, vrsta, temperatura, voda, suhakoza, masnakoza, izgorjelakoza, akne, prehlada, bronhitis, astma, upalapluca, zgaravica, nadutost, proljev, zatvor, glavobolja, bolutrbuhu, zubobolja, korisnik, Image) " +
                           "VALUES " + "('" + naziv.Text + "', '" + opis.Text + "','" + vrsta + "' ,'" + temperatura.Text + "','" + voda.Text + "', '" + suhakoza + "','" + masnakoza + "','"
                           + izgorjelakoza + "','" + akne + "' , '" + prehlada + "','" + bronhitis + "' , '" + astma + "' , '" + upalapluca + "','" + zgaravica + "','"
                           + nadutost + "','" + proljev + "','" + zatvor + "','" + glavobolja + "','" + bolutrbuhu + "','" + zubobolja + "','" + label8.Text + "', @images)";

                        SqlCommand cmd = new SqlCommand(query, con);
                        
                        cmd.Parameters.Add(new SqlParameter("@images", images));
                        int N = cmd.ExecuteNonQuery();

                        this.Hide();
                        Profil profil = new Profil();
                        profil.Show();
                        BiljkaDodajcs biljka = new BiljkaDodajcs();
                        biljka.Show();

                    }

                    con.Close();
                }
            }
        }

        private void ButtonOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosBiljke unos = new UnosBiljke();
            unos.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            vrsta = "Cvjetnica";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            vrsta = "Bezcvjetnica";
        }

        string imgLocation = "";
        private void Browsebutton_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files (*.jpg) |*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {            
                imgLocation = dialog.FileName.ToString();
                slikabox.ImageLocation = imgLocation;
            }

        }
      
        private void suhakoza_CheckedChanged(object sender, EventArgs e)
        {
            suhakoza = "Suha koža";
        }

        private void masnaKoza_CheckedChanged(object sender, EventArgs e)
        {
            masnakoza = "Masna koža";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            izgorjelakoza = "Izgorjela koža";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            akne = "Akne";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            prehlada = "Prehlada";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            bronhitis = "Bronhitis";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            astma = "Astma";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            upalapluca = "Upala pluća";
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            zgaravica = "Žgaravica";
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            nadutost = "Nadutost";
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            proljev = "Proljev";
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            zatvor = "Zatvor";
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            glavobolja = "Glavobolja";
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            bolutrbuhu = "Bol u trbuhu";
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            zubobolja = " Zubobolja";
        }

        private void label8_ClientSizeChanged(object sender, EventArgs e)
        {
            label8.Text = PrijavaKorisnika.imePrijavljenog;
        }

        private void label8_Click()
        {
            label8.Text = PrijavaKorisnika.imePrijavljenog;
        }

        private void label8_ContextMenuStripChanged(object sender, EventArgs e)
        {
            label8.Text = PrijavaKorisnika.imePrijavljenog;
        }
    }
}

