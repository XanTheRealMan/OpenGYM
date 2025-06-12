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
            panel5 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            NewCustomerID = new TextBox();
            label4 = new Label();
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
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 70);
            panel1.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(241, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(351, 70);
            panel5.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("HONOR Sans Arabic UI B", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(351, 70);
            label1.TabIndex = 2;
            label1.Text = "تسجيل عميل جديد";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(121, 70);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(NewCustomerID);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(121, 47);
            panel3.TabIndex = 2;
            // 
            // NewCustomerID
            // 
            NewCustomerID.BorderStyle = BorderStyle.FixedSingle;
            NewCustomerID.Enabled = false;
            NewCustomerID.Location = new Point(12, 10);
            NewCustomerID.Name = "NewCustomerID";
            NewCustomerID.Size = new Size(70, 23);
            NewCustomerID.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("HONOR Sans Arabic UI R", 9F);
            label4.Location = new Point(88, 15);
            label4.Name = "label4";
            label4.Size = new Size(30, 17);
            label4.TabIndex = 14;
            label4.Text = "رقم :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HONOR Sans Arabic UI R", 9F);
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 10;
            label2.Text = "الإسم كامل :";
            // 
            // CustomerFullName
            // 
            CustomerFullName.BorderStyle = BorderStyle.FixedSingle;
            CustomerFullName.Font = new Font("HONOR Sans Arabic UI R", 9F);
            CustomerFullName.Location = new Point(82, 93);
            CustomerFullName.Name = "CustomerFullName";
            CustomerFullName.Size = new Size(205, 24);
            CustomerFullName.TabIndex = 11;
            // 
            // CustomerPhoneNumber
            // 
            CustomerPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            CustomerPhoneNumber.Location = new Point(82, 122);
            CustomerPhoneNumber.Name = "CustomerPhoneNumber";
            CustomerPhoneNumber.Size = new Size(205, 23);
            CustomerPhoneNumber.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HONOR Sans Arabic UI R", 9F);
            label3.Location = new Point(16, 125);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 12;
            label3.Text = "رقم الهاتف :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 299);
            panel4.Name = "panel4";
            panel4.Size = new Size(592, 54);
            panel4.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSave);
            panel6.Controls.Add(btnCancel);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(180, 54);
            panel6.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("HONOR Sans Arabic UI R", 9F);
            btnSave.Location = new Point(93, 9);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 33);
            btnSave.TabIndex = 0;
            btnSave.Text = "تسجيل";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("HONOR Sans Arabic UI R", 9F);
            btnCancel.Location = new Point(12, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 33);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "إغلاق";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CustomerAddress
            // 
            CustomerAddress.BorderStyle = BorderStyle.FixedSingle;
            CustomerAddress.Font = new Font("HONOR Sans Arabic UI R", 9F);
            CustomerAddress.Location = new Point(357, 123);
            CustomerAddress.Name = "CustomerAddress";
            CustomerAddress.Size = new Size(208, 24);
            CustomerAddress.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("HONOR Sans Arabic UI R", 9F);
            label5.Location = new Point(305, 125);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 22;
            label5.Text = "العنوان :";
            // 
            // CustomerEmail
            // 
            CustomerEmail.BorderStyle = BorderStyle.FixedSingle;
            CustomerEmail.Location = new Point(350, 93);
            CustomerEmail.Name = "CustomerEmail";
            CustomerEmail.Size = new Size(215, 23);
            CustomerEmail.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("HONOR Sans Arabic UI R", 9F);
            label6.Location = new Point(305, 96);
            label6.Name = "label6";
            label6.Size = new Size(39, 17);
            label6.TabIndex = 20;
            label6.Text = "البريد :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("HONOR Sans Arabic UI R", 9F);
            label7.Location = new Point(306, 155);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 24;
            label7.Text = "الجنس :";
            // 
            // CustomerGender
            // 
            CustomerGender.Font = new Font("HONOR Sans Arabic UI R", 9F);
            CustomerGender.FormattingEnabled = true;
            CustomerGender.Location = new Point(357, 152);
            CustomerGender.Name = "CustomerGender";
            CustomerGender.Size = new Size(208, 25);
            CustomerGender.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("HONOR Sans Arabic UI R", 9F);
            label8.Location = new Point(12, 155);
            label8.Name = "label8";
            label8.Size = new Size(69, 17);
            label8.TabIndex = 26;
            label8.Text = "تاريخ الميلاد :";
            // 
            // CustomerBirthDate
            // 
            CustomerBirthDate.CustomFormat = "dd-MM-yyyy";
            CustomerBirthDate.Format = DateTimePickerFormat.Custom;
            CustomerBirthDate.Location = new Point(87, 152);
            CustomerBirthDate.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            CustomerBirthDate.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            CustomerBirthDate.Name = "CustomerBirthDate";
            CustomerBirthDate.Size = new Size(200, 23);
            CustomerBirthDate.TabIndex = 27;
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 353);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NewCustomerForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            Text = "تسجيل عميل جديد";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
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
        private Label label1;
        private Panel panel5;
    }
}