using System;
using static System.Console;

namespace Guess_Number
{
    class Guess_Number
        // Created by Jake Magri
    {
        static Random randomNumbers = new Random(); // random number generator
        static int answer; // random number generated
        static int TotalNumberGuessed; 
        static void Main(string[] args)
        {

            int userGuessNumber;

            newGame(); // start of game takes value input from user
            Write("Guess (0 to exit): ");
            userGuessNumber = Convert.ToInt32(ReadLine());

            while (userGuessNumber != 0)
            {
                TotalNumberGuessed++;
                CompareNumbers(userGuessNumber); // compares user value to answer value

                Write("Guess (0 to exit): ");
                userGuessNumber = Convert.ToInt32(ReadLine());

            }
        }
        static void newGame() // generates a random number according to constraints
        {
            answer = randomNumbers.Next(1, 1001);
            TotalNumberGuessed = 0;
            WriteLine("Guess a number between 1 and 1000");
        }

        static void CompareNumbers(int userNumber) // method with conditional statement to check answer and position according to answer value(correct, higher, lower)
        {
            if (answer == userNumber) // correct value response
            {
                WriteLine("Congratulations. You guessed the number!"); 
                WriteLine();
                DisplayMessage(TotalNumberGuessed);
                newGame();
            }
            else if (answer < userNumber) // incorrect value response (higher)
            {
                WriteLine("Too high. Try again.");
            }
            else // incorrect value response (lower)
            {
                WriteLine("Too low. Try again.");
            }

        }
        static void DisplayMessage(int TotalNumberGuessed) // method with end game message and total tries
        {
            WriteLine("You guessed the number in {0} tries", TotalNumberGuessed);

            if (10 == TotalNumberGuessed) // conditional statement to provide response according to number of guesses
            {
                WriteLine("Aha! You know the secret!");
            }
            else if (10 >= TotalNumberGuessed)
            {
                WriteLine("Either you know the secret or you got lucky!");
            }
            else
            {
                WriteLine("You should be able to do better!");
            }
            WriteLine();
        }
    }
}


