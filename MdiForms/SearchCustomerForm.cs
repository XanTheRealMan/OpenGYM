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

namespace OpenGYM.MdiForms
{
    public partial class SearchCustomerForm : Form
    {
        public SearchCustomerForm()
        {
            InitializeComponent();
            this.CustomersTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomersTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.CustomersTable.MouseClick += CustomersTableMouseClick;
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

        private void CustomersTableMouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = this.CustomersTable.HitTest(e.X, e.Y).RowIndex;
                if (this.CustomersTable.SelectedRows.Count > 0 && currentMouseOverRow >= 0)
                {
                    ContextMenuStrip m = new ContextMenuStrip();
                    m.Items.Add("عرض سجل الإشتراكات");
                    //m.Items.Add("تعديل البيانات");

                    m.Show(this.CustomersTable, new Point(e.X, e.Y));

                    m.ItemClicked += async (object? sender, ToolStripItemClickedEventArgs e) =>
                    {
                        if (e.ClickedItem.Text == "عرض سجل الإشتراكات")
                        {
                            if (this.CustomersTable.SelectedRows.Count > 0)
                            {
                                int customerId = Convert.ToInt32(this.CustomersTable.SelectedRows[0].Cells[0].Value);
                                Customer c = await Connection.GetCustomerByID(customerId);
                                SubscriptionRecordsForm form = new SubscriptionRecordsForm(c);
                                form.ShowDialog();
                            }
                        }
                        //else if (e.ClickedItem.Text == "تعديل البيانات")
                        //{
                        //    if (this.CustomersTable.SelectedRows.Count > 0)
                        //    {
                        //        int customerId = Convert.ToInt32(this.CustomersTable.SelectedRows[0].Cells[0].Value);
                        //        CustomerEditForm form = new CustomerEditForm(customerId);
                        //        form.ShowDialog();
                        //    }
                        //}
                    };
                }
            }
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
