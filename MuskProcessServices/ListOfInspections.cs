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
    public partial class ListOfInspections : Form
    {
        public ListOfInspections()
        {
            // TODO: Rename variables accordingly.
            InitializeComponent();

            // The code below is for testing purposes only
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox1.Items.Add("Please select site");
            comboBox1.Items.Add("Weetabix Burton");
            comboBox1.Items.Add("Tyte and Lyle");
            comboBox1.SelectedIndex = 0;
            this.Controls.Add(comboBox1);
        }

        private void ListOfInspections_Load(object sender, EventArgs e)
        {

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
    }
}
