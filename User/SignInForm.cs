using System;
using System.Windows.Forms;

namespace Library
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Check for admin credentials
            if (txtUsername.Text == "admin" && txtPassword.Text == "password")
            {

            }
            // Check for regular user credentials (in a real app, this would be validated against a database)
            else if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                var mainUserForm = new MainUserForm();
                mainUserForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Sign In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSwitchToSignUp_Click(object sender, EventArgs e)
        {
            var signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}
