using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What name do you go by?");

            var name = Console.ReadLine();

            //get curernt time to compare
            DateTime currentTime = DateTime.Now;
            int year = currentTime.Year;
            int month = currentTime.Month;
            int day = currentTime.Day;

            //set new value for when it is considered morning, evening, night (afternoon is between morning-evening)
            var morningTime = new DateTime(year, month, day, 11, 59, 59);
            var eveningTime = new DateTime(year, month, day, 16, 59, 59);
            var nightTime = new DateTime(year, month, day, 20, 0, 0);

            //create rule to check curernt time to expected greeting
            var morning = (currentTime < morningTime);
            var afternoon = (currentTime > morningTime && currentTime < eveningTime);
            var evening = (currentTime > eveningTime && currentTime < nightTime);
            var night = (currentTime > nightTime);

            if (morning == true)
            {
                Console.WriteLine($"Good Monring {name}!");
            }
            if (afternoon == true)
            {
                Console.WriteLine($"Good Afternoon {name}!");
            }
            if (evening == true)
            {
                Console.WriteLine($"Good Evening {name}!");
            }
            if (night == true)
            {
                Console.WriteLine($"Good Night {name}!");
            }

            Console.ReadLine();
        }
    }
}
