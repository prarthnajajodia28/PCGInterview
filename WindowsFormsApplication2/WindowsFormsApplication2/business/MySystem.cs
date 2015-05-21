using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication2.StudentFolder;

namespace WindowsFormsApplication2.business
{
    class MySystem
    {
    
    private static MySystem mySystem;
    private StudentDirectory studentDirectory;
    
        //Making sure only one instance of the System exists
    public static MySystem getInstance(){
        if (mySystem == null){
            mySystem = new MySystem();
        }
        return mySystem;
    }

    private MySystem() {
        studentDirectory=new StudentDirectory();
        //Creating five sample lists of assignment marks for minimum requirements of atleast 5 students in the student list
        List<int> sample1 = new List<int>();
        sample1.Add(75);
        sample1.Add(80);
        sample1.Add(85);

        List<int> sample2 = new List<int>();
        sample2.Add(80);
        sample2.Add(85);
        sample2.Add(90);

        List<int> sample3 = new List<int>();
        sample3.Add(75);
        sample3.Add(72);
        sample3.Add(71);

        List<int> sample4 = new List<int>();
        sample4.Add(99);
        sample4.Add(92);
        sample4.Add(85);

        List<int> sample5 = new List<int>();
        sample5.Add(81);
        sample5.Add(86);
        sample5.Add(83);

        //Creating five sample students
        Student student1 = studentDirectory.createStudent("Prarthna", sample1);
        Student student2 = studentDirectory.createStudent("Prerna", sample2);
        Student student3 = studentDirectory.createStudent("Aarushi", sample3);
        Student student4 = studentDirectory.createStudent("Akshata", sample4);
        Student student5 = studentDirectory.createStudent("Priya", sample5);
            
    }

    public StudentDirectory getStudentDirectory() {
        return studentDirectory;
    }

    public void setStudentDirectory(StudentDirectory studentDirectory)
    {
        this.studentDirectory=studentDirectory;
    }

    }
}
