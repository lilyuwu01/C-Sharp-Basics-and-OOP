namespace creating_an_array_v5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Declare an array to store 5 numbers
            int[] arrayOfNumbers = new int[5];

            // Loop to take user input and store it in the array
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                bool isValid;
                do
                {
                    Console.Write($"Enter Number {i + 1}: "); // Prompt user to enter a number
                    isValid = int.TryParse(Console.ReadLine(), out arrayOfNumbers[i]); // Try to parse user input

                    if (!isValid)
                    {
                        Console.WriteLine("Invalid Input."); // Show error message if input is not a valid integer
                    }
                }
                while (!isValid); // Repeat until a valid number is entered
            }

            // Initialize two variables to hold the first and second largest numbers
            // We use int.MinValue so that any number entered will be larger
            int firstLargestNumber = int.MinValue;
            int secondLargestNumber = int.MinValue;

            // This flag is used to check if we actually found a second largest number
            bool foundSecondLargest = false;

            // Loop through the array to determine the first and second largest numbers
            foreach (int num in arrayOfNumbers)
            {
                // If the current number is greater than the first largest number
                if (num > firstLargestNumber)
                {
                    secondLargestNumber = firstLargestNumber; // The old first largest becomes second largest
                    firstLargestNumber = num; // Update first largest number
                    foundSecondLargest = true; // We have a valid second largest number
                }
                // If the current number is greater than second largest but not equal to first largest
                else if (num > secondLargestNumber && num != firstLargestNumber)
                {
                    secondLargestNumber = num; // Update second largest number
                    foundSecondLargest = true;
                }
            }

            // Check if a valid second largest number was found
            if (!foundSecondLargest)
            {
                Console.WriteLine("No second largest number found."); // This happens if all numbers are the same
            }
            else
            {
                Console.WriteLine($"Second Largest Number: {secondLargestNumber}"); // Output the second largest number
            }
        }
    }
}
