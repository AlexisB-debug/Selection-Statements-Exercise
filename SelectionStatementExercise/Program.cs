using System.Globalization;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var favNumber = random.Next(1, 100);
            int guess = 0;
            int counter = 0;
            
            //Limit my loop to 15 guesses so that the user is not allowed to play the "infinite loop game!"
            while (guess != favNumber && counter < 14)
            {
                Console.WriteLine("The game is fifteen guesses! Guess my favorite number! Hint, for this game it's an integer between 1 and 100.");
                counter = counter + 1;
                guess = int.Parse(Console.ReadLine());
                
                if (guess < favNumber)
                {
                    Console.WriteLine($"{guess} is less than my favorite number!");
                }
                else if (guess > favNumber)
                {
                    Console.WriteLine($"{guess} is greater than my favorite number!");
                }
                else if (guess == favNumber)
                {
                    Console.WriteLine("Confetti, Glitter, & Bells");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            while (guess != favNumber && counter < 1)
            {
                Console.WriteLine("Final Guess!");
                counter = counter + 1;
                guess = int.Parse(Console.ReadLine());
                
                if (guess == favNumber)
                {
                    Console.WriteLine("Confetti, Glitter, & Bells");
                }
                else
                {
                    Console.WriteLine($"My favorite number is {guess}! Keep trying and the glitter will shine and the bells ring!");
                }
            }


        }
    }
}
