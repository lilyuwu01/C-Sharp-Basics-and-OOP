namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter operator ( +, -, *, /): ");
            string numberOperator = Console.ReadLine();
            int answerOfTwoNumbers;

            switch (numberOperator) 
            {
                case "+":
                    answerOfTwoNumbers = firstNumber + secondNumber;
                    Console.WriteLine(answerOfTwoNumbers);
                    break;
                case "-":
                    answerOfTwoNumbers = firstNumber - secondNumber;
                    Console.WriteLine(answerOfTwoNumbers);
                    break;
                case "*":
                    answerOfTwoNumbers= firstNumber * secondNumber;
                    Console.WriteLine(answerOfTwoNumbers);
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero!");
                        return;  
                    }
                    answerOfTwoNumbers = firstNumber / secondNumber;
                    break;
                default:
                    Console.WriteLine("Invalid Operator!");
                    break;


            }
        }
    }
}
