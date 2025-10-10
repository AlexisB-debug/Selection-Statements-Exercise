using System.Globalization;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            bool playAgain = true;
            
            do
            {
                var favNumber = random.Next(1, 100);
                int counter = 0;
                int guess = 0;
                Console.WriteLine("The game is fifteen guesses! Guess my favorite number! Hint, for this game it's an integer between 1 and 100 inclusive.");

                while (guess != favNumber && counter < 15)
                {
                    Console.WriteLine($"Guess {++counter}/15: Type your guess!");

                    while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Invalid Input; Type an integer between 1 and 100 inclusive.");
                        Console.WriteLine($"Guess {counter}/15: Type your guess!");
                    }

                    if (guess < favNumber)
                    {
                        Console.WriteLine($"{guess} is less than my favorite number!");
                    }
                    else if (guess > favNumber)
                    {
                        Console.WriteLine($"{guess} is greater than my favorite number!");
                    }
                    else
                    {
                        Console.WriteLine("Confetti, Glitter, & Bells");
                        break;
                    }
                }

                if (guess != favNumber)
                {
                    Console.WriteLine($"Guess Over, My favorite number is {favNumber}!\nKeep trying & the glitter will shine & the bells will ring!");
                }
                Console.WriteLine("Play again?\nType yes or no");
                string playAgainInput = Console.ReadLine().ToLower();
                playAgain = playAgainInput == "y" || playAgainInput == "yes";
                
            }  while (playAgain);
            
            Console.WriteLine("Thanks for playing! Goodbye!");
        }
    }
}
