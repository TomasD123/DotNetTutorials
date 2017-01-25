using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 3; i += 1)
            {

                for (int j = 0; j <= 24; j += 1)
                {
                    string product = Convert.ToString(j);
                    Console.Write("{0}",  product.PadLeft(4) );
                    if (j < 24)
                        Console.Write(",");
                    j += i;
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
