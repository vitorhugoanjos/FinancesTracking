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

        public double Amount { get; private set; }

        public User User { get; private set; }

        public Category Category { get; private set; }

        public DateTime Date { get; private set; }

        public Expense(User user, string comment, double amount, Category category, DateTime date)
        {
            Comment = comment;
            Amount = amount;
            User = user;
            Category = category;
            Date = date;

            try
            {
                User.UseMoney(amount);
            }
            catch (ArgumentOutOfRangeException) {
                throw new System.ArgumentOutOfRangeException("amount", "The amount can't be greater than the user's balance");
            }
            
        }

        public override string ToString()
        {
            return "[" + Category + "] " + Comment + " - " + Amount;
        }
    }
}
