namespace PassingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person ("Yuri", 20);
            Console.WriteLine("BEFORE: {0}, {1}", p1.Name, p1.Age);

            ChangePerson(p1); 
            Console.WriteLine("AFTER: {0}, {1}", p1.Name, p1.Age);

            //another example of changing/passing objects
            Person p2 = p1;
            p2.Name = "Potchi";
            Console.WriteLine("After Alternation 2: {0}, {1}", p1.Name, p1.Age);

        }

        public static void ChangePerson(Person p1)
        {
            p1.Name = "Rem";
            p1.Age = 17;
        }
    }
}
