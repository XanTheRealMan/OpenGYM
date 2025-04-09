namespace OpenGYM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.btnSubmit.Click += btnSubmitClicked;
            this.btnClose.Click += btnCloseClicked;
        }

        private void btnSubmitClicked(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (string.IsNullOrWhiteSpace(loginUsername.Text))
            {
                errorProvider1.SetError(loginUsername, "Please enter your username.");
                return;
            }
            if (string.IsNullOrWhiteSpace(loginPassword.Text))
            {
                errorProvider2.SetError(loginPassword, "Please enter your password.");
                return;
            }

            //TODO: Implement login logic here
        }

        private void btnCloseClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
