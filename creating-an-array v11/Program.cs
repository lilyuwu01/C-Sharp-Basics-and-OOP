namespace creating_an_array_v11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];

            for (int i = 0; i < myArray.Length; i++) 
            {
                bool isValid;
                do
                {
                    Console.Write($"Enter Number {i + 1}: ");
                    isValid = int.TryParse(Console.ReadLine(), out myArray[i]);

                    if (!isValid)
                    {
                        Console.WriteLine("Invalid Input");
                    }

                } while (!isValid);
            }

            Array.Reverse(myArray);

            Console.WriteLine($"The Reversed Array: {string.Join(", ", myArray)}");
        }
    }
}
