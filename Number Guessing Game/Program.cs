using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses;
        String response;

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            response = "";
            number = random.Next(min, max + 1);

            while(guess != number)
            {
                Console.WriteLine("Guess a number between {0} - {1}:", min, max);
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: {0}", guess);

                if (guess > number)
                {
                    Console.WriteLine("{0} is too high", guess);
                }
                else if (guess < number)
                {
                    Console.WriteLine("{0} is too low", guess);
                }
                guesses++;
            }

            Console.WriteLine("Number: {0}", number);
            Console.WriteLine("YOU WIN");
            Console.WriteLine("Took you {0} guesses", guesses);

            Console.WriteLine("\nWould you like to play again (Y/N): ");
            response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }
        Console.WriteLine("Thanks for playing!....");
    }
}

