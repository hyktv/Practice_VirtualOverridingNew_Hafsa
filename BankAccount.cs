using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_VirtualOverridingNew_Hafsa
{
    internal class BankAccount
    {
        //feilds
        public string name;
        public string accountNumber;
        public double balance;
        Random rand = new Random();

        //constructor and properties
        public BankAccount(string name, double balance)
        {
            Name = name;
            Balance = balance;
            AccountNumber = rand.Next(100000000, 1000000000).ToString();
        }

        public string Name { get; set; }
        public string AccountNumber { get; }
        public double Balance { get; protected set; }

        //methods
        public virtual bool Deposit(double amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool Withdraw (double amount)
        {
            if (amount >= 0 && balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType()} Name: {Name} - Account Number: {AccountNumber} - Balance: ${Balance}";
        }


    }
}
