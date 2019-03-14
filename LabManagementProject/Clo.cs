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
        SqlConnection con = new SqlConnection(@"Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");
        private int Id = 0;
        public Clo()
        {
            InitializeComponent();
        }

        private void Clo_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'projectBDataSet.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet.Clo);

        }

        private void btnaddclo_Click(object sender, EventArgs e)
        {
            if (txtcloname.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Clo(Name, DateCreated, DateUpdated) values(@name, @datecreated, @dateupdated) ";
                cmd.Parameters.AddWithValue("@name", txtcloname.Text);
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
                MessageBox.Show("Please Enter Name of Clo With Correct Format!");
            }
        }
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
        private void RemoveData()
        {
            txtcloname.Text = "";
            
        }

        

        private void dgvclo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                Id = Convert.ToInt32(dgvclo.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtcloname.Text = dgvclo.Rows[e.RowIndex].Cells[1].Value.ToString();
                btnaddclo.Hide();
                
            }

        }

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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Rubric r = new Rubric();
            r.Show();
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
