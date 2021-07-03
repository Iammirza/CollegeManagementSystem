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
    public partial class FindingStudent : Form
    {
        public FindingStudent()
        {
            InitializeComponent();
        }

        private void ShowFindingStudentButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= DESKTOP-TK7S7HH\\SYS;  Initial Catalog= CollegeManagementSystem; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission where NAID = " + FindingStudentTextBox.Text + " ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            if (ds.Tables[0].Rows.Count != 0)
            {
                FnameFindLabel.Text = ds.Tables[0].Rows[0][1].ToString();
                MnameFindLabel.Text = ds.Tables[0].Rows[0][2].ToString();
                GenderFindLabel.Text = ds.Tables[0].Rows[0][3].ToString();
                DobFindLabel.Text = ds.Tables[0].Rows[0][4].ToString();
                MobileFindLabel.Text = ds.Tables[0].Rows[0][5].ToString();
                EmailFindLabel.Text = ds.Tables[0].Rows[0][6].ToString();
                StandardFindLabel.Text = ds.Tables[0].Rows[0][7].ToString();
                MediumFindLabel.Text = ds.Tables[0].Rows[0][8].ToString();
                SchoolFindLabel.Text = ds.Tables[0].Rows[0][9].ToString();
                YearFindLabel.Text = ds.Tables[0].Rows[0][10].ToString();
                AddressFindLabel.Text = ds.Tables[0].Rows[0][11].ToString();
            }
            else 
            {
                MessageBox.Show("Please Enter Correct Registration ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFindingStudentButton_Click(object sender, EventArgs e)
        {
            FnameFindLabel.Text = "___________________";
            MnameFindLabel.Text = "___________________";
            GenderFindLabel.Text = "___________________";
            DobFindLabel.Text = "___________________";
            MobileFindLabel.Text = "___________________";
            EmailFindLabel.Text = "___________________";
            StandardFindLabel.Text = "___________________";
            MediumFindLabel.Text = "___________________";
            SchoolFindLabel.Text = "___________________";
            YearFindLabel.Text = "___________________";
            AddressFindLabel.Text = "___________________";
        }

    }
}
