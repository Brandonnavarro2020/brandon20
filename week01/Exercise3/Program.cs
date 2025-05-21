using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Crear generador de números aleatorios
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // 1 a 100
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("🧠 Welcome to 'Guess My Number'!");
            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");

            // Bucle para adivinar
            while (guess != magicNumber)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();
                guess = int.Parse(input);
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("🔼 Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("🔽 Lower");
                }
                else
                {
                    Console.WriteLine($"🎉 You guessed it in {guessCount} guesses!");
                }
            }

            Console.Write("Would you like to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("👋 Thanks for playing!");
    }
}
