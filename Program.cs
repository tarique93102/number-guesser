using System;

// namespace
namespace NumberGuesser
{
    // main class
    class Program
    {
        // entry point method
        static void Main(string[] args)
        {
            // function to get app info
            GetAppInfo();

            // function to greet user
            GreetUser();

            while (true)
            {

                // init correct number
                // int correctNumber = 7;

                // create a random object
                Random random = new Random();

                // init random number
                int correctNumber = random.Next(1, 11);

                // init guess variable
                int guess = 0;

                // ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // get users input
                    string input = Console.ReadLine();

                    // make sure it is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // keep going
                        continue;
                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    // match guess to correct number
                    if (guess != correctNumber)
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }

                    // keep going
                    continue;
                }

                // output success message
                // print error message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!");

                // ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                } else if (answer == "N")
                {
                    return;
                } else
                {
                    return;
                }
            }
        }

        // get and display app info
        static void GetAppInfo()
        {
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Tarique Ejaz";

            // change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // resets the text color
            Console.ResetColor();
        }

        // greet users with their name
        static void GreetUser()
        {
            // ask users name
            Console.WriteLine("What is your name?");

            // get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);
        }

        // print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
