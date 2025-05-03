namespace creating_an_array_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[5];


            for(int i = 0; i < arrayOfNumbers.Length; i++)
            {
                bool isValid;
                do
                {
                    Console.Write($"Enter a number {i + 1}: ");
                    isValid = int.TryParse(Console.ReadLine(), out arrayOfNumbers[i]);

                    if (!isValid)
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }


                } while( !isValid );

            }

            int largestNumber = arrayOfNumbers[0];

            for (int i = 1; i < arrayOfNumbers.Length; i++)
            {


                if (arrayOfNumbers[i] > largestNumber)
                {
                    largestNumber = arrayOfNumbers[i];
                }
            }

            Console.WriteLine($"The largest number is: {largestNumber}");
        }
    }
}
