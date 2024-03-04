namespace HW6;

using System;

public class Professor
{
    private string profName;
    private string classTeach;
    private double salary;

    public Professor(string name, string course, double salary)
    {
        profName = name;
        classTeach = course;
        this.salary = salary;
    }

    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }

    public string GetName()
    {
        return profName;
    }

    public string GetClassTeach()
    {
        return classTeach;
    }
}

public class Student
{
    private string studentName;
    private string classEnroll;
    private double studentGrade;

    public Student(string name, string course, double grade)
    {
        studentName = name;
        classEnroll = course;
        studentGrade = grade;
    }

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }

    public string GetName()
    {
        return studentName;
    }

    public string GetClassEnroll()
    {
        return classEnroll;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Professor prof1 = new Professor("Alice", "Java", 9000);
        Professor prof2 = new Professor("Bob", "Math", 8000);

        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);

        Console.WriteLine("Professor Details:");
        Console.WriteLine("Name: " + prof1.GetName());
        Console.WriteLine("Class they teach: " + prof1.GetClassTeach());
        Console.WriteLine("Salary: " + prof1.GetSalary());
        Console.WriteLine();

        Console.WriteLine("Name: " + prof2.GetName());
        Console.WriteLine("Class they teach: " + prof2.GetClassTeach());
        Console.WriteLine("Salary: " + prof2.GetSalary());
        Console.WriteLine();

        Console.WriteLine("Student Details:");
        Console.WriteLine("Name: " + student1.GetName());
        Console.WriteLine("Class they're enrolled in: " + student1.GetClassEnroll());
        Console.WriteLine("Grade: " + student1.GetGrade());
        Console.WriteLine();

        Console.WriteLine("Name: " + student2.GetName());
        Console.WriteLine("Class they're enrolled in: " + student2.GetClassEnroll());
        Console.WriteLine("Grade: " + student2.GetGrade());
        Console.WriteLine();

        // Calculating and printing difference in salary between professors
        double salaryDifference = Math.Abs(prof1.GetSalary() - prof2.GetSalary());
        Console.WriteLine("Difference in salary between professors: " + salaryDifference);
        Console.WriteLine();

        // Calculating and printing total grade of Lisa’s Java course and Tom’s Math course
        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine("Total grade of Lisa’s Java course and Tom’s Math course: " + totalGrade);
    }
}
