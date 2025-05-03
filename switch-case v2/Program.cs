namespace switch_case_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayNumber;
            Console.Write("Enter a number (1-7): ");
            bool isDayValid = int.TryParse(Console.ReadLine(), out dayNumber);

            if (!isDayValid)  // Check if input is not a valid number
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                return; // Exit early to prevent executing the switch case
            }

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number! Please enter a number between 1 and 7.");
                    break;
            }
            }
        }
    }





