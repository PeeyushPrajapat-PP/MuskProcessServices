﻿using MuskProcessServices.Models;
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Monthly_Inspection_Report()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // for testing purposes only
            PDFReport.generatePDF(1);
        }
    }
}
