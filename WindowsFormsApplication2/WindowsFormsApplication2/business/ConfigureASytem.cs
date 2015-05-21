using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication2.StudentFolder;

namespace WindowsFormsApplication2.business
{
    class ConfigureASytem
    {
        //Creating singleton pattern
        public static MySystem configure()
        {
            MySystem system = MySystem.getInstance();

            return system;
        }
       
    }
}
