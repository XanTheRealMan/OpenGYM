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
            this.aboutToolStripMenuItem.Click += (s, e) => MessageBox.Show("OpenGYM - Gym Management System\nVersion 1.0\nDeveloped by Your Name", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.logoutToolStripMenuItem.Click += (s, e) =>
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            };
        }

        private void loadUserData(User user)
        {
            this.currentUserName.Text = user.FullName;
            this.currentUserRole.Text = user.Role;
            this.toolStripStatusLabel.Text = $"logged in as {user.Username}.";
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
