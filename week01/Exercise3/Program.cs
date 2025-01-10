using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new();
        int guessnumber = randomGenerator.Next(1, 50);
        int guess = 0;

        while (guess != guessnumber)
        {
            Console.Write("What is your guess? ");
            string guessuser = Console.ReadLine();
            guess = int.Parse(guessuser);

            if (guess < guessnumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > guessnumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}