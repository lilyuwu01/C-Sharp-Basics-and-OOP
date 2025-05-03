namespace paramz_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessage("Hello");      // Output: Hello
            PrintMessage("Hi", true);   // Output: !!! Hi !!!
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message); // Prints the message normally
        }

        // Overloaded version
        public static void PrintMessage(string message, bool emphasize)
        {
            if (emphasize)
            {
                Console.WriteLine($"!!! {message} !!!"); // Adds emphasis
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
