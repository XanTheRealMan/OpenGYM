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
            closeAlllToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(768, 74);
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
            panel3.Size = new Size(434, 74);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 44);
            label2.Name = "label2";
            label2.Size = new Size(339, 14);
            label2.TabIndex = 2;
            label2.Text = "open-source software to manage gym subscriptions.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 15);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 1;
            label1.Text = "OpenGYM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(-106, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(874, 74);
            panel4.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 122, 77);
            panel2.Controls.Add(btnNewCustomer);
            panel2.Controls.Add(btnSearchCustomer);
            panel2.Controls.Add(btnNewSubscription);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(currentUserRole);
            panel2.Controls.Add(currentUserName);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 380);
            panel2.TabIndex = 1;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.FlatStyle = FlatStyle.Flat;
            btnNewCustomer.ForeColor = Color.White;
            btnNewCustomer.Image = (Image)resources.GetObject("btnNewCustomer.Image");
            btnNewCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewCustomer.Location = new Point(12, 129);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(247, 39);
            btnNewCustomer.TabIndex = 7;
            btnNewCustomer.Text = "New Customer";
            btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.FlatStyle = FlatStyle.Flat;
            btnSearchCustomer.ForeColor = Color.White;
            btnSearchCustomer.Image = (Image)resources.GetObject("btnSearchCustomer.Image");
            btnSearchCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchCustomer.Location = new Point(12, 205);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(247, 39);
            btnSearchCustomer.TabIndex = 6;
            btnSearchCustomer.Text = "Search Customer";
            btnSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // btnNewSubscription
            // 
            btnNewSubscription.FlatStyle = FlatStyle.Flat;
            btnNewSubscription.ForeColor = Color.White;
            btnNewSubscription.Image = (Image)resources.GetObject("btnNewSubscription.Image");
            btnNewSubscription.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewSubscription.Location = new Point(12, 167);
            btnNewSubscription.Name = "btnNewSubscription";
            btnNewSubscription.Size = new Size(247, 39);
            btnNewSubscription.TabIndex = 4;
            btnNewSubscription.Text = "New Subscription";
            btnNewSubscription.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(12, 101);
            label5.Name = "label5";
            label5.Size = new Size(247, 2);
            label5.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // currentUserRole
            // 
            currentUserRole.AutoSize = true;
            currentUserRole.Font = new Font("Verdana", 7F, FontStyle.Bold);
            currentUserRole.ForeColor = Color.Silver;
            currentUserRole.Location = new Point(84, 55);
            currentUserRole.Name = "currentUserRole";
            currentUserRole.Size = new Size(46, 12);
            currentUserRole.TabIndex = 1;
            currentUserRole.Text = "ADMIN";
            // 
            // currentUserName
            // 
            currentUserName.AutoSize = true;
            currentUserName.Font = new Font("Verdana", 9F);
            currentUserName.ForeColor = Color.White;
            currentUserName.Location = new Point(84, 37);
            currentUserName.Name = "currentUserName";
            currentUserName.Size = new Size(93, 14);
            currentUserName.TabIndex = 0;
            currentUserName.Text = "ADMIN ADMIN";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, windowsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(768, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(112, 22);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeAlllToolStripMenuItem });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(68, 20);
            windowsToolStripMenuItem.Text = "Windows";
            // 
            // closeAlllToolStripMenuItem
            // 
            closeAlllToolStripMenuItem.Name = "closeAlllToolStripMenuItem";
            closeAlllToolStripMenuItem.Size = new Size(123, 22);
            closeAlllToolStripMenuItem.Text = "Close Alll";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(274, 456);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(494, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Font = new Font("Cascadia Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 17);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 478);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Verdana", 8.25F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "OpenGYM - GYM Management System";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private ToolStripMenuItem closeAlllToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label currentUserRole;
        private Label currentUserName;
        private Label label5;
        private Button btnNewSubscription;
        private Button btnSearchCustomer;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private Button btnNewCustomer;
    }
}