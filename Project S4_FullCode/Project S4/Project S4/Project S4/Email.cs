using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Security.Principal;
using System.IO;

namespace Project_S4
{
    class Email
    {
        //Student student
        MailMessage eMail = new MailMessage(); //Declaring the mailMessage class constructer
        List<string> emails = new List<string>();
        SmtpClient spartansSmtp = new SmtpClient("smtp.gmail.com"); //This sets up the SMTP client for gmail.
        

        public Email (Classes c, ListBox absentBox, bool body, TextBox customText, Time times) //this has to recieve the textbox text somehow and assign it to email.Body in the commented else... you also need to fix what's in the if
        {
            foreach (var o in absentBox.Items)
            {
                foreach (Student s in c.myClass)
                {
                    if(o == s.listBoxItem) //check if the current student is absent
                    {
                        emails.Add(s.guardianEmail);
                    }
                }
            }
                if(emails.Count > 0)
                {
                    foreach (string email in emails)
                    {
                        eMail.To.Add(email); //pulls the guardian emails and then this adds to list of people the email will be sent to
                    }
                }

            if (body == false) //if it's generic
            {
                eMail.Body = "Todays attendance shows that your child was late to today's class by: " + times.lateTime() + " minutes.";

            }
            else //if it's custom
            {
                eMail.Body = customText.Text;

            }

        }

        public Email(Classes c)
        {
            foreach (Student s in c.myClass)
            {
                emails.Add(s.guardianEmail);

            }

        }

        public void setupEmail()
        {
            /* These are setting the parameters for the SMTP client:
             * The port sets the specfic port that this is going through.
             * The credentials allow the server to log-in and send the email from the account.
             * The very last parameter enables SSL to use a secure sending mechanism.
             */

            //Hey, it's Andrea. I think we should figure out a way to automatically grab the teachers credentials and send them that way.
            //Unless we want a bot to send the emails. But if parents want to reply, we should include the teacher's email in the email we send them.
            spartansSmtp.Port = 587;
            spartansSmtp.Credentials = new System.Net.NetworkCredential("ckspartans4@gmail.com", "CK_Spartans4");
            spartansSmtp.EnableSsl = true;

            /* This generates all of the nessessary aspects of the email. That contains:
             * Who it's from?
             * Who it's to?
             * What is the subject of the email?
             * What will the body of the email contain?
             */

            eMail.From = new MailAddress("ckspartans4@gmail.com");
            eMail.Subject = "Your child attending CKSS was not present today";
            spartansSmtp.Send(eMail);

        }

        public void sendEmail() // this takes the imformation and inputs it into a format that sends the email if certain text
        {
            /* if (student doesnt show up to class) 
            {
                eMail.Body = studentID + "has not attended todays" + courseCode + "class. This is only affecting" + studentID + "'s education as what we did in class today was quite important.";
            }
            else (student is 10 minutes late)
            {
               eMail.Body = studentID + "was 10 minutes late to the" + courseCode + "class today. Unfourtantly this will add up to" + studentID + "'s detention time.";
               
            } */
        }   
    }
}
