namespace methods_exercise_v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum(5);
            Sum(5, 10, 15);
            Sum(5, 10, 15, 20);

            int[] myArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Sum(myArray);
        }
        public static void Sum(params int[] myArray)
        {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++) 
            {
                sum += myArray[i];            
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
