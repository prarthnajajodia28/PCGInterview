using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.StudentFolder
{
    class StudentDirectory
    {
        private List<Student> studentDirectory;

        public StudentDirectory() {
            studentDirectory = new List<Student>();
        }


        public List<Student> getStudentDirectory()
        {
            return studentDirectory;
        }

        //Adding a new Student to the directory
        public Student createStudent(string name, List<int> assignments)
        {    
            Student student = new Student(name,assignments);
            studentDirectory.Add(student);
            return student;
        }

        //Find if a student exists already
        public Boolean searchStudent(string name)
        {
            foreach (Student student in studentDirectory) {
                if (name == student.getName())
                {
                    return true;
                }
            }
            return false;
        }

        //Search a student to return for the list view
        public Student searchStudent(string name,string grade)
        {
            foreach (Student student in studentDirectory)
            {
                if (name == student.getName())
                {
                    return student;
                }
            
            }

            return null;
        }
    
    }
}
