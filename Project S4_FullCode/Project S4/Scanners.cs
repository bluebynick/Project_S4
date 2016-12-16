using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_S4
{
    class Scanners
    {

        

        public Scanners()
        {

        }

        public string barcode(KeyPressEventArgs e)
        {

            string aa = "";
            int value;
            string s = e.KeyChar.ToString();

            if (int.TryParse(s, out value)){ //make sure it's an int


                aa = aa + e.KeyChar;
            }


            return aa;
        }

        public string getStudentID(string barcode)
        {
            int counter =0;
            char[] charId = new char[barcode.Length];
            char[] charArray = barcode.ToCharArray();

            for(int i = 0; i < barcode.Length; i++)
            {
                if((i>5) && (i < barcode.Length - 1))
                {
                    charId[counter] = charArray[i];

                    counter += 1;
                }

            }

            if (counter > 7)
            {
                counter = 0;
                return "error";
            }
            else
            {
                return new string(charId);
            }
        }
    }
}
