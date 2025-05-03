using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_practice
{
    internal class student
    {
        private string nameStudent;
        private int ageStudent;
        private double finalGrade;
        // auto implemented
        public string lastName {  get; private set; }

        public student(string nameStudent, string lastName, int ageStudent, double finalGrade)
        {
            this.nameStudent = nameStudent;
            this.lastName = lastName;
            this.ageStudent = ageStudent;
            this.finalGrade = finalGrade;
        }

        public student(string nameStudent, string lastName ,int ageStudent)
            : this(nameStudent, lastName ,ageStudent, 0)
        {

        }

        public void SayHello()
        {
            Console.WriteLine($"Hello from {nameStudent}");
        }

        public string Name
        {
            get 
            {
                if (ageStudent >= 18)
                {
                    return nameStudent;
                }
                else
                {
                    return "this student is too young.";
                }
            }

            set 
            {
                if (value != "")
                {
                    nameStudent = value;
                }
            }
        }

        public int Age
        {
            get
            {
                if (ageStudent >= 18)
                {
                    return ageStudent;
                }
                else
                {
                    return -1;
                }
            }

            set 
            {
                if (value != 0)
                {
                    ageStudent = value;
                }
            }
        }

        public double FinalGrade
        {
            get
            {
                return finalGrade;
            }
            set
            {
                if (value < 65)
                {
                    value = 65;
                }
                else if (value > 100)
                {
                    value = 100;
                }

                finalGrade = value;
            }
        }

      
    }
}
