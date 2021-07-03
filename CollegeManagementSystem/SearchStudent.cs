using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeManagementSystem
{
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FeeRegistrationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= DESKTOP-TK7S7HH\\SYS;  Initial Catalog= CollegeManagementSystem; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission where NAID = " + SearchStudentTextBox.Text + " ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            SearchStudentDataGridView.DataSource = ds.Tables[0];
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= DESKTOP-TK7S7HH\\SYS;  Initial Catalog= CollegeManagementSystem; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NewAdmission.NAID as Student_ID,NewAdmission.fname as Full_Name,NewAdmission.mname as Mother_Name,NewAdmission.gender as Gender,NewAdmission.dob as Date_Of_Birth,NewAdmission.mobile as Mobile,NewAdmission.email as Email_ID,NewAdmission.semester,NewAdmission.prog as Programming_Language,NewAdmission.sname as School_Name,NewAdmission.duration as Course_Duration,NewAdmission.addres as Address,fees.fees as Fees from NewAdmission inner join fees on NewAdmission.NAID=fees.NAID";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            SearchStudentDataGridView.DataSource= ds.Tables[0];
        }
    }
}
