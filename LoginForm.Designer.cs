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
            panel1.Size = new Size(460, 67);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HONOR Sans Arabic UI R", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(222, 39);
            label2.Name = "label2";
            label2.Size = new Size(226, 18);
            label2.TabIndex = 1;
            label2.Text = "ادخل اسم المستخدم وكلمة المرور للتسجيل";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HONOR Sans Arabic UI B", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 10);
            label1.Name = "label1";
            label1.Size = new Size(109, 22);
            label1.TabIndex = 0;
            label1.Text = "تسجيل الدخول";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HONOR Sans Arabic UI R", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(220, 76);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "إسم المستخدم :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("HONOR Sans Arabic UI R", 8.249999F);
            label4.Location = new Point(220, 130);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "كلمة المرور :";
            // 
            // loginUsername
            // 
            loginUsername.BorderStyle = BorderStyle.FixedSingle;
            loginUsername.Font = new Font("HONOR Sans Arabic UI R", 9F);
            loginUsername.Location = new Point(220, 97);
            loginUsername.Name = "loginUsername";
            loginUsername.Size = new Size(218, 24);
            loginUsername.TabIndex = 4;
            // 
            // loginPassword
            // 
            loginPassword.BorderStyle = BorderStyle.FixedSingle;
            loginPassword.Font = new Font("HONOR Sans Arabic UI R", 9F);
            loginPassword.Location = new Point(220, 151);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(218, 24);
            loginPassword.TabIndex = 5;
            loginPassword.UseSystemPasswordChar = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("HONOR Sans Arabic UI R", 9F);
            btnClose.Location = new Point(332, 185);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(106, 37);
            btnClose.TabIndex = 7;
            btnClose.Text = "إغلاق";
            btnClose.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("HONOR Sans Arabic UI R", 9F);
            btnSubmit.Location = new Point(220, 185);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(106, 37);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "تسجيل دخول";
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(460, 234);
            Controls.Add(btnSubmit);
            Controls.Add(btnClose);
            Controls.Add(loginPassword);
            Controls.Add(loginUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
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
