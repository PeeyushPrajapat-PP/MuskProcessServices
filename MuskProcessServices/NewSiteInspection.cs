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
        public NewSiteInspection()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<SubHeader> list = new List<SubHeader>();
            list.Add(new SubHeader() { _subHeaderID = 1, _subTitle = "Working Standards" });
            list.Add(new SubHeader() { _subHeaderID = 2, _subTitle = "Quality" });
            list.Add(new SubHeader() { _subHeaderID = 3, _subTitle = "Site Rules" });
            list.Add(new SubHeader() { _subHeaderID = 4, _subTitle = "Environmental" });
            list.Add(new SubHeader() { _subHeaderID = 5, _subTitle = "Protection of Individuals" });
            list.Add(new SubHeader() { _subHeaderID = 6, _subTitle = "Equipment" });
            list.Add(new SubHeader() { _subHeaderID = 7, _subTitle = "Other" });
            section.DataSource = list;
            section.ValueMember = "subHeaderID";
            section.DisplayMember = "subTitle";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void section_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SubHeader obj = section.SelectedItem as SubHeader;
            if (obj != null)
                MessageBox.Show(string.Format(".{0} - {1} selected", obj._subHeaderID, obj._subTitle, MessageBoxButtons.OK, MessageBoxIcon.Information));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
