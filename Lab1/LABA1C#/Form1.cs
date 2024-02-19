using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LABA1C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            int day;
            int month;
            int year;
            if (int.TryParse(textBox3.Text, out day) && int.TryParse(textBox4.Text, out month) && int.TryParse(textBox5.Text, out year))
            {
                StudentVm student = new StudentVm(name, lastname, day, month, year);
                string filename = @"C:\Users\vadim\source\repos\LABA1C#\LABA1C#\students.dat";
                FileManager.Save(filename, student);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for day, month, and year.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int monthToDisplay;
            if (int.TryParse(textBox6.Text, out monthToDisplay))
            {
                string filename = @"C:\Users\vadim\source\repos\LABA1C#\LABA1C#\students.dat";
                FileManager.Sort(filename); 
                List<StudentVm> studentsByMonth = FileManager.GetStudentsByMonth(filename, monthToDisplay);

                dataGridView1.DataSource = studentsByMonth;
            }
            else
            {
                MessageBox.Show("Please enter a valid month.");
            }
        }

    }
}
