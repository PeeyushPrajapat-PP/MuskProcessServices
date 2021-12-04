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
    public partial class NewSiteInspection : Form
    {
        private List<Intervention> interventions = new List<Intervention>();
        public NewSiteInspection()
        {
            InitializeComponent();

            // Get items from database and add them to dropdown list
            populateDropdownFields();

            disableInterventionForm();
        }
        private void disableInterventionForm()
        {
            sectionDropdown.Enabled = false;
            countField.Enabled = false;
            commentField.Enabled = false;
            completedCheckBox.Enabled = false;
            actionTakenField.Enabled = false;
            button3.Enabled = false;
        }

        private void populateDropdownFields()
        {
            // Sites dropdown items
            siteDropdown.DataSource = MuskSite.getAllSites().Tables[0];
            siteDropdown.ValueMember = "SiteID";
            siteDropdown.DisplayMember = "Name";

            // Users dropdown items (Supervisor and Inspector)
            supervisorDropdown.DataSource = User.getAllUsers().Tables[0];
            supervisorDropdown.ValueMember = "UserID";
            supervisorDropdown.DisplayMember = "Fullname";

            inspectorDropdown.DataSource = User.getAllUsers().Tables[0];
            inspectorDropdown.ValueMember = "UserID";
            inspectorDropdown.DisplayMember = "Fullname";

            //SubHeader dropdown items
            sectionDropdown.DataSource = SubHeader.getAllSubHeaders().Tables[0];
            sectionDropdown.ValueMember = "SubHeaderID";
            sectionDropdown.DisplayMember = "SubTitle";
            sectionDropdown.SelectedIndex = 0;

            // Default value
            siteDropdown.SelectedIndex = 0;
            supervisorDropdown.SelectedIndex = 0;
            inspectorDropdown.SelectedIndex = 0;
        }




        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get value from form and add them to List<Interventions>
            interventions.Add(new Intervention(sectionDropdown.SelectedIndex,
                Int32.Parse(countField.Text),
                commentField.Text,
                completedCheckBox.Checked,
                actionTakenField.Text)
                );

            // Clear out the form for new interventions to be added
            sectionDropdown.SelectedIndex = 0;
            countField.Text = "";
            commentField.Text = "";
            completedCheckBox.Checked = false;
            actionTakenField.Text = "";
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            // Get SiteInspectionId from the DB
            string queryExpression = String.Format("SELECT * FROM SiteInspections");
            DataSet result = queryExpression.getDataSetFromDB();

            int siteInspectionId = result.Tables[0].Rows[0].Field<int>("SiteInspectionID") + 1;

            // add interventions to DB
            foreach (Intervention item in interventions)
            {
                Intervention.SaveToDB("INSERT INTO Interventions(SiteInspectionID, SubHeaderID, Count, Comment, Completed, ActionTaken) VALUES(@SiteInspectionID, @SubHeaderID, @Count, @Comment, @Completed, @ActionTaken)", item, siteInspectionId);
            }

            MessageBox.Show("Successfully added to the DB.");
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void section_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*SubHeader obj = section.SelectedItem as SubHeader;
            if (obj != null)
                MessageBox.Show(string.Format(".{0} - {1} selected", obj._subHeaderID, obj._subTitle, MessageBoxButtons.OK, MessageBoxIcon.Information));
*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            SiteInspection siteInspection =
                new SiteInspection(
                    Convert.ToInt32(siteDropdown.SelectedValue),
                    1, // edit to take currentUser.UserId value
                    Convert.ToInt32(supervisorDropdown.SelectedValue),
                    Convert.ToInt32(inspectorDropdown.SelectedValue),
                    workAreaField.Text,
                    jobDescriptionField.Text,
                    typeField.Text
                );

            DBConnection.SaveSiteInspectionToDB("INSERT INTO SiteInspections(SiteID, CompletedBy, Supervisor, Inspector, WorkArea, JobDescription, Type, Status) VALUES(@SiteID, @CompletedBy, @Supervisor, @Inspector, @WorkArea, @JobDescription, @Type, @Status)", siteInspection);

            // Enable Intervention details part of the form
            sectionDropdown.Enabled = true;
            countField.Enabled = true;
            commentField.Enabled = true;
            completedCheckBox.Enabled = true;
            actionTakenField.Enabled = true;
            button3.Enabled = true;
            

            // Disable Site Inspection details form
            siteDropdown.Enabled = false;
            workAreaField.Enabled = false;
            supervisorDropdown.Enabled = false;
            jobDescriptionField.Enabled = false;
            inspectorDropdown.Enabled = false;
            typeField.Enabled = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            // If there are values in the fields ask for confirmation
            this.Hide();
            (new Menu()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User.Logout();
        }
    }
}
