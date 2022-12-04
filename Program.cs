using System;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Get app info
            GetAppInfo();

            //Ask user name and start game
            GreetUser();

            string cont = "y";

            while (cont.ToLower() == "y")
            {

                //Generate random number between 1 and 10 each time code is run
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

                int tries = 1;

                Console.Write("Guess a number between 1 and 10: ");

                while (guess != correctNumber)
                {

                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please input an integer");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write("Wrong. Guess again: ");

                        tries++;
                    }

                    if (guess == correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Congratulations, that is correct and it took you {0} tries", tries);

                        Console.ResetColor();
                    }
                }

                Console.Write("Would you like to play again?(Y/N): ");

                cont = Console.ReadLine();

            }
        }

        //get and display app info
        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Adam Kangiser";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset color
            Console.ResetColor();
        }

        //ask user name and greet
        static void GreetUser()
        {
            //get user name and start game
            Console.Write("What is your name? ");

            string userName = Console.ReadLine();

            Console.WriteLine("Hellow {0}, let's play a game...", userName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}