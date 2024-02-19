using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace LAB1C_
{
    internal class Student
    {
        private string name { get; set; }
        private string lastname { get; set; }
        private int day { get; set; }
        private int month { get; set; }
        private int year { get; set; }

        public Student(string name, string lastname, int day, int month, int year)
        {
            this.name = name;
            this.lastname = lastname;
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }     
        }

    }
}
