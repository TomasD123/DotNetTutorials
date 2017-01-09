using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingDecisionIfElseSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple switch example
                //uint guessedNumber = 1;
                //switch (guessedNumber)
                //{
                //    case 0:
                //        Console.WriteLine("Sorry, 0 is not a valid guess.");
                //        break;
                //    case 1:
                //    case 2:
                //    case 3:
                //        Console.WriteLine("You guessed low.");
                //        break;
                //    case 4:
                //        Console.WriteLine("You guessed the right number!");
                //        break;
                //    default:
                //        Console.WriteLine("You guessed high.");
                //        break;
                //}

            int correctNumber = new Random().Next(4);

            int guessNumber = int.Parse(Console.ReadLine());


        }
    }
}
