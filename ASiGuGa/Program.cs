using System;

namespace ASiGuGa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================\n");
            Console.WriteLine("| Welcome to ASiGuGa |\r");
            Console.WriteLine("======================\n");

            int number = 0;
            string difficulty = "";

            while (number == 0)
            {
                Console.WriteLine("Select your difficulty level:");
                Console.WriteLine("1 - Easy       (1 - 100)");
                Console.WriteLine("2 - Medium     (1 - 1,000)");
                Console.WriteLine("3 - Hard       (1 - 10,000)");
                Console.WriteLine("4 - Impossible (1 - 1,000,000");
                Console.Write("Enter your selection: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        number = new Random().Next(1, 100);
                        difficulty = "Easy";
                        break;
                    case 2:
                        number = new Random().Next(1, 1000);
                        difficulty = "Medium";
                        break;
                    case 3:
                        number = new Random().Next(1, 10000);
                        difficulty = "Hard";
                        break;
                    case 4:
                        number = new Random().Next(1, 1000000);
                        difficulty = "Impossible";
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }

                Console.WriteLine("=============================");
            }

            Console.WriteLine($"Starting game in {difficulty}");

            int guess = 0;
            int tries = 0;
            while (guess != number && tries < 10)
            {
                Console.Write($"(Try {++tries} / 10) Type your guess, and then press Enter: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < number)
                {
                    Console.WriteLine($"The number is HIGHER than {guess}");
                }
                else if (guess > number)
                {
                    Console.WriteLine($"The number is LOWER than {guess}");
                }
            }

            Console.WriteLine("=================================");

            if (guess == number)
            {
                Console.WriteLine("You won!!!");
                Console.WriteLine($"You managed to guess the number after {tries} tries!");
            }
            else
            {
                Console.WriteLine("You lost...");
                Console.WriteLine($"The number was {number}");
                switch (difficulty)
                {
                    case "Medium":
                        Console.WriteLine("You could try lowering the difficulty to Easy");
                        break;
                    case "Hard":
                        Console.WriteLine("You could try lowering the difficulty to Medium");
                        break;
                    case "Impossible":
                        Console.WriteLine("You could try lowering the difficulty to Hard");
                        break;
                    default:
                        Console.WriteLine("Try playing again!");
                        break;
                }
            }

            Console.WriteLine("=================================");
            Console.Write("Press any key to close the app... ");
            Console.ReadKey();
        }
    }
}
