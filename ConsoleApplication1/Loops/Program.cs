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
            //for (int i = 0; i <= 24; i += 4)
            //{
            //    Console.Write($" {i} ");

            //    for (int j = 0; j <= 24; j += 3)
            //    {
            //        Console.Write($" {j} ");

                    for (int k = 0; k <= 2; k += 2)
                    {
                        Console.Write($" {k} ");

                        for (int l = 0; l <= 24; l += 1)
                        {
                            Console.Write($" {l} ");
                        }

                        Console.WriteLine();
                    }

            //    }
            //}
            Console.ReadLine();
        }
    }
}
