namespace OpenGYM.MdiForms
{
    partial class NewSubscriptionForm
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label3 = new Label();
            SubscriptionEndDate = new DateTimePicker();
            SubscriptionBeginDate = new DateTimePicker();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            NewSubscriptionID = new TextBox();
            label4 = new Label();
            panel7 = new Panel();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            PaymentTotal = new NumericUpDown();
            PaymentMethod = new ComboBox();
            Notes = new TextBox();
            label8 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            btnClear = new Button();
            btnClose = new Button();
            btnPrint = new Button();
            btnSave = new Button();
            CustomerName = new TextBox();
            label2 = new Label();
            btnSearchCustomer = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentTotal).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(SubscriptionEndDate);
            groupBox1.Controls.Add(SubscriptionBeginDate);
            groupBox1.Font = new Font("HONOR Sans Arabic UI R", 9F);
            groupBox1.Location = new Point(12, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 92);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "مدة الإشتراك";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("HONOR Sans Arabic UI R", 9F);
            label5.Location = new Point(198, 53);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 34;
            label5.Text = "تاريخ الإنتهاء :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HONOR Sans Arabic UI R", 9F);
            label3.Location = new Point(198, 25);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 33;
            label3.Text = "تاريخ البدئ :";
            // 
            // SubscriptionEndDate
            // 
            SubscriptionEndDate.CustomFormat = "dd-MM-yyyy";
            SubscriptionEndDate.Font = new Font("Segoe UI", 9F);
            SubscriptionEndDate.Format = DateTimePickerFormat.Custom;
            SubscriptionEndDate.Location = new Point(6, 52);
            SubscriptionEndDate.Name = "SubscriptionEndDate";
            SubscriptionEndDate.Size = new Size(180, 23);
            SubscriptionEndDate.TabIndex = 18;
            // 
            // SubscriptionBeginDate
            // 
            SubscriptionBeginDate.CustomFormat = "dd-MM-yyyy";
            SubscriptionBeginDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubscriptionBeginDate.Format = DateTimePickerFormat.Custom;
            SubscriptionBeginDate.Location = new Point(6, 21);
            SubscriptionBeginDate.Name = "SubscriptionBeginDate";
            SubscriptionBeginDate.Size = new Size(180, 23);
            SubscriptionBeginDate.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 70);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(121, 70);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(NewSubscriptionID);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(121, 47);
            panel3.TabIndex = 2;
            // 
            // NewSubscriptionID
            // 
            NewSubscriptionID.BorderStyle = BorderStyle.FixedSingle;
            NewSubscriptionID.Enabled = false;
            NewSubscriptionID.Location = new Point(12, 10);
            NewSubscriptionID.Name = "NewSubscriptionID";
            NewSubscriptionID.Size = new Size(70, 23);
            NewSubscriptionID.TabIndex = 15;
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
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(303, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(289, 70);
            panel7.TabIndex = 4;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("HONOR Sans Arabic UI B", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(289, 70);
            label1.TabIndex = 2;
            label1.Text = "إشتراك جديد";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(PaymentTotal);
            groupBox3.Controls.Add(PaymentMethod);
            groupBox3.Font = new Font("HONOR Sans Arabic UI R", 9F);
            groupBox3.Location = new Point(303, 148);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(277, 92);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "الدفع";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("HONOR Sans Arabic UI R", 9F);
            label7.Location = new Point(183, 58);
            label7.Name = "label7";
            label7.Size = new Size(88, 17);
            label7.TabIndex = 35;
            label7.Text = "القيمة المستحقة :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("HONOR Sans Arabic UI R", 9F);
            label6.Location = new Point(206, 27);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 34;
            label6.Text = "طريقة الدفع :";
            // 
            // PaymentTotal
            // 
            PaymentTotal.DecimalPlaces = 2;
            PaymentTotal.Font = new Font("Segoe UI", 9F);
            PaymentTotal.Location = new Point(6, 57);
            PaymentTotal.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            PaymentTotal.Name = "PaymentTotal";
            PaymentTotal.Size = new Size(165, 23);
            PaymentTotal.TabIndex = 30;
            PaymentTotal.ThousandsSeparator = true;
            // 
            // PaymentMethod
            // 
            PaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            PaymentMethod.FormattingEnabled = true;
            PaymentMethod.Location = new Point(6, 24);
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.Size = new Size(188, 25);
            PaymentMethod.TabIndex = 18;
            // 
            // Notes
            // 
            Notes.BorderStyle = BorderStyle.FixedSingle;
            Notes.Location = new Point(65, 114);
            Notes.Name = "Notes";
            Notes.PlaceholderText = "ملاحظات عن العميل";
            Notes.Size = new Size(514, 23);
            Notes.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("HONOR Sans Arabic UI R", 9F);
            label8.Location = new Point(11, 115);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 29;
            label8.Text = "ملاحظة :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 299);
            panel4.Name = "panel4";
            panel4.Size = new Size(592, 54);
            panel4.TabIndex = 30;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnClear);
            panel5.Controls.Add(btnClose);
            panel5.Controls.Add(btnPrint);
            panel5.Controls.Add(btnSave);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(336, 54);
            panel5.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("HONOR Sans Arabic UI R", 9F);
            btnClear.Location = new Point(89, 9);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 33);
            btnClear.TabIndex = 32;
            btnClear.Text = "جديد";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("HONOR Sans Arabic UI R", 9F);
            btnClose.Location = new Point(8, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 33);
            btnClose.TabIndex = 31;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Enabled = false;
            btnPrint.Font = new Font("HONOR Sans Arabic UI R", 9F);
            btnPrint.Location = new Point(170, 9);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 33);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "طباعة";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("HONOR Sans Arabic UI R", 9F);
            btnSave.Location = new Point(251, 9);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 33);
            btnSave.TabIndex = 4;
            btnSave.Text = "تسجيل";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // CustomerName
            // 
            CustomerName.BorderStyle = BorderStyle.FixedSingle;
            CustomerName.Location = new Point(66, 80);
            CustomerName.Name = "CustomerName";
            CustomerName.PlaceholderText = "إسم العميل";
            CustomerName.Size = new Size(438, 23);
            CustomerName.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HONOR Sans Arabic UI R", 9F);
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 32;
            label2.Text = "العميل :";
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.Font = new Font("HONOR Sans Arabic UI R", 9F);
            btnSearchCustomer.Location = new Point(509, 80);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(75, 23);
            btnSearchCustomer.TabIndex = 33;
            btnSearchCustomer.Text = "بحث";
            btnSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // NewSubscriptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 353);
            Controls.Add(btnSearchCustomer);
            Controls.Add(label2);
            Controls.Add(CustomerName);
            Controls.Add(panel4);
            Controls.Add(label8);
            Controls.Add(groupBox3);
            Controls.Add(Notes);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NewSubscriptionForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            Text = "إشتراك جديد";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentTotal).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Panel panel1;
        private GroupBox groupBox3;
        private ComboBox PaymentMethod;
        private TextBox Notes;
        private Label label8;
        private DateTimePicker SubscriptionEndDate;
        private DateTimePicker SubscriptionBeginDate;
        private NumericUpDown PaymentTotal;
        private Panel panel4;
        private Panel panel5;
        private Button btnPrint;
        private Button btnSave;
        private Button btnClose;
        private Panel panel7;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox NewSubscriptionID;
        private Label label4;
        private TextBox CustomerName;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label7;
        private Label label6;
        private Button btnSearchCustomer;
        private Button btnClear;
    }
}