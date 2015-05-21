using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.business;
using WindowsFormsApplication2.StudentFolder;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        private static MySystem mySystem;

        public Form1()
        {
            mySystem = ConfigureASytem.configure();
            InitializeComponent();
        }

        //Creating a new Student and adding to the student Directory
        private void Add_Click(object sender, EventArgs e)
        {
            Success.Text = "";
            string s_name;
            int s_ass1, s_ass2, s_ass3;
            //Validation checks for all the values
            Boolean flag_ass1,flag_ass2,flag_ass3,flag_name;
            flag_ass1=assignment1_Validating();
            flag_ass2 = assignment2_Validating();
            flag_ass3 = assignment3_Validating();
            flag_name=name_Validating();
            //If valid, create a student and add to the directory
            if (flag_ass1 && flag_ass2 && flag_ass3 && flag_name)
            {
                error_ass1.Text = "";
                error_ass2.Text = "";
                error_ass3.Text = "";
                name_error.Text = "";
            
                List<int> assignment = new List<int>();
                s_name = name.Text;
                s_ass1 = int.Parse(assignment1.Text);
                s_ass2 = int.Parse(assignment2.Text);
                s_ass3 = int.Parse(assignment3.Text);

                assignment.Add(s_ass1);
                assignment.Add(s_ass2);
                assignment.Add(s_ass3);

                Student student = mySystem.getStudentDirectory().createStudent(s_name, assignment);

                Success.Text = "Student Added Successfully\n Grade: " + student.getGrade();
            }

        }

        //Validion for Student Name
        private Boolean name_Validating()
        {
            name_error.Text = "";
            //For Empty String
            if (string.IsNullOrEmpty(name.Text))
            {
                name_error.Text = "Name Required!";
                return false;
            }
            //For valid string as name
            else if (!Regex.IsMatch(name.Text, @"[A-Za-z]"))
            {
                name_error.Text = "Name invalid!";
                return false;
            }
            else if (mySystem.getStudentDirectory().searchStudent(name.Text))
            {
                MessageBox.Show("Student already exists");
                return false;
            }
            return true;
        }


        private Boolean assignment1_Validating()
        {
            error_ass1.Text = "";
            try
            {
                int.Parse(assignment1.Text);
            }
            catch (FormatException e) {

                error_ass1.Text = "Assignment 1 invalid!";
                
                e.GetType();
                return false;
            }
            if (string.IsNullOrEmpty(assignment1.Text))
            {
                error_ass1.Text = "Assignment 1 Required!";
                return false;
            }
            else if (Regex.IsMatch(assignment1.Text, @"[A-Za-z][][!#$%&'()*+,./:;<=>?@\^_`{|}~-][ \t\r\n\v\f]") || int.Parse(assignment1.Text) < 0 || int.Parse(assignment1.Text) > 100)
            {
                error_ass1.Text = "Assignment 1 invalid!";
                return false;
            }
            return true;
        }
        private Boolean assignment2_Validating()
        {
            error_ass2.Text = "";
            try
            {
                int.Parse(assignment2.Text);
            }
            catch (FormatException e)
            {

                error_ass2.Text = "Assignment 2 invalid!";
                e.GetType();
                return false;
            }
            if (string.IsNullOrEmpty(assignment2.Text))
            {
                error_ass2.Text = "Assignment 2 Required!";
                return false;
            }
            else if (Regex.IsMatch(assignment2.Text, @"[A-Za-z][][!#$%&'()*+,./:;<=>?@\^_`{|}~-][ \t\r\n\v\f]") || int.Parse(assignment2.Text) < 0 || int.Parse(assignment2.Text) > 100)
            {
                error_ass2.Text = "Assignment 2 invalid!";
                return false;
            }
            return true;
        }


        private Boolean assignment3_Validating()
        {
            error_ass3.Text = "";
            try
            {
                int.Parse(assignment3.Text);
            }
            catch (FormatException e)
            {

                error_ass3.Text="Assignment 3 invalid!";
                e.GetType();
                return false;
            }
            if (string.IsNullOrEmpty(assignment3.Text))
            {
                error_ass3.Text = "Assignment 3 Required!";
                return false;
            }
            else if (Regex.IsMatch(assignment3.Text, @"[A-Za-z][][!#$%&'()*+,./:;<=>?@\^_`{|}~-][ \t\r\n\v\f]") || int.Parse(assignment3.Text) < 0 || int.Parse(assignment3.Text) > 100)
            {
                error_ass3.Text = "Assignment 3 invalid!";
                
                return false;
            }
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Display vD = new Display();
            vD.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void assignment3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
