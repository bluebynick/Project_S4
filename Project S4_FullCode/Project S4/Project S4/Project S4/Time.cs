using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Project_S4
{
    class Time
    {
        Stopwatch sw;
        DateTime current;
        //public int elapsedTime;

        int elapsedTime;

        public Time()
        {
            current = new DateTime();
            sw = new Stopwatch();
            sw.Start();
            //make something that populates a listbox by taking in a listbox and an arraylist
        }

        public string time()
        {
            current = DateTime.Now;
           
            string time = current.Hour + ":" + current.Minute +  ":" + current.Second;

            return time;

        }
        public int lateTime()
        {
            current = DateTime.Now;
            elapsedTime = sw.Elapsed.Minutes;
            return elapsedTime;
        }
    
    }
}
