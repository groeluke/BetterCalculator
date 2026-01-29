
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
            while (true)
            {
                Console.WriteLine("Please enter two numbers. Enter \"Q\" at any time to quit."); 
                //instructions for user

                int firstNumber = ReadValidNumber();
                //reads and validats the first number
                if (firstNumber == int.MinValue) break;
                //checks for quit command

                int secondNumber = ReadValidNumber(); 
                //reads and validates the second number
                if (secondNumber == int.MinValue) break;
                //checks for quit commant

                string operation = ReadValidOperation();
                //reads and validates the operation
                if (operation == "Q") break;

                ShowResult(firstNumber, secondNumber, operation);
                //shows the result based on user input
                Console.WriteLine(); 
                //blank line for readability
            }

            Console.WriteLine("Have a nice day");
            Console.WriteLine("Press Enter to close this window");
            Console.ReadLine();
            //this is for user convinience when "Q" is entered to quit the program
        }

        static int ReadValidNumber() 
            //Reads and validates user input for numbers
        {
            while (true)
            {
                Console.Write("Choose a Number: "); 
                //prompt for user input
                string? input = Console.ReadLine(); 
                //reads user input

                if (string.IsNullOrEmpty(input))
                    // if the input is empty, it loops back
                    continue;  

                if (input!.Equals("Q", StringComparison.OrdinalIgnoreCase)) 
                    return int.MinValue;
                //checks for quit command

                if (int.TryParse(input, out int number)) 
                {
                    Console.WriteLine($"You entered \"{input}\"");
                    //validating user input for number
                    return number;
                }

                Console.WriteLine($"You entered \"{input}\", please enter a whole number."); 
                //error message for invalid input
            }
        }

        static string ReadValidOperation() 
            //reads and validates user input for operation
        {
            while (true)
            {
                //option prompt for operations
                Console.WriteLine("Choose one of the following options:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");

                //user input for operation
                Console.Write("Your choice: ");
                string? input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                    // if the input is empty, it loops back
                    continue;

                if (input!.Equals("Q", StringComparison.OrdinalIgnoreCase))
                    return "Q";
                //validating user input for operation
                if (input == "1" || input == "2" || input == "3" || input == "4")
                {
                    Console.WriteLine($"You entered \"{input}\"");
                    return input;
                }

                Console.WriteLine($"You entered \"{input}\"");
                // loops back (no extra error text — matches example)
            }
        }
 
        static void ShowResult(int firstNumber, int secondNumber, string userInput) 
            //Shows the result based on user input
        {
            switch (userInput)
            {
                case "1": //addition
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    break;

                case "2": //subtraction
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;

                case "3": //multiplication
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;

                case "4": //division
                    if (secondNumber == 0)
                    {
                        Console.WriteLine($"{firstNumber} / {secondNumber} = Cannot divide by zero");
                        //handling division by zero
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation."); 
                    // should not reach here due to prior validation
                    break;
            }
        }
    }
}
