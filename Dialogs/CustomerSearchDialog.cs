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

namespace OpenGYM.Dialogs
{
    public partial class CustomerSearchDialog : Form
    {
        public CustomerSearch SelectedCustomer;

        public CustomerSearchDialog(List<Customer> Customers)
        {
            InitializeComponent();
            this.CustomersTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomersTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.CustomersTable.SelectionChanged += RowSelected;
            this.CustomersTable.CellDoubleClick += BtnOKClick;
            this.btnOK.Click += BtnOKClick;
            this.btnCancel.Click += BtnCancelClick; ;
            ListCustomers(Customers);
        }

        private void BtnCancelClick(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnOKClick(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RowSelected(object? sender, EventArgs e)
        {
            if (this.CustomersTable.SelectedRows.Count > 0)
            {
                var selectedRow = this.CustomersTable.SelectedRows[0];
                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[1].Value != null)
                {
                    SelectedCustomer = new CustomerSearch
                    {
                        CustomerID = (int)selectedRow.Cells[0].Value,
                        FullName = selectedRow.Cells[1].Value.ToString()!
                    };
                }
            }
        }

        private void ListCustomers(List<Customer> Customers)
        {
            foreach (var customer in Customers)
            {
                int rowIndex = this.CustomersTable.Rows.Add();
                var row = this.CustomersTable.Rows[rowIndex];
                row.Cells[0].Value = customer.CustomerID;
                row.Cells[1].Value = customer.FullName;
            }
        }
    }
}
