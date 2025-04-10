using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenGYM.MdiForms;

namespace OpenGYM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.btnNewCustomer.Click += BtnNewCustomerClick;
            this.btnNewSubscription.Click += BtnNewSubscriptionClick;
            this.btnSearchCustomer.Click += BtnSearchCustomerClick;
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
