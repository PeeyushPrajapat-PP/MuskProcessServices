using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MuskProcessServices.Models;

namespace MuskProcessServices
{
    public partial class ListOfInspections : Form
    {
        public ListOfInspections()
        {
            // TODO: Rename variables accordingly.
            InitializeComponent();

            // The code below is for testing purposes only
            siteDropdown.DropDownStyle = ComboBoxStyle.DropDown;
            siteDropdown.Items.Add("Please select site");
            siteDropdown.Items.Add("Weetabix Burton");
            siteDropdown.Items.Add("Tyte and Lyle");
            siteDropdown.SelectedIndex = 0;
            this.Controls.Add(siteDropdown);
        }

        private void ListOfInspections_Load(object sender, EventArgs e)
        {

            PopulateFilterOptionFields();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //tableLayoutPanel1.Controls.Add(new Label() { Text = "Type:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 0);
            /*var columnHeaderStyle = new TextBox();
            int row2 = tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0));
            columnHeaderStyle.Text = "Date";
            tableLayoutPanel1.Controls.Add(columnHeaderStyle, 0, 0);*/
        }
        private void PopulateFilterOptionFields()
        {
            // Sites dropdown items
            siteDropdown.DataSource = MuskSite.getAllSites().Tables[0];
            siteDropdown.ValueMember = "SiteID";
            siteDropdown.DisplayMember = "Name";
            siteDropdown.SelectedItem = null;
            siteDropdown.SelectedText = "-- Select --";

            // EnteredBy dropdown items
            enteredByDropdown.DataSource = User.getAllUsers().Tables[0];
            enteredByDropdown.ValueMember = "UserID";
            enteredByDropdown.DisplayMember = "Fullname";
            enteredByDropdown.SelectedItem = null;
            enteredByDropdown.SelectedText = "-- Select --";

            // Months dropdown
            string[] monthNames = DateTimeFormatInfo.CurrentInfo.MonthNames;
            monthNames = monthNames.Where((item, index) => index != monthNames.Length - 1).ToArray();
            monthDropdown.DataSource = monthNames;
            monthDropdown.SelectedItem = null;
            monthDropdown.SelectedText = "-- Select --";
        }
    }
}
