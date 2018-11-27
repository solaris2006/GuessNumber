using System;

namespace GuessNumber
{
    class Program

    {
        
        static void Main(string[] args)
        {


            //add variables
            string userInput;
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            bool guessed = false;
            Console.WriteLine("Please enter a number between 1 and 100");
            

            //main logic 
            while (!guessed)          
            {
                //ask user input
                userInput = Console.ReadLine();

                //verify if it is a number
                if (Int32.TryParse(userInput, out int result))
                {
                    // test conditions for numbers betwenn 1 and 100
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
