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
    public partial class StudentResult : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");
        private int Id = 0;
        public StudentResult()
        {
            InitializeComponent();
        }

        private void StudentResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet15.StudentResult' table. You can move, or remove it, as needed.
            this.studentResultTableAdapter.Fill(this.projectBDataSet15.StudentResult);
            // TODO: This line of code loads data into the 'projectBDataSet14.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet14.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet13.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet13.Student);

        }
        public void DisplayData()
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from StudentResult ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvresult.DataSource = dt;

            con.Close();
        }


        public int Level(string s)
        {
            if (cmbrubriclevel.Text == "Exceptional")
            {
                return 4;
            }
            else if (cmbrubriclevel.Text == "Good")
            {
                return 3;
            }
            else if (cmbrubriclevel.Text == "Fair")
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        private void btneveluate_Click(object sender, EventArgs e)
        {
            int record = Level(cmbrubriclevel.Text);
           
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            SqlCommand query = con.CreateCommand();
            query.CommandType = CommandType.Text;
            SqlCommand query0 = con.CreateCommand();
            query0.CommandType = CommandType.Text;
            SqlCommand query1 = con.CreateCommand();
            query1.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into StudentResult (StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) values(@studentId, @assessmentcomponentid, @rubricmeasurementid, @evaluationdate)";
            query1.CommandText = "Select Id from Student where RegistrationNumber = '" + cmbregistration.Text + "'";
            query.CommandText = "Select Id from AssessmentComponent where Name = '" + cmbassessment.Text + "' ";
            query0.CommandText = "Select Id from RubricLevel where  MeasurementLevel ='" +record+"' ";
            cmd.Parameters.AddWithValue("@assessmentcomponentid", (int)query.ExecuteScalar());
            cmd.Parameters.AddWithValue("@studentId", (int)query1.ExecuteScalar());
            cmd.Parameters.AddWithValue("@rubricmeasurementid", (int)query0.ExecuteScalar());
            cmd.Parameters.AddWithValue("@evaluationdate", dateTimePicker1.Value.ToString("MM/dd/yyyy"));
            cmd.ExecuteNonQuery();
            query.ExecuteNonQuery();
            query1.ExecuteNonQuery();
            query0.ExecuteNonQuery();
            MessageBox.Show("evaluation marked ");
            DisplayData();
            con.Close();
            
        }   
    }
}
