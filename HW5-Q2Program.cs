namespace HW5_Q2;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third integer:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the fourth integer:");
        int num4 = Convert.ToInt32(Console.ReadLine());

        int largestAmongFirstTwo = GetLargestInteger(num1, num2);
        int largestAmongLastTwo = GetLargestInteger(num3, num4);

        int overallLargest = GetLargestInteger(largestAmongFirstTwo, largestAmongLastTwo);

        Console.WriteLine("The largest integer is: " + overallLargest);
    }

    static int GetLargestInteger(int a, int b)
    {
        return a > b ? a : b;
    }
}