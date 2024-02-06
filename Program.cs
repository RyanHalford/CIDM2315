namespace HW3_Part1;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

             if (n1 > n2)
            {
                Console.WriteLine("The Largest num: " + n1);
            }
            else if (n2 > n1)
            {
                Console.WriteLine("The Largest num: " + n2);
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }
        }
    }
