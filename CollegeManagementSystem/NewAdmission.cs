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
    public partial class NewAdmissionForm : Form
    {
        public NewAdmissionForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NewAdmissionForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-TK7S7HH\\SYS; Initial Catalog= CollegeManagementSystem; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select max(NAID) from NewAdmission";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();

            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            RegNo.Text = (abc + 1).ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void MotherNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            String fname = FullNameTextBox.Text;
            String mname = MotherNameTextBox.Text;
            String gender = "";
            bool isChecked = MaleRadioButton.Checked;
            if (isChecked)
            {
                gender = MaleRadioButton.Text;
            }
            else 
            {
                gender = FemaleRadioButton.Text;
            }
            String dob = DobDateTimePicker.Text;
            Int64 mobile = Int64.Parse(MobileTextBox.Text);
            String email = EmailTextBox.Text;
            String semester = SemesterComboBox.Text;
            String program = ProgramComboBox.Text;
            String sname = SchoolTextBox.Text;
            String duration = DurationComboBox.Text;
            String addres = AddressRichTextBox.Text;

            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source =DESKTOP-TK7S7HH\\SYS; Initial Catalog= CollegeManagementSystem; Integrated Security = True";

            //con.Open();
           // SqlCommand sc = new SqlCommand("insert into NewAdd(fname, mname, gender, dob, mobile, email, semester, prog, sname, duration, addres) values ('" + fname + "' , '" + mname + "' , '" + gender + "' , '" + dob + "' , '" + mobile + "' , '" + email + "' , '" + semester + "' , '" + program + "' , '" + sname + "' , '" + duration + "' , '" + addres + "' )", con);
           // sc.ExecuteNonQuery();
          //  MessageBox.Show("Data Saved Successfuly. Remember the Registration ID ", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
           // con.Close();

           SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            
            cmd.CommandText = "insert into NewAdmission(fname, mname, gender, dob, mobile, email, semester, prog, sname, duration, addres) values ('" + fname + "' , '" + mname + "' , '" + gender + "' , '" + dob + "' , '" + mobile + "' , '" + email + "' , '" + semester + "' , '" + program + "' , '" + sname + "' , '" + duration + "' , '" + addres + "' )";

            
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
           DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();

            MessageBox.Show("Data Saved Successfuly. Remember the Registration ID ", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            FullNameTextBox.Clear();
            MotherNameTextBox.Clear();
            MaleRadioButton.Checked = false;
            FemaleRadioButton.Checked = false;
            MobileTextBox.Clear();
            EmailTextBox.Clear();
            ProgramComboBox.ResetText();
            DurationComboBox.ResetText();
            SemesterComboBox.ResetText();
            SchoolTextBox.Clear();
            AddressRichTextBox.Clear();

            
        }

        private void RegNo_Click(object sender, EventArgs e)
        {

        }

        private void AddressRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DurationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SchoolTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MobileTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void GenderLabel_Click(object sender, EventArgs e)
        {

        }

        private void MobileLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
        }
    }
}
