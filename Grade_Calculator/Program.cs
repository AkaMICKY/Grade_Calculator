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
            int SCORE = Convert.ToInt32(Score);
            if (SCORE == 0)
            {
                Console.WriteLine("0 How? thats F- for sure :<");
            } else if (SCORE <= 25 )
            {
                Console.WriteLine("F,Come on You can do better:( ");
            } else if (SCORE <= 35)
            {
                Console.WriteLine("D-, I mean Manageable :0");
            } else if (SCORE <= 50)
            {
                Console.WriteLine("P, MID :|");
            } else if (SCORE <= 75)
            {
                Console.WriteLine("B, Above Average :>");
            } else if (SCORE <= 80)
            {
                Console.WriteLine ("A, Nice try you did great");
            } else if (SCORE <= 100)
            {
                Console.WriteLine("Excellent A+ :)");
            } else
            {
                Console.WriteLine("Invalid Score,Enter A number Between 0 and 100");
            }
            
        }
    }
}
