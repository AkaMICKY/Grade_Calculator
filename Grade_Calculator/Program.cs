using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Your Score: ");
            string Score = Console.ReadLine();
            if (int.TryParse(Score, out int SCORE))
            {
                if (SCORE == 0)
                {
                    Console.WriteLine("0 How? thats F- for sure :<"); // prints if Score is = to 0
                }
                else if (SCORE <= 25)
                {
                    Console.WriteLine("F,Come on You can do better:( "); // prints if Score is < than 25
                }
                else if (SCORE <= 35)
                {
                    Console.WriteLine("D-, I mean Manageable :0"); // prints if Score is < than 35
                }
                else if (SCORE <= 50)
                {
                    Console.WriteLine("P, MID :|"); // prints if Score is < than 50
                }
                else if (SCORE <= 75)
                {
                    Console.WriteLine("B, Above Average :>"); // prints if Score is < than 75
                }
                else if (SCORE <= 80)
                {
                    Console.WriteLine("A, Nice try you did great"); // prints if Score is < than 80
                }
                else if (SCORE <= 100)
                {
                    Console.WriteLine("Excellent A+ :)"); // prints if Score is < than 100
                }
                else
                {
                    Console.WriteLine("Invalid Score,Enter A number Between 0 and 100"); // prints if Score is not in the Range of 0 and 100
                }
            } else
            {
                Console.WriteLine(Score + " is not an Actual Value, Please enter an Actual Score");
            }
            
            
        }
    }
}
