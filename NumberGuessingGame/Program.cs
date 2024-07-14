using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(1, 100);
            int guessedNumber;
            int counter = 1;


            while (true)
            {
                Console.WriteLine("Guess any number from 1 to 100: ");
                guessedNumber = int.Parse(Console.ReadLine());
                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine("You made in {0}", counter);
                    break;
                }
                Console.WriteLine(ReturnHint(guessedNumber, randomNumber));
                counter++;
            }
        }

        public static string ReturnHint(int guessedNumber, int randomNumber)
        {
            string result = (guessedNumber > randomNumber) ? "The number is lesser than the number you guessed" : "The number is greater than the number you guessed";
            return result;
        }
    }
}
