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

            int guessedNumber;

            int randomNumber = new Random().Next(4);

            //Console.WriteLine($"{randomNumber}");

            Console.WriteLine($"Please guess a number between 1 and 3");
            
            do
            {
                guessedNumber = int.Parse(Console.ReadLine());

                if (guessedNumber < 1 || guessedNumber > 3)
                {
                    Console.WriteLine("You have guessed a number outside the range between one and three, please try again");
                }

            }while (guessedNumber < 1 || guessedNumber > 3);

            
            if (guessedNumber == randomNumber)
            {
                Console.WriteLine("You have guessed right");
            }  
            if (guessedNumber > randomNumber)
            {
                Console.WriteLine("Your guessed number was to high");
            }  
            if (guessedNumber < randomNumber)
            {
                Console.WriteLine("Your guessed number was to low");
            } 

            Console.ReadLine();
        }
    }
}
