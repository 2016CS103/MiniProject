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
        SqlConnection con = new SqlConnection(@"Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");
        private int Id = 0;
        public ManageAssessments()
        {
            InitializeComponent();
        }

        private void ManageAssessments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet4.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet4.Assessment);

        }

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

        private void RemoveData()
        {
            txttitle.Text = "";
            txttotalmarks.Text = "";
            txttotalweightage.Text = "";

        }

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

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (Id != 0 && txttitle.Text != "" && txttotalmarks.Text != "" && txttotalweightage.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
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
    }
}
