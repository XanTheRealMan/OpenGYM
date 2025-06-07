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

namespace OpenGYM.MdiForms
{
    public partial class SearchCustomerForm : Form
    {
        public SearchCustomerForm()
        {
            InitializeComponent();
            this.CustomersTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomersTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    SearchCustomer(s, e);
                }
            };
            this.btnClose.Click += (s, e) => this.Close();
            this.btnSearch.Click += SearchCustomer;
        }

        private async void SearchCustomer(object? sender, EventArgs e)
        {
            string Name = this.CustomerName.Text.Trim();
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Please enter a search term.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var customers = await Connection.SearchCustomerByName(Name);
                //this.CustomersTable.DataSource = customers;
                if (customers.Count == 0)
                {
                    MessageBox.Show("No customers found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.CustomersTable.Rows.Clear();
                    foreach (var customer in customers)
                    {
                        int rowIndex = this.CustomersTable.Rows.Add();
                        var row = this.CustomersTable.Rows[rowIndex];
                        row.Cells[0].Value = customer.CustomerID;
                        row.Cells[1].Value = customer.FullName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
