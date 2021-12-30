using System;
namespace FirstProject
{
    class Program
    {        
        static void Main(string[] args)
        {
            //var account1 = new BankAccount("Fahri", 1000);
            //Console.WriteLine($"Account {account1.Number} was created for {account1.Owner} with {account1.Balance}.");



            BankAccount account2  = new("Aysenur", 3000);

            Console.WriteLine("BALANCE: " + account2.Balance);
            


            account2.MakeDeposit(100, DateTime.Now, "deposit1");
            account2.MakeDeposit(100, DateTime.Now, "deposit2");
            account2.MakeDeposit(100, DateTime.Now, "deposit3");
            account2.MakeWithdrawal(200, DateTime.Now, "withdrawal1");
            account2.MakeDeposit(100, DateTime.Now, "deposit4");
            account2.MakeDeposit(100, DateTime.Now, "deposit5");
            account2.MakeDeposit(100, DateTime.Now, "deposit6");


            try
            {
                account2.MakeDeposit(-200, DateTime.Now, "negative deposit");
            } catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("\n opps... Deposit cannot be made.");
            }


            Console.WriteLine("\nBALANCE: " + account2.Balance);


            //foreach (var item in account2.allTransactions) Console.WriteLine($"IN PROGRAM allTransactions: {item.Amount}, {item.Date}, {item.Notes}");

            account2.GetAccountHistory();










            //Console.WriteLine($"Account Number: {account2.Number}, Owner:  {account2.Owner}, Balance: {account2.Balance}.");


            //account2.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            //Console.WriteLine(account2.Balance);
            //account2.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            //Console.WriteLine(account2.Balance);


            //Console.WriteLine(account2.GetAccountHistory());

            // Test that the initial balances must be positive.
            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //    return;
            //}


            // Test for a negative balance.
            //try
            //{
            //    account2.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}


        }
    }
}
 