using System;

//namespace
namespace Number_Guesser
{
    //main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Code_Dev";

            //change the text color
            Console.ForegroundColor = ConsoleColor.Green;

            //write the app info
            Console.WriteLine("{0}: Version {1} by {2}",appName,appVersion,appAuthor);

            //reset the text color
            Console.ResetColor();

            //ask users name
            Console.WriteLine("What's your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...",inputName);

            while (true)
            {



                //set the number
                //int num = 7;

                //create a random object
                Random random = new Random();

                int num = random.Next(1, 11);

                //init guess
                int guess = 0;

                //game over
                Console.WriteLine("Guess a number between 1 and 10");

                //check if the guess is not correct
                while (guess != num)
                {
                    string input = Console.ReadLine();

                    //make sure its a num
                    if (!int.TryParse(input, out guess))
                    {
                        //change the text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //tell the player its not an number
                        Console.WriteLine("That's not a number!");

                        //reset the text color
                        Console.ResetColor();

                        //keep going
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != num)
                    {

                        //change the text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //game over
                        Console.WriteLine("Wrong number, please try again");

                        //reset the text color
                        Console.ResetColor();
                    }
                }

                //output success message
                //change the text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                //game win
                Console.WriteLine("You are correct");

                //reset the text color
                Console.ResetColor();

                //ask if the player wants to play again
                Console.WriteLine("Play again? [Y or N]");

                //get the answers
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }
    }
}
