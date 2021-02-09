using System;

namespace NestedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up variables needed. Note the use of a boolean type for isNumebr.
            string input;
            bool isNumber = false;

            //  Accept input from the user
            Console.WriteLine("Please enter a number between 1 and 100: ");
            input = Console.ReadLine();

            // NOTE:
            // The Console.Readline() function treats everything (even numbers) as text, so the input
            // from the user needs to be converted to a number if possible.
            // This int.TryParse() call will return as true if the inpute is a number, and place the number
            // into the "out" variable called result, which can be accessed within the Main() function.
            isNumber = int.TryParse(input, out int result);

            // This is the part that does the work.  Read it carefully and see if you can work out what it does.
            if (isNumber)
            {
                if (result < 50)
                {
                    Console.WriteLine("Your number is less than 50");
                    if (result < 15)
                    {
                        Console.WriteLine("You picked a really low number");
                        if (result == 3)
                        {
                            Console.WriteLine($"You have guessed the magical LOW number of {result}"); 
                        }
                        else
                        {
                            Console.WriteLine($"Sorry. The magic LOW number was 3.  You selected {result}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"You picked a number between 15 and 50. Your choice of {result} is not one of the magic numbers");
                    }
                }
                else
                {
                    Console.WriteLine("Your number is 50 or higher");
                    if (result == 74)
                    {
                        Console.WriteLine($"You have guessed the magical HIGH number. Your choice of {result} is a winner!");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed a high number, but your choice of {result} is not one of the magic numbers");
                    }
                }
            }
            else
            {
                Console.WriteLine("You did not enter a number.");
            }



        }
    }
}
