using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.StudentFolder
{
    class Student
    {
        string s_name;
        List<int> assignments = new List<int>();
        string grade;

        public Student() { }

        public Student(string s_name,List<int> assignments) {
            this.assignments = assignments;
            this.s_name = s_name;
            setGrade(assignments);
        }

        public string getName() {
            return s_name;
        }

        public List<int> getAssignments() {
            return assignments;
        }

        public void setName(string s_name)
        {
            this.s_name = s_name;
        }

        public void setAssignments(List<int> assignments)
        {
            this.assignments=assignments;
        }

        public void setGrade(List<int> assignments)
        {
            int avg = 0;
            foreach(int assignment in assignments){
                avg += assignment;
            }
            avg /= assignments.Count;
            if (avg >= 90)
                grade = "A";
            else if (avg >= 80)
                grade = "B";
            else if (avg >= 70)
                grade = "C";
            else if (avg >= 60)
                grade = "D";
            else
                grade = "F";

        }

        public string getGrade()
        {
            return grade;
        }

        public override string ToString()
        {
            return getName();
        }

    }
}
