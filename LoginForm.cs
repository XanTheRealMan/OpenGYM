/*
 * This file is part of OpenGYM.
 * Copyright (C) 2025  Anas Yusuf <anasybal@mail.ru>.
 *
 * OpenGYM is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * OpenGYM is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with OpenGYM. If not, see <https://www.gnu.org/licenses/>.
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
