using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med_Tech
{
    internal class DataBaseMed
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MCPH5UG;Initial Catalog=Med-Tech_Base;Integrated Security=True;TrustServerCertificate=True");

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
