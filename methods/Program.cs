namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreetUser("Yuri");
        }
        public static void GreetUser(string nameUser = "Yuri")
        {
            Console.WriteLine($"Hello, {nameUser}! Welcome to the program.");
        }
    }
}
