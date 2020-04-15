using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biljke
{
    static class DB
    {
        public static SqlConnection GetSqlkonekcija()
        {
            return new SqlConnection(@"Data Source=DESKTOP-T2PR5V6;Initial Catalog=Biljkoteka;Integrated Security=True");
        }
    }
}
