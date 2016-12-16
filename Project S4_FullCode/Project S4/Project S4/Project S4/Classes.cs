using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_S4
{
    class Classes
    {
        public Scanners scan = new Scanners();
        public List <Student> present = new List<Student>();
        public List <Student> absent = new List<Student>();
        public string courseCode;
        public List<Student> myClass;

        public Classes (string courseName, List<Student> students)
        {
            absent = students;
            myClass = students; //should be initialized to the size of the class... access to school database or manually entered by user?
            courseCode = courseName;
        }
    }
}
