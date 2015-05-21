using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.business;
using WindowsFormsApplication2.StudentFolder;

namespace WindowsFormsApplication2
{
    public partial class ViewDirectory : Form
    {
        
        private static MySystem mySystem;

        public ViewDirectory()
        {
            InitializeComponent();
            mySystem =ConfigureASytem.configure();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Display d = new Display();
            d.Show();
        }
        //To retrieve values of selected item from the list view
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //Refreshing the listview
            if (listView1.SelectedIndices.Count <= 0)
            {
                return;
            } 
            string name = listView1.SelectedItems[0].Text;
            string grade = listView1.SelectedItems[0].SubItems[0].Text;
            StudentDirectory sd = mySystem.getStudentDirectory();
            Student student=sd.searchStudent(name,grade);
                assignment1.Text = student.getAssignments()[0] +"";
                assignment2.Text = student.getAssignments()[1] + "";
                assignment3.Text = student.getAssignments()[2] + "";
        }

        private void ViewDirectory_Load(object sender, EventArgs e)
        {
            //Populating the listview
            List<Student> sList = mySystem.getStudentDirectory().getStudentDirectory();     
            foreach (Student student in sList)
            {
                ListViewItem lvi = new ListViewItem(student.ToString());
                lvi.SubItems.Add(student.getGrade());
                listView1.Items.Add(lvi);
            }

        }


    }
}
