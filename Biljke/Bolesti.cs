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
    public partial class Bolesti : Form
    {
        public Bolesti()
        {
            InitializeComponent();
        }

        DataTable dba; 

        private void Profil_bolest_Click(object sender, EventArgs e)
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

        private void Unos_bolest_Click(object sender, EventArgs e)
        {
            UnosBiljke obj = new UnosBiljke();
            obj.Show();
            this.Hide();
        }

        private void Ljekovitost_bolest_Click(object sender, EventArgs e)
        {
            Ljekovitost obj = new Ljekovitost();
            obj.Show();
            this.Hide();
        }

        private void Pregled_bolest_Click(object sender, EventArgs e)
        {
            Pregled obj = new Pregled();
            obj.Show();
            this.Hide();
        }

        private void Exit_bolesti_Click(object sender, EventArgs e)
        {
            button obj = new button();
            obj.Show();
            this.Hide();
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            var con = DB.GetSqlkonekcija();
            con.Open();
            SqlCommand cmd = new SqlCommand("select naziv, vrsta, voda, temperatura, korisnik, image from unos where suhakoza ='" + odabrano.Text +
                "' or masnakoza='" + odabrano.Text + "'or izgorjelakoza='" + odabrano.Text +
                "'or akne='" + odabrano.Text + "'or prehlada='" + odabrano.Text + "'or bronhitis='"
                + odabrano.Text + "'or astma='" + odabrano.Text + "'or upalapluca='" + odabrano.Text
                + "'or zgaravica='" + odabrano.Text + "'or nadutost='" + odabrano.Text + "'or proljev='"
                + odabrano.Text + "'or zatvor='" + odabrano.Text + "'or glavobolja='" + odabrano.Text
                + "'or bolutrbuhu='" + odabrano.Text + "'or zubobolja='" + odabrano.Text + "'", con);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                dba = new DataTable();
                sda.Fill(dba);

                dataGridView1.RowTemplate.Height = 60;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = dba;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
                imageCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                BindingSource source = new BindingSource();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                source.DataSource = dba;
                dataGridView1.DataSource = source;
                sda.Update(dba);
                con.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
     
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            odabrano.Text = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            odabrano.Text = comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabrano.Text = comboBox3.Text;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabrano.Text = comboBox4.Text;
        }  
    }
  }


