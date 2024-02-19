using LABA1C_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

public static class FileManager
{
    public static void Save(string filename, StudentVm student)
    {
        List<StudentVm> students = LoadStudents(filename);
        students.Add(student);
        SerializeStudents(filename, students);
        MessageBox.Show($"Student add");
    }

    public static void Sort(string filename)
    {
        List<StudentVm> students = LoadStudents(filename);
        students = students.OrderBy(s => s.Year).ThenBy(s => s.Month).ThenBy(s => s.Day).ToList();
        SerializeStudents(filename, students);
    }

    private static List<StudentVm> LoadStudents(string filename)
    {
        if (!File.Exists(filename))
        {
            return new List<StudentVm>();
        }

        try
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<StudentVm>)formatter.Deserialize(stream);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Fail {ex.Message}");
            return new List<StudentVm>();
        }
    }

    private static void SerializeStudents(string filename, List<StudentVm> students)
    {
        using (FileStream stream = File.Create(filename)) 
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, students);
        }
    }

    public static List<StudentVm> GetStudentsByMonth(string filename, int month)
    {
        List<StudentVm> students = LoadStudents(filename);
        return students.Where(s => s.Month == month).ToList();
    }
}
