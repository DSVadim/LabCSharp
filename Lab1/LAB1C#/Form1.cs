using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LAB1C_
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
            int day = int.Parse(textBox3.Text);
            int month = int.Parse(textBox4.Text);
            int year = int.Parse(textBox5.Text);

            Lists myList = new Lists(name, lastname, day, month, year);

            string filename = @"C:\Users\vadim\source\repos\LAB1C#\LAB1C#\students.txt";

            myList.Save(filename);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\vadim\source\repos\LAB1C#\LAB1C#\students.txt";

            List<StudentViewModel> studentsViewModel = new List<StudentViewModel>();

            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');
                if (parts.Length == 5)
                {
                    try
                    {
                        string name = parts[0];
                        string lastname = parts[1];
                        int day = int.Parse(parts[2]);
                        int month = int.Parse(parts[3]);
                        int year = int.Parse(parts[4]);

                        Student student = new Student(name, lastname, day, month, year);

                        StudentViewModel viewModel = new StudentViewModel
                        {
                            Name = student.Name,
                            LastName = student.Lastname,
                            DateOfBirth = $"{student.Day}/{student.Month}/{student.Year}"
                        };

                        studentsViewModel.Add(viewModel);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show($"Cannot parse line: {line}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            dataGridView1.DataSource = studentsViewModel;
        }


    }
}
