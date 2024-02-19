using System;

namespace LABA1C_
{
    [Serializable]
    public class StudentVm
    {
        
        public StudentVm(string name, string lastname, int day, int month, int year)
        {
            Name = name;
            Lastname = lastname;   
            Day = day;
            Month = month;
            Year = year;
        }

        public StudentVm()
        {
            
        }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }

        public int Year { get; set; }

    }
}
