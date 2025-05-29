using System;
using System.Windows.Forms;

namespace Library
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                var newForm = new MainUserForm();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSwitchToSignIn_Click(object sender, EventArgs e)
        {
            var signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
