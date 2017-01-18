using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpressionBasedLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Factors: ");
            while (number > 1) // convert this to while
            {
                int candidateFactor = 1;
                while (candidateFactor <= number) // convert this to while
                {
                    if (number % candidateFactor == 0) // found a factor
                    {
                        Console.Write(candidateFactor);
                        // divide number by the factor you found and assign this back to number
                         number = number / candidateFactor;
                        // print a comma if number is still greater than 1
                        if (number > 1)
                            Console.Write(", ");
                    }
                    // don't forget to increment factor!
                    if (candidateFactor <= number)
                    candidateFactor++;
                }
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
