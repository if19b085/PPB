using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add Code importing POSTGRESQL Connect

namespace LoginRegistrationSytem
{
    public partial class frmRegister : Form
    {
        //Connect to POSTGRESQL

        public frmRegister()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and Password Fields are empty", "Registration Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPassword.Text == txtComPassword.Text)
            {
                //Open POSTRESQL Connection
                //Code INSERT function for Username and Password
                //Close POSTRESQL Connection

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";

                MessageBox.Show("Your Account has been created successfully.", "Registration Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
                txtComPassword.Focus();
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ///SINGLETON SINGLETON!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            new frmLogin().Show();
            this.Hide();
            ///SINGLETON SINGLETON!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ///SINGLETON SINGLETON!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            new frmLogin().Show();
            this.Hide();
            ///SINGLETON SINGLETON!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }
    }
}
