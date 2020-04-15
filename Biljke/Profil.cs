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
using System.IO;

namespace Biljke
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
            label1_Click();
        }

        DataTable dba;
        private void Profil_profil_Click_1(object sender, EventArgs e)
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

        private void Unos_profil_Click_1(object sender, EventArgs e)
        {
            UnosBiljke obj = new UnosBiljke();
            obj.Show();
            this.Hide();
        }

        private void Ljekovitost_profil_Click_1(object sender, EventArgs e)
        {
            Ljekovitost obj = new Ljekovitost();
            obj.Show();
            this.Hide();
        }

        private void Pregled_profil_Click_1(object sender, EventArgs e)
        {
            Pregled obj = new Pregled();
            obj.Show();
            this.Hide();
        }

        private void Exit_profil_Click_1(object sender, EventArgs e)
        {

            button obj = new button();
            obj.Show();
            this.Hide();
        }

        private void Obrisi_profil_Click(object sender, EventArgs e)
        {
            var con = DB.GetSqlkonekcija();
            if (odabranabiljka.Text == "____________")
            {

                BiljkaOdaberi odaberi = new BiljkaOdaberi();
                odaberi.Show();

            }
            else
            {
                con.Open(); 
                SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM unos WHERE naziv ='" + odabranabiljka.Text + "';", con);
                sda.SelectCommand.ExecuteNonQuery();

                this.Hide();
                Profil profil = new Profil();
                profil.Show();

                BiljkaObrisana biljka = new BiljkaObrisana();
                biljka.Show();

            }
            con.Close();
        }


        private void label1_ClientSizeChanged(object sender, EventArgs e)
        {
            label1.Text = PrijavaKorisnika.ime;
        }

        private void label1_Click()
        {

            label1.Text = PrijavaKorisnika.ime;

            var con = DB.GetSqlkonekcija();
            con.Open(); 
            SqlCommand cmd = new SqlCommand("SELECT naziv, Image FROM unos WHERE korisnik='" + PrijavaKorisnika.imePrijavljenog + "'", con);

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
                imageCol = (DataGridViewImageColumn)dataGridView1.Columns[1];
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
        
        private void SearchButton_Click(object sender, EventArgs e)
        {
           var con = DB.GetSqlkonekcija();

           if( odabranabiljka.Text  ==  "____________") {

                BiljkaOdaberi odaberi2 = new BiljkaOdaberi();
                odaberi2.Show();


            }
            else
            { 
                con.Open(); 
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM unos WHERE naziv ='" + odabranabiljka.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                opisbox.Text = dt.Rows[0][1].ToString();
                combovrsta.Text = dt.Rows[0][2].ToString();
                temperatura.Text = dt.Rows[0][4].ToString();
                voda.Text = dt.Rows[0][3].ToString();
                suhabox.Text = dt.Rows[0][6].ToString();
                masnabox.Text = dt.Rows[0][7].ToString();
                izgorjelabox.Text = dt.Rows[0][8].ToString();
                aknebox.Text = dt.Rows[0][9].ToString();
                prehladabox.Text = dt.Rows[0][10].ToString();
                bronhitisbox.Text = dt.Rows[0][11].ToString();
                astmabox.Text = dt.Rows[0][12].ToString();
                upalabox.Text = dt.Rows[0][13].ToString();
                zgaravicabox.Text = dt.Rows[0][14].ToString();
                nadutostbox.Text = dt.Rows[0][15].ToString();
                proljevbox.Text = dt.Rows[0][16].ToString();
                zatvorbox.Text = dt.Rows[0][17].ToString();
                glavoboljabox.Text = dt.Rows[0][18].ToString();
                bolbox.Text = dt.Rows[0][19].ToString();
                zuboboljabox.Text = dt.Rows[0][20].ToString();

                Byte[] data = (Byte[])dt.Rows[0][5];
                MemoryStream mem = new MemoryStream(data);
                slikabox.Image = Image.FromStream(mem);
                
                con.Close();
         
        }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[1].Value;
                MemoryStream ms = new MemoryStream();
                odabranabiljka.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                BiljkeNema nema = new BiljkeNema();
                nema.Show();
            }
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            
        }

    }
}

