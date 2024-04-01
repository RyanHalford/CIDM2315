namespace HW9;

using System;
using System.Collections.Generic;

class Student
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine("Student ID: " + studentID + ", Name: " + studentName);
    }

    public int GetID()
    {
        return studentID;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create 4 students
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        // Create gradebook dictionary
        Dictionary<int, Tuple<string, double>> gradebook = new Dictionary<int, Tuple<string, double>>
        {
            { alice.GetID(), new Tuple<string, double>("Alice", 4.0) },
            { bob.GetID(), new Tuple<string, double>("Bob", 3.6) },
            { cathy.GetID(), new Tuple<string, double>("Cathy", 2.5) },
            { david.GetID(), new Tuple<string, double>("David", 1.8) }
        };

        // Check if "Tom" is in the gradebook and add if not present
        if (!gradebook.ContainsKey(555))
        {
            gradebook.Add(555, new Tuple<string, double>("Tom", 3.3));
        }

        // Calculate average GPA
        double totalGPA = 0;
        foreach (var kvp in gradebook)
        {
            totalGPA += kvp.Value.Item2;
        }
        double averageGPA = totalGPA / gradebook.Count;

        Console.WriteLine("Average GPA: " + averageGPA);

        // Print information about students with GPA greater than average GPA
        Console.WriteLine("Students with GPA greater than average GPA:");
        foreach (var kvp in gradebook)
        {
            if (kvp.Value.Item2 > averageGPA)
            {
                Console.WriteLine("Student ID: " + kvp.Key + ", Name: " + kvp.Value.Item1 + ", GPA: " + kvp.Value.Item2);
            }
        }
    }
}