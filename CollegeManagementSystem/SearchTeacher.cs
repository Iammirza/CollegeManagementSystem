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
    public partial class SearchTeacher : Form
    {
        public SearchTeacher()
        {
            InitializeComponent();
        }

        private void SearchTeacher_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= DESKTOP-TK7S7HH\\SYS;  Initial Catalog= CollegeManagementSystem; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NewAdd.NAID as Teacher_ID,NewAdd.fname as Full_Name,NewAdd.gender as Gender,NewAdd.dob as Date_Of_Birth,NewAdd.mobile as Mobile,NewAdd.email as Email_ID,NewAdd.semester,NewAdd.prog as Programming_Language,NewAdd.sname as School_Name,NewAdd.duration as Course_Duration,NewAdd.addres as Address,fees.fees as Fees from NewAdd inner join fees on NewAdd.NAID=fees.NAID";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            SearchTeacherDataGridView.DataSource = ds.Tables[0];
        }

        private void SearchTeacherButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= DESKTOP-TK7S7HH\\SYS;  Initial Catalog= CollegeManagementSystem; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdd where NAID = " + SearchTeacherTextBox.Text + " ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            SearchTeacherDataGridView.DataSource = ds.Tables[0];
        }

    }
}
