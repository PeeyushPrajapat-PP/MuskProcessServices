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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            // Display username of current user
            //MessageBox.Show(AuthState.CurrentUser.Username);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new NewSiteInspection()).Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Monthly_Inspection_Report()).Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new ListOfInspections()).Show();
            this.Hide();

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            User.Logout();
        }
    }
}
