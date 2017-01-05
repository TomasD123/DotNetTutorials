using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string emptyString = String.Empty;
            string nullString = null;

            Console.WriteLine(emptyString); // prints nothing
            Console.WriteLine(nullString); // prints nothing

            // this line will print 0
            Console.WriteLine($"1st string is {emptyString.Length} characters long.");
            //by adding the $ it shows the numeric value between the {}

            // this line will throw an exception (uncomment it to confirm)
            // Console.WriteLine($"2nd string is {nullString.Length} characters long.");

            Console.ReadLine();
        }
    }
}
