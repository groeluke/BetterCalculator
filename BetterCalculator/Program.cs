









namespace BetterCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int firstNumber, secondNumber;

            Console.WriteLine("Please enter a number:");
            userInput = Console.ReadLine();
            firstNumber = int.Parse(userInput);
            Console.WriteLine($"You entered: {firstNumber}");

            Console.WriteLine("Please enter a number:");
            userInput = Console.ReadLine();
            secondNumber = int.Parse(userInput);
            Console.WriteLine($"You entered: {secondNumber}");

            Console.WriteLine("Chose an operation to perform: 1 addtion, 2 subtraction, 3 multiplication, 4 division");
            userInput = Console.ReadLine();
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
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    break;
            }
        }
    }
}
