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
            Console.WriteLine("what is your name?");

            var name = Console.ReadLine();

            DateTime currentTime = DateTime.Now;
            int year = currentTime.Year;
            int month = currentTime.Month;
            int day = currentTime.Day;

            var morningTime = new DateTime(year, month, day, 11, 59, 59);
            var afternoonTime = new DateTime(year, month, day, 12, 0, 0);
            var eveningTime = new DateTime(year, month, day, 17, 59, 59);
            
            var morning = (currentTime < morningTime );
            var afternoon = (currentTime > morningTime && currentTime < eveningTime);

            if (morning == true)
            {
                Console.WriteLine("Good Monring");
            }
            if (afternoon == true)
            {
                Console.WriteLine("Good Afternoon");
            }
        }
    }
}
