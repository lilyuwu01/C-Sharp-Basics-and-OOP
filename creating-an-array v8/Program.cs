namespace creating_an_array_v8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] zipCodes = { "1702", "1720", "1714", "1718", "1700" };

            Console.Write("Enter Zip Code: ");
            string code = Console.ReadLine();

            bool isZipCodeFound = false;

            for (int i = 0; i < zipCodes.Length; i++) 
            {
                if (code == zipCodes[i]) 
                {
                   isZipCodeFound = true;
                    break;
                }
            
            }

            if (isZipCodeFound == true)
            {
                Console.WriteLine("We can deliever the package.");
            }
            else
            {
                Console.WriteLine("We cannot ship to this zip code.");
            }


        }
    }
}
