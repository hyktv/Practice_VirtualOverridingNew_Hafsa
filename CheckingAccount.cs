using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_VirtualOverridingNew_Hafsa
{
    internal class CheckingAccount : BankAccount
    {
        //feild, property, constructor
        public double overdraftFee;
        public double OverdraftFee { get; set; }

        public CheckingAccount(string name, double balance, double overdraftFee) : base(name, balance)
        {
            OverdraftFee = overdraftFee;
        }

        //methods
        public override bool Withdraw(double amount)
        {
            if (!base.Withdraw(amount))
            {
                Balance -= overdraftFee;
            }
            return true;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Overdraft Fee: {OverdraftFee}";
        }

    }
}
