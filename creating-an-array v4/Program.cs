namespace creating_an_array_v4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[5];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                bool isValid;
                do
                {
                    Console.Write($"Enter for number {i + 1}: ");
                    isValid = int.TryParse(Console.ReadLine(), out arrayOfNumbers[i]); 

                    if (!isValid)
                    {
                        Console.WriteLine("Invalid Input. Enter a number.");
                        
                    }

                }while (!isValid);

            }

            int smallestNumber = arrayOfNumbers[0];

            for (int i = 1; i < arrayOfNumbers.Length; i++)
            {
                if (smallestNumber > arrayOfNumbers[i])
                {
                    smallestNumber = arrayOfNumbers[i];
                }
            }
            Console.WriteLine($"The Smallest Number is: {smallestNumber}");
        }
    }
}
