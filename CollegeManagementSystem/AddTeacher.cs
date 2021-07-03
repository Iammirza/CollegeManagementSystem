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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void SubTeacherButton_Click(object sender, EventArgs e)
        {
            String fname = FnameTeacherTextBox.Text;
            String gender = "";
            bool isChecked = MaleTeacherRadioButton.Checked;
            if (isChecked)
            {
                gender = MaleTeacherRadioButton.Text;
            }
            else
            {
                gender = FemaleTeacherRadioButton.Text;
            }
            String dob = DobTeacherDateTimePicker.Text;
            Int64 mobile = Int64.Parse(MobileTeacherTextBox.Text);
            String email = EmailTeacherTextBox.Text;
            String semester = SemesterTeacherComboBox.Text;
            String program = ProgramTeacherComboBox.Text;
            String duration = DurationTeacherComboBox.Text;
            String addres = AddressTeacherRichTextBox.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-TK7S7HH\\SYS; Initial Catalog= CollegeManagementSystem; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewAdd(fname, gender, dob, mobile, email, semester, prog, duration, addres) values ('" + fname + "' , '" + gender + "' , '" + dob + "' , '" + mobile + "' , '" + email + "' , '" + semester + "' , '" + program + "' , '" + duration + "' , '" + addres + "' )";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();

            MessageBox.Show("Data Saved Successfuly.", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
