namespace params

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CalculateSum(1, 2, 3));
        Console.WriteLine(CalculateSum(5, 10, 15, 20)); // Output: 50
        Console.WriteLine(CalculateSum());
    }
    public static int CalculateSum(params int[] number)
    {
        int sum = 0;

        foreach (int i in number)
        {
            sum += i;
        }

        return sum;
    }
}
}
