namespace class_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student("Yuri", "Booo", 23, 95);
            s1.Name = "";
            s1.FinalGrade = 105;
            Console.WriteLine(s1.FinalGrade);
            Console.WriteLine(s1.Name);

        }
    }
}
