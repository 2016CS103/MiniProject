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
    public partial class AssessmentComponent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");
        private int Id = 0;
        public AssessmentComponent()
        {
            InitializeComponent();
        }

        private void AssessmentComponent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet10.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet10.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet9.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet9.Rubric);
            // TODO: This line of code loads data into the 'projectBDataSet8.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet8.Assessment);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txttotalmarks.Text != "" )
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM AssessmentComponent WHERE Name = @name AND AssessmentId =@assessmentId ";
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@assessmentId", AssessmentId(cmbassessment.Text));
                int records = (int)cmd.ExecuteScalar();
                if (records == 0)
                {
                    cmd.CommandText = "insert into AssessmentComponent(Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) values(@name,@rubricId,@totalmarks,@datecreated,@dateupdated,@assessmentId)";
                   // cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@rubricId", RubicId(cmbrubric.Text));
                    cmd.Parameters.AddWithValue("@totalmarks", txttotalmarks.Text);
                    cmd.Parameters.AddWithValue("@datecreated", DateTime.Now);
                    cmd.Parameters.AddWithValue("@dateupdated", DateTime.Now);
                    
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DisplayData();
                    MessageBox.Show("Record Inserted Successfully");
                    RemoveData();
                }
                else
                {
                    MessageBox.Show("Record Already Exist!");
                    RemoveData();
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Please Provide Details With Correct Format!");
            }
        }
        private void RemoveData()
        {
            txtname.Text = "";
            txttotalmarks.Text = "";

        }

        public int RubicId(String s)
        {
           
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Id FROM Rubric WHERE Details = '"+ cmbrubric.Text +"'";
            return (int) cmd.ExecuteScalar();
        }

        public int AssessmentId(String s)
        {
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Id FROM Assessment WHERE Title = '" + cmbassessment.Text + "'";
            return (int)cmd.ExecuteScalar();
        }
        public void DisplayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AssessmentComponent";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvassessmentcomponent.DataSource = dt;

            con.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txttotalmarks.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update AssessmentComponent set Name=@name,TotalMarks=@totalmarks,DateUpdated=@dateupdated,AssessmentId=@assessmentId,RubricId=@rubricId  where Id=@id";
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@totalmarks", txttotalmarks.Text);
                cmd.Parameters.AddWithValue("@dateupdated", DateTime.Now);
                cmd.Parameters.AddWithValue("@assessmentId", AssessmentId(cmbassessment.Text));
                cmd.Parameters.AddWithValue("@rubricId", RubicId(cmbrubric.Text));
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

        private void dgvassessmentcomponent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtname.Text = dgvassessmentcomponent.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttotalmarks.Text = dgvassessmentcomponent.Rows[e.RowIndex].Cells[2].Value.ToString();
            con.Open();
            SqlCommand cmd0 = con.CreateCommand();
            cmd0.CommandType = CommandType.Text;
            cmd0.CommandText = "select Details from Rubric where Id = '" + dgvassessmentcomponent.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ";
            cmbrubric.Text = cmd0.ExecuteScalar().ToString();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select Title from Assessment where Id = '" + dgvassessmentcomponent.Rows[e.RowIndex].Cells[5].Value.ToString() + "' ";
            cmbassessment.Text = cmd2.ExecuteScalar().ToString();


            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select Id from AssessmentComponent where Name ='" + txtname.Text + "' ";
            cmd1.ExecuteNonQuery();
            Id = Convert.ToInt32(cmd1.ExecuteScalar());
            con.Close();
            btnadd.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txttotalmarks.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete AssessmentComponent where Id=@id";
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Record Deleted Successfully!");
                RemoveData();
                btnadd.Show();
                
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
                btnadd.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RubricLevel r = new RubricLevel();
            r.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageAssessments m = new ManageAssessments();
            m.Show();
            this.Hide();
        }
    }
}
