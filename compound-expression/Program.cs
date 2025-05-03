using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UdemyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your exam score: ");
            int studentScore = int.Parse(Console.ReadLine());
            Console.Write("Did you submit the project? true/false: ");
            bool studentPass;
            bool isStudentGradeValid = bool.TryParse(Console.ReadLine(), out studentPass);

            if (!isStudentGradeValid)
            {
                Console.WriteLine("Invalid input! Please enter 'true' or 'false'.");
            }
            else if (studentScore >= 50 && studentPass)
            {
                Console.WriteLine("You passed the course!");
            }
            else
            {
                Console.WriteLine("You did not pass the course.");
            }

        }
    }
}
