using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homepage_admin
{
    public partial class logout : Form
    {
        public logout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login log = new login();
            //this.Hide();
            //log.Show();

        }

        private void logout_Load(object sender, EventArgs e)
        {
            using NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=12345678; Database=Jecation");
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            string sql = "SELECT username_akun FROM akun WHERE role = admin";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            NpgsqlDataAdapter rd = new NpgsqlDataAdapter();
            label7.Text = sql;

            cmd.Dispose();
            con.Close();
        }
    }
}
