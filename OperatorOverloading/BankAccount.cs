using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    internal class BankAccount
    {
        private double money;
        private string owner;

        public BankAccount(string owner, double money) 
        {
            this.owner = owner;
            this.money = money;
        }
        public double Money 
        {
            get 
            {
                return money;
            }
        }

        public string Owner 
        {
            get 
            { 
                return owner;
            }
        }

        public static BankAccount operator + (BankAccount bank1, BankAccount bank2) 
        { 
            double newAmountOfMoney = bank1.Money + bank2.Money;
            string newOwners = bank1.Owner + " + " + bank2.Owner;

            BankAccount newBankAccount = new BankAccount(newOwners, newAmountOfMoney);
            return newBankAccount;
        }

        public static BankAccount operator +(BankAccount bank1, double amount)
        {
            double newAmountOfMoney = bank1.Money + amount;
            string newOwners = bank1.Owner;

            BankAccount newBankAccount = new BankAccount(newOwners, newAmountOfMoney);
            return newBankAccount;
        }
    }
}
