﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManagementProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void lblmanagestudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FrmStudent s = new FrmStudent();
            s.Show();
            this.Hide();

        }

        private void lblmanageclos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            Clo s = new Clo();
            s.Show();
            this.Hide();
        }

        private void lblmanagerubrics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Rubric s = new Rubric();
            s.Show();
            this.Hide();
        }
    }
}
