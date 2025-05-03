using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationApplication_OOP.PointsAndLines
{
    internal class User
    {

        public static int currentID;

        public int id;

        private string userName;
        private int passWord;

        public string Username
        {
            get  // get is like a read while set is write.
            { 
                return "The username is" + " " + userName;
            }
            //set 
            //{
            //    if (value.Length >= 4 && value.Length <= 10)
            //    {
            //        userName = value;
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Please enter a username with 4 to 10 characters.");
            //    }
                
            //}
        
        }

        public int Password 
        {
            //get 
            //{ 
            //    return passWord;
            //}
            set 
            {

                if (value >= 4 && value <= 10)
                {
                    passWord = value;
                }
                else
                {
                    Console.WriteLine("Please enter a password with 4 to 10 characters.");
                }
            }
        
        }

        public User() 
        {
            currentID++;
            id = currentID;
        }

        public User(string userName) // this is a constructor
        {
            currentID++;
            id = currentID;
            this.userName = userName;
        }
    }
}
