namespace Practice_VirtualOverridingNew_Hafsa
{
    //hafsa
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();

            //instances
            CheckingAccount checking = new CheckingAccount("Checking", 0, 1);
            SavingsAccount savings = new SavingsAccount("Savings", 0, 2);
            RetirementAccount retirement = new RetirementAccount("Retirement", 0, 3);

            accounts.Add(checking);
            accounts.Add(savings);
            accounts.Add(retirement);


            //deposit 500
            foreach (BankAccount account in accounts)
            {
                account.Deposit(500);
            }

            //deposit -50000
            foreach (BankAccount account in accounts)
            {
                account.Deposit(-50000);
            }

            //withdraw 200
            foreach (BankAccount account in accounts)
            {
                account.Withdraw(200);
            }

            //withdraw -200000
            foreach (BankAccount account in accounts)
            {
                account.Withdraw(-200000);
            }

            //overdraw each account
            foreach (BankAccount account in accounts)
            {
                account.Withdraw(100000);
            }

            //sisplay results
            foreach (BankAccount account in accounts)
            {
                Console.WriteLine(account.ToString());
            }

        }//main


    }//class


}//namespavce