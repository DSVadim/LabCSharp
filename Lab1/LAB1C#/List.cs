using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LAB1C_
{
    internal class Lists : Student
    {

        public Lists(string name, string lastname, int day, int month, int year) : base(name, lastname, day, month, year)
        {
        }

        public void Save(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                writer.WriteLine($"{Name} {Lastname} {Day} {Month} {Year}");
            }
        }

        public void Sort(string filename)
        {

        } 
    }
}
