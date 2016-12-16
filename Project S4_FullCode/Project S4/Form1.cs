using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Project_S4
{
    public partial class Form1 : Form
    {
        //change default form to Login in Program later
        Classes c;
        Email eMail;
        Scanners s = new Scanners();
        String str = "";
        List<Student> students = new List<Student>();
        bool visibility = false;
        bool body = false;
        bool clicked = false;
        bool readyForACheck = false;
        public string customText;
        int counter = 0;
        Time times;

        bool keyPresser = false;
        //l_time.Text = "This is where the label is";

        public Form1()
        {
            
            //MessageBox.Show("Instructions:" + Environment.NewLine + Environment.NewLine + " 1. Click");
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPresser = true;

            str = str + s.barcode(e);

            if (str.Length >= 14)
            {
                 // l_barcode.Items.Add(s.getStudentID(str));

                foreach(Student studt in c.myClass)
                {
                    if(str.Contains(studt.studentID) && studt.classCheck == 0 || str.Contains(studt.studentID) && studt.classCheck == 2) //do a check to see if the barcode scanned in is in the class and if not, make a new student
                    {
                        l_students.Items.Remove(studt.listBoxItem);
                        l_barcode.Items.Add(studt.listBoxItem);
                        studt.classCheck++;
                        c.present.Add(studt);
                        studt.sw.Stop();
                        if (studt.sw.Elapsed.Minutes > 3 && studt.classCheck != 2)
                        {
                            studt.lateMins = studt.sw.Elapsed.Minutes;
                        }
                        else
                        {
                            studt.lateMins += studt.sw.Elapsed.Minutes;
                        }
                    }
                    else if (str.Contains(studt.studentID) && studt.classCheck == 1)
                    {
                        l_students.Items.Add(studt.listBoxItem);
                        l_barcode.Items.Remove(studt.listBoxItem);
                        studt.sw.Restart();
                        studt.classCheck++;

                    }
                }
                str = "";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            times = new Time();
                keyPresser = false;

                counter = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Time current = new Time();
            l_time.Text = current.time();
            

        }
        private void b_email_Click(object sender, EventArgs e)
        {
            if (l_students.Items.Count > 0)
            {
                label4.Focus();
                if (eMail != null)
                {
                    eMail.setupEmail();
                    //eMail.sendEmail();
                }
                else
                {
                    MessageBox.Show("Your email was not sent as you have not clicked 'Check In Attendance'.");

                }
            }
            else
            {
                MessageBox.Show("There are no Students to send emails to! Click 'Load Students' or everyone is here.");
            }
        }

        private void b_LoadStudents_Click(object sender, EventArgs e)
        {
            if (counter < 1)
            {
                label4.Focus();
                if (keyPresser == false)
                {
                    if (c != null)
                    {
                        foreach (Student s in c.myClass)
                        {
                            l_students.Items.Add(s.listBoxItem);
                            s.sw.Start();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a course.");
                    }
                }
                counter++;
            }
            else
            {

            }
        }
        

        private void b_sendAttendance_Click(object sender, EventArgs e)
        {
            if (readyForACheck == false)
            {
                MessageBox.Show("Please choose a type of body. Or 'Submit' your custom body.");
            }
            else
            {
                if (clicked == true)
                {
                    foreach(var b in l_students.Items)
                    {

                        MessageBox.Show(b + " is " + times.lateTime() + " minutes late.");
                    }
                    label4.Focus();
                    eMail = new Email(c, l_students, body, t_customText, times);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Focus();
        }

        private void l_students_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_emailtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_customBody_Click(object sender, EventArgs e)
        {

        }

        private void b_useCustom_Click(object sender, EventArgs e)
        {
            if (l_students.Items.Count > 0)
            {
                visibility = !visibility;
                if (visibility == false)
                {
                    l_customBody.Visible = false;
                    t_customText.Visible = false;
                    b_submit.Visible = false;
                }
                else
                {
                    l_customBody.Visible = true;
                    t_customText.Visible = true;
                    b_submit.Visible = true;

                }
            }
            else
            {
                MessageBox.Show("There are no Students to send emails to! Click 'Load Students' or everyone is here.");
            }
        }

        private void b_submit_Click(object sender, EventArgs e)
        {
            body = true;
            clicked = true;
            readyForACheck = true;

        }

        public void t_customText_TextChanged(object sender, EventArgs e)
        {
            customText = t_customText.Text;
            
        }

        private void b_body_Click(object sender, EventArgs e)
        {
            if (l_students.Items.Count > 0)
            {
                clicked = true;
                readyForACheck = true;
            }
            else
            {
                MessageBox.Show("There are no Students to send emails to! Click 'Load Students' or everyone is here.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void b_button_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader str = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                str.Close();
            }

            FileWritingAndReading f = new FileWritingAndReading();

            List<Student> students = new List<Student>();

            string courseName = openFileDialog1.FileName; //Can't do this at startup... User must be able to upload a specific file.
                                                      //Use a menuStrip, and add a "Load" button. Be able to select a file. However... find a way to preserve each student's data
            string[] info = new string[] { "Last Name", "First Name", "Student Number", "Parent e-mail" };

            int[] indices = f.findIndices(courseName, info);

            string[][] data = f.readSomeData(courseName);

            for (int i = 1; i < data.Length; i++)
            {
                Student stu = new Student(new string[] { data[i][indices[0]], data[i][indices[1]], data[i][indices[2]], data[i][indices[3]] });
                students.Add(stu);

            }


            c = new Classes(courseName, students);

        }
    }
}
