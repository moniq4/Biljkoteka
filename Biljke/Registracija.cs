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
 


namespace Biljke
{
    public partial class Registracija : Form  
   
    {
        public Registracija()
        {
            InitializeComponent(); 
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void Registriraj_se_Click(object sender, EventArgs e)
        {

            if (Ime.Text == "" || Prezime.Text == "" || Email.Text == "" || Lozinka.Text == "")

            {
                RegistracijaPolja reg = new RegistracijaPolja();
                reg.Show();

            }

            else

            {

                var con = DB.GetSqlkonekcija();
                con.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [Registracija] WHERE Email=@email", con);
                command.Parameters.AddWithValue("@email", Email.Text);
                object result = command.ExecuteScalar();
                int Registracija = Convert.ToInt32(result);

                if (Registracija > 0) 
                {
                    RegistracijaEmail regm = new RegistracijaEmail();
                    regm.Show();
                }

                else
                {
                    string query = "INSERT INTO Registracija(ime, prezime, email, lozinka) VALUES ('" + Ime.Text + "', '" + Prezime.Text + "', '" + Email.Text + "', '" + Lozinka.Text + "' )";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    button obj = new button();
                    obj.Show();
                    this.Hide();

                }
                con.Close();
            }
        }

        private void Prijavi_se_Click(object sender, EventArgs e)
        {
            button obj = new button();
            obj.Show();
            this.Hide();
        }
    }
}

