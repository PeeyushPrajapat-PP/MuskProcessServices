using MuskProcessServices.Models;
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
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addNewSiteInspectionBtn_Click(object sender, EventArgs e)
        {
            (new NewSiteInspection()).Show();
            this.Hide();

        }

        private void monthlyReportBtn_Click(object sender, EventArgs e)
        {
            (new Monthly_Inspection_Report()).Show();
            this.Hide();

        }

        private void listOfInspectionsBtn_Click(object sender, EventArgs e)
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
