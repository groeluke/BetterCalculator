
/*Luke Groesbeck
Spring 2026
RCET 2265
Project BetterCalculator
Computer Fundamentals and Introduction to Programming
https://github.com/groeluke/BetterCalculator.git
*/

namespace BetterCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int result = 0;
            bool isValid = false;
            string message = "";

            do
            {

                Console.WriteLine("Please enter two numbers. Enter \"Q\" at any time to quit.");
                userInput = Console.ReadLine();
                Console.WriteLine($"Choose a Number: \"{userInput}\"");

                try
                {
                    result = int.Parse(userInput);
                    message = $"Good job! {result} is a number";
                    isValid = true;
                }
                catch (Exception ex)
                {
                    if (userInput == "Q" || userInput == "q")
                    {
                        message = "Have a wonderful day";
                        isValid = true;
                    }
                    else
                    {
                        message = $" You entered \"{userInput}\", please enter a real number.";
                    }
                }

                Console.WriteLine(message);
            } while (isValid == false);

            Console.Read();

        }
    }
}
