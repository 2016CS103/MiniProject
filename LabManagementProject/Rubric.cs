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
    public partial class Rubric : Form
    {
        /// <summary>
        /// Con is variable used for the connection of database with this project.
        /// </summary>
        SqlConnection con =
            new SqlConnection(@"Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");

        private int Id = 0;

        public Rubric()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is form load function which dispaly data that is already present in dataGridView and fill the combox from the values of database.
        /// </summary>

        private void Rubric_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet6.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter1.Fill(this.projectBDataSet6.Clo);
            // TODO: This line of code loads data into the 'projectBDataSet3.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet3.Clo);
            // TODO: This line of code loads data into the 'projectBDataSet2.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet2.Rubric);

        }

        
        /// <summary>
        /// click event of add button, First Check valid values then add them to dataGridView and display the newly added data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnaddrubric_Click(object sender, EventArgs e)
        {
            if (txtrubricid.Text != "" && rchclodetails.Text !="" && cmbcloid.Text!="")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                SqlCommand query = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                query.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Rubric(Id, Details, CloId) values(@Id, @details, @cloid) ";
                cmd.Parameters.AddWithValue("@Id", txtrubricid.Text);
                cmd.Parameters.AddWithValue("@details", rchclodetails.Text);
                query.CommandText = "Select Id from Clo where Name = '" + cmbcloid.Text + "' ";
                cmd.Parameters.AddWithValue("@cloid", (int)query.ExecuteScalar());
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Record Inserted Successfully");
                RemoveData();
            }
            else
            {
                MessageBox.Show("Please Fill the text fields!");
            }
        }
        /// <summary>
        /// this function is used to display the data in the dataGridView
        /// </summary>

        public void DisplayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Rubric";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvrubric.DataSource = dt;

            con.Close();
        }
        /// <summary>
        /// this function is used to remove data from textboxes.
        /// </summary>
        private void RemoveData()
        {
            txtrubricid.Text = "";
            rchclodetails.Text = "";
            cmbcloid.Text = "";

        }
        /// <summary>
        /// that function fill the textboxes with the data that is selected for updation or deletion purpose.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dgvrubric_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dgvrubric.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtrubricid.Text = dgvrubric.Rows[e.RowIndex].Cells[0].Value.ToString();
            rchclodetails.Text = dgvrubric.Rows[e.RowIndex].Cells[1].Value.ToString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name from Clo where Id = '"+ dgvrubric.Rows[e.RowIndex].Cells[2].Value.ToString() + "' ";
            cmbcloid.Text = cmd.ExecuteScalar().ToString();
            con.Close();



            btnaddrubric.Hide();
        }
        /// <summary>
        /// Click event of the update button in which updated data is inserted into the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtrubricid.Text != "" && rchclodetails.Text != "" && cmbcloid.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                SqlCommand query = con.CreateCommand();
                query.CommandType = CommandType.Text;
                cmd.CommandText = "update Rubric set Id = @id, Details = @details, CloId = @cloid where Id=@id ";
                cmd.Parameters.AddWithValue("@id", txtrubricid.Text);
                cmd.Parameters.AddWithValue("@details", rchclodetails.Text);
                query.CommandText = "Select Id from Clo where Name = '" + cmbcloid.Text + "' ";
                cmd.Parameters.AddWithValue("@cloid", (int)query.ExecuteScalar());
                //  cmd.Parameters.AddWithValue("@cloid", cmbcloid.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Record Updated Successfully");
                RemoveData();
                btnaddrubric.Show();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        /// <summary>
        /// click event of delete button that is used to delete the selected row from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtrubricid.Text != "" && rchclodetails.Text != "" && cmbcloid.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete Rubric where Id=@id";
                cmd.Parameters.AddWithValue("@id", txtrubricid.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Record Deleted Successfully!");
                RemoveData();
                btnaddrubric.Show();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
        /// <summary>
        /// link label for clo form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clo c = new Clo();
            c.Show();
            this.Hide();
        }
        /// <summary>
        /// link label for student form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmStudent s = new FrmStudent();
            s.Show();
            this.Hide();


        }
        /// <summary>
        /// link label for the home.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }

}


