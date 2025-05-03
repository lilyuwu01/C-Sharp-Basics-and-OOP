namespace creating_an_array_v7
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
                        Console.WriteLine("Invalid Input. Enter a Number.");
                    }


                } while (!isValid);
            }

            int greatCounter = 0;

            Console.Write("Enter a number to compare: ");
            int numberToCompare = int.Parse(Console.ReadLine());

            foreach (int num in arrayOfNumbers) 
            { 
                if(num > numberToCompare)
                {
                    greatCounter++;
                }
            }

            Console.WriteLine($"Numbers greater than {numberToCompare}: {greatCounter}");
        }



            

            
    }
}

