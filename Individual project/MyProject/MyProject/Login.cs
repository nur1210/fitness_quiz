using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary.Logic;
using ClassLibrary.Models;
using MaterialSkin.Controls;
using MaterialSkin;
using ClassLibrary.DB;

namespace MyProject
{
    public partial class Login : MaterialForm
    {
        private DbLogin dbLogin;
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            dbLogin = new DbLogin();
        }

        private bool ValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "Password") {
                tbxPassword.Text = "";
                tbxPassword.ForeColor = SystemColors.InactiveCaptionText;
                tbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "") {
                tbxPassword.UseSystemPasswordChar = false;
                tbxPassword.Text = "Password";
                tbxPassword.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void tbxEmail_Enter(object sender, EventArgs e)
        {
            if (tbxEmail.Text == "E-mail") {
                tbxEmail.Text = "";
                tbxEmail.ForeColor = SystemColors.InactiveCaptionText;
            }
        }

        private void tbxEmail_Leave(object sender, EventArgs e)
        {
            if (tbxEmail.Text == "") {
                tbxEmail.Text = "E-mail";
                tbxEmail.ForeColor = SystemColors.InactiveCaption;
            }
        }


        private void btnPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            if (tbxEmail.Text == "E-mail" || tbxPassword.Text == "Password")
            {
                MessageBox.Show("Fill all fields!", "Not all fields are filled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidEmail(tbxEmail.Text))
            {
                MessageBox.Show("Email is not valid! Please, input a valid one.", "Not valid email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var email = tbxEmail.Text;
                var password = tbxPassword.Text;
                var id = dbLogin.Login(email, password);
                if (id > -1)
                {
                    MainForm form = new MainForm();
                    form.Show();
                    form.Closed += (s, args) => this.Close();
                    this.Hide();
                }
            }
        }

    }
}
