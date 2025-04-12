namespace OpenGYM.MdiForms
{
    partial class SearchCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomerForm));
            button1 = new Button();
            button2 = new Button();
            panel6 = new Panel();
            panel4 = new Panel();
            button6 = new Button();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            CustomerFullName = new ColumnHeader();
            CustomerID = new ColumnHeader();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            button1.Location = new Point(84, 8);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 0;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            button2.Location = new Point(3, 8);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 1;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(button1);
            panel6.Controls.Add(button2);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(422, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(170, 47);
            panel6.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 418);
            panel4.Name = "panel4";
            panel4.Size = new Size(592, 47);
            panel4.TabIndex = 38;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(460, 16);
            button6.Name = "button6";
            button6.Size = new Size(27, 20);
            button6.TabIndex = 24;
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(359, 16);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Customer ID";
            textBox2.Size = new Size(95, 21);
            textBox2.TabIndex = 23;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(87, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(493, 44);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(6, 16);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Customer Name";
            textBox1.Size = new Size(347, 21);
            textBox1.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 61);
            panel1.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(231, 23);
            label1.TabIndex = 0;
            label1.Text = "Search for Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F);
            label2.Location = new Point(8, 83);
            label2.Name = "label2";
            label2.Size = new Size(73, 14);
            label2.TabIndex = 33;
            label2.Text = "Customer:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CustomerID, CustomerFullName });
            listView1.Location = new Point(12, 116);
            listView1.Name = "listView1";
            listView1.Size = new Size(569, 296);
            listView1.TabIndex = 39;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // CustomerFullName
            // 
            CustomerFullName.DisplayIndex = 0;
            CustomerFullName.Text = "Full Name";
            // 
            // CustomerID
            // 
            CustomerID.DisplayIndex = 1;
            CustomerID.Text = "ID";
            // 
            // SearchCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 465);
            Controls.Add(listView1);
            Controls.Add(panel4);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Font = new Font("Verdana", 8.25F);
            Name = "SearchCustomerForm";
            ShowIcon = false;
            Text = "Search for Customer";
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Panel panel6;
        private Panel panel4;
        private Button button6;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private ListView listView1;
        private ColumnHeader CustomerID;
        private ColumnHeader CustomerFullName;
    }
}