using System.Globalization;

namespace creating_an_array_v9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of students in your class: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            string nameOfStudents;
            double finalScore = 0;
            double highestGrade = 0;
            double averageGrade = 0;
            string highestGradeName = "";

            string[] studentNames = new string[numberOfStudents];
            double[] grade = new double[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Enter Name of Student {i + 1}: ");
                nameOfStudents = Console.ReadLine();
                studentNames[i] = nameOfStudents;
                Console.Write($"Enter Final Score of Student {i + 1}: ");
                finalScore = double.Parse(Console.ReadLine());
                grade[i] = finalScore;
                averageGrade += finalScore;

                if (finalScore > highestGrade) 
                { 
                    highestGrade = finalScore;
                    highestGradeName = nameOfStudents;
                }
            }

            averageGrade /= numberOfStudents;
            Console.WriteLine($"The average grade of the class is {averageGrade}");
            Console.WriteLine($"The highest grade of the class is {highestGrade} and its from {highestGradeName}");




        }
    }
}
