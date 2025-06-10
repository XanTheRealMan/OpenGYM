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
                "ذكر",
                "انثى"
            });
            this.CustomerGender.SelectedIndex = 0;
            this.btnSave.Click += SaveNewCustomer;
            this.btnCancel.Click += (s, e) => this.Close();
        }
        
        private void SaveNewCustomer(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.CustomerFullName.Text)
                || string.IsNullOrWhiteSpace(this.CustomerPhoneNumber.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Customer newCustomer = new Customer
            {
                FullName = this.CustomerFullName.Text,
                Email = GetEmail(),
                Phone = GetPhoneNumber(),
                Address = GetAddress(),
                Gender = GetGender(),
                DateOfBirth = GetDateOfBirth()
            };

            try
            {
                _ = Connection.SaveCustomer(newCustomer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving customer");
                return;
            }

            MessageBox.Show("New customer added successfully!");
            ClearFields();
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
                this.NewCustomerID.Text = "1";
            }
        }

        private string GetPhoneNumber()
        {
            string phoneNumber = this.CustomerPhoneNumber.Text;
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return "N/A";
            }
            return phoneNumber;
        }

        private string GetEmail()
        {
            string email = this.CustomerEmail.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                return "N/A";
            }
            return email;
        }

        private string GetAddress()
        {
            string address = this.CustomerAddress.Text;
            if (string.IsNullOrWhiteSpace(address))
            {
                return "N/A";
            }
            return address;
        }

        private string GetGender()
        {
            string? selectedGender = this.CustomerGender.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedGender))
            {
                return "Male";
            }
            else
            {
                return selectedGender;
            }
        }

        private DateTime GetDateOfBirth()
        {
            // The DateTimePicker.Value property is of type DateTime and cannot be null.
            // Therefore, the null check is unnecessary and has been removed.
            return this.CustomerBirthDate.Value;
        }

        private void ClearFields()
        {
            this.CustomerFullName.Clear();
            this.CustomerEmail.Clear();
            this.CustomerPhoneNumber.Clear();
            this.CustomerAddress.Clear();
            this.CustomerGender.SelectedIndex = 0;
            this.CustomerBirthDate.Value = DateTime.Now;

            int newCustomerID;
            if (int.TryParse(this.NewCustomerID.Text, out newCustomerID))
            {
                this.NewCustomerID.Text = (newCustomerID + 1).ToString();
            }
        }
    }
}
