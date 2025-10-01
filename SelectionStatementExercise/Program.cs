namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = new Random().Next(1, 100);
            int guess = int.Parse(Console.ReadLine());

            while (guess != favNumber)
            {
                NumberGame(favNumber);
            }
        }

        static int NumberGame(int favNumber)
        {
            Console.WriteLine("Guess my favorite number! Hint, for this game it's an integer between 1 and 100.");
            int guess = int.Parse(Console.ReadLine());

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
            }
        }
    }
}
