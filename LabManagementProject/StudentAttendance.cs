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
    public partial class StudentAttendance : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");
       // private int Id = 0;
        public StudentAttendance()
        {
            InitializeComponent();
        }

        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet7.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet7.Student);
            ComboBoxFill();

        }

        public void ComboBoxFill()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name from Lookup where Category='ATTENDANCE_STATUS'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmbstatus.DisplayMember = "Name";
            cmbstatus.DataSource = dt;
            con.Close();
        }

        private void btnmarkattendance_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                SqlCommand query = con.CreateCommand();
                query.CommandType = CommandType.Text;
                SqlCommand query1 = con.CreateCommand();
                query1.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into ClassAttendance (AttendanceDate) values(@attendance)";
                cmd.Parameters.AddWithValue("@attendance", dateTimePicker1.Value.ToString("MM/dd/yyyy"));
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Insert into StudentAttendance (AttendanceId, StudentId, AttendanceStatus) values(@attendanceid, @studentId, @attendancestatus)";
                query1.CommandText = "Select Id from Student where RegistrationNumber = '" + cmbregistrationnumber.Text + "'";
                query.CommandText = "select Id from ClassAttendance where AttendanceDate = '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "'";
                cmd.Parameters.AddWithValue("@attendanceid", (int)query.ExecuteScalar());
                cmd.Parameters.AddWithValue("@studentId", (int)query1.ExecuteScalar());
                cmd.Parameters.AddWithValue("@attendancestatus", StatusValue(cmbstatus.Text));
                cmd.ExecuteNonQuery();
                query.ExecuteNonQuery();
                query1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Attendance Marked Successfully");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("You have already marked attendance for this student");
            }

            
        }

        public int StatusValue(string s)
        {
            if (cmbstatus.Text == "Present")
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select LookupId from Lookup where Name='Present'";
                cmd.ExecuteNonQuery();
                return (int)cmd.ExecuteScalar();


            }
            else if(cmbstatus.Text == "Absent")
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select LookupId from Lookup where Name='Absent'";
                cmd.ExecuteNonQuery();
                return (int)cmd.ExecuteScalar();
            }
            else if (cmbstatus.Text == "Leave")
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select LookupId from Lookup where Name='Leave'";
                cmd.ExecuteNonQuery();
                return (int)cmd.ExecuteScalar();
            }
            else
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select LookupId from Lookup where Name='Late'";
                cmd.ExecuteNonQuery();
                return (int)cmd.ExecuteScalar();
            }

        }

        private void lblbacktohome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void lblassessment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageAssessments m = new ManageAssessments();
            m.Show();
            this.Hide();
        }
    }
}
