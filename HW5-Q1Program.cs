﻿namespace HW5_Q1;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int largest = GetLargestInteger(num1, num2);

        Console.WriteLine("The largest integer is: " + largest);
    }

    static int GetLargestInteger(int a, int b)
    {
        return a > b ? a : b;
    }
    }
