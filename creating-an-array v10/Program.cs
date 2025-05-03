namespace creating_an_array_v10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[5];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                bool isVallid;
                do
                {
                    Console.Write($"Enter Number {i + 1}: ");
                    isVallid = int.TryParse(Console.ReadLine(), out arrayOfNumbers[i]);

                    if(!isVallid)
                    {
                        Console.WriteLine("Invalid Input.");
                    }

                } while (!isVallid);
            }

            int maxNumber = arrayOfNumbers.Max();
            int minNumber = arrayOfNumbers.Min();


            Console.WriteLine($"The max number in the array is: {maxNumber}");
            Console.WriteLine($"The min number in the array is: {minNumber}");
        }
    }
}
