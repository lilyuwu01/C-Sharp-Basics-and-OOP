namespace multi_dimensional_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[3][];
            myArray[0] = new int[4] { 5, 6, 7, 8 };
            myArray[1] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            myArray[2] = new int[2] { 1, 2 };

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
