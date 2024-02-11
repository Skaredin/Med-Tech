using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Drawing;


namespace Med_Tech
{
    public partial class Avtarizacia : Form
    {
        DataBaseMed baseMed = new DataBaseMed();
        public Avtarizacia()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoginTextBox.MaxLength = 50;
            PassvordTextBox.MaxLength = 50;
        }
        private void Shifr(object sender, EventArgs e)
        {
          
          

        }
        private void Avtorizacia1_Click(object sender, EventArgs e)
        {
            var Login = LoginTextBox.Text;
            var Passvord = PassvordTextBox.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();


            string querys = $"select id_Profile, login, password from Profile where login='{Login}' and password = '{Passvord}'";
            SqlCommand conn = new SqlCommand(querys, baseMed.getConnection());

            adapter.SelectCommand = conn;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Успешный вход!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { }


        }

        private void Skrit_parol_Click(object sender, EventArgs e)
        {
            
        }
    }
}
