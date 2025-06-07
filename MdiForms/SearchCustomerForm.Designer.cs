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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            btnClose = new Button();
            panel6 = new Panel();
            panel4 = new Panel();
            btnSearch = new Button();
            panel1 = new Panel();
            panel7 = new Panel();
            label1 = new Label();
            CustomersTable = new DataGridView();
            dgvID = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            panel8 = new Panel();
            panel10 = new Panel();
            CustomerName = new TextBox();
            panel9 = new Panel();
            customerSearchBindingSource = new BindingSource(components);
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersTable).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerSearchBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Fill;
            btnClose.Font = new Font("HONOR Sans Arabic UI R", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(11, 12);
            btnClose.Name = "btnClose";
            btnClose.RightToLeft = RightToLeft.Yes;
            btnClose.Size = new Size(75, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnClose);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(11, 12, 11, 12);
            panel6.RightToLeft = RightToLeft.Yes;
            panel6.Size = new Size(97, 54);
            panel6.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 363);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.Yes;
            panel4.Size = new Size(685, 54);
            panel4.TabIndex = 38;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Font = new Font("HONOR Sans Arabic UI R", 9F);
            btnSearch.Location = new Point(6, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 36);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(685, 69);
            panel1.TabIndex = 32;
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(526, 0);
            panel7.Name = "panel7";
            panel7.RightToLeft = RightToLeft.Yes;
            panel7.Size = new Size(159, 69);
            panel7.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HONOR Sans Arabic UI B", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(154, 30);
            label1.TabIndex = 0;
            label1.Text = "البحث عن عميل";
            // 
            // CustomersTable
            // 
            CustomersTable.AllowUserToAddRows = false;
            CustomersTable.AllowUserToDeleteRows = false;
            CustomersTable.AllowUserToResizeColumns = false;
            CustomersTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new Font("HONOR Sans Arabic UI R", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            CustomersTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            CustomersTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("HONOR Sans Arabic UI R", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            CustomersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            CustomersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersTable.Columns.AddRange(new DataGridViewColumn[] { dgvID, dgvName });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("HONOR Sans Arabic UI R", 9.75F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            CustomersTable.DefaultCellStyle = dataGridViewCellStyle8;
            CustomersTable.Dock = DockStyle.Fill;
            CustomersTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            CustomersTable.Location = new Point(13, 0);
            CustomersTable.MultiSelect = false;
            CustomersTable.Name = "CustomersTable";
            CustomersTable.ReadOnly = true;
            CustomersTable.RightToLeft = RightToLeft.Yes;
            CustomersTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("HONOR Sans Arabic UI R", 9.75F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            CustomersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            CustomersTable.RowHeadersWidth = 20;
            CustomersTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new Font("HONOR Sans Arabic UI R", 9.75F);
            CustomersTable.RowsDefaultCellStyle = dataGridViewCellStyle10;
            CustomersTable.ScrollBars = ScrollBars.None;
            CustomersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomersTable.ShowCellErrors = false;
            CustomersTable.ShowCellToolTips = false;
            CustomersTable.ShowEditingIcon = false;
            CustomersTable.ShowRowErrors = false;
            CustomersTable.Size = new Size(659, 218);
            CustomersTable.StandardTab = true;
            CustomersTable.TabIndex = 39;
            // 
            // dgvID
            // 
            dgvID.HeaderText = "رقم";
            dgvID.Name = "dgvID";
            dgvID.ReadOnly = true;
            dgvID.Resizable = DataGridViewTriState.False;
            // 
            // dgvName
            // 
            dgvName.HeaderText = "الإسم";
            dgvName.Name = "dgvName";
            dgvName.ReadOnly = true;
            dgvName.Resizable = DataGridViewTriState.False;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 294);
            panel2.TabIndex = 40;
            // 
            // panel5
            // 
            panel5.Controls.Add(CustomersTable);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 62);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(13, 0, 13, 14);
            panel5.Size = new Size(685, 232);
            panel5.TabIndex = 41;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel8);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(7);
            panel3.Size = new Size(685, 62);
            panel3.TabIndex = 40;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(panel9);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(7, 7);
            panel8.Name = "panel8";
            panel8.Size = new Size(671, 48);
            panel8.TabIndex = 35;
            // 
            // panel10
            // 
            panel10.Controls.Add(CustomerName);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(90, 0);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(6);
            panel10.Size = new Size(581, 48);
            panel10.TabIndex = 36;
            // 
            // CustomerName
            // 
            CustomerName.AcceptsReturn = true;
            CustomerName.AllowDrop = true;
            CustomerName.Dock = DockStyle.Fill;
            CustomerName.Font = new Font("HONOR Sans Arabic UI R", 9F);
            CustomerName.Location = new Point(6, 6);
            CustomerName.MaxLength = 60;
            CustomerName.Multiline = true;
            CustomerName.Name = "CustomerName";
            CustomerName.PlaceholderText = "إسم العميل";
            CustomerName.Size = new Size(569, 36);
            CustomerName.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnSearch);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(6);
            panel9.Size = new Size(90, 48);
            panel9.TabIndex = 23;
            // 
            // customerSearchBindingSource
            // 
            customerSearchBindingSource.DataSource = typeof(Database.CustomerSearch);
            // 
            // SearchCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 417);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(701, 456);
            Name = "SearchCustomerForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            Text = "البحث عن عميل";
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersTable).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerSearchBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnClose;
        private Panel panel6;
        private Panel panel4;
        private Button btnSearch;
        private Panel panel1;
        private Label label1;
        private DataGridView CustomersTable;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel7;
        private TextBox CustomerName;
        private BindingSource customerSearchBindingSource;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvName;
    }
}