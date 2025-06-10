/*
 * Copyright (C) 2025  Anas Yusuf <me@anasov.ly>.
 * 
 * This software is proprietary and is not free or open-source.
 * It is a paid software, and any use, distribution, or modification without a valid license is strictly prohibited.
 * Unauthorized use will result in legal action, including but not limited to lawsuits.  
 * 
 * For licensing inquiries, please contact the software owner.
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
            this.btnSubsRecord.Click += BtnSubsRecordClick;
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
            if (user.Role == "مسؤول")
            {
                this.btnManageUsers.Visible = false;
            }
            else if (user.Role == "موظف")
            {
                this.btnManageUsers.Visible = false;
                this.btnManageSubscriptions.Visible = false;
            }
        }

        private void BtnSubsRecordClick(object? sender, EventArgs e)
        {
            SubscriptionRecordsForm newForm = new SubscriptionRecordsForm(null);
            newForm.MdiParent = this;
            newForm.Show();
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
