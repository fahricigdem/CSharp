using System;

namespace FirstProject
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
            Console.WriteLine($"IN TRANSACTIONS: \t   this.Amount: {this.Amount}\t this.Date: {this.Date}\t this.Notes: {this.Notes}.");
        }
    }
}