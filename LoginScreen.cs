using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._2
{
    public partial class LoginScreen : Form
    {
        bool successfulLogin = false;
        public LoginScreen()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
        }

        public void ExitApplication(object sender, FormClosingEventArgs e)
        {
            if (!successfulLogin)
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.ToLower() == "teacher" && txtPassword.Text == "Admin")
            {
                successfulLogin = true;
                Close();
            }
            else
                MessageBox.Show("Invalid login.", "Error", MessageBoxButtons.OK);
        }

        private void lblShowHide_Click(object sender, EventArgs e)
        {
            if (lblShowHide.Text == "Show")
            {
                txtPassword.UseSystemPasswordChar = false;
                lblShowHide.Text = "Hide";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                lblShowHide.Text = "Show";
            }
        }
    }
}
