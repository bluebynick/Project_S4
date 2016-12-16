using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Project_S4
{
    class Student
    {
        /*
         * some sort of reference to the school database.
         * string holds studentName
         * string of ID (must match up with scanner input)
         * int for present/absent
         * float for lates (in minutes)
         * reference from classes class. to get name?
         */

        public string studentLastName;
        public string studentFirstName;
        public string studentID ="";
        public string guardianEmail;
        public string listBoxItem;
        public int classCheck;
        public int presentNum;
        public int absentNum;
        public int lateMins;
        public FileWritingAndReading dataManager;
        public Scanners scan;
        public string[] data;
        public Stopwatch sw;

        public Student(string name) //don't worry andrea Nick did this. If you want to see where i call it look in the Form1_KeyPress
        {
            scan = new Scanners();

            studentLastName = name;
            //set stringID to whatever string is passed in by scanner
            //studentName set to classes.[arrayNum].Student.toString(); (that a total guess!)
        }
        public Student(string name, int[] information, string[] classData) //don't worry andrea Nick did this. If you want to see where i call it look in the Form1_KeyPress
        {
            scan = new Scanners();

            for(int i = 0; i< information.Length; i++)
            {
            }

            studentLastName = name;
            //set stringID to whatever string is passed in by scanner
            //studentName set to classes.[arrayNum].Student.toString(); (that a total guess!)
        }

        public Student(string[] information) //don't worry andrea Nick did this. If you want to see where i call it look in the Form1_KeyPress
        {
            scan = new Scanners();
            sw = new Stopwatch();
            studentLastName = information[0];
            studentFirstName = information[1];
            studentID = information[2];
            guardianEmail = information[3];
            listBoxItem = studentLastName + ", " + studentFirstName;
            classCheck = 0;
        }
    }
}
