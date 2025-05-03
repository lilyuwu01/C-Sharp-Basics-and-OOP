namespace StaticKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Boi", 6);
            Person p2 = new Person("Girl", 9);

            Console.WriteLine(Person.Count);

            Test();
        }

        public static void Test()
        {
            Console.WriteLine("Test"); 
        }
    }
}
