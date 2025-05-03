namespace ArraysOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[2];
            myArray[0] = 5;
            myArray[1] = 10;

            Person[] peopleArray = new Person[2];
            peopleArray[0] = new Person("Yuri", 20);
            peopleArray[1] = new Person("Potchi", 24);

            for(int i = 0; i < peopleArray.Length; i++) 
            {
                Console.WriteLine("{0}, {1}", peopleArray[i].Name, peopleArray[i].Age);
            
            }
        }
    }
}
