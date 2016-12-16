using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;


namespace Project_S4
{
    public partial class Login : Form
    {
        Form1 myForm;
        public string userName;

        public Login(Form1 form)
        {
            InitializeComponent();
            myForm = form;
        }
        public Login ()
        {
            InitializeComponent();
            myForm = new Form1();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            userName = WindowsIdentity.GetCurrent().Name;
            textBox1.Text =  userName;
            textBox1.KeyDown += new KeyEventHandler(textBox1_KeyDown);
        
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    myForm.Show();
                }
                catch(Exception)
                {
                    myForm = new Form1();
                    myForm.Show();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
