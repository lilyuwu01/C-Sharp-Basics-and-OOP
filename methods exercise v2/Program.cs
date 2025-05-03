namespace methods_exercise_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int number = int.Parse(Console.ReadLine());
            int squared = Square(number);
            Console.WriteLine($"{number} is squared {squared}");
            int cubed = Cube(number);
            Console.WriteLine($"{number} is cubed {cubed}");

        }
        public static int Square(int number)
        {
            int answer = number * number;
            return answer;
        }
        public static int Cube(int number)
        {
            int answer = Square(number) * number;
            return answer;
        }
    }
}
