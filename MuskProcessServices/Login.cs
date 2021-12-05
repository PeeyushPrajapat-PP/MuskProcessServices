using System;
using System.Windows.Forms;

namespace MuskProcessServices
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            bool result = User.Login(username, password);

            if (result)
            {
                (new Menu()).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect credentials.");
            }
        }

        private void validateUsername(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameInput.Text))
            {
                usernameInput.Focus();
                errorProviderApp.SetError(usernameInput, "Username should not be left blank!");
            }
            else if (usernameInput.Text.Contains(" "))
            {
                usernameInput.Focus();
                errorProviderApp.SetError(usernameInput, "Username cannot have white spaces in between.");
            }
            else
            {
                errorProviderApp.SetError(usernameInput, "");
            }
        }

        private void validatePassword(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordInput.Text))
            {
                passwordInput.Focus();
                errorProviderApp.SetError(passwordInput, "Password should not be left blank!");
            }
            else if (passwordInput.Text.Contains(" "))
            {
                usernameInput.Focus();
                errorProviderApp.SetError(passwordInput, "Password cannot have white spaces in between.");
            }
            else
            {
                errorProviderApp.SetError(passwordInput, "");
            }
        }
    }
}
