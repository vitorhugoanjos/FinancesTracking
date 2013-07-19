using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Model
{
    public class Expense
    {

        public string Comment { get; private set; }

        public decimal Amount { get; private set; }

        public User User { get; private set; }

        public Category Category { get; private set; }

        public DateTime Date { get; private set; }

        public Expense(User user, string comment, decimal amount, Category category, DateTime date)
        {
            Comment = comment;
            Amount = amount;
            User = user;
            Category = category;
            Date = date;
            User.WithdrawCash(amount);
            
        }

        public override string ToString()
        {
            return "[" + Category + "] " + Comment + " - " + Amount + " euros.";
        }
    }
}
