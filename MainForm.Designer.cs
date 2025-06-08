namespace OpenGYM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel2 = new Panel();
            btnSubsRecord = new Button();
            panel5 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnNewCustomer = new Button();
            btnSearchCustomer = new Button();
            btnNewSubscription = new Button();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            currentUserRole = new Label();
            currentUserName = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStripStatusLabel = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 152, 94);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1023, 85);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 152, 94);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(435, 85);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TT Mussels Trl Light", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 53);
            label2.Name = "label2";
            label2.Size = new Size(350, 18);
            label2.TabIndex = 2;
            label2.Text = "a lightweight software to manage gym subscriptions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TT Mussels Trl", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 18);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 1;
            label1.Text = "OpenGYM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1023, 85);
            panel4.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 122, 77);
            panel2.Controls.Add(btnSubsRecord);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(btnNewCustomer);
            panel2.Controls.Add(btnSearchCustomer);
            panel2.Controls.Add(btnNewSubscription);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(currentUserRole);
            panel2.Controls.Add(currentUserName);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 548);
            panel2.TabIndex = 1;
            // 
            // btnSubsRecord
            // 
            btnSubsRecord.FlatStyle = FlatStyle.Flat;
            btnSubsRecord.Font = new Font("HONOR Sans Arabic UI R", 10F);
            btnSubsRecord.ForeColor = Color.White;
            btnSubsRecord.Image = (Image)resources.GetObject("btnSubsRecord.Image");
            btnSubsRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubsRecord.Location = new Point(12, 280);
            btnSubsRecord.Name = "btnSubsRecord";
            btnSubsRecord.Size = new Size(247, 45);
            btnSubsRecord.TabIndex = 11;
            btnSubsRecord.Text = "سجل الإشتراكات";
            btnSubsRecord.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 428);
            panel5.Name = "panel5";
            panel5.Size = new Size(274, 120);
            panel5.TabIndex = 10;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("HONOR Sans Arabic UI R", 10F);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 64);
            button2.Name = "button2";
            button2.Size = new Size(247, 45);
            button2.TabIndex = 9;
            button2.Text = "إدارة الإشتراكات";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("HONOR Sans Arabic UI R", 10F);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 13);
            button1.Name = "button1";
            button1.Size = new Size(247, 45);
            button1.TabIndex = 8;
            button1.Text = "إدارة الموظفين";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.FlatStyle = FlatStyle.Flat;
            btnNewCustomer.Font = new Font("HONOR Sans Arabic UI R", 10F);
            btnNewCustomer.ForeColor = Color.White;
            btnNewCustomer.Image = (Image)resources.GetObject("btnNewCustomer.Image");
            btnNewCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewCustomer.Location = new Point(12, 127);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(247, 45);
            btnNewCustomer.TabIndex = 7;
            btnNewCustomer.Text = "عميل جديد";
            btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.FlatStyle = FlatStyle.Flat;
            btnSearchCustomer.Font = new Font("HONOR Sans Arabic UI R", 10F);
            btnSearchCustomer.ForeColor = Color.White;
            btnSearchCustomer.Image = (Image)resources.GetObject("btnSearchCustomer.Image");
            btnSearchCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchCustomer.Location = new Point(12, 178);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(247, 45);
            btnSearchCustomer.TabIndex = 6;
            btnSearchCustomer.Text = "بحث عن عميل";
            btnSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // btnNewSubscription
            // 
            btnNewSubscription.FlatStyle = FlatStyle.Flat;
            btnNewSubscription.Font = new Font("HONOR Sans Arabic UI R", 10F);
            btnNewSubscription.ForeColor = Color.White;
            btnNewSubscription.Image = (Image)resources.GetObject("btnNewSubscription.Image");
            btnNewSubscription.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewSubscription.Location = new Point(12, 229);
            btnNewSubscription.Name = "btnNewSubscription";
            btnNewSubscription.Size = new Size(247, 45);
            btnNewSubscription.TabIndex = 4;
            btnNewSubscription.Text = "إشتراك جديد";
            btnNewSubscription.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(12, 117);
            label5.Name = "label5";
            label5.Size = new Size(247, 2);
            label5.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(193, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // currentUserRole
            // 
            currentUserRole.Font = new Font("HONOR Sans Arabic UI R", 9F);
            currentUserRole.ForeColor = Color.Silver;
            currentUserRole.Location = new Point(12, 63);
            currentUserRole.Name = "currentUserRole";
            currentUserRole.Size = new Size(175, 17);
            currentUserRole.TabIndex = 1;
            currentUserRole.Text = "---- -----";
            // 
            // currentUserName
            // 
            currentUserName.Font = new Font("HONOR Sans Arabic UI R", 9.75F);
            currentUserName.ForeColor = Color.White;
            currentUserName.Location = new Point(12, 43);
            currentUserName.Name = "currentUserName";
            currentUserName.Size = new Size(175, 18);
            currentUserName.TabIndex = 0;
            currentUserName.Text = "---- -----";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, windowsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1023, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(42, 20);
            fileToolStripMenuItem.Text = "ملف";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(135, 22);
            logoutToolStripMenuItem.Text = "تسجيل خروج";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(135, 22);
            exitToolStripMenuItem.Text = "إغلاق";
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeAllToolStripMenuItem });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(51, 20);
            windowsToolStripMenuItem.Text = "النوافذ";
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(124, 22);
            closeAllToolStripMenuItem.Text = "إغلاق الكل";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(58, 20);
            helpToolStripMenuItem.Text = "مساعدة";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(130, 22);
            aboutToolStripMenuItem.Text = "عن التطبيق";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Font = new Font("Cascadia Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 17);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(274, 635);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(749, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 657);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1039, 696);
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "منظومة إدارة النوادي الرياضية";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem closeAllToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label currentUserRole;
        private Label currentUserName;
        private Label label5;
        private Button btnNewSubscription;
        private Button btnSearchCustomer;
        private Button btnNewCustomer;
        private ToolStripStatusLabel toolStripStatusLabel;
        private StatusStrip statusStrip1;
        private Button button1;
        private Button button2;
        private Panel panel5;
        private Button btnSubsRecord;
    }
}