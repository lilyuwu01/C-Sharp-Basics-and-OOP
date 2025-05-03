namespace creating_an_array_v6
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
                    Console.Write($"Enter Number {i + 1}: ");
                    isValid = int.TryParse(Console.ReadLine(), out arrayOfNumbers[i]);

                    if (!isValid)
                    {
                        Console.WriteLine("Invalid Input");
                    }

                } while (!isValid);
            }

            Array.Reverse(arrayOfNumbers);

            for (int i = 0;i < arrayOfNumbers.Length;i++)
            {
                Console.WriteLine($"The Reverse Version: {arrayOfNumbers[i]}");
            }
        }
    }
}
