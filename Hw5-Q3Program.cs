namespace HW5_Q3;
using System;
class Program
{
    static void Main(string[] args)
    {
        createAccount();
    }

    static bool checkAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.WriteLine("Enter your username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine();

        Console.WriteLine("Re-enter your password:");
        string confirmPassword = Console.ReadLine();

        Console.WriteLine("Enter your birth year:");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        if (checkAge(birthYear))
        {
            if (password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
    }

