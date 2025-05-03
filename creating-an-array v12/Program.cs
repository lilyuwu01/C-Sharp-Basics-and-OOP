namespace creating_an_array_v12
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
                        Console.WriteLine("Invalid Input.");
                    }


                } while (!isValid);
            }

            int oddCounter = 0;
            int evenCouter = 0;

            foreach (int num in arrayOfNumbers) 
            { 
                if(num % 2 == 0)
                {
                    evenCouter++;
                }
                else
                {
                    oddCounter++;
                }
            }

            Console.WriteLine($"The total of even in the array are: {evenCouter}");
            Console.WriteLine($"The total of odd in the array are: {oddCounter}");
        }
    }
}
