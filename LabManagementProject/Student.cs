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
        SqlConnection con = new SqlConnection(@"Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");
        private int Id = 0;

        public FrmStudent()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DisplayData();



        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {   
            if (txtfirstname.Text != "" && txtlastname.Text != "" && txtcontact.Text != "" && txtemail.Text != "" &&
                txtregistration.Text != "" && cmbStatus.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values(@Fname,@Lname,@contact,@email,@registration,@status)";
                cmd.Parameters.AddWithValue("@Fname", txtfirstname.Text);
                cmd.Parameters.AddWithValue("@Lname", txtlastname.Text);
                cmd.Parameters.AddWithValue("@contact", txtcontact.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@registration", txtregistration.Text);
                cmd.Parameters.AddWithValue("@status", StatusValue(cmbStatus.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Record Inserted Successfully");
                RemoveData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }


        }


        public void DisplayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvstudent.DataSource = dt;

            con.Close();
        }

        public int StatusValue(string s)
        {
            if (cmbStatus.Text == "Regular")
            {
                return 1;
            }

            return 0;
        }




        private void RemoveData()
        {
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            txtregistration.Text = "";
            cmbStatus.Text = "";
            Id = 0;
        }

        private void dgvstudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                Id = Convert.ToInt32(dgvstudent.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtfirstname.Text = dgvstudent.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtlastname.Text = dgvstudent.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtcontact.Text = dgvstudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtemail.Text = dgvstudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtregistration.Text = dgvstudent.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbStatus.Text = dgvstudent.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text != "" && txtlastname.Text != "" && txtcontact.Text != "" && txtemail.Text != "" &&
                txtregistration.Text != "" && cmbStatus.Text != "")  
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Student set FirstName=@Fname,LastName=@Lname, Contact=@contact,Email=@email,RegistrationNumber=@registration,Status=@status where Id=@id";
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@Fname", txtfirstname.Text);
                cmd.Parameters.AddWithValue("@Lname", txtlastname.Text);
                cmd.Parameters.AddWithValue("@contact", txtcontact.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@registration", txtregistration.Text);
                cmd.Parameters.AddWithValue("@status", StatusValue(cmbStatus.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Record Updated Successfully");
                RemoveData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete Student where Id=@id";
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Record Deleted Successfully!");
                RemoveData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}

