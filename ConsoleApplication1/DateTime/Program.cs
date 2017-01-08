using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Calculating Durations Between DateTimes
                //this line creates a new instance for next year
                //DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
                //this line subracts that instance from current date
                //TimeSpan duration = nextYear - DateTime.Today;
                //Console.WriteLine($"There are {duration.TotalDays} days left in the year");

            //Lessons for Getting to Parts of Dates and Times 
                //var currentTime = DateTime.Now; // current time
                //var someTime = new DateTime(2016, 7, 1, 11, 10, 9); // 1 July 2016 11:10:09 AM (setting new time/date)
                //int year = someTime.Year; // 2016
                //int month = someTime.Month; // 7
                //int day = someTime.Day; // 1
                //int hour = someTime.Hour; // 11
                //int minute = someTime.Minute; // 10
                //int second = someTime.Second; // 9

                //Console.WriteLine($"{nameof(someTime)}: {someTime}");
                //Console.WriteLine($"{nameof(year)}: {year}");
                //Console.WriteLine($"{nameof(month)}: {month}");
                //Console.WriteLine($"{nameof(day)}: {day}");
                //Console.WriteLine($"{nameof(hour)}: {hour}");
                //Console.WriteLine($"{nameof(minute)}: {minute}");
                //Console.WriteLine($"{nameof(second)}: {second}");


            Console.WriteLine("Hello, please give me your date of birth like so '1/1/1980' ");
            //Split input into array
            string[] input = (Console.ReadLine().Split('/'));
            //convert to int to get dob
            int[] dob = Array.ConvertAll(input, Int32.Parse); 
            int month = dob[0];
            int day = dob[1];
            int year = dob[2];

            //how many days old
            var someDate = new DateTime(year,month,day);
            TimeSpan duration = DateTime.Today - someDate;
            Console.WriteLine($"You are {duration.TotalDays} days old");

            //determine current date to check for age
            var today = DateTime.Now;
            var currentYear = today.Year;
            var currentMonth = today.Month;
            var currentDay = today.Day;

            //check for when bday falls to know age
            if (currentMonth < month && currentDay < day)
            {
                int age = currentYear - (year+1);
                Console.WriteLine($"You are {age} years old ");
            }
            if(currentMonth >= month && currentDay >= day)
            {
                int age = currentYear - year;
                Console.WriteLine($"You are {age} years old ");
                if (currentDay == day)
                {
                    Console.WriteLine($"Happy Birthday!!");
                    TimeSpan future = new TimeSpan(10000, 0, 0, 0);
                    DateTime anniversary = today.Add(future);
                    Console.WriteLine($"Your 10,000 day Anniversay falls on {anniversary}");
                }
            }

            Console.ReadLine();
        }
    }
}
