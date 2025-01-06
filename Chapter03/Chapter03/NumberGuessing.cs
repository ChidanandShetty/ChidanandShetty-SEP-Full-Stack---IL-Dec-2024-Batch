using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class NumberGuessing
    {
        static void Main()
        {
            Random random = new Random();
            int correctNumber = random.Next(1, 4); // Generates 1, 2, or 3

            Console.Write("Guess a number (1-3): ");
            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber < 1 || guessedNumber > 3)
                Console.WriteLine("Invalid guess! Please enter a number between 1 and 3.");
            else if (guessedNumber < correctNumber)
                Console.WriteLine("Too low!");
            else if (guessedNumber > correctNumber)
                Console.WriteLine("Too high!");
            else
                Console.WriteLine("Correct! You guessed it!");
        }
    }
}
