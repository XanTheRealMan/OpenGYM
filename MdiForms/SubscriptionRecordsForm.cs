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
        public SubscriptionRecordsForm()
        {
            InitializeComponent();
            this.SubscriptionsTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.SubscriptionsTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.SubscriptionsTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.SubscriptionsTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.SubscriptionsTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.SubscriptionsTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.btnClose.Click += (s, e) => this.Close();
            _ = LoadSubscriptions();
        }

        private async Task LoadSubscriptions()
        {
            try
            {
                var payments = await Connection.LoadPaymentsByCreateDate(DateTime.Today);
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
