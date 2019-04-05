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
    public partial class RubricLevel : Form
    {
        
        /// <summary>
        /// Con is variable used for the connection of database with this project.
        /// </summary>
        
        SqlConnection con =
            new SqlConnection(@"Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");

        private int Id = 0;
        public RubricLevel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// on the load of rubric level form it fill the combo boxes with rubric ids that are added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RubricLevel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet16.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter1.Fill(this.projectBDataSet16.Rubric);
            // TODO: This line of code loads data into the 'projectBDataSet12.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet12.RubricLevel);
            // TODO: This line of code loads data into the 'projectBDataSet11.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet11.Rubric);

        }

        /// <summary>
        /// this function gets the level of rubric in the form of string and convert it into int value which is stored to db.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Level(string s)
        {
            if (cmbrubriclevel.Text == "Exceptional")
            {
                return 4;
            }
            else if (cmbrubriclevel.Text =="Good")
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
        /// <summary>
        /// this button is used to add the record in the data base from combo box or text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cmbrubriclevel.Text != "" && cmbid.Text != "" && txtrubricdetails.Text !="")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                        "insert into RubricLevel(RubricId, Details, MeasurementLevel) values(@rubricId,@details,@measurementlevel)";

                cmd.Parameters.AddWithValue("@rubricId", cmbid.Text);
                cmd.Parameters.AddWithValue("@measurementlevel", Level(cmbrubriclevel.Text));
                cmd.Parameters.AddWithValue("@details", txtrubricdetails.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Record Inserted Successfully");
                RemoveData();
              
            
            }
            else
            {
                MessageBox.Show("Please Provide Details With Correct Format!");
            }
        }
      /*  public int RubicId(String s)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Id FROM Rubric WHERE Details = '" + cmbid.Text + "'";
            return (int)cmd.ExecuteScalar();
        }*/
        /// <summary>
        /// this function is used to display the data in the grid view from db or textboxes.
        /// </summary>
        public void DisplayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from RubricLevel";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvrubriclevel.DataSource = dt;

            con.Close();
        }
        /// <summary>
        /// this function is used to remove data from textboxes.
        /// </summary>
        private void RemoveData()
        {
            cmbid.Text = "";
            txtrubricdetails.Text = "";
            cmbrubriclevel.Text = "";
            

        }
        /// <summary>
        /// this is used when we have to edit or delete the data, we select a row from the data grid view and the text boxes fill with that data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvrubriclevel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbid.Text = dgvrubriclevel.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtrubricdetails.Text = dgvrubriclevel.Rows[e.RowIndex].Cells[1].Value.ToString();


            con.Open();
           /* SqlCommand cmd0 = con.CreateCommand();
            cmd0.CommandType = CommandType.Text;
            cmd0.CommandText = "select Details from Rubric where Details = '" + dgvrubriclevel.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ";
            cmbid.Text = cmd0.ExecuteScalar().ToString();*/

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select MeasurementLevel from RubricLevel where MeasurementLevel = '" + dgvrubriclevel.Rows[e.RowIndex].Cells[2].Value.ToString() + "' ";
            if ((int) cmd2.ExecuteScalar() == 4)
            {
                cmbrubriclevel.Text = "Exceptional";
            }
            else if ((int)cmd2.ExecuteScalar() == 3)
            {
                cmbrubriclevel.Text = "Good";
            }
            else if ((int)cmd2.ExecuteScalar() == 2)
            {
                cmbrubriclevel.Text = "Fair";
            }
            else
            {
                cmbrubriclevel.Text = "Unsatisfactory";
            }

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select Id from RubricLevel where RubricId ='" + cmbid.Text + "' ";
            cmd1.ExecuteNonQuery();
            Id = Convert.ToInt32(cmd1.ExecuteScalar());
            con.Close();
            btnadd.Hide();
        }
        /// <summary>
        /// this is used to update the information that is selected from the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cmbid.Text != "" && cmbrubriclevel.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update RubricLevel set RubricId=@rubricId,Details=@details,MeasurementLevel=@measurementlevel where Id=@id";
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@rubricId", cmbid.Text);
                cmd.Parameters.AddWithValue("@details", txtrubricdetails.Text);
                
                cmd.Parameters.AddWithValue("@measurementlevel", Level(cmbrubriclevel.Text));
                
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

        /// <summary>
        /// this is used to delete the information that is selected from the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (cmbid.Text != "" && cmbrubriclevel.Text != "" && txtrubricdetails.Text !="")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from StudentResult where RubricMeasurementId=@rid";
                cmd.Parameters.AddWithValue("@rid", Id);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete RubricLevel where Id=@id";
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

        /// <summary>
        /// this label is used to navigate to home page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblhome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
        /// <summary>
        /// this label is used to navigate to Student result page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentResult s = new StudentResult();
            s.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AssessmentComponent a = new AssessmentComponent();
            a.Show();
            this.Hide();
        }
    }
}
