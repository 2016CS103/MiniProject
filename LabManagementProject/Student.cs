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
using System.Text.RegularExpressions;

namespace LabManagementProject
{
    public partial class FrmStudent : Form
    {
        /// <summary>
        /// Con is variable used for the connection of database with this project.
        /// </summary>
        SqlConnection con = new SqlConnection(@"Data Source = FARAZ; Initial Catalog = ProjectB; Integrated Security = True");
        private int Id = 0;

        public FrmStudent()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// this is form load function which dispaly data that is already present in dataGridView and fill the combox from the values of database.
        /// </summary>
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            ComboBoxFill();
            DisplayData();



        }
        /// <summary>
        /// click event of add button, First Check valid values then add them to dataGridView and display the newly added data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnaddstudent_Click(object sender, EventArgs e)
        {   
            if (txtfirstname.Text != "" && txtlastname.Text != "" && txtcontact.Text != "" && txtemail.Text != "" &&
                txtregistration.Text != "" && cmbStatus.Text != "" &&  IsValid())
                
                
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM Student WHERE RegistrationNumber = @registration";
                cmd.Parameters.AddWithValue("@registration", txtregistration.Text);
                int records = (int)cmd.ExecuteScalar();
                if (records == 0)
                {
                    cmd.CommandText ="insert into Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values(@Fname,@Lname,@contact,@email,@registration,@status)";
                    cmd.Parameters.AddWithValue("@Fname", txtfirstname.Text);
                    cmd.Parameters.AddWithValue("@Lname", txtlastname.Text);
                    cmd.Parameters.AddWithValue("@contact", txtcontact.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                  //cmd.Parameters.AddWithValue("@registration", txtregistration.Text);
                    cmd.Parameters.AddWithValue("@status", StatusValue(cmbStatus.Text));
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
                }

            }
            else
            {
                MessageBox.Show("Please Provide Details With Correct Format!");
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
            cmd.CommandText = "select * from student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvstudent.DataSource = dt;

            con.Close();
        }

        /// <summary>
        /// this function is used to fill the data in the combobox.
        /// </summary>
        public void ComboBoxFill()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name from Lookup where Category='STUDENT_STATUS'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmbStatus.DisplayMember = "Name";
            cmbStatus.DataSource = dt;
            con.Close();
        }
        /// <summary>
        /// this function is used to convert the string value into int value.
        /// </summary>
        /// <param name="s">string Argument</param>
        /// <returns>convert the string into int</returns>

        public int StatusValue(string s)
        {
            if (cmbStatus.Text == "Active")
            {
           
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select LookupId from Lookup where Name='Active'";
                cmd.ExecuteNonQuery();
                return (int)cmd.ExecuteScalar();
                 

            }
            else
            {
              
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select LookupId from Lookup where Name='InActive'";
                cmd.ExecuteNonQuery();
                return (int)cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// this function is used to remove data from textboxes.
        /// </summary>


        private void RemoveData()
        {
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            txtregistration.Text = "";
            cmbStatus.Text = "";
            Id = 0;
        }
        /// <summary>
        /// that function fill the textboxes with the data that is selected for updation or deletion purpose.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dgvstudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                Id = Convert.ToInt32(dgvstudent.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtfirstname.Text = dgvstudent.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtlastname.Text = dgvstudent.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtcontact.Text = dgvstudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtemail.Text = dgvstudent.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtregistration.Text = dgvstudent.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbStatus.Text = dgvstudent.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
        }
        /// <summary>
        /// Click event of the update button in which updated data is inserted into the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (IsValid() && txtfirstname.Text != "" && txtlastname.Text != "" && txtcontact.Text != "" && txtemail.Text != "" &&
                txtregistration.Text != "" && cmbStatus.Text != "")  
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM Student WHERE RegistrationNumber = @registration";
                cmd.Parameters.AddWithValue("@registration", txtregistration.Text);
               
                int records = (int)cmd.ExecuteScalar();
                if (records == 0)
                {
                    cmd.CommandText =
                        "update Student set FirstName=@Fname,LastName=@Lname, Contact=@contact,Email=@email,RegistrationNumber=@registration,Status=@status where Id=@id";
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@Fname", txtfirstname.Text);
                    cmd.Parameters.AddWithValue("@Lname", txtlastname.Text);
                    cmd.Parameters.AddWithValue("@contact", txtcontact.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    //  cmd.Parameters.AddWithValue("@registration", txtregistration.Text);
                    cmd.Parameters.AddWithValue("@status", StatusValue(cmbStatus.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DisplayData();
                    MessageBox.Show("Record Updated Successfully");
                    RemoveData();
                }
                else
                {
                    MessageBox.Show("Record Already Exist!");
                    con.Close();
                }
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
            if (Id != 0)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete Student where Id=@id";
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Record Deleted Successfully!");
                RemoveData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        /// <summary>
        /// regular expression for the validation of Email.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            string pattren = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                             @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                             @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (Regex.IsMatch(txtemail.Text, pattren))
            {
                errorProvider3.Clear();
            }
            else
            {
                 errorProvider3.SetError(this.txtemail, "Enter the Email address in correct format");
                return;
            }

        }
        /// <summary>
        /// regular expression for the validation of first name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtfirstname.Text, @"^[A-Z][a-zA-Z]*$"))
            {
                errorProvider1.Clear();
                
            }
            else
            {
                errorProvider1.SetError(txtfirstname, "Only use alphabets & Use first letter Capital");
                return;
            }
        }
        /// <summary>
        /// regular expression for the validation of last name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtlastname.Text, @"^[A-Z][a-zA-Z]*$"))
            {
                errorProvider2.Clear();
                
            }
            else
            {
                errorProvider2.SetError(txtlastname, "Only use alphabets & Use first letter Capital");
                return;
            }
        }
        /// <summary>
        /// regular expression for the validation of contact number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtcontact.Text, @"^(\+)?([9]{1}[2]{1})?-? ?(\()?([0]{1})?[1-9]{2,4}(\))?-? ??(\()?[1-9]{4,7}(\))?$"))
            {
                errorProvider4.Clear();

            }
            else
            {
                errorProvider4.SetError(txtcontact, "Enter Valid phone Number. Use that Format +92 321 7469854 | 923217469857 | 041 2680226");
                return;
            }

        }
        /// <summary>
        /// regular expression for the validation of registration number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtregistration_TextChanged(object sender, EventArgs e)
        {
            
            if (Regex.IsMatch(txtregistration.Text, @"^(\d{4}-[A-Z|a-z]{2}-\d{1,4})?$"))
            {
                errorProvider5.Clear();

            }
            else
            {
                errorProvider5.SetError(txtregistration, "Enter Valid Registration Number. Use that Format 2016-CS-103");
                return;
                
            }

            


        }
        /// <summary>
        /// this fuction check that if any error provider indicates error than it return false and data can't inserted in data base. 
        /// </summary>
        /// <returns>true or false value depend upon whether data is valid </returns>


        public bool IsValid()
        {
            foreach (Control c in this.Controls)
            {
                if (errorProvider1.GetError(c).Length > 0)
                {
                    return false;
                }
                else if (errorProvider2.GetError(c).Length > 0)
                {
                    return false;
                }
                else if (errorProvider3.GetError(c).Length > 0)
                {
                    return false;
                }
                else if (errorProvider4.GetError(c).Length > 0)
                {
                    return false;
                }
                else if (errorProvider5.GetError(c).Length > 0)
                {
                    return false;
                }

            }

            return true;
        }
        /// <summary>
        /// link label for the clo form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Clo c = new Clo();
            c.Show();
            this.Hide();
        }
        /// <summary>
        /// link label for the home page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }



    
}

