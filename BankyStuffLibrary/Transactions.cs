using System;
using Humanizer;

namespace BankyStuffLibrary
{
    public class Transaction
    {
        public decimal Amount { get; }
        public string AmountForHumans {
            get
            {
                return ((int)Amount).ToWords();
            }
        }
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