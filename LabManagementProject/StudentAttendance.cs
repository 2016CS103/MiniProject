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
        /// <summary>
        /// Con is variable used for the connection of database with this project.
        /// </summary>
        SqlConnection con = new SqlConnection(@"Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");
       // private int Id = 0;
        public StudentAttendance()
        {
            InitializeComponent();
        }
        /// <summary>
        /// on the load of form this function fill the data in combo box .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet7.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet7.Student);
            ComboBoxFill();

        }
        /// <summary>
        /// this function fills the status combo box with the attendance status.
        /// </summary>
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
        /// <summary>
        /// this is used to mark the attendance and save all the record to database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show(ex.Message +"You have already marked attendance for this student");
            }

            
        }
        /// <summary>
        /// this function converts the status string to int value which is stored to database.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
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
        /// <summary>
        /// link label is used to navigate to home page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblbacktohome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
        /// <summary>
        /// link label is used to navigate to manage assessment page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblassessment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageAssessments m = new ManageAssessments();
            m.Show();
            this.Hide();
        }
    }
}
