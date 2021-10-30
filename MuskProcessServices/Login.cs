using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuskProcessServices
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username.Equals(""))
            {
                MessageBox.Show("Please enter a valid username...");
            } else if (password.Equals(""))
            {
                MessageBox.Show("Please enter a valid password...");
            } else
            {
                bool result = User.Login(txtUsername.Text, txtPassword.Text);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
