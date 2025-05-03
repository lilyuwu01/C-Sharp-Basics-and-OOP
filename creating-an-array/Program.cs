namespace creating_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //you can use a do while loop for safer input handling.
            int[] arrayOfNumbers = new int[5];
            int sumOfNumbers = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write($"Enter Number {i+1}: ");
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());

                sumOfNumbers += arrayOfNumbers[i];

            }
            Console.WriteLine($"Sum of all Numbers: {sumOfNumbers}");
        }
    }
}
