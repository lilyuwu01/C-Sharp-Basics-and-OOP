namespace ValidationApplication_OOP.PointsAndLines
{

    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Yuri");
            Console.WriteLine(User.ID);

            User user2 = new User();
            Console.WriteLine(User.ID);
        }
    }
}
