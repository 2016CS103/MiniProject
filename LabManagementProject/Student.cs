using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LabManagementProject
{
    public partial class FrmStudent : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");
        private SqlCommand cmd;
        private SqlDataAdapter adpt;
        private DataSet dt;
     

        public FrmStudent()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //DisplayData();



        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            conn.Open();
           // cmd = new SqlCommand("insert into Student values('"+txtfirstname.Text+"', '"+txtlastname.Text+"', '"+txtcontact.Text+"', '"+txtemail.Text+"', '"+txtregistration.Text+"', '"+cmbStatus.Text+"')", conn);
            //cmd.ExecuteNonQuery();
            
           // MessageBox.Show("student data saved");
            DisplayData();
            conn.Close();

            
        }

        public void DisplayData()
        {
           // conn.Open();
            adpt = new SqlDataAdapter("select * from Student", conn);
            dt = new DataSet();
            adpt.Fill(dt);
            dgvstudent.DataSource = dt;
           // conn.Close();
        }
    }
}
