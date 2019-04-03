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
    public partial class Clo : Form
    {
        /// <summary>
        /// Con is variable used for the connection of database with this project.
        /// </summary>
        SqlConnection con = new SqlConnection(@"Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");
        private int Id = 0;
        public Clo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is form load function which dispaly data that is already present in dataGridView and fill the combox from the values of database.
        /// </summary>

        private void Clo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet5.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter1.Fill(this.projectBDataSet5.Clo);

           

        }
        /// <summary>
        /// click event of add button, First Check valid values then add them to dataGridView and display the newly added data.
        /// </summary>

        private void btnaddclo_Click(object sender, EventArgs e)
        {
            if (txtcloname.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(Name) FROM Clo WHERE Name = @name";
                cmd.Parameters.AddWithValue("@name", txtcloname.Text);
                int records = (int)cmd.ExecuteScalar();
                if (records == 0)
                {
                    
                    cmd.CommandText =
                        "insert into Clo(Name, DateCreated, DateUpdated) values(@name, @datecreated, @dateupdated) ";
                    
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
                    con.Close();
                    RemoveData();

                }
            }
            else
            {
                MessageBox.Show("Please Enter Name of Clo!");
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
            cmd.CommandText = "select * from Clo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvclo.DataSource = dt;

            con.Close();
        }
        /// <summary>
        /// this function is used to remove data from textboxes.
        /// </summary>
        private void RemoveData()
        {
            txtcloname.Text = "";
            
        }
        /// <summary>
        /// that function fill the textboxes with the data that is selected for updation or deletion purpose.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void dgvclo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                txtcloname.Text = dgvclo.Rows[e.RowIndex].Cells[0].Value.ToString();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id from Clo where Name ='" + txtcloname.Text + "' ";
                cmd.ExecuteNonQuery();
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                btnaddclo.Hide();
                
            }

        }
        /// <summary>
        /// Click event of the update button in which updated data is inserted into the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtcloname.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Clo set Name = @name, DateUpdated = @dateupdated where Id=@id ";
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@name", txtcloname.Text);
                cmd.Parameters.AddWithValue("@dateupdated", DateTime.Now);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Record Updated Successfully");
                RemoveData();
                btnaddclo.Show();
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
            if (Id != 0 && txtcloname.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Rubric where CloId=@cid";
                cmd.Parameters.AddWithValue("@cid", Id);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from Clo where Id=@id";
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Record Deleted Successfully!");
                RemoveData();
                btnaddclo.Show();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
                btnaddclo.Show();
            }
        }
        /// <summary>
        /// link label for Rubric form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rubric r = new Rubric();
            r.Show();
            this.Hide();
        }
        /// <summary>
        /// link label for Student form.
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
        /// link label for home.
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
