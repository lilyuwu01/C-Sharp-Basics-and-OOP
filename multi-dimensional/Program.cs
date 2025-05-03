namespace multi_dimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 4];
            myArray[0,0] = 5;
            myArray[0, 1] = 6;
            myArray[0, 2] = 7;
            myArray[0, 3] = 8;

            myArray[1, 0] = 5;
            myArray[1, 1] = 6;
            myArray[1, 2] = 7;
            myArray[1, 3] = 8;

            myArray[2, 0] = 5;
            myArray[2, 1] = 6;
            myArray[2, 2] = 7;
            myArray[2, 3] = 8;

            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myArray[i, j]);
                }
                Console.WriteLine(); 
            }
        }
    }
}
