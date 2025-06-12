namespace OpenGYM.MdiForms
{
    partial class SubscriptionRecordsForm
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            customerSearchBindingSource = new BindingSource(components);
            panel5 = new Panel();
            SubscriptionsTable = new DataGridView();
            dgvID = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvDateBegin = new DataGridViewTextBoxColumn();
            dgvDateEnd = new DataGridViewTextBoxColumn();
            dgvPayment = new DataGridViewTextBoxColumn();
            dgvNotes = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            title = new Label();
            panel7 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            btnPrint = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)customerSearchBindingSource).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SubscriptionsTable).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // customerSearchBindingSource
            // 
            customerSearchBindingSource.DataSource = typeof(Database.CustomerSearch);
            // 
            // panel5
            // 
            panel5.Controls.Add(SubscriptionsTable);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(13);
            panel5.Size = new Size(800, 327);
            panel5.TabIndex = 41;
            // 
            // SubscriptionsTable
            // 
            SubscriptionsTable.AllowUserToAddRows = false;
            SubscriptionsTable.AllowUserToDeleteRows = false;
            SubscriptionsTable.AllowUserToResizeColumns = false;
            SubscriptionsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Font = new Font("HONOR Sans Arabic UI R", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubscriptionsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            SubscriptionsTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            SubscriptionsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("HONOR Sans Arabic UI R", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            SubscriptionsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            SubscriptionsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubscriptionsTable.Columns.AddRange(new DataGridViewColumn[] { dgvID, dgvName, dgvDateBegin, dgvDateEnd, dgvPayment, dgvNotes });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("HONOR Sans Arabic UI R", 9.75F);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            SubscriptionsTable.DefaultCellStyle = dataGridViewCellStyle13;
            SubscriptionsTable.Dock = DockStyle.Fill;
            SubscriptionsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            SubscriptionsTable.Location = new Point(13, 13);
            SubscriptionsTable.MultiSelect = false;
            SubscriptionsTable.Name = "SubscriptionsTable";
            SubscriptionsTable.ReadOnly = true;
            SubscriptionsTable.RightToLeft = RightToLeft.Yes;
            SubscriptionsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("HONOR Sans Arabic UI R", 9.75F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            SubscriptionsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            SubscriptionsTable.RowHeadersWidth = 20;
            SubscriptionsTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Font = new Font("HONOR Sans Arabic UI R", 9.75F);
            SubscriptionsTable.RowsDefaultCellStyle = dataGridViewCellStyle15;
            SubscriptionsTable.ScrollBars = ScrollBars.Vertical;
            SubscriptionsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubscriptionsTable.ShowCellErrors = false;
            SubscriptionsTable.ShowCellToolTips = false;
            SubscriptionsTable.ShowEditingIcon = false;
            SubscriptionsTable.ShowRowErrors = false;
            SubscriptionsTable.Size = new Size(774, 301);
            SubscriptionsTable.StandardTab = true;
            SubscriptionsTable.TabIndex = 39;
            // 
            // dgvID
            // 
            dgvID.HeaderText = "رقم العملية";
            dgvID.Name = "dgvID";
            dgvID.ReadOnly = true;
            dgvID.Resizable = DataGridViewTriState.False;
            // 
            // dgvName
            // 
            dgvName.HeaderText = "إسم العميل";
            dgvName.Name = "dgvName";
            dgvName.ReadOnly = true;
            dgvName.Resizable = DataGridViewTriState.False;
            // 
            // dgvDateBegin
            // 
            dgvDateBegin.HeaderText = "تاريخ من";
            dgvDateBegin.Name = "dgvDateBegin";
            dgvDateBegin.ReadOnly = true;
            // 
            // dgvDateEnd
            // 
            dgvDateEnd.HeaderText = "تاريخ إلى";
            dgvDateEnd.Name = "dgvDateEnd";
            dgvDateEnd.ReadOnly = true;
            // 
            // dgvPayment
            // 
            dgvPayment.HeaderText = "المدفوع";
            dgvPayment.Name = "dgvPayment";
            dgvPayment.ReadOnly = true;
            // 
            // dgvNotes
            // 
            dgvNotes.HeaderText = "ملاحظات";
            dgvNotes.Name = "dgvNotes";
            dgvNotes.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 327);
            panel2.TabIndex = 43;
            // 
            // title
            // 
            title.Dock = DockStyle.Fill;
            title.Font = new Font("HONOR Sans Arabic UI B", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.RightToLeft = RightToLeft.Yes;
            title.Size = new Size(502, 69);
            title.TabIndex = 0;
            title.Text = "سجل الإشتراكات";
            title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            panel7.Controls.Add(title);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(298, 0);
            panel7.Name = "panel7";
            panel7.RightToLeft = RightToLeft.Yes;
            panel7.Size = new Size(502, 69);
            panel7.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(800, 69);
            panel1.TabIndex = 41;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 396);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.Yes;
            panel4.Size = new Size(800, 54);
            panel4.TabIndex = 42;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnPrint);
            panel6.Controls.Add(btnClose);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(11, 12, 11, 12);
            panel6.RightToLeft = RightToLeft.Yes;
            panel6.Size = new Size(178, 54);
            panel6.TabIndex = 1;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("HONOR Sans Arabic UI R", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(92, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(75, 30);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "طباعة";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("HONOR Sans Arabic UI R", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(11, 12);
            btnClose.Name = "btnClose";
            btnClose.RightToLeft = RightToLeft.Yes;
            btnClose.Size = new Size(75, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // SubscriptionRecordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "SubscriptionRecordsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            Text = "سجل الإشتراكات";
            ((System.ComponentModel.ISupportInitialize)customerSearchBindingSource).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SubscriptionsTable).EndInit();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private BindingSource customerSearchBindingSource;
        private Panel panel5;
        private DataGridView SubscriptionsTable;
        private Panel panel2;
        private Label title;
        private Panel panel7;
        private Panel panel1;
        private Panel panel4;
        private Panel panel6;
        private Button btnClose;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvDateBegin;
        private DataGridViewTextBoxColumn dgvDateEnd;
        private DataGridViewTextBoxColumn dgvPayment;
        private DataGridViewTextBoxColumn dgvNotes;
        private Button btnPrint;
    }
}