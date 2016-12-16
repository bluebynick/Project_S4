using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_S4
{
    public partial class CourseCode : Form
    {
        //string data2;

        public CourseCode(string data)
        {
            InitializeComponent();
            //data2 = data;
        }

        private void t_course_TextChanged(object sender, EventArgs e)
        {
            if (e.Equals(Keys.Enter))
            {
                this.Close();

            }

        }

        private void CourseCode_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(t_course.Text))
            {

                this.DialogResult = DialogResult.OK;
            }

            else
            {
                MessageBox.Show("That course is invalid. Please try again");
                e.Cancel = true;
            }

        }
    }
}
