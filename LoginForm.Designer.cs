namespace OpenGYM
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            loginUsername = new TextBox();
            loginPassword = new TextBox();
            btnClose = new Button();
            btnSubmit = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 70);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F);
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(408, 14);
            label2.TabIndex = 1;
            label2.Text = "Enter your Username && Password and press the submit button.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(172, 23);
            label1.TabIndex = 0;
            label1.Text = "Authentication";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F);
            label3.Location = new Point(220, 82);
            label3.Name = "label3";
            label3.Size = new Size(71, 14);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F);
            label4.Location = new Point(220, 136);
            label4.Name = "label4";
            label4.Size = new Size(69, 14);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // loginUsername
            // 
            loginUsername.BorderStyle = BorderStyle.FixedSingle;
            loginUsername.Font = new Font("Verdana", 10F);
            loginUsername.Location = new Point(220, 99);
            loginUsername.Name = "loginUsername";
            loginUsername.Size = new Size(218, 24);
            loginUsername.TabIndex = 4;
            loginUsername.Text = "admin";
            // 
            // loginPassword
            // 
            loginPassword.BorderStyle = BorderStyle.FixedSingle;
            loginPassword.Font = new Font("Verdana", 10F);
            loginPassword.Location = new Point(220, 153);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(218, 24);
            loginPassword.TabIndex = 5;
            loginPassword.UseSystemPasswordChar = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(332, 196);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(106, 32);
            btnClose.TabIndex = 7;
            btnClose.Text = "CLOSE";
            btnClose.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            btnSubmit.Image = (Image)resources.GetObject("btnSubmit.Image");
            btnSubmit.Location = new Point(220, 196);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(106, 32);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(460, 238);
            Controls.Add(btnSubmit);
            Controls.Add(btnClose);
            Controls.Add(loginPassword);
            Controls.Add(loginUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Verdana", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentication";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox loginUsername;
        private TextBox loginPassword;
        private Button btnClose;
        private Button btnSubmit;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}
