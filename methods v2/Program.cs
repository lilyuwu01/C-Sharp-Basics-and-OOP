namespace methods_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5, 3);
            Console.WriteLine(result);
        }
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
