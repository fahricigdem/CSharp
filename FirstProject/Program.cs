using System;
namespace FirstProject
{
    class Program
    {        
        static void Main(string[] args)
        {
            var account1 = new BankAccount("Fahri", 1000);
            Console.WriteLine($"Account {account1.Number} was created for {account1.Owner} with {account1.Balance}.");



            var account2 = new BankAccount("Aysenur", 2000);
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance}.");


            account2.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account2.Balance);
            account2.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account2.Balance);


            Console.WriteLine(account2.GetAccountHistory());

            // Test that the initial balances must be positive.
            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }


            // Test for a negative balance.
            try
            {
                account2.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }


        }
    }
}
 