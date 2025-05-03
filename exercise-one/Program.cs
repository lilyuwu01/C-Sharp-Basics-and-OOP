namespace exercise_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an hourly pay rate: ");
            double hourPay = double.Parse(Console.ReadLine());

            if(hourPay < 7.50 || hourPay >= 49.00)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("Okay");
            }

        }
    }
}
