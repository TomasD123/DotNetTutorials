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

            string[] input;
            int[] dob;
            int month, day, year;
            bool validMonth = false;
            bool validDay = false;
            bool validYear = false;

            Console.WriteLine("Hello, please give me your date of birth like so 'xx/xx/xxxx' ");

            do
            {
                //Split input into array
                input = (Console.ReadLine().Split('/'));

                if (input[0].Length == 1 || input[0].Length == 2)
                    validMonth = true;
                if (input[1].Length == 1 || input[1].Length == 2)
                    validDay = true;
                if (input[2].Length == 4)
                    validYear = true;

                if (validMonth == false || validDay == false || validYear == false)
                {
                    Console.WriteLine("Please enter date of birth like so xx/xx/xxxx");
                }

                //convert to int to get dob
                dob = Array.ConvertAll(input, Int32.Parse);
                month = dob[0];
                day = dob[1];
                year = dob[2];

            } while (validMonth == false || validDay == false || validYear == false);

            //how many days old
            //this line set up a date
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
                //if (currentDay == day)
                {
                    Console.WriteLine($"Happy Birthday!!");
                    ///*use TimeSpan to represents a time interval (duration of time or elapsed time) that is measured as a positive or negative 
                    //  number of days, hours, minutes, seconds, and fractions of a second. Because it represents a general interval without 
                    //  reference to a particular start or end point, it cannot be expressed in terms of years and months */
                    //TimeSpan future = new TimeSpan(10000, 0, 0, 0);
                    ///*using Add Method (using TimeSpan) to add the 10k to find out anniversary */
                    //DateTime anniversary = today.Add(future);
                    //Console.WriteLine($"Your 10,000 day Anniversay falls on {anniversary}");
                }
            }

            double durationTillNext = duration.TotalDays;
            int daysToNextAnniversary = 10000 - (Convert.ToInt32(durationTillNext) % 10000);
            TimeSpan future2 = new TimeSpan(daysToNextAnniversary, 0, 0, 0);
            DateTime anniversary2 = DateTime.Today + future2;

            Console.WriteLine("You have {0} till your next 10000 days of life, which falls on {1}", daysToNextAnniversary, anniversary2); 

            Console.ReadLine();
        }
    }
}
