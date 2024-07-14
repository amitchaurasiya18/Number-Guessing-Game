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
            char playAgain = 'y';

            while (playAgain == 'y')
            {
                PlayGame();
                Console.Write("Want to play again? For 'Yes' press 'y' and for 'No' press 'n': ");
                playAgain = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thank you for playing!");
        }

        private static void PlayGame()
        {
            int randomNumber = new Random().Next(1, 101);
            int guessedNumber;
            int counter = 1;

            while (true)
            {
                Console.WriteLine("Guess any number from 1 to 100: ");
                guessedNumber = int.Parse(Console.ReadLine());

                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine($"You guessed it in {counter} attempts!\n");
                    break;
                }

                Console.WriteLine(ReturnHint(guessedNumber, randomNumber));
                counter++;
            }
        }

        private static string ReturnHint(int guessedNumber, int randomNumber)
        {
            return (guessedNumber > randomNumber) ? "Sorry, too High" : "Sorry, too Low";
        }
    }
}