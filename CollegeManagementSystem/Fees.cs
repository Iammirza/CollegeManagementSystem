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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void FeeRegistrationTextBox_TextChanged(object sender, EventArgs e)
        {

            if (FeeRegistrationTextBox.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= DESKTOP-TK7S7HH\\SYS; Initial Catalog= CollegeManagementSystem; Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select fname, mname, duration from NewAdmission where NAID = " + FeeRegistrationTextBox.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                if (DS.Tables[0].Rows.Count != 0)
                {

                    FnameFeeLabel.Text = DS.Tables[0].Rows[0][0].ToString();
                    MnameFeeLabel.Text = DS.Tables[0].Rows[0][1].ToString();
                    DurationFeeLabel.Text = DS.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Registration ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FnameFeeLabel.Text = "___________________";
                    MnameFeeLabel.Text = "___________________";
                    DurationFeeLabel.Text = "___________________";
                }
            }
            else
            {
                FeeRegistrationTextBox.Text = "";
                FeeTextBox.Text = "";
                FnameFeeLabel.Text = "___________________";
                MnameFeeLabel.Text = "___________________";
                DurationFeeLabel.Text = "___________________"; 
            }
        }

        private void FeeSubmitButton_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source= DESKTOP-TK7S7HH\\SYS; Initial Catalog= CollegeManagementSystem; Integrated Security = True";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;

            cmd1.CommandText = "select * from fees where NAID = "+FeeRegistrationTextBox.Text+" ";
            SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
            DataSet DS1 = new DataSet();
            DA1.Fill(DS1);




            if (DS1.Tables[0].Rows.Count == 0)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= DESKTOP-TK7S7HH\\SYS; Initial Catalog= CollegeManagementSystem; Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into fees(NAID, fees) values(" + FeeRegistrationTextBox.Text + ", " + FeeTextBox.Text + ") ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                if (MessageBox.Show("Fee Submition Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    FeeRegistrationTextBox.Text = "";
                    FeeTextBox.Text = "";
                    FnameFeeLabel.Text = "___________________";
                    MnameFeeLabel.Text = "___________________";
                    DurationFeeLabel.Text = "___________________";
                }
            }
            else
            {
                MessageBox.Show("Fee is Already Submitted");
            }
        }
    }
}
