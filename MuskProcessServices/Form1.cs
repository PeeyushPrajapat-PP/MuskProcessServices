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
    public partial class Form1 : Form
    {
        public Form1()
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
            string[] users = {"inspector","administrator"};
            string[] passwords = { "guest1", "admin1" };

            //string user = "Peeyush";
            //string pass = "password";

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if ((username == users[0] && password == passwords[0] )|| (username == users[1] && password == passwords[1]))
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /* TODO: Remove code below
         * Testing DB connection. Leaving for example. 
         * 
         * private void btnLoadData_Click(object sender, EventArgs e)
        {
            DBConnection dbConnection = DBConnection.getInstanceOfDBConnection();
            DataSet datasetUser = dbConnection.getDataSet("SELECT * FROM Users");
            //Console.log(datasetUser.Tables[0]);
            dgvUsers.DataSource = datasetUser.Tables[0];
        }*/
    }
}
