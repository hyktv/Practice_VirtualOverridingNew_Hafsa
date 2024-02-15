using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_VirtualOverridingNew_Hafsa
{
    internal class SavingsAccount : BankAccount
    {
        //property, constructor
        public double Interest { get; set; }

        public SavingsAccount(string name, double balance, double interest) : base(name, balance)
        {
            Interest = interest;
        }

        //methods
        public override bool Deposit(double amount)
        {
            bool deposited = base.Deposit(amount);
            if (deposited)
            {
                Balance += amount * Interest;
            }
            return deposited;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Interest: {Interest}";
        }

    }
}
