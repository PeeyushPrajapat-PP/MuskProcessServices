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

            if (username.Equals(""))
            {
                MessageBox.Show("Please enter a valid username...");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Please enter a valid password...");
            }
            else
            {
                bool result = User.Login(usernameInput.Text, passwordInput.Text);
                if (result)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failure");
                }
            }
        }

        /* TODO: Remove code below
         * Testing DB connection. Leaving for example. 

        private void btnLoadData_Click_1(object sender, EventArgs e)
        {
            DBConnection dbConnection = DBConnection.getInstanceOfDBConnection();
            DataSet datasetUser = dbConnection.getDataSet("SELECT * FROM Users");
            //Console.log(datasetUser.Tables[0]);
            dgvUsers.DataSource = datasetUser.Tables[0];
        }
        */
    }
}
