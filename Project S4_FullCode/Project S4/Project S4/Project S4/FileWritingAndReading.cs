using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Project_S4
{
    class FileWritingAndReading
    {
        public string[] readAllData(string fileName)
        {
            try
            {
                return File.ReadAllLines(fileName);  //this reads a whole data file and returns a string array to you. that simple
            }
            catch (Exception e)
            {
                return File.ReadAllLines(fileName + ".xlsx");
            }
        }

        public string[] readTextFile(string fileName)
        {
            try
            {
                return File.ReadAllLines(fileName);  //this reads a whole data file and returns a string array to you. that simple
            }
            catch (Exception e)
            {
                return File.ReadAllLines(fileName + ".txt");
            }
        }

        public string[] readSomeData(string fileName, int start, int num)
        {
            StreamReader reader = new StreamReader(fileName);

            string[] data = new string[num];
            List<string[]> a = new List<string[]>();
            string tempLine = "";
            int i;

            
            for (i = 0; i < start; i++)
            {
                if (reader.ReadLine() != null); //this obviously will return null if nothing's there, but this thing is smart and it
                //actually goes down each time it's ! = null

            }

            for(int j = 0; j< num; j++)
            {
                tempLine = reader.ReadLine();
                if(tempLine == null)
                {
                    reader.Close();
                    return data; 
                }



                data[j] = tempLine;
            }
            reader.Close();
            return data;
        }

        public string[][] readSomeData(string fileName, string course)
        {
            StreamReader reader;
            try
            {
                reader = new StreamReader(fileName + ".txt"); //this reads a whole data file and returns a string array to you. that simple
            }
            catch (Exception e)
            {
                reader = new StreamReader(fileName + ".csv");
            }

            string[] data;
            List<string[]> a = new List<string[]>(); //rowbottom said this needs to be a string array
            string tempLine = "";
            int i;
            while(true)
            {
                tempLine = reader.ReadLine();
                if (tempLine == null)
                {
                    reader.Close();
                    return a.ToArray();
                }


                if (tempLine.Contains(course))
                {

                    data = tempLine.Split(',');
                    a.Add(data);

                }
            }
        }

        public string[][] readSomeData(string fileName)
        {
            StreamReader reader;
            try
            {
                reader = new StreamReader(fileName); //this reads a whole data file and returns a string array to you. that simple
            }
            catch (Exception e)
            {
                reader = new StreamReader(fileName + ".csv");
            }
            

            string[] data;
            List<string[]> a = new List<string[]>(); //rowbottom said this needs to be a string array
            string tempLine = "";
            int i;

            while (true)
            {
                tempLine = reader.ReadLine();
                if (tempLine == null)
                {
                    reader.Close();
                    return a.ToArray();
                }
                
                data = tempLine.Split(',');
                a.Add(data);

                
            }
        }

        public int[] findIndices(string fileName, string[] fields) //returns value of whatever fields are required (e.g. last, first)
        {
            StreamReader reader;
            try
            {
                reader = new StreamReader(fileName); //this reads a whole data file and returns a string array to you. that simple
            }
            catch (Exception e)
            {
                reader = new StreamReader(fileName + ".csv");
            }
            string rawData;
            string[] header;
            int[] indices = new int[fields.Length];

            //get the file header
            rawData = reader.ReadLine();//done in two steps for clarity
            header = rawData.Split(',');//this contains the headers

            for (int i = 0; i < header.Length; i++)
            {
                header[i] = header[i].ToUpper();//just to remove the possibility of problems due to case
                for (int j = 0; j < fields.Length; j++)
                {
                    fields[j] = fields[j].ToUpper();
                    if (header[i].Contains(fields[j]))
                    {
                        indices[j] = i;
                    }
                }
            }
            reader.Close();

            return indices;
        }

        public void loadAllDataToTextBox(string [] data, ListBox list) //you can have big names cause intellisense is great
        {

            foreach(string d in data)
            {
                list.Items.Add(d);
            }

        }

        public string [] readDataFromListBox(int count, ListBox box)
        {

            string[] data = new string[count];

            for(int i =0; i< count; i++)
            {
                data[i] = (string)box.Items[i];

            }

            return data;

        }

        public void writeAllDataToFile(string fileName, string indices, string[] data)
        {
            var writer = new StreamWriter(fileName);
            //writer.WriteLine("Voter: " + (string)box.Items[0]);
            //string[] info = { "Last Name", "First Name", "Student Number", "Parent e-mail" };
            //info.ToString();
            writer.WriteLine(indices);
            foreach (string d in data)
            {
                if (d != null)
                {
                    writer.WriteLine(d);
                }
            }
            writer.Close();
        }

        public void eraseAllDataInFile(string fileName)
        {
            var writer = new StreamWriter(fileName);
            string line = null;

            foreach (char c in fileName)
            {
                writer.WriteLine(line);
            }

            writer.Close();
        }


    }
}
