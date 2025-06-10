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
    public partial class SubscriptionRecordsForm : Form
    {
        Customer? _customer = null;

        public SubscriptionRecordsForm(Customer? customer = null)
        {
            InitializeComponent();
            this._customer = customer;
            this.SubscriptionsTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.SubscriptionsTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.SubscriptionsTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.SubscriptionsTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.SubscriptionsTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.SubscriptionsTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.btnClose.Click += (s, e) => this.Close();
            this.btnPrint.Click += BtnPrintClick;
            _ = LoadSubscriptions();
        }

        private async void BtnPrintClick(object? sender, EventArgs e)
        {
            try
            {
                if (this.SubscriptionsTable.Rows.Count == 0)
                {
                    MessageBox.Show("No subscriptions to print.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (this.SubscriptionsTable.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a subscription to print.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = this.SubscriptionsTable.SelectedRows[0];

                string? customerName = selectedRow.Cells[1].Value?.ToString();
                if (string.IsNullOrEmpty(customerName))
                {
                    MessageBox.Show("Customer name is missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Membership membership = await Connection.GetMembershipByID(
                    Convert.ToInt32(selectedRow.Cells[0].Value)
                );

                Payment payment = await Connection.GetPaymentByMembershipID(
                    Convert.ToInt32(selectedRow.Cells[0].Value)
                );

                InvoiceBuilder invoiceBuilder = new InvoiceBuilder(
                    membership,
                    payment,
                    membership.CustomerID,
                    customerName
                );
                try
                {
                    invoiceBuilder.GenerateInvoice();
                    //invoiceBuilder.SaveInvoice();  
                    invoiceBuilder.PreviewInvoice();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error generating invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadSubscriptions()
        {
            try
            {
                List<Payment> payments;
                if(this._customer != null)
                {
                    payments = await Connection.LoadPaymentsByCustomerID(this._customer.CustomerID);
                }
                else
                {
                    payments = await Connection.LoadPaymentsByCreateDate(DateTime.Today);
                }
                if (payments.Count == 0)
                {
                    MessageBox.Show("No subscriptions found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.SubscriptionsTable.Rows.Clear();
                    foreach (var paym in payments)
                    {
                        Customer customer = await Connection.GetCustomerByID(paym.CustomerID);
                        Membership membership = await Connection.GetMembershipByID(paym.MembershipID);
                        if (customer == null || membership == null)
                        {
                            continue; // Skip if customer or membership is not found
                        }
                        int rowIndex = this.SubscriptionsTable.Rows.Add();
                        var row = this.SubscriptionsTable.Rows[rowIndex];
                        row.Cells[0].Value = paym.MembershipID;
                        row.Cells[1].Value = customer.FullName;
                        row.Cells[2].Value = membership.StartDate.ToShortDateString();
                        row.Cells[3].Value = membership.EndDate.ToShortDateString();
                        row.Cells[4].Value = paym.Amount.ToString("C2");
                        row.Cells[5].Value = paym.Notes.Replace("N/A", "لا يوجد");
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
