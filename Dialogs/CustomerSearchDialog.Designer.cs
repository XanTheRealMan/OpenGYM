namespace OpenGYM.Dialogs
{
    partial class CustomerSearchDialog
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            panel4 = new Panel();
            panel6 = new Panel();
            btnOK = new Button();
            btnCancel = new Button();
            CustomersTable = new DataGridView();
            dgvID = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 284);
            panel4.Name = "panel4";
            panel4.Size = new Size(609, 40);
            panel4.TabIndex = 20;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnOK);
            panel6.Controls.Add(btnCancel);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(180, 40);
            panel6.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("HONOR Sans Arabic UI R", 9F);
            btnOK.Location = new Point(93, 6);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 26);
            btnOK.TabIndex = 0;
            btnOK.Text = "إختيار";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("HONOR Sans Arabic UI R", 9F);
            btnCancel.Location = new Point(12, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 26);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CustomersTable
            // 
            CustomersTable.AllowUserToAddRows = false;
            CustomersTable.AllowUserToDeleteRows = false;
            CustomersTable.AllowUserToResizeColumns = false;
            CustomersTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Font = new Font("HONOR Sans Arabic UI R", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            CustomersTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            CustomersTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("HONOR Sans Arabic UI R", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            CustomersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            CustomersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersTable.Columns.AddRange(new DataGridViewColumn[] { dgvID, dgvName });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("HONOR Sans Arabic UI R", 9.75F);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            CustomersTable.DefaultCellStyle = dataGridViewCellStyle13;
            CustomersTable.Dock = DockStyle.Fill;
            CustomersTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            CustomersTable.Location = new Point(5, 5);
            CustomersTable.MultiSelect = false;
            CustomersTable.Name = "CustomersTable";
            CustomersTable.ReadOnly = true;
            CustomersTable.RightToLeft = RightToLeft.Yes;
            CustomersTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("HONOR Sans Arabic UI R", 9.75F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            CustomersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            CustomersTable.RowHeadersWidth = 20;
            CustomersTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Font = new Font("HONOR Sans Arabic UI R", 9.75F);
            CustomersTable.RowsDefaultCellStyle = dataGridViewCellStyle15;
            CustomersTable.ScrollBars = ScrollBars.None;
            CustomersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomersTable.ShowCellErrors = false;
            CustomersTable.ShowCellToolTips = false;
            CustomersTable.ShowEditingIcon = false;
            CustomersTable.ShowRowErrors = false;
            CustomersTable.Size = new Size(599, 274);
            CustomersTable.StandardTab = true;
            CustomersTable.TabIndex = 40;
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
            // panel1
            // 
            panel1.Controls.Add(CustomersTable);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(609, 284);
            panel1.TabIndex = 41;
            // 
            // CustomerSearchDialog
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(609, 324);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CustomerSearchDialog";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "نتائج البحث";
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomersTable).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel6;
        private Button btnOK;
        private Button btnCancel;
        private DataGridView CustomersTable;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvName;
        private Panel panel1;
    }
}