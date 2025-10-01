using System.Globalization;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = new Random().Next(1, 100);
            Console.WriteLine("Guess my favorite number! Hint, for this game it's an integer between 1 and 100.");
            int guess = int.Parse(Console.ReadLine());
            //Limit my loop to 15 guesses so that the user is not allowed to play the "infinite loop game!"
            while (index[] <= index[14])
            {
                NumberGame(favNumber);
                index[] = index[] + 1
            }

            while (index[] == index[15])
            {
                NumbersSalutations(favNumber);
            }
        }

        static int NumberGame(int favNumber, int guess)
        {
            if (guess < favNumber)
            {
                return Console.WriteLine($"{guess} is less than my favorite number!");
            }
            else if (guess > favNumber)
            {
                return Console.WriteLine($"{guess} is greater than my favorite number!");
            }
            else if (guess == favNumber)
            {
                return Console.WriteLine("Confetti, Glitter, & Bells");
                yield break;
            }
        }

        static int NumbersSalutations(int favNumber, int guess)
        {
            if (guess == favNumber)
                return Console.WriteLine("Confetti, Glitter, & Bells");
            else if (guess !== favNumber)
                return Console.WriteLine($"Sorry, your out of guesses. My favorite number is {guess}");
        }
    }
}
