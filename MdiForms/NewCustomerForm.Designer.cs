namespace OpenGYM
{
    partial class NewCustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            NewCustomerID = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            CustomerFullName = new TextBox();
            CustomerPhoneNumber = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            CustomerAddress = new TextBox();
            label5 = new Label();
            CustomerEmail = new TextBox();
            label6 = new Label();
            label7 = new Label();
            CustomerGender = new ComboBox();
            label8 = new Label();
            CustomerBirthDate = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 61);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(471, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(121, 61);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(NewCustomerID);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(121, 41);
            panel3.TabIndex = 2;
            // 
            // NewCustomerID
            // 
            NewCustomerID.BorderStyle = BorderStyle.FixedSingle;
            NewCustomerID.Enabled = false;
            NewCustomerID.Location = new Point(39, 10);
            NewCustomerID.Name = "NewCustomerID";
            NewCustomerID.Size = new Size(70, 21);
            NewCustomerID.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F);
            label4.Location = new Point(7, 13);
            label4.Name = "label4";
            label4.Size = new Size(26, 14);
            label4.TabIndex = 14;
            label4.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(168, 23);
            label1.TabIndex = 0;
            label1.Text = "New Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(73, 14);
            label2.TabIndex = 10;
            label2.Text = "Full Name:";
            // 
            // CustomerFullName
            // 
            CustomerFullName.BorderStyle = BorderStyle.FixedSingle;
            CustomerFullName.Location = new Point(93, 81);
            CustomerFullName.Name = "CustomerFullName";
            CustomerFullName.Size = new Size(194, 21);
            CustomerFullName.TabIndex = 11;
            // 
            // CustomerPhoneNumber
            // 
            CustomerPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            CustomerPhoneNumber.Location = new Point(123, 106);
            CustomerPhoneNumber.Name = "CustomerPhoneNumber";
            CustomerPhoneNumber.Size = new Size(164, 21);
            CustomerPhoneNumber.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F);
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(105, 14);
            label3.TabIndex = 12;
            label3.Text = "Phone Number:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 259);
            panel4.Name = "panel4";
            panel4.Size = new Size(592, 47);
            panel4.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSave);
            panel6.Controls.Add(btnCancel);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(422, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(170, 47);
            panel6.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            btnSave.Location = new Point(84, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            btnCancel.Location = new Point(3, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CustomerAddress
            // 
            CustomerAddress.BorderStyle = BorderStyle.FixedSingle;
            CustomerAddress.Location = new Point(374, 107);
            CustomerAddress.Name = "CustomerAddress";
            CustomerAddress.Size = new Size(191, 21);
            CustomerAddress.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F);
            label5.Location = new Point(305, 108);
            label5.Name = "label5";
            label5.Size = new Size(63, 14);
            label5.TabIndex = 22;
            label5.Text = "Address:";
            // 
            // CustomerEmail
            // 
            CustomerEmail.BorderStyle = BorderStyle.FixedSingle;
            CustomerEmail.Location = new Point(356, 81);
            CustomerEmail.Name = "CustomerEmail";
            CustomerEmail.Size = new Size(209, 21);
            CustomerEmail.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F);
            label6.Location = new Point(305, 83);
            label6.Name = "label6";
            label6.Size = new Size(45, 14);
            label6.TabIndex = 20;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F);
            label7.Location = new Point(310, 134);
            label7.Name = "label7";
            label7.Size = new Size(58, 14);
            label7.TabIndex = 24;
            label7.Text = "Gender:";
            // 
            // CustomerGender
            // 
            CustomerGender.FormattingEnabled = true;
            CustomerGender.Location = new Point(374, 132);
            CustomerGender.Name = "CustomerGender";
            CustomerGender.Size = new Size(191, 21);
            CustomerGender.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F);
            label8.Location = new Point(12, 134);
            label8.Name = "label8";
            label8.Size = new Size(75, 14);
            label8.TabIndex = 26;
            label8.Text = "Birth Date:";
            // 
            // CustomerBirthDate
            // 
            CustomerBirthDate.CustomFormat = "dd-MM-yyyy";
            CustomerBirthDate.Format = DateTimePickerFormat.Custom;
            CustomerBirthDate.Location = new Point(93, 132);
            CustomerBirthDate.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            CustomerBirthDate.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            CustomerBirthDate.Name = "CustomerBirthDate";
            CustomerBirthDate.Size = new Size(194, 21);
            CustomerBirthDate.TabIndex = 27;
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 306);
            Controls.Add(CustomerBirthDate);
            Controls.Add(label8);
            Controls.Add(CustomerGender);
            Controls.Add(label7);
            Controls.Add(CustomerAddress);
            Controls.Add(label5);
            Controls.Add(CustomerEmail);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(CustomerPhoneNumber);
            Controls.Add(label3);
            Controls.Add(CustomerFullName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NewCustomerForm";
            ShowIcon = false;
            Text = "New Customer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox CustomerFullName;
        private TextBox NewCustomerID;
        private Label label4;
        private TextBox CustomerPhoneNumber;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnSave;
        private Button btnCancel;
        private TextBox CustomerAddress;
        private Label label5;
        private TextBox CustomerEmail;
        private Label label6;
        private Label label7;
        private ComboBox CustomerGender;
        private Label label8;
        private DateTimePicker CustomerBirthDate;
        private Panel panel6;
    }
}