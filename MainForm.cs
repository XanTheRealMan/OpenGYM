/*
 * This file is part of OpenGYM.
 * Copyright (C) 2025  Anas Yusuf <itz.anasov@gmail.com>.
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenGYM.Database;
using OpenGYM.MdiForms;

namespace OpenGYM
{
    public partial class MainForm : Form
    {
        public MainForm(User user)
        {
            InitializeComponent();
            loadUserData(user);
            this.btnNewCustomer.Click += BtnNewCustomerClick;
            this.btnNewSubscription.Click += BtnNewSubscriptionClick;
            this.btnSearchCustomer.Click += BtnSearchCustomerClick;
            this.closeAllToolStripMenuItem.Click += CloseAllForms;
            this.exitToolStripMenuItem.Click += (s, e) => Application.Exit();
            this.aboutToolStripMenuItem.Click += (s, e) => MessageBox.Show("OpenGYM - Gym Management System\nVersion 1.0\nDeveloped by Anas Yusuf.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.logoutToolStripMenuItem.Click += (s, e) =>
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            };
            this.toolStripStatusLabel.Font = new Font("HONOR Sans Arabic UI R", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void loadUserData(User user)
        {
            this.currentUserName.Text = user.FullName;
            this.currentUserRole.Text = user.Role;
            this.toolStripStatusLabel.Text = $"المستخدم الحالي :  {user.Username} - ({user.Role})";
        }

        private void CloseAllForms(object? sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void BtnNewCustomerClick(object? sender, EventArgs e)
        {
            NewCustomerForm newForm = new NewCustomerForm();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void BtnNewSubscriptionClick(object? sender, EventArgs e)
        {
            NewSubscriptionForm newForm = new NewSubscriptionForm();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void BtnSearchCustomerClick(object? sender, EventArgs e)
        {
            SearchCustomerForm searchForm = new SearchCustomerForm();
            searchForm.MdiParent = this;
            searchForm.Show();
        }
    }
}
