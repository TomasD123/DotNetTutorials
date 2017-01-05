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
            //string emptyString = String.Empty;
            //string nullString = null;

            //Console.WriteLine(emptyString); // prints nothing
            //Console.WriteLine(nullString); // prints nothing

            //// this line will print 0
            //Console.WriteLine($"1st string is {emptyString.Length} characters long.");
            ////by adding the $ it shows the numeric value between the {}

            //// this line will throw an exception (uncomment it to confirm)
            //// Console.WriteLine($"2nd string is {nullString.Length} characters long.");

            string name = "Tom";
            string greeting1 = $"Hello {name} !";
            var loud = name.ToUpper();
            var quiet = name.ToLower();

            string number = "";
            Console.WriteLine(greeting1);
            Console.WriteLine("Please give me a number between 1-6 ");            
            number = Console.ReadLine();

            if (string.IsNullOrEmpty(number))
            {
                Console.WriteLine(greeting1);
            }
            else
            {
                int num = Int32.Parse(number);

                if (num <= 3)
                {
                    Console.WriteLine($"Hello {quiet} !");
                }
                else if (num >= 4 && num <= 6)
                {
                    Console.WriteLine($"Hello {loud} !");
                }
            }
            
            

            Console.ReadLine();
        }
    }
}
