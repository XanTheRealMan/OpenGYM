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

namespace OpenGYM
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
            _ = SetNewCustomerIDAsync();
            this.CustomerGender.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CustomerGender.Items.AddRange(new object[] {
                "Male",
                "Female"
            });
            this.CustomerGender.SelectedIndex = 0;
            this.btnSave.Click += SaveNewCustomer;
        }

        private void SaveNewCustomer(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.CustomerFullName.Text) ||
                string.IsNullOrWhiteSpace(this.CustomerEmail.Text) ||
                string.IsNullOrWhiteSpace(this.CustomerPhoneNumber.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Customer newCustomer = new Customer
            {
                FullName = this.CustomerFullName.Text,
                Email = this.CustomerEmail.Text,
                Phone = this.CustomerPhoneNumber.Text,
                Address = this.CustomerAddress.Text,
                Gender = this.CustomerGender.SelectedItem.ToString(),
                DateOfBirth = this.CustomerBirthDate.Value
            };
            Connection.SaveCustomer(newCustomer);
            MessageBox.Show("New customer added successfully!");
            this.Close();
        }

        private async Task SetNewCustomerIDAsync()
        {
            try
            {
                Customer c = await Connection.GetLastCustomerID();
                this.NewCustomerID.Text = (c.CustomerID + 1).ToString();
            }
            catch (Exception ex)
            {
                this.NewCustomerID.Text = "0";
            }
        }
    }
}
