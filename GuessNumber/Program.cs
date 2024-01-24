namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess a number (1-100):");

            Random randomNumber = new Random();
            int winningNumber = randomNumber.Next(1, 101);

            int guess = int.Parse(Console.ReadLine());

            while (guess != winningNumber)
            {
                if (guess > winningNumber)
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("Too low");
                }
                Console.Write("Guess a number (1-100):");
                guess = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You guessed it!");
        }
    }
}