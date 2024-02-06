namespace HW3_Part2;

class Program
{
   
   static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine($"N = {N} Shape = {shape}");
        if (shape == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new String('*', i));
            }
        }
        else if (shape == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new String(' ', N - i) + new String('*', i));
            }
        }
        else
        {
            Console.WriteLine("Invalid shape! Please enter 'left' or 'right'.");
        }
    }

   
   
    static void Main(string[] args)
    {
    Console.Write("Enter an integer number: ");
        int N = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter shape (left or right): ");
        string shape = Console.ReadLine();

        PrintTriangle(N, shape);
    }
}
