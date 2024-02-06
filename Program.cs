namespace HW3_Part2;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Enter the value of N: ");
        int N = int.Parse(Console.ReadLine());

        // Loop through each row
        for (int i = 0; i < N; i++)
        {
            // Loop through each column
            for (int j = 0; j < N; j++)
            {
                // Print the appropriate symbol based on the position
                Console.Write("#");
            }
            Console.WriteLine(); // Move to the next row
        }
    }
}
    

