/*
 * Copyright (C) 2025  Anas Yusuf <me@anasov.ly>.
 * 
 * This software is proprietary and is not free or open-source.
 * It is a paid software, and any use, distribution, or modification without a valid license is strictly prohibited.
 * Unauthorized use will result in legal action, including but not limited to lawsuits.  
 * 
 * For licensing inquiries, please contact the software owner.
 */

using Microsoft.VisualBasic.ApplicationServices;
using OpenGYM.Database;

namespace OpenGYM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.btnSubmit.Click += btnSubmitClicked;
            this.btnClose.Click += btnCloseClicked;
        }

        private async void btnSubmitClicked(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();

            if (string.IsNullOrWhiteSpace(loginUsername.Text))
            {
                errorProvider1.SetError(loginUsername, "Please enter your username.");
                return;
            }
            if (string.IsNullOrWhiteSpace(loginPassword.Text))
            {
                errorProvider2.SetError(loginPassword, "Please enter your password.");
                return;
            }

            string username = loginUsername.Text;
            string password = Encryption.Encrypt(loginPassword.Text);

            Database.User user = await Connection.GetUserAsync(username, password);
            if (user == null || user.PasswordHash != password)
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                this.Hide();
            }
        }

        private void btnCloseClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
