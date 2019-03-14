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
        SqlConnection con =
            new SqlConnection(@"Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");

        private int Id = 0;

        public Rubric()
        {
            InitializeComponent();
        }

        private void Rubric_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet3.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet3.Clo);
            // TODO: This line of code loads data into the 'projectBDataSet2.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet2.Rubric);

        }

        private void btnaddrubric_Click(object sender, EventArgs e)
        {
            if (txtrubricid.Text != "" && rchclodetails.Text !="" && cmbcloid.Text!="")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Rubric(Id, Details, CloId) values(@Id, @details, @cloid) ";
                cmd.Parameters.AddWithValue("@Id", txtrubricid.Text);
                cmd.Parameters.AddWithValue("@details", rchclodetails.Text);
                cmd.Parameters.AddWithValue("@cloid", cmbcloid.Text);
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
        private void RemoveData()
        {
            txtrubricid.Text = "";
            rchclodetails.Text = "";
            cmbcloid.Text = "";

        }

        private void dgvrubric_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dgvrubric.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtrubricid.Text = dgvrubric.Rows[e.RowIndex].Cells[0].Value.ToString();
            rchclodetails.Text = dgvrubric.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbcloid.Text = dgvrubric.Rows[e.RowIndex].Cells[2].Value.ToString();



            btnaddrubric.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtrubricid.Text != "" && rchclodetails.Text != "" && cmbcloid.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Rubric set Id = @id, Details = @details, CloId = @cloid where Id=@id ";
                cmd.Parameters.AddWithValue("@id", txtrubricid.Text);
                cmd.Parameters.AddWithValue("@details", rchclodetails.Text);
                cmd.Parameters.AddWithValue("@cloid", cmbcloid.Text);
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Clo c = new Clo();
            c.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmStudent s = new FrmStudent();
            s.Show();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }
    }

}


