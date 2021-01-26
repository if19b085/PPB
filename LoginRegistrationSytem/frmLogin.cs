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
    public partial class frmLogin : Form
    {
        //Connect to POSTGRESQL
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
            //Open POSTRESQL Connection
            //Code SELECT function for Username and Password
                //Some kind of Login Funtion needed
            //Close POSTRESQL Connection

            //Show Dashboard
        }
    }
}
