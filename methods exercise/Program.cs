namespace methods_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            MultiplicationTable(number);
        }
        public static void MultiplicationTable(int number) 
        {
    
            for (int i = 2; i < 11; i++) 
            {
                int product = number * i;
                Console.WriteLine($"{number} x {i} = {product}");
            }


            
        }
    }
}
