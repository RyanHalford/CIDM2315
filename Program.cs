namespace HW2_Part2;
using System;
class Program
{
    static void Main(string[] args)
    {
    
         //Got this of the internet and changed up some of the wording to what i needed and a little bit of the code. 
         //The was orignally a name system not number
            Console.WriteLine("Enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

        if(n1<n2){  //Edited this from the test code in the lesson section.
            if(n1<n3){
                Console.WriteLine("The smallest num: n1");
            }
            else{
                Console.WriteLine("The smallest num: n3");
            }
        }
        else{ 
            if(n2<n3){
                Console.WriteLine("The smallest num: n2");
            }
            else{
                Console.WriteLine("The smallest num: n3");
            }
        }
    }
}
