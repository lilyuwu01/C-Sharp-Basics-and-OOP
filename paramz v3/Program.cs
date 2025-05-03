namespace paramz_v3
{
    internal class Program
    {
        public static void Main()
        {
            // Test cases
            Console.WriteLine(FindMax(3, 7));            // Output: 7
            Console.WriteLine(FindMax(1, 4, 9, 2, 8));   // Output: 9
            Console.WriteLine(FindMax());               // Output: int.MinValue (No values given)
        }

        // Method Overloading: Finds max between two numbers
        public static int FindMax(int a, int b)
        {
            return (a > b) ? a : b; // Returns the larger number
        }

        // Using 'params' to find max from multiple numbers
        public static int FindMax(params int[] numbers)
        {
            if (numbers.Length == 0) return int.MinValue; // Handle empty case

            int max = numbers[0]; // Assume first number is max

            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num; // Update max if a larger number is found
                }
            }

            return max; // Return the maximum value
        }
    }
}
