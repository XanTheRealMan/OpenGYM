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
    public partial class NewSubscriptionForm : Form
    {
        public NewSubscriptionForm()
        {
            InitializeComponent();
            this.btnClose.Click += (s, e) => this.Close();
            this.btnSave.Click += (s, e) => this.SaveSubscription();
            this.btnSearchCustomer.Click += (s, e) => this.SearchCustomer();
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

        private void SearchCustomer()
        {

        }

        private void SaveSubscription()
        {
            // Implement the logic to save the subscription details
            // This could involve validating inputs, saving to a database, etc.
            //MessageBox.Show("تم حفظ الاشتراك بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ClearFields();
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

            int newSubscriptionID;
            if (int.TryParse(this.NewSubscriptionID.Text, out newSubscriptionID))
            {
                this.NewSubscriptionID.Text = (newSubscriptionID + 1).ToString();
            }
        }
    }
}
