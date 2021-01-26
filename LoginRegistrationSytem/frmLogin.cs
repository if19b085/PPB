using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace LoginRegistrationSytem
{
    public partial class frmLogin : Form
    {
        NpgsqlConnection connect = new NpgsqlConnection(@"Server=localhost;port=5432;user id=postgres; password=password; database=PPB");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            ///SINGLETON SINGLETON!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            new frmRegister().Show();
            this.Hide();
            ///SINGLETON SINGLETON!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        }

        private void label4_Click(object sender, EventArgs e)
        {
            ///SINGLETON SINGLETON!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            new frmRegister().Show();
            this.Hide();
            ///SINGLETON SINGLETON!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect.Open();
            string query = "SELECT COUNT(*) from public.users WHERE username = @username AND password = @password";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
            cmd.Parameters.AddWithValue("username", txtUsername.Text);
            ///!!!!!!!!!!!!!!!!!!!!PASSWORD HASHING!!!!!!!!!!!!!!!!!!!!)
            cmd.Parameters.AddWithValue("password", txtPassword.Text);
            int n = cmd.ExecuteNonQuery();
            NpgsqlDataReader reader = cmd.ExecuteReader();
            int login = 0;
            while (reader.Read())
            {
                login = reader.GetInt32(0);
            }
            connect.Close();
            
            if(login == 1)
            {
                MessageBox.Show("You´ve been logged in successfully.", "Registration Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login didn´t work.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
