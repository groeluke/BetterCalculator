
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
                Console.WriteLine("Please enter two numbers. Enter \"Q\" at any time to quit.\n");

                int firstNumber = ReadValidNumber();
                if (firstNumber == int.MinValue) break;

                int secondNumber = ReadValidNumber();
                if (secondNumber == int.MinValue) break;

                string operation = ReadValidOperation();
                if (operation == "Q") break;

                ShowResult(firstNumber, secondNumber, operation);

                Console.WriteLine("\n");  // clean separation before next cycle
            }

            Console.WriteLine("Have a nice day");
            Console.WriteLine("Press Enter to close this window");
            Console.ReadLine();
        }

        static int ReadValidNumber()
        {
            while (true)
            {
                Console.Write("Choose a Number: ");
                string? input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                    continue;  // blank Enter → re-prompt quietly

                if (input!.Equals("Q", StringComparison.OrdinalIgnoreCase))
                    return int.MinValue;

                if (int.TryParse(input, out int number))
                {
                    Console.WriteLine($"You entered \"{input}\"");
                    return number;
                }

                Console.WriteLine($"You entered \"{input}\", please enter a whole number.");
            }
        }

        static string ReadValidOperation()
        {
            while (true)
            {
                Console.WriteLine("Choose one of the following options:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");

                Console.Write("Your choice: ");
                string? input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                    continue;

                if (input!.Equals("Q", StringComparison.OrdinalIgnoreCase))
                    return "Q";

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
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    break;

                case "2":
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;

                case "3":
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;

                case "4":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine($"{firstNumber} / {secondNumber} = Cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    }
                    break;

                default:
                    // Should never reach here due to validation
                    Console.WriteLine("Invalid operation.");
                    break;
                    //pause 
                    Console.Read();
            }
        }
    }
}
