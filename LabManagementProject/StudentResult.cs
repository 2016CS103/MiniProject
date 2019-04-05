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
        // private int Id = 0;
        int a, Marks, compMarks;
        public StudentResult()
        {
            InitializeComponent();
        }

        private void StudentResult_Load(object sender, EventArgs e)
        {
             

            
            DisplayData();
            ComboboxFill();



            // TODO: This line of code loads data into the 'projectBDataSet18.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter1.Fill(this.projectBDataSet18.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet17.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet17.Assessment);
            // TODO: This line of code loads data into the 'projectBDataSet15.StudentResult' table. You can move, or remove it, as needed.
            this.studentResultTableAdapter.Fill(this.projectBDataSet15.StudentResult);
            // TODO: This line of code loads data into the 'projectBDataSet14.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet14.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet13.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet13.Student);

            

        }
        


        public int Level(string s)
        {
            if (cmbrubricdetail.Text == "Exceptional")
            {
                return 4;
            }
            else if (cmbrubricdetail.Text == "Good")
            {
                return 3;
            }
            else if (cmbrubricdetail.Text == "Fair")
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
            int record = Level(cmbrubricdetail.Text);
           
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
            query.CommandText = "Select Id from AssessmentComponent where Name = '" + cmbassessmentcomponent.Text + "' ";
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmStudent s = new FrmStudent();
            s.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageAssessments m = new ManageAssessments();
            m.Show();
            this.Hide();
        }

        private void cmbassessment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbassessmentcomponent.Items.Clear();
            string q = "SELECT * FROM Assessment WHERE Title = '" + cmbassessment.Text + "'";
            SqlCommand cmda = new SqlCommand(q, con);
           
            con.Open();
            int r = Convert.ToInt32(cmda.ExecuteScalar());
            
            con.Close();
            string query2 = "SELECT Id FROM AssessmentComponent WHERE AssessmentId = '" + r + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader reader2;
            try
            {
                con.Open();
                reader2 = cmd2.ExecuteReader();
                
                while (reader2.Read())
                {
                    cmbassessmentcomponent.Items.Add(reader2[0]);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            
        }

        private void cmbassessmentcomponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbrubricdetail.Items.Clear();
            string q = "SELECT RubricId FROM AssessmentComponent WHERE Id = '" + cmbassessmentcomponent.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            
            con.Open();
            int r = Convert.ToInt32(cmd.ExecuteScalar());
            
            con.Close();
            string query2 = "SELECT Details FROM Rubric WHERE Id = '" + r + "'";
            SqlCommand cmd0 = new SqlCommand(query2, con);
            cmbrubricdetail.Items.Clear();
            SqlDataReader reader2;
            try
            {
                con.Open();
                reader2 = cmd0.ExecuteReader();
                
                while (reader2.Read())
                {
                    cmbrubricdetail.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmbrubricdetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbrubriclevel.Items.Clear();
            string q = "SELECT Id FROM Rubric WHERE Details = '" + cmbrubricdetail.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            
            con.Open();
            int r = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            string query2 = "SELECT MeasurementLevel FROM RubricLevel WHERE RubricId = '" + r + "'";
            SqlCommand cmd0 = new SqlCommand(query2, con);
           
            SqlDataReader reader2;
            try
            {
                con.Open();
                reader2 = cmd0.ExecuteReader();
                
                while (reader2.Read())
                {
                    cmbrubriclevel.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string level = cmbrubriclevel.Text;
                int level1 = Convert.ToInt32(level);
                int maxlevel = 4;
                string q = "SELECT TotalMarks FROM AssessmentComponent WHERE Id = '" + cmbassessmentcomponent.Text + "'";
                SqlCommand cmda = new SqlCommand(q, con);
                con.Open();
                int r = Convert.ToInt32(cmda.ExecuteScalar());
                con.Close();
                compMarks = r;
                Marks = (level1 / maxlevel) * compMarks;
                string query =
                    "INSERT into StudentResult(StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) values ('" +
                    cmbregistration.Text + "', '" + cmbassessmentcomponent.Text + "', '" + cmblevelid.Text + "', '" +
                    dateTimePicker1.Value + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader;

                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Evaluation marked successfully");
                con.Close();
                DisplayData();
                con.Close();
                ComboboxFill();

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
           
            
          
           
        }
       
        

        private void cmbrubriclevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query2 = "SELECT Id FROM RubricLevel WHERE MeasurementLevel = '" + cmbrubriclevel.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
           
            SqlDataReader reader2;
            try
            {
                con.Open();
                reader2 = cmd2.ExecuteReader();
                
                while (reader2.Read())
                {
                    cmblevelid.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

       

        private void dgvresult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id1 = Convert.ToInt32(dgvresult.Rows[e.RowIndex].Cells[3].Value);
            int id2 = Convert.ToInt32(dgvresult.Rows[e.RowIndex].Cells[2].Value);
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    this.dgvresult.Rows.RemoveAt(e.RowIndex);
                    string query = "DELETE FROM StudentResult WHERE StudentId = @id1 and AssessmentComponentId = @id2";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@id1", id1));
                    cmd.Parameters.Add(new SqlParameter("@id2", id2));
                    cmd.ExecuteReader();
                    con.Close();

                }
            }
        }

        private void cmbregistration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ComboboxFill()
        {
            string query = "SELECT Id FROM Student";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbregistration.Items.Add(reader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            string query1 = "SELECT Title FROM Assessment";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader reader1;
            try
            {
                con.Open();
                reader1 = cmd1.ExecuteReader();
            
                while (reader1.Read())
                {
                    cmbassessment.Items.Add(reader1[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }


        public void DisplayData()
        {
            string q1 =
                "SELECT StudentResult.AssessmentComponentId, StudentResult.StudentId, Student.FirstName As Student, Rubric.Details, Assessment.Title AS AssessmentTitle, AssessmentComponent.TotalMarks AS ComponentMarks, RubricLevel.MeasurementLevel FROM StudentResult JOIN Student On StudentResult.StudentId = Student.Id JOIN AssessmentComponent ON Assessmentcomponent.Id = StudentResult.AssessmentComponentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id Join Assessment ON Assessment.Id = AssessmentComponent.AssessmentId ";
            SqlDataAdapter d = new SqlDataAdapter(q1, con);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dgvresult.DataSource = dt;
            dgvresult.Columns["AssessmentComponentId"].Visible = false;
            dgvresult.Columns["StudentId"].Visible = false;

            int count = dgvresult.RowCount;
            for (int i = 0; i < count; i++)
            {
                double k = Convert.ToDouble(dgvresult.Rows[i].Cells["ComponentMarks"].Value);
                double l = Convert.ToDouble(dgvresult.Rows[i].Cells["MeasurementLevel"].Value);
                double marks = Convert.ToDouble((l / 4) * k);
                dgvresult.Rows[i].Cells["ObtainedMarks"].Value = marks;
            }

            cmbregistration.Items.Clear();
            cmbassessment.Items.Clear();
            cmbassessmentcomponent.Items.Clear();
            cmbrubricdetail.Items.Clear();
            cmbrubriclevel.Items.Clear();
            cmblevelid.Items.Clear();





            // con.Close();
        }
    }
}
