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
    
    public partial class Pregled : Form
    {
        public Pregled()
        {
            InitializeComponent();

        }
       
        DataTable dba; 

        private void Profil_Pregled_Click(object sender, EventArgs e)
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

        private void Unos_Profil_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosBiljke profil = new UnosBiljke();
            profil.Show();
        }

        private void Ljekovitost_Pregled_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ljekovitost profil = new Ljekovitost();
            profil.Show();
        }

        private void Pregled_pregled_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pregled profil = new Pregled();
            profil.Show();
        }

        private void Exit_Pregled_Click(object sender, EventArgs e)
        {
            this.Hide();
            button profil = new button();
            profil.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            var con = DB.GetSqlkonekcija();

            if (nazivbox1.Text == "Unesi naziv biljke")
            {
                BiljkeUnesi biljkaunos = new BiljkeUnesi();
                biljkaunos.Show();
            }

            else
            {  con.Open(); 
               SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM unos WHERE naziv ='" + nazivbox1.Text + "'", con);
               DataTable dt = new DataTable();

               sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
               nazivbox1.Text = dt.Rows[0][0].ToString();
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

            else
            {
               BiljkaNepostoji biljkaunos = new BiljkaNepostoji();
               biljkaunos.Show();
            }
            
            }

            }
  
        private void AllButton_Click(object sender, EventArgs e) 
        {
            var con = DB.GetSqlkonekcija();
            con.Open(); 
            SqlCommand cmd = new SqlCommand("select naziv, korisnik, image from unos;", con);

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
                imageCol = (DataGridViewImageColumn)dataGridView1.Columns[2];
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

        private void Pregled_Load(object sender, EventArgs e) 
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[2].Value;
                MemoryStream ms = new MemoryStream();

                nazivbox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }

            catch (Exception)
            {
                BiljkePrikazi prikazisve = new BiljkePrikazi();
                prikazisve.Show(); 
            }
        }

        private void nazivbox1_Click(object sender, EventArgs e)
        {
           nazivbox1.Clear();
           nazivbox1.ForeColor = Color.Black;
        }
    }
}
