using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenGYM.Database;
using OpenGYM.Dialogs;

namespace OpenGYM.MdiForms
{
    public partial class NewSubscriptionForm : Form
    {
        private int subCustomerID = -1;
        private string subCustomerName = string.Empty;
        private bool savedAlready = false;
        private Membership? savedSubscription = null;
        private Payment? savedPayment = null;

        public NewSubscriptionForm()
        {
            InitializeComponent();
            this.btnClose.Click += (s, e) => this.Close();
            this.btnSave.Click += (s, e) => this.SaveSubscription();
            this.btnSearchCustomer.Click += (s, e) => this.SearchCustomer();
            this.btnClear.Click += BtnClearClick;
            this.btnPrint.Click += BtnPrintClick;
            this.CustomerName.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true; // Prevents the beep sound
                    this.SearchCustomer();
                }
            };
            this.PaymentMethod.Items.AddRange(new object[]
            {
                "نـقدي",
                "موبي كاش",
                "إدفع لي",
                "يسرباي",
                "وثبة"
            });
            this.PaymentMethod.SelectedIndex = 0;
            this.SubscriptionEndDate.Value = DateTime.Now.AddMonths(1);
            _ = SetNewMembershipIDAsync();
        }

        private void BtnPrintClick(object? sender, EventArgs e)
        {
            // print saved subscription details only
            if (savedAlready && savedSubscription != null && savedPayment != null)
            {
                InvoiceBuilder invoiceBuilder = new InvoiceBuilder(
                    savedSubscription,
                    savedPayment,
                    subCustomerID,
                    subCustomerName
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
            else
            {
                MessageBox.Show("Save the subscription before printing.");
            }
        }

        private void BtnClearClick(object? sender, EventArgs e)
        {
            // check if fields are empty, if not ask for confirmation
            // check if subCustomerID is -1 or subCustomerName is empty
            if (this.subCustomerID == -1 || string.IsNullOrEmpty(this.subCustomerName))
            {
                this.ClearFields();
            }
            else
            {
                var result = MessageBox.Show("Are you sure you want to clear the fields?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.ClearFields();
                }
            }
        }

        private async Task SetNewMembershipIDAsync()
        {
            try
            {
                Membership c = await Connection.GetLastMembershipID();
                this.NewSubscriptionID.Text = (c.MembershipID + 1).ToString();
            }
            catch (Exception ex)
            {
                this.NewSubscriptionID.Text = "1";
            }
        }

        private async void SearchCustomer()
        {
            // search in database for the name and select the most similar one  
            var customers = await Connection.SearchCustomerByName(this.CustomerName.Text);
            if (customers != null && customers.Count > 0)
            {
                // Convert List<CustomerSearch> to List<Customer> if necessary  
                var customerList = customers.Select(c => new Customer
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName
                }).ToList();

                if (customerList.Count == 1)
                {
                    this.subCustomerID = customerList[0].CustomerID;
                    this.subCustomerName = customerList[0].FullName;
                    this.CustomerName.Text = $"{this.subCustomerID} - {this.subCustomerName}";
                }
                else
                {
                    using (var searchForm = new CustomerSearchDialog(customerList))
                    {
                        if (searchForm.ShowDialog() == DialogResult.OK)
                        {
                            this.subCustomerID = searchForm.SelectedCustomer.CustomerID;
                            this.subCustomerName = searchForm.SelectedCustomer.FullName;
                            this.CustomerName.Text = $"{this.subCustomerID} - {this.subCustomerName}";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No customer found with that name.");
            }
        }

        private async void SaveSubscription()
        {
            if(this.subCustomerID == -1 || this.subCustomerName == string.Empty)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            if (this.SubscriptionBeginDate.Value >= this.SubscriptionEndDate.Value)
            {
                MessageBox.Show("The subscription end date must be after the start date.");
                return;
            }

            if (this.PaymentTotal.Value <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.");
                return;
            }

            if (this.savedAlready)
            {
                var result = MessageBox.Show("You have already saved this subscription. Do you want to save it again?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            Membership subscription = new Membership
            {
                MembershipID = int.Parse(this.NewSubscriptionID.Text),
                CustomerID = this.subCustomerID,
                StartDate = this.SubscriptionBeginDate.Value,
                EndDate = this.SubscriptionEndDate.Value,
                IsActive = true
            };

            Payment payment = new Payment
            {
                CustomerID = this.subCustomerID,
                MembershipID = subscription.MembershipID,
                Amount = this.PaymentTotal.Value,
                Notes = GetNotes(),
                PaymentMethod = this.PaymentMethod.SelectedItem.ToString(),
            };

            subscription = await Connection.SaveMembership(subscription);
            payment = await Connection.SavePayment(payment);

            MessageBox.Show("New subscription added successfully!");

            this.savedSubscription = subscription;
            this.savedPayment = payment;

            this.savedAlready = true;
            this.btnPrint.Enabled = true;

            //this.ClearFields();
        }

        private string GetNotes()
        {
            string notes = this.Notes.Text;
            if (string.IsNullOrWhiteSpace(notes))
            {
                return "N/A";
            }
            return notes;
        }

        private void ClearFields()
        {
            this.CustomerName.Text = string.Empty;
            this.SubscriptionBeginDate.Value = DateTime.Now;
            this.SubscriptionEndDate.Value = DateTime.Now.AddMonths(1);
            this.PaymentMethod.SelectedIndex = 0;
            this.PaymentTotal.Value = 0;
            this.Notes.Text = string.Empty;
            this.btnPrint.Enabled = false;

            this.subCustomerID = -1;
            this.subCustomerName = string.Empty;

            this.savedAlready = false;
            this.savedSubscription = null;
            this.savedPayment = null;

            _ = SetNewMembershipIDAsync();
        }
    }
}
