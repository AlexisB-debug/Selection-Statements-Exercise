using System.Globalization;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var favNumber = random.Next(1, 100);
            int counter = 0;
            Console.WriteLine("The game is fifteen guesses! Guess my favorite number! Hint, for this game it's an integer between 1 and 100 inclusive.");
            //How to create a tryparse range between 0 and 101?
            bool guessIsAnInteger;
            int guess;
            do
            {
                Console.WriteLine("Type an integer between 1 and 100.");
                guessIsAnInteger = int.TryParse(Console.ReadLine(), out guess);
            }while(!guessIsAnInteger);
            //Limit my loop to 15 guesses so that the user is not allowed to play the "infinite loop game!"
            //Console.WriteLine("Final Guess!");
            while (guess != favNumber)
            {
                counter = counter + 1;
                
                // bool guessIsAnInteger;
                // int guess;
                // do
                // {
                //     Console.WriteLine("Type an integer between 1 and 100.");
                //     guessIsAnInteger = int.TryParse(Console.ReadLine(), out guess);
                // }while(!guessIsAnInteger);
                
                
                if (guess < favNumber && counter < 14)
                {
                    Console.WriteLine($"{guess} is less than my favorite number!");
                }
                else if (guess > favNumber && counter < 14)
                {
                    Console.WriteLine($"{guess} is greater than my favorite number!");
                }
                else if (guess == favNumber && counter < 14)
                {
                    Console.WriteLine("Confetti, Glitter, & Bells");
                    break;
                }
                else if (guess < favNumber && counter == 14)
                {
                    Console.WriteLine($"My favorite number is {favNumber}! Keep trying and the glitter will shine and the bells ring!");
                    break;
                }
                else if (guess > favNumber && counter == 14)
                {
                    Console.WriteLine($"My favorite number is {favNumber}! Keep trying and the glitter will shine and the bells ring!");
                    break;
                }
                else if (guess == favNumber && counter == 14)
                {
                    Console.WriteLine("Confetti, Glitter, & Bells");
                    break;
                }
                // else
                // {
                //     Console.WriteLine("Invalid Input");
                // }
            }
        }
    }
}
