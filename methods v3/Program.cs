namespace methods_v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintEvenOdd(4);  // Expected output: "Even"
            PrintEvenOdd(7);  // Expected output: "Odd"
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0; // Returns true if even, false if odd
        }

        public static void PrintEvenOdd(int number)
        {
            if (IsEven(number)) // Calls IsEven and checks its returned value
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
  

