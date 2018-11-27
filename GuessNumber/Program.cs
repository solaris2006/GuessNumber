using System;

namespace GuessNumber
{
    class Program

    {
        // I am inserting a comment
        static void Main(string[] args)
        {

            string userInput;
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            bool guessed = false;
            Console.WriteLine("Please enter a number between 1 and 100");
            

            while (!guessed)          
            {
                userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out int result))
                {

                    if (result > 1 && result < 100)
                    {

                        if (result == randomNumber)
                        {
                            Console.WriteLine("You have guessed the number which is {0}", userInput);
                            guessed = true;
                        }
                        else if (result < randomNumber)
                        {
                            Console.WriteLine("The number is smaller than the target numer , try again");
                        }
                        else
                        {
                            Console.WriteLine("The number is  higher than the target number");
                        }

                    } else
                    {
                        Console.WriteLine("Please enter a number between 1 and 100");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }

            Console.ReadLine();
        }

    }
}
