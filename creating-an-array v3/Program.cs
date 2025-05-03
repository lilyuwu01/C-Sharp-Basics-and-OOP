using System;

namespace creating_an_array_v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[5];
            int counterEven = 0;
            int counterOdd = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                bool isValid;
                
                do
                {
                    Console.Write($"Enter Number {i + 1}: ");
                    isValid = int.TryParse(Console.ReadLine(), out arrayOfNumbers[i]);

                    if (!isValid)
                    {
                        Console.WriteLine("Invalid Input. Please enter a number.");
                    }
                    else if(arrayOfNumbers[i] <= 0)
                    {
                        Console.WriteLine("Invalid Input. Please enter a positive number.");
                    }
                    else
                    {
                        if(arrayOfNumbers[i] % 2 == 0)
                        {
                            counterEven++;
                        }
                        else
                        {
                            counterOdd++;
                        }
                        
                    }

                } while (!isValid || arrayOfNumbers[i] <= 0);

           }

            Console.WriteLine($"Total of Even in the Array: {counterEven}");
            Console.WriteLine($"Total of Odd in the Array: {counterOdd}");
        }
    }
}
