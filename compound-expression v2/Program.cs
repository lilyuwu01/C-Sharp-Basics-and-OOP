namespace compound_expression_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.Write("Are you a citizen? (true/false): ");
            bool ansCiti = bool.Parse(Console.ReadLine());

            if (userAge >= 18 && ansCiti)
            {
                Console.WriteLine("You are eligible to vote!");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote!");
            }

        }
    }
    
}
