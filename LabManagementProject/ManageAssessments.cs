using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManagementProject
{
    public partial class ManageAssessments : Form
    {
        /// <summary>
        /// Con is variable used for the connection of database with this project.
        /// </summary>
        SqlConnection con = new SqlConnection(@"Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");
        private int Id = 0;
        public ManageAssessments()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is used to load the data of assessment in the grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageAssessments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet4.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet4.Assessment);

        }
        /// <summary>
        /// this function is used to add the assessment to data base and display the data is grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnaddassessment_Click(object sender, EventArgs e)
        {
            if (txttitle.Text != "" && txttotalmarks.Text != "" && txttotalweightage.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM Assessment WHERE Title = @title";
                cmd.Parameters.AddWithValue("@title", txttitle.Text);
                int records = (int)cmd.ExecuteScalar();
                if (records == 0)
                {
                    cmd.CommandText = "insert into Assessment(Title, DateCreated, TotalMarks, TotalWeightage) values(@title, @datecreated, @totalmarks, @totalweightage) ";
                   // cmd.Parameters.AddWithValue("@title", txttitle.Text);
                    cmd.Parameters.AddWithValue("@datecreated", DateTime.Now);
                    cmd.Parameters.AddWithValue("@totalmarks", txttotalmarks.Text);
                    cmd.Parameters.AddWithValue("@totalweightage", txttotalweightage.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    DisplayData();
                    MessageBox.Show("Record Inserted Successfully");
                    RemoveData();
                }
                else
                {
                    MessageBox.Show("Record Already Exist!");
                    con.Close();
                    RemoveData();

                }

            }
            else
            {
                MessageBox.Show("Please Enter  Name of Assessment!");
            }

          
        }
        /// <summary>
        /// this function is used to remove data from the all text boxes.
        /// </summary>
        private void RemoveData()
        {
            txttitle.Text = "";
            txttotalmarks.Text = "";
            txttotalweightage.Text = "";

        }
        /// <summary>
        /// this function is used to display data in the data grid view.
        /// </summary>
        public void DisplayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Assessment";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvassessment.DataSource = dt;

            con.Close();
        }

        private void ManageAssessments_MouseClick(object sender, MouseEventArgs e)
        {

        }
        /// <summary>
        /// this is used to select data from row and fill the text boxes with the selected data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvassessment_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          //  Id = Convert.ToInt32(dgvassessment.Rows[e.RowIndex].Cells[0].Value.ToString());
            txttitle.Text = dgvassessment.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttotalmarks.Text = dgvassessment.Rows[e.RowIndex].Cells[2].Value.ToString();
            txttotalweightage.Text = dgvassessment.Rows[e.RowIndex].Cells[3].Value.ToString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Id from Assessment where Title ='" + txttitle.Text + "' ";
            cmd.ExecuteNonQuery();
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            btnaddassessment.Hide();
        }
        /// <summary>
        /// this is used to update the selected data from the data base.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txttitle.Text != "" && txttotalmarks.Text != "" && txttotalweightage.Text !="")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                        "update Assessment set Title = @title, TotalMarks = @totalmarks, TotalWeightage = @totalweightage where Id=@id ";
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@title", txttitle.Text);
                cmd.Parameters.AddWithValue("@totalmarks", txttotalmarks.Text);
                cmd.Parameters.AddWithValue("@totalweightage", txttotalweightage.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Record Updated Successfully");
                RemoveData();
                btnaddassessment.Show();
             }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        /// <summary>
        /// this is used to delete the selected data from the data base.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (Id != 0 && txttitle.Text != "" && txttotalmarks.Text != "" && txttotalweightage.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from AssessmentComponent where AssessmentId=@cid";
                cmd.Parameters.AddWithValue("@cid", Id);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from Assessment where Id=@id";
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Record Deleted Successfully!");
                RemoveData();
                btnaddassessment.Show();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
                btnaddassessment.Show();
            }
        }
        /// <summary>
        /// this label is used to navigate to home page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
        /// <summary>
        /// this label is used to navigate to assesment component.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AssessmentComponent a = new AssessmentComponent();
            a.Show();
            this.Hide();
        }
    }
}
